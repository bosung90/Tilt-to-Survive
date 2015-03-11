using UnityEngine;
using System.Collections;

public class MoveTowardsPlayer : MonoBehaviour {

	[Range(0,5)]
	public float ShortDistSpeed;
	[Range(0,2)]
	public float LongDistPower;

	private GameObject player;

	private Vector2 playerPos;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerPos = player.transform.position;

		InvokeRepeating ("UpdatePlayerPos", 0, 8f);
	}

	void UpdatePlayerPos()
	{
		playerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 curPos = transform.position;
		
		//move toward player pos;
		float playerDist = new Vector2 (playerPos.x - curPos.x, playerPos.y - curPos.y).magnitude;
		
		if(playerDist <=1)
			transform.position = Vector2.MoveTowards(curPos, playerPos, ShortDistSpeed * Time.deltaTime);
		else 
			transform.position = Vector2.MoveTowards(curPos, playerPos, Mathf.Pow(playerDist,LongDistPower) * ShortDistSpeed * Time.deltaTime);

	}
}
