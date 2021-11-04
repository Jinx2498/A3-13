using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int maxHealth = 5000;
    public int currrentHealth;
    public static int damage;
    public int totalDamage;
    private readonly Random random = new Random(); 


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

    public void DealDamage() {
        if(gameObject.tag == "Rogue" || gameObject.tag == "Mage" || gameObject.tag == "Moonkin Druid" || gameObject.tag == "Priest") {

            damage = random.Next(5, 21);
            Rogue.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            Mage.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            MoonkinDruid.TakeDamage(damage);
            totalDamage += damage;

            damage = random.Next(5, 21);
            Priest.TakeDamage(damage);
            totalDamage += damage;

        }

        if(gameObject.tag == "Warrior") {

            damage = random.Next(40, 51);
            Warrior.TakeDamage(damage);
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
        if (currrentHealth <= 0) {
            // Dead
        } else {
            Boss.DealDamage();
        }
    }
}
