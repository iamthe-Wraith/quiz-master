using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalSoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        int score = scoreKeeper.CalculateScore();

        string pre = score < 50 ? "Bummer..." : "Congratulations!";

        finalSoreText.text = pre + "\nYou scored " + score + "%";
    }
}
