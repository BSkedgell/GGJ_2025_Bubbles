using UnityEngine;
using UnityEngine.AI;

public class FollowScript : MonoBehaviour
{
    public NavMeshAgent navMeshAgent; // Reference to the NavMeshAgent component
    private Transform playerTransform; // Transform of the player

    void Start()
    {
        // Find the player object using the "Player" tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            // Get the player's Transform
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("No object with the 'Player' tag found in the scene.");
        }
    }

    void Update()
    {
        // If the player's transform is found, update the destination of the NavMeshAgent
        if (playerTransform != null)
        {
            navMeshAgent.SetDestination(playerTransform.position);
        }
    }
}
