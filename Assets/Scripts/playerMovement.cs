using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public float velocity = 10f;

    public Rigidbody rb;

    public int score;

    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        setScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH, 0.0f, moveV);
        rb.AddForce(movement * velocity);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("pickUp")) {
            other.gameObject.SetActive(false);
            score += 1;
            print(score);
            setScoreText();
        }
    }

    void setScoreText() {
        scoreText.text = "Score: " + score.ToString();
    }

}
