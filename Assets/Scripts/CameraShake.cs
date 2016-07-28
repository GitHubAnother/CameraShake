/*
作者名称:YHB

脚本作用:震动相机的主要脚本

建立时间:2016.7.28.17.52
*/

using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
    #region 字段
    public static CameraShake _Instance;

    [HideInInspector]
    public bool isShaking = false;//是否开启震动

    private Vector3 initPosition;//记录相机初始位置
    private float delayTime;//延迟时间
    private float distance;//相机震动距离
    #endregion

    #region Unity内置函数
    void Awake()
    {
        _Instance = this;
    }
    void Start()
    {
        initPosition = this.transform.localPosition;
    }
    void Update()
    {
        Shaking();
    }
    #endregion

    #region 单例外调震动(时间，距离)    停止震动   开启震动
    public void Shake(float delayTime, float distance)
    {
        isShaking = true;

        this.delayTime = delayTime;
        this.distance = distance;

        Invoke("StopShake", delayTime);
    }

    void StopShake()
    {
        isShaking = false;
    }

    void Shaking()
    {
        if (isShaking)
        {
            this.transform.localPosition = initPosition + Random.insideUnitSphere * distance;
        }
    }
    #endregion
}
