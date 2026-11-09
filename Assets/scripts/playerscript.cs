using Unity.VisualScripting;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public int playerSpeed = 3;
    public GameObject lasershot;
    public int playerHealth = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(0, -4);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }
        if (transform.position.x > 10)
        {
            transform.position = new Vector2(-10, -4);
        }
        if (transform.position.x < -10)
        {
            transform.position = new Vector2(10, -4);
        }
        //Debug.Log(transform.position);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
        Instantiate(lasershot, transform.position, Quaternion.identity);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.name == "enemy")
        {
            playerHealth = playerHealth - 1;
        }
        if (playerHealth == 0)
        {
           Destroy(gameObject);
        }
    }

}
