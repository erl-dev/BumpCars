using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScriptYellowCar : MonoBehaviour
{
   Rigidbody rb;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public GameObject smokeEffect;
    int smokeCount = 0;

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
                if(smokeCount == 0){
                    FindObjectOfType<AudioManagerScript>().Play("SpeedingSound");
                    GameObject effect = Instantiate(smokeEffect, transform.position, transform.rotation);
                    smokeCount = 1;
                    Destroy(effect, 2f);
                }
            }    
    } 
}
