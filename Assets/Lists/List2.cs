using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List2 : MonoBehaviour
{
    public List<GameObject> prefabs;
    public List<GameObject> objectsCreated;
    bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&canSpawn)
        {
            if(objectsCreated.Count > 10)
            {
                canSpawn = false;
                for(int i =0; i < objectsCreated.Count; i++)
                {
                    MeshRenderer rend = objectsCreated[i].GetComponent<MeshRenderer>();

                    rend.sharedMaterial.color = Color.green;
                }
                objectsCreated.Clear();
            }

            else
            {
                Spawn();
            }
        }
    }



    void Spawn()
    {
        
        Vector3 randomPos = new Vector3(Random.Range(0, 10), Random.Range(0, 10), 0);
        GameObject spawnedObject = prefabs[Random.Range(0, prefabs.Count)];


        Instantiate(spawnedObject, transform.position = randomPos, Quaternion.identity);
        objectsCreated.Add(spawnedObject);
    }
}
