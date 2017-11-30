using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float horizontal;
    
    public float speed = 5;

    void Start () {
		
	}
	
	
	void Update () {
       

        
        horizontal = Input.GetAxis("Horizontal"); //Variable horizontal el Input Horizontal creado previamente
        Vector3 movement = new Vector3(0, 0, horizontal); //Creamos el Vector
        movement = movement.normalized * speed * Time.deltaTime;//Le añadimos la velocidad
        transform.Translate(movement);//Aplica el movimiento con la velocidad
        transform.position += transform.forward * movement.z;//Movor hacia delante en el eje Z

        
    }
}
