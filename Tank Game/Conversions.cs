using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;
using rl = Raylib;
using static Raylib.Raylib;

namespace Tank_Game
{

    class Conversions
    {
        //Converting custom library vectors to raylib equivalents
        public static rl.Vector2 ConvertVector(Vector2 vector)
        {
            return new rl.Vector2(vector.x, vector.y);
        }

        public static rl.Vector3 ConvertVector(Vector3 vector)
        {
            return new rl.Vector3(vector.x, vector.y, vector.z);
        }

        public static rl.Vector4 ConvertVector(Vector4 vector)
        {
            return new rl.Vector4(vector.x, vector.y, vector.z, vector.w);
        }
    }
}
