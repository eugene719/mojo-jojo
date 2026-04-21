using UnityEngine;

public class SimpleAudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip actionSoundEffect;

    void Start()
    {
        // 1. Setup Background Music
        if (backgroundMusic != null && bgmSource != null)
        {
            bgmSource.clip = backgroundMusic;
            bgmSource.loop = true; // Make it loop
            bgmSource.playOnAwake = true; // Start immediately
            bgmSource.Play();
        }
    }

    void Update()
    {
        // 2. Detect Input (Space bar or Left Mouse Click)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            PlaySFX();
        }
    }

    void PlaySFX()
    {
        if (actionSoundEffect != null && sfxSource != null)
        {
            // PlayOneShot allows multiple sounds to overlap without cutting off
            sfxSource.PlayOneShot(actionSoundEffect);
        }
    }
}