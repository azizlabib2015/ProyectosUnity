using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public string axis;
    public float angle=20;
    public bool reversed;
    public HingeJoint hinge;
    JointSpring spring;
    void Start()
    {
        spring = hinge.spring;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxis(axis) != 0)
        {
            spring.targetPosition = -angle;
            hinge.spring = spring;
        }
        else
        {
            spring.targetPosition = angle;
            hinge.spring = spring;
        }

    }
}
