using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color1 : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(ColorChange());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ColorChange()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            rend.material.color = Color.HSVToRGB(Random.value, Random.value, Random.value);

        } 
    }
}
