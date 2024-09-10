using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField]
    private GameObject childText;
    [SerializeField]
    private GameObject childSelectText;

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
}
