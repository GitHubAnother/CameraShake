/*
作者名称:YHB

脚本作用:单例调用震动相机脚本--->放在粒子特效上

建立时间:2016.7.28.19.28
*/

using UnityEngine;
using System.Collections;

public class CameraShakeStart : MonoBehaviour
{
    #region 字段
    public float delayTime = 0.1f;
    public float distance = 0.5f;
    #endregion

    void Start()
    {
        CameraShake._Instance.Shake(delayTime, distance);
    }
}
