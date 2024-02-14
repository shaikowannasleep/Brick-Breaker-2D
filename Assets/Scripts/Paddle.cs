using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
filename: Paddle.cs
@author: shaikowannasleep
createdAt: 2024-02-13 22:03
 */
//The RequireComponent attribute automatically adds required components as dependencies.
[RequireComponent(typeof(Rigidbody2D))] 
public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 30f;

    public new Rigidbody2D rb ;
    public Vector2 direction ;


    private void Awake()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }


    private void Start()
    {
        ResetPaddle();
    }

    public void ResetPaddle()
    {
        rb.velocity = Vector2.zero;
        transform.position = new Vector2(0f, transform.position.y);
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector2.right;
        }
        else
        {
            this.direction = Vector2.zero;
        }
    }


    private void FixedUpdate()
    {
        if (direction != Vector2.zero) {
             rb.AddForce(direction *speed);
              }
    }


}
