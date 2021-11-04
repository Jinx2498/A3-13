using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currrentHealth;

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

    // Update is called once per frame
    void DealDamage() {
        if(other.gameObject.tag == "Boss") {
            Random rand = new Random();

            damage = rand.Next(5, 31);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    void TotalMageDamageDealt() {
        return totalDamage;
    }

    void TotalMageDamageTaken() {
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
