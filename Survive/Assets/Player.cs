using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform m_Transform;
    public bool canSwim;
    public bool fishing;
    public bool isGround;

    Animator animator;

    void Start()
    {
        m_Transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isGround)
        {
            animator.SetTrigger("fishing");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
            animator.SetBool("swim", true);
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Water"))
            animator.SetBool("swim", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal")
        {
            m_Transform.position = other.GetComponent<Portal>().m_Position;
            Debug.Log(other.GetComponent<Portal>().m_Position);
        }
    }
}
