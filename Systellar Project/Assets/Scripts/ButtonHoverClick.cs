using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoverClick : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip hoverEffect;

    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverEffect);
    }
}
