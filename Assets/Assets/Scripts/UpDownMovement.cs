using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    [SerializeField] private float updownspeed1,updownspeed2;

    private Rigidbody2D rb1,rb2;
    private BoxCollider2D bc1,bc2;

    public PhotonView pv1,pv2;

    private void Awake()
    {
        rb1 = GetComponent<Rigidbody2D>();
        bc1 = GetComponent<BoxCollider2D>();

        rb2 = GetComponent<Rigidbody2D>();
        bc2 = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        /*if(pv.isMine)
        {
            CheckInput();
        }*/
        if(gameObject.tag == "P1")
        {
            CheckInput1();
        }
        else if(gameObject.tag == "P2/AI")
        {
            CheckInput2();
        }
    }

    private void CheckInput1()
    {
        Vector3 posY1 = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            posY1.y += updownspeed1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            posY1.y -= updownspeed1 * Time.deltaTime;
        }
        transform.position = posY1;
    }
    private void CheckInput2()
    {
        Vector3 posY2 = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            posY2.y += updownspeed2 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            posY2.y -= updownspeed2 * Time.deltaTime;
        }
        transform.position = posY2;
    }
}
