using UnityEngine;

public class pControler : MonoBehaviour
{
    
    [SerializeField] float speed = 5.0f;
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3 enemyDir;
    [SerializeField] float playerDotEnemyDir;
     [SerializeField] GameObject playerChild;
    void Start()
    {
        
        // Make it a child of this Player GameObject
        playerChild.transform.parent = this.transform;

        // Set the child's world position using the exact requested calculation:
        // Player's current position + the player's current forward direction vector
        Vector3 targetPosition = this.transform.position + this.transform.forward;
        playerChild.transform.position = targetPosition;

        // Adjust the scale of the child so it's less intrusive
        playerChild.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);



    }

    void Update()
    {
        Movement();
        enemyLocation();
    }

    private void Movement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }

    private void enemyLocation()
    {
        if (enemy == null)
        {
           return;
        }

        Vector3 vectorToEnemy = enemy.transform.position; 

        enemyDir = vectorToEnemy.normalized;

        playerDotEnemyDir = Vector3.Dot(transform.forward, enemyDir);
    }
}