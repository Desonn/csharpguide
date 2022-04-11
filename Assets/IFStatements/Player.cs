using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Renderer rend;
    [SerializeField]
    float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)&&speed >0)
        {
            speed -= 10;
        }
      if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 10;
        }
         Speed();
    }

    void Speed()
    {
        if (speed > 20)
            print("slow down");

        if (speed <= 0)
            print("speed up");
    }

}