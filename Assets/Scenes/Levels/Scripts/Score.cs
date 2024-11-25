using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    private int currentScore;
    void Start()
    {
        text.text = "0";
        currentScore = 0;
    }

    // Update is called once per frame
    public void UpdateScore(int score)
    {
        currentScore += score;
        text.text = currentScore.ToString();
    }

    public int GetScore()
    {
        return currentScore;
    }
}
