using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zybookInterface
{
    public class Employee : IPerson
    {//qiu li 06-14-2022
        public string Name { get; set; } = "John Doe";
        public string Title { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hi! I'm a {Title}.");
        }
    }
}
