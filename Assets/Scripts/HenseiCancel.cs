using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenseiCancel : MonoBehaviour {
    Transform hen;
    Hensei hensei;
    // Use this for initialization
    void Start () {
        hen = transform.parent;
        hensei = hen.GetComponent<Hensei>();
    }

    public void OnClick()
    {
        hensei.player.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
