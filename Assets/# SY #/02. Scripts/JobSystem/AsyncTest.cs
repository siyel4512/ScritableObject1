using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class AsyncTest : MonoBehaviour
{
    //// Start is called before the first frame update
    //async void Start()
    //{
    //    Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
    //    Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    //    await TestAsync(); //  ���� �����尡 �ƴ� �ٸ� �����尡 �۾��� �����ϰ� ����
    //    Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    //}

    //private async Task TestAsync()
    //{
    //    // await�� �ش� �۾��� ���������� �ش� �Լ��� ��ٸ�
    //    await Task.Run(()=> 
    //    {
    //        Debug.Log("�۾� ����");
    //        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
    //    });
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // �̺�Ʈ �ڵ鷯�� ����Ѵٸ� ������ ���� ���� (��ȯ���� Task���� void�� ����...)
    private async void TestAsync()
    {
        // await�� �ش� �۾��� ���������� �ش� �Լ��� ��ٸ�
        await Task.Run(() =>
        {
            Debug.Log("�۾� ����");
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        });
    }
}
