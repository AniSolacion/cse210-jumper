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

    public bool guessLetter(string input)
    {
        // if the letter is already in the the string of already guessed letters, then the guess is returned as incorrect
        // if letter is in string then ret
        bool valid = true;
        foreach (string it in alreadyGuessedLetters)
        {
            
            if (input == it)
            {  
                valid = false;
            }
           
        }
        if (valid == true && input.Length != 1)
        {
            valid = false;
        }
        if (valid == true)
        {
            letter = input;
            this.addToGuessedLetters();
        }

        return valid;
    }

    public string returnLetter()
    {
        return letter;
    }
    }
}