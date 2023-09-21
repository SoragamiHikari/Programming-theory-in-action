using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBe : MonoBehaviour
{
    private Rigidbody rb;

    public float bulletSpeed;
    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        gun = GameObject.Find("Gun");

        rb.AddForce(gun.transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
