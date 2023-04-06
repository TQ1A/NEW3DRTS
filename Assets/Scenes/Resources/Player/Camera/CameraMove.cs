using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 _position;
    private Rigidbody _rb;
    private float _modify;
    [SerializeField] public float _speed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _modify = Mathf.Sqrt(_rb.position.y) * 2.5f;

        _position = Input.mousePosition;

        if (_position.x >= Screen.width - 5.3f)
            _rb.AddForce(Vector3.right * _speed * _modify);

        if (_position.x <= 0.1f)
            _rb.AddForce(Vector3.left * _speed *_modify);

        if (_position.y >= Screen.height - 2.3f)
            _rb.AddForce(Vector3.forward * _speed * _modify);

        if (_position.y <= 0.1f)
            _rb.AddForce(Vector3.back * _speed * _modify);
    }
}
