using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_lock : MonoBehaviour
{
    public Transform _target;

    private void Update()
    {
        Lock();
        transform.LookAt(_target);
    }

    void Lock()
    {
        _target.transform.position = new Vector3(transform.position.x, 0, transform.position.z+5f);
    }
}
