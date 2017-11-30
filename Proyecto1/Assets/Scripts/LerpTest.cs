using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour {
    public Vector3 a;
    public Vector3 b;
    public float progress = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = Vector3.Lerp(a, b, progress);
        transform.position = Vector3.LerpUnclamped(a, b, progress);
    }
}
