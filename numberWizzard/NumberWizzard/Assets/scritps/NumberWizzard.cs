using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizzard : MonoBehaviour {
    //variables
    int Tries=10;
    int Min=1;
    int Max=1001;
    int guess=500;


    public Text guessText;

    void NextGuess()
    {
        guessText.text = guess.ToString();

        guess = (Max +Min)/2;
        Tries --;

        if (Tries == 0)
        {
            SceneManager.LoadScene("win");
        }

        
    }

   public void LowGuess()
    {
        Max = guess;
        NextGuess();
    }

   public void HighGuess()
    {
        Min = guess;
        NextGuess();
    }


}
