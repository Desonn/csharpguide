using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventMain.MoveCube += CubeMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    public void CubeMove()
    {
        transform.position = new Vector3(2, 5, 0);
    }
}
