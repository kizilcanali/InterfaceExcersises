using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float Speed = 10f;
    public int Health = 50;
    public int BulletAmount = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        float moveA = Input.GetAxis("Horizontal");
        float moveB = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(moveA * Speed, 0, moveB * Speed);
    }


    private void OnTriggerEnter(Collider other)
    {
        var Interactable = other.GetComponent<IInteractable>();
        if (Interactable == null) return;

            Interactable.InteractItem();
        
        
            
    }

}
