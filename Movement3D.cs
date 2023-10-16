using UnityEngine;


public class Movement3D : MonoBehaviour
{
    [SerializeField]
    public float   moveSpeed = 5.0f;  //이동속도
    [SerializeField]
    public float   jumpForce = 3.0f; //뛰는힘
    public float   gravity = -9.81f;   //중력계수
    private Vector3 moveDirection;  //이동방향

    [SerializeField]
    private Transform           cameraTransform;
    private CharacterController characterController;

    private void Awake() 
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if ( characterController.isGrounded == false)
        {
            moveDirection.y += gravity * Time.deltaTime;
        }

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
    public void MoveTo(Vector3 direction)
        {
            //moveDirection = direction;
            //moveDirection = new Vector3(direction.x, moveDirection.y, direction.z);
            Vector3 movedis = cameraTransform.rotation * direction;
            moveDirection = new Vector3(movedis.x, moveDirection.y, movedis.z);       
        }
    public void JumpTo()
    {
        if (  characterController.isGrounded == true)
        {
            moveDirection.y = jumpForce;
        }
    }
}
