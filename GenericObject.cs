using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Dazzer
{
    abstract class GenericObject
    {
        public Vector2 position;
        public float scale = 1;
        public Texture2D texture;

        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
