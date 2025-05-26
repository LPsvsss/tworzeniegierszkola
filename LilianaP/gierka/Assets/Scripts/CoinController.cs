using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(10*Time.deltaTime, 10*Time.deltaTime, 0); 
    }
}
