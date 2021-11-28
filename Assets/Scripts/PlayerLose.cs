using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{

    public float deathYTrigger;
    public float screamYTrigger;
    private bool screamed = false;

    public AudioClip screamSound; 
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(!screamed && gameObject.transform.position.y < screamYTrigger){
            audioSource.PlayOneShot(screamSound);
            screamed = true;
        }

        if(gameObject.transform.position.y < deathYTrigger){

            GameObject obj = GameObject.Find("WhisperSource");
            //UnityEngine.Debug.Log(obj);
            Destroy(obj);

            LevelGenerator.SetMazeNumber(0);

            SceneManager.LoadScene("GameOver");
        }

        
    }
}
