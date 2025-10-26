using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public Transform target;
    public float cameraspeed;
    public float minX,maxX;
    public float minY,maxY;
    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        if(target!=null)
        {
            Vector2 newcamposition = Vector2.Lerp(transform.position,target.position,Time.deltaTime*cameraspeed);
       float ClampX= Mathf.Clamp(newcamposition.x,minX,maxX);
       float ClampY= Mathf.Clamp(newcamposition.x,minY,maxY);
       transform.position=new Vector3(ClampX,ClampY,-10f);
        }

    }
}
