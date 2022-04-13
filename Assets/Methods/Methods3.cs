using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods3 : MonoBehaviour
{
    public Vector3[] randomPos;
    // Start is called before the first frame update
    void Start()
    {
        GenerateSpawns();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateSpawns()
    {
        for(int i =0; i<randomPos.Length; i++)
        {
           randomPos[i]= MakeSpawn();
        }
        transform.position = randomPos[Random.Range(0, randomPos.Length)];
    }

    Vector3 MakeSpawn()
    {
        Vector3 newPos = new Vector3(Random.Range(0, 10),  Random.Range(0, 10), Random.Range(0, 10));

        return newPos;
    }
}
