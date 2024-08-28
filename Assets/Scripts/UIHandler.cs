using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private Button[] buttonTheme;
   
    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
