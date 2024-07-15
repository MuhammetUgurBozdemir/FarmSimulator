//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Game/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""OnMove"",
            ""id"": ""26855518-463c-4616-9004-d603310ba6d5"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""feda9083-63d9-46c9-8ac1-2e8afbe10941"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""7ce2267e-6938-4752-a07d-ecbfadc13f84"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bd21d41e-c017-41f5-9ae7-c44bdef854c3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ecf391c6-7c97-4ee2-a945-3b60c3515c13"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3060daf9-895c-48f1-a511-2702d8c5a08d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""81f6e48f-6316-4b3d-994a-9e0dfaf59f29"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9b2c7300-37fa-47c8-a3d2-c2aa325420f0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a869f7eb-3a5d-4f41-be85-72571e8acafb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b7038a9-e2c2-4ee3-a8b8-707123235b07"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Jump"",
            ""id"": ""54499d49-9513-49e5-844e-eb3ac8bbce74"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""88513200-0b33-4847-9818-b7b48d5dbdb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66ee4dfb-6f13-4db5-bfbb-4ad70825c5ec"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Click"",
            ""id"": ""9bad0ab2-ad47-4a1c-8fd6-8d59c8f880e4"",
            ""actions"": [
                {
                    ""name"": ""Clicked"",
                    ""type"": ""Button"",
                    ""id"": ""be42833d-2705-454f-9577-64fe1f583ad8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1fac1e3-e40c-47d7-aabd-df35d73b687d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clicked"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnMove
        m_OnMove = asset.FindActionMap("OnMove", throwIfNotFound: true);
        m_OnMove_WASD = m_OnMove.FindAction("WASD", throwIfNotFound: true);
        m_OnMove_Look = m_OnMove.FindAction("Look", throwIfNotFound: true);
        // Jump
        m_Jump = asset.FindActionMap("Jump", throwIfNotFound: true);
        m_Jump_Newaction = m_Jump.FindAction("New action", throwIfNotFound: true);
        // Click
        m_Click = asset.FindActionMap("Click", throwIfNotFound: true);
        m_Click_Clicked = m_Click.FindAction("Clicked", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // OnMove
    private readonly InputActionMap m_OnMove;
    private List<IOnMoveActions> m_OnMoveActionsCallbackInterfaces = new List<IOnMoveActions>();
    private readonly InputAction m_OnMove_WASD;
    private readonly InputAction m_OnMove_Look;
    public struct OnMoveActions
    {
        private @PlayerInput m_Wrapper;
        public OnMoveActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_OnMove_WASD;
        public InputAction @Look => m_Wrapper.m_OnMove_Look;
        public InputActionMap Get() { return m_Wrapper.m_OnMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnMoveActions set) { return set.Get(); }
        public void AddCallbacks(IOnMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_OnMoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnMoveActionsCallbackInterfaces.Add(instance);
            @WASD.started += instance.OnWASD;
            @WASD.performed += instance.OnWASD;
            @WASD.canceled += instance.OnWASD;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
        }

        private void UnregisterCallbacks(IOnMoveActions instance)
        {
            @WASD.started -= instance.OnWASD;
            @WASD.performed -= instance.OnWASD;
            @WASD.canceled -= instance.OnWASD;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
        }

        public void RemoveCallbacks(IOnMoveActions instance)
        {
            if (m_Wrapper.m_OnMoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_OnMoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnMoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnMoveActions @OnMove => new OnMoveActions(this);

    // Jump
    private readonly InputActionMap m_Jump;
    private List<IJumpActions> m_JumpActionsCallbackInterfaces = new List<IJumpActions>();
    private readonly InputAction m_Jump_Newaction;
    public struct JumpActions
    {
        private @PlayerInput m_Wrapper;
        public JumpActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Jump_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Jump; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JumpActions set) { return set.Get(); }
        public void AddCallbacks(IJumpActions instance)
        {
            if (instance == null || m_Wrapper.m_JumpActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_JumpActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IJumpActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IJumpActions instance)
        {
            if (m_Wrapper.m_JumpActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IJumpActions instance)
        {
            foreach (var item in m_Wrapper.m_JumpActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_JumpActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public JumpActions @Jump => new JumpActions(this);

    // Click
    private readonly InputActionMap m_Click;
    private List<IClickActions> m_ClickActionsCallbackInterfaces = new List<IClickActions>();
    private readonly InputAction m_Click_Clicked;
    public struct ClickActions
    {
        private @PlayerInput m_Wrapper;
        public ClickActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Clicked => m_Wrapper.m_Click_Clicked;
        public InputActionMap Get() { return m_Wrapper.m_Click; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ClickActions set) { return set.Get(); }
        public void AddCallbacks(IClickActions instance)
        {
            if (instance == null || m_Wrapper.m_ClickActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ClickActionsCallbackInterfaces.Add(instance);
            @Clicked.started += instance.OnClicked;
            @Clicked.performed += instance.OnClicked;
            @Clicked.canceled += instance.OnClicked;
        }

        private void UnregisterCallbacks(IClickActions instance)
        {
            @Clicked.started -= instance.OnClicked;
            @Clicked.performed -= instance.OnClicked;
            @Clicked.canceled -= instance.OnClicked;
        }

        public void RemoveCallbacks(IClickActions instance)
        {
            if (m_Wrapper.m_ClickActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IClickActions instance)
        {
            foreach (var item in m_Wrapper.m_ClickActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ClickActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ClickActions @Click => new ClickActions(this);
    public interface IOnMoveActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IJumpActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IClickActions
    {
        void OnClicked(InputAction.CallbackContext context);
    }
}
