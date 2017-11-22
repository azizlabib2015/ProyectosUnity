using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectInfo : MonoBehaviour {

    public int duracion = 5;
	// Use this for initialization
	void Start () {
        string goName=gameObject.name;
        Debug.Log("EL GameObject "+goName+" se destruye en 5 segundos.");
        Destroy(gameObject,duracion);
        

    }
    private void OnDestroy()
    {
        Debug.Log("EL GameObject Destruido.");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
