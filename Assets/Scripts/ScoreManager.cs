using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;


public class ScoreManager : MonoBehaviour
{
    private int score;

    public Text ScoreText;


    public void increaseScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);

    }


}
