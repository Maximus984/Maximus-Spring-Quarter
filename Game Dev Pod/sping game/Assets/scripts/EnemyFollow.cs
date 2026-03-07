using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    } 

    private void Update()
    {
        // Update the destination of the enemy to the player's current position
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();

        // If we hit the player
        if (player != null)
        {
            // Destroy the player
            Destroy(collision.gameObject);
        }
    }
}