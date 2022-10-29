using System.Collections;
using System.Threading;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // �ڷ�ƾ�� ���� ������� �۵��ϴ� �ڵ��̴�.
    private void Start()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId); // ���� 1�̸� ���� �����带 �ǹ��Ѵ�.
        StartCoroutine(CoStart());
    }

    IEnumerator CoStart()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
        yield return CoTest();
        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("�۾� ����");
        yield return null;
    }
}
