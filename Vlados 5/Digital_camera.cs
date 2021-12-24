using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlados_5
{
    class Digital_camera: Сamera
    {
        int screen_size;
        public Digital_camera(int screen_size, string name, int number_of_pixels): base(name, number_of_pixels)
        {
            this.screen_size = screen_size;
        }

        public int get_screen_size()
        {
            return screen_size;
        }
    }
}
