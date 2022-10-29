// 참고 블로그 : https://blog.naver.com/cdw0424/221592662392

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;
using Unity.Collections;

public class JobSystemTest4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);

        StartCoroutine(CoJob());
    }

    IEnumerator CoJob()
    {

        var A = new NativeArray<int>(100, Allocator.TempJob); // NativeArray<int>(배열을 몇개 까지 만들것인지, Allocator.TempJob....)
        var B = new NativeArray<int>(100, Allocator.TempJob); //Allocator.Temp... 사용시 반드시 메모리를 반환해줘야한다.
        var Result = new NativeArray<int>(100, Allocator.TempJob);

        // 값 넣어주기
        for (int i = 0; i < 100; i++)
        {
            A[i] = i;
            yield return null;
        }
        for (int i = 0; i < 100; i++)
        {
            B[i] = i;
            yield return null;
        }

        // 잡 생성
        TestJob testJob;

        // 생성자
        testJob.a = A;
        testJob.b = B;
        testJob.result = Result;

        // 스케줄링
        JobHandle Handle = testJob.Schedule(100, 32);

        // 안전하게 비동기로 작업을 진행할 수 있다.
        while (!Handle.IsCompleted)
        {
            yield return null;
        }

        Handle.Complete();

        for (int i = 0; i < 100; i++)
        {
            Debug.LogFormat("결과 : {0} + {1} = {2}", A[i], B[i], Result[i]);
            yield return null;
        }

        // 메모리 해제
        A.Dispose();
        B.Dispose();
        Result.Dispose();
    }

    // 반환형
    struct TestJob : IJobParallelFor
    {
        public NativeArray<int> a;
        public NativeArray<int> b;
        public NativeArray<int> result;

        public void Execute(int index)
        {
            result[index] = a[index] + b[index];
        }
    }
}
