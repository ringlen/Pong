using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private GameObject childText;
    [SerializeField]
    private GameObject childSelectText;

    public static Sprite selectedTheme;
    public static Sprite selectedPaddle;
    public static Sprite selectedBall;

    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        childText.SetActive(true);
        childSelectText.SetActive(false);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        childText.SetActive(false);
        childSelectText.SetActive(true);
    }

    public void SelectTheme(Sprite theme)
    {
        selectedTheme = theme;
    }

    public void SelectPaddle(Sprite paddle)
    {
        selectedPaddle = paddle;
    }

    public void SelectBall(Sprite ball)
    {
        selectedBall = ball;
    }

}

