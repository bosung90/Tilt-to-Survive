using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public GameObject EnemyPrefab;
	public Camera camera;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateEnemy" ,0f , 3f);
	}

	void GenerateEnemy()
	{
		GameObject newEnemy = Instantiate (EnemyPrefab) as GameObject;
		newEnemy.transform.position = camera.ScreenToWorldPoint (new Vector2(Random.Range (0, camera.pixelWidth), Random.Range (0, camera.pixelHeight)));
	}
	
	// Update is called once per frame
	void Update () {
	}
}
