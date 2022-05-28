// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""7d58e3f7-682e-4e62-b189-630597c45a0b"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Value"",
                    ""id"": ""2bdb080e-73ea-4d5c-a94a-baa8b561d37b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""40033e90-02ff-44e5-957a-e4b11297f043"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tail"",
                    ""type"": ""Button"",
                    ""id"": ""79530d93-d9a8-49ec-a307-999c6230713c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Value"",
                    ""id"": ""6e8a1b24-46b8-485a-ba14-adae1631bb1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e7bd2539-e657-4b23-941c-91aaf6750b2a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03a71fe2-c428-4733-8e79-fa606ae5a6d9"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""154291e4-c6cb-4e6b-86aa-cd06a7c9aa56"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tail"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e64008f-1f8d-4b28-9568-007cb72463b9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Forward = m_GamePlay.FindAction("Forward", throwIfNotFound: true);
        m_GamePlay_Rotate = m_GamePlay.FindAction("Rotate", throwIfNotFound: true);
        m_GamePlay_Tail = m_GamePlay.FindAction("Tail", throwIfNotFound: true);
        m_GamePlay_Break = m_GamePlay.FindAction("Break", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Forward;
    private readonly InputAction m_GamePlay_Rotate;
    private readonly InputAction m_GamePlay_Tail;
    private readonly InputAction m_GamePlay_Break;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_GamePlay_Forward;
        public InputAction @Rotate => m_Wrapper.m_GamePlay_Rotate;
        public InputAction @Tail => m_Wrapper.m_GamePlay_Tail;
        public InputAction @Break => m_Wrapper.m_GamePlay_Break;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForward;
                @Rotate.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRotate;
                @Tail.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTail;
                @Tail.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTail;
                @Tail.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnTail;
                @Break.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBreak;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Tail.started += instance.OnTail;
                @Tail.performed += instance.OnTail;
                @Tail.canceled += instance.OnTail;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnTail(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
    }
}
