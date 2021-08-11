using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] protected int speed = 5;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void MoveByHalfCircle() {
        Vector3 vector = transform.right;
        var min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        var max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        transform.position = Vector3.MoveTowards(transform.position, transform.position + vector, speed * Time.deltaTime);
        /*
        transform.up = Vector3.MoveTowards(transform.position, transform.position + vector, speed * Time.deltaTime);// ÏÐÅÄÏÎËÀÃÀÅÌÎÅ ÄÂÈÆÅÍÈÅ ÏÎ ÎÑÈ Ó

        if (transform.position.x > max.x - 1 || transform.position.x < min.x + 2.7f) {
            speed = -speed;
        }
        */
    }

    private void Update() {
        MoveByHalfCircle();
    }
}
