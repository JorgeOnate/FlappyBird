using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    [SerializeField] public float speed = 6.0f;

    
    // Simple movement of ship
    void Start()
    {
        
        
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("clear");
    //    }
    //}
}
