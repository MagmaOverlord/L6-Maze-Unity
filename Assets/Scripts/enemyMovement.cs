using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
        if ((transform.position - target.position).magnitude > 0.1f) {
            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            transform.position = new Vector3(26, 1, -32);
        }
    }
}
