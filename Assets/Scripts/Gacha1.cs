using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gacha1 : MonoBehaviour {
    /*[SerializeField] int tes1Incidence;
    [SerializeField] int tes2Incidence;
    [SerializeField] int tes3Incidence;
    string[] tesNames = { "sra", "gobu", "dara" };*/
    private GachaTable[] gachatable = new GachaTable[2];
    private System.Random random;
    int value = 100;
    int maxIndex = 2; // 武器、能力アップ(素早さ・攻撃・回避)
    int countPerPack = 10;
    //SpriteRenderer mainsprite;
    Vector3 itemPos = new Vector3(-6, 2, 0);
    Vector3 itemPos2 = new Vector3(-6, -2, 0);
    int itemSize = 5;
    List<GameObject> generatedItem = new List<GameObject>();

    // Use this for initialization
    void Start () {
        for(int i = 0; i < maxIndex; i++)
        {
            gachatable[i] = Resources.Load<GachaTable>("GachaTable/" + (i + 1).ToString());
        }
        random = new System.Random((int)DateTime.Now.Ticks);
        //mainsprite = gameObject.GetComponent<SpriteRenderer>();
        //packOpen(1000);
        gachaRen(1000);
    }

    // Update is called once per frame
    void Update () {
		
	}

    /*public List<string> packOpen(int money)
    {
        List<string> resultList = new List<string>();
        int totalProbability = 0;
        if (money < value)
        {
            return null;
        }
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability += gachatable[i].probability;
        }
        resultList = new List<string>();
        for(int i = 0; i < countPerPack; i++)
        {
            string card = getCard(totalProbability);
            resultList.Add(card);
        }

        Debug.Log(resultList[0] +","+ resultList[1] + "," + resultList[2] + "," + resultList[3] + "," + resultList[4] +
            "," + resultList[5] + "," + resultList[6] + "," + resultList[7] + "," + resultList[8] + "," + resultList[9] +
            "," + "nyusyu");

        return resultList;
    }*/
    public void gachaRen(int money)
    {
        //List<Sprite> resultList2 = new List<Sprite>();
        int totalProbability2 = 0;
        if (money < value)
        {
            return;
        }
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability2 += gachatable[i].probability;
        }
        //resultList2 = new List<Sprite>();
        for(int i = 0; i < countPerPack; i++)
        {
            //Sprite item = getGazo(totalProbability2);
            GameObject itemObj = getGazo(totalProbability2);
            //resultList2.Add(item);
            generatedItem.Add(itemObj);
        }
    }
    /*private string getCard(int _allProbability)
    {
        int randomValue = getRandom(_allProbability);
        int totalProbability = 0;
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability += gachatable[i].probability;
            if (totalProbability >= randomValue)
            {
                string id = getRandom(gachatable[i].cards); // cards
                return id;
            }
        }
        return null;
    }*/
    private int getRandom(int _max)
    {
        return random.Next(0, _max);
    }
    /*private string getRandom(List<string> _list)
    {
        return _list[random.Next(0, _list.Count)];
    }*/
    private GameObject getRandom2(List<GameObject> list2)
    {
        return list2[random.Next(0, list2.Count)];
    }
    private GameObject getGazo(int allPribability2)
    {
        int randomValue2 = getRandom(allPribability2);
        int totalProbability = 0;
        for(int i = 0; i < maxIndex; i++)
        {
            totalProbability += gachatable[i].probability;
            if (generatedItem.Count <= 4) // 上段アイテム5個
            {
                for (int j = 0; j < itemSize; j++)
                {

                    if (totalProbability >= randomValue2)
                    {
                        GameObject id2 = (GameObject)Instantiate(
                             getRandom2(gachatable[i].gachaItem),
                            itemPos,
                            Quaternion.identity
                            );
                        itemPos.x += 3;
                        return id2;
                    }

                }
            }
            else // 下段アイテム5個
            {
                //itemPos.x = -6;
                //itemPos.y = -2;
                for (int j2 = 0; j2 < itemSize; j2++)
                {

                    if (totalProbability >= randomValue2)
                    {
                        GameObject id2 = (GameObject)Instantiate(
                             getRandom2(gachatable[i].gachaItem),
                            itemPos2,
                            Quaternion.identity
                            );
                        itemPos2.x += 3;
                        return id2;
                    }

                }
            }
            
            /*if (totalProbability >= randomValue2)
            {
                GameObject id2 = (GameObject)Instantiate(
                     getRandom2(gachatable[i].gachaItem),
                    itemPos,
                    Quaternion.identity
                    );
                return id2;
            }*/
        }
        return null;
    }
}
