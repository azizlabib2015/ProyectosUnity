using UnityEngine;
using System.Collections;

public class GiroRueda : MonoBehaviour
{
    public float speed = 10f;
    public float angulo;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        //angulo = GetComponentInParent<Transform>().eulerAngles.magnitude;
        //Vector3 axis =transform.localRotation;
        //gameObject.transform.Rotate(, angulo * Time.deltaTime);
        ////transform.Rotate(Vector3.up, rotattionAxis * speed * Time.deltaTime);

    }
}
