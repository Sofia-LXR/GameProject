using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderCameraController : MonoBehaviour
{
    private  GameObject CarPlayer;
    private float MinX, MinY, MaxX, MaxY;
    // Start is called before the first frame update
    void Start()
    {
        CarPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(CarPlayer.transform.position.x, transform.position.y,CarPlayer.transform.position.z);
    }
}
