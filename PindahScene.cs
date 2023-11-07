using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public bool sudahPindah = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (!sudahPindah)
        {
            StartCoroutine("pindahScene");
        }
    }
    private IEnumerator pindahScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("SceneGadungan");
        sudahPindah = true;
    }
}
