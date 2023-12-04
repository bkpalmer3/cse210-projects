using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu menu = new Menu();
        // menu.DisplayMenu();
        // int userInput = menu.EnterUserInput();

        // Breathing BreathingA = new Breathing("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // string userInput = BreathingA.InputTimeLengthUser();
        // BreathingA.SetTimeLength(userInput);
        // BreathingA.RunBreathing();

        // Reflection reflectionA = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    //     reflectionA.DisplayActivity();
    //     string userInput = reflectionA.InputTimeLengthUser();
    //     reflectionA.SetTimeLength(userInput);

    //     Console.WriteLine ("Consider the following prompt: ");
    //     string prompt = reflectionA.GetRandomPrompt();
    //     Console.WriteLine($"=== {prompt} ===");

    //     Console.WriteLine("Press Enter to continue");
    //     string nothing = Console.ReadLine();

    //     Console.WriteLine("Get Ready!");
    //     Thread.Sleep(5000);

    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(reflectionA.GetTimeLength());
    //     while (DateTime.Now < endTime )
    //     {
    //         string question = reflectionA.GetRandomQuestion();
    //         Console.WriteLine($"> {question}");
    //         reflectionA.RunAnimation();
    //     }
    

        // Listing listingA = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        // listingA.DisplayActivity();
        // string userInput = listingA.InputTimeLengthUser();
        // listingA.SetTimeLength(userInput);
        // Console.WriteLine("List as many responses as you can to the following question");
        // string prompt = listingA.GetRandomPrompt();
        // Console.WriteLine($"=== {prompt} ===");

        // Console.WriteLine ("You may begin in:");
        // Thread.Sleep(5000);

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(listingA.GetTimeLength());
        // while (DateTime.Now < endTime )
        // {
        //     Console.WriteLine();
        //     Console.Write("> ");
        //     listingA.AddAnswer(Console.ReadLine());
        // }
        // listingA.SetNumberOfItems();
        // listingA.DisplayNumberOfItems();
        Activities baseactivity = new Activities("Secret Activity","This activity does nothing and is not meant to be used");
        Menu menu = new Menu();
        int menuInput = 0;

        while (menuInput != 4)
        {
            menu.DisplayMenu();
            menuInput = menu.EnterUserInput();

            switch (menuInput)
            {
                case 1:
                    Breathing BreathingA = new Breathing("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.WriteLine();
                    BreathingA.DisplayActivity();
                    Console.WriteLine();

                    string userInput = BreathingA.InputTimeLengthUser();
                    BreathingA.SetTimeLength(userInput);
                    Console.WriteLine();
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = startTime.AddSeconds(BreathingA.GetTimeLength());
                    Console.WriteLine("Get Ready!");
                    BreathingA.RunAnimation();
                    Console.WriteLine();
                    
                    while (DateTime.Now < endTime )
                    {
                        Console.Write("Breath in...");
                        for (int i = 6; i>0; i--)
                        {
                            Console.Write(i);
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.Write("Breath out...");
                        for (int i = 4; i>0; i--)
                        {
                            Console.Write(i);
                            Thread.Sleep(1000);
                            Console.Write("\b \b");
                        }
                        Console.WriteLine();            
                        Console.WriteLine();
                    }

                    BreathingA.DisplayEndMessage();
                    BreathingA.RunAnimation();
                    break;
                
                case 2:
                    Reflection reflectionA = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.WriteLine();
                    reflectionA.DisplayActivity();
                    Console.WriteLine();
                    userInput = reflectionA.InputTimeLengthUser();
                    reflectionA.SetTimeLength(userInput);

                    Console.WriteLine();
                    Console.WriteLine ("Consider the following prompt: ");
                    string prompt = reflectionA.GetRandomPrompt();
                    Console.WriteLine("==============================================");
                    Console.WriteLine(prompt);
                    Console.WriteLine("==============================================");
                    Console.Write("Press Enter to continue");
                    string nothing = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Get Ready!");
                    reflectionA.RunAnimation();

                    startTime = DateTime.Now;
                    endTime = startTime.AddSeconds(reflectionA.GetTimeLength());
                    while (DateTime.Now < endTime )
                    {
                        string question = reflectionA.GetRandomQuestion();
                        Console.WriteLine($"> {question}");
                        reflectionA.RunAnimation();
                        Console.WriteLine();
                    }
                    
                    reflectionA.DisplayEndMessage();
                    reflectionA.RunAnimation();

                break;

                case 3:
                    Listing listingA = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.WriteLine();
                    listingA.DisplayActivity();
                    Console.WriteLine();

                    userInput = listingA.InputTimeLengthUser();
                    listingA.SetTimeLength(userInput);
                    Console.WriteLine();

                    Console.WriteLine("List as many responses as you can to the following question");
                    prompt = listingA.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine("===========================================");
                    Console.WriteLine(prompt);
                    Console.WriteLine("===========================================");
                    Console.WriteLine();

                    Console.Write ("You may begin in:");
                    for (int i = 4; i>0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }


                    startTime = DateTime.Now;
                    endTime = startTime.AddSeconds(listingA.GetTimeLength());
                    while (DateTime.Now < endTime )
                    {
                        Console.WriteLine();
                        Console.Write("> ");
                        listingA.AddAnswer(Console.ReadLine());
                    }
                    
                    Console.WriteLine();
                    listingA.SetNumberOfItems();
                    listingA.DisplayNumberOfItems();

                    Console.WriteLine();
                    listingA.DisplayEndMessage();
                    listingA.RunAnimation();
                break;


            }
        }
    }
}
