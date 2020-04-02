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

        Vector2 centre;

        public float Width { get => texture.width; }
        public float Height { get => texture.height; }

        public void Load(string path)
        {
            texture = LoadTexture(path);
            centre = new Vector2(Width / 2, Height / 2);
        }

        public override void OnDraw()
        {
            DrawTexturePro(texture, new rl.Rectangle(0,0,Width,Height), new rl.Rectangle(globalPosition.x,globalPosition.y,Width,Height),Conversions.ConvertVector(centre),globalRotation,rl.Color.WHITE);
        }
    }
}
