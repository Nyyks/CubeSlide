using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartTime = 1f;

    public GameObject GameOver;
    public GameObject Canvas;
    public Text Score;
    public Text HighScore;
    public Transform PlayerPosition;
    private int ScoreInt;
    private int HighScoreInt;
    public Text score2;

   


    public void Fail()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("FailScreen", RestartTime);
        }
        
    } 

    public void FailScreen()
    {
        GameOver.SetActive(true);
        Canvas.SetActive(false);
        Time.timeScale = 0;
        Highscore();
        GetHighScore();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



    //Score Shit
    void Update()
    {
        Score.text = PlayerPosition.position.x.ToString("0");
        ScoreInt = int.Parse(Score.text);
        score2.text = PlayerPosition.position.x.ToString("0");
    }

    void Highscore()
    {
        if (ScoreInt > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ScoreInt);
        } 
    }

    void GetHighScore()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }






}
