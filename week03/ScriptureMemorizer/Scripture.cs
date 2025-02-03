// Keeps track of both the reference and the text of
// the scripture.  Can hide words and get the rendered 
// display of the text

using System;

public class Scripture
{
    //Declare variables
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    

    // Constructor that accepts both a reference and
    // the text of the scripture
    public Scripture(Reference reference, string text)
    {
        _random = new Random();
        _reference = reference;
        string[] _words = text.Split(" ");
        foreach(string word in _words){
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
        
   
    }

    /*The key behaviors for the Scripture class are to hide 
    random words and also to get the display text as a string. 
    (The "display text" refers to the text with some words 
    shown normally, and some replaced by underscores.) It 
    would also be nice to have a behavior to check if the 
    scripture is completely hidden so that you know when to 
    end the program.*/

    // HideRandomWords(numberToHide: int): 
    public void HideRandomWords(int numberToHide){
        // Take the list of words and randomly hide words based on the 
        // numberToHide and whether or not they have been hidden already
        Random rand = new Random();
        int x = 0;
        var hiddernWords = _words;
        while (x<numberToHide){
            int index = _random.Next(_words.Count);
            if (hiddenWords[index])
            
            x++;
        }
        //foreach(Word in hiddernWords){

        //}

    }

    // GetDisplayText(): string
    public string GetDisplayText(){
        return "";
    }

    // CompletelyHidden(): bool
    public bool CompletelyHidden(){
        foreach (Word word in _words){
            if (word.IsHidden()){
                return true;
            }
            else{
                return false;
            }
        }
        return true;

    }
}
