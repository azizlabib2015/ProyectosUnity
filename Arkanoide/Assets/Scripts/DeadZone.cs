using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

	public Transform spawnBallPosition;
    GameObject ball;
    private void Start()
    {
        // ball= ballCollider.gameObject;
        //spawnBallPosition =ball.transform.
    }

    private void OnTriggerEnter(Collider ballCollider)
	{
		
		//Mover la bola al punto de spawn
		ball.transform.position = spawnBallPosition.position;
		ball.transform.rotation = spawnBallPosition.rotation;

		//Poner a cero las velocidades del rigidbody
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
	}
}