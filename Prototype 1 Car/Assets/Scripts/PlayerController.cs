using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private float speed = 20.0f;
    private float turnSpeed = 120.0f;
    private  float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame updateg
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves car based on Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //Rotates car based on Horizontal Input 1
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
       
       
    }
}
