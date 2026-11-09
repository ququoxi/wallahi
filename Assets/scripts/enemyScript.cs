using Unity.VisualScripting;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int enemyhej = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomPosition = Random.Range(-6, 6);

        transform.position = new Vector2(randomPosition, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * enemyhej * Time.deltaTime);
        {
            if (transform.position.y < -6)
            {
                UpdatePosition();
            }
        }
        
    }
   
    void UpdatePosition ()
    {
        float randomPosition = Random.Range(-6, 6);

        transform.position = new Vector2(randomPosition, 6);
    }
}
