using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forge : MonoBehaviour
{
    public GameObject _objToSpawn;
    public GameObject _parent;

    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_objToSpawn, _parent.transform);
        }
    }
}
