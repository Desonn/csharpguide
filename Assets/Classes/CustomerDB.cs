using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDB : MonoBehaviour
{
    [SerializeField]
    Customer customer1;
    public Customer[] customers; 
    // Start is called before the first frame update
    void Start()
    {
        customer1 = new Customer("Bob", "John", 33, "Male", "Mower");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
