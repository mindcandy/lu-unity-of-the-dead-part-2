using UnityEngine;
using System.Collections;

public class LevelTimer : MonoBehaviour {

	public int timeLimitInSeconds = 60;
	public TextMesh textMesh;

	// Update is called once per frame
	void Update () {
		textMesh.text = Mathf.RoundToInt(timeLimitInSeconds - Time.timeSinceLevelLoad).ToString();
		if(Time.timeSinceLevelLoad > timeLimitInSeconds)
		{
			Application.LoadLevel("CompleteScene");
		}
	}
}
