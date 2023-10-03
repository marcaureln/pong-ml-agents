using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject playerOnLeft, playerOnRight, ball; 
    
    // Start is called before the first frame update
    void Start()
    {
        Kickstart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kickstart()
    {
        playerOnLeft.transform.position = new Vector3(-10, 0, -1);
        playerOnRight.transform.position = new Vector3(10, 0, -1);
        ball.transform.position = new Vector3(0, 0, -1);
        ball.GetComponent<BallController>().Kickstart();
    }
}
