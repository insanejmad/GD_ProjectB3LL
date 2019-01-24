using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeVerticale : MonoBehaviour {

    public float modifh = 0.01f;
    public Transform minh;
    public Transform maxh;
    private float hauteur;
    private bool isGoingUp;

    // Use this for initialization
    void Start () {
        hauteur = transform.position.y;
        isGoingUp = true;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dp = new Vector3();
        hauteur = transform.position.y;

        if(isGoingUp == true)
        {
            dp.y += modifh;
            transform.position += dp;
            if (transform.position.y >= maxh.transform.position.y)
                isGoingUp = false;
        }
        else
        {
            dp.y -= modifh;
            transform.position += dp;
            if (transform.position.y <= minh.transform.position.y)
                isGoingUp = true;
        }
    }
}
