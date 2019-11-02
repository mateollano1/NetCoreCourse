using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TGI.WebApp.Models
{
    public class Computer
    {
        public Computer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public String Brand  { get; set; }
        public String Model { get; set; }
        public String  Cpu { get; set; }
        public String  Ram { get; set; }
    }
}
