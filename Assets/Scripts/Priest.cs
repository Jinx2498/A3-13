using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : MonoBehaviour
{
    public int maxHealth = 900;
    public int maxMama = 1000;
    public int currrentHealth;
    public int currretMana;
    // PlayerHealth priestHealth;

    // PlayerHealth mageHealth;
    // PlayerHealth rogueHealth;
    // PlayerHealth barbarianHealth;
    // PlayerHealth moonkinDruidHealth;

    // Start is called before the first frame update
    void Start()
    {
        currrentHealth = maxHealth;
        currretMana = maxMama;

        // ameObject PT_Medieval_Priest_StPatrick = GameObject.Find("PT_Medieval_Priest_StPatrick");
        // priestHealth = PT_Medieval_Priest_StPatrick.GetComponent<PlayerHealth>();

        // GameObject Barbarian = GameObject.Find("Barbarian");
        // barbarianHealth = Barbarian.GetComponent<PlayerHealth>();
        // GameObject magi_earthen_v1 = GameObject.Find("magi_earthen_v1");
        // mageHealth = magi_earthen_v1.GetComponent<PlayerHealth>();
        // GameObject Basic_Bandit = GameObject.Find("Basic_Bandit");
        // rogueHealth = Basic_Bandit.GetComponent<PlayerHealth>();
        // GameObject HuaYao_01 = GameObject.Find("HuaYao_01");
        // moonkinDruidHealth = HuaYao_01.GetComponent<PlayerHealth>();
    }

    public void TakeDamage(int amount) {
        currrentHealth =- amount;

        if (currrentHealth <= 0) {
            //Dead
            //Go back to main menu or scorres
        }
    }

    public void SmallHeal() {

        int rand = Random.Range(1, 10);

        if (rand == 1)
        {
            Rogue.AddHealth(15);

        }
        else if (rand == 2) 
        { 
        
            Mage.AddHealth(15);

        }
        else if (rand == 3)
        {
            MoonkinDruid.AddHealth(15);
        }
        else 
        {
            Priest.AddHealth(15);
        }

        currretMana -= 5;

    }

    public void BigHeal() {

        currretMana -= 10;
        barbarianHealth.playerHealth += 25;
        
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
            SmallHeal();
            BigHeal();
            if(GetActiveScene == "Level2") {
                if(Warrior.GetHealth() <= 1500) {
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
