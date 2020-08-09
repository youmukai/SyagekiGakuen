using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSenTaku : MonoBehaviour {
    public GameObject handgun;
    public GameObject rifle;
    Anima2D.SpriteMesh[] handgunAniMesh;
    Anima2D.SpriteMeshInstance handgunMesh;
    Anima2D.SpriteMesh[] rifleAniMesh;
    Anima2D.SpriteMeshInstance rifleMesh;
    Anima2D.SpriteMesh[] playerItem = new Anima2D.SpriteMesh[5];
    Transform syousaiPanel;
    Transform image;
    Transform bunrui;
    Text bunruiText;
    Image imageN;
    Transform henseiPanel;
    Hensei hensei;

    public void OnClick()
    {
        for(int i = 0; i < playerItem.Length; i++)
        {
            if (playerItem[i].sprite.name == imageN.sprite.name)
            {
                if (int.Parse(bunruiText.text) == 1)
                {
                    handgunMesh.spriteMesh = playerItem[i];
                    handgunAniMesh[0] = playerItem[i];
                }else if(int.Parse(bunruiText.text) == 2)
                {
                    rifleMesh.spriteMesh = playerItem[i];
                    rifleAniMesh[1] = playerItem[i];
                }
                
            }
            //Debug.Log(playerItem[i].sprite.name);
            //Debug.Log(imageN.sprite.name);
        }
        hensei.player.SetActive(true);
    }
	// Use this for initialization
	void Start () {
        handgunMesh = handgun.GetComponent<Anima2D.SpriteMeshInstance>();
        handgunAniMesh = handgun.GetComponent<Anima2D.SpriteMeshAnimation>().frames;
        rifleMesh = rifle.GetComponent<Anima2D.SpriteMeshInstance>();
        rifleAniMesh = rifle.GetComponent<Anima2D.SpriteMeshAnimation>().frames;
        syousaiPanel = transform.root.Find("syousaiPanel");
        image = syousaiPanel.transform.Find("Image");
        imageN = image.GetComponent<Image>();
        bunrui = syousaiPanel.transform.Find("Bunrui");
        bunruiText = bunrui.GetComponent<Text>();
        henseiPanel = transform.root.Find("HenseiPanel");
        hensei = henseiPanel.GetComponent<Hensei>();
        //Debug.Log(handgunAniMesh[0]);
        //Debug.Log(rifleMesh);
        for(int i = 0; i < 5; i++)
        {
            playerItem[i] = Resources.Load<Anima2D.SpriteMesh>("SpriteMesh/PlayerItem/buki sozai" + (i + 1).ToString());
            //Debug.Log(playerItem[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
