using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOne : MonoBehaviour
{
    [SerializeField] int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            points = 50;
        else if (Input.GetKeyDown(KeyCode.W))
            points = 100;
      else  if (Input.GetKeyDown(KeyCode.E))
            points = 0;
        Points();
    }

    void Points()
    {
        switch (points)
        {
            case 50:
                print("50!");
                break;
            case 100:
                print("100!");
                break;

            default:
                print("you need 50 or 100 points");
                break;
        }

    }
}
