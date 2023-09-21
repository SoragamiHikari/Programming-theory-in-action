using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE

public class Box : Thing
{
    public GameObject bananaPrefabs;

    // POLYMORPHISM

    public override void Destroyed()
    {
        hP--;
        if (hP <= 0)
        {
            Instantiate(bananaPrefabs, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
