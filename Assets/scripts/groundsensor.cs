using UnityEngine;

public class groundsensor : MonoBehaviour
{
    public bool isGrounded;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }
    void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
        if (collision.gameObject.layer == 7)
        {
            //Destroy(collision.gameObject);
            goomba _enemyScript = collision.gameObject.GetComponent<goomba>();
            _enemyScript.GoombaDeath();
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)

        {
            isGrounded = true;
        }
    }
}