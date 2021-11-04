using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mage : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    private readonly System.Random random = new System.Random();
    public Boss boss; 
    private Mage mage;

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

    // Update is called once per frame
    public void DealDamage() {
        if(gameObject.tag == "Boss") {

            damage = random.Next(5, 31);
            boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalMageDamageDealt() {
        return totalDamage;
    }

    public int TotalMageDamageTaken() {
        return currentHealth;
    }

    public void AddHealth(int heal) {
        currrentHealth += heal;
    } 

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // dead
        } else {
            mage.DealDamage();
        }
    }
}
