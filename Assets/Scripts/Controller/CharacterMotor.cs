using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    public Rigidbody2D _rb;

    public float _moveSpeed= 500;

    public Vector2 _moveDir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.AddForce(_moveDir * _moveSpeed * Time.fixedDeltaTime);
    }
}
