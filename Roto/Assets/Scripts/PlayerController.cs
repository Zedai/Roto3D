using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float spinSpeed;
    public bool clockwise;
    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        transform.position = transform.position + (movement * speed * Time.deltaTime);
        transform.Rotate (new Vector3 (0, -1 + 2 * System.Convert.ToInt32(clockwise), 0) * spinSpeed *Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Wall"))
        {
            
        }
    }

 }
