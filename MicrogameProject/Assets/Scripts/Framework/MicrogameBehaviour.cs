using UnityEngine;
namespace MicrogameCourse.Framework
{



    public abstract class MicrogameBehaviour : MonoBehaviour
    {
        //Microgame Session
        protected bool isRunning { get; private set; }

        protected MicrogameSession Session { get; private set; }

        public virtual void Begin(MicrogameSession session)
        {
            Session = session;
            isRunning = true;

        }

        public virtual void End()
        {
            isRunning = false;
        }
        protected void Win()
        {
            if (isRunning) Session.Finish(true);
        }

        protected void Lose()
        {
            if (isRunning) Session.Finish(false);
        }
    }
}