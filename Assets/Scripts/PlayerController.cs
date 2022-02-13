using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float TurnSpeed = 45.0f;
    private float speed = 20.0f;
    private float horizontallnput;
    private float forwardinput;
    
    // Update is called once per frame
    void Update()
    {
        
        horizontallnput = Input.GetAxis("Horizontal");
        
        forwardinput = Input.GetAxis("Vertical");
        
        
        
        transform.Translate( Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Rotate(Vector3.up, TurnSpeed * horizontallnput * Time.deltaTime);
        
    
    }
}
