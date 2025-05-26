using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOff : MonoBehaviour
{
    [SerializeField] GameObject ball01;
    [SerializeField] GameObject ball02;

    private void OnTriggerEnter(Collider other)
    {
        ball01.SetActive(true);
        ball02.SetActive(true);
    }
}
