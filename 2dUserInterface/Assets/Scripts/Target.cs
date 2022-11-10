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
     private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _targerRb = GetComponent<Rigidbody2D>();
        _gameManager = gameObject.Find("Game Manager").GetComponent<GameManager>();

        _targerRb.AddForce(Vector2.up * RandomizeForce(), ForceMode2D.Impulse);
         _targerRb.AddTorque(RandomizeTorque());
    }

    private float RandomizeTorque()
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 private float RandomizeForce()
 {
     return Random.Range(MinSpeed, MaxSpeed);
 }

private void OnTriggerEnter2D(Collider2D other)
 {
     Destroy(this.gameObject);
     if(!other.gameObject.CompareTag("Bad"))
     {
         //Debug.Log("GameOver");
         _gameManager.IsGameActive = false;
     }
 }
 }
