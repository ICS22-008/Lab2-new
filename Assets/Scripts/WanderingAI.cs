using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    private float enemySpeed = 3.0f;
    private float obstacleRange = 5.0f;
    private float sphereRadius = 0.75f;
<<<<<<< Updated upstream
=======
    private EnemyStates state;
    [SerializeField] private GameObject laserbeamPrefab;
    private GameObject laserbeam;
    public float fireRate = 2.0f;
    private float nextFire = 0.0f;

    private float baseSpeed = 0.25f;
    float difficultySpeedDelta = 0.3f; // the change in speed per level of difficult
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Enemy
        transform.Translate(Vector3.forward * enemySpeed * Time.deltaTime);
        // generate Ray
        Ray ray = new Ray(transform.position, transform.forward);
        // Spherecast and determine if Enemy needs to turn
        RaycastHit hit;
        if (Physics.SphereCast(ray, sphereRadius, out hit))
        {
            if (hit.distance < obstacleRange)
            {
            
            float turnAngle = Random.Range(-110, 110);
                transform.Rotate(Vector3.up * turnAngle);
            }
        }
    }
    public void SetDifficulty(int difficulty) {
        Debug.Log("WanderingAI.SetDifficulty(" + difficulty + ")");
        enemySpeed = baseSpeed + (difficulty * difficultySpeedDelta);
    }
}
