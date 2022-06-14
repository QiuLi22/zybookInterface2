using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zybookInterface
{
    public interface IPerson
    {//qiu li 06-14-2022
        public string Name { get; set; }
        public void SayHello();
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
