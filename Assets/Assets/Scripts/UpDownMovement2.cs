using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement2 : MonoBehaviour
{
    [SerializeField] private float updownspeed;

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
        CheckInput();
        /*if(pv.isMine)
        {
            CheckInput();
        }*/
    }

    private void CheckInput()
    {
        var move = new Vector3(0, Input.GetAxisRaw("Vertical"));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += move * updownspeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += move * updownspeed * Time.deltaTime;
        }
    }
}
