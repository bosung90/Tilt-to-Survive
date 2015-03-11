using UnityEngine;
using System.Collections;

public class PowerGenerator : MonoBehaviour {

	public Camera camera;
	public GameObject[] PowerPrefabs;

	public static int PowerOnField = 0;

	// Use this for initialization
	void Start () {
//		camera = GameObject.FindGameObjectWithTag ("MainCamera").camera;
		InvokeRepeating ("GeneratePower" ,0f , 3f);
	}
	
	void GeneratePower()
	{
		if(PowerOnField <4)
		{
//			Camera cam = GameObject.Find("Main Camera").camera;
			GameObject newEnemy = Instantiate (PowerPrefabs[Random.Range(0,PowerPrefabs.Length)]) as GameObject;
			newEnemy.transform.position = camera.ScreenToWorldPoint (new Vector2(Random.Range (0, camera.pixelWidth), Random.Range (0, camera.pixelHeight)));
			PowerOnField ++;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
