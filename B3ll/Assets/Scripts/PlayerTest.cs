using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    /* Variables publiques = check ton inspector, au niveau du script, tu peux bidouiller les variables comme tu veux ! */
    public float speed = 0.10f;
    public float jumph = 0.10f;

    private Animator anim;
    private bool isRunning;
    private float jumpTime;

    void Start()
    {
        anim = GetComponent<Animator>();
        isRunning = false;
        jumpTime = 5f;
    }

    void Update()
    {
        Vector3 dp = new Vector3();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (isRunning == true)
                isRunning = false;
            else isRunning = true;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            dp.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dp.x += speed;
            if (isRunning == false)
                anim.Play("Walk");
            else anim.Play("RunR");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            dp.x += speed;
            dp.y += speed;
            anim.SetTrigger("Jump");
        }

        jumpTime -= Time.deltaTime;

        if (jumpTime == 0)
            anim.SetTrigger("Land");

        /*
        if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.D))
        {
            dp.x += jumph;
            anim.Play("JumpR");
        }
        */

        transform.position += dp;
    }
}
