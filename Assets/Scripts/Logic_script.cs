using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Logic_script : MonoBehaviour
{
    protected int score;
    protected int highScore;
    public Text scoretext;
    public Text highscoreText;
    public GameObject GameOverScreen;
    public AudioSource score_sound;
    public AudioSource death_sound;
    public p_script player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<p_script>();
        highscoreText.text = "High score: "+PlayerPrefs.GetInt("highScore", 0).ToString();



    }

    public void AddScore(int scorepoint)
    {
        if (player.alive)
        {
            score_sound.Play();
            score += scorepoint;
            scoretext.text = score.ToString();

        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void GameOver()
    {
        death_sound.Play();
        GameOverScreen.SetActive(true);

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);

            highscoreText.text = "New Record: " +highScore.ToString();
            highscoreText.color = Color.gray;


        }



    }



}
