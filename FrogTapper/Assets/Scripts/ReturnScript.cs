using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnScript : MonoBehaviour
{
    public int MainMenu = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returnn()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
