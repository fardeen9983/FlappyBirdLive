using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //Hashcode for Animator triggers
    private static readonly int Flap = Animator.StringToHash("Flap");

    private static readonly int Die = Animator.StringToHash("Die");

    //Reference to Animator component on the bird
    private Animator _anim;

    //Keep track that the bird has hit the ground or not
    private bool _isDead;

    //Reference to RigidBody2D component on the bird
    private Rigidbody2D _rb2D;

    //Force to jump upwards
    public float upForce;

    // Start is called before the first frame update
    private void Start()
    {
        upForce = 200f;
        _isDead = false;
        _rb2D = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //If bird is not dead
        if (!_isDead)
            //If player presses Mouse button 1
            if (Input.GetMouseButtonDown(0))
            {
                //Set velocity to zero.
                //So we can move upwards without interference from the velocity gained while falling down
                _rb2D.velocity = Vector2.zero;
                //Add force in upwards direction
                _rb2D.AddForce(upForce * Vector2.up);
                //Set Flap animation
                _anim.SetTrigger(Flap);
            }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //On collision with everything make the bird go dead
        _isDead = true;
        //Set Die animation
        _anim.SetTrigger(Die);
    }
}