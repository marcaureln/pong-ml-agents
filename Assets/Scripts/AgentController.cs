using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.VisualScripting;
using UnityEngine;

public class AgentController : Agent
{
    public float speed = 5f;
    private Rigidbody2D _rb;
    [SerializeField] private Transform ballTransform;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public override void OnEpisodeBegin()
    {
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(ballTransform.position);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float verticalInput = actions.ContinuousActions[0];
        Vector2 movement = new Vector2(0, verticalInput) * speed;
        _rb.velocity = movement;
    }
    
    public override void Heuristic(in ActionBuffers actionsOutput)
    {
        ActionSegment<float> actions = actionsOutput.ContinuousActions;
        actions[0] = Input.GetAxis("Vertical");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<BallController>(out BallController ball))
        {
            AddReward(1f);
        }
    }

    public void Scored()
    {
        AddReward(100f);
        EndEpisode();
    }

    public void Conceded()
    {
        SetReward(0f);
        EndEpisode();
    }
}