using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Configuration
{
    public static class AppConfig
    {
        public static string ConnectionString { get; } = "Data Source=\"ftl.kherson.ua, 14333\";Initial Catalog=Hotel;User ID=hotel;Password=Hotel123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
    }
}
