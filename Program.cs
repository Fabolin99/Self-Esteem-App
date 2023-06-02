string userChoice = "";

while (userChoice != "0")
{
    //Display the interactive menu.
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Take Self-esteem Test");
    Console.WriteLine("2. Read Text File");
    Console.WriteLine("3. Display Facts About Self-esteem");
    Console.WriteLine("0. Quit");
    Console.WriteLine(">Choice");

    userChoice = Console.ReadLine();
    
    if (userChoice == "1")
    {
        SelfEsteemTest option1 = new SelfEsteemTest();
        option1.display_test();
    }
    else if (userChoice == "2")
    {
        FileReader option2 = new FileReader();
        option2.read_file();
    }
    else if (userChoice == "3")
    {
       FactDisplayer option3 = new FactDisplayer();
       option3.display_ponder_questions();
    }
}
