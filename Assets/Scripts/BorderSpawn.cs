using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderSpawn : MonoBehaviour
{
    public GameObject GO;
    public float repeat;


    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),3, repeat);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject borders = Instantiate(GO, transform.position, Quaternion.identity);
    }
}
