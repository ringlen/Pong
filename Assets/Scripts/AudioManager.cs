using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] audioSources;

    public static AudioManager Instance;
    public enum Audio
    {
        BackgroundAudio,
        ButtonAudio,
        ScoreSound,
        PaddleHitAudio,
        BounceOfWallAudio     
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
    void Start()
    {
        PlayBackgroundAudio();
        Debug.Log("Music plays");

    }

    // Update is called once per frame
    void Update()
    {
        HandleAudio();
    }

    public void PlayBackgroundAudio()
    {
        audioSources[(int)Audio.BackgroundAudio].Play();
    }
    public void PlayButtonAudio()
    {
        audioSources[(int)Audio.ButtonAudio].Play();
    }

    public void PlayScoreAudio() 
    {
        audioSources[(int)Audio.ScoreSound].Play();
    }

    public void PlayPaddleHitAudion()
    {
        audioSources[(int)Audio.PaddleHitAudio].Play();
    }

    public void PlayBounceOfWallAudio() 
    {
        audioSources[(int)Audio.BounceOfWallAudio].Play();
    }

    public void HandleAudio()
    {
        if (SceneHandler.Instance.isGameSceneLoaded)
        {
            audioSources[(int)Audio.BackgroundAudio].Stop();
        }
    }
}
