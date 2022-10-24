using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
 
 private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Shooted");
            GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().EnemyKilled();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        else if (collision.gameObject.CompareTag("Structure"))
        {
         
            Destroy(this.gameObject);
        }
    }
}
