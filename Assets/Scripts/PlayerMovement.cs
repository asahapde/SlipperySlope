using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontalInput;
    public int points = 0;
    public float forceStrength = 10f;

    public TextMeshProUGUI pointText;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.left * horizontalInput*forceStrength);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (other.tag == "Enemy")
        {
            points++;
            pointText.text = points.ToString();
        }
    }
}
