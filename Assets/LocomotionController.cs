using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftController;
    public XRController rightController;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreeshold = 0.1f;

    // Update is called once per frame
    private void Update()
    {
        if (leftController)
        {
            leftController.gameObject.SetActive(IsActivation(leftController));
        }
        if (rightController)
        {
            rightController.gameObject.SetActive(IsActivation(rightController));
        }
    }

    public bool IsActivation(XRController xrController)
    {
        InputHelpers.IsPressed(xrController.inputDevice, teleportActivationButton, out bool isActive, activationThreeshold);
        return isActive;
    }
}
