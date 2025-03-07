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
        Console.Write("What mood/s are you in today? ");
        string mood = Console.ReadLine();
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.Write(prompt);
        Console.WriteLine("(Write the text of your entry as a single string.)");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText, mood);
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
        //Prompt user for the name of the file that they would like to save to
        Console.Write("Name of the file that you would like to save to: ");
        fileName = Console.ReadLine();

        // Us "using" to make sure that the file gets closed and cleaned up
        // when you are done.  Put StreamWriter object in block and use the 
        // same Write() and WriteLine() methods the same as Console.Write()
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries){

                outputFile.WriteLine($"{entry._date}|{entry._mood}|{entry._promptText}|{entry._entryText}");
            }
            
        }

    }

    //LoadFromFile(file : string)
    public void LoadFromFile()
    {
        // Prompt user for the name of the file they would like to load
        Console.WriteLine("Name of the .txt file that you would like ");
        fileName = Console.ReadLine();

        if (!File.Exists(fileName)){
            Console.WriteLine("File not found.");
            return;
        }
        // Use the "System.IO.File.ReadAllLines()" function to read file.
        string[] lines = File.ReadAllLines(fileName);
        
        foreach(string line in lines){
            string[] parts = line.Split('|');
            if (parts.Length == 4){
                Entry entry = new Entry(parts[2], parts[3], parts[1]);
                entry._date = parts[0];
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}