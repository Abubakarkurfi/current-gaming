using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform enemy;
    public Transform spawnpoint;
        
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespawnEnemy(){
        Instantiate(enemy,spawnpoint.transform.position,spawnpoint.transform.rotation);
    }
    void OnTriggerEnter2D(collider2D other){
        if(other.gameObject.tag=="player"){
            RespawnEnemy();
        }
    }
}
