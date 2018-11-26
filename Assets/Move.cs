using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float m_speed = 5f;
    public Vector3 teleportPoint;
    public Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedY = Input.GetAxis("Horizontal");
        float speedX = Input.GetAxis("Vertical");
        Vector3 moveVec = new Vector3(speedY, 0, speedX);
        rb.MovePosition(this.transform.position + Time.deltaTime * m_speed * moveVec);
    }
}
