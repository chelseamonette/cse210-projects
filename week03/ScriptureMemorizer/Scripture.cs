// Keeps track of both the reference and the text of
// the scripture.  Can hide words and get the rendered 
// display of the text

using System;

public class Scripture
{
    //Declare variables
    private Reference _reference;
    private List<Word> _words;

    // Constructor that accepts both a reference and
    // the text of the scripture
    public Scripture(Reference reference, string word)
    {

    }

    // HideRandomWords(numberToHide: int): 
    public void HideRandomWords(int numberToHide){


    }

    // GetDisplayText(): string
    public string GetDisplayText(){

        return "";
    }

    // CompletelyHidden(): bool
    public bool CompletelyHidden(){

        return true;
    }
}
