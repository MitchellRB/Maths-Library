using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }

        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour = 0b_0000_0000_0000_0000_0000_0000_0000_0000;
            colour |= (uint)red << 24;
            colour |= (uint)green << 16;
            colour |= (uint)blue << 8;
            colour |= alpha;
        }

        public byte GetRed()
        {
            return 0;
        }
        public void SetRed(byte red)
        {

        }

        public byte GetGreen()
        {
            return 0;
        }
        public void SetGreen(byte green)
        {

        }

        public byte GetBlue()
        {
            return 0;
        }
        public void SetBlue(byte green)
        {

        }

        public byte GetAlpha()
        {
            return 0;
        }
        public void SetAlpha(byte green)
        {

        }
    }
}
