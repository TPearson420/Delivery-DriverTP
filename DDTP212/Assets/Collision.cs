using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] float destroydelay = 0.5f;
    bool hasPackage;
    private void Start()
    {
        Debug.Log(hasPackage);
            
    }
    void  CollisionEnter2D(Collision2D other)              {
        Debug.Log("Ouch!");
   
    
    
    
    
    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destroydelay);
        }
        if (other.tag == "Customer" && hasPackage) ;
        {
            Debug.Log("Package Delivered!");
        }

    }
}
