using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo____DIP
{
    public class Switch
    {
        private Lamp lamp;
        public Switch(Lamp device)
        {
            this.lamp = device;
        }
        public void Press()
        {
            lamp.Operate();
        }
    }
}
