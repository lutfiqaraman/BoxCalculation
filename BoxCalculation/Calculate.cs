using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxCalculation
{
    public class Calculate
    {
        int height;
        int width;
        int length;

        public Calculate(int h, int w, int l)
        {
            height = h;
            width  = w;
            length = l;
        }

        public int[] Get_size()
        {
            int Surface = (2 * length * width) + (2 * length * height) + (2 * width * height);
            int Volume  = height * length * width;

            int[] values = new int[] { Surface, Volume };

            return values;
        }

    }
}
