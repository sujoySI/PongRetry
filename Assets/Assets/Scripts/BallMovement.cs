using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float ballmovespeed, accelerationTime, maxSpeed;
    private float timeLeft;

    private Vector3 pos;
    private Vector2 movement;

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
        //PongBallMove();
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

    /*private void PongBallMove()
    {
        pos = transform.position;
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            //movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            pos.x += /*new Vector3(Random.Range(-1f, 1f), 0)*//*Random.Range(-10f, 10f) * maxSpeed * Time.deltaTime;
            pos.y += /*new Vector3(0, Random.Range(-1f, 1f))*//*Random.Range(-10f, 10f) * maxSpeed * Time.deltaTime;
            transform.position = pos;
            timeLeft += accelerationTime;
        }
    }*/

    /*void FixedUpdate()
    {
        rb.AddForce(pos * maxSpeed);
    }*/
}
