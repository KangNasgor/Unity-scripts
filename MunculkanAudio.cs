using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanAudio : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip Clip;
    void Start()
    {
        
    }
    void Update()
    {
        Audio();
    }
    private void Audio()
    {
        Source.PlayOneShot(Clip);
    }
}
