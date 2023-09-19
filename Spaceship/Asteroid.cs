using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Spaceship
{
    internal class Asteroid
    {
        public Vector2 position = new Vector2 (600, 300);
        public int speed;
        public int radius = 59;
        

        // Asteroid Constructor
        public Asteroid(int newSpeed)
        {
            Random rand = new Random();
            speed = newSpeed;
            position = new Vector2(1280 + radius, rand.Next(0, 721));
        }

        // Asteroid Update
        public void astroidUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
