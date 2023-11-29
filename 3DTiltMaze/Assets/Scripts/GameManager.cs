using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject youWinText;

    private AudioSource audioSource1;
    public AudioClip winSound1;

    private AudioSource audioSource2;
    public AudioClip winSound2;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if(instance != null)
        {
            Destroy(gameObject);
        }

        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = gameObject.AddComponent<AudioSource>();
    }

    public void Win()
    {
        //display win message
        youWinText.SetActive(true);

        if(audioSource1.isPlaying)
        {
            audioSource1.Stop();
        }

        if(winSound2 != null)
        {
            audioSource2.clip = winSound2;
            audioSource2.Play();
        }
    }
}
