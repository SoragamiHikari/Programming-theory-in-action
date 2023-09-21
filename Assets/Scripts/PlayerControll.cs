using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerControll : MonoBehaviour
{
    private Rigidbody rb;

    private int bullet = 10;
    private float verticalInput;
    private float horizontalInput;

    // ENCAPSULATION
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;

    public GameObject firePoint;
    public GameObject gun;
    public GameObject bulletPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        GameManager.Instance.ammo = bullet;
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION
        InputPlayerControl();
        InputFire();
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
    }

    void InputFire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bullet >= 0)
            {
                Instantiate(bulletPrefabs, firePoint.transform.position, gun.transform.rotation);
            }
            bullet--;
            GameManager.Instance.ammo = bullet;
            GameManager.Instance.AmmoToText();
        }
    }

    void PlayerMove()
    {
        rb.velocity = transform.forward * moveSpeed * verticalInput;
        transform.Rotate(Vector3.up, horizontalInput * rotateSpeed);
    }
}
