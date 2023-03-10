using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject iguanaPrefab;
    private GameObject[] iguanas;
    private int numIguanas = 5;
    private Vector3 spawnPointIguana = new Vector3(9.74f, 0, -4.54f);
    //private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);
    private int numEnemiesToSpawn = 5;
    private GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = new GameObject[numEnemiesToSpawn];
        iguanas = new GameObject[numIguanas];
        for (int i = 0; i < iguanas.Length; i++) {
            if (iguanas[i] == null) {
                iguanas[i] = Instantiate(iguanaPrefab) as GameObject;
                iguanas[i].transform.position = spawnPointIguana;
                float angle = Random.Range(0, 360);
                iguanas[i].transform.Rotate(0, angle, 0);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < enemies.Length; i++) {
            if (enemies[i] == null)
            {
                enemies[i] = Instantiate(enemyPrefab) as GameObject;
                enemies[i].transform.position = spawnPoint;
                float angle = Random.Range(0, 360);
                enemies[i].transform.Rotate(0, angle, 0);
            }
        }
        //if (enemy == null)
        //{
        //    enemy = Instantiate(enemyPrefab) as GameObject;
        //    enemy.transform.position = spawnPoint;
        //    float angle = Random.Range(0, 360);
        //    enemy.transform.Rotate(0, angle, 0);
        //}
    }
}
