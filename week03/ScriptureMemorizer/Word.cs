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

    /*The key behaviors for the Word class are to hide and show a
     word and to check if a word is hidden or not. In addition, a 
     Word should have a behavior to get the display text of that word,
      which would be either the word itself (for example, "prayer") 
      or, if the word were hidden, this behavior would return 
      underscores (for example, "______").*/
    // HideWord(): void
    public void HideWord(){
        _isHidden = true;
        
    }

    // ShowWord(): void
    public void ShowWord(){
        _isHidden = false;
    }

    // IsHidden(): bool
    public bool IsHidden(){
       if (){
            return true;
       }
       else if ()(
            return false;
       )
    }

    // GetDisplayText(): string
    public string GetDisplayText(){
        if (IsHidden()){
            string hiddenWord = new string('_',_text.Length);
            return hiddenWord;
        }
        else{
            return _text;
        }
    }
}