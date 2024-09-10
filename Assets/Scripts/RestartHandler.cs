using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartHandler : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer themeRestartRandere;
    [SerializeField]
    private TextMeshProUGUI scorePlayer1Text, scorePlayer2Text;
    [SerializeField]
    private TextMeshProUGUI winnerText;

    public void Start()
    {
        ChangeTheme();
        DisplayScore();
        DisplayWinner();
    }
    public void ChangeTheme()
    {
        themeRestartRandere.sprite = UIHandler.Instance.GetTheme();
    }

    public void DisplayScore()
    {
        if (GameManager.Instance != null) 
        {
            scorePlayer1Text.text = GameManager.Instance.GetScorePl1().ToString();
            scorePlayer2Text.text = GameManager.Instance.GetScorePl2().ToString();
        }
        else
        {
            Debug.Log(GameManager.Instance);
        }
    }


    public void DisplayWinner()
    {
        if (GameManager.Instance != null)
        {
            switch (GameManager.Instance.winner)
            {
                case Winner.Player1:
                    winnerText.text = "Player 1 WINS";
                    break;
                case Winner.Player2:
                    winnerText.text = "Player 2 WINS";
                    break;
                default:
                    winnerText.text = "TIE";
                    break;
            }
        }
        else
        {
            Debug.Log(GameManager.Instance);
        }
       
    }

    public void RestartGame()
    {
        SceneHandler.Instance.LoadGameScene();
    }

    public void QuitToMenu()
    {
        SceneHandler.Instance.QuitToMenuScene();
    }

    public void ButtonAudio()
    {
        AudioManager.Instance.PlayButtonAudio();
    }
}
