using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
	public GameObject Player;
    // Start is called b

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		Vector3 POS = Player.transform.position;
		transform.position = new Vector3 (POS.x,POS.y, -10f);
    }
}
