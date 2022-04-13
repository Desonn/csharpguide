using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods2 : MonoBehaviour
{
    [SerializeField]
    int health, damgeAmount;
   public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        dead = isDead();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isDead()==false)
        {
           
           
            
                damgeAmount = Random.Range(0, 15);
                isDead();
                Damage(damgeAmount);
                
           
        }
    }

    void Damage(int dmg)
    {
        health -= dmg;
    }
   private bool isDead()
    {

        return health < 1;  
    }
}
