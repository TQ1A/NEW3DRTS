using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStructure : MonoBehaviour
{
    public GameObject _create;
    public Transform _parent;

    public void OnClick()
    {
        Instantiate(_create,_parent);
    }
}
