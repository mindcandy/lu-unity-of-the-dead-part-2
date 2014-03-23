using UnityEngine;
using System.Collections;

public class FollowTargetScript : MonoBehaviour {
	public GameObject target;
	public float followSpeed = 0.02f;

	private const int UP = 0;
	private const int RIGHT = 1;
	private const int DOWN = 2;
	private const int LEFT = 3;
	
	// Update is called once per frame
	void Update () {
		if(target)
		{
			transform.position = Vector3.MoveTowards(transform.position,target.transform.position,followSpeed);

			Vector2 distance = transform.position - target.transform.position;
			if(Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
			{
				SetDirection((distance.x > 0) ? LEFT : RIGHT);
			}
			else
			{
				SetDirection((distance.y > 0) ? DOWN : UP);
			}
		}
	}

	void SetDirection(int direction)
	{
		GetComponent<Animator>().SetInteger("Direction",direction);
	}
}
