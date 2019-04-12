using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main ()
        {
            // Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow ("Battle Ships", 800, 600);
            // Load Resources
            GameResources game = new GameResources ();
            GameController gameController = new GameController ();
            game.LoadResources ();
            
            SwinGame.PlayMusic (game.GameMusic ("Background"));

            // Game Loop
            for (
            ; (((SwinGame.WindowCloseRequested () == true)
                        || (gameController.CurrentState == GameState.Quitting))
                        == false);
            ) {
                gameController.HandleUserInput ();
                gameController.DrawScreen ();
            }

            SwinGame.StopMusic ();
            // Free Resources and Close Audio, to end the program.
            game.FreeResources ();
        }

    }
}