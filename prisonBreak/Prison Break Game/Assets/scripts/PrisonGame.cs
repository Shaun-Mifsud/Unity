using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonGame : MonoBehaviour {
    public Text myText;

    private enum States
    {
        cell,sheets_0,mirror,lock_0,cell_mirror,sheets_1,lock_1,freedom,floor,stairs_0,closet_door,stairs_1,corridor_1,in_closet,Stairs_2,corridor_2,corridor_3,courtyard
    };

    private States myState;

    void Cell()
    {
        myText.text=("You are in a prison cell, and you want to escape. There are " +
               "some dirty sheets on the bed, a mirror on the wall, and the door " +
               "is locked from the outside.\n\n" +
               "Press S to view Sheets, M to view Mirror and L to view Lock");

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }

    }

    void Sheets_0()
    {
        myText.text = ("You can't believe you sleep in these things. Surely it's " + "time somebody changed them. The pleasures of prison life " +
              "I guess!\n\n" + "Press R to Return to roaming your cell");

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }


    }

    void mirror()
    {
        myText.text = ("You are still in your cell, and you STILL want to escape! There are " +
                        "some dirty sheets on the bed, a mirror , " +
                        "and that pesky door is still there, and firmly locked!\n\n" +
                        "Press R to go back Cell or T to Take the Mirror");

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }


    }

    void cell_mirror()
    {
        myText.text = ("You are still in your cell, and you STILL want to escape! There are " +
                    "some dirty sheets on the bed, a mark where the mirror was, " +
                    "and that pesky door is still there, and firmly locked!\n\n" +
                    "Press S to view Sheets, or L to view Lock");

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
                    "combination is. You wish you could somehow see where the dirty " +
                    "fingerprints were, maybe that would help.\n\n" +
                     "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }

    void sheets_1()
    {
        myText.text = ("Holding a mirror in your hand doesn't make the sheets look " + "any better.\n\n" + "Press R to Return to roaming your cell");

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }

    }

    void lock_1()
    {
        myText.text = ("You carefully put the mirror through the bars, and turn it round " +
                        "so you can see the lock. You can just make out fingerprints around " +
                        "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                        "Press O to Open, or R to Return to your cell");

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }

    void freedom()
    {
        myText.text = ("You are Free !!! press p to restart press S to go to stairs 0");


        if (Input.GetKeyDown(KeyCode.P))
         {
                myState = States.cell;
         }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }

    }

    void stairs_0()
    {
        myText.text = ("You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n");
    }

    void stairs_1()
    {
        myText.text = ("Unfortunately wielding a puny hairclip hasn't given you the " +
    "confidence to walk out into a courtyard surrounded by armed guards!\n\n");
    }

    void stairs_2()
    {
        myText.text = ("");
    }

    void stairs_3()
    {
        myText.text = ("");
    }

    void floor()
    {
        myText.text = ("Rummaging around on the dirty floor, you find a hairclip.\n\n");
    }

    void corridor_1()
    {
        myText.text = ("Still in the corridor. Floor still dirty. Hairclip in hand. " +
        "Now what? You wonder if that lock on the closet would succumb to " +
        "to some lock-picking?\n\n");
    }

    void corridor_2()
    {
        myText.text = ("");
    }

    void corridor_3()
    {
        myText.text = ("You're standing back in the corridor, now convincingly dressed as a cleaner." 
            +"You strongly consider the run for freedom.\n\n");
    }

    void closet_door()
    {
        myText.text = ("You are looking at a closet door, unfortunately it's locked. " +
        "Maybe you could find something around to help enourage it open?\n\n");

    }

    void in_closet()
    {
        myText.text = ("Inside the closet you see a cleaner's uniform that looks about your size! " +
           "Seems like your day is looking-up.\n\n");
    }

    void courtyard()
    {
        myText.text = ("You walk through the courtyard dressed as a cleaner. " +
                "The guard tips his hat at you as you waltz past, claiming " +
        "your freedom. You heart races as you walk into the sunset.\n\n" +
        "Press P to Play again.");
    }




    void Start ()
    {
        myState = States.cell;
    }

	
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            Cell();       
        }

        else if (myState == States.sheets_0)
        {
            Sheets_0();
        }

        else if (myState == States.sheets_1)
        {
            sheets_1();
        }

        else if(myState == States.cell_mirror)
        {
            cell_mirror();
        }

        else if (myState == States.mirror)
        {
            mirror();
        }

        else if (myState == States.lock_1)
        {
            lock_1();
        }

        else if (myState == States.lock_0)
        {
            lock_0();
        }

        else if (myState == States.stairs_0)
        {
            stairs_0();
        }

        else if (myState == States.stairs_1)
        {
            stairs_1();
        }

        else if (myState == States.Stairs_2)
        {
            stairs_2();
        }

        else if (myState == States.Stairs_2)
        {
            stairs_2();
        }

        else if (myState == States.floor)
        {
            floor();
        }

        else if (myState == States.corridor_1)
        {
            corridor_1();
        }

        else if (myState == States.corridor_2)
        {
            corridor_2();
        }

        else if (myState == States.corridor_3)
        {
            corridor_3();
        }

        else if (myState == States.closet_door)
        {
            closet_door();
        }

        else if (myState == States.in_closet)
        {
            in_closet();
        }

        else if (myState == States.courtyard)
        {
            courtyard();
        }


    }
}
