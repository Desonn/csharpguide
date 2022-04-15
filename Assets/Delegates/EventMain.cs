using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMain : MonoBehaviour
{
    public delegate void AssignPos();
    public static event AssignPos MoveCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(MoveCube != null)
            {
                MoveCube();
            }
        }
    }
}
