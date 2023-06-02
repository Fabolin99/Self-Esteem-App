public class FactDisplayer
{
    public void display_ponder_questions()
    {
        //The random library allows to select a random string from a list.
        var random = new Random();
        var list = new List<string>{"Did I help someone today?", 
            "How did I show my love to others?","What was the most meaningful experience today?",
            "Did I have time to ponder today's experiences?", "Do I consider today a good day?"};
        int index = random.Next(list.Count);
        string question = (list[index]);
        Console.WriteLine(question);
    }
}
