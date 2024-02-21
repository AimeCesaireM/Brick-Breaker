using UnityEngine;

public class Ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody {get; private set;}

    public float speed = 500f;
    public float maxBounceAngle = 75f;

    private void Awake(){
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start(){
        // delay to start ball trajectory
        ResetBall();
    }

    public void ResetBall(){
        this.transform.position = Vector2.zero;
        this.rigidbody.velocity = Vector2.zero;

        //invoke delays the function call by '2nd argument' seconds
        Invoke(nameof(setRandomTrajectory), 1f);
    }

    public void ResetPaddle(){
        this.transform.position = new Vector2(0f, this.transform.position.y);
        this.rigidbody.velocity = Vector2.zero;
    }



    private void setRandomTrajectory (){
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null){
            Vector3 paddlePosition = this.transform.position;
            Vector2 contactPoint = collision.GetContact(0).point;

            float offset = paddlePosition.x - contactPoint.x;
            float width = collision.otherCollider.bounds.size.x / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.up, ball.rigidbody.velocity);
            float bounceAngle = (offset / width) * this.maxBounceAngle;

            float newAngle = Mathf.Clamp(currentAngle + bounceAngle,- this.maxBounceAngle, this.maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);

            ball.rigidbody.velocity = rotation * Vector2.up * ball.rigidbody.velocity.magnitude;
        }
        
    }
}
