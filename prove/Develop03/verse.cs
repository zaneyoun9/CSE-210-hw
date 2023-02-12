using System;

class Verse
{
    private List<Word> _words;

    public Verse(String verse) 
    {
        // Create the list for words only when the object is created
        _words = new List<Word>();

        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] words = verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }

    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
    public void Hide(int count)
    {
        Word word = new Word("");

        for (int i = 0; i < count; i++)
        {
            
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _words.Count);
            if (_words[randomIndex].IsHidden() == false)
            {
                _words[randomIndex].hide();
            }
            else
            {
                if (IsAllHidden() != true)
                    i -= 1;
            }
        }
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
           if (!word.IsHidden()) 
           {
                return false;
           }
        } 
        return true;
    }
}
