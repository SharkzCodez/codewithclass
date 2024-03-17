public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of today? ");
        _prompts.Add("Did you see any animals today? ");
        _prompts.Add("How were you kind to yourself today? ");
        _prompts.Add("What color would you associate today with? ");
        _prompts.Add("What did you have for lunch? ");
        
    }

    public void Prompts()
    {
        Random journalPrompt = new Random();
        int index = journalPrompt.Next(0, _prompts.Count);
        string prompt = _prompts[index];
    }
}