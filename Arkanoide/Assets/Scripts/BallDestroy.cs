using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour {
	//Float que dice en el estado que esta el objeto
	public float state = 0;
	// Cuando colisiona añade un estado 
	void OnCollisionEnter(Collision col){
		state = state + 1;




	
	
	}
	void CheckColor(){
		//Dependiendo del estado tendra un color u otro 
		if (state == 1) {
			transform.GetComponent<Renderer> ().material.color = Color.yellow;
		}
		if (state == 2) {
			transform.GetComponent<Renderer> ().material.color = Color.red;
		}
		if (state == 3) {
			transform.GetComponent<Renderer> ().material.color = Color.white;
		}
		if (state == 4) {
			Destroy (gameObject);
		}
	}
	void Update(){
		CheckColor();
	}
}
