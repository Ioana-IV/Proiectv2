using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Category")]
        [RegularExpression(@"^[a-zA-Z0-9_.-]+$", ErrorMessage = "Please only use letter, numbers, - (dash), _ underscore and . point !"), Required, StringLength(200, MinimumLength = 3)]
        public string CategoryName { get; set; }

    }
}
