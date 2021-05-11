using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RainbowWhale
{
    public class Bonus : MonoBehaviour
    {
	    public BonusType bonusType;
	    public EnchantBullet EnchantBullet;

	    private void Update()
	    {
		    if (Input.GetKeyDown(KeyCode.Space))
		    {
			    
		    }
	    }
    }


    public enum BonusType
    {
	    EnchantBullet
    }
}
