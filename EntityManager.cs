using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace Dazzer
{
	public class EntityManager
	{
		static public int entities;

		public EntityManager ()
		{

		}

		public GenericObject CreateEntity(Texture2D texture)
		{
			entities++;

			return new GenericObject (texture);
		}
	}
}