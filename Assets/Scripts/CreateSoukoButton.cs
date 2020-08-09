using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateSoukoButton : MonoBehaviour {
    List<string> soukoList = new List<string>();
    public GameObject soukoItemPre;
    private GameObject[] soukoItem;
    ItemDeta[] itemd = new ItemDeta[5];
    private void OnEnable()
    {
        soukoList = GachaTes1.LoadList<string>("ListSaveKey2");
        for(int i = 0; i < 5; i++)
        {
            itemd[i] = Resources.Load<ItemDeta>("Item/" + (i + 1).ToString());
            //Debug.Log(itemd[i]);
        }
        soukoItem = new GameObject[soukoList.Count];
        Debug.Log(soukoItem.Length);
        for(int i = 0; i < soukoList.Count; i++)
        {
            for(int j = 0; j < itemd.Length; j++)
            {
                if (itemd[j].name == soukoList[i])
                {
                    soukoItem[i] = GameObject.Instantiate(soukoItemPre) as GameObject;
                    soukoItem[i].name = "soukoItem" + i;
                    soukoItem[i].transform.SetParent(transform, false);
                    soukoItem[i].transform.GetChild(0).GetComponent<Image>().sprite = itemd[j].ItemGazo;
                }
            }
        }
    }
    private void OnDisable()
    {
        for(var i = 0; i < soukoItem.Length; i++)
        {
            Destroy(soukoItem[i]);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
