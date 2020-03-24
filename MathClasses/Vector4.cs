using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }

        public static Vector4 operator +(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        public static Vector4 operator -(Vector4 v1,Vector4 v2)
        {
            return new Vector4(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        public static Vector4 operator *(Vector4 v, float f)
        {
            return new Vector4(v.x * f, v.y * f, v.z * f, v.w * f);
        }

        public static Vector4 operator *(float f, Vector4 v)
        {
            return new Vector4(v.x * f, v.y * f, v.z * f, v.w * f);
        }

        public float Dot(Vector4 other)
        {
            return x * other.x + y * other.y + z * other.z + w * other.w;
        }

        public Vector4 Cross(Vector4 other)
        {
            Vector3 v3a = new Vector3(x, y, z);
            Vector3 v3b = new Vector3(other.x, other.y, other.z);
            Vector3 v3c = v3a.Cross(v3b);
            return new Vector4(v3c.x, v3c.y, v3c.z, 0);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }
    }
}
