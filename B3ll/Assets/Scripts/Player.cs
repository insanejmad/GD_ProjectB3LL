using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /* Variables publiques = check ton inspector, au niveau du script, tu peux bidouiller les variables comme tu veux ! */
    public float speed = 0.10f;
    public float jumph = 0.10f;

    private Animator anim;

    private float jumpTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        jumpTime = 5f;
    }

    void Update()
    {
        move();
    }

    void move()
    {
        Vector3 dp = new Vector3();

        /* PREVOIR LE CHANGEMENT MARCHE/COURSE !!!!! */

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
            anim.Play("RunR");
        }

        if (Input.GetKey(KeyCode.Q))
        {
            dp.x += speed;
            //anim.Play("RunL");
        }

        if (Input.touchCount == 0)
            anim.Play("Idle");

        transform.position += dp;

    }
}
