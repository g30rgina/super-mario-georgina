using UnityEngine;

public class moneda : MonoBehaviour
{
    public Animator monedaAnimator;
    public Rigidbody2D rigidbodyMoneda;

    private AudioSource _audioSourceMoneda;
    public AudioClip monedaSonido;
    private gamemanager _gamemanager;
    public SpriteRenderer _spriterender

    void Awake()
    {

        //monedaAnimator = GetComponent<Animator>();

        gamemanager = GameObject.Find("game manager").GetComponent<gamemanager>();

        rigidbodyMoneda = GetComponent<Rigidbody2D>();

        _audioSourceMoneda = GetComponent<AudioSource>();

    } 


    void OnCollisionEnter2D(Collision2D monedaCollision)
     {
       if (monedaCollision.gameObject.CompareTag("Player"))
        {
            render sprite enabled = false; 
            _gamemanager.Coins(); 
            _audioSourceMoneda.PlayOneShot(monedaSonido); 
            Destroy(gameObject, 0.5f);
        } 

    } 
}
