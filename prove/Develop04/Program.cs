using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        int userInput = menu.EnterUserInput();
    }
}