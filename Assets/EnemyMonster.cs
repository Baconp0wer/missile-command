using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMonster : MonoBehaviour
{
    private Vector2 target;
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject patlamaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed*Time.deltaTime);
        if(transform.position ==(Vector3)target)
        {
            Instantiate(patlamaPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
