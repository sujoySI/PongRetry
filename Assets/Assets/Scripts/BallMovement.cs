using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballmovespeed;

    private Vector3 pos;

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        PongMovement();
    }

    private void PongMovement()
    {
        pos = transform.position;
        if(Input.GetKey(KeyCode.Space))
        {
            pos.x += ballmovespeed * Time.deltaTime;
            pos.y += ballmovespeed * Time.deltaTime;
            transform.position = pos;
        }
    }
}
