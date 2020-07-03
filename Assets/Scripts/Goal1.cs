using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerPrefs.SetInt("stage1Clear", 1);
        }
        if (other.CompareTag("Player"))
        {
            Debug.Log("goal1");
            //Time.timeScale = 0f;
            SceneManager.LoadScene("Menu");
            //StartCoroutine("HyoujiGoal");
        }
    }
}
