using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    //public Bullet bullet;
    public GameObject bulletPre;
    bool beingWait = false;
    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
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
        yield return new WaitForSeconds(0.4f);
        beingWait = false;
    }
}
