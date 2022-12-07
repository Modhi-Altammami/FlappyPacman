using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenParallel : MonoBehaviour
{

    private MeshRenderer mr;
    public float animationSpeed = 1f;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        mr.material.mainTextureOffset += new Vector2 (animationSpeed * Time.deltaTime , 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
