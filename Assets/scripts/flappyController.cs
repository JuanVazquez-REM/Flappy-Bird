using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flappyController : MonoBehaviour
{
    float velocity;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 7;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rigidbody2D.velocity = Vector2.up * velocity;
            
        }
    }

    OnTriggerEnter
}
