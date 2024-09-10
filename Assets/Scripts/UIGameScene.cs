using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameScene : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    SpriteRenderer themeRenderer;
    [SerializeField]
    SpriteRenderer leftPaddleRenderer, rightPaddleRenderer;
    [SerializeField]
    SpriteRenderer ballRenderer;

    void Start()
    {
        ChangeTheme();
    }

    void Update()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = GameManager.Instance.GetScorePl1() + " : " + GameManager.Instance.GetScorePl2();
        }
    }

    public void ChangeTheme()
    {
        if (UIHandler.selectedTheme != null)
        {
            themeRenderer.sprite = UIHandler.Instance.GetTheme();
        }
        if (UIHandler.selectedPaddle != null)
        {
            leftPaddleRenderer.sprite = UIHandler.Instance.GetPaddle();
            rightPaddleRenderer.sprite = UIHandler.Instance.GetPaddle();
        }
        if (UIHandler.selectedBall != null)
        {
            ballRenderer.sprite = UIHandler.Instance.GetBall();
        }
    }
}
