using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int _correctAnswers = 0;
    private int _questionsSeen = 0;

    int CorrectAnswers
    {
        get { return _correctAnswers; }
    }

    int QuestionsSeen
    {
        get { return _questionsSeen; }
    }

    public int CalculateScore()
    {
        // cast 1 variable to float to ensure we get a float back from the equation
        // if we do not do this, the equation would return an int
        return Mathf.RoundToInt(_correctAnswers / (float)_questionsSeen * 100);
    }

    public void IncrementCorrectAnswers()
    {
        _correctAnswers++;
    }

    public void IncrementQuestionsSeen()
    {
        _questionsSeen++;
    }
}
