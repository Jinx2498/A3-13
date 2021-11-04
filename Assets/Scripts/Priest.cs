using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : MonoBehaviour
{
    public int maxHealth = 900;
    public int maxMama = 1000;
    public int currrentHealth;
    public int currretMana;

    // Start is called before the first frame update
    void Start()
    {
        currrentHealth = maxHealth;
        currretMana = maxMama;
    }

    void TakeDamage(int amount) {
        currrentHealth =- amount;

        if (currrentHealth <= 0) {
            //Dead
            //Go back to main menu or scorres
        }
    }

    void SmallHeal() {

    }

    void BigHeal() {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currrentHealth <= 0) {
            // dead
        } else {
            // Heal
            currentMana += 3;
        }
    }
}
