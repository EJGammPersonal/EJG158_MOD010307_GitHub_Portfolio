using UnityEngine;

namespace MicrogameCourse.Learning
{
    public class LifecycleProbe : MonoBehaviour
    {
        private bool hasLoggedFirstUpdate;

        private void Awake()
        {
            Log("Awake");
        }

        private void OnEnable()
        {
            Log("OnEnable");
        }

        private void Start()
        {
            Log("Start");
        }

        private void Update()
        {
            if (!hasLoggedFirstUpdate)
            {
                Log("first Update");
            }
        }

        private void OnDisable()
        {
            Log("OnDisable");
        }

        private void OnDestroy()
        {
            Log("OnDestroy");
        }

        private void Log(string eventName)
        {
            Debug.Log($"[frame {Time.frameCount}] {gameObject.name}: {eventName}");
        }
    }
}

