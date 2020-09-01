using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMecanism : MonoBehaviour
{
    //This Script simply controls the movement of the bird
    //in which case it only jumps
    // Start is called before the first frame update
   
    [Header("Velocity of flight:")]
    [SerializeField] public float velocity = 1;
    
    //[Header("Jump Control:")]
    //[SerializeField] private KeyCode MouseL;
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //jump
            _rigidbody2D.velocity = Vector2.up * velocity;
        }
    }
}
