using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorInteraction : MonoBehaviour
{
    public Animator doorAnimator;
    public float interactionRange = 3f;
    private Transform player;
    private bool isOpen = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= interactionRange && !isOpen)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenDoors();
            }
        }
    }

    void OpenDoors()
    {
        isOpen = true;
        doorAnimator.SetBool("isOpen", true);
    }
}