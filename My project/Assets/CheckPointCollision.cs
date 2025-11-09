using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        UnityEngine.Debug.Log(other.tag);

        if(other.tag == "Player"){
            UnityEngine.Debug.Log("Collided");
            FindObjectOfType<LevelManager>().CurrentCheckpoint = this.gameObject;
        }
    }
}
