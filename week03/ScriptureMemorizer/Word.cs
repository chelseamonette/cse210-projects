// Keeps track of a single word and whether it is 
// shown or hidden.

using System;

public class Word
{
    // Declare variables
    private string _text;
    private bool _isHidden;

    // Constructor that should accept the text of the
    // word to save it as an attribute.
    public Word(string text)
    {   
        _text = text;
    }

    // HideWord(): void
    public void HideWord(){
        string hiddenWord = new string('_',_text.Length);
    }

    // ShowWord(): void
    public void ShowWord(){
        Console.Write(_text);
    }

    // IsHidden(): bool
    public bool IsHidden(){
        if(_isHidden){
            return true;
        }
        else{
            return false;
        }
    }

    // GetDisplayText(): string
    public string GetDisplayText(){
        if (_isHidden){
           string word = _text.HideWord();
           return word;
        }
        else if (_isHidden == false){
            string word = $"{_text}";
            return word;
        }
    }
}