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

        SceneObject turretObject = new SceneObject();
        SpriteObject turretSprite = new SpriteObject();

        public void Init()
        {
            SetTargetFPS(60);

            tankSprite.Load(@"..\..\Sprites\PNG\Tanks\TankBlue.png");

            tankObject.SetPosition(300, 300);
            tankObject.AddChild(tankSprite);

            turretSprite.Load(@"..\..\Sprites\PNG\Tanks\BarrelBlue");

            tankObject.AddChild(turretObject);
            turretObject.AddChild(turretSprite);

            turretObject.UpdateTransform();

        }

        public void Update()
        {
            tankObject.Rotate(1);
        }

        public void Draw()
        {
            tankObject.Draw();
        }
    }
}
