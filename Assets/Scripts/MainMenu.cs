using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
        
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level2");
        
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
        
    }

    public void Scores()
    {
        SceneManager.LoadScene("Scores");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
