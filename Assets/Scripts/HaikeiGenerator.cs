using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaikeiGenerator : MonoBehaviour {
    int StageTipSize = 23;
    int currentTipIndex;
    public Transform character;
    public GameObject[] stageTips;
    public int startTipIndex;
    public int preInstantiate;
    public List<GameObject> generatedStageList = new List<GameObject>();
    // Use this for initialization
    void Start () {
        currentTipIndex = startTipIndex - 1;
        UpdateStage(preInstantiate);
    }
	
	// Update is called once per frame
	void Update () {
        /*if (character != null)
        {*/
            int charaPositionIndex = (int)(character.position.x / StageTipSize);
            if (charaPositionIndex + preInstantiate > currentTipIndex)
            {
                UpdateStage(charaPositionIndex + preInstantiate);
            }
        /*}*/
        
    }

    void UpdateStage(int toTipIndex)
    {
        if (toTipIndex <= currentTipIndex) return;
        for (int i = currentTipIndex + 1; i <= toTipIndex; i++)
        {
            GameObject stageObject = GenerateStage(i);
            generatedStageList.Add(stageObject);
        }
        while (generatedStageList.Count > preInstantiate + 2) DestroyOldestStage();
        currentTipIndex = toTipIndex;
    }
    GameObject GenerateStage(int tipIndex)
    {
        int nextStageTip = Random.Range(0, stageTips.Length);
        GameObject stageObject = (GameObject)Instantiate(
            stageTips[nextStageTip],
            new Vector3(tipIndex * StageTipSize, 1, 0),
            Quaternion.identity
            );
        return stageObject;
    }

    void DestroyOldestStage()
    {
        GameObject oldStage = generatedStageList[0];
        generatedStageList.RemoveAt(0);
        Destroy(oldStage);
    }
}
