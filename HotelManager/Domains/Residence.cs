using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Domains
{
    public class Residence
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdRoom { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public int CountDays { get; set; } = 0;
        public Residence()
        {
            
        }
        public Residence(int idClient, int idRoom, DateTime startDate, DateTime endDate, int countDays)
        {
            IdClient = idClient;
            IdRoom = idRoom;
            StartDate = startDate;
            EndDate = endDate;
            CountDays = countDays;
        }
    }
}
