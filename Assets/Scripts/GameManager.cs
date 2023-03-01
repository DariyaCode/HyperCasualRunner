using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MenuUI;
    public GameObject GamePlayIU;
    public GameObject spawner;
    public GameObject BGPartical;

    public static GameManager instance;
    public bool gameStarted = false;

    Vector3 originalCamPos;

    public GameObject player;

    int lives = 2;
    int score = 0;

    public Text LivesText;
    public Text ScoreText;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        originalCamPos = Camera.main.transform.position;
    }

    public void StartGame()
    {
        gameStarted = true;

        MenuUI.SetActive(false);
        GamePlayIU.SetActive(true);
        spawner.SetActive(true);
        BGPartical.SetActive(true);
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
            LivesText.text = "Lives : " + lives;
        }
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = "Score : " + score;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Shake()
    {
        StartCoroutine("CameraShake");
    }

    IEnumerator CameraShake() 
    {
        for(int i = 0; i < 5; i++)
        {
            Vector2 randomPos = Random.insideUnitCircle * 0.5f;

            Camera.main.transform.position = new Vector3(randomPos.x, randomPos.y, originalCamPos.z);

            yield return null;
        }
        Camera.main.transform.position = originalCamPos;
    }

}
