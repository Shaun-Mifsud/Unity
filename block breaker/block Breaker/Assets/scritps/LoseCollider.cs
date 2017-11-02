using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    public levelManager myLevelManager;


    //is called when collision happens
    void OnCollisionEnter2D(Collision2D collision)
    {
        print("collision happened with "+ collision.gameObject.name);
        
    }

    //is called when collider is a trigger

    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Triggered by " + collision.gameObject.name);
        myLevelManager.LoadLevel("win");
    }

    void Start () {
		

	}
	

	void Update () {
		

	}
}
