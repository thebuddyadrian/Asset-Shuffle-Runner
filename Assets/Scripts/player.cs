using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            body.velocity = Vector3.up * 12;
        }
    }
}
