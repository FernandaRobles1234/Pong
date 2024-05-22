using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class PlayerController : MonoBehaviour
{
    public string _axisName;

    public Rigidbody2D _rb;
    public float _moveSpeed = 500;
    public Vector2 _moveDir;
    void Start()
    {
        
    }

    void FixedUpdate()
    {

        Vector2 moveDir = new Vector2(0.0f, Input.GetAxis(_axisName));
        _moveDir = moveDir.normalized;

        _rb.velocity= _moveDir * _moveSpeed * Time.fixedDeltaTime;
    }
}
