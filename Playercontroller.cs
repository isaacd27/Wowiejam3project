// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Playercontroller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Playercontroller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Playercontroller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Playercontroller"",
    ""maps"": [
        {
            ""name"": ""Keyboard(wasd)"",
            ""id"": ""48c46831-a690-4c4a-b35a-afa9d61345b5"",
            ""actions"": [
                {
                    ""name"": ""Left/right"",
                    ""type"": ""Value"",
                    ""id"": ""fb43bb2b-b467-4d83-b5e9-170bf7fea8b9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up/down"",
                    ""type"": ""Button"",
                    ""id"": ""ea340aff-8e27-47ad-b59b-cb3f9f575206"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3ad5afcc-7496-438c-99b9-04f1202d6b80"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""701f3cc4-5707-4a32-9900-feaeae9116fc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6083593f-f6cd-4744-8343-60593284166c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left/right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c80512b2-6c16-48b0-b062-67f276780409"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""698cd729-ce67-41e8-b614-dc5f952ba779"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c2fe173f-2f8d-463b-963a-360a73d78b9d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b2b8fb79-180a-4dd5-a2a1-c683ac6a6607"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard(wasd)
        m_Keyboardwasd = asset.FindActionMap("Keyboard(wasd)", throwIfNotFound: true);
        m_Keyboardwasd_Leftright = m_Keyboardwasd.FindAction("Left/right", throwIfNotFound: true);
        m_Keyboardwasd_Updown = m_Keyboardwasd.FindAction("Up/down", throwIfNotFound: true);
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

    // Keyboard(wasd)
    private readonly InputActionMap m_Keyboardwasd;
    private IKeyboardwasdActions m_KeyboardwasdActionsCallbackInterface;
    private readonly InputAction m_Keyboardwasd_Leftright;
    private readonly InputAction m_Keyboardwasd_Updown;
    public struct KeyboardwasdActions
    {
        private @Playercontroller m_Wrapper;
        public KeyboardwasdActions(@Playercontroller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Leftright => m_Wrapper.m_Keyboardwasd_Leftright;
        public InputAction @Updown => m_Wrapper.m_Keyboardwasd_Updown;
        public InputActionMap Get() { return m_Wrapper.m_Keyboardwasd; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardwasdActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardwasdActions instance)
        {
            if (m_Wrapper.m_KeyboardwasdActionsCallbackInterface != null)
            {
                @Leftright.started -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnLeftright;
                @Leftright.performed -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnLeftright;
                @Leftright.canceled -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnLeftright;
                @Updown.started -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnUpdown;
                @Updown.performed -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnUpdown;
                @Updown.canceled -= m_Wrapper.m_KeyboardwasdActionsCallbackInterface.OnUpdown;
            }
            m_Wrapper.m_KeyboardwasdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Leftright.started += instance.OnLeftright;
                @Leftright.performed += instance.OnLeftright;
                @Leftright.canceled += instance.OnLeftright;
                @Updown.started += instance.OnUpdown;
                @Updown.performed += instance.OnUpdown;
                @Updown.canceled += instance.OnUpdown;
            }
        }
    }
    public KeyboardwasdActions @Keyboardwasd => new KeyboardwasdActions(this);
    public interface IKeyboardwasdActions
    {
        void OnLeftright(InputAction.CallbackContext context);
        void OnUpdown(InputAction.CallbackContext context);
    }
}
