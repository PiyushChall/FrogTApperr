using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogKiller : MonoBehaviour
{
    //variable to store the death effect
    [SerializeField] public GameObject DeathEffect;

    public int TotalScore;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //rhis block of code tells the engine to imcrement the totalscore by 1 when the player clicks on the gameobject.
        TotalScore = PlayerPrefs.GetInt("Score ", 0);
        TotalScore++;
        PlayerPrefs.SetInt("Score ", TotalScore);
        PlayerPrefs.Save();
        Debug.Log("Score " + TotalScore.ToString());
        //rhis line of code tells the engine to destroy the game object when the player clicks on the gameobject.
        Destroy(gameObject);



        //this code tells the computer to instantiate(spawn) the gameobject stored in the deatheffect variable when the player clicks on the gameobject.
        //Here the DeathEffect is a variable in which we can store the prefab.
        //transform.position specifies where the prefab will be spawned.
        //Quaternion.identity is used to specify that we dont want any rotation to our spawned prefab.
        Instantiate(DeathEffect, transform.position, Quaternion.identity);      
        
    }
}
