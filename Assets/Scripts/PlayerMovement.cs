using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public PlayerData playerData;
    public float speed = 0f;
    public new Rigidbody rigidbody;
    public float horizontal, vertical;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = playerData.speed;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3 (horizontal, 0, vertical);

        MoveCharacter(moveDirection);
    }

    void MoveCharacter(Vector3 direction)
    {
        if (rigidbody != null)
        {
            rigidbody.MovePosition(rigidbody.position + direction * speed * Time.deltaTime);
        }
        else
        {
            rigidbody.MovePosition(rigidbody.position);
        }
    }
}
