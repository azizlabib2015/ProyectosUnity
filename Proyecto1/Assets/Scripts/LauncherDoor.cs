using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherDoor : MonoBehaviour
{
    BoxCollider collider;
    MeshRenderer renderer;

    // Use this for initialization
    void Start()
    {
        collider = gameObject.GetComponent<BoxCollider>();
        renderer = gameObject.GetComponent<MeshRenderer>();
        setState(true);
    }
    private void OnTriggerExit(Collider other)
    {
        setState(false);
    }
    public void setState(bool open)
    {
        collider.isTrigger = open;
        renderer.enabled = !open;
    }
}
