using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    { 
    }

    void Update()
    {
        transform.Translate(Vector3.up * 20f * Time.deltaTime);   
    }
}
