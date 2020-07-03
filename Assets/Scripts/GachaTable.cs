using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Create GachaTable",fileName ="GachaTableEntity")]
public class GachaTable : ScriptableObject {
    public new string name;
    public int probability;
    public new List<string> cards;
    public new Sprite sprite1;
    public new GameObject gatyaitem;
    public List<GameObject> gachaItem;
    public List<Sprite> gachaItem2;
}
