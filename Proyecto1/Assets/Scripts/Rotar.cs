using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {

    public float angles = 30;
    public Vector3 axis;//crear un eje
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(axis, angles * Time.deltaTime);
	}

    
}
