using Assets.Scripts.UI;
using UnityEngine;
using Valve.VR.Extras;

public class VrMenuHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.TryGetComponent<VRButton>(out VRButton button))
        {
            button.eventCLick.Invoke();
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.TryGetComponent<VRButton>(out VRButton button))
        {
            button.eventInside.Invoke();
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.TryGetComponent<VRButton>(out VRButton button))
        {
            button.eventOutside.Invoke();
        }
    }


}
