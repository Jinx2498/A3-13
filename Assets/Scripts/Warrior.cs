using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Warrior : MonoBehaviour
{
    public int maxHealth = 3000;
    public int currentHealth;
    public static int damage;
    public int totalDamage;
    public float totalBossDamage;
    public Scene scene;
    public string sceneName;
    private readonly System.Random random = new System.Random(); 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
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

    public int GetHealth() {
        return currentHealth;
    }

    public void AddHealth(int heal) {
        currrentHealth += heal;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            // dead
        } else {
            Warrior.DealDamage();
            if(sceneName == "Level3") {
                totalBossDamage = Warrior.TotalWarriorDamageTaken() + MoonkinDruid.TotalDruidDamageTaken() + Priest.TotalPriestDamageTaken() + Rogue.TotalRogueDamageTaken() + Mage.TotalMageDamageTaken();
                totalBossDamage *= 0.01;
                int round = (int)Math.Round(precise, 0);
                Warrior.TakeDamage(round);
            }
        }

    
    }
}
