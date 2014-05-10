using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Dazzer
{
    class Grid
    {
        int[,] gridMap;
        Texture2D texture;
<<<<<<< HEAD
        int width = 100;
        int height = 100;
=======
        int width = 39;
        int height = 40;
>>>>>>> 5371fc9aa661729189fc21af1ab6132ed0fc513b

        public Grid(ContentManager content)
        {
            gridMap = new int[width, height];
            texture = content.Load<Texture2D>("Rock");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            for (int x = 3; x < width - 3; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    spriteBatch.Draw(texture, new Rectangle(x * 35, y * 35, 30, 30), Color.White);
                }
            }
            spriteBatch.End();
        }
    }
}
