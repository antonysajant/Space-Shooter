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


}
