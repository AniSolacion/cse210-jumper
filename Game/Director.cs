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
            word.setBlankSpace();
            ioService.WriteText("");
            ioService.WriteListInLine(word.getBlank());
            ioService.WriteText("");
            ioService.WriteList(parachute.getParachute());
            ioService.WriteList(parachute.getPerson());

            // DEBUG: solution
            ioService.WriteText(word.getWord());

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
                guess = ioService.ReadText("Enter a letter [a-z]:  ");
                valid = guesser.guessLetter(guess);
            }

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            //if the letter is in the word
            if (word.getWord().Contains(guess))
            {
                word.replaceBlank(guess);
            }
            else{
                parachute.takeRowOffParachute();
            }
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {            
            if(word.getBlank().Contains("_") && parachute.getParachute().Count() != 0)
            {
                ioService.WriteListInLine(word.getBlank());
                ioService.WriteText("");
                ioService.WriteText("");
                ioService.WriteList(parachute.getParachute());
                ioService.WriteList(parachute.getPerson());
            }
            else
            {
                isPlaying = false;
            }

            //if there are no more blanks left in the get blanks list
            if (isPlaying == false && word.getBlank().Contains("_"))
            {
                ioService.WriteText("Congratulations! you have fallen and have now died. ");
                ioService.WriteText($"The word you might have been looking for is : {word.getWord()}");
                ioService.WriteText("Better luck next time!!");
                ioService.WriteList(parachute.getParachute());
                parachute.setDeath();
                ioService.WriteList(parachute.getPerson());
                
            }
            else if (isPlaying == false && parachute.getParachute().Count() != 0){
                ioService.WriteText($"You have successfully not died. The word was : {word.getWord()}");
            }
            
        }
    }
}