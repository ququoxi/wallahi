using UnityEngine;

public class laserScript : MonoBehaviour
{
    public int laserhej = 6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * laserhej * Time.deltaTime);
        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
