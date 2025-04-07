using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public int Health = 100;                   //체력을 100이라 설정한다.(int)
    public float Timer = 1.0f;                 //타이머 변수를 선언한다.(float)
    public int AttackPoint = 50;  //공격력을 선언한다.
    // 최초 프레임이 업데이트 되기 전 한번 실행 된다.
    void Start()
    {
        Health = 100;                          //이 스크립트가 실행 될때 100을 더 올려준다.
    }

    //게임이 진행중인 매 프레임 마다 호출된다.
    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0) 
        {
            Timer = 1;
            Health += 10;
        }

        CharacterHealhtUp();

        if (Input.GetKeyDown(KeyCode.Space))  //스페이스 키를 눌렀을때 
        {
            Health -= AttackPoint;      //체력 포인트를 공격 포인트 만큼 감소 시켜 준다. (Health - Health - AttackPoint

        }
        CheckDeath();

    }

    private void CharacterHealhtUp()
    {
        throw new NotImplementedException();
    }

    public void CharacterHit(int Damage)          //데미지를 받는 함수를 선언 한다
    {
        Health -= Damage;                    //받은 공격력에 대한 체력을 감소 시킨다

    }

    void CheckDeath() 
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

      
}


