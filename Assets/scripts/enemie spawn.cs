using UnityEngine;

public class enemiespawn : MonoBehaviour
{
    public GameObject enemiesPrefab;
    public Transform spawnPosition;




    void SpawnEnemies()
    {
        Instantiate(enemiesPrefab, spawnPosition.position, Quaternion.identity);
    }

    void OntriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SpawnEnemies();
        }  
}
