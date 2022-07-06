using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControlsKey : MonoBehaviour
{
    public GameObject controlsUi; //ui des controls
    public GameObject menuUi; //ui du menu

    public void ControlKey() //si on appuie sur controls alors le panneau des controls s'active et desactive le menu
    {
        controlsUi.SetActive(true);
        menuUi.SetActive(false);
    }

    public void BackButton() //si on appuie sur back le panneau controls se descative et le menu s'active
    {
        controlsUi.SetActive(false);
        menuUi.SetActive(true);
    }
}
