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
    class Program
    {
        public static bool debug = true;

        public static Game game = new Game();

        static void Main(string[] args)
        {
            InitWindow(640 * 2, 480 * 2, "Tank game");

            game.Init();

            SetTargetFPS(60);

            while (!WindowShouldClose())
            {
                game.Update();

                BeginDrawing();
                ClearBackground(rl.Color.WHITE);

                game.Draw();

                EndDrawing();
            }

            CloseWindow();
        }
    }
}
