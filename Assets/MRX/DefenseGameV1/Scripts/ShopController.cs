using System;
using Unity.VisualScripting;
using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class ShopController : MonoBehaviour
    {
        public ShopItem[] items;

        void Start()
        {
            Init();
        }
        private void Init()
        {
            if (items == null || items.Length <= 0) return;
            for (int i = 0; i < items.Length; i++)
            {
                var item = items[i];
                string dataKey = Const.PLAYER_PREFIX_PREF + i;//player_0,1,2
                if (item != null)
                {
                    if (i == 0)
                        Pref.SetBool(dataKey, true);
                    else
                    {
                        if (!PlayerPrefs.HasKey(dataKey))
                            Pref.SetBool(dataKey, false);
                    }
                }
            }
        } 
    }
}

