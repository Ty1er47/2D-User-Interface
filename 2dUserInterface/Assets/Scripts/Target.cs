using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int PointValue = 1;
    public float MinSpeed = 10;
     public float MaxSpeed = 20;
     public float MaxTorque = 10;
     private Rigidbody2D _targerRb;
    // Start is called before the first frame update
    void Start()
    {
        _targerRb = GetComponent<Rigidbody2D>();

        _targerRb.AddForce(Vector2.up * MinSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
