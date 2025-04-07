using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public int Health = 100;                   //ü���� 100�̶� �����Ѵ�.(int)
    public float Timer = 1.0f;                 //Ÿ�̸� ������ �����Ѵ�.(float)
    public int AttackPoint = 50;  //���ݷ��� �����Ѵ�.
    // ���� �������� ������Ʈ �Ǳ� �� �ѹ� ���� �ȴ�.
    void Start()
    {
        Health = 100;                          //�� ��ũ��Ʈ�� ���� �ɶ� 100�� �� �÷��ش�.
    }

    //������ �������� �� ������ ���� ȣ��ȴ�.
    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0) 
        {
            Timer = 1;
            Health += 10;
        }

        CharacterHealhtUp();

        if (Input.GetKeyDown(KeyCode.Space))  //�����̽� Ű�� �������� 
        {
            Health -= AttackPoint;      //ü�� ����Ʈ�� ���� ����Ʈ ��ŭ ���� ���� �ش�. (Health - Health - AttackPoint

        }
        CheckDeath();

    }

    private void CharacterHealhtUp()
    {
        throw new NotImplementedException();
    }

    public void CharacterHit(int Damage)          //�������� �޴� �Լ��� ���� �Ѵ�
    {
        Health -= Damage;                    //���� ���ݷ¿� ���� ü���� ���� ��Ų��

    }

    void CheckDeath() 
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

      
}


