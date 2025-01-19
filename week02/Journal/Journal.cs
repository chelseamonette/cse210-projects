// Stores a list of journal entries.  Responsibilities: 
// add an entry, display all the entries, save to a file,
// and load from a file.  Display method iterates through 
// all Entry object and call the Entry display method.
public class Journal
{
    // _entries : List<Entry>
    public List<Entry> _entries = new();

    //AddEntry(newEntry : Entry) : void
    public void CreateNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Write the text of your entry as a single string.");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText);
        _entries.Add(entry);
    }

    //DisplayAll() : void
    public void DisplayAll()
    {
        
    }

    //SaveToFile(file : string)
    public void SaveToFile()
    {

    }

    //LoadFromFile(file : string)
    public void LoadFromFile()
    {

    }
}