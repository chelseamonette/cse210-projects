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

    // Mood Added for Creativity
    public string _mood = "";
    public Entry(string promptText, string entryText, string mood)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date  = dateText;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }
    // Display() : void
    public void Display()
    {
       Console.WriteLine($"{_date} - Mood: {_mood}; {_promptText}: {_entryText}");
    }

}