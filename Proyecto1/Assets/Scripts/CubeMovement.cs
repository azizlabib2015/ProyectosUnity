using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeMovement : MonoBehaviour
{
    //public bool forward;
    //public bool back;
    //public bool right;
    //public bool left;
    public float depth;
    public float horizontal;
    public float speed = 20;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        //forward = Input.GetKey(KeyCode.W);
        //back = Input.GetKey(KeyCode.S);
        //right = Input.GetKey(KeyCode.D);
        //left = Input.GetKey(KeyCode.A);

        depth = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal, 0, depth);
        movement = movement.normalized * speed * Time.deltaTime;

        transform.Translate(movement);
        ////eje z
        //if (forward)
        //{
        //    transform.position += transform.forward * speed * Time.deltaTime;
        //}
        //else if (back)
        //{
        //    transform.position += -transform.forward * speed * Time.deltaTime;
        //}


        ////eje x
        //if (right)
        //{
        //    transform.position += transform.right * speed * Time.deltaTime;
        //}
        //else if (left)
        //{
        //    transform.position += -transform.right * speed * Time.deltaTime;
        //}
    }
}
