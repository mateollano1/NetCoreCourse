﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TGI.WebApp.Data;
using TGI.WebApp.Models;

namespace TGI.WebApp.Pages.Students
{
    public class EditModel : PageModel
    {
        public StudentStore StudentStore { get; set; }
        public EditModel(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }
        [BindProperty]
        public Student Student { get; set; }
        public void OnGet(Guid id)
        {
            Student = StudentStore.GetStudentById(id);
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            StudentStore.EditStudent(Student);
            return RedirectToPage("./Index");
        }
    }
}