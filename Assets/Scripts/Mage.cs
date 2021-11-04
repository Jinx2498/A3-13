using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mage : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currrentHealth;
    public static int damage;
    public int totalDamage;
    private readonly System.Random random = new System.Random(); 

    // Start is called before the first frame update
    void Start()
    {
        currrentHealth = maxHealth;
    }

    public void TakeDamage(int amount) {
        currrentHealth =- amount;

        if (currrentHealth <= 0) {
            //Dead
            //Go back to main menu or scorres
        }
    }

    // Update is called once per frame
    public void DealDamage() {
        if(gameObject.tag == "Boss") {

            damage = random.Next(5, 31);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalMageDamageDealt() {
        return totalDamage;
    }

    public int TotalMageDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currrentHealth <= 0) {
            // dead
        } else {
            Mage.DealDamage();
        }
    }
}
