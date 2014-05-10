#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace Dazzer
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        StateManager level;
        Player playerOne;
        Grid grid;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            level = new StateManager();
            playerOne = new Player(Content);
            grid = new Grid(Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            playerOne.Update();
            playerOne.PCInput(Keys.Up, Keys.Down, Keys.Left, Keys.Right);

            playerTwo.Update();
            playerTwo.PCInput(Keys.W, Keys.S, Keys.A, Keys.D);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            switch(level.currentGameState)
            {
                case StateManager.GameState.main_Menu:
                    {
                        GraphicsDevice.Clear(Color.CornflowerBlue);

                        break;
                    }

                case StateManager.GameState.game_Level:
                    {
                        GraphicsDevice.Clear(Color.White);
                        grid.Draw(spriteBatch);
                        playerOne.Draw(spriteBatch);
                        playerTwo.Draw(spriteBatch);

                        break;
                    }
            }

            base.Draw(gameTime);
        }
    }
}
