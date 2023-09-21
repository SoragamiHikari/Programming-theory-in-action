using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerControll : MonoBehaviour
{
    private Rigidbody rb;

    private float verticalInput;
    private float horizontalInput;

    public float moveSpeed;
    public float rotateSpeed;
    public GameObject firePoint;
    public GameObject gun;
    public GameObject bulletPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION
        InputPlayerControl();
    }

    private void FixedUpdate()
    {
        // ABSTRACTION
        PlayerMove();
    }

    void InputPlayerControl()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefabs, firePoint.transform.position, gun.transform.rotation);
        }
    }

    void PlayerMove()
    {
        rb.velocity = transform.forward * moveSpeed * verticalInput;
        transform.Rotate(Vector3.up, horizontalInput * rotateSpeed);
    }
}
