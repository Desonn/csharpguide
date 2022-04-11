using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalc : MonoBehaviour
{
  public int bill = 40;
  public  float tipAmount;
   public float total;
    // Start is called before the first frame update
    void Start()
    {
        total = bill * (tipAmount/100) + bill;
        Debug.Log("Your Bill is: "+bill + " Tip is: "+tipAmount + " Bill total is : " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
