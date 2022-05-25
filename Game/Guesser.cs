namespace Unit03.Game
{
    /// <summary>
    
    /// </summary>
    public class Guesser
    {
        private List<string> alreadyGuessedLetters= new List<string>();
        private string letter;

        /// <summary>
        /// Constructs a new instance of Guesser.
        /// </summary>
        public Guesser()
        {

        }
    private void addToGuessedLetters()
    {
        alreadyGuessedLetters.Add(letter);
    }

    private bool guessLetter(string input)
    {
        // if the letter is already in the the string of already guessed letters, then the guess is returned as incorrect
        // if letter is in string then ret
        bool valid = True;
        foreach (string it in alreadyGuessedLetters)
        {
            
            if (input == it)
            {  
                valid = False;
            }
           
        }
        if (valid == True)
        {
            letter = input;
            this.addToGuessedLetters();
        }

        
    }

    private string returnLetter()
    {
        return letter;
    }
    }
}