using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySale
    {
        private int id;
        private int salesProductId;
        private string salesProductName;
        private string salesProductCompany;
        private int salesQuantitySold;
        private int salesCustomerId;
        private int salesTotalEarning;

        public int Id { get => id; set => id = value; }
        public int SalesProductId { get => salesProductId; set => salesProductId = value; }
        public string SalesProductName { get => salesProductName; set => salesProductName = value; }
        public string SalesProductCompany { get => salesProductCompany; set => salesProductCompany = value; }
        public int SalesQuantitySold { get => salesQuantitySold; set => salesQuantitySold = value; }
        public int SalesCustomerId { get => salesCustomerId; set => salesCustomerId = value; }
        public int SalesTotalEarning { get => salesTotalEarning; set => salesTotalEarning = value; }
    }
}
