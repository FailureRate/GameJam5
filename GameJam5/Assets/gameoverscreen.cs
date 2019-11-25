using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscreen : MonoBehaviour
{
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadscene()
    {
        enemySpawner.playerdead = false;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
