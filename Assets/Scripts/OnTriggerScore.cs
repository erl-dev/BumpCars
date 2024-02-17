using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScore : MonoBehaviour
{


        void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Bus"){
                ScoreScriptP1.instance.AddPointCar5();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Truck"){ 
                ScoreScriptP1.instance.AddPointCar4();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Car"){ 
                ScoreScriptP1.instance.AddPointCar23();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Tuktuk"){ 
                ScoreScriptP1.instance.AddPointCar1();
                Destroy(other.gameObject);
            }
        }
    

 

}
