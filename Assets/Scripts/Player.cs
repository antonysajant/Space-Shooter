using Mono.Cecil;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalAxis;
    private float verticalAxis;
    private float nextFire;
    private SpawnManager spawnManager;
    [SerializeField]private int hp = 3;
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireRate = 1f;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        nextFire = fireRate;
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();

        if (spawnManager == null)   //null checking for Spawn Manager script
            Debug.LogError("SpawnManager is null");
    }

    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }
    }

    void movement()
    {
        transform.Translate(new Vector3(horizontalAxis, verticalAxis, 0) * speed * Time.deltaTime);

        if (transform.position.y <= -4.03f)     //restricts y axis movement
            transform.position = new Vector3(transform.position.x, -4.03f, transform.position.z);
        else if (transform.position.y >= 0.5f)
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);

        if (transform.position.x <= -9.35f)     //warps the player about the x axis boundaries
            transform.position = new Vector3(9.35f, transform.position.y, transform.position.z);
        else if (transform.position.x >= 9.35f)
            transform.position = new Vector3(-9.35f, transform.position.y, transform.position.z);
    }

    void fire()
    {
        if (Time.time >= nextFire)  //fires bullet according to fireRate
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.95f, transform.position.z), Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

    public void damage()    //deducts 1hp
    {
        hp--;

        if (hp < 1)
        {
            spawnManager.stopSpawning();
            Destroy(this.gameObject);
        }
    }
}
