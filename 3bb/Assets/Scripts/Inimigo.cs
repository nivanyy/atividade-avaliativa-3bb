using UnityEngine;

public class Inimigo : Personagem
{
    
    
    
    [SerializeField] private int dano = 1;

    public float raioDeVisao = 1;
    public CircleCollider2D visaoCollider;
    
    [SerializeField] private Transform posicaoPlayer;
    
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    
    private bool andando = false;

    public void setDano(int dano)
    {
        this.dano = dano;
    }


    public int getDano()
    {
        return this.dano;
    }
    
    
    
    
    
    
    void Start()
    {
    spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
