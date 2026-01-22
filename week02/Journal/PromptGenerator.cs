public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What is one small win I had today, even if it seemed insignificant?");
        _prompts.Add("What drained my energy the most today?");
        _prompts.Add("What gave me energy today?");
        _prompts.Add("What challenge did I face today, and how did I respond to it?");
        _prompts.Add("What am I grateful for right now?");
        _prompts.Add("Did I learn anything new today? If yes, what?");
        _prompts.Add("What thought kept repeating in my mind today?");
        _prompts.Add("What moment today do I want to remember later?");
        _prompts.Add("How did I treat myself today?");
        _prompts.Add("Did I act in line with my values today? Why or why not?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What made me smile today?");
        _prompts.Add("What am I worried about tonight?");
        _prompts.Add("What is one thing I can improve tomorrow?");
        _prompts.Add("Who did I appreciate today, even if I didn’t say it out loud?");
        _prompts.Add("What decision did I make today that mattered?");
    }

    public string GetRandomPrompt()
    {
        Random _randomGenerator = new Random();
        int index = _randomGenerator.Next(0, 20);
        return _prompts[index];

    }
}