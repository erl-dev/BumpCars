using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCars : MonoBehaviour
{
    public List<CarsInfo> cars ;

    Rigidbody rb;
    float forwardForce;

    GameObject car;
    public GameObject player1Button1SpawnLoc;
    public GameObject player1Button2SpawnLoc;
    public GameObject player1Button3SpawnLoc;
    public GameObject player1Button4SpawnLoc;
    public GameObject player1Button5SpawnLoc;
    public GameObject player1Button6SpawnLoc;

    

    public int index;
    public int index1;
    public int index2;

    public Image carSpawn1;
    public Image carSpawn2;
    public Image carSpawn3;

    

    public bool isButtonPressed;



    void Start()
    {
        RandomCarsPlayer1();
        ShowImage1();
    }

    
    void FixedUpdate()
    {
        Movement();
    }

    public void ShowImage1()
    {
        carSpawn1.sprite = cars[index].carImage;
        carSpawn2.sprite = cars[index1].carImage;
        carSpawn3.sprite = cars[index2].carImage;

    }

   

    public void RandomCarsPlayer1()
    {
        index = Random.Range(0, cars.Count);   
        index1 = Random.Range(0, cars.Count);
        index2 = Random.Range(0, cars.Count);
    }

  

    public void SpawnGameObjectButton1()
    {
      
            car = Instantiate(cars[index].cars, player1Button1SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();


       
        
      
    }

    public void SpawnGameObjectButton2()
    {
       
            car = Instantiate(cars[index].cars, player1Button2SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();
        

    }

    public void SpawnGameObjectButton3()
    {
        if (car != null)
        {
            car = Instantiate(cars[index].cars, player1Button3SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();
        }

    }

    public void SpawnGameObjectButton4()
    {
       
            car = Instantiate(cars[index].cars, player1Button4SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();
       

    }

    public void SpawnGameObjectButton5()
    {
        
            car = Instantiate(cars[index].cars, player1Button5SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();
       

    }

    public void SpawnGameObjectButton6()
    {
       
            car = Instantiate(cars[index].cars, player1Button6SpawnLoc.transform);
            forwardForce = cars[index].force;
            isButtonPressed = true;
            SpawnManager();
     

    }

    


    public void SpawnManager()
    {
        if(isButtonPressed == true)
        {
           

            index = index1;
            index1 = index2;
            index2 = Random.Range(0, cars.Count);

            ShowImage1();
            

        }
    }

    public void Movement()
    {
        if (isButtonPressed == true)
        {

            rb = this.car.GetComponent<Rigidbody>();
            rb.velocity = transform.TransformDirection(Vector3.right * forwardForce);
           
            
        }
    }







}
