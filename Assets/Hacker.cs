﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    
    void ShowMainMenu()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("What would you like to hack into?");
            Terminal.WriteLine("Press 1 for City Hall.");
            Terminal.WriteLine("Press 2 for the Police Precint.");
            Terminal.WriteLine("Press 3 for the Hospital.");
            Terminal.WriteLine("Enter your selection:");
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
