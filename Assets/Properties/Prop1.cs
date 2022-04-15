using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop1 : MonoBehaviour
{
    private float speed =5;
   public float Speed
    {
        get
        {


            return speed;
        }
    }
    public string name1 { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        print(Speed);
        print(name1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
