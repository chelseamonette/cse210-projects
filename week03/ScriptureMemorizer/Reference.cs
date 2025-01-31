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
        book = _book;
        chapter = _chapter;
        verse = _verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        book = _book;
        chapter = _chapter;
        startVerse = _verse;
        endVerse = _endVerse;
    }
    // GetDisplayText(): string
    public string GetDisplayText(){
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    // Possible getters and setters
    public string GetBook(){
        return _book;
    }
    public void SetBook(string book){
        _book = book;
    }
    public int GetChapter(){
        return _chapter;
    }
    public void SetChapter(int chapter){
        _chapter = chapter;
    }
    public int GetVerse(){
        return _verse;
    }
    public void SetVerse(int verse){
        _verse = verse;
    }
    public int GetEndVerse(){
        return _endVerse;
    }
    public void SetEndVerse(int endVerse){
        _endVerse = endVerse;
    }
}