using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClickSound : MonoBehaviour
{
    public AudioSource playClickSound;

    public void playClickSFX()
    {
        playClickSound.Play();
    }
}
