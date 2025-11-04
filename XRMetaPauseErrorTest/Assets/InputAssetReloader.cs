using UnityEngine;
using UnityEngine.InputSystem;

public class InputAssetReloader : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActions;

    private void OnEnable()
    {
        if (inputActions == null) return;
        Debug.Log("Enabling input action asset diretly");
        inputActions.Enable();
    }
}
