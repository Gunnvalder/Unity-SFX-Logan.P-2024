using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScript : MonoBehaviour
{
    private AudioSource musicSource;

    BoxCollider musicTrigger;

    private void Awake()
    {
        musicSource = GetComponent<AudioSource>();
        musicTrigger = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        musicSource.Play();
    }
}
