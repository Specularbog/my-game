using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject k;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.Equals(k)) 
        {
            if (k.GetComponent<Knight>().power)
            {
              //  Destroy(gameObject);
             //   Debug.Log("Enemy Killed, should destroy sword");
             //   k.GetComponent<Knight>().power = false;
              //  Destroy(k.GetComponent<Knight>().weapon);
            }
        }

    }



    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
