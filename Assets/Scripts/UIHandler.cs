using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour
{
    public static UIHandler Instance;

    public static Sprite selectedTheme;
    public static Sprite selectedPaddle;
    public static Sprite selectedBall;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LoadScene()
    {
        SceneHandler.Instance.LoadGameScene();
    }

    public void SelectTheme(Sprite theme)
    {
        selectedTheme = theme;
    }

    public Sprite GetTheme()
    {
        return selectedTheme;
    }

    public void SelectPaddle(Sprite paddle)
    {
        selectedPaddle = paddle;
    }

    public Sprite GetPaddle()
    {
        return selectedPaddle;
    }

    public void SelectBall(Sprite ball)
    {
        selectedBall = ball;
    }

    public Sprite GetBall()
    {
        return selectedBall;
    }

}

