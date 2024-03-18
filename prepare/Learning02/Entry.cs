public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


        string getEntry()
        {return string.Format("{0}~{1}~{2}", _date, _promptText, _entryText);}
}