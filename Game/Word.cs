using System;
using System.Collections.Generic;

namespace Unit03.Game{
    class Word{
        //private List<string> list;
        private string word_as_list;
        public List<string> blank_to_be_filled= new List<string>();

        public Word()
        {
            var lines = File.ReadAllLines(@"Game/words.txt");
            var r = new Random();
            var randomLineNumber = r.Next(1, lines.Length - 1);
            word_as_list = lines[randomLineNumber];
        }
        //Gets the length of the word and adds blanks to the blank_to_be_filled variable
        public void setBlankSpace(){
            for (int i = 0; i < word_as_list.Count();) {
                blank_to_be_filled.Add("_");
                i ++;
            }
        }

        //Replaces the blank_to_be_filled letter if the guessed_ltr letter is inside the word
        public void replaceBlank(string guessed_ltr){
            for (int i = 0; i < word_as_list.Count();i++) {
                if(word_as_list[i] == guessed_ltr[0]){
                    blank_to_be_filled[i] = guessed_ltr;
                    
                }
            }
        }  

        public List<string> getBlank(){
            return blank_to_be_filled;
        }

        public string getWord(){
            return word_as_list;
        }
    }
}