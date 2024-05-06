using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFIJ : MonoBehaviour
{
    public float speed;
    public float damage;
    public GameObject target;
    public GameObject tower;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
            Vector3 velocity = transform.forward * speed;
            rb.velocity = velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            enemyFIJ enemyObj = collision.gameObject.GetComponent<enemyFIJ>();
            enemyObj.damage(damage,tower);
        }
        Destroy(gameObject);
    }
}
