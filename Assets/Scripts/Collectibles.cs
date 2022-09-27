using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //THIS DESTROYS THE COINS
        
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }

        //THE CODE BELOW ADDS 1 SCORE TO THE COIN THAT THE PLAYER COLLECTS!

        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
