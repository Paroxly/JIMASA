using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    private int setScore;
    public int currentScore;
    public int requiredScore;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = setScore;
        scoreText.text = "Score: " + currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore >= requiredScore)
        {
            SceneManager.LoadScene("Win");
        }

        scoreText.text = "Score: " + currentScore;
    }

    public void incScore(int score)
    {
        currentScore += score;
    }
}
