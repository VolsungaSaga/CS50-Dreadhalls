using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSkullBob : MonoBehaviour
{

    public Vector3 topPosition = new Vector3(0, 0.1f,0);
    public Vector3 bottomPosition = new Vector3(0,-0.1f,0);

    public float desiredSpeed = .1f; //meters per second.

    private Vector3 target;
    private Vector3 origin;

    private bool goingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        origin = gameObject.transform.position;
        target = origin + topPosition;
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, target) < 0.001){
            if(goingUp){
                target = origin + bottomPosition;
                goingUp = false;
            }
            else{
                target = origin + topPosition;
                goingUp = true;
            }
        }

        Vector3 newPosition = Vector3.MoveTowards(gameObject.transform.position, target, desiredSpeed * Time.deltaTime);
        gameObject.transform.position = newPosition;
        
    }
}
