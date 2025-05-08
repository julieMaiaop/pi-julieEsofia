using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f; // Velocidade de movimento
    [SerializeField] Rigidbody2D rb;       // Referência ao Rigidbody2D

    [SerializeField] Animator anim;


    Vector2 movement; // Vetor de movimento
    private void Start()
    {
        rb.gravityScale = 0;
    }
    void Update()
    {
        // Entrada do teclado (Eixo horizontal e vertical)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movimento aplicado ao Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
