using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickScripts : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlaySegment()
    {
        audioSource.Play();
    }

}

