using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ellipticalmover : MonoBehaviour
{
    float timeCounter=0;
    float speed;
    float width;
    float height;
    float rotation;
    float y=175;

    // Start is called before the first frame update
    void Start()
    {
        rotation=0;
        speed=0.25f;
        width=200;
        height=300; 
        y=175;
    }

    // Update is called once per frame
    void Update()
    {
        rotation=rotation-0.314f/5;
        timeCounter +=Time.deltaTime*speed;
        float x=550+Mathf.Cos(timeCounter)*width;   
        if(y>75)y=y-0.07f;
        if(Input.GetMouseButtonDown(0))y=y+10;
        float z=550+Mathf.Sin(timeCounter)*height;
        transform.position = new Vector3(x,y,z) ;
        transform.rotation = Quaternion.Euler(new Vector3(0,rotation,0));    
    }
}
