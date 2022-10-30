// ���� ��α�1 : https://rito15.github.io/posts/job-system/
// ���� ��α�2 : https://javart.tistory.com/135
// ���� ��α�3 : https://buttha.tistory.com/6

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using Unity.Collections;

public class JobSystemTest5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("���� ������ : {0}", Time.frameCount);

        //IJob();
        //Parallel();
        Parallel2();
    }

    #region IJob
    private void IJob()
    {
        StartCoroutine(CoTest());
        StartCoroutine(CoTest2());
        StartCoroutine(CoTest3());
        StartCoroutine(CoTest4());
        StartCoroutine(CoTest5());
        StartCoroutine(CoTest6());
        StartCoroutine(CoTest7());
        StartCoroutine(CoTest8());
        StartCoroutine(CoTest9());
        StartCoroutine(CoTest10());
    }

    IEnumerator CoTest()
    {
        // �� ����
        TestJob testJob;

        // �����ٸ�
        JobHandle Handle = testJob.Schedule();

        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest2()
    {
        // �� ����
        TestJob2 testJob2;

        // �����ٸ�
        JobHandle Handle2 = testJob2.Schedule();

        while (!Handle2.IsCompleted)
        {
            yield return null;
        }

        Handle2.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest3()
    {
        // �� ����
        TestJob3 testJob3;

        // �����ٸ�
        JobHandle Handle3 = testJob3.Schedule();

        while (!Handle3.IsCompleted)
        {
            yield return null;
        }

        Handle3.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest4()
    {
        // �� ����
        TestJob4 testJob4;

        // �����ٸ�
        JobHandle Handle4 = testJob4.Schedule();

        while (!Handle4.IsCompleted)
        {
            yield return null;
        }

        Handle4.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest5()
    {
        // �� ����
        TestJob5 testJob5;

        // �����ٸ�
        JobHandle Handle5 = testJob5.Schedule();

        while (!Handle5.IsCompleted)
        {
            yield return null;
        }

        Handle5.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest6()
    {
        // �� ����
        TestJob6 testJob6;

        // �����ٸ�
        JobHandle Handle6 = testJob6.Schedule();

        while (!Handle6.IsCompleted)
        {
            yield return null;
        }

        Handle6.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest7()
    {
        // �� ����
        TestJob7 testJob7;

        // �����ٸ�
        JobHandle Handle7 = testJob7.Schedule();

        while (!Handle7.IsCompleted)
        {
            yield return null;
        }

        Handle7.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest8()
    {
        // �� ����
        TestJob8 testJob8;

        // �����ٸ�
        JobHandle Handl8 = testJob8.Schedule();

        while (!Handl8.IsCompleted)
        {
            yield return null;
        }

        Handl8.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest9()
    {
        // �� ����
        TestJob9 testJob9;

        // �����ٸ�
        JobHandle Handle9 = testJob9.Schedule();

        while (!Handle9.IsCompleted)
        {
            yield return null;
        }

        Handle9.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    IEnumerator CoTest10()
    {
        // �� ����
        TestJob10 testJob10;

        // �����ٸ�
        JobHandle Handle10 = testJob10.Schedule();

        while (!Handle10.IsCompleted)
        {
            yield return null;
        }

        Handle10.Complete();

        Debug.LogFormat("���� ������ : {0}", Time.frameCount);
    }

    // IJob�� �񵿱�� ���� �����带 �ϳ� �� ����ϰڴٴ� �ǹ�
    struct TestJob : IJob
    {
        public void Execute()
        {
            // ���� �۾��� ���⼭ ó��
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����");
        }
    }

    struct TestJob2 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����2");
        }
    }

    struct TestJob3 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����3");
        }
    }

    struct TestJob4 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����4");
        }
    }

    struct TestJob5 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����5");
        }
    }

    struct TestJob6 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����6");
        }
    }

    struct TestJob7 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����7");
        }
    }

    struct TestJob8 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����8");
        }
    }

    struct TestJob9 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����9");
        }
    }

    struct TestJob10 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
            print("�۾� ����10");
        }
    }
    #endregion

    #region IJobParallelFor
    private void Parallel()
    {
        var result = new NativeArray<int>(100, Allocator.TempJob);

        ParallelForJob job = new ParallelForJob();
        job.result = result;

        JobHandle handle = job.Schedule(100, 20);

        handle.Complete();

        result.Dispose();

        Debug.LogFormat("���� ������ : {0}", Thread.CurrentThread.ManagedThreadId);
    }

    struct ParallelForJob : IJobParallelFor
    {
        public NativeArray<int> result;

        public void Execute(int index)
        {
            result[index] = index;
            Debug.LogFormat("index : {0}, result : {1}, ������ ��ȣ : {2}", index, result[index], Thread.CurrentThread.ManagedThreadId);
        }
    }

    private void Parallel2()
    {
        var a = new NativeArray<int>(10, Allocator.TempJob);
        var b = new NativeArray<int>(10, Allocator.TempJob);
        var result = new NativeArray<int>(10, Allocator.TempJob);

        ParallelJob2 job = new ParallelJob2();
        job.a = a;
        job.b = b;
        job.result = result;

        for (int i = 0; i < 10; i++)
        {
            a[i] = 10 - i;
            b[i] = i;
        }

        JobHandle handle = job.Schedule(10, 2);
        handle.Complete();

        a.Dispose();
        b.Dispose();
        result.Dispose();
    }

    struct ParallelJob2 : IJobParallelFor
    {
        public NativeArray<int> a;
        public NativeArray<int> b;
        public NativeArray<int> result;

        public void Execute(int index)
        {
            result[index] = a[index] + b[index];

            Debug.LogFormat("index : {0}, {1} + {2} = {3}, ������ ��ȣ : {4}", index, a[index], b[index],  result[index], Thread.CurrentThread.ManagedThreadId);
        }
    }
    #endregion
}
