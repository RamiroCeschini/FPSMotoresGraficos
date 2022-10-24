using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject bulletPrefab;
    public float bulletForce;
    public Text killCountUI;
    public int killCount;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);
            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
            rb.AddRelativeForce(Vector3.down * bulletForce, ForceMode.Impulse);
        }
    }

    public void EnemyKilled()
    {
        killCount++;
        killCountUI.text = "Kills: " + killCount.ToString();   
    }
}
