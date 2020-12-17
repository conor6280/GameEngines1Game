using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoostRing : MonoBehaviour
{
    public GameObject BoostRing;

    private void Update()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(650, -650), Random.Range(1, 2), Random.Range(650, -650));
        if (collision.gameObject.tag == "Player")
        {
            spawnBoost();
            Destroy(BoostRing);
            Debug.Log("snvs");
        }
    }

    void OnTriggerEnter(Collider collision)
    {

    }

    public void spawnBoost()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(0, 1300), Random.Range(1, 2), Random.Range(0, 1300));
        Instantiate(BoostRing, spawnPosition, Quaternion.Euler(new Vector3(90,0,0)));
    }
}
