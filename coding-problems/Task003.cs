/*
 * Write a function to reverse the order of words, but keep the punctuation in place.
 * For example, turn "Hello world!" into “world Hello!” and
 * “With you, be May the Fourth.” to “Fourth the, May be you With.”
*/

public class Task003
{
    private enum PunctuationPosition
    {
        AfterWord,
        BeforeWord,
    }
    
    private struct PunctuationData
    {
        public char punctuation;
        public int wordCount;
        public PunctuationPosition pos;

        public PunctuationData()
        {
            punctuation = '\0';
            wordCount = 0;
            pos = PunctuationPosition.AfterWord;
        }
    }
    
    private string m_inputString = "Wow!! (said Goldilocks)... Three bowls, three beds for #3 bears.";

    private string ReverseWordOrderRetainPunctuation(string stringToReverse)
    {
        var cleanUpString = stringToReverse.Trim();
        string[] stringArray = cleanUpString.Split(" ");
        var punctuationDatas = new List<PunctuationData>();

        // Iterate on each word and collect punctuation data
        for (int wordCount = 0; wordCount < stringArray.Length; wordCount++)
        {
            var wordString = stringArray[wordCount];
            
            // Iterate on each character basis
            for (int charCount = 0; charCount < stringArray[wordCount].Length; charCount++)
            {
                if (char.IsPunctuation(wordString[charCount]))
                {
                    // If it's at the start of the word, then prepend, else it belongs at the end
                    PunctuationPosition _pos;
                    _pos = charCount == 0 ? PunctuationPosition.BeforeWord : PunctuationPosition.AfterWord;
                    
                    var data = new PunctuationData
                    {
                        punctuation = wordString[charCount],
                        wordCount = wordCount,
                        pos = _pos
                    };

                    punctuationDatas.Add(data);
                }
            }
        }

        // Remove the punctuation
            for (int i = 0; i < stringArray.Length; i++)
            {
                var word = stringArray[i];
                var newWord = string.Empty;
                for (int j = 0; j < stringArray[i].Length; j++)
                {
                    if (!char.IsPunctuation(word[j]))
                    {
                        newWord += word[j];
                    }
                }

                stringArray[i] = newWord;
            }

            // Flip the array order
            Array.Reverse(stringArray);
            
            // Reinject the punctuation back in precise order
            for (int i = 0; i < punctuationDatas.Count; i++)
            {
                string wordToEdit = stringArray[punctuationDatas[i].wordCount];
                
                switch (punctuationDatas[i].pos)
                {
                    case PunctuationPosition.BeforeWord:
                        wordToEdit = punctuationDatas[i].punctuation + wordToEdit;
                        break;
                    
                    case PunctuationPosition.AfterWord:
                        wordToEdit += punctuationDatas[i].punctuation;
                        break;
                }
                
                stringArray[punctuationDatas[i].wordCount] = wordToEdit;
            }

            return string.Join(" ", stringArray);
        }
        
    public void Main()
    {
        var result = ReverseWordOrderRetainPunctuation(m_inputString);
        Console.WriteLine($"- - - - -\n{m_inputString}\nbecomes...\n{result}\n- - - - -");
    }
}