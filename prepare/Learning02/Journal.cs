public class Journal
{
    public List<Entry> _entries;
    
    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine(variable.Prompts());
        String _entryText = Console.ReadLine();
    }
    public void DisplayAll()
    {}
    public void SaveToFile(string file)
    {
        Console.WriteLine("What will you name your file? ");
        File.WriteAllText(File.text);
    }
    public void LoadFromFile(string file)
    {}
}

