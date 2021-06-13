using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpController : MonoBehaviour
{
    #region Var
    public Slider slide;
    #endregion

    #region Unity Method
    private void Awake()
    {
        slide = GetComponent<Slider>();

    }

    private void Start()
    {
       
    }
    void Update()
    {
        
    }
    #endregion
}
