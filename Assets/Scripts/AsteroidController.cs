using System;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private GameObject explosionVsx;

    [SerializeField]AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
            _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        _rb.AddForceY(-4,ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Shredder")) {
            GameObject explosionVsxClone = Instantiate(explosionVsx, transform.position, Quaternion.identity);
            Destroy(explosionVsxClone, 1f);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    
}
