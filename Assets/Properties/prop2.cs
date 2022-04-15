using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prop2 : MonoBehaviour
{
    Prop1 prop1;
    // Start is called before the first frame update
    void Start()
    {
        prop1 = GameObject.Find("Prop").GetComponent<Prop1>();

        print(prop1.Speed);
        prop1.name1 = "bob";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
