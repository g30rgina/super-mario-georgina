using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class goomba : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    private AudioSource _audioSource;
    private BoxCollider2D _boxCollider;
    private gamemanager _gameManager;

    public AudioClip deathSFX;

    public float movementSpeed = 4;
    public int direction = 1;
    void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _gameManager = GameObject.Find("game manager").GetComponent<gamemanager>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUptade()
    {
        _rigidBody2D.linearVelocity = new Vector2(direction * movementSpeed, _rigidBody2D.linearVelocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tuberias") || collision.gameObject.layer == 7)
        {
            //ESTO HACE LO MISMO QUE LA LINEAS DE ABAJO PERO DE FORMA MAS INTUITIVA
            //direction = direction * -1;
            direction *= -1;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
    public void GoombaDeath()

    {
        _gameManager.Addkill();

        _audioSource.PlayOneShot(deathSFX);

        movementSpeed = 0;

        _boxCollider.enabled = false;

        Destroy(gameObject, 1);
      
        // _audioSource.clip = deathSFX;
        // _audioSource.Play(); 


    }
}
