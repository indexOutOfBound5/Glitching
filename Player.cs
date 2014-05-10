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

		public Player(ContentManager content)
        {
            pTexture = content.Load<Texture2D>("Player");
            position = new Vector2();
            scale = 0.3f;
            origin = new Vector2(pTexture.Width * scale, pTexture.Height * scale);
        }

		public void Update()
        {
            position += playerVelocity;
        }

        public void PCInput(Keys UpDir, Keys downDir, Keys leftDir, Keys rightDir)
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(rightDir))
            {
                playerRotation += 0.08f;
            }

            if (keyboard.IsKeyDown(leftDir))
            {
                playerRotation -= 0.08f;
            }

            if (keyboard.IsKeyDown(UpDir))
            {
                playerVelocity.X = (float)Math.Cos(playerRotation) * tangentialVelocity * 2f;
                playerVelocity.Y = (float)Math.Sin(playerRotation) * tangentialVelocity * 2f;
            }

            else if (playerVelocity != Vector2.Zero)
            {
                float i = playerVelocity.X;
                float j = playerVelocity.Y;

                playerVelocity.X -= friction * i;
                playerVelocity.Y -= friction * j;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(pTexture, position, null, Color.Red, playerRotation, origin, scale, SpriteEffects.None, 0.0f);
            spriteBatch.End();
        }
    }
}
