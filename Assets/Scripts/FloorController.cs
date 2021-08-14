using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private GameObject floorPrefab;

    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        CreateFloor();
    }

    private void CreateFloor() {
        for(int i = -13; i != 26; i++) {
            Instantiate(floorPrefab, new Vector3(i, -5.501f, 0), Quaternion.identity);
        }
    }
}
