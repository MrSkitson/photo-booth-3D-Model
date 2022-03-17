using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Capsule;
    public GameObject Sphere;
    //private float startDelay = 2;
   // private float modelSpawnTime = 0;
    private float ModelSpawnX = 1;
    private float ModelSpawnY = 2;
    private float ModelSpawnZ = 2;

    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
         
        //InvokeRepeating("CubeSpown", startDelay, modelSpawnTime);
        CubeSpown();
    }

   public void CubeSpown()
    {
        Vector3 spawnPos = new Vector3(ModelSpawnX, ModelSpawnY, ModelSpawnZ);
        Instantiate(Cube, spawnPos, Quaternion.identity);
        objectRb = GetComponent<Rigidbody>(); 
    }

    public void CapsuleSpown()
    {
        Vector3 spawnPos = new Vector3(ModelSpawnX, ModelSpawnY, ModelSpawnZ);
        Instantiate(Capsule, spawnPos, Capsule.gameObject.transform.rotation);
        objectRb = GetComponent<Rigidbody>(); 
    }

   public void SphereSpown()
   {
        Vector3 spawnPos = new Vector3(ModelSpawnX, ModelSpawnY, ModelSpawnZ);
        Instantiate(Sphere, spawnPos, Sphere.gameObject.transform.rotation);
        objectRb = GetComponent<Rigidbody>(); 
    }

void LateUpdate()
{
    // if (click next)
    // {
    //     Destroy(this.gameObject);
        
    //     CapsuleSpown(); 
    // }
}



}
