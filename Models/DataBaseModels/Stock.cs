using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TatooManagemantSystem.Models.DataBaseModels
{
    public class Stock
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int LowStockQuantity { get; set;  }

        public string Uri { get; set; }

        public string Category { get; set; }

        public DateTime LastOrderDate { get; set; }

        public DateTime LastModified { get; set; }


    }
}
