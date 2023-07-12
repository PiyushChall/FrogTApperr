using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThem : MonoBehaviour
{
    //this is used to store the frog prefab which we made in unity into a variable called frog.
    public GameObject frog;

    //I made this to determine or chage the spawning time from the inspectre
    public float howManySec = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnthefrogs());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnthefrogs()
    {
        while (true)
        {
            yield return new WaitForSeconds(howManySec);


            //this lline of code is used to generate/create random number between 0 & screenHeight
            float posX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, 
                Camera.main.ScreenToWorldPoint(new Vector2(0, 10)).y);

            //this lline of code is used to generate/create random number between 0 & screenWidth
            float posY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, 
                Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            //this allocates the cordinate of the random number which we made
            Vector2 spawPosition = new Vector2(posX, posY);


            //this is to generate the frog in the generated location.
            Instantiate(frog, spawPosition, Quaternion.identity);
        }
    }
}
