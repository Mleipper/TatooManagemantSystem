using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TatooManagemantSystem.Models.DataBaseModels
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        //List of components-- A Service is made up of several peices of stock 
        //StockId 
        //AmountUsed
        //
    }
}
