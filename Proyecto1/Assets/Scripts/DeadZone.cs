using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public Transform spawBallPosition;
    public LauncherDoor launcherDoor;
    private void OnTriggerEnter(Collider other)
    {
        launcherDoor.setState(true);
        GameObject ball = other.gameObject;
        //mover al bola al punto de spaw
        ball.transform.position = spawBallPosition.position;
        ball.transform.rotation = spawBallPosition.rotation;

        //poner a cero las velocidades del rigibody
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        //Acceder al componente Bal Launcher del bola y la varieable fired ponerla a false
        BallLauncher launcher = ball.GetComponent<BallLauncher>();
        launcher.fired = false;
        GameObject.FindObjectOfType<ScoreManager>().ResetScore();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
