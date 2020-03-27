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
    class SpriteObject : SceneObject
    {

        rl.Texture2D texture = new rl.Texture2D();
        rl.Image image = new rl.Image();

        public float Width { get => texture.width; }
        public float Height { get => texture.height; }

        public void Load(string path)
        {
            image = LoadImage(path);
            texture = LoadTextureFromImage(image);
        }
    }
}
