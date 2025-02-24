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


        transform.Translate(new Vector3(horizontalAxis, verticalAxis, 0) * speed * Time.deltaTime);

        if (transform.position.y <= -4.03f)
            transform.position = new Vector3(transform.position.x, -4.03f, transform.position.z);
        else if (transform.position.y >= 0.5f)
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);

        if(transform.position.x <= -9.35f)
            transform.position=new Vector3(9.35f,transform.position.y,transform.position.z);
        else if(transform.position.x >= 9.35f)
            transform.position = new Vector3(-9.35f, transform.position.y, transform.position.z);
    }
}
