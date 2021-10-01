using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public int highScore;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        highScoreUI.text = highScore.ToString();
        if(score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider is working");

        if(other.gameObject.tag == "scoreup")
        {
            score++;
        }
    }
}
