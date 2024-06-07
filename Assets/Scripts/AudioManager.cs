using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------Audio Source------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("------Audio Clip------")]
    public AudioClip background;
    public AudioClip landing;
    
    public AudioClip collectbronze;
    public AudioClip collectsilver;
    public AudioClip collectgold;
    public AudioClip flipping;
    public AudioClip transition;
    public AudioClip buttons;
    public AudioClip move;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
