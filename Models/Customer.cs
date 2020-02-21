using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShop.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using WebShop.Controllers;

namespace WebShop.Models
{

    public enum Gender
    {
        [Display(Name = "Male")]
        Male,

        [Display(Name = "Female")]
        Female
    }
    public class Customer
        {
       

        public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            [Display(Name = "Birth Date")]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }

            [Display(Name = "Gender")]
            public Gender CustomerGender { get; set; }
            public List<Order> Orders { get; set; }
        }
    }
