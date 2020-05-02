using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 0;
    int min = 0;
    int guess = 0;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;

        Debug.Log("Guess a number between " + max + " and " + min + " but don't tell me");
        Debug.Log("Press UpArrow if your number is higher");
        Debug.Log("Press DownArrow if your number is lower");
        Debug.Log("Press Enter (Return) if my guess is correct");
        Debug.Log("Is your guess " + guess);
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            CalculateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            CalculateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Awesome, let's play again");
            StartGame();
        }
    }

    void CalculateGuess()
    {
        RandomeGuessStatement(); 
        guess = ((max + min) / 2);
        Debug.Log("Is " + guess + " your number?");
    }

    void RandomeGuessStatement()
    {
        int randomNumber = Random.Range(1, 5);
        if (randomNumber == 1)
        {
            Debug.Log("I am getting a little tense");
        }
        if (randomNumber == 2)
        {
            Debug.Log("Getting warmer.....");
        }
        if (randomNumber == 3)
        {
            Debug.Log("Hopefully not to far off");
        }
        if (randomNumber == 4)
        {
            Debug.Log("Almost there, I can feel it in my bits");
        }
    }
}
