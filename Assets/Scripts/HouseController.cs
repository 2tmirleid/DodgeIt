using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour {
    [SerializeField] private float speed = 5f;
    [SerializeField] public static Rigidbody2D rb2d;
    public static bool isGrounded = false;

    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        MoveByHalfCircle();
        
    }

    private void MoveByHalfCircle() {
        if(!isGrounded) {
            rb2d.gravityScale = 0;
        } else {
            rb2d.gravityScale = 4;
        }
        Vector3 vector = transform.right;
        var min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        var max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        transform.position = Vector3.MoveTowards(transform.position, transform.position + vector, speed * Time.deltaTime);

        if(transform.position.x > max.x - 2 || transform.position.x < min.x + 2) {
            speed = -speed;
        }
    }

    
}
    
