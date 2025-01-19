//Represents a single journal entry.  Has its own 
// display method
public class Entry 
{
    // _date : string
    public string _date = "";
    //_promptText : string
    public string _promptText = "";
    //_entryText : string
    public string _entryText = "";
    public Entry(string promptText, string entryText)
    {
        _date  = new DateTime().ToString();
        _promptText = promptText;
        _entryText = entryText;
        
    }
    // Display() : void
    void Display()
    {

    }

}