using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Warrior : MonoBehaviour
{
    public int maxHealth = 3000;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    public float totalBossDamage;
    private readonly System.Random random = new System.Random(); 
    public Boss boss;
    private Warrior warrior;

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

            damage = random.Next(40, 51);
            boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    

    public int TotalWarriorDamageDealt() {
        return totalDamage;
    }

    public int TotalWarriorDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // dead
        } else {
            warrior.DealDamage();
        }

        if(GetActiveScene == "Level3") {
            totalBossDamage = warrior.TotalWarriorDamageTaken() + moonkinDruid.TotalDruidDamageTaken() + priest.TotalPriestDamageTaken() + rogue.TotalRogueDamageTaken() + mage.TotalMageDamageTaken();
            totalBossDamage *= 0.01;
            int round = (int)Math.Round(precise, 0);
            warrior.TakeDamage(round);
        }
    }
}
