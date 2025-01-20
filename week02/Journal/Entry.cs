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
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date  = dateText;
        _promptText = promptText;
        _entryText = entryText;
        
    }
    // Display() : void
    public void Display()
    {
       Console.WriteLine($"{_date} - {_promptText}: {_entryText}");
    }

}