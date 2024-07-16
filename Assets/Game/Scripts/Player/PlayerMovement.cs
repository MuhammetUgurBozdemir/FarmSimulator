using System;
using System.Collections;
using DG.Tweening;
using Game.Scripts.Controllers;
using Game.Scripts.Enum;
using Game.Scripts.FarmFields;
using Game.Scripts.Popup;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        private PlayerInput playerInput;
        private PlayerInput.OnMoveActions onMove;
        private PlayerInput.ClickActions onClick;
        private PlayerInput.EscapeActions escapeActions;
        [SerializeField] private CharacterController characterController;
        private Vector3 playerVelocity;
        [SerializeField] private float speed = 5;
        [SerializeField] private Animator animator;
        [SerializeField] private Transform body;
        [SerializeField] private Transform head;
        public Transform toolHolder;
        private Vector3 camOrigin;

        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        private static readonly int IsDigging = Animator.StringToHash("isDigging");

        private bool isAnimation;

        private float xRot;
        private float yRot;

        private Camera _mainCamera;
        private PopupController _popupController;
        private PlayerController _playerController;
        private ScreenController _screenController;

        [Inject]
        private void Construct([Inject(Id = "mainCam")] Camera mainCamera, PopupController popupController,
            PlayerController playerController,
            ScreenController screenController)
        {
            _mainCamera = mainCamera;
            _popupController = popupController;
            _playerController = playerController;
            _screenController = screenController;
        }

        public void Init()
        {
            _mainCamera.transform.SetParent(transform);
            camOrigin = _mainCamera.transform.localPosition;
            playerInput = new PlayerInput();
            onMove = playerInput.OnMove;
            onClick = playerInput.Click;
            escapeActions = playerInput.Escape;

            onClick.Clicked.performed += ctx => ProcessHarvest();
            escapeActions.Escape.performed += ctx => _screenController.ChangeState(ScreenState.MainMenuView);

            onMove.Enable();
            escapeActions.Enable();
            onClick.Enable();
        }

        void FixedUpdate()
        {
            ProcessMove(onMove.WASD.ReadValue<Vector2>());
        }

        private void LateUpdate()
        {
            ProcessLook(onMove.Look.ReadValue<Vector2>());
        }

        void ProcessMove(Vector2 input)
        {
            if (_popupController.isActive || isAnimation) return;

            Vector3 moveDir = Vector3.zero;

            moveDir.x = input.x;
            moveDir.z = input.y;
            moveDir.y = -9.8f;

            characterController.Move(transform.TransformDirection(moveDir) * speed * Time.deltaTime);

            body.localEulerAngles = Vector3.zero;
            body.localPosition = Vector3.zero;

            if (input.x > 0 || input.y > 0)
            {
                animator.SetBool(IsRunning, true);
            }
            else
            {
                animator.SetBool(IsRunning, false);
            }
        }

        void ProcessLook(Vector2 input)
        {
            if (_popupController.isActive) return;

            if (isAnimation)
            {
                return;
            }

            float mouseX = input.x;
            float mouseY = input.y;

            xRot -= (mouseY * Time.deltaTime) * 120;

            _mainCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
            transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * 100);
        }


        void ProcessHarvest()
        {
            RaycastHit hit;

            if (Physics.Raycast(_mainCamera.transform.position, _mainCamera.transform.forward, out hit, 100))
            {
                if (hit.transform.CompareTag($"Plant") &&
                    Vector3.Distance(transform.position, hit.transform.position) < 5)
                {
                    var component = hit.transform.GetComponent<FarmField>();
                    
                    if(component.isProcessing) return;
                    StartCoroutine(AnimDelay(component.Plant));
                }
            }
        }

        IEnumerator AnimDelay(Action action)
        {
            if (_playerController.GetItemData == null) yield break;

            animator.SetBool(_playerController.GetItemData.AnimationKey, true);
            isAnimation = true;

            _mainCamera.transform.SetParent(head);
            _mainCamera.transform.localPosition = Vector3.zero;

            yield return new WaitForSeconds(.1f);

            var state = animator.GetCurrentAnimatorStateInfo(0);

            yield return new WaitForSeconds(state.length);

            animator.SetBool(_playerController.GetItemData.AnimationKey, false);

            _mainCamera.transform.SetParent(transform);
            _mainCamera.transform.DOLocalMove(camOrigin, .3f);
            isAnimation = false;
            action?.Invoke();
        }

        public void Dispose()
        {
            onMove.Disable();
            onClick.Disable();
            escapeActions.Disable();
        }
    }
}