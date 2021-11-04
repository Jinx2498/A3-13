using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonkinDruid : MonoBehaviour
{
    public int maxHealth = 1250;
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
        if(other.gameObject.tag == "Boss") {
            Random rand = new Random();

            damage = rand.Next(5, 16);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    void TotalDruidDamageDealt() {
        return totalDamage;
    }

    void TotalDruidDamageTaken() {
        return currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currrentHealth <= 0) {
            // dead
        } else {
            MoonkinDruid.DealDamage();
        }
    }
}
