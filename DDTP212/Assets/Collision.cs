using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);


    [SerializeField] float destroydelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    


    
    
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
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroydelay);
        }
        if (other.tag == "Customer" && hasPackage);

        {
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package Delivered!");
        }

    }
}
