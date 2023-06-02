using System.IO;
public class SelfEsteemTest
{
    public void display_test()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();

        // Prompting multiple questions
        Console.WriteLine("Please, answer the following statements on a scale of 1-10 " +
                          "(1: Strongly Disagree, 10: Strongly Agree):");

        // Array of questions
        string[] questions = {
            "Question 1: Do believe in my potential?",
            "Question 2: Do I see others' love in my life?",
            "Question 3: Do I consider myself a very interesting person?",
            "Question 4: Do I feel appreciated?",
            "Question 5: Do I feel loved?",
            "Question 6: Have I injured myself?",
            "Question 7: Do I feel optimistic when I face a challenge?",
            "Question 8: How often do I set goals in my life?",
            "Question 9: How often do I make new friends?",
            "Question 10: Do I feel capable to overcome adversity?"
        };

        // Array to store ratings
        int[] answer = new int[questions.Length];

        // Loop through each question and collect ratings
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine(questions[i]);

            int score = 0;
            bool validInput = false;

            // Prompt for a valid rating
            while (!validInput)
            {
                Console.Write("Enter your rating (1-10): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out score) && score is >= 1 and <= 10)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid rating. Please enter a number between 1 and 10.");
                }
            }
            answer[i] = score;
        }
        int sum = answer.Sum();
        
        //Prompts for writing the results in a text file.
        Console.WriteLine("Do you want to save your results in a text file?(y/n)");
        string userChoice = Console.ReadLine();
          
        if(userChoice == "y")
        {
            Console.WriteLine("What is the name of the file?");
            string filePath = Console.ReadLine();

            try
            {
                // Create a new instance of StreamWriter
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write content to the file
                    writer.WriteLine($"Thank you {userName} for taking the test!");
                    writer.WriteLine($"Your test result is {sum}");
                    writer.WriteLine("Remember that this is not a professional test.");
                    writer.WriteLine("If more help is needed, it is recommended to seek professional help");
                }
                Console.WriteLine("Text file has been written successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        } 
        else if(userChoice == "n")
        {
            Console.WriteLine($"Your test score is {sum}");
            Console.WriteLine($"Have a good one {userName}!");
        }
        else
        {
            Console.WriteLine("Please, choose a correct answer (y/n)");
        }
    }
    
}
