using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{

    float donmeHizi;
    void Start()
    {
        Debug.Log("Sphere Controller has been started.");

        donmeHizi = 50f;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, donmeHizi * Time.deltaTime);
        
        
    }
}
