using UnityEngine;
using System;

public class CameraZoom : MonoBehaviour
{
    public Camera _myCamera;
    private Rigidbody _rb;
    private float _modify;
    private float _zoom;
    [SerializeField] public float _zoomSpeed;
    [SerializeField] public float _minHigh;
    [SerializeField] public float _maxHigh;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Zoom();
    }

    void Zoom()
    {
        _modify = Mathf.Sqrt(Math.Abs(_rb.position.y)) * 2f;
        if(_rb.position.y < _minHigh)
        {
            _modify = 0;
        }
        _zoom = Input.mouseScrollDelta.y;
        Vector3 dir = _myCamera.ScreenPointToRay(Input.mousePosition).direction * _modify;
        float vec = _zoom * _zoomSpeed * _modify;

        if (_rb.position.y < _minHigh)
        {
            _rb.transform.position = Vector3.Lerp(_rb.position, new Vector3(_rb.position.x, _minHigh, _rb.position.z), 10 * Time.deltaTime);
        }

        if (_zoom < 0 && _rb.position.y <= _maxHigh)
        {
            _rb.AddForce(new Vector3(0, dir.y * vec, vec));
        }
        else if (_zoom > 0 && _rb.position.y >= _minHigh)
        {
            _rb.AddForce(dir * vec);
        }
    }
}
