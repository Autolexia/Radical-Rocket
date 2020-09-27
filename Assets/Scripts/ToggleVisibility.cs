using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject ObjectToShow;
    public GameObject ObjectToHide;

    public void ToggleObjectVisibility()
    {
        if (ObjectToHide != null)
        {
            ObjectToShow.SetActive(true);
        }

        if (ObjectToHide != null)
        {
            ObjectToHide.SetActive(false);
        }
    }

    public ToggleVisibility(GameObject objectToShow, GameObject objectTohide)
    {
        ObjectToHide = objectTohide;
        ObjectToShow = objectToShow;
    }
}
