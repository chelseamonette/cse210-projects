// Keeps track of the book, chapter, and verse 
// information

using System;
using System.Data;
using System.Security.Cryptography;

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
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // GetDisplayText(): string
    public string GetDisplayText(){

        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

  
}