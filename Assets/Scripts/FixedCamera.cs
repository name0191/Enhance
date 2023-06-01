using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }

    void SetResolution()
    {
        int width = 1920;
        int height = 1080;

        Screen.SetResolution(width, height, true);
    }
}
