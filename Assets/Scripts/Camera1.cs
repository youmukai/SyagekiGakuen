using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour {
    GameObject player;
    bool goalSyu;
    GameObject goal;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x, 0, -10);
        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }
        if (player.transform.position.x > 155)
        {
            if (!goalSyu)
            {
                goalSyu = true;
                goal = GameObject.FindGameObjectWithTag("Goal");
                //Debug.Log("goalsita");
            }
            transform.position = new Vector3(155, 0, -10);
        }
        

        /*if (transform.position.y > 5)
        {
            transform.position = new Vector3(0, 5, -10);
        }*/
        /*if (transform.position.x >= 18)
        {
            transform.position = new Vector3(18, 5, -10);
        }*/
	}
}
