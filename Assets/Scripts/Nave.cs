using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nave : MonoBehaviour
{
    Rigidbody2D _rb;
    
    [SerializeField]float xSpeed;
    [SerializeField] GameObject municaoPrefab;
    [SerializeField] private Slider slider;
    private float damage = 0.2f;
    Transform projetil;
    
    float xDir;

    float taxaDisp = 0.25f;

    float ultimoDisp;
    bool isFiring;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        projetil = transform.Find("Projetil");
    }
    
    private void Update()
    {
        if (isFiring)
        {
            Atirar();
        }
    }

    void FixedUpdate()
    {   
        Movimentar();
    }
    
   
    void Movimentar()
    {
        _rb.linearVelocityX = xDir * xSpeed * Time.deltaTime;
    }

    void Atirar()
    {
        if(Time.time > ultimoDisp+taxaDisp)
        {
            Instantiate(municaoPrefab, projetil.position, Quaternion.identity);
            ultimoDisp = Time.time;
        }
    }
    void OnAttack(InputValue inputValue)
    {
        isFiring = !isFiring;
    }
    void OnMove(InputValue inputValue)
    {
        xDir = inputValue.Get<Vector2>().x;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        slider.value += damage;
        if (slider.value >= slider.maxValue)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
