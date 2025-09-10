using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour
{

    private AudioSource source;
    private Collider2D soundTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();
    }
}
