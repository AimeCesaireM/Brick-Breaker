using UnityEngine;

public class Brick : MonoBehaviour
{
    public SpriteRenderer spriteRenderer {get; private set;}
    public Sprite[] staates;

    public bool unbreakable;

    public int points = 100;
    public int health {get; private set;}

   private void Awake(){
        this.spriteRenderer = GetComponent<SpriteRenderer>();

   }
   private void Start(){
        if (!this.unbreakable){
            this.health = this.staates.Length;
            this.spriteRenderer.sprite = this.staates[this.health - 1];
        }
   }

   private void OnCollisionEnter2D(Collision2D collision){
    if (collision.gameObject.name == "Ball"){
        Hit();
        }
   }

   private void Hit(){
    if (! this.unbreakable){
        -- this.health;

        if (health <= 0){
            this.gameObject.SetActive(false);
        }
        else{
            this.spriteRenderer.sprite = this.staates[this.health - 1];
        }
        //tell the game manager that a brick was hit
        FindObjectOfType<GameManager>().Hit(this);
        
    }
   }
}
