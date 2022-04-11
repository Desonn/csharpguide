using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTwo : MonoBehaviour
{
    Renderer rend;
    int colorCode;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            colorCode = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            colorCode = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            colorCode = 3;
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            colorCode = 4;

        ChangeColor();
    }

    void ChangeColor()
    {
        switch (colorCode)
        {
            case 1: rend.material.color = Color.blue;
                break;
            case 2: rend.material.color = Color.red;
                break;
            case 3: rend.material.color = Color.green;
                break;
            case 4: rend.material.color = Color.black;
                break;
        }
    }
}
