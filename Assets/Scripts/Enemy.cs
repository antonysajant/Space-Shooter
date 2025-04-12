using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 7.5f;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)      //randomly spawns enemy above camera
            transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 7.5f, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if(player!=null)    //null checking for the presence of Player script
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
