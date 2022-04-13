using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods1 : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor(cube, Color.red);
    }


    void ChangeColor(GameObject obj, Color color)
    {
       Renderer ren = obj.GetComponent<Renderer>();

        ren.material.color = color;
    }
}
