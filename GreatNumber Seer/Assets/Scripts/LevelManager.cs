using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevel(string levelName)
    {
        Debug.Log("Level Load Requested for: " + levelName);
        SceneManager.LoadScene(levelName);
    }

    public void EndGame()
    {
        Debug.Log("Game Finished");
        Application.Quit();
    }
}
