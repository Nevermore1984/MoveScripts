using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour {


    public NavMeshAgent agent;
    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//坐标转化为射线  这里注意如果摄像机要将tag设置为MainCamera 否则会报空引用
            RaycastHit hit;//保存碰撞信息
            if (Physics.Raycast(ray, out hit))
            {
                //print(hit.point);
                agent.SetDestination(hit.point);//设置要到达的目标位置

            }
        }


        animator.SetFloat("Speed", agent.velocity.magnitude);//根据速度  播放动画
	}
}
