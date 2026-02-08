using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times when you showed strength."
        ) {}

    public void Run()
    {
        StartActivity();

        Random rand = new();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Count)]}");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{_questions[rand.Next(_questions.Count)]} ");
            ShowSpinner(5);
        }

        EndActivity();
    }
}
