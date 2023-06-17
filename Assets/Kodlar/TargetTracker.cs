using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        FindTarget();
    }

    void FindTarget()
    {
        target = GameObject.FindWithTag("Chest");
    }
    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            FindTarget();
        }
        else
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
            rb.MovePosition(pos);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        target = null;
        Destroy(collision.gameObject);
    }
}
