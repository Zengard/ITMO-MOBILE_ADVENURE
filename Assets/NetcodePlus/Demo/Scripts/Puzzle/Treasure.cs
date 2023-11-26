using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NetcodePlus.Demo
{
    public class Treasure : SNetworkBehaviour
    {


        protected override void Awake()
        {
            base.Awake();

        }

        protected virtual void OnDestroy()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            GAManager.instance.OnLevelComplite(1);
            PuzzleGame.Get().WinGame();
        }
    }
}
