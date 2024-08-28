using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    public int scorePl1 = 0;
    public int scorePl2 = 0;

    private const int WIN_SCORE = 10;

    public bool isGameOver = false;
 
    void Update()
    {
        updateScore();
    }
    public void updateScore()
    {
        scoreText.text = scorePl1 + " : " + scorePl2;
    }
    
    public void checkWin()
    {
        if (scorePl1 == WIN_SCORE)
        {
            isGameOver = true;
            Debug.Log("Player1 is a winner!");
        }
        if (scorePl2 == WIN_SCORE) 
        {
            isGameOver = true;
            Debug.Log("Player2 is a winner!");
        }
    }
}
