using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game State
    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen = Screen.MainMenu;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello, Hacker.");
    }

    void ShowMainMenu(string greeting)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine(greeting);
            Terminal.WriteLine("What would you like to hack into?");
            Terminal.WriteLine("Press 1 for Hospital.");
            Terminal.WriteLine("Press 2 for the Police Precint.");
            Terminal.WriteLine("Press 3 for the City Hall.");
            Terminal.WriteLine("Enter your selection:");
        }

    // Update is called once per frame
    void OnUserInput(string input)
	{
		print("The user typed: \"" + input + "\"");
        if(input == "menu")
        {
            ShowMainMenu("Resetting options...");
        }
        else if(input == "1")
        {
            level = 1;
            StartGame();
        }
        else if(input == "2")
        {
            level = 2;
            StartGame();
        }
        else if(input == "3")
        {
            level = 3;
            StartGame();
        }
        else if(input == "Hack the planet!")
        {
            Terminal.WriteLine("Nice to see you, ZeroCool!  Please make your selection.");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level.");
        }
	}

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You chose Level " + level);
        Terminal.WriteLine("Please enter the password: ");
        
    }


    void Update()
    {
        
    }

    
}
