using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HealthLogger : MonoBehaviour
{
    StreamWriter writer;
    public string filename;
    int t;
    public bool logging = true;

    // Start is called before the first frame update
    void Start()
    {
        writer = new StreamWriter(filename);
        writer.WriteLine("Time-step,boss,warrior,rogue,mage,druid,priest");
    }

    // Update is called once per frame
    void Update()
    {
        if (!logging) return;   // Do not output health to file if not logging

        writer.Write(t);
        writer.Write(',');
        writer.Write(GameObject.Find("monster_orc").GetComponent<Boss>().currentHealth);
        writer.Write(',');
        writer.Write(GameObject.Find("Barbarian").GetComponent<Warrior>().currentHealth);
        writer.Write(',');
        writer.Write(GameObject.Find("Basic_Bandit").GetComponent<Rogue>().currentHealth);
        writer.Write(',');
        writer.Write(GameObject.Find("magi_earthen_v1.0").GetComponent<Mage>().currentHealth);
        writer.Write(',');
        writer.Write(GameObject.Find("HuaYao_01").GetComponent<MoonkinDruid>().currentHealth);
        writer.Write(',');
        writer.Write(GameObject.Find("PT_Medieval_Priest_StPatrick").GetComponent<Priest>().currentHealth);
        writer.Write('\n');
        ++t;
    }
}
