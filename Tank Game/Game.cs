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
        SpriteObject tankObject = new SpriteObject();

        SpriteObject turretObject = new SpriteObject();

        public void Init()
        {
            SetTargetFPS(60);

            tankObject.Load(@"..\..\Sprites\PNG\Tanks\TankBlue.png");

            turretObject.Load(@"..\..\Sprites\PNG\Tanks\BarrelBlue");

        }

        public void Update()
        {

        }

        public void Draw()
        {
            tankObject.Draw();
        }
    }
}
