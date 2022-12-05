using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballmovespeed;

    private Vector3 posX, posY;

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
        posX = transform.position;
        posY = transform.position;
        if(Input.GetKey(KeyCode.Space))
        {
            posX.x += ballmovespeed * Time.deltaTime;
            transform.position = posX;
            Debug.Log(transform.position);
            posY.y += ballmovespeed * Time.deltaTime;
            transform.position = posY;
            //Debug.Log(transform.position);
        }
    }
}
