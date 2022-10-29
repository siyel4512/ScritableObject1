using System.Collections;
using System.Threading;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // 코루틴은 단일 쓰레드로 작동하는 코드이다.
    private void Start()
    {
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId); // 값이 1이면 메인 쓰레드를 의미한다.
        StartCoroutine(CoStart());
    }

    IEnumerator CoStart()
    {
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
        yield return CoTest();
        Debug.LogFormat("현재 프래임 : {0}", Time.frameCount);
    }

    IEnumerator CoTest()
    {
        Debug.LogFormat("현재 쓰레드 : {0}", Thread.CurrentThread.ManagedThreadId);
        Debug.LogFormat("작업 했음");
        yield return null;
    }
}
