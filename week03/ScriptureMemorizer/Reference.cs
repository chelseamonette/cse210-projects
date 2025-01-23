// Keeps track of the book, chapter, and verse 
// information

using System;

public class Reference
{
    //Declare variables 
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors to account for cases where there is 
    // a single verse or multiple verses.
    public Reference(string book, int chapter, int verse)
    {

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {

    }
    // GetDisplayText(): string
    public string GetDisplayText(){

        return "";
    }

    // Possible getters and setters
}