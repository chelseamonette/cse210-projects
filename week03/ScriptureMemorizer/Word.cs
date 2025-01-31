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
        int letters = text.Length;
        
    }

    // HideWord(): void
    public void HideWord(){
        foreach(int letter in letters)
    }

    // ShowWord(): void
    public void ShowWord(){

    }

    // IsHidden(): bool
    public bool IsHidden(){

        return true;
    }

    // GetDisplayText(): string
    public string GetDisplayText(){
        if (_isHidden){
           string word = 
        }
        else if (_isHidden == false){
            string word = $"{_text}";
            return word;
        }
    }
}