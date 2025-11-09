using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health=3;
    public int lives=3;

    private float flickerTime=0f;
    public float flickerDuration=0.1f;

    private SpriteRenderer sr;

    private bool isImmune=false;
    private float immunityTime=0f;
    public float immunityDuration=1.5f;
    void start(){
        sr=GetComponent<spriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isImmune==true){
            Spriteflicker();
            immunityTime=immunityTime+Time.deltaTime;
            if(immunityTime>=immunityDuration){
                isimmune=false;
                sr.enabled=true;
            }
        }
    }

    public void TakeDamage(int damage){
        if(isImmune==false){
            health=healt-damge;
            if(health<0)
            health=0;
            if(lives>0&&health==0){
                FindObjectOftype<LevelManager>().RespawnPlayer();
                health =3;
                lives--;
            }
            else if (lives==0&&health==0){
                Debug.log("Gamaeover");
                Destroy(this.gameObject);
            }
            Debug.Log("player Health:"+health.ToString());
            Debug.Log("player Lives:"+lives.Tostring());
        }
        isImmune =true;
        immunityTime=0f;
    }
    void SpriteFlicker(){
        if(flicker<flickerDuration)
        {flicherTime=flickerTime+Time.deltaTime;}
        else if (flickerTime>=flickerDuration){
            sr.enabled=!(sr.enabled);
            flickerTime=0;
        }
    }
}
