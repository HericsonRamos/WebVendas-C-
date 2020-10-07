﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebVendas.Models;

namespace WebVendas.Controllers
{
    public class DepartmentsController : Controller
    {
        List<Department> list = new List<Department>();
        public IActionResult Index()
        {
            this.list.Add(new Department { Id = 1, Name = "Eletronics" });
            this.list.Add(new Department { Id = 2, Name = "Fashion" });
            this.list.Add(new Department { Id = 3, Name = "Cars" });
            this.list.Add(new Department { Id = 4, Name = "Motorcyle" });
            return View(this.list);
        }

        private IActionResult Delete(int id)
        {

            this.list.Remove(new Department { Id = id } );
            
            return View(this.list); 
        }
    }
}
