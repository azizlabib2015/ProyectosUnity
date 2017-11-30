using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransform : MonoBehaviour {

    public Vector3 global;
    public Vector3 local;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        global = transform.position;
        local = transform.localPosition;
	}
}
