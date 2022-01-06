using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // movement variables, public to adjust in Unity instead of script
    public float speed = 5f;        // movement speed
    public float turnSpeed = 10f;   // rotation speed

    // private movement variables, for script to control
    private float horizontalMove;   // left and right movmenet variables
    private float verticalMove;     // forward and backward movement variables

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal"); // left and right
        verticalMove = Input.GetAxis("Vertical");     // forward and backward

        // move forward or backward according to horizontal input
        transform.Translate(Vector3.forward *  speed * Time.deltaTime * verticalMove);
        // Rotate player based on vertical input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalMove);
    }
}
