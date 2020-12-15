using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotsBorn : MonoBehaviour
{
    public GameObject Depots_Obj;
    private  GameObject Obj;
    public GameObject[] DepotPoints;
    private int Index;
    
    void Start()
    {
        for (int i = 0; i < DepotPoints.Length; i++)
        {
            Obj = Instantiate(Depots_Obj, DepotPoints[i].transform.position, Quaternion.identity);
            Obj.transform.parent = DepotPoints[i].transform;
        }
        for(int i = 0; i < 5; i++)
        {
            Index = Random.Range(0, DepotPoints.Length);
            DepotPoints[i].SetActive(false);
        }
        

    }

    void Update()
    {
        
    }
    

}
