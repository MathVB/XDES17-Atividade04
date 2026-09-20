using UnityEngine;

public class Municao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float ySpeed;

    Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        _rb.AddForceY(ySpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
   
}
