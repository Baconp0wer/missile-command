using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonster : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject explosionPrefab;
    GameObject[] chest;

    

    Vector3 target;

  void Start()
    {
        chest = GameObject.FindGameObjectsWithTag("Chest");
        target = chest[Random.Range(0, chest.Length)].transform.position;
    }

    private void Update()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }


            
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Chest")
        {
            MissileExplode();
            Destroy(col.gameObject);
        }
        else if (col.tag == "Explosion")
        {
            FindObjectOfType<GameController>().AddMissileDestroyedPoints();
            MissileExplode();
            
        }
    }

    private void MissileExplode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
