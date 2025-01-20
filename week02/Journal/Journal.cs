// Stores a list of journal entries.  Responsibilities: 
// add an entry, display all the entries, save to a file,
// and load from a file.  Display method iterates through 
// all Entry object and call the Entry display method.
using System.ComponentModel.DataAnnotations;
using System.IO;

public class Journal
{
    // Declare variables
    string fileName = "myFile.txt";

    // _entries : List<Entry>
    public List<Entry> _entries = new();

    //AddEntry(newEntry : Entry) : void
    public void CreateNewEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Write the text of your entry as a single string.");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText);
        _entries.Add(entry);
    }

    //DisplayAll() : void
    public void DisplayAll()
    {
      foreach(Entry entry in _entries)
      {
        entry.Display();
      }
        
    }

    //SaveToFile(file : string)
    public void SaveToFile()
    {
        // Us "using" to make sure that the file gets closed and cleaned up
        // when you are done.  Put StreamWriter object in block and use the 
        // same Write() and WriteLine() methods the same as Console.Write()
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_entries);
        }

    }

    //LoadFromFile(file : string)
    public void LoadFromFile()
    {

    }
}