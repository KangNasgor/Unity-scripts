using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class MenjualSampah : MonoBehaviour
{
    public Controller player;
    public int koin;
    public Text textKoin;
    private void Update()
    {
        UpdateKoinText();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "penjual")
        {
            koin += player.jumlahSampah;
            player.jumlahSampah -= player.jumlahSampah;
        }
        UpdateKoinText();
    }
    public void UpdateKoinText()
    {
        textKoin.text = koin.ToString();
    }
}
