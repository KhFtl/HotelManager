using HotelManager.DAL;
using HotelManager.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class RoomForm : Form
    {
        private readonly RoomDb _roomDb;
        private bool _isRefreshing = false;

        public RoomForm()
        {
            InitializeComponent();
            _roomDb = new RoomDb();
            // subscribe to RowValidated so insertion happens when user finishes editing/adding a row
            dataGridView1.RowValidated += dataGridView1_RowValidated;
            this.FillTable();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTable()
        {
            _isRefreshing = true;
            List<Room>? rooms = _roomDb.GetAllRooms();
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.Clear();
            }
            if (rooms != null)
            {
                int i = 0;
                foreach (var room in rooms)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["Id"].Value = room.Id;
                    dataGridView1.Rows[i].Cells["NameRoom"].Value = room.Name;
                    dataGridView1.Rows[i].Cells["Price"].Value = room.Price;
                    i++;
                }
            }
            _isRefreshing = false;
        }

        private void dataGridView1_RowValidated(object? sender, DataGridViewCellEventArgs e)
        {
            if (_isRefreshing)
                return;

            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // ignore new row template
            if (row.IsNewRow)
                return;

            // read values
            var nameObj = row.Cells["NameRoom"].Value;
            var priceObj = row.Cells["Price"].Value;

            string name = nameObj?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(name))
            {
                // simple validation: name required
                MessageBox.Show("Name is required", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceObj?.ToString(), out decimal price))
            {
                MessageBox.Show("Invalid price", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check Id: if exists -> update, otherwise -> insert
            var idVal = row.Cells["Id"].Value;
            if (idVal != null && int.TryParse(idVal.ToString(), out int existingId) && existingId > 0)
            {
                var roomToUpdate = new Room(name, price) { Id = existingId };
                try
                {
                    bool updated = _roomDb.UpdateRoom(roomToUpdate);
                    if (!updated)
                    {
                        MessageBox.Show("Failed to update room in database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // no UI modification here — grid already shows edited values
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // Insert new row (existing behavior)
            var room = new Room(name, price);
            bool added;
            try
            {
                added = _roomDb.AddRoom(room);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (added)
            {
                // DO NOT modify rows synchronously inside RowValidated (throws InvalidOperationException).
                // Defer UI changes until after the current event finishes by scheduling via BeginInvoke.
                // Keep _isRefreshing guard to avoid re-entry.
                string addedName = name;
                string addedPriceString = price.ToString();
                this.BeginInvoke(new Action(() =>
                {
                    _isRefreshing = true;
                    FillTable(); // safe now — executed after handler returns
                    // best-effort: select newly added row
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (r.IsNewRow) continue;
                        var rn = r.Cells["NameRoom"].Value?.ToString();
                        var rp = r.Cells["Price"].Value?.ToString();
                        if (rn == addedName && rp == addedPriceString)
                        {
                            dataGridView1.CurrentCell = r.Cells["NameRoom"];
                            break;
                        }
                    }
                    _isRefreshing = false;
                }));
            }
            else
            {
                MessageBox.Show("Failed to add room to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.FillTable();
        }
    }
}
