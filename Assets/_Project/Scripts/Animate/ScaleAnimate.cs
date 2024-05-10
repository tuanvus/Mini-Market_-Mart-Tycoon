using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ScaleAnimate : MonoBehaviour
{
    [SerializeField] float scaleValue = 1.5f;
    [SerializeField] float duration = 1;
    void Start()
    {
        transform.DOScale(new Vector3(scaleValue, scaleValue, scaleValue), duration).SetLoops(-1, LoopType.Yoyo);
    }

  
}
