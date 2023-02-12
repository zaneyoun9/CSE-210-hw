using System;

class Word
{
    private string _text = "";
    public bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void hide()
    {
        _hidden = true;
    }

    public void Display()
    {
        if (_hidden)
        {
            foreach (char character in _text)
            {
                Console.Write('_'); 
            }
        } else {
            System.Console.Write(_text);
        }
    }


    public bool IsHidden()
    {
        return _hidden;
    }
}
