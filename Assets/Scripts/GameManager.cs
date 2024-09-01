using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    SpriteRenderer themeRenderer;
    [SerializeField]
    SpriteRenderer leftPaddleRenderer, rightPaddleRenderer;
    [SerializeField]
    SpriteRenderer ballRenderer;

    public int scorePl1 = 0;
    public int scorePl2 = 0;

    private const int WIN_SCORE = 5;

    public bool isGameOver = false;

    private void Start()
    {
        ChangeTheme();
    }
    void Update()
    {
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoreText.text = scorePl1 + " : " + scorePl2;
    }

    public void WinChech()
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

    public void ChangeTheme()
    {
        if (UIHandler.selectedTheme != null)
        {
            themeRenderer.sprite = UIHandler.selectedTheme;
        }
        if (UIHandler.selectedPaddle != null)
        {
            leftPaddleRenderer.sprite = UIHandler.selectedPaddle;
            rightPaddleRenderer.sprite = UIHandler.selectedPaddle;
        }
        if (UIHandler.selectedBall != null)
        {
            ballRenderer.sprite = UIHandler.selectedBall;
        }
    }

    public bool GameOver(bool isGameOver)
    {
        if (isGameOver)
        {
            // Load restart scene
        }
        return isGameOver;
    }
}
