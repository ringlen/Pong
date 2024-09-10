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

    // When cursor hovers the button text changes
    public void OnPointerEnter(PointerEventData eventData)
    {
        childText.SetActive(true);
        childSelectText.SetActive(false);
    }
    // When cursor is out of area text returns to its starting position
    public void OnPointerExit(PointerEventData eventData)
    {
        childText.SetActive(false);
        childSelectText.SetActive(true);
    }
}
