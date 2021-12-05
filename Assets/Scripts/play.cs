using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public AudioClip[] soundsNota;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

     public void button_do() 
    {
        audioSource.PlayOneShot(soundsNota[0]);
        audioSource.Play();
    } 

      public void button_re() 
    {
        audioSource.PlayOneShot(soundsNota[1]);
        audioSource.Play();
    } 

      public void button_mi() 
    {
        audioSource.PlayOneShot(soundsNota[2]);
        audioSource.Play();
    } 

      public void button_fa() 
    {
        audioSource.PlayOneShot(soundsNota[3]);
        audioSource.Play();
    } 

      public void button_sol() 
    {
        audioSource.PlayOneShot(soundsNota[4]);
        audioSource.Play();
    } 
      public void button_la() 
    {
        audioSource.PlayOneShot(soundsNota[5]);
        audioSource.Play();
    } 
      public void button_si() 
    {
        audioSource.PlayOneShot(soundsNota[6]);
        audioSource.Play();
    } 


}
