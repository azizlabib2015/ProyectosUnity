using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour
{
    public float ylimit = -5;
    private Vector3 originalPosition;
    Rigidbody myRigibody;
    public bool resetVelocity;

    // Use this for initialization
    void Start()
    {
        myRigibody = GetComponent<Rigidbody>();
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<=ylimit)
        {
            transform.position = originalPosition;
            if (resetVelocity)
            {
                myRigibody.velocity = Vector3.zero;
                myRigibody.angularVelocity = Vector3.zero; 
            }
        }
    }
}
