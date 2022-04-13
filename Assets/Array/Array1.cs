using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array1 : MonoBehaviour
{
    public string[] names;
    public int[] ages;
    public string[] cars;
    int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, names.Length);

       foreach(var name in names)
        {
            print(name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Name: " + names[random] + " Age is : " + ages[random] + "Fav car is :" + cars[random]);
        }
    }
}
