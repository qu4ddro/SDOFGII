using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public GameObject Enemy1;
	public int Enemy1Count = 15;
	public int Enemy1OriginBegin = 0;
	public int Enemy1OriginWidth = 45;

	public GameObject Enemy2;
	public int Enemy2Count = 20;
	public int Enemy2OriginBegin = 90;
	public int Enemy2OriginWidth = 180;

	public GameObject Enemy3;
	public int Enemy3Count = 5;
	public int Enemy3OriginBegin = 180;
	public int Enemy3OriginWidth = 45;

	public GameObject Boundary;
	public GameObject Player;
	float distance;


	/// <summary>
	/// Awake this instance.
	/// </summary>
	void Awake()
	{
		distance = Boundary.GetComponent<SphereCollider>().radius;
	}

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Enemy1Count; i++) {
			SpawnEnemy(Enemy1, Enemy1Count, Enemy1OriginBegin,Enemy1OriginWidth);
		}
		for (int i = 0; i < Enemy2Count; i++) {
			SpawnEnemy(Enemy2, Enemy2Count, Enemy2OriginBegin,Enemy2OriginWidth);
		}
		for (int i = 0; i < Enemy3Count; i++) {
			SpawnEnemy(Enemy3, Enemy3Count, Enemy3OriginBegin,Enemy3OriginWidth);
		}
	}

	// Update is called once per frame
	void Update () {
//		if (GameObject.FindGameObjectsWithTag ("Enemy").Length < Enemy1Count) {
//			SpawnEnemy (Enemy1, Enemy1Count,0, 90);
//		}
	}
	Vector3 spawnPointTemp;
	/// <summary>
	/// Spawns the enemies.
	/// </summary>
	void SpawnEnemy(GameObject enemy, int enemyCount, int offset, int width)
	{
		int i = Random.Range(offset,offset+width);
		spawnPointTemp.x = Mathf.Cos (Mathf.Deg2Rad*i) * (distance);
		spawnPointTemp.z = Mathf.Sin (Mathf.Deg2Rad*i) * (distance);
		Instantiate(enemy, spawnPointTemp , Quaternion.identity);
	}
}
