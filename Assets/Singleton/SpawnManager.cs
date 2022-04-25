using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    static SpawnManager _instance;

    public static SpawnManager Instance
    {
        get
        {
            if (_instance == null)
                print("Spawn Manager is null");
            return _instance;
        }
    }

    public void Spawn()
    {
        print("start spawning");
    }

    private void Awake()
    {
        _instance = this;
    }
}
