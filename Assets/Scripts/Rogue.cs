using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rogue : MonoBehaviour
{
    public int maxHealth = 1500;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    private readonly System.Random random = new System.Random(); 
    public Boss boss;
    public Rogue rogue;

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

            damage = random.Next(15, 26);
            boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalRogueDamageDealt() {
        return totalDamage;
    }

    public int TotalRogueDamageTaken() {
        return currentHealth;
    }

    public void AddHealth(int heal) {
        currentHealth += heal;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // dead
        } else {
            rogue.DealDamage();
        }
    }
}
