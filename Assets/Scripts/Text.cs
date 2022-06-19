using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public KeyCode textButton = KeyCode.Space;
    public GameObject text;
    public GameObject ball;
    private Rigidbody2D rb2d;
    void Start() 
    {
        text.SetActive(true);
        rb2d = ball.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(textButton))
        {
            text.SetActive(false);
            rb2d.gravityScale = 30;
        }
    }
}
