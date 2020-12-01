using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data
    string[] level1Passwords = { "needle", "blood", "bandage", "doctor", "nurse" };
    string[] level2Passwords = { "cuffs", "kill", "arrest", "gun", "cop" };
    string[] level3Passwords = { "mayor", "politician", "law", "budget", "protest" };
    
    // Game State
    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;
    string password;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello, Hacker.");
    }

    void ShowMainMenu(string greeting)
        {
            currentScreen = Screen.MainMenu;
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
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
	}

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if(isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else if(input == "Hack the planet!") // Easter egg
        {
            Terminal.WriteLine("Nice to see you, ZeroCool!  Please make your selection.");
        }
        else
        {
            Terminal.WriteLine("Please select a valid level.");
            Debug.LogError("Invalid level number.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("Please enter the password: ");
        switch(level)
        {
            case 1:
                password = level1Passwords[2];
                break;
            case 2:
                password = level2Passwords[2];
                break;
            case 3:
                password = level3Passwords[2];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    void CheckPassword(string input) 
    {
        if(input == password)
        {
            Terminal.WriteLine("Good job!");
        }
        else
        {
            Terminal.WriteLine("Bad smarts. Try again.");
        }
    }

    void Update()
    {
        
    }

    
}
