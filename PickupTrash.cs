using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using TMPro;
public class PickupTrash : MonoBehaviour
{
    public Controller player;
    private void Start()
    {
        player.UpdatePoinText();
    } 
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.jumlahSampah += 1;
            Destroy(gameObject);
        }
        player.UpdatePoinText();
    }
}
