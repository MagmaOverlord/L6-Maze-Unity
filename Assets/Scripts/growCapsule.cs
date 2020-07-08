using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class growCapsule : Collectible
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Derived class");
    }

    // Update is called once per frame
    void Update()
    {
        this.moveRotate(); 
    }

    
}
