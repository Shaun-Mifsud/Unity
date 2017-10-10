using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizzard : MonoBehaviour {
    //variables
    int Min;
    int Max;
    int guess;

    //methods
    void Guess()
    {
        print("Is the number is bigger or smaller than: " + guess + " ?");
        print("Press UP if the number is bigger");
        print("Press DOWN if the number is smaller");
        print("Press ENTER if the number is guessed");
    }

    void StartGame()
    {
        Min = 0;
        Max = 1001;
        guess = 500;

        print("Hello and welcome");
        Debug.Log("Please choose a number from " + Min + " to " + Max); //Debug.Log is the same as print 
        Guess();
    }

    // Use this for initialization
    void Start() {
        StartGame();
    }


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("up arrow pressed");
            Min = guess;
            guess = (Max + Min) / 2;
            Guess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("down arrow pressed");
            Max = guess;
            guess = (Max + Min) / 2;
            Guess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("enter  pressed");
            print("Correct");
            print("Press Q to exit the game and or P to re-play");

            if (Input.GetKeyDown(KeyCode.Q))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
                 if (Input.GetKeyDown(KeyCode.P))
                 {
                     StartGame();
                 }
            
        }


    }
}
