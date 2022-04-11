using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchtest3 : MonoBehaviour
{
    [SerializeField] int _weaponID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            _weaponID = 0;
        else if (Input.GetKeyDown(KeyCode.Alpha1))
            _weaponID = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _weaponID = 2;
        switch (_weaponID)
        {
            case 0: print("You picked the Knife");
                break;
            case 1: print("you pick handgun");
                break;
            case 2: print("you pick machine gun");
                break;
        }
    }
}
