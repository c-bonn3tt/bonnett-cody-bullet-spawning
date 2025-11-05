using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class OptimusPrime
    {

        Vector2 position;
        Texture2D texture;
        Vector2 Size;

        int hp = 0;
        public void SetUp()
        {
            float radius = Window.Size.X / 2.0f;
            float angle = Random.Float(0.0f, 2 * MathF.PI);

            position.X = radius * MathF.Cos(angle);
            position.Y = radius * MathF.Sin(angle);

            texture = Graphics.LoadTexture("Texture/evil-optimus.png");


            hp = 3;
        }

        public void Update()
        {
           // leftEdge = position.X;
           // rightEdge = position.Y
            Graphics.Rotation = 0.0f;
            Graphics.Scale = 1.0f;
            Graphics.Draw(texture, position);
        }
    }
}
