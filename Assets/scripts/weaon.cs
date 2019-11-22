using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaon : MonoBehaviour
{
    public GameObject e;
    public GameObject k;
    private bool isEquipped = false;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject.Equals(k))
        {
            k.GetComponent<Knight>().SetSword(transform);
            isEquipped = true;
            k.GetComponent<Knight>().power = true;
            k.GetComponent<Knight>().weapon = gameObject;
            Debug.Log(" " + isEquipped);
        }


        if(collision.transform.tag == "e")
        {
            //Debug.Log("In weapon " + collision.transform.name);
           // isEquipped = false;
            //Debug.Log("Should destroy sword");

            //k.GetComponent<Knight>().power = false;
            //k.GetComponent<Knight>().weapon = gameObject;

        }
        /*
        if (collision.collider.gameObject.Equals(e))
        {
            k.GetComponent<Knight>().power = false;
            k.GetComponent<Knight>().weapon = gameObject;
        }
        */

    }

    void Update()
    {
        if (isEquipped)
        {
            Vector2 Knightpos = new Vector2(k.transform.position.x, k.transform.position.y + 2);
            transform.position = Knightpos;
        }
        



        
    }

    public void DestroyWeapon()
    {
        Destroy(gameObject);
    }

    public Transform GetSword()
    {
        return transform;
    }
}