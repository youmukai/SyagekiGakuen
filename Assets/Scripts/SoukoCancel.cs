using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoukoCancel : MonoBehaviour {
    public Canvas canvas;
    Hensei hensei;
    public GameObject baikyakuPanel;

    public void OnClick()
    {
        foreach(Transform child in canvas.transform)
        {
            if (child.name == "HenseiPanel" && child.gameObject.activeSelf)
            {
                hensei = child.GetComponent<Hensei>();
                hensei.player.SetActive(true);
            }
        }
    }
    public void OnbaikyakuClick()
    {
        baikyakuPanel.SetActive(false);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
