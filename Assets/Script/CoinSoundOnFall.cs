using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CoinSoundOnFall : MonoBehaviour
{
    [Tooltip("Tag permukaan yang akan memicu suara jatuh (misal: Floor)")]
    public string groundTag = "Ground";

    [Tooltip("Suara yang diputar saat koin jatuh")]
    public AudioClip fallSound;

    private AudioSource audioSource;
    private bool hasPlayedSound = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Pastikan hanya memainkan suara satu kali
        if (!hasPlayedSound && collision.gameObject.CompareTag(groundTag))
        {
            if (fallSound != null)
            {
                audioSource.PlayOneShot(fallSound);
                hasPlayedSound = true;
            }
        }
    }
}
