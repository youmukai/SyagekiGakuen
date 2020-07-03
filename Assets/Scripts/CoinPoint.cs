﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoint : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
        GameObject coinGo = (GameObject)Instantiate(
            prefab,
            Vector3.zero,
            Quaternion.identity
            );
        coinGo.transform.SetParent(transform, false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDrawGizmos()
    {
        Vector3 offset = new Vector3(0, 0.5f, 0);
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawSphere(transform.position + offset, 0.7f);
        if (prefab != null)
            Gizmos.DrawIcon(transform.position + offset, prefab.name, true);
    }
}
