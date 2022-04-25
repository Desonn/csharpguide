using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                print("Game Manager is null");
            }
           
           
                return _instance;
            
        }
    }


    private void Start()
    {
        SpawnManager.Instance.Spawn();
    }

    private void Awake()
    {
        _instance = this;
    }
}
