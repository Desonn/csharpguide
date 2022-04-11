using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour
{
    string myName = "Jim";
    int age = 33;
    float speed = 5.5f;
    float health = 100;
    int score = 10;
    bool hasKeys = true;
    int ammoCount = 15;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My Name " + myName + " age: " + age + " speed " + speed + " My health " + health + " score: " + score + " ammo left: " + ammoCount);
        Debug.Log("Keys Collected:" + hasKeys);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
