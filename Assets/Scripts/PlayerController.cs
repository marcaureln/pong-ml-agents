using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public bool autoPilot = true;
    public Transform ball;
    private Rigidbody2D _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (autoPilot)
        {
            var position = transform.position;
            float targetY = Mathf.Lerp(position.y, ball.position.y + Random.Range(-1, 1), Time.deltaTime * speed);
            targetY = Mathf.Clamp(targetY, -3.0f, 3.0f);
            float velocityY = (targetY - position.y) / Time.deltaTime;
            _rb.velocity = new Vector2(0, velocityY);
            return;
        }
        
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0, verticalInput) * speed;
        _rb.velocity = movement;
    }
}
