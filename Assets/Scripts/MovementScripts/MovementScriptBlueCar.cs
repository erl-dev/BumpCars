using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptBlueCar : MonoBehaviour
{
     Rigidbody rb;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            rb = this.GetComponent<Rigidbody>();
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            if(isGrounded){

                rb.velocity = transform.TransformDirection(Vector3.forward * -10);
                

            }
            
             
         
    }    
}
