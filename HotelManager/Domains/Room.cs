using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Domains
{
    public class Room
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; } = 0;
        public Room()
        {
            
        }

        public Room(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
