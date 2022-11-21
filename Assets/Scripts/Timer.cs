using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float fillFraction = 1f;
    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion = false;

    [SerializeField] float timeToGuessAnswer = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    
    float timerValue;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    private void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if(timerValue <= 0)
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
            else
            {
                fillFraction = timerValue / timeToGuessAnswer;
            }
        } 
        else
        {
            if(timerValue <= 0)
            {
                isAnsweringQuestion = true;
                timerValue = timeToGuessAnswer;
                loadNextQuestion = true;
            }
            else
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
        }

        Debug.Log(isAnsweringQuestion + " : " + timerValue + " = " + fillFraction);
    }
}
