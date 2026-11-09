        bodyParts.Add(transform);
        if (Input.GetKeyDown(KeyCode.A) && moveDirection != Vector3.right) moveDirection = Vector3.left;
        {
    
        if (Input.GetKeyDown(KeyCode.W) && moveDirection != Vector3.back) moveDirection = Vector3.forward;
        for (int i = 0; i < bodyParts.Count; i++)
    public Transform bodyPrefab;
    }

        moveTimer += Time.deltaTime;

        Vector3 targetPos = transform.position + moveDirection;
        
            Vector3 temp = bodyParts[i].position;
        if (moveTimer >= 1f / moveSpeed)
    {
        {
    }

    }
    {
        // Classic Snake Logic: Har part apne agle part ki jagah chala jayega
public class SnakeController : MonoBehaviour
    public float moveSpeed = 5f;
    private void Update()
        
        // 3D Grid Movement (WASD)
            MoveSnake();
        }
using System.Collections.Generic;
    private List<Transform> bodyParts = new List<Transform>();
    private void HandleInput()
    private void MoveSnake()
    private void Start()
        currentSkinIndex = GameManager.Instance.selectedSkinIndex;
        if (Input.GetKeyDown(KeyCode.D) && moveDirection != Vector3.left) moveDirection = Vector3.right;
        }
using UnityEngine;
    private Vector3 moveDirection = Vector3.forward;
        HandleInput();
            moveTimer = 0f;

{
        if (Input.GetKeyDown(KeyCode.S) && moveDirection != Vector3.forward) moveDirection = Vector3.back;
        ApplySkin(transform);
    {
    private float moveTimer;
    {

    private int currentSkinIndex;
            bodyParts[i].position = targetPos;
            targetPos = temp;
    }

    public void Grow()
    {
        // Naya body part add karna
        Transform newPart = Instantiate(bodyPrefab, bodyParts[bodyParts.Count - 1].position, Quaternion.identity);
        bodyParts.Add(newPart);
        ApplySkin(newPart);
        GameManager.Instance.AddScore();
    }

    private void ApplySkin(Transform part)
    {
        if (GameManager.Instance.snakeSkins.Length > currentSkinIndex)
        {
            Material skin = GameManager.Instance.snakeSkins[currentSkinIndex];
            part.GetComponent<Renderer>().material = skin;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Grow();
            Destroy(other.gameObject);
            FindObjectOfType<FoodSpawner>().SpawnFood();
        }
        else if (other.CompareTag("Wall") || other.CompareTag("Body"))
        {
            GameManager.Instance.GameOver();
        }
    }
    }
