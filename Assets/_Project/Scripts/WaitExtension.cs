using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public static class WaitExtension
{
    public static void Wait(this MonoBehaviour mono, float delay, UnityAction action)
    {
        if (mono.gameObject.activeInHierarchy)
        {
            mono.StartCoroutine(ExecuteAction(delay, action));
        }
    }

    private static IEnumerator ExecuteAction(float delay, UnityAction action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action.Invoke();
        yield break;
    }

    public static void SpeedUpFx(this ParticleSystem fx, float speed)
    {
        if (fx.gameObject.activeInHierarchy)
        {
            var main = fx.main;
            main.startSpeedMultiplier = speed;
        }

        for (int i = 0; i < fx.transform.childCount; i++)
        {
            if (fx.transform.GetChild(i).GetComponent<ParticleSystem>())
            {
                // TODO
                var main = fx.main;
                main.startSpeedMultiplier = speed;
            }
        }
    }
}