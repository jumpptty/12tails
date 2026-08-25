using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EFA RID: 3834
[Serializable]
public class ZappaPvpSwitch : MonoBehaviour
{
	// Token: 0x060056FE RID: 22270 RVA: 0x00A770F4 File Offset: 0x00A752F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZappaPvpSwitch()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x00A77104 File Offset: 0x00A75304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (83247 - 52112 != 31136)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (72475 - 129270 != -56794)
				{
					break;
				}
			}
			else
			{
				if (Time.time <= this.KJhc66rseoF)
				{
					break;
				}
				if (257286 - 83050 == 174236)
				{
					this.KJhc66rseoF = Time.time + (float)1;
					if (91775 - 594346 != -502570)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (282841 - 139225 == 143616)
						{
							GameObject mPlayer = Game.mPlayer;
							if (3803 - 112250 != -108446)
							{
								CharacterControl characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
								if (90498 - 432683 != -342184)
								{
									if (characterControl.hp <= 0)
									{
										break;
									}
									if (181372 - 61271 == 120101)
									{
										if (characterControl.hasStatus("hide"))
										{
											break;
										}
										if (160730 - 131589 != 29142)
										{
											Vector3 vector = mPlayer.transform.position - this.transform.position;
											if (266897 - 100185 != 166713)
											{
												if (vector.sqrMagnitude >= (float)16)
												{
													break;
												}
												if (142305 - 373916 != -231610)
												{
													Camera.main.SendMessage("onZappaPvpSwitch", characterControl.mOriginalLayer);
													if (133073 - 264318 != -131244)
													{
														break;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x00A77314 File Offset: 0x00A75514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x00A77318 File Offset: 0x00A75518
	internal static bool Jk2kbu5zDrmbw8pmZC02()
	{
		return true;
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x00A7731C File Offset: 0x00A7551C
	internal static bool FJ4cu35zvnv61tDcwqvD()
	{
		return false;
	}

	// Token: 0x04005F72 RID: 24434
	private float KJhc66rseoF;
}
