namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Guesser guesser = new Guesser();
        private Word word = new Word();
        private Parachute parachute = new Parachute();
        private IOService ioService = new IOService();
        private bool isPlaying = true;
        private string guess;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            ioService.WriteText("This is a game of jumper (hangman)");
            ioService.WriteText("Guess the word before the jumper dies!!");
            // get new word from word
            word.
            ioService.WriteText(word.blanks());
            ioService.WriteText(parachute.getParachute());
            ioService.WriteText(parachute.getPerson());

        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            //Guess letter outputs a bool for if the letter is valid or not.
            bool valid = false;
            if (!valid)
            {
                guess = ioService.ReadText("Enter a letter: ");
                valid = guesser.guessLetter(guess);
            }

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            hider.WatchSeeker(seeker);
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            string hint = hider.GetHint();
            ioService.WriteText(hint);
            if (hider.IsFound())
            {
                isPlaying = false;
            }
            
        }
    }
}