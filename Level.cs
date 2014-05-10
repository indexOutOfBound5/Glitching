using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace Dazzer
{
	public abstract class Level
	{
		SoundBank bgMusic;
		Grid grid;
		GenericObject[,] enities;
	}
}