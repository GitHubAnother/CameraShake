/*
作者名称:YHB

脚本作用:自销毁

建立时间:2016.7.28.20.05
*/

using UnityEngine;
using System.Collections;

public class DestroyThis : MonoBehaviour
{
    void Start()
    {
        Destroy(this.gameObject, 0.9f);
    }
}
