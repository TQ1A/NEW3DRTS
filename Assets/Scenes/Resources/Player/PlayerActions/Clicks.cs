using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicks : MonoBehaviour
{
    public GameObject _e;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            EKey();
    }

    void EKey()
    {
        _e.SetActive(!_e.activeSelf);
    }
}
