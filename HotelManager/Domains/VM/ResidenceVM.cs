using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Domains.VM
{
    public class ResidenceVM
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = String.Empty;
        public string RoomName { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CountDays { get; set; } = 0;
        public decimal RoomPrice { get; set; } = 0;
        public decimal TotalPrice { get; set; } = 0;
        public ResidenceVM()
        {
            
        }
        public ResidenceVM(int id, string clientName, string roomName, DateTime startDate, DateTime endDate, int countDays, decimal roomPrice, decimal totalPrice)
        {
            Id = id;
            ClientName = clientName;
            RoomName = roomName;
            StartDate = startDate;
            EndDate = endDate;
            CountDays = countDays;
            RoomPrice = roomPrice;
            TotalPrice = totalPrice;
        }
    }
}
