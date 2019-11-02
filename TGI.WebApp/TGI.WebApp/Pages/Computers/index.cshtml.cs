using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGI.WebApp.Data;
using TGI.WebApp.Models;

namespace TGI.WebApp.Pages.Computers
{
    public class indexModel : PageModel
    {
        public ComputerStore ComputerStore { get; set; }
        public List<Computer> Computers { get; set; }
        public indexModel(ComputerStore computerStore)
        {
            ComputerStore = computerStore;
            Computers = computerStore.GetStudents();

        }
        public void OnGet()
        {

        }
    }
}