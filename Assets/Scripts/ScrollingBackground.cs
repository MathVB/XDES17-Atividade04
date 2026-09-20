using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    Material _mat;

    [SerializeField] float velocidade;
    Vector2 _offset;
    float _offsetX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
         _mat = GetComponent<SpriteRenderer>().material;   
    }

    // Update is called once per frame
    void Update()
    {
        _offsetX += velocidade * Time.deltaTime;
        _offset.x = _offsetX;
        _mat.mainTextureOffset = _offset;
    }
}
