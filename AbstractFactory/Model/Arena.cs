using AbstractFactory._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model
{
    public class Arena : IDiesel
    {
        public string GetName()
        {
            return "This is Arena";
        }
    }
}
