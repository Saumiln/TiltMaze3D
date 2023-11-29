using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public AudioClip rollingSound;  // Assign the audio clip in the Unity Editor
    private AudioSource audioSource;
    private Rigidbody rb;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();

        if(rollingSound == null)
        {
            Debug.LogError("Rolling sound not assigned!");
        }
        else
        {
            audioSource.clip = rollingSound;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > 0.1f && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if(rb.velocity.magnitude < 0.1f && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "goal")
        {
            Destroy(gameObject,2f);
            Debug.Log("You Win!");
            GameManager.instance.Win();
        }
    }
}
