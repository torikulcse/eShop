﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eShop.Areas.Admin.Models
{
    public class Catagory
    {
        private Catagory x;
        public Catagory()
        {

        }
        public Catagory(Catagory x)
        {
            this.x = x;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Sorting { get; set; }

    }
}