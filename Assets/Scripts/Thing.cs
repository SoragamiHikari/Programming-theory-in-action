using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour
{
    public int hP = 3;

    public virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            hP--;
            if(hP <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
