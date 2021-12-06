using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public Text timeText;

    private void Start()
    {
        timerIsRunning = true; //timer-ul porneste automat, odata cu jocul
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0) //daca timpul ramas este mai mare decat 0 secunde
            {
                timeRemaining -= Time.deltaTime; //se actualizeaza timpului ramas la fiecare secunda 
                DisplayTime(timeRemaining); //timpul ramas este afisat pe ecran
            }
            else
            {
                Debug.Log("Time has run out!"); //timpul a expirat
                timeRemaining = 0;
                timerIsRunning = false; //timer-ul se opreste
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //calculul minutelor
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //calculul secundelor

        timeText.text = string.Format("TIME LEFT {0:00}:{1:00} ", minutes, seconds); //formatare timer
    }
}
