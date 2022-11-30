using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownMovement2 : MonoBehaviour
{
    [SerializeField] private float updownspeed2;

    private Rigidbody2D rb2;
    private BoxCollider2D bc2;

    public PhotonView pv2;

    private void Awake2()
    {
        rb2 = GetComponent<Rigidbody2D>();
        bc2 = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        CheckInput2();
        /*if(pv.isMine)
        {
            CheckInput();
        }*/
    }

    private void CheckInput2()
    {
        Vector3 posY = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            posY.y += updownspeed2 * Time.deltaTime; 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            posY.y -= updownspeed2 * Time.deltaTime;
        }
        transform.position = posY;
    }
}
