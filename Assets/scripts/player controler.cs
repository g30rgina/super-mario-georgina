using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;

public class playercontroler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 startPosition;

    public float movementSpeed = 5f;
    public float jumpforce = 10; 
    public int direction = 1;

    public Vector3 intialPosition;
    public Vector3 finalPosition;

    private InputAction moveAction;

    private Vector2 moveDirection;

    private Rigidbody2D rBody2D;

    void Awake()
    {
        rBody2D = GetComponent<Rigidbody2D>();
    }

    public
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        transform.position = startPosition;

        moveAction = InputSystem.actions["Move"];

        rBody2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = moveAction.ReadValue<Vector2>();
        //transform.position = new Vector3(transform.position.x + direction * movementSpeed * Time.deltatime, transform.position.y, transform.position.z);

        //transform.Translate(new Vector3(direction * movementSpeed * Time.deltaTime, 0,0));

        //transform.position = Vector2.MoveTowards(transform.position, transform.position + new Vector3(10, 0, 0), movementSpeed * Time.deltaTime);

        //transform.position = Vector2.MoveTowards(transform.position, new Vector2 (transform.position.x + direction, transform.position.y), movementSpeed * Time.deltaTime);


        transform.position = new Vector3(transform.position.x + moveDirection.x * movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);

        //transform.position = new Vector3(transform.position.x * movementSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
