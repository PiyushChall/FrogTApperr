using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    //this is a declaration of the variable which stores the game object.
    public GameObject frog;


    //this is a variable which we can change in the inspecter of unity for our desired size.
    public float desiredScale = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        // this line of code is used to find the game object named frog in the scene.
        frog = GameObject.Find("Frog");

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void ScaleThis()
    {
        frog.gameObject.transform.localScale = new Vector3(desiredScale, desiredScale, 0f);
    }
}
