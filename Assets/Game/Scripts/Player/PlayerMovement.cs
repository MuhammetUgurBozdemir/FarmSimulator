using Game.Scripts.Popup;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Controllers.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput playerInput;
        private PlayerInput.OnMoveActions onMove;
        [SerializeField] private CharacterController characterController;
        private Vector3 playerVelocity;
        [SerializeField] private float speed = 5;
        [SerializeField] private Animator animator;
        [SerializeField] private Transform body;

        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        private float xRot;
        private float yRot;

        private Camera _mainCamera;
        private PopupController _popupController;

        [Inject]
        private void Construct([Inject(Id = "mainCam")] Camera mainCamera,PopupController popupController)
        {
            _mainCamera = mainCamera;
            _popupController = popupController;
        }

        public void Init()
        {
            _mainCamera.transform.SetParent(transform);
            playerInput = new PlayerInput();
            onMove = playerInput.OnMove;

            onMove.Enable();
        }
        void FixedUpdate()
        {
            ProcessMove(onMove.WASD.ReadValue<Vector2>());

            if (Input.GetKey(KeyCode.C))
            {
                _popupController.PopupRequest("InventoryPopup",new PopupParameters());
            }
        }

        private void LateUpdate()
        {
             ProcessLook(onMove.Look.ReadValue<Vector2>());
        }

        void ProcessMove(Vector2 input)
        {
            Vector3 moveDir = Vector3.zero;

            moveDir.x = input.x;
            moveDir.z = input.y;
            moveDir.y = -9.8f;

            characterController.Move(transform.TransformDirection(moveDir) * speed * Time.deltaTime);

            body.localEulerAngles = new Vector3(0, 0, 0);

            if (input.x > 0 || input.y > 0)
            {
                animator.SetBool(IsRunning , true);
            }
            else
            {
                animator.SetBool(IsRunning,false);
            }
        }

        void ProcessLook(Vector2 input)
        {
            float mouseX = input.x;
            float mouseY = input.y;

            xRot -= (mouseY * Time.deltaTime) * 120;
            
            _mainCamera.transform.localRotation=Quaternion.Euler(xRot,0,0);
            transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * 120);
        }

        public void Dispose()
        {  
            onMove.Disable();
        }
    }
}