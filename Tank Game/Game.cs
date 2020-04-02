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

            tankObject.SetPosition(350, 300);
            tankObject.AddChild(tankSprite);

            turretSprite.Load(@"..\..\Sprites\PNG\Tanks\BarrelBlue.png");

            tankSprite.UpdateTransform();

            tankObject.AddChild(turretObject);
            turretObject.AddChild(turretSprite);

            turretSprite.origin.y = 40;

            turretObject.UpdateTransform();

        }

        public void Update()
        {
            if (IsKeyDown(rl.KeyboardKey.KEY_A))
            {
                tankObject.Rotate(-2);
            }
            if (IsKeyDown(rl.KeyboardKey.KEY_D))
            {
                tankObject.Rotate(2);
            }

            if (IsKeyDown(rl.KeyboardKey.KEY_W))
            {
                tankObject.MoveForeward(1);
            }
            if (IsKeyDown(rl.KeyboardKey.KEY_S))
            {
                tankObject.MoveForeward(-1);
            }

            if (IsKeyDown(rl.KeyboardKey.KEY_Q))
            {
                turretObject.Rotate(-2);
            }
            if (IsKeyDown(rl.KeyboardKey.KEY_E))
            {
                turretObject.Rotate(2);
            }
        }

        public void Draw()
        {
            tankObject.Draw();
        }
    }
}
