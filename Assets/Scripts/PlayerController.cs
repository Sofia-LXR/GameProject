using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private static PlayerController player;

    public int Speed=3;
    private Rigidbody rigidbody;
    
    public static PlayerController Player
    {
        get
        {
            return player;
        }
    }

    private void Awake()
    {
        if(player  == null)
        {
            player = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A D 左右
        float vertical = Input.GetAxis("Vertical"); //W S 上 下
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,90,0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, -180, 0));
        }
       if(horizontal !=0||vertical != 0)
        {
            this.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Portal")
        {
            PlayerController.player.Speed()
        }
    }
}
