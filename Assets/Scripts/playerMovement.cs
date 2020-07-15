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
        if (other.gameObject.CompareTag("pickUp"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            setScoreText();
        }
        else if (other.gameObject.CompareTag("grow"))
        {
            other.gameObject.SetActive(false);
            rb.transform.localScale = new Vector3(5f, 5f, 5f);
        }
        else if (other.gameObject.CompareTag("losePoints"))
        {
            other.gameObject.SetActive(false);
            score -= 5;
            if (score < 0)
            {
                score = 0;
            }
            setScoreText();
        }
        else if (other.gameObject.CompareTag("enemy")) {
            velocity -= 1f;
            transform.position = new Vector3(0, 1, 0);
            if (velocity <= 0f) {
                velocity = 0f;
                scoreText.text = "Game Over!";
            }
        }
    }

    void setScoreText() {
        scoreText.text = "Score: " + score.ToString();
    }

}
