using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{

    public static Player self;

    [SerializeField] Rigidbody2D playerRigidBody;

    [SerializeField] Animator playerAnimator;

    [SerializeField] int moveSpeed;

    public string transitionName;

    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;





    // Start is called before the first frame update
    void Start()
    {
        if (self != null && self != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            self = this;
        }

        
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");

        float verticalMovment = Input.GetAxisRaw("Vertical");

        playerRigidBody.velocity = new Vector2(horizontalMovement, verticalMovment) * moveSpeed;

        playerAnimator.SetFloat("movmentX", playerRigidBody.velocity.x);
        playerAnimator.SetFloat("movmentY", playerRigidBody.velocity.y);

        if (horizontalMovement == 1 || horizontalMovement == -1 || verticalMovment == 1 || verticalMovment == -1)
        {
            playerAnimator.SetFloat("lastX", horizontalMovement);
            playerAnimator.SetFloat("lastY", verticalMovment);
        }

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, bottomLeftEdge.x, topRightEdge.x),
            Mathf.Clamp(transform.position.y, bottomLeftEdge.y, topRightEdge.y),
            Mathf.Clamp(transform.position.z, bottomLeftEdge.z, topRightEdge.z)
            );

    }

    public void SetLevelLimit(Vector3 top, Vector3 bottom)
    {
        bottomLeftEdge = bottom;
        topRightEdge = top;
    }
}
