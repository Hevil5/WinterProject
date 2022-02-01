using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("LeftJoyX");
        forwardInput = Input.GetAxis("LeftJoyY");
        //move the  forward and right with speed per frame
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * 10);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * 10);
    }
}
