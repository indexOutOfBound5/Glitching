using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Dazzer
{
	public class GenericObject
    {
        public float scale = 1;
		public Vector2 position;
		public Texture2D texture;
		public SoundEffect soundEffect;

        public void Update()
		{
		}

		public GenericObject(Texture2D texture)
		{
			this.texture = texture;
		}

		public GenericObject(): base()
		{

		}

		public Texture2D GetTexture
		{
			get { return texture; }
			set{ }
		}

		public SoundEffect GetSoundEffect
		{
			get { return soundEffect; }
			set{ }
		}

        public void Draw(SpriteBatch spriteBatch)
		{
		}
    }
}
