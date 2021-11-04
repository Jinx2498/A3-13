using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss : MonoBehaviour
{
    public int maxHealth = 5000;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    private readonly System.Random random = new System.Random(); 
    private Boss boss;
    public Mage mage;
    public MoonkinDruid moonkinDruid;
    public Rogue rogue;
    public Priest priest;
    public Warrior warrior;
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
        if(gameObject.tag == "Rogue" || gameObject.tag == "Mage" || gameObject.tag == "Moonkin Druid" || gameObject.tag == "Priest") {

            damage = random.Next(5, 21);
            rogue.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            mage.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            moonkinDruid.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            priest.TakeDamage(damage);
            totalDamage += damage;

        }

        if(gameObject.tag == "Warrior") {

            damage = random.Next(40, 51);
            warrior.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalBossDamageDealt() {
        return totalDamage;
    }

    public int TotalBossDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // Dead
        } else {
            boss.DealDamage();
        }
    }
}
