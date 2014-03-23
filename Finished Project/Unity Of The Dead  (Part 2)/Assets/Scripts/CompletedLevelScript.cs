using UnityEngine;
using System.Collections;

public class CompletedLevelScript : MonoBehaviour {

	public int timeUntilNextLevelLoads = 120;

	private int _counter = 0;

	
	// Update is called once per frame
	void Update () {
		if(_counter++ > timeUntilNextLevelLoads)
		{
			GotoNextLevel();
		}
	}

	public void GotoNextLevel()
	{
		GameObject.Find("LevelController").GetComponent<LevelController>().LoadNextLevel();
	}
}
