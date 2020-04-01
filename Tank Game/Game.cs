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
    class Game
    {
        SceneObject tankObject = new SceneObject();
        SpriteObject tankSprite = new SpriteObject();

        public void Init()
        {
            SetTargetFPS(60);

            tankSprite.Load(@"..\Sprites\PNG\Tanks\TankBlue.png");
            tankSprite.SetRotate(Conversions.DegToRad(90));
            tankSprite.SetPosition(-tankSprite.Width / 2, tankSprite.Height / 2);
        }

        public void Update()
        {
            
        }

        public void Draw()
        {
            tankSprite.Draw();
        }
    }
}
