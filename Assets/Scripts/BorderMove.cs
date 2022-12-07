using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderMove : MonoBehaviour
{
    public float speed = 5f;

    // Used to destroy the border after it left the scene
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x-20f;
    }

    private void Update()
    {
        transform.position += Vector3.left*speed*Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

}
