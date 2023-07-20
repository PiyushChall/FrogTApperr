using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerMyVersion : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] Frogs;

    public float howManySec = 1.8f;

    [SerializeField] Text scoreText;

    public int TotalScore;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnfrogs());
        StartCoroutine(Speedincrease());
    }

    // Update is called once per frame
    void Update()
    {
        TotalScore = PlayerPrefs.GetInt("Score ", 0);
        scoreText.text = "Score " + TotalScore.ToString();
    }
    IEnumerator spawnfrogs()
    {
        while (true)
        {
            yield return new WaitForSeconds(howManySec);

            int randomEnemy = Random.Range(0, Frogs.Length);
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(Frogs[0], spawnPoints[randomSpawnPoint].position, transform.rotation);
        }
    }

    IEnumerator Speedincrease()
    {
        while (true)
        {
            while (howManySec > 0.2f)
            {
                yield return new WaitForSecondsRealtime(5f);
                howManySec = howManySec - 0.2f;
            }
            
        }
    }
}
