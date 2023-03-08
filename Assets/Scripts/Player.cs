using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player self;

    [SerializeField] Rigidbody2D playerRigidBody;

    [SerializeField] Animator playerAnimator;

    [SerializeField] int moveSpeed;

    public string transitionName;


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
    }
}
