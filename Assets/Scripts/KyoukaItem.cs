using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KyoukaItem : MonoBehaviour {
    public Text textExpS;
    public Text textExpT;
    public Text textExpD;
    public Text HpU;
    public Text PoU;
    public Text SpU;
    int ka1 = 0;
    int ka2 = 0;
    int ka3 = 0;
    int ka4 = 0;
    int ka5 = 0;
    int ka6 = 0;

    List<string> soukoList = new List<string>();
    ItemDeta[] itemd = new ItemDeta[6];
    int count = 0;
    private void OnEnable()
    {
        soukoList = GachaTes1.LoadList<string>("ListSaveKey2");
        for (int i = 0; i < itemd.Length; i++)
        {
            itemd[i] = Resources.Load<ItemDeta>("Item/KyokaItem/" + (i + 1).ToString());
            Debug.Log(itemd[i]);
        }
        for (int i = 0; i < soukoList.Count; i++)
        {
            for (int j = 0; j < itemd.Length; j++)
            {
                if (itemd[j].name == soukoList[i])
                {
                    if (itemd[j].name == "EXPsyo")
                    {
                        ka1++;
                    }
                    if (itemd[j].name == "EXPtyu")
                    {
                        ka2++;
                    }
                    if (itemd[j].name == "EXPdai")
                    {
                        ka3++;
                    }
                    if (itemd[j].name == "HPUP")
                    {
                        ka4++;
                    }
                    if (itemd[j].name == "PowerUP")
                    {
                        ka5++;
                    }
                    if (itemd[j].name == "SpeedUP")
                    {
                        ka6++;
                    }
                    count++;
                }
            }
        }
        textExpS.text = "x " + ka1;
        textExpT.text = "x " + ka2;
        textExpD.text = "x " + ka3;
        HpU.text = "x " + ka4;
        PoU.text = "x " + ka5;
        SpU.text = "x " + ka6;
        Debug.Log(count);
    }
    private void OnDisable()
    {
        ka1 = 0;
        ka2 = 0;
        ka3 = 0;
        ka4 = 0;
        ka5 = 0;
        ka6 = 0;
        count = 0;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
