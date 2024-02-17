using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerScoreP2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.tag == "Bus"){
                ScoreScriptP2.instance.AddPointCar5();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Truck"){ 
                ScoreScriptP2.instance.AddPointCar4();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Car"){ 
                ScoreScriptP2.instance.AddPointCar23();
                Destroy(other.gameObject);
            }
            else if (other.gameObject.tag == "Tuktuk"){ 
                ScoreScriptP2.instance.AddPointCar1();
                Destroy(other.gameObject);
            }
        }
    
}
