using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSound : MonoBehaviour
{
    public GameObject frog;
    public AudioClip sound;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source.clip = sound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
