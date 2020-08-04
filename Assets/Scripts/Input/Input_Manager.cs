// GENERATED AUTOMATICALLY FROM 'Assets/Input_Manager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input_Manager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_Manager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input_Manager"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4763870f-84c4-4c1c-adae-ffa9ea97fe89"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9708ee29-8f26-4100-81d5-30a643e7d4b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0edd4464-e294-48ef-a1db-4d590d6a60ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c659914-2552-4187-ae9e-75d48af3cb9b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5ab054d5-d55c-423b-ab2f-feb2590c86df"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""55214107-c89a-4288-9061-c4360f381a99"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""5d899753-c8a2-4654-a7bb-00646983658a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""47c5d121-a48b-497b-87a1-9a598358379f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Store"",
            ""id"": ""3d184010-b6f7-4143-8784-fc1cb2cc9c5f"",
            ""actions"": [
                {
                    ""name"": ""ChangeSelection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""25e3cc0f-14fc-4121-b86c-94a6b71b4059"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da9afcc8-21b5-4342-a4c7-ff60128bb8e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60ea0927-838a-48c8-8c96-54e80ed5a9e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9c577ff8-6ab8-4be8-b13e-93a01177687a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7044a9fc-d625-44cd-a5d6-b7b58547058a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""60347060-9e4e-4c2c-9307-ac2d9637331e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""1b73cbe6-913e-498e-b3e7-c29197aafa26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""02546069-7c61-47a0-9d1f-909c06731fd5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        // Store
        m_Store = asset.FindActionMap("Store", throwIfNotFound: true);
        m_Store_ChangeSelection = m_Store.FindAction("ChangeSelection", throwIfNotFound: true);
        m_Store_Confirm = m_Store.FindAction("Confirm", throwIfNotFound: true);
        m_Store_Cancel = m_Store.FindAction("Cancel", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interact;
    public struct PlayerActions
    {
        private @Input_Manager m_Wrapper;
        public PlayerActions(@Input_Manager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Store
    private readonly InputActionMap m_Store;
    private IStoreActions m_StoreActionsCallbackInterface;
    private readonly InputAction m_Store_ChangeSelection;
    private readonly InputAction m_Store_Confirm;
    private readonly InputAction m_Store_Cancel;
    public struct StoreActions
    {
        private @Input_Manager m_Wrapper;
        public StoreActions(@Input_Manager wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeSelection => m_Wrapper.m_Store_ChangeSelection;
        public InputAction @Confirm => m_Wrapper.m_Store_Confirm;
        public InputAction @Cancel => m_Wrapper.m_Store_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Store; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StoreActions set) { return set.Get(); }
        public void SetCallbacks(IStoreActions instance)
        {
            if (m_Wrapper.m_StoreActionsCallbackInterface != null)
            {
                @ChangeSelection.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnChangeSelection;
                @ChangeSelection.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnChangeSelection;
                @ChangeSelection.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnChangeSelection;
                @Confirm.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_StoreActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeSelection.started += instance.OnChangeSelection;
                @ChangeSelection.performed += instance.OnChangeSelection;
                @ChangeSelection.canceled += instance.OnChangeSelection;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public StoreActions @Store => new StoreActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IStoreActions
    {
        void OnChangeSelection(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
