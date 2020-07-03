using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneController : MonoBehaviour {

    AudioSource selectSound;

	// Use this for initialization
	void Start () {
        selectSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnHomeButtonClicked()
    {
        selectSound.Play();
        SceneManager.LoadScene("Home");
    }

    public void OnStage1ButtonClicked()
    {
        selectSound.Play();
        Invoke("ChangeStage", 1.0f);
        //SceneManager.LoadScene("Stage0");
    }
    void ChangeStage()
    {
        SceneManager.LoadScene("Stage0");
    }

}
