using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static GameObject ball;
    [SerializeField] float speed;
    [SerializeField] GameObject firstball;

    private void Start()
    {
        ball = firstball;//
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(ball.transform.position.x, ball.transform.position.y,-10), speed);
        //
    }
    
}