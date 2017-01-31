using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingMissile : MonoBehaviour {

    public float speed = 5;
    public float rotatingSpeed = 200;

    GameObject target;
    Rigidbody2D rb;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;
        point2Target.Normalize();
        float value = Vector3.Cross(point2Target, transform.right).z;

        rb.angularVelocity = rotatingSpeed * value;
        rb.velocity = transform.right * speed;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "NoMissile")
        {
            if(other.tag == "Player")
                target.GetComponent<PlayerControl>().CalculateDamage(-10);
            Destroy(this.gameObject, 0.02f);
        }
    }
}
