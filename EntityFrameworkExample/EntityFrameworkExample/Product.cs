using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkExample
{
    public class Product
    {
        //[Required(ErrorMessage = "Please enter value..")]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter value..")]
        //[StringLength(50, ErrorMessage = "please enter a value of maximum 50..")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Please enter value..")]
        public decimal UnitPrime { get; set; }
        //[Required(ErrorMessage = "Please enter value..")]
        public int StockAmount { get; set; }

    }
}
