using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherBall : MonoBehaviour
{

    public Rigidbody BallRigibody;
    public float pushForce = 10;
    private Vector3 direccion;
    private bool fired;
    // Use this for initialization
    void Start()
    {
        fired = false;//poner el estado de disparo a falso
        //poner la direccion de la bola que se desplaze para delante en mi caso delante es (transform.left)
        direccion = transform.TransformDirection(-1,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        //comprobar si ha pulsado la tecla espacio Y el estado de  disparo es verdadero
        if (!fired && Input.GetKeyDown(KeyCode.Space))
        {
            //Si es verdadero la condicion

            //1--Crear la fuerza de tipo Vector3 ,se obtiene por fuerza=direccion*fuerzaEmpuje
            Vector3 Force = direccion * pushForce;

            //2--el rigibody de la bola le aplico esa fuerza
            BallRigibody.AddForce(Force, ForceMode.VelocityChange);

            //3--cambiar el estado de diparo a falso
            fired = true;
        }
    }
}
