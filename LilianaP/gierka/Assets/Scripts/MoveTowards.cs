using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] int speed = 1;
    Vector3 playerPosition;
    void Start()
    {
        playerPosition = player.transform.position;
    }

   
    void Update()
    {
        playerPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
