using UnityEngine;

public class    Movimiento : MonoBehaviour
{
    [SerializeField]private float velocity;
    [SerializeField]private Vector3 movementDirection;

    private Rigidbody rb;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement Imputs
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        movementDirection = new Vector3(movX, movementDirection.y, movZ );

        animator.SetFloat("movZ", movZ);
        animator.SetFloat("movX", movX);
    }
    private void FixedUpdate() //es como el update pero se llama 100 veces por segundo 
    {
        MoverPersonaje();   

    }
    void MoverPersonaje() {

        rb.AddForce(movementDirection * velocity, ForceMode.Acceleration); //añadiria fuerza al PJ
    
    }
}
