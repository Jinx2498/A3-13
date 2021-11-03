using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int bossHealth = 0;
    public int bossDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bossHealth <= 0) {
            Destroy(gameObject);
            GameOver.gameOver();
        }
    }
}
