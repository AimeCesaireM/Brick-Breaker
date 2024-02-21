using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D Rigidbody {  get; private set; }
    public Vector2 Direction { get; private set; }

    public float speed = 30f;


    private void Awake()
    {
        this.Rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.Direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
             this.Direction = Vector2.right;
        }
        else
        {
            this.Direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.Direction != Vector2.zero)
        {
            this.Rigidbody.AddForce(this.Direction * this.speed);

        }
    }
}

