using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.

public class Movimiento : MonoBehaviour {

    public float horizontal;
    
    public float speed = 5;
    public GameObject ball;
    public Rigidbody rb;
    public LauncherBall lb;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject Object = collision.gameObject;
        if (Object.name == "Ball")
        {
            Vector3 pivote = transform.position;
            Vector3 pointDirection = collision.transform.position;
            Vector3 direction = pointDirection - pivote;
            Vector3 vectorDirection = direction * lb.pushForce;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(vectorDirection.normalized, ForceMode.Impulse);
        }
        else if (Object.name == "wRight")
        {

            Debug.Log(Object.name);
        }
        
    }

    
    void Start () {
        rb = ball.GetComponent<Rigidbody>();
        lb = ball.GetComponent<LauncherBall>();
	}
	
	
	void Update () {
       

        
        horizontal = Input.GetAxis("Horizontal"); //Variable horizontal el Input Horizontal creado previamente
        Vector3 movement = new Vector3(0, 0, horizontal); //Creamos el Vector
        movement = movement.normalized * speed * Time.deltaTime;//Le añadimos la velocidad
        transform.Translate(movement);//Aplica el movimiento con la velocidad
        transform.position += transform.forward * movement.z;//Movor hacia delante en el eje Z

        
    }
}
