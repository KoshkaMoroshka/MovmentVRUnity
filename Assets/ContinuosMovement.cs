using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ContinuosMovement : MonoBehaviour
{
    public float speed = 1;
    public XRNode inputSource;
    public Vector2 inputAxis;
    private CharacterController character;
    private bool movement = false;

    public GameObject rig;

    // Start is called before the first frame update
    private void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
        if (Input.GetButtonDown("XRI_Left_Primary2DAxisClick"))
        {
            SetActive();
        }
    }

    private void FixedUpdate()
    {
        Quaternion headYaw = Quaternion.Euler(0, rig.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        if (movement)
        {
            character.Move(direction * Time.fixedDeltaTime * speed);
        }
    }

    private void SetActive()
    {
        movement = !movement;
    }
}
