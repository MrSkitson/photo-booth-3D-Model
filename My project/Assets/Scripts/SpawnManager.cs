using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SpawnManager : MonoBehaviour
{
    public Button BackButton;
    public Button PhotoButton;
    public Button NextButton;

    private float ModelSpawnX = -1;
    private float ModelSpawnY = 2;
    private float ModelSpawnZ = 2;
   
    public GameObject[] Models ;

    private Rigidbody objectRb;

    public int currentIndex = 0;
  
     public int CurrentIndex
     {
      
             get
             {
                 return currentIndex;
             }
             set
             {
             if (Models[currentIndex] != null)
                 {
                     //set the current active object to inactive, before replacing it
                 GameObject aktivesObj = Models[currentIndex];
                 aktivesObj.SetActive(true);
                 }
  
                 if (value < 0)
                 currentIndex = Models.Length - 1;
             else if (value > Models.Length - 1)
                     currentIndex = 0;
                 else
                     currentIndex = value;
             if (Models[currentIndex] != null)
                 {
                 GameObject aktivesObj = Models[currentIndex];
                     aktivesObj.SetActive(true);
                 }
             }
      }

    // Start is called before the first frame update
    void Start()
    {
    BackButton.gameObject.SetActive(true);
    PhotoButton.gameObject.SetActive(true);
    NextButton.gameObject.SetActive(true);
    
    CubeSpown(CurrentIndex);
        
    }

   public void CubeSpown(int CurrentIndex)
    {
             Vector3 spawnPos = new Vector3(ModelSpawnX, ModelSpawnY, ModelSpawnZ);
        Instantiate(Models[CurrentIndex], spawnPos, Quaternion.identity);
        objectRb = GetComponent<Rigidbody>();

    }

    public void CapsuleSpown(int CurrentIndex)
    {
       
        Vector3 spawnPos = new Vector3(ModelSpawnX, ModelSpawnY, ModelSpawnZ);
        Instantiate(Models[CurrentIndex], spawnPos, Quaternion.identity);
        objectRb = GetComponent<Rigidbody>(); 
       
    }
     
    

    void LateUpdate()
    {      
   NextButton.onClick.AddListener(() => OnClickNext(CurrentIndex)); 
   BackButton.onClick.AddListener(() => OnClickBack(CurrentIndex));
    }

    public void OnClickNext(int _index)
    {
   if(_index == 0)
   {
       CurrentIndex++;
       CapsuleSpown(CurrentIndex);
      
    //    Models = GameObject.FindGameObjectsWithTag("Model1");
    //    gameObject.SetActive(false);
    }
    
    }

    public void OnClickBack(int _index)
    {
       SceneManager.LoadScene(0);
    }


}


//     public void DestroyGO()
// {
//     Destroy(Models[currentIndex]);
// 