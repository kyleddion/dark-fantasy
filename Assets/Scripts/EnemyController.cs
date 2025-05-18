using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    public Transform target;
    public float attackRange = 2f;
    public int attackDamage = 10;

    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance <= attackRange)
            {
                AttackPlayer();
            }
        }
    }

    void AttackPlayer()
    {
        // Placeholder for attack logic
        Debug.Log($"Enemy attacks for {attackDamage} damage");
    }
}
