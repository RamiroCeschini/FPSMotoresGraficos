using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().killCount >= 8)
            {
                SceneManager.LoadScene(3);
            }
        }

        else if (collision.gameObject.CompareTag("Structure"))
        {
         
            Destroy(this.gameObject);
        }
    }
}
