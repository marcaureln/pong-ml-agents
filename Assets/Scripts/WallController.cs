using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public GameObject agent, mainCamera;
    public bool isAgentOpponent;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Ball")) return;
        
        mainCamera.GetComponent<GameController>().Kickstart();
            
        if (isAgentOpponent)
        {
            agent.GetComponent<AgentController>().Scored();
        }
        else
        {
            agent.GetComponent<AgentController>().Conceded();
        }
    }
}