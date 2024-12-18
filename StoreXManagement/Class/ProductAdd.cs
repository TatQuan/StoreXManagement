using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreXManagement
{
    public class ProductAdd
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
        public int QuantityAdd { get; set; }
        public decimal TotalAmount { get; set; }

        public ProductAdd() { }
        public ProductAdd(int proID, string proName, int quantityAdd, decimal totalAmount)
        {
            ProID = proID;
            ProName = proName;
            QuantityAdd = quantityAdd;
            TotalAmount = totalAmount;
        }
    }
}
