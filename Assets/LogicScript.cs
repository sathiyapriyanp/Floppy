using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScene;

    public void addScore()
    {
        playerScore = playerScore + 1;
        score.text = playerScore.ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

    }
    public void GameOver()
    {
        gameOverScene.SetActive(true);
    }
}
