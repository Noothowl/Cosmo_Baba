using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_script : MonoBehaviour
{
    protected int score;
    public Text scoretext;
    public GameObject GameOverScreen;
    public AudioSource score_sound;
    public AudioSource death_sound;
    public p_script player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<p_script>();
        


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
    }



}
