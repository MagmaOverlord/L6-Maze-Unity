using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.Random r = new System.Random();
        int num = r.Next(0, 90);
        print(num);
        transform.Rotate(new Vector3(num, num, num) * Time.deltaTime);
    }
}
