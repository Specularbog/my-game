using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour
{
    public GameObject Knight;
    public GameObject Floor;
    void OnCollisionEnter2D()
    {
        float z = Floor.transform.position.z;
        float y = Floor.transform.position.y + 5;
        float x = Floor.transform.position.x;
        Vector3 v = new Vector3(x, y, z);
        Knight.transform.position = v;
    }
    
}

