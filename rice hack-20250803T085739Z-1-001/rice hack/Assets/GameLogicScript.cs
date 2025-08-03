using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogicScript : MonoBehaviour
{
    public int playerScore;
    [SerializeField] TextMeshProUGUI testScore;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    public AudioSource normalDingSFX;
    public AudioSource fifthDingSFX;
    public AudioSource tenthDingSFX;
    public AudioSource gameOverSFX;

    [ContextMenu("Increase Score")] //good for testing
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        testScore.text = "Your score: " + playerScore.ToString();
        if (playerScore % 10 == 0)
        {
            tenthDingSFX.Play();
        }
        else if(playerScore % 5 == 0)
        {
            fifthDingSFX.Play();
        }
        else
        {
            normalDingSFX.Play();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverSFX.Play();
    }

    public void goToHome()
    {
        SceneManager.LoadScene(0);
        gameOverScreen.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
}
