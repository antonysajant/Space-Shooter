using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalAxis;
    private float verticalAxis;
    [SerializeField] private float speed = 5f;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");


        transform.Translate(new Vector3(1 * horizontalAxis, 1 * verticalAxis, 0) * speed * Time.deltaTime);
    }
}
