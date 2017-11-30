using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    public Rigidbody myRigibody;
    public float pushForce;
    public Vector3 direction;
    public bool fired;
	// Use this for initialization
	void Start () {
        fired = false;
        direction = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
        if (!fired && Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 force = direction * pushForce;
            myRigibody.AddForce(force,ForceMode.VelocityChange);
            fired = true;
        }
	}
}
