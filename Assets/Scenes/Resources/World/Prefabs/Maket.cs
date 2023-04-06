using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maket : MonoBehaviour
{
    public GameObject _obj;

    private void Update()
    {
        Move();
        Rotate();
        LeftClick();
    }

    void Move()
    {
        RaycastHit[] hits;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hits = Physics.RaycastAll(ray);
        for (int i = 0;i < hits.Length;i++)
        {
            if (hits[i].collider.tag == "Ground")
            {
                gameObject.transform.position = hits[i].point + hits[i].normal * 0.5f;
            }
        }
    }

    void LeftClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_obj, gameObject.transform.position, gameObject.transform.rotation, GameObject.Find("Buildings").transform);
            Destroy(gameObject);
        }
    }
    void Rotate()
    {
        if (Input.GetKey(KeyCode.X))
        {
            gameObject.transform.Rotate(0,0.5f,0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.Rotate(0,-0.5f,0);
        }
    }
}