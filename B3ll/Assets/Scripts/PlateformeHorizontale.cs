using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeHorizontale : MonoBehaviour {

    public float modifh = 0.01f;
    public Transform minh;
    public Transform maxh;
    private float hauteur;
    private bool isGoingUp;

    // Use this for initialization
    void Start () {
        hauteur = transform.position.x;
        isGoingUp = true;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 dp = new Vector3();
        hauteur = transform.position.x;

        if(isGoingUp == true)
        {
            dp.x += modifh;
            transform.position += dp;
            if (transform.position.x >= maxh.transform.position.x)
                isGoingUp = false;
        }
        else
        {
            dp.x -= modifh;
            transform.position += dp;
            if (transform.position.x <= minh.transform.position.x)
                isGoingUp = true;
        }
    }
}
