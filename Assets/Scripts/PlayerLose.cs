using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{

    public float deathYTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < deathYTrigger){

            GameObject obj = GameObject.Find("WhisperSource");
            //UnityEngine.Debug.Log(obj);
            Destroy(obj);

            LevelGenerator.SetMazeNumber(0);

            SceneManager.LoadScene("GameOver");
        }

        
    }
}
