using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeleteAllPlayerPrefs {
    [MenuItem("Tools/DeleteAll PlayerPrefs")]
	public static void Execute()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("PlayerPrefs.DeleteAll()");
    }
}
