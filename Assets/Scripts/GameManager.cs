using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Winner
{
    None, Player1, Player2
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Winner winner;

    [SerializeField]
    private int scorePl1 = 0;
    [SerializeField]
    private int scorePl2 = 0;

    private const int WIN_SCORE = 1;

    public bool isGameOver { get; private set; } = false;

    private bool hasSceneChanged = false;

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

    void Update()
    {
        WinnerCheck();
    }

    public int GetScorePl1()
    {
        return scorePl1;
    }

    public int GetScorePl2() 
    {
        return scorePl2;
    }

    public void IncrementScorePlayer1()
    {
        scorePl1++;
    }
    public void IncrementScorePlayer2() 
    {
        scorePl2++;
    }
    

    public void WinnerCheck()
    {
        if (scorePl1 >= WIN_SCORE && !isGameOver)
        {
            winner = Winner.Player1;
            GameOver();
        }
        if (scorePl2 >= WIN_SCORE && !isGameOver) 
        {
            winner = Winner.Player2;
            GameOver();
        }
    }

    public void GameOver()
    {        
        if (!hasSceneChanged)
        { 
            SceneHandler.Instance.LoadRestartScene();
            hasSceneChanged = true;
            isGameOver = true;

            Debug.Log("Game is over");
        }
    }

    public void ResetGame()
    {
        isGameOver = false;
        winner = Winner.None;

        scorePl1 = 0;
        scorePl2 = 0;

        Debug.Log("Game is reset");
    }

    // Destroys instances of persistent objects
    public void DestroyInstance()
    {
        GameObject[] persistentObjects = GameObject.FindGameObjectsWithTag("Persistent");
        foreach (GameObject persistentObject in persistentObjects)
        {
            Destroy(persistentObject);
        }

        Debug.Log("Persistent game objects destroyed");
    }

}
