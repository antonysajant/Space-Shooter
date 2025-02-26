using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * 20f * Time.deltaTime);

        if (transform.position.y > 8)
            Destroy(gameObject);
    }
}
