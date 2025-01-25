using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class FollowScript : MonoBehaviour

{
public NavMeshAgent enemy;
public Transform player;

    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
