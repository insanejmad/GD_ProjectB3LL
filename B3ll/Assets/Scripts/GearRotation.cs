using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearRotation : MonoBehaviour {
    public float rotationSpeed = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 dp = new Vector3();
        dp.z += rotationSpeed;
        transform.Rotate(dp);
    }
}
