using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    string itemName ,description;
    [SerializeField]
    Sprite itemIcon;
    [SerializeField]
    float attackPower;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(itemName + " Description: " + description);
        Debug.Log("attack power: " + attackPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
