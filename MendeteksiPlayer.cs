using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MendeteksiPlayer : MonoBehaviour
{
    public MunculkanAudio scriptAudio;
    void Start()
    {
        scriptAudio.enabled = false;
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scriptAudio == true)
        {
            if (collision.CompareTag("Player"))
            {
                scriptAudio.enabled = true;
                StartCoroutine("Enumerator");
            }
        }
        else if(scriptAudio == null)
        {
         //   Debug.Log("hai");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(scriptAudio);
    }
    private IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(0.001f);
        scriptAudio.enabled = false;
    }
}
