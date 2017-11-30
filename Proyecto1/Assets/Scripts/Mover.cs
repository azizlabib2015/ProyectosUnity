using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public Transform myTransform;//crear un objeto de tipo transformador
    public Vector3 sum;//crear
	// Use this for initialization
	void Start () {
        myTransform = gameObject.GetComponent<Transform>();
        Vector3 pos = myTransform.position;
        pos += sum;

        myTransform.position = pos;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
