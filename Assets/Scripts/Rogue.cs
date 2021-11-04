using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : MonoBehaviour
{
    public int maxHealth = 1500;
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

    void DealDamage() {
        if(other.gameObject.tag == "Boss") {
            Random rand = new Random();

            damage = rand.Next(15, 26);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    void TotalRogueDamageDealt() {
        return totalDamage;
    }

    void TotalRogueDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currrentHealth <= 0) {
            // dead
        } else {
            Rogue.DealDamage();
        }
    }
}
