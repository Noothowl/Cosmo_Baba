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

    public p_script player;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<p_script>();

    }

    public void AddScore(int scorepoint)
    {
        if (player.alive)
        {
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
        GameOverScreen.SetActive(true);
    }



}
