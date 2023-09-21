using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text ammoText;

    // ENCAPSULATION
    private int m_ammo = 0;
    public int ammo
    {
        get { return m_ammo; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("Ammo run out or negative");
            }
            else
            {
                m_ammo = value;
            }
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ammoText.text = "Ammo : " + ammo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AmmoToText()
    {
        ammoText.text = "Ammo : " + ammo;
    }
}
