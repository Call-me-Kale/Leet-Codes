public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        string[] words = text.Split(' ');
        int properWordsCount = 0;
        for(int i = 0; i < words.Length; i++) {
            bool isProper = true;
            for(int j = 0; j < brokenLetters.Length; j++){
                if(words[i].Contains(brokenLetters[j])){
                    isProper = false;
                }
            }
            if(isProper){
                properWordsCount = properWordsCount + 1;
            }
        }
        return properWordsCount;
    }
}
