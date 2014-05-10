using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Dazzer
{
	abstract class GenericObject
    {
        public float scale = 1;
		public Vector2 position;
		private Texture2D texture;
		private SoundEffect soundEffect;

        public abstract void Update();
		public GenericObject(Texture2D texture, SoundEffect soundEffect)
		{
			this.texture = texture;
			this.soundEffect = soundEffect;
		}

		public GenericObject GetTexture
		{
			get { texture; }
			set;
		}

		public GenericObject GetSoundEffect
		{
			get { soundEffect; }
			set;
		}

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
