using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{

    // 设定绑定目标  
    public Transform target;
    // 设置隔离目标的距离  
    float distance = 10.0f;
    // 设置隔离目标的高度  
    float height = 0f;
    //转动的速度  
    float heightDamping = 2.0f;
    float rotationDamping = 3.0f;

    void LateUpdate()
    {
        // Early out if we don't have a target  
        if (!target)
            return;

        // 想要旋转的角度和高度  
        //float wantedRotationAngle = target.eulerAngles.y;  
        float wantedHeight = target.position.y + height;


        //当前的高度和欧拉角  
        //float currentRotationAngle = transform.eulerAngles.y;  
        float currentHeight = transform.position.y;

        //从当前的欧拉角旋转到  
        //currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);  

        //从当前的高度到想到的高度  
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        //这里是我修改的，直接让它等于1，  
        //摄像机就不会旋转。  
        float currentRotation = 1;

        // 设置于目标的Y轴的距离  
        transform.position = target.position;//先让目标的位置和摄像机的位置一致  
        transform.position -= currentRotation * Vector3.forward * distance;//改变摄像机的Z轴  

        // 设置摄像机的位置  
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        //摄像机总是注视目标  
        transform.LookAt(target);
    }
}