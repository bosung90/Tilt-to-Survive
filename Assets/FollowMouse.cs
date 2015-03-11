using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {
	[Range(0,5)]
	public float ShortDistSpeed;
	[Range(1,2)]
	public float LongDistPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 curPos = transform.position;

		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;

		//move toward mouse pos;
		float mouseDist = new Vector2 (mousePos.x - curPos.x, mousePos.y - curPos.y).magnitude;

		if(mouseDist <=1)
			transform.position = Vector2.MoveTowards(curPos, mousePos, ShortDistSpeed * Time.deltaTime);
		else 
			transform.position = Vector2.MoveTowards(curPos, mousePos, Mathf.Pow(mouseDist,LongDistPower) * ShortDistSpeed * Time.deltaTime);
	}
}
