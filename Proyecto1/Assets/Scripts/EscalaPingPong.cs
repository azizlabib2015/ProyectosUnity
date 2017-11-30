using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalaPingPong : MonoBehaviour {
    public Vector3 maxEscala;
    public Vector3 minEscala;
    public float speed=1f;
    bool up;
    float i = 0;



    // Use this for initialization
    void Start () {
        up = true;
        transform.localScale = minEscala;
	}
	
	// Update is called once per frame
	void Update () {
        //modifcar la escala
        if (up)
        {
            transform.localScale = Vector3.Lerp(minEscala, maxEscala, i);
        }
        else
        {
            transform.localScale = Vector3.Lerp(maxEscala, minEscala, i);
        }

        i += Time.deltaTime * speed;
        if (i>=1)
        {
            i = 0;
            up = !up;
        }
    }

    private void FixedUpdate()
    {
        Debug.Log("El tiempo es " + Time.deltaTime);
    }
}
