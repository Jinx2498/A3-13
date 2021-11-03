using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonkinDruid : MonoBehaviour
{
    public int maxHealth = 1250;
    public int currrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currrentHealth = maxHealth;
    }

    void TakeDamage(int amount) {
        currrentHealth =- amount;

        if (currrentHealth <= 0) {
            //Dead
            //Go back to main menu or scorres
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
