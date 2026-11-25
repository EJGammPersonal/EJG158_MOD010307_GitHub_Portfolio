using UnityEngine;
using UnityEngine.SceneManagement;

namespace MicrogameCourse.Framework
{


    public sealed class SceneNavigator : MonoBehaviour
    {
        private const string MenuScene = "Main Menu";
        private const string RCPlaneSchool = "RC Plane School";
        private const string ClawMachine = "Claw Machine";
        private const string SlotsMachine = "Slot Machine";
        private const string RussianRoulette = "Russian Roulette";
        private bool isLoading;

        public void OpenRC()
        {
            Load(RCPlaneSchool);
        }

        public void OpenClaw()
        {
            Load(ClawMachine);
        }
        public void OpenSlots()
        {
            Load(SlotsMachine);
        }

        public void OpenRoulette()
        {
            Load(RussianRoulette);
        }

        public void OpenMenu()
        {
            Load(MenuScene);
        }



        public void Replay()
        {
            Load(SceneManager.GetActiveScene().name);
        }

        private void Load(string sceneName)
        {
            if (isLoading) return;
            if (!Application.CanStreamedLevelBeLoaded(sceneName))
            {
                Debug.LogError($"Add {sceneName} to File > Build Profiles > Scene List.");
            }


            isLoading = true;
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

        }
    }
}