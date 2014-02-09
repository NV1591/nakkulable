using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChaiShai.Model
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Required, StringLength(100000), Display(Name = "Category Description")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Products> Products { get; set;}
    }
}