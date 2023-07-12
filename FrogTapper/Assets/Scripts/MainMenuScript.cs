using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public int StartLevel = 2;
    public int HowtoPlay = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startlvl()
    {
        SceneManager.LoadScene(StartLevel);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(HowtoPlay);
    }
    public void quit()
    {
        Application.Quit();
    }
}
