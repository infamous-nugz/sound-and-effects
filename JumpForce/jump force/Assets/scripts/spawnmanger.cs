using UnityEngine;

public class spawnmanger : MonoBehaviour
{
    public GameObject obstaclesprefab;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle ()
    {
        Instantiate(obstaclesprefab, spawnpos, obstaclesprefab.transform.rotation);

    }
}
