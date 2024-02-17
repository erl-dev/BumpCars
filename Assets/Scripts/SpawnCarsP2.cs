using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DentedPixel;

public class SpawnCarsP2 : MonoBehaviour
{
    public List<CarsInfo> cars ;
    public float spawnCooldown = 2.0f; // Cooldown duration in seconds
    private float lastSpawnTime;
    public GameObject bar;
    

    Rigidbody rb;
    float forwardForce;

    

    GameObject car;
    public GameObject player2Button1SpawnLoc;
    public GameObject player2Button2SpawnLoc;
    public GameObject player2Button3SpawnLoc;
    public GameObject player2Button4SpawnLoc;
    public GameObject player2Button5SpawnLoc;
    public GameObject player2Button6SpawnLoc;

    

    public int index;
    public int index1;
    public int index2;

    public Image carSpawn1;
    public Image carSpawn2;
    public Image carSpawn3;

    

    public static bool isButtonPressed;    



    void Start()
    {
        
        RandomCarsPlayer2();
        ShowImage1();

    }

    
    void Update()
    {
        

    }

    public void ShowImage1()
    {
        carSpawn1.sprite = cars[index].carImage;
        carSpawn2.sprite = cars[index1].carImage;
        carSpawn3.sprite = cars[index2].carImage;

    }

   

    public void RandomCarsPlayer2()
    {
        index = Random.Range(0, cars.Count);   
        index1 = Random.Range(0, cars.Count);
        index2 = Random.Range(0, cars.Count);
    }

  

    public void SpawnGameObjectButton1()
    {
        if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button1SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
        }

      
    }

    public void SpawnGameObjectButton2()
    {
       if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button2SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
       }
        

    }

    public void SpawnGameObjectButton3()
    {
       if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button3SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
        }

    }

    public void SpawnGameObjectButton4()
    {
       if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button4SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
       }
       

    }

    public void SpawnGameObjectButton5()
    {
        if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button5SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
        }
       

    }

    public void SpawnGameObjectButton6()
    {
       if (Time.time - lastSpawnTime >= spawnCooldown){
            car = Instantiate(cars[index].cars, player2Button6SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            lastSpawnTime = Time.time; // Update last spawn time
            SpawnManager();
       }
     

    }

    


    public void SpawnManager()
    {
        if(isButtonPressed == true)
        {
           

            index = index1;
            index1 = index2;
            index2 = Random.Range(0, cars.Count);
            ResetBarAnimation(); // Reset the bar animation
            AnimateBar();
            ShowImage1();

        }
       
    }

     public void ResetBarAnimation()
    {
        LeanTween.cancel(bar); // Cancel any ongoing animation on the bar GameObject
        bar.transform.localScale = new Vector3(0f, 1f, 1f); // Reset the scale of the bar to its initial state
    }

    public void AnimateBar(){
        LeanTween.scaleX(bar, 1, 2);
    }
}
