using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCCar : MonoBehaviour
{
    public GameObject npccar;
    GameObject NPC;
    public Transform[] NPCCarpoint_pos;
    int index;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        NPC = Instantiate(npccar);
        NPC.transform.parent = NPCCarpoint_pos[Random.Range(0, NPCCarpoint_pos.Length)].transform;
        NPC.AddComponent<NavMeshAgent>();
        NPC.GetComponent<NavMeshAgent>().baseOffset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        
        if (NPC.GetComponent<NavMeshAgent>().remainingDistance < 0.2f)
        {
            index++;
            index %= NPCCarpoint_pos.Length;
            NPC.GetComponent<NavMeshAgent>().SetDestination(NPCCarpoint_pos[index].position);
        }
    }
}
