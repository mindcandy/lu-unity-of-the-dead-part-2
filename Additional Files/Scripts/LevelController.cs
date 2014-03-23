using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public string[] levelNames;
	public int currentLevel = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		LoadNextLevel();
	}

	public void LoadNextLevel()
	{
		if(currentLevel < levelNames.Length)
		{
			Application.LoadLevel(levelNames[currentLevel]);
			currentLevel++;
		}
	}
}
