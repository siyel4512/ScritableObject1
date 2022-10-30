using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Jobs;
using UnityEngine;

public class JobSystemTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);

        // 잡 생성
        TestJob testJob;

        // 스케줄링
        //testJob.Schedule(); // 메인 쓰레드에 스케줄링해준 다음에 스케줄링한 작업을 워크쓰레드들이 가져감. 이때 워크쓰레드(유니티에서...)는 "잢쓰레드"라고도 불림, 코어의 개수만큼 존재(ex 쿼드코어는 4개의 잡쓰레드 존재)

        // 해당 작업이 끝날때까지 대기하고 싶다면
        JobHandle Handle = testJob.Schedule();
        Handle.Complete();

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
}
