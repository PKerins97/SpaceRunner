using TMPro;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class SpaceRunner : MonoBehaviour
{
    public float speed = 5f; // Speed of the spaceship
    public float obstacleSpawnInterval = 2f; // Interval between obstacle spawns
    public float spawnAheadDistance = 15f; // Distance ahead of the player to spawn obstacles
    public float obstacleSpeed = 4f; // Speed at which obstacles move towards the player
    public float spawnAreaWidth = 10f;// Depth of the area where obstacles can spawn
    public GameObject obstaclePrefab; // Prefab for obstacles
    public Transform player; // Point where obstacles spawn
    public GameManager gameManager; // Reference to the GameManager script
    public TMP_Text scoreText; // UI text for displaying score
    public TMP_Text coinsText; // UI text for displaying coins
    private int score = 0; // Player's score
    private int coins = 0; // Player's coins
    private bool isGameOver = false;
    private Vector3 obstacleSpawnPosition;
    private Vector3 spawnAreaDepth;

    void Start()
    {
        // Start spawning obstacles
        InvokeRepeating("SpawnObstacle", obstacleSpawnInterval, obstacleSpawnInterval);
    }


    void Update()
    {
        if (!isGameOver)
        {
            // Move the spaceship forward
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            // Check for player input (swipe left/right)
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                MoveRight();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                MoveUp();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveDown();
            }
            // Update the spawn position ahead of the player
            obstacleSpawnPosition = player.position + player.forward * spawnAheadDistance;

        }

    }

    void MoveLeft()
    {
        // Move the spaceship to the left
        transform.Translate(Vector3.left);
        transform.Rotate(Vector3.forward, Mathf.Lerp(0,-90,0));
    }

    void MoveRight()
    {
        // Move the spaceship to the right
        transform.Translate(Vector3.right);
        transform.Rotate(Vector3.forward, Mathf.Lerp(0, 90, 0));
    }
    void MoveUp()
    {
        // Move the spaceship to the up
        transform.Translate(Vector3.up);
    }

    void MoveDown()
    {
        // Move the spaceship to the down
        transform.Translate(Vector3.down);
    }
    void SpawnObstacle()
    {
        // Calculate the spawn position ahead of the player
        Vector3 spawnPosition = player.position + Vector3.forward * spawnAheadDistance;
        spawnPosition.x += Random.Range(-spawnAreaWidth / 2f, spawnAreaWidth / 2f);
        spawnPosition.y = 0f; // Ensure the spawn position is at ground level

        // Spawn the obstacle
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

        // Move the obstacle towards the player
        Vector3 moveDirection = (player.position - spawnPosition).normalized;
        obstacle.GetComponent<Rigidbody>().velocity = moveDirection * obstacleSpeed;

        // Destroy the obstacle after a set time
        Destroy(obstacle, 10f);

    }

    // Method to handle collisions with obstacles
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("game over");
            isGameOver = true;

            gameManager.GameOver();

        }
    }

    // Method to handle scoring
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ScoreTrigger"))
        {
            // Increase score when passing a score trigger
            score++;
            // Update UI
            UpdateUI();
        }
    }

    // Method to update UI elements
    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        coinsText.text = "Coins: " + coins;
    }

    // Method to add coins to the player's total
    public void AddCoins(int amount)
    {
        coins += amount;
        // Update UI
        UpdateUI();
    }
}
