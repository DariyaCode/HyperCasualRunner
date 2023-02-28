using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameStarted = false;
    public GameObject player;

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

}
