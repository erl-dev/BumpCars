using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScore : MonoBehaviour
{
    public GameObject carOrig;

        void OnTriggerEnter(Collider other)
        {
           
            if (other.gameObject.tag == "Destroy")
            {
                GameObject carClone = Instantiate(carOrig);
                Destroy(carClone);
  
                Debug.Log("Collided");
                
               
            }
        }
    

 

}
