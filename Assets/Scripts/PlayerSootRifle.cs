using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSootRifle : MonoBehaviour {
    public GameObject bulletPre;
    bool beingWait = false;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X))
        {
            if (!beingWait)
            {
                StartCoroutine(Shot());
            }
        }
    }
    IEnumerator Shot()
    {
        beingWait = true;
        Instantiate(bulletPre, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        beingWait = false;
    }
}
