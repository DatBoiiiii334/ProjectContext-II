using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 0.5f;

    private void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * -speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }


}
    
 
