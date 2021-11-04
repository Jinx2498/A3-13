using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : MonoBehaviour
{
    public int maxHealth = 900;
    public int maxMama = 1000;
    public int currentHealth;
    public int currentMana;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMama;
    }

    public void TakeDamage(int amount) {
        currentHealth =- amount;

        if (currentHealth <= 0) {
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
        if (currentHealth <= 0) {
            // dead
        } else {
            // Heal
            currentMana += 3;
        }
    }
}
