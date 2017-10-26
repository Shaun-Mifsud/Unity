using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer=null;

     void Awake()
     {
        //if my musicplayer is the 1st instance 
        if (myMusicPlayer == null)
        {
            //mymusicplayer = 1st sound object

            myMusicPlayer = this;
            //this.gameObejct = the gameObject attached to this
            //script, in our case soundObject
            //DontDestroyOnLoad = do not destroy the gameObject
            //when changing scenes
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else //if mymusicplayer is not null 
             //if soundobject already exists
        {
            print("sound object " + this.gameObject.GetInstanceID().ToString());
            //destroy the 2nd gameObject created
            Destroy(this.gameObject);
        }
     }

    void Start () {
           
 
	}
	

	void Update () {
		
	}
}
