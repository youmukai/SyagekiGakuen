using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Souko1 : MonoBehaviour {
    static List<string> loadList=new List<string>();
    List<string> soukoList = new List<string>();
    string[] array;
    string[] array2;
    List<string> kurabe;
    bool hajime1 = false;
	// Use this for initialization
	void Start () {
        soukoList = GachaTes1.LoadList<string>("ListSaveKey2");
        kurabe = GachaTes1.LoadList<string>("ListSaveKey1");
        array2 = kurabe.ToArray();
        array = loadList.ToArray();
        //Debug.Log(array.Length);
        //Debug.Log(soukoList.Count);
        //for (int k = 0; k < soukoList.Count; k++){ Debug.Log(soukoList[k]); }

        if (array.Length == 0)
        {
            //Debug.Log("true2");
            loadList = GachaTes1.LoadList<string>("ListSaveKey1");
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array2[i] == array[i] && soukoList.Count!=0)
            {
                //Debug.Log("true");
            }
            else
            {
                loadList = GachaTes1.LoadList<string>("ListSaveKey1");
                //Debug.Log(loadList.Count);
                array = loadList.ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    soukoList.Add(array[j]);
                }

                GachaTes1.SaveList<string>("ListSaveKey2", soukoList);
                Debug.Log(soukoList.Count);
                //for (int k = 0; k < soukoList.Count; k++) { Debug.Log(soukoList[k]); }
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
