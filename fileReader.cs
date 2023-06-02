public class FileReader
{
    public void read_file()
    {
        // Specify the file path
        Console.WriteLine("What is the name of the file? ");
        string filePath = Console.ReadLine();

        try
        {
            // Create a new instance of StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                // Read and display lines from the file until the end is reached
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //In case there is an error, it displays a message.
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
} 
