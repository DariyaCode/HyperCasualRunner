using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameStarted = false;
    public GameObject player;

    int lives = 2;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void StartGame()
    {
        gameStarted = true;
    }

    public void GameOver()
    {
        player.SetActive(false);

        Invoke("ReloadLevel", 1.5f);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void UpdateLives() 
    {
        if(lives <= 0)
        {
            GameOver();
        }
        else
        {
            lives--;
            print("lives : " + lives);
        }
    }

    public void UpdateScore()
    {
        score++;
        print("score : " + score);
    }

}
