using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoonkinDruid : MonoBehaviour
{
    public int maxHealth = 1250;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    private readonly System.Random random = new System.Random(); 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount) {
        currentHealth =- amount;

        if (currentHealth <= 0) {
            //Dead
            //Go back to main menu or scorres
        }
    }

    public void DealDamage() {
        if(gameObject.tag == "Boss") {

            damage = random.Next(5, 16);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalDruidDamageDealt() {
        return totalDamage;
    }

    public int TotalDruidDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // dead
        } else {
            MoonkinDruid.DealDamage();
        }
    }
}
