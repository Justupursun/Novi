﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novi.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsArticleOfTheMonth { get; set; }
        public bool Hireable { get; set; }

        //[Required(ErrorMessage = "Please enter your startdate")]
        //[Display(Name = "Hire From")]
        //[StringLength(50)]
        public string HireFrom { get; set; }


        public string HireTill { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
