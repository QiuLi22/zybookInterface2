using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zybookInterface
{
    class Student : ILearner
    {//qiu li 06-14-2022
        public string Name { get; set; } = "John Doe";

        public void SayHello()
        {
            Console.WriteLine($"Hi! I'm {Name}!");
        }

        public void Study(string topic)
        {
            Console.WriteLine($"I'm studying {topic}.");
        }
    }
}
