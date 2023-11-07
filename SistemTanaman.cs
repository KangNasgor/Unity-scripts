using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemTanaman : MonoBehaviour
{
    public GameObject tanaman1;
    public GameObject tanaman2;
    public GameObject tanaman3;
    public GameObject tanaman4;
    private bool coroutineEnds = false;
    private bool spawnerOn = false;
    public GameObject coin;
    public Transform coinSpawnerPosition;
    private float jumlahCoin;
    void Update()
    {
        if (!coroutineEnds)
        {
            StartCoroutine("tanaman");
        }
        if(spawnerOn == true)
        {
            StartCoroutine("coinSpawner");
        }
        Debug.Log(jumlahCoin);
    }
    private IEnumerator tanaman()
    {
        coroutineEnds = true;
        tanaman1.SetActive(true);
        yield return new WaitForSeconds(5f);
        tanaman2.SetActive(true);
        tanaman1.SetActive(false);
        yield return new WaitForSeconds(5f);
        tanaman3.SetActive(true);
        tanaman2.SetActive(false);
        yield return new WaitForSeconds(5f);
        tanaman4.SetActive(true);
        tanaman3.SetActive(false);
        spawnerOn = true;
    }
    private IEnumerator coinSpawner()
    {
        spawnerCoin();
        yield return new WaitForSeconds(60f);
    }
    private void spawnerCoin()
    {
        Instantiate(coin);
        jumlahCoin++;
        if(jumlahCoin >= 10)
        {
            spawnerOn = false;
        }
    }
}
