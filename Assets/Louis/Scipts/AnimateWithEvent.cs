using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWithEvent : MonoBehaviour
{
    public Animator _anim;
    public GameObject _SwordCol;
    public GameObject DaguerCol;
    public void SetToFalseSword()
    {
        _anim.SetBool("Sword", false);
        _SwordCol.SetActive(false);
    }
    public void SetToFalseDaguer()
    {
        _anim.SetBool("Daguer", false);
        DaguerCol.SetActive(false);
    }
    public void SetToTrueSword()
    {
        _SwordCol.SetActive(true);
    }
    public void SetToTrueDaguer()
    {
        DaguerCol.SetActive(true);
    }
}
