//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""ad3be44c-e367-486f-8b73-d905eb258988"",
            ""actions"": [
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""4e3bda9e-0863-4560-9d58-3ec72f0ac37e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""c91087cb-b0c2-4cff-b1ad-10b2599cace2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""9ab6e64c-5459-4dd6-b4a6-6409eb10a339"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""b395bbd3-500d-4062-bd08-b9ea817c3cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""ed688f2b-93bb-4ddb-8297-2587cf54baea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""38f20a35-7c29-44ec-93a4-2571c1f74c9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4af671d8-cd7a-46b5-a517-61220d268d95"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc2874ba-c580-4e76-a7ad-d3fd3b2b957e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""734f1fb4-af5e-4c2f-bcd4-dcbd8e85f7b1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f0290dd-84ca-4594-92e5-e6a570d18f99"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc652d4d-592e-4c49-8623-8afdccd5fe20"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3ba7cdf-7085-4962-a903-c78c2775d7ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5faccf7-9526-4953-90b1-5db9253bac35"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a51b8f1c-712d-4ddb-9609-b9886bb308ad"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51875708-190a-45a8-bd72-4370a54a3f04"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a9f0d23-5b9a-4390-baa3-747d6904e16d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Enter = m_General.FindAction("Enter", throwIfNotFound: true);
        m_General_Up = m_General.FindAction("Up", throwIfNotFound: true);
        m_General_Down = m_General.FindAction("Down", throwIfNotFound: true);
        m_General_Left = m_General.FindAction("Left", throwIfNotFound: true);
        m_General_Right = m_General.FindAction("Right", throwIfNotFound: true);
        m_General_Exit = m_General.FindAction("Exit", throwIfNotFound: true);
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

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_Enter;
    private readonly InputAction m_General_Up;
    private readonly InputAction m_General_Down;
    private readonly InputAction m_General_Left;
    private readonly InputAction m_General_Right;
    private readonly InputAction m_General_Exit;
    public struct GeneralActions
    {
        private @PlayerInput m_Wrapper;
        public GeneralActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Enter => m_Wrapper.m_General_Enter;
        public InputAction @Up => m_Wrapper.m_General_Up;
        public InputAction @Down => m_Wrapper.m_General_Down;
        public InputAction @Left => m_Wrapper.m_General_Left;
        public InputAction @Right => m_Wrapper.m_General_Right;
        public InputAction @Exit => m_Wrapper.m_General_Exit;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @Enter.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnEnter;
                @Up.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnRight;
                @Exit.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);
    public interface IGeneralActions
    {
        void OnEnter(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
}
