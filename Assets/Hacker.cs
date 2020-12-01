using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello, Jo.");
    }

    void ShowMainMenu(string greeting)
        {
            Terminal.ClearScreen();
            Terminal.WriteLine(greeting);
            Terminal.WriteLine("What would you like to hack into?");
            Terminal.WriteLine("Press 1 for City Hall.");
            Terminal.WriteLine("Press 2 for the Police Precint.");
            Terminal.WriteLine("Press 3 for the Hospital.");
            Terminal.WriteLine("Enter your selection:");
        }

    // Update is called once per frame

    void OnUserInput(string input)
	{
		print("The user typed: \"" + input + "\"");
        if(input == "1")
        {
            print("You chose City Hall.");
        }
        else if(input == "2")
        {
            print("You chose the Police Precint.");
        }
        else if(input == "3")
        {
            print("You choose the Hospital.");
        }
        else if(input == "Menu")
        {
            ShowMainMenu("Resetting options...");
        }
        else
        {
            print(false);
        }
	}

    void Update()
    {
        
    }

    
}
