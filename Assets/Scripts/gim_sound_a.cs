using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class gim_sound_a : MonoBehaviour
{
    [Tooltip("Trigger に入っている時の BGM")]
    public AudioClip m_bgmIn;
    [Tooltip("Trigger から出ている時の BGM")]
    public AudioClip m_bgmOut;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("侵入した");
            AudioSource a = GetComponent<AudioSource>();
            a.clip = m_bgmIn;
            a.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("出た");
            AudioSource a = GetComponent<AudioSource>();
            a.clip = m_bgmOut;
            a.Play();
        }
    }
}
