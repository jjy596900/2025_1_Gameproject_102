using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public int Health = 100;                   //ü���� 100�̶� �����Ѵ�.(int)
    public float Timer = 1.0f;                 //Ÿ�̸� ������ �����Ѵ�.(float)
    public int AttackPoint = 50;              //���ݷ��� �����Ѵ�.
    // ���� �������� ������Ʈ �Ǳ� �� �ѹ� ���� �ȴ�.
    void Start()
    {
        Health += 100;                          //�� ��ũ��Ʈ�� ���� �ɶ� 100�� �� �÷��ش�.
    }

    //������ �������� �� ������ ���� ȣ��ȴ�.
    void Update()
    {
        Timer -= Time.deltaTime;            //�ð��� �� �����Ӹ��� ���ҽ�Ų��(deltatime ������ ������ �ð��� �ǹ��մϴ�)
        if (Timer <= 0)                    //���� Timer �� ��ġ�� 0���Ϸ� ������ ��� (1�ʸ��� ���۵Ǵ� �ൿ�� ���鶧)
        {
            Timer = 1;                      //�ٽ� 1�ʷ� Ÿ�̸Ӹ� �ʱ�ȭ �����ش�
            Health += 10;                   //1�ʸ��� ü���� 10�� �÷��ش�
        }

        if (Input.GetKeyDown(KeyCode.Space))  //�����̽� Ű�� �������� 
        {
            Health -= AttackPoint;      //ü�� ����Ʈ�� ���� ����Ʈ ��ŭ ���� ���� �ش�. (Health - Health - AttackPoint
        
        }

        if (Health <= 0)          //ü���� 0���� �� ���
        {
            Destroy(gameObject);        // �� ������Ʈ�� �ı� ��Ų��.
        }
    
    }
}
