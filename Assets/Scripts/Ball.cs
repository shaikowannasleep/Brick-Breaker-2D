using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
filename: Ball.cs
@author: shaikowannasleep
createdAt: 2024-02-14 09:33
 */

//The RequireComponent attribute automatically adds required components as dependencies.
[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    private new Rigidbody2D rb;
    public float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Vector2 force = Vector2.zero; force.x = Random.Range(-1f, 1f); force.y = -1f;
        //! ForceMode2D.Impulse
        //! Apply the impulse force instantly. This mode depends on the mass of rigidbody
        //! so more force must be applied to move higher-mass objects the same amount as lower-mass objects.
        rb.AddForce(force.normalized * speed, ForceMode2D.Impulse);
        //? một vector có độ dài (magnitude) bằng 1 nhưng hướng giữ nguyên;
    }

    private void FixedUpdate()
    {
        //? điều chỉnh tốc độ của đối tượng mà không thay đổi hướng di chuyển của nó.
        rb.velocity = rb.velocity.normalized * speed;
    }



}