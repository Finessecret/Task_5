using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlados_5
{
    abstract class Сamera: IDevice
    {
        string name;

        int number_of_pixels;

        public Сamera(string name, int number_of_pixels)
        {
            this.name = name;
            this.number_of_pixels = number_of_pixels;
        }

        public string get_name()
        {
            return name;
        }

        public int get_number_of_pixels()
        {
            return number_of_pixels;
        }

        public string set_name()
        {
            return name;
        }

        public int set_number_of_pixels()
        {
            return number_of_pixels;
        }

        public bool Power { get; set; }

        public void Power_off()
        {
            Power = false;
        }

        public void Power_on()
        {
            Power = true;
        }
    }
}
