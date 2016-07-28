/*
作者名称:YHB

脚本作用:随机生成粒子特效

建立时间:2016.7.28.17.30
*/

using UnityEngine;
using System.Collections;

public class SpawnRandom : MonoBehaviour
{
    #region 字段
    public GameObject YanHuoPrefab;
    public float minTime = 1f;
    public float maxTime = 3f;
    public float distance = 3f;
    #endregion

    #region Unity内置函数
    void Start()
    {
        Invoke("Spawn", Random.Range(minTime, maxTime));
    }
    #endregion

    //生成的方法
    void Spawn()
    {
        Instantiate(YanHuoPrefab, this.transform.position + Random.insideUnitSphere * distance, Quaternion.identity);
    }
}
