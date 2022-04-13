using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer 
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;



    public  Customer(string fname, string lName, int age, string gender, string job)
    {
        this.firstName = fname;
        this.lastName = lName;
        this.age = age;
        this.gender = gender;
        this.occupation = job;
    }
    
}
