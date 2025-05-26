using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickUp : MonoBehaviour
{
    //pastebin.com/R8P2sjSz

    float score = 0;
    [SerializeField] float speed = 1.0f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(clip);
            StartCoroutine(MoveToPlayer(other.transform, transform, speed));
            score++;
            Debug.Log("Twoj wynik to" + score);
            
        }
    }

     IEnumerator MoveToPlayer(Transform coin, Transform player, float speed)
    {
        float duration = 1.5f;

        float time = 0;


        while(time < duration)
        {
            coin.position = UnityEngine.Vector3.MoveTowards(coin.position, player.position,speed*Time.deltaTime);
            time += Time.deltaTime; // nasz licznik czasu - 0.05 + 0.05 + 0.05 = 3
            yield return null; // odstep czasowy - stop 1 klatka
        }
      

        Destroy(coin.gameObject);
  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);

        }
    }


   
    // Update is called once per frame
    void Update()
    {
        
    }
}
