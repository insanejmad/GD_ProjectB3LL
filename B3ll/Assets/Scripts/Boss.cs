using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    public float modifh = 0.01f;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    private float hauteurX;
    private float hauteurY;
    private bool isGoingUp;
    private bool isGoingDown;
    private bool isGoingDownLeft;
    private bool isGoingLeft;
    private bool isGoingRight;
    private bool isGoingUpRight;

    // Use this for initialization
    void Start () {
        hauteurX = transform.position.x;
        hauteurY = transform.position.y;
        isGoingUp = true;
        isGoingDown = false;
        isGoingDownLeft = false;
        isGoingRight = false;
        isGoingUpRight = false;
        isGoingLeft = false;
}
	
	// Update is called once per frame
	void Update () {
        Vector3 dp = new Vector3();
        hauteurX = transform.position.x;
        hauteurY = transform.position.y;

        if (isGoingUp == true)
        {
            dp.y += modifh;
            transform.position += dp;
            if (transform.position.y >= pos2.transform.position.y)
            {
                isGoingUp = false;
                isGoingRight = true;
            }
        }
        if (isGoingRight == true)
        {
            dp.x += modifh;
            transform.position += dp;
            if (transform.position.x >= pos3.transform.position.x)
            {
                isGoingRight = false;
                isGoingDown = true;
            }
        }
        if (isGoingDown == true)
            {
            dp.y -= modifh;
            transform.position += dp;
            if (transform.position.y <= pos4.transform.position.y)
            {
                isGoingDown = false;
                isGoingUpRight = true;
            }
        }
        if (isGoingUpRight == true)
        {
            dp.y += modifh;
            transform.position += dp;
            if (transform.position.y >= pos3.transform.position.y)
            {
                isGoingUpRight = false;
                isGoingLeft = true;
            }
        }
        if (isGoingLeft == true)
        {
            dp.x -= modifh;
            transform.position += dp;
            if (transform.position.x <= pos2.transform.position.x)
            {
                isGoingLeft = false;
                isGoingDownLeft = true;
            }
        }
        if (isGoingDownLeft == true)
        {
            dp.y -= modifh;
            transform.position += dp;
            if (transform.position.y <= pos1.transform.position.y)
            {
                isGoingDownLeft = false;
                isGoingUp = true;
            }
        }
    }
}
