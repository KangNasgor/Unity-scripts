using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float speed = 5;
    public int poin;
    public int jumlahSampah;
    public Text textSampah;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        rb.velocity = speed * new Vector2(horiz, verti);

        UpdatePoinText();
    }
    public void UpdatePoinText()
    {
        textSampah.text = jumlahSampah.ToString();
    }
}