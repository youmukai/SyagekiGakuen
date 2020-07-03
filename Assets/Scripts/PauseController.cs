using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            pauseUI.SetActive(!pauseUI.activeSelf);
            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
    public void OnClickBack()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OnClickRe()
    {
        SceneManager.LoadScene("Home");
    }
}
