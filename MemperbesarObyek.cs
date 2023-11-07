using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemperbesarObyek : MonoBehaviour
{
    public GameObject circle;
    private bool clicked = false;
    public Rigidbody2D rb;
    Vector2 originalSize;
    public float seconds = 3;
    public AudioSource source;
    public AudioClip sound;
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        originalSize = transform.localScale;
    }
    void Update()
    {
        float size = 5;
        size +=  Time.deltaTime;
        float transition = size * Time.deltaTime;
        Transform circleScale = circle.transform;
        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.localScale = new Vector2(transform.localScale.x * 4, transform.localScale.y * 4);
            StartCoroutine(originalPos());
            source.PlayOneShot(sound);
        }

        IEnumerator originalPos()
        {
            yield return new WaitForSeconds(seconds);
            transform.localScale = originalSize;
        }
    }
}
