using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public static SceneHandler Instance;

    public bool isGameSceneLoaded { get; private set; } = false;
    public enum Scene
    {
        GameScene,
        MenuScene,
        RestartScene
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void LoadRestartScene()
    {
        SceneManager.LoadScene(Scene.RestartScene.ToString());
        Debug.Log("Restart Scene loaded");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(Scene.GameScene.ToString());
        Debug.Log("Game Scene loaded");
        isGameSceneLoaded = true;

        if (GameManager.Instance != null)
        {
            GameManager.Instance.ResetGame();
            GameManager.Instance.DestroyInstance();
        }
    }

    public void QuitToMenuScene()
    {
        SceneManager.LoadScene(Scene.MenuScene.ToString());
        Debug.Log("Quit To Menu Scene loaded");

        GameManager.Instance.DestroyInstance();
    }
    
}
