using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Rigidbody2D _rb;
    public float _moveSpeed= 500;
    private Vector2 _moveDir;
    private void Awake()
    {

    }
    void Start()
    {
        this.transform.position = new Vector2(0, 0);
        _rb.velocity = new Vector2(0, 0);
        _moveDir = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)).normalized;

        _rb.velocity = _moveDir * _moveSpeed * Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void restart()
    {
        this.Start();
    }
}
