using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpDownMovement : MonoBehaviour
{
    [SerializeField] private float updownspeed;
    [SerializeField] KeyCode upKey,downKey;//Sets input as a variable so we can control it from Editor

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    public PhotonView pv;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        /*if(pv.isMine)
        {
            CheckInput();
        }*/
        CheckInput();
    }

    //Makes P1 and P2
    private void CheckInput()
    {
        Vector3 posY = transform.position;
        if (Input.GetKey(upKey))
        {
            posY.y += updownspeed * Time.deltaTime;
        }
        if (Input.GetKey(downKey))
        {
            posY.y -= updownspeed * Time.deltaTime;
        }
        transform.position = posY;
    }
}
