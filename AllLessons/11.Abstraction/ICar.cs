using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Abstraction
{
    // what the current object can do
    public interface IDrivable
    {
        public void Start();
        public void Accelerate();
        public void Brake();
        public int Speed { get; set; }
    }
}
