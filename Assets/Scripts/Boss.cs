using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int maxHealth = 5000;
    public int currrentHealth;
    public int damage;
    public int totalDamage;


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

    void DealDamage() {
        if(other.gameObject.tag == "Rogue" || other.gameObject.tag == "Mage" || other.gameObject.tag == "Moonkin Druid" || other.gameObject.tag == "Priest") {
            Random rand = new Random();

            damage = rand.Next(5, 21);
            Rogue.TakeDamage(damage);
            totalDamage += damage;

            damage = rand.Next(5, 21);
            Mage.TakeDamage(damage);
            totalDamage += damage;

            damage = rand.Next(5, 21);
            MoonkinDruid.TakeDamage(damage);
            totalDamage += damage;

            damage = rand.Next(5, 21);
            Priest.TakeDamage(damage);
            totalDamage += damage;

        }

        if(other.gameObject.tag == "Warrior") {
            Random rand = new Random();

            damage = rand.Next(40, 51);
            Warrior.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    void TotalBossDamageDealt() {
        return totalDamage;
    }

    void TotalBossDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currrentHealth <= 0) {
            // Dead
        } else {
            Boss.DealDamage();
        }
    }
}
