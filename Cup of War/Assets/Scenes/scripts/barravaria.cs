using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class barravaria : MonoBehaviour
{

    [SerializeField] private Transform Barra;

    // Start is called before the first frame update
    public void variar()
    {
        transform.DOScaleY(1.562665f, 5).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

}
