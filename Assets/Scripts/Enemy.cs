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

        if (transform.position.y <= -5.5f)
            transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 7.5f, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();

            if(player!=null)
            {
                player.damage();
            }
            Destroy(gameObject);
        }
        
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
