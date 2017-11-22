using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour {

    public string frase = "Eyyyyyyyy";
    public int num = 5;
    public float decimales = 2.4f;
    public bool booleano=true;
    public PlayMode pmode;
    public Color color ;

     void Awake()
    {
        Debug.Log("Awake");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Use this for initialization
    void Start () {
        Debug.Log("este es un mensaje informativo");
        Debug.LogWarning("este es un mensaje warning");
        Debug.LogError("este es un mensaje Error");
    }
    void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    void OnDestroy()
    {
        Debug.Log("OnDistroy");
    }
    //// Update is called once per frame
    //void Update () {
    //    Debug.Log("updata cada frame");
    //}
	 
    
}
