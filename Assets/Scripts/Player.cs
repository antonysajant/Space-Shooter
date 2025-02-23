using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalAxis;
    private float verticalAxis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        //transform.Translate(transform.position.x + horizontalAxis, transform.position.y + verticalAxis, transform.position.z);
    }
}
