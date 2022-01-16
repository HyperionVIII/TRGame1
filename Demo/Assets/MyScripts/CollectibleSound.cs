using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSound : MonoBehaviour
{
    [SerializeField] public AudioSource collectHealthSoundEffect;
    [SerializeField] public AudioSource collectCoinSoundEffect;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Heal"))
        {
            collectHealthSoundEffect.Play();
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            collectCoinSoundEffect.Play();
        }
    }
}