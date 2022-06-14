using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zybookInterface
{
    public interface ILearner : IPerson
    {//qiu li 06-14-2022
        void Study(string topic);
    }

}
