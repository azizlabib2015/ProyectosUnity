using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoverPingPong : MonoBehaviour
{
    public Vector3 a;
    public Vector3 b;
    public float speed = 2;
    public float progress = 0;
    // Use this for initialization
   

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(a, b, progress);
        progress += speed * Time.deltaTime;

        if (progress <= 0 || progress >= 1)
        {
            speed = -speed;
        }
    }
}
