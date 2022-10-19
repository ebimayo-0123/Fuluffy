using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if(transform.position.x>0)
        {
            rb2d.velocity=Vector3.left*speed;
        }
        else
        {
            rb2d.velocity=Vector3.right*speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
