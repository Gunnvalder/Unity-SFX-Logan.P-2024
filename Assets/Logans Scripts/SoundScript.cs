using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private AudioSource sound;

    BoxCollider soundTrigger;

    // Start is called before the first frame update
    private void Awake()
    {
        sound = GetComponent<AudioSource>();
        soundTrigger = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
}
