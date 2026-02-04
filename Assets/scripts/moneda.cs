using UnityEngine;

public class moneda : MonoBehaviour
{
    public Animator monedaAnimator;
    public Rigidbody2D rigidbodyMoneda;

    private AudioSource _audioSourceMoneda;
    public AudioClip monedaSonido;


    void Awake()
    {
        monedaAnimator = GetComponent<Animator>();

        rigidbodyMoneda = GetComponent<Rigidbody2D>();

        _audioSourceMoneda = GetComponent<AudioSource>();

    } 


    void OnCollisionEnter2D(Collision2D monedaCollisiom)
     {
       if (monedaCollisiom.gameObject.CompareTag("Player"))
        {
            _audioSourceMoneda.PlayOneShot(monedaSonido);
            Destroy(gameObject, 0.5f);
        } 

    } 
}
