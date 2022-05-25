namespace Unit03.Game{
    class Word{
        private List<string> list = System.IO.File.ReadLines(@"words.text");
        private string word_as_list = list[Random.Next(0,list.count)];
        private string blank_to_be_filled;

        //Gets the length of the word and adds blanks to the blank_to_be_filled variable
        public void setBlankSpace(){
            for (int i = 0; i <= word.count; i += 1) {
                blank_to_be_filled[i] = "_";
            }
        }

        //Replaces the blank_to_be_filled letter if the guessed_ltr letter is inside the word
        public void replaceBlank(string guessed_ltr){
            for (int i = 0; i <= word.count; i += 1) {
                if(word[i] == guesssed_ltr){
                    blank_to_be_filled[i] = guesssed_ltr;
                }
            }
        }  
    }
}