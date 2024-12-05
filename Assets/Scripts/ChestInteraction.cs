using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    public Animator chestAnimator;
    public float interactionRange = 3f;
    private Transform player;
    private bool isOpen = false;
    public AudioSource chestAudio;

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
                OpenChest();
            }
        }
    }

    void OpenChest()
    {
        isOpen = true;
        chestAnimator.SetBool("isOpen", true);
    }

    public void PlayChestOpenSound()
    {
        if (chestAudio != null)
        {
            chestAudio.Play();
        }
    }

} 