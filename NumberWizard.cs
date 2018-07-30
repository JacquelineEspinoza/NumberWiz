using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int maxguess = 800;
    int minguess = 10;
    int guess = 395;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Hello fellow traveler, I am the Number Wizard");
        Debug.Log("I will be able to deduce a number from your deepest thoughts.");
        Debug.Log("The number you decide must be at most: " + maxguess);
        Debug.Log("The number you decide must be at least: ." +minguess);

        Debug.Log("Is your number higher or lower than 395?");
        Debug.Log("Push the Up arrow if your secret number is higher");
        Debug.Log("Push the Down arrow if your secret number is lower");
        Debug.Log("Push the Enter Key if I guessed your secret number correctly");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("AHA just as I suspected, The Up Arrow was pressed your number is higher.");
            minguess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("OHO just as I had assumed, The Down Arrow was pressed your number is lower.");
            maxguess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("EUREKA THE NUMBER WIZARD IS SUCCESSFUL ONCE AGAIN I HAVE GUESSED IT!");
        }
	}
}
