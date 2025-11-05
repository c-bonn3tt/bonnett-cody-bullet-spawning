// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Bullet[] bullets = new Bullet[100];
        int bulletIndex = 0;

        OptimusPrime[] optimusPrime = new OptimusPrime[5];
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Bullet Spawning");
            Window.SetSize(600, 600);
            Window.TargetFPS = 120;

            for (int i = 0; i < 20; i++)
            {

            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            int ammo = 0;

            if (Input.IsMouseButtonPressed(MouseInput.Left)) SpawnBullet();

            //call update on all bullets
            for (int i = 0; i < bullets.Length; i++)
            {
                //skip the bullet if it hasnt spawned yet
                if (bullets[i] == null)
                {
                    ammo++;
                    continue;
                }
                bullets[i].Update();
                //Text.Draw($"Ammo; {ammo}") = new Vector2(10, 10);
               
               
            }

            if (Input.IsMouseButtonPressed(MouseInput.Right))
            {
                bullets = new Bullet[20];
            }
        }

        void SpawnBullet()
        {

            if (bullets[bulletIndex] != null) return;
            
            Bullet bullet = new Bullet();

            Vector2 centerScreen = Window.Size / 2.0f;

            bullet.position = centerScreen;

            Vector2 centerToMouse = Input.GetMousePosition() - centerScreen;
            bullet.velocity = Vector2.Normalize(centerToMouse);

            bullets[bulletIndex] = bullet;
            bulletIndex++;

            if (bulletIndex >= bullets.Length) bulletIndex = 0;
        }
    }

}
