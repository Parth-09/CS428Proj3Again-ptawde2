using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    public void Play1()
    {
        sound.Play();
    }
}
