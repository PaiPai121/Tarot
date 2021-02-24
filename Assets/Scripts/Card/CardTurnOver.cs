using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum CardState{
    Front,
    Back
}

public class CardTurnOver : MonoBehaviour
{
    public GameObject mFront; // 卡牌正面
    public GameObject mBack; // 卡片背面
    public CardState mCardState = CardState.Front; // 卡牌当前的状态，是正面还是背面?
    public float mTime = 0.3f;
    private bool isActive = false; //true代表正在翻转中

    /// <summary>
    /// 初始化卡牌角度，根据mCardState
    /// </summary>
    public void Init()
    {
        if(mCardState == CardState.Front){
            // 欧拉角为0和90
            mFront.transform.eulerAngles = Vector3.zero;
            mBack.transform.eulerAngles = new Vector3(0,90,0);
        }
        else{
            mBack.transform.eulerAngles = Vector3.zero;
            mFront.transform.eulerAngles = new Vector3(0,90,0);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    /// <summary>
    /// 调用接口，转向背面
    /// </summary>
    public void StartBack(){
        if(isActive){
            return;
        }
        StartCoroutine(ToBack());  // 来自DoTween
    }

    /// <summary>
    /// 调用接口，转向正面
    /// </summary>
    public void StartFront(){
        if(isActive){
            return;
        }
        StartCoroutine(ToFront());  // 来自DoTween
    }

    /// <summary>
    ///  IEnumerator 是枚举器，使得类能够被迭代。(I应该是InterFace，接口)   yield：在 return 时，保存当前函数的状态，下次调用时继续从当前位置处理。
    /// </summary>
    /// <returns></returns>
    IEnumerator ToBack(){
        isActive = true;
        mFront.transform.DORotate(new Vector3(0,90,0),mTime);
        for(float i = mTime;i >= 0;i -= Time.deltaTime){
            yield return 0;
        }
        mBack.transform.DORotate(new Vector3(0,0,0),mTime);
        isActive = false;
    }

    IEnumerator ToFront(){
        isActive = true;
        mBack.transform.DORotate(new Vector3(0,90,0),mTime);
        for(float i = mTime;i >= 0;i -= Time.deltaTime){
            yield return 0;
        }
        mFront.transform.DORotate(new Vector3(0,0,0),mTime);
        isActive = false;
    }
}
