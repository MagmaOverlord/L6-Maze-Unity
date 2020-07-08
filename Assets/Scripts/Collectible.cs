using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.moveRotate();
    }
    public void moveRotate() {
        System.Random r = new System.Random();
        int num = r.Next(0, 90);
        print(num);
        transform.Rotate(new Vector3(num, num, num) * Time.deltaTime);
    }
}
