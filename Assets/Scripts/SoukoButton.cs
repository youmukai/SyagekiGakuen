using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoukoButton : MonoBehaviour {
    Transform syousaiPanel;
    Transform itemImage;
    Transform nameText;
    Transform kogekiText;
    Transform syasokuText;
    Transform setumeiText;
    Transform bunrui;
    Image jisin;
    Image imageItem;
    Text nameTextItem;
    Text kogekiTextItem;
    Text syasokuTextItem;
    Text setumeiTextItem;
    Text bunruiTag;
    ItemDeta[] itemd = new ItemDeta[5];
    Transform background;
    Transform baikyaku;
    breakItem itemBreak;
    Transform baikyakuPanel;

    // Use this for initialization
    void Start () {
        syousaiPanel = transform.root.Find("syousaiPanel"); //　Canvasは一番上にならない
        itemImage = syousaiPanel.transform.Find("Image"); // Debug.Log(itemImage);
        imageItem = itemImage.GetComponent<Image>();
        nameText = syousaiPanel.transform.Find("NameText");
        nameTextItem = nameText.GetComponent<Text>();
        kogekiText = syousaiPanel.transform.Find("KogekiText");
        kogekiTextItem = kogekiText.GetComponent<Text>();
        syasokuText = syousaiPanel.transform.Find("SyasokuText");
        syasokuTextItem = syasokuText.GetComponent<Text>();
        setumeiText = syousaiPanel.transform.Find("SetumeiText");
        setumeiTextItem = setumeiText.GetComponent<Text>();
        bunrui = syousaiPanel.transform.Find("Bunrui");
        bunruiTag = bunrui.GetComponent<Text>();
        jisin = this.gameObject.GetComponent<Image>();
        background = transform.root.Find("Background");
        baikyaku = background.transform.Find("BaikyakuButton");
        itemBreak = baikyaku.GetComponent<breakItem>();
        baikyakuPanel = transform.parent.parent.parent.parent.parent.Find("BaikyakuPanel");


        for (int i = 0; i < 5; i++)
        {
            itemd[i] = Resources.Load<ItemDeta>("Item/" + (i + 1).ToString());
            //Debug.Log(itemd[i].ItemGazo.name);
        }
    }
	
    public void OnClick()
    {
        if (itemBreak.bButton == false)
        {
            syousaiPanel.gameObject.SetActive(true);
            imageItem.sprite = jisin.sprite;
            for (int i = 0; i < itemd.Length; i++)
            {
                if (itemd[i].ItemGazo.name == imageItem.sprite.name)
                {
                    nameTextItem.text = itemd[i].hyoujiName;
                    kogekiTextItem.text = "攻撃: " + itemd[i].tikara;
                    syasokuTextItem.text = "射速: " + itemd[i].hayasa;
                    setumeiTextItem.text = itemd[i].bun;
                    bunruiTag.text = itemd[i].bunrui.ToString();
                }
            }
        }
        else
        {
            baikyakuPanel.gameObject.SetActive(true);
        }
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
