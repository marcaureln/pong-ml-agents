using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D _rb;

    private bool _isPlaying = false;

    public float kickstartForce = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlaying) return;
        Kickstart();
        _isPlaying = true;
    }

    void Kickstart()
    {
        float randomAngle = Random.Range(135f, 225f);
        Vector2 launchDirection = Quaternion.Euler(0, 0, randomAngle) * Vector2.right; // Convert angle to direction

        _rb.velocity = launchDirection * kickstartForce;
    }
}
