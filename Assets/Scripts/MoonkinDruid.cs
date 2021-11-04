using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonkinDruid : MonoBehaviour
{
    public int maxHealth = 1250;
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

            damage = random.Next(5, 16);
            Boss.TakeDamage(damage);
            totalDamage += damage;
        }
    }

    public int TotalDruidDamageDealt() {
        return totalDamage;
    }

    public int TotalDruidDamageTaken() {
        return currentHealth;
    }

    public void AddHealth(int heal) {
        currrentHealth += heal;
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
