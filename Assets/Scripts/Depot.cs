using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depot : MonoBehaviour
{
    public int Speed = 60;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        float time = Time.deltaTime;
        transform.Rotate(new Vector3(0,time*Speed,0));
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
           
        }
    }
}
