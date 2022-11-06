﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cozma_Laurentiu_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }
       
        public string FullName { get { return FirstName + " " + LastName; } }

        public ICollection<Book>? Books { get; set; }

    }
}
