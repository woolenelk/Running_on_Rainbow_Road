// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""c88ecff5-12c3-4544-97b0-c3311697bcee"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""52b4f1a1-9870-4ded-a064-ccb8d7b2eca5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""94a4ae4d-bc0e-41e7-b9ff-ae6a745f46a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AddBlue"",
                    ""type"": ""Button"",
                    ""id"": ""8cf0c159-73ee-425c-8ee0-fe0df9f608b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AddRed"",
                    ""type"": ""Button"",
                    ""id"": ""57bfaa93-e6dc-474f-b680-aaa2bda601ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AddGreen"",
                    ""type"": ""Button"",
                    ""id"": ""d519886a-e465-4ab6-9c7a-acb26332e967"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""bd632645-5142-4ed8-8a73-11cb0ace33a2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d8fc9ab1-1f99-4a1d-b223-9e2cb7a027af"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d61d4308-6cb4-4d65-8e9c-22626f201e54"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1035b884-0559-4d12-836f-5761891e10d9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24296082-4843-462b-9641-ee417f3464c5"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddBlue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""401334f9-bade-4495-b710-3b41af418c35"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddRed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6413af7a-0d0c-4d63-a3c1-ebdc75bf501c"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AddGreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Jump = m_PlayerMovement.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovement_AddBlue = m_PlayerMovement.FindAction("AddBlue", throwIfNotFound: true);
        m_PlayerMovement_AddRed = m_PlayerMovement.FindAction("AddRed", throwIfNotFound: true);
        m_PlayerMovement_AddGreen = m_PlayerMovement.FindAction("AddGreen", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Jump;
    private readonly InputAction m_PlayerMovement_AddBlue;
    private readonly InputAction m_PlayerMovement_AddRed;
    private readonly InputAction m_PlayerMovement_AddGreen;
    public struct PlayerMovementActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerMovement_Jump;
        public InputAction @AddBlue => m_Wrapper.m_PlayerMovement_AddBlue;
        public InputAction @AddRed => m_Wrapper.m_PlayerMovement_AddRed;
        public InputAction @AddGreen => m_Wrapper.m_PlayerMovement_AddGreen;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnJump;
                @AddBlue.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddBlue;
                @AddBlue.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddBlue;
                @AddBlue.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddBlue;
                @AddRed.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddRed;
                @AddRed.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddRed;
                @AddRed.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddRed;
                @AddGreen.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddGreen;
                @AddGreen.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddGreen;
                @AddGreen.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnAddGreen;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @AddBlue.started += instance.OnAddBlue;
                @AddBlue.performed += instance.OnAddBlue;
                @AddBlue.canceled += instance.OnAddBlue;
                @AddRed.started += instance.OnAddRed;
                @AddRed.performed += instance.OnAddRed;
                @AddRed.canceled += instance.OnAddRed;
                @AddGreen.started += instance.OnAddGreen;
                @AddGreen.performed += instance.OnAddGreen;
                @AddGreen.canceled += instance.OnAddGreen;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAddBlue(InputAction.CallbackContext context);
        void OnAddRed(InputAction.CallbackContext context);
        void OnAddGreen(InputAction.CallbackContext context);
    }
}
