﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace TGI.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public IConfiguration Configuration { get; set; }
        public IndexModel(IConfiguration configuration)
        {
            Configuration = configuration;


        }
        public void OnGet()
        {

        }
    }
}
