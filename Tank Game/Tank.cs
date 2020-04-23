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
    class Tank : SceneObject
    {
        SpriteObject sprite = new SpriteObject("TankSprite");
        public SceneObject turret = new SceneObject("Turret");
        SpriteObject turretSprite = new SpriteObject("TurretSprite");

        rl.Texture2D bulletTexture;

        public Controls controls = new Controls();

        public Tank() : base()
        {
            AddChildren();
        }

        public Tank(string _name) : base(_name)
        {
            AddChildren();
        }

        void AddChildren()
        {
            AddChild(sprite);
            AddChild(turret);
            turret.AddChild(turretSprite);
        }

        void CreateCollider()
        {
            localBox.min = globalPosition - sprite.origin;
            localBox.max = globalPosition + sprite.origin;
        }

        //Load in sprites, including the bullet sprite
        public void Load(string tankPath, string turretPath, string bulletPath)
        {
            sprite.Load(tankPath);
            turretSprite.Load(turretPath);
            turretSprite.origin.y = 40;
            bulletTexture = LoadTexture(bulletPath);
            CreateCollider();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            if (IsKeyDown(controls.left))
            {
                Rotate(-2);
            }
            if (IsKeyDown(controls.right))
            {
                Rotate(2);
            }

            if (IsKeyDown(controls.foreward))
            {
                MoveForeward(2);
                if (Collides() || !globalBox.Overlaps(parent.GlobalBox))
                {
                    MoveForeward(-2);
                }
            }
            if (IsKeyDown(controls.back))
            {
                MoveForeward(-2);
                if (Collides() || !globalBox.Overlaps(parent.GlobalBox))
                {
                    MoveForeward(2);
                }
            }

            if (IsKeyDown(controls.turretLeft))
            {
                turret.Rotate(-4);
            }
            if (IsKeyDown(controls.turretRight))
            {
                turret.Rotate(4);
            }

            if (IsKeyPressed(controls.shoot))
            {
                //Create bullet with a reference to its sprite
                Bullet bullet = new Bullet(ref bulletTexture, "Bullet");
                bullet.SetPosition(globalPosition.x, globalPosition.y);
                bullet.SetRotate(turret.GlobalRotation);
                //Move bullet to end of barrel
                bullet.MoveForeward(40);
                //Add bullet as a child of the world
                parent.AddChild(bullet);
            }
        }

        //Returns true if the tank is colliding with any other object
        bool Collides()
        {
            foreach (var item in parent.Children)
            {
                if (item != this && globalBox.Overlaps(item.GlobalBox))
                {
                    return true;
                }
            }
            return false;
        }

        public override void OnDraw()
        {
            base.OnDraw();
        }
    }
}
