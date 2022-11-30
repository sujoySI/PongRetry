using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement2 : MonoBehaviour
{
    [SerializeField] private float updownspeed1;

    private Rigidbody2D rb1;
    private BoxCollider2D bc1;

    public PhotonView pv1;

    private void Awake1()
    {
        rb1 = GetComponent<Rigidbody2D>();
        bc1 = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        CheckInput1();
        /*if(pv.isMine)
        {
            CheckInput();
        }*/
    }

    private void CheckInput1()
    {
        Vector3 posY = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            posY.y += updownspeed1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            posY.y -= updownspeed1 * Time.deltaTime;
        }
        transform.position = posY;
    }
}
