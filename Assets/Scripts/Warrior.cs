using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public int maxHealth = 3000;
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
        if(gameObject.tag == "Boss") {

            damage = random.Next(40, 51);
            Boss.TakeDamage(damage);
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
        if (currrentHealth <= 0) {
            // dead
        } else {
            Warrior.DealDamage();
        }
    }
}
