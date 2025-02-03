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
        _isHidden = false;
    }

    /*The key behaviors for the Word class are to hide and show a
     word and to check if a word is hidden or not. In addition, a 
     Word should have a behavior to get the display text of that word,
      which would be either the word itself (for example, "prayer") 
      or, if the word were hidden, this behavior would return 
      underscores (for example, "______").*/
  
    // HideWord(): void
    public void HideWord(){
        string hiddenWord = new string('_',_text.Length);
        Console.Write(hiddenWord);
    }

    // ShowWord(): void
    public void ShowWord(){
        Console.Write(_text);
    }

      // IsHidden(): bool
    public bool IsHidden(){
       return true;
    }

    // GetDisplayText(): string
    public string GetDisplayText(){
        if (IsHidden()){
           return _text.HideWord();
        }
        else{
            return _text.ShowWord();;
        }
    }
    public string GetText(){
        return _text;
    }
}