using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heal : MonoBehaviour
{
    PlayerHealth priestHealth;

    PlayerHealth mageHealth;
    PlayerHealth rogueHealth;
    PlayerHealth barbarianHealth;
    PlayerHealth moonkinDruidHealth;

    /**
     * SHOW HEALTH
    public Text phText;
    public Text mhText;
    public Text rhText;
    public Text bhText;
    public Text mohText;
    **/
    // Start is called before the first frame update
    void Start()
    {
        GameObject PT_Medieval_Priest_StPatrick = GameObject.Find("PT_Medieval_Priest_StPatrick");
        priestHealth = PT_Medieval_Priest_StPatrick.GetComponent<PlayerHealth>();

        GameObject Barbarian = GameObject.Find("Barbarian");
        barbarianHealth = Barbarian.GetComponent<PlayerHealth>();
        GameObject magi_earthen_v1 = GameObject.Find("magi_earthen_v1");
        mageHealth = magi_earthen_v1.GetComponent<PlayerHealth>();
        GameObject Basic_Bandit = GameObject.Find("Basic_Bandit");
        rogueHealth = Basic_Bandit.GetComponent<PlayerHealth>();
        GameObject HuaYao_01 = GameObject.Find("HuaYao_01");
        moonkinDruidHealth = HuaYao_01.GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        smallHeal();
        BigHeal();
        regenMana();
       
    }

    public void smallHeal()
    {
        //loop = true;
        //yield return new WaitForSeconds(1);

       
        int rand = Random.Range(1, 7);

        if (rand == 1)
        {
            rogueHealth.playerHealth += 15;

        }
        else if (rand == 2) 
        { 
        
            mageHealth.playerHealth += 15;

        }
        else if (rand == 3)
        {
            moonkinDruidHealth.playerHealth += 15;
        }
        else
        {
            priestHealth.playerHealth += 15;
        }

        priestHealth.playerMana -= 5;
        System.Threading.Thread.Sleep(1000);
        
    }

    void BigHeal()
    {
        priestHealth.playerMana -= 10;
        barbarianHealth.playerHealth += 25;
        System.Threading.Thread.Sleep(1000);
    }

    void regenMana(){
        priestHealth.playerMana += 3;
        System.Threading.Thread.Sleep(1000);
    }
}
