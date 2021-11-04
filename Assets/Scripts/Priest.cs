using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Priest : MonoBehaviour
{
    public int maxHealth = 900;
    public int maxMama = 1000;
    public int currentHealth;
    public int currentMana;
    public Scene scene;
    public string sceneName;
    private readonly System.Random random = new System.Random(); 
    public Mage mage;
    public MoonkinDruid moonkinDruid;
    public Rogue rogue;
    private Priest priest;
    public Warrior warrior;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentMana = maxMama;
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

    public void SmallHeal() {

        int rand = Random.Range(1, 10);

        if (rand == 1)
        {
            rogue.AddHealth(15);

        }
        else if (rand == 2) 
        { 
        
            mage.AddHealth(15);

        }
        else if (rand == 3)
        {
            moonkinDruid.AddHealth(15);
        }
        else 
        {
            priest.AddHealth(15);
        }

        currretMana -= 5;

    }

    public void BigHeal() {

        currretMana -= 10;
        warrior.AddHealth(25);
        
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
            SmallHeal();
            BigHeal();

            if(sceneName == "Level2") {
                if(warrior.GetHealth() <= 1500) {
                    int rand = Random.Range(1,3);
                    if(rand == 1) {
                        SmallHeal();
                    } else {
                        BigHeal();
                    }
                }
            }
            currentMana += 3;
        }

    }
}
