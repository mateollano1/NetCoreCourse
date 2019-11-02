using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGI.WebApp.Models;

namespace TGI.WebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }
        public ComputerStore(TGLContext context)
        {
            Context = context;
        }
        public List<Computer> GetStudents()
        {
            return Context.Computer.ToList();
        }
        internal void addComputer(Computer computer)
        {
            Context.Computer.Add(computer);
            Context.SaveChanges();
        }
    }
}
