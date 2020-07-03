using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

    AudioSource startButton;

	// Use this for initialization
	void Start () {
        startButton = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStartButtonClicked()
    {
        startButton.Play();
        Invoke("ChangeScene", 1.0f);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("Home");
    }
}
