using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float m_speed = 5f;
    public Vector3 teleportPoint;
    public Rigidbody rb;
    public float rotateSpeed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotVec = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        Vector3 prevRotVec = this.transform.rotation.eulerAngles;
        Quaternion quaternion = Quaternion.Euler(prevRotVec + Time.deltaTime * rotateSpeed * rotVec);
        rb.MoveRotation(quaternion);

        float speedY = Input.GetAxis("Horizontal");
        float speedX = Input.GetAxis("Vertical");
        Vector3 moveVec = new Vector3(speedY, 0, speedX);
        rb.MovePosition(this.transform.position + quaternion * (Time.deltaTime * m_speed * moveVec));

    }
}
