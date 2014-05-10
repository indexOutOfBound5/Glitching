using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dazzer
{
    class StateManager
    {
        public enum GameState
        {
            main_Menu,
            game_Level
        }

        public GameState currentGameState = GameState.game_Level;
    }
}
