using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour
{
    public int hP = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Destroyed();
        }
    }

    public virtual void Destroyed()
    {
        hP--;
        if (hP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
