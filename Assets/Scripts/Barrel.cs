using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE

public class Barrel : Thing
{
    public GameObject explotionFx;

    // POLYMORPHISM

    public override void Destroyed()
    {
        hP--;
        if (hP <= 0)
        {
            Instantiate(explotionFx, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
