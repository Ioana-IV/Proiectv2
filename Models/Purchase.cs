using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ivanov_Ioana_Proiect.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ivanov_Ioana_Proiect.Models
{
    public class Purchase
    {
        public int ID { get; set; }

        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime PurchaseDate { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(-9999, 9999)]
        [Required]
        public decimal Price { get; set; }

        [Display(Name = "Payment Type")]
        [Required]
        public int PaymentTypeID { get; set; }
        public virtual PaymentType PaymentType { get; set; }  //Navigation property

        [Display(Name = "Payee")]
        [Required]
        public int PayeeID { get; set; }
        public Payee Payee { get; set; } //Navigation property

        [Display(Name = "Purchase Category")]
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; } //Navigation property

        [Required]
        public string Details { get; set; }


    }
}
