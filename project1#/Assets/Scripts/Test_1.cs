using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_1 : MonoBehaviour
{

    int test_int;  //������ �Ҵ��� �� intŸ������ ������ �����ϴ�.
    float test_float;    //������ ���������� �Ҽ��� ���� ������ �� floatŸ���� ������ �����ϴ�.
    string test_string;  //���ڿ��� �Ҵ����� �� stringŸ���� ������ �������ش�.
    bool test_bool;      //true�� false�� �� �� ���� ������ ���� �Ҵ� �� �� boolŸ���� ������ �������ش�.

    /*public int test_int2;
    public int test_int3;
    public int test_int4;*/


    public int test_bool1;
    public int test_bool2;
    private void Start()
    {
        // int 1 = 0�� �ݺ��� �����ϴ� ����, i < 10�� i �� 10���� ���� ������ �ݺ�, i++ �� i�� 1�� ����
        /*for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }*/

        //test_method(test_int2, test_int3);
    }
    private void Update()
    {
        while (test_bool1 < 10)
        {
            Debug.Log(test_bool1++)
            
        }
        //�� �����ڴ� >,< , ==,<= >=, !=
        //�� ������ ����
        //a > b �� a�� b���� ũ��.
        //a < b �� b�� a���� ũ��.
        //a == b a�� b�¿� ����.
        //a <= b b�� a�� ���ų� ũ��.
        //a >= b a�� b�� ���ų� ũ��.
        //a != b a �� b�� �ٸ���.
        if (Input.GetKeyDown(KeyCode.Space))

((      if (test_bool1 < test_bool2)
        {
            Debug.Log("if�� ���� ");
        }
        else if (test_bool1 == test_bool2)
        {
            Debug.Log("else if ����(���̴�)");
        }
        else 
        {
            Debug.Log("else ����(���̴�)");
        }
        //test_method(test_int2, test_int3);
        //test_int4 = Test_method2(test_int2, test_int3);
    }

    //�Ʒ��� �ִ� �� ��ü �ּ�(ctrl + shift + / �� ������ �ȴ� ),
    //(Ctrl + k ���� �� Ctrl + c) �̰� Ǯ���� (Ctrl + k �� ���� �� Ctrl+ U)
   /* void Test_method(int a, int b)  //retur�� �����ִ� �Լ� �Լ��� ���� void�� �������ش�.
    {
        Debug.Log(a + b);
    }
    int Test_method2(int a, int b)  //return�� ���ִ� �Լ� ������ ��ȯ�Ǵ� ���� Ÿ���� �������ش�.
    {
        return a + b;
    }*/
}