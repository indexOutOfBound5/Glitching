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
    class Player : GenericObject
    {
        float playerRotation;
        Vector2 playerVelocity;
        float tangentialVelocity = 1;
        float friction = 0.1f;
        Texture2D pTexture;
        Vector2 origin;

        KeyboardState previousKey;

		public Player(ContentManager content)
        {
            pTexture = content.Load<Texture2D>("Rock");
            position = new Vector2();
            scale = 0.3f;
            origin = new Vector2(pTexture.Width * scale, pTexture.Height * scale);
        }

		public void Update()
        {
            position += playerVelocity;

            playerVelocity.Y += 0.1f;

            PCInput();
        }

        public void PCInput()
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Space))
            {
                playerVelocity.Y = -tangentialVelocity * 2f;
            }
            else if (position.Y > 640)
            {
                playerVelocity = Vector2.Zero;
            }

            if (keyboard.IsKeyDown(Keys.Right) && previousKey.IsKeyUp(Keys.Right))
            {
                playerVelocity.X += 0.9f;
            }
            else
            {
                playerVelocity.X -= friction;
            }

            if (keyboard.IsKeyDown(Keys.Left) && previousKey.IsKeyUp(Keys.Left))
            {
                playerVelocity.X -= 0.9f;
            }
            else
            {
                playerVelocity.X += friction;
            }

            previousKey = keyboard;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(pTexture, position, new Rectangle(0, 0, 50, 90), Color.Red, playerRotation, origin, scale, SpriteEffects.None, 0.0f);
            spriteBatch.End();
        }
    }
}
