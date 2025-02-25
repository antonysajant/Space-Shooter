using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 7.5f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -11f)
            transform.position = new Vector3(transform.position.x, 11f, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
            Destroy(gameObject);
    }
}
