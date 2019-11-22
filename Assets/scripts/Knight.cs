using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public float jump = 300f;
    public float speed = 5f;
    public Quaternion rotation;
    public bool power = false;
    public GameObject weapon;
    public GameObject Floor;
    public GameObject K;
    private int numOfJumps = 0;
    private bool istouching;
    public GameObject startoflvl1;

    // Start is called before the first frame update
    void Start()
    {
        power = false;
        istouching = false;
    }

    // Update is called once per frame
    public GameObject e;
    public GameObject k;
    private Transform swordEquipped;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //        Debug.LogError(collision.transform.name + " " + collision.gameObject.tag);
        if (collision.gameObject.tag == "e")
        {
            Debug.Log(k.GetComponent<Knight>().power);
            if (!k.GetComponent<Knight>().power)
            {
                Debug.Log("Should Send back");
                float z = Floor.transform.position.z;
                float y = Floor.transform.position.y + 5;
                float x = Floor.transform.position.x;
                Vector3 v = new Vector3(x, y, z);
                k.transform.position = v;
            }
            else if (k.GetComponent<Knight>().power == true)
            {
                Debug.Log("Should Kill");
                collision.transform.GetComponent<enemy>().DestroyEnemy();
                k.GetComponent<Knight>().power = false;
                swordEquipped.transform.GetComponent<weaon>().DestroyWeapon();


            } else if (collision.gameObject.tag == "g")
            {
                istouching = true;
            }
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
            //            Debug.Log("Before " +  rotation.y);
            transform.localRotation = rotation;
            //        Debug.Log("After " + rotation.y);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            rotation = new Quaternion(0.0f, 180.0f, 0.0f, 1.0f);
            //       Debug.Log("Before " + rotation.y);
            transform.localRotation = rotation;
            //            Debug.Log("After " + rotation.y);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && numOfJumps < 2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
            numOfJumps++;
        }
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(0, -speed * Time.deltaTime, 0);
        //}
        // print(power);
    }

    public void SetSword(Transform swordToSet)
    {
        swordEquipped = swordToSet;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        numOfJumps = 0;
    
        if (Input.GetKey(KeyCode.Alpha1) && istouching)
        {
                float z = startoflvl1.transform.position.z;
            float y = startoflvl1.transform.position.y + 5;
            float x = startoflvl1.transform.position.x;
            Vector3 v = new Vector3(x, y, z);
            K.transform.position = v;
            istouching = false;
        }
    }
}
