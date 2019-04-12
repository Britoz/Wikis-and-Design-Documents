using SwinGameSDK;

namespace MyGame
{
    // '' <summary>
    // '' The EndingGameController is responsible for managing the interactions at the end
    // '' of a game.
    // '' </summary>
    class EndingGameController : HighScoreController
    {
        
        // '' <summary>
        // '' Draw the end of the game screen, shows the win/lose state
        // '' </summary>
        public void DrawEndOfGame() {
            Rectangle toDraw = new Rectangle();
            string whatShouldIPrint;
            DrawField(ComputerPlayer.PlayerGrid, ComputerPlayer, true);
            DrawSmallField(HumanPlayer.PlayerGrid, HumanPlayer);
            toDraw.X = 0;
            toDraw.Y = 250;
            toDraw.Width = SwinGame.ScreenWidth();
            toDraw.Height = SwinGame.ScreenHeight();
            if (HumanPlayer.IsDestroyed) {
                whatShouldIPrint = "YOU LOSE!";
            }
            else {
                whatShouldIPrint = "-- WINNER --";
            }
            
            SwinGame.DrawTextLines(whatShouldIPrint, Color.White, Color.Transparent, GameFont("ArialLarge"), FontAlignment.AlignCenter, toDraw);
        }
        
        // '' <summary>
        // '' Handle the input during the end of the game. Any interaction
        // '' will result in it reading in the highsSwinGame.
        // '' </summary>
        public void HandleEndOfGameInput() {
            if ((SwinGame.MouseClicked(MouseButton.LeftButton) 
                        || (SwinGame.KeyTyped(KeyCode.vk_RETURN) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE)))) {
                ReadHighScore(HumanPlayer.Score);
                EndCurrentState();
            }
            
        }
    }
}
