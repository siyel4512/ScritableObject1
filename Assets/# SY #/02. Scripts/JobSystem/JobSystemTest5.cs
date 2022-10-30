// 참고 블로그1 : https://rito15.github.io/posts/job-system/
// 참고 블로그2 : https://javart.tistory.com/135
// 참고 블로그3 : https://buttha.tistory.com/6

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
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);

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
        // 잡 생성
        TestJob testJob;

        // 스케줄링
        JobHandle Handle = testJob.Schedule();

        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest2()
    {
        // 잡 생성
        TestJob2 testJob2;

        // 스케줄링
        JobHandle Handle2 = testJob2.Schedule();

        while (!Handle2.IsCompleted)
        {
            yield return null;
        }

        Handle2.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest3()
    {
        // 잡 생성
        TestJob3 testJob3;

        // 스케줄링
        JobHandle Handle3 = testJob3.Schedule();

        while (!Handle3.IsCompleted)
        {
            yield return null;
        }

        Handle3.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest4()
    {
        // 잡 생성
        TestJob4 testJob4;

        // 스케줄링
        JobHandle Handle4 = testJob4.Schedule();

        while (!Handle4.IsCompleted)
        {
            yield return null;
        }

        Handle4.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest5()
    {
        // 잡 생성
        TestJob5 testJob5;

        // 스케줄링
        JobHandle Handle5 = testJob5.Schedule();

        while (!Handle5.IsCompleted)
        {
            yield return null;
        }

        Handle5.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest6()
    {
        // 잡 생성
        TestJob6 testJob6;

        // 스케줄링
        JobHandle Handle6 = testJob6.Schedule();

        while (!Handle6.IsCompleted)
        {
            yield return null;
        }

        Handle6.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest7()
    {
        // 잡 생성
        TestJob7 testJob7;

        // 스케줄링
        JobHandle Handle7 = testJob7.Schedule();

        while (!Handle7.IsCompleted)
        {
            yield return null;
        }

        Handle7.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest8()
    {
        // 잡 생성
        TestJob8 testJob8;

        // 스케줄링
        JobHandle Handl8 = testJob8.Schedule();

        while (!Handl8.IsCompleted)
        {
            yield return null;
        }

        Handl8.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest9()
    {
        // 잡 생성
        TestJob9 testJob9;

        // 스케줄링
        JobHandle Handle9 = testJob9.Schedule();

        while (!Handle9.IsCompleted)
        {
            yield return null;
        }

        Handle9.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest10()
    {
        // 잡 생성
        TestJob10 testJob10;

        // 스케줄링
        JobHandle Handle10 = testJob10.Schedule();

        while (!Handle10.IsCompleted)
        {
            yield return null;
        }

        Handle10.Complete();

        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    // IJob은 비동기로 단일 쓰레드를 하나 더 사용하겠다는 의미
    struct TestJob : IJob
    {
        public void Execute()
        {
            // 실제 작업은 여기서 처리
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음");
        }
    }

    struct TestJob2 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음2");
        }
    }

    struct TestJob3 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음3");
        }
    }

    struct TestJob4 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음4");
        }
    }

    struct TestJob5 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음5");
        }
    }

    struct TestJob6 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음6");
        }
    }

    struct TestJob7 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음7");
        }
    }

    struct TestJob8 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음8");
        }
    }

    struct TestJob9 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음9");
        }
    }

    struct TestJob10 : IJob
    {
        public void Execute()
        {
            Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
            print("작업 했음10");
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

        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
    }

    struct ParallelForJob : IJobParallelFor
    {
        public NativeArray<int> result;

        public void Execute(int index)
        {
            result[index] = index;
            Debug.LogFormat("index : {0}, result : {1}, 쓰레드 번호 : {2}", index, result[index], Thread.CurrentThread.ManagedThreadId);
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

            Debug.LogFormat("index : {0}, {1} + {2} = {3}, 쓰레드 번호 : {4}", index, a[index], b[index],  result[index], Thread.CurrentThread.ManagedThreadId);
        }
    }
    #endregion
}
