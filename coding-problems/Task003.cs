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
    
    private string m_inputString = "'Wow!' said Goldilocks... 'Three bowls, three beds and three bears.'";

    private string ReverseWordOrderRetainPunctuation(string stringToReverse)
    {
        var cleanUpString = stringToReverse.Trim();
        string[] stringArray = cleanUpString.Split(" ");
        var punctuationDatas = new List<PunctuationData>();

        // Iterate on each word and collect punctuation data
        for (int wordCount = 0; wordCount < stringArray.Length; wordCount++)
        {
            Console.WriteLine(stringArray[wordCount] + (wordCount+1));

            // Iterate on each character basis
            for (int charCount = 0; charCount < stringArray[wordCount].Length; charCount++)
            {
                var word = stringArray[wordCount];
                
                if (char.IsPunctuation(word[charCount]))
                {
                    // If it's at the start of the word, then prepend, else it belongs at the end
                    PunctuationPosition _pos;
                    _pos = charCount == 0 ? PunctuationPosition.BeforeWord : PunctuationPosition.AfterWord;
                    
                    var data = new PunctuationData
                    {
                        punctuation = word[charCount],
                        wordCount = wordCount,
                        pos = _pos
                    };

                    punctuationDatas.Add(data);
                }
            }
            
            // Remove the punctuation
            
            
            // Flip the array order
            Array.Reverse(stringArray);
            
            // Inject the punctuation back in precise order
            
        }
        
        return stringArray.ToString();
    }

    public void Main()
    {
        var result = ReverseWordOrderRetainPunctuation(m_inputString);
        Console.WriteLine($"{m_inputString}\nbecomes...\n{result}");
    }
}
