using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List1 : MonoBehaviour
{
    public List<string> names = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i < names.Count; i++)
        {
            print(names[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            names.Remove(names[Random.Range(0, names.Count)]);
            for(int i =0; i < names.Count; i++)
            {
                print(names[i]);
            }
        }
    }
}
