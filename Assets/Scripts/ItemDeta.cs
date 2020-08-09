using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create ItemDeta", fileName = "ItemDetaEntity")]
public class ItemDeta : ScriptableObject {
    public new string name;
    public string hyoujiName;
    public int itemNem;
    public Sprite ItemGazo;
    public int revel;
    public string bun;
    public int tikara;
    public float hayasa;
    public int bunrui; // 1:拳銃 2:ライフル
}
