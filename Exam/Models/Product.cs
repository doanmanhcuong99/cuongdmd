using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierlID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string UnitOnOder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
