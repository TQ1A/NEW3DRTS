using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public static float _fps;

    void OnGUI()
    {
        _fps = 1.0f / Time.deltaTime;
        GUILayout.Label(@$"FPS: {(int)_fps}");
    }
}