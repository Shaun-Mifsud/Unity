using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonGame : MonoBehaviour {
    public Text myText;

    private enum States
    {
        cell,sheets_0,mirror,lock_0,cell_mirror,sheets_1,lock_1,freedom
    };

    private States myState;

    void Cell()
    {
        print("You are in a prison cell, and you want to escape. There are " +
               "some dirty sheets on the bed, a mirror on the wall, and the door " +
               "is locked from the outside.\n\n" +
               "Press S to view Sheets, M to view Mirror and L to view Lock");
    }

    void Sheets_0()
    {
        print("You can't believe you sleep in these things. Surely it's " + "time somebody changed them. The pleasures of prison life " +
                 "I guess!\n\n" + "Press R to Return to roaming your cell");
    }

    void mirror()
    {

    }


    void Start ()
    {
        myState = States.cell;
        myText.text = "Bongu";
    }

	
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            Cell();       
        }

        if (myState == States.sheets_0)
        {
            Sheets_0();
        }




    }
}
