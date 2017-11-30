using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}
public class CubeRotation : MonoBehaviour
{

    // Use this for initialization
    //public bool up;
    //public bool down;
    public float speed = 10f;
    public float rotattionAxis;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        rotattionAxis = Input.GetAxis("Rotation");
        transform.Rotate(Vector3.up, rotattionAxis * speed * Time.deltaTime);


        //up = Input.GetKey(KeyCode.Q);
        //down = Input.GetKey(KeyCode.E);
        //if (up)
        //{
        //    transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        //}
        //else if (down)
        //{
        //    transform.Rotate(Vector3.down, speed * Time.deltaTime);
        //}

    }
}
