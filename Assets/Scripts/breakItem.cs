using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakItem : MonoBehaviour {
    bool bButon = false;
    public bool bButton { get; set; }
    public void OnClick()
    {
        bButton = true;
    }

    public void OnCancelClick()
    {
        bButton = false;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
