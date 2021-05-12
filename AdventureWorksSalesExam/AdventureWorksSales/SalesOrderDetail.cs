using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales
{
    class SalesOrderDetail
    {
        public int SalesOrderID { get; set; }
        public int OrderQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
        public int SalesOrderDetailID { get; set; }
        public string ProductName { get; set; }
        public int ProductID { get; set; }


        public override string ToString()
        {
            return $"Order: {OrderQty}, Product: {ProductName},             Unit Price: {UnitPrice},    Line Total: {LineTotal}";
        }
    }
}
