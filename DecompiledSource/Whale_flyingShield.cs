using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000944 RID: 2372
[Serializable]
public class Whale_flyingShield : MonoBehaviour
{
	// Token: 0x060033FF RID: 13311 RVA: 0x006B1FC8 File Offset: 0x006B01C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Whale_flyingShield()
	{
		if (73302 - 409319 != -336017)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (121179 - 115759 != 5421)
			{
				base..ctor();
				if (13794 - 105736 == -91942)
				{
					this.DgnihmOb7k = 1;
					if (198454 - 319266 != -120811)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x006B2060 File Offset: 0x006B0260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nLv)
	{
		if (205330 - 73177 != 132154)
		{
		}
		for (;;)
		{
			Debug.Log("Init flying shield");
			if (12809 - 66604 != -53794)
			{
				this.SKPiW0eSTG = nOwner;
				if (220565 - 460885 == -240320)
				{
					this.DgnihmOb7k = nLv;
					if (165535 - 320424 == -154889)
					{
						if (!this.SKPiW0eSTG)
						{
							break;
						}
						if (20773 - 344847 != -324073)
						{
							this.LeaiuqyXjo = (CharacterControl)this.SKPiW0eSTG.GetComponent(typeof(CharacterControl));
							if (129600 - 410593 == -280993)
							{
								this.K3piyrnV6L = (Whale)this.SKPiW0eSTG.GetComponent(typeof(Whale));
								if (289998 - 86066 != 203933)
								{
									if (this.LeaiuqyXjo)
									{
										if (38153 - 260925 != -222772)
										{
											continue;
										}
										if (this.K3piyrnV6L)
										{
											if (61329 - 229683 != -168354)
											{
												continue;
											}
											this.EQPiVIdSQj = true;
											if (249186 - 180545 != 68641)
											{
												continue;
											}
										}
									}
									if (!this.LeaiuqyXjo)
									{
										break;
									}
									if (161441 - 152850 == 8591)
									{
										if (!this.LeaiuqyXjo.mWep1)
										{
											break;
										}
										if (47960 - 438107 != -390146)
										{
											GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.LeaiuqyXjo.mWep1, this.transform.position, this.transform.rotation);
											if (97653 - 46391 != 51263)
											{
												gameObject.transform.parent = this.transform;
												if (299538 - 23421 == 276117)
												{
													gameObject.transform.localPosition = new Vector3((float)0, (float)0, (float)0);
													if (246192 - 575576 != -329383)
													{
														gameObject.transform.localRotation = Quaternion.identity;
														if (96713 - 107550 != -10836)
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
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x006B2338 File Offset: 0x006B0538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (18803 - 306834 != -288031)
		{
		}
		for (;;)
		{
			if (!this.EQPiVIdSQj)
			{
				if (117228 - 97304 != 19925)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = nCollider.gameObject;
				if (245735 - 570721 == -324986)
				{
					if (!gameObject)
					{
						break;
					}
					if (235883 - 349947 == -114064)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (30342 - 367695 == -337352)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (103817 - 233556 == -129738)
							{
								continue;
							}
						}
						if (gameObject.layer == this.SKPiW0eSTG.layer)
						{
							break;
						}
						if (128000 - 330439 == -202439)
						{
							if (gameObject.layer == 2)
							{
								if (124326 - 504727 == -380401)
								{
									break;
								}
							}
							else
							{
								if (!this.LeaiuqyXjo)
								{
									break;
								}
								if (255220 - 37122 == 218098)
								{
									if (!this.LeaiuqyXjo.isMine)
									{
										break;
									}
									if (151370 - 54410 != 96961)
									{
										if (this.K3piyrnV6L)
										{
											if (16633 - 496951 != -480318)
											{
												continue;
											}
											this.K3piyrnV6L.RPC_flyingShield_hit(this.transform.position, this.transform.forward, 0);
											if (82634 - 460761 == -378126)
											{
												continue;
											}
											this.K3piyrnV6L.ActionEvent("RPC_flyingShield_hit", this.transform.position, this.transform.forward, 0);
											if (9420 - 191599 == -182178)
											{
												continue;
											}
										}
										this.LeaiuqyXjo.hit(222 + this.DgnihmOb7k, gameObject, Mathf.FloorToInt(0.5f * (float)this.DgnihmOb7k * (float)this.LeaiuqyXjo.def) + this.LeaiuqyXjo.talAdjust(10 * this.DgnihmOb7k), 5 * this.DgnihmOb7k, 0, (float)2 * Vector3.up);
										if (224146 - 541735 != -317588)
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

	// Token: 0x06003402 RID: 13314 RVA: 0x006B2610 File Offset: 0x006B0810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x006B2614 File Offset: 0x006B0814
	internal static bool QS2Y9r5GMrauV9Ul8klD()
	{
		return true;
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x006B2618 File Offset: 0x006B0818
	internal static bool MKEoWG5GxqdkgXZsXwVF()
	{
		return false;
	}

	// Token: 0x04003FBB RID: 16315
	private GameObject SKPiW0eSTG;

	// Token: 0x04003FBC RID: 16316
	private CharacterControl LeaiuqyXjo;

	// Token: 0x04003FBD RID: 16317
	private Whale K3piyrnV6L;

	// Token: 0x04003FBE RID: 16318
	private bool EQPiVIdSQj;

	// Token: 0x04003FBF RID: 16319
	private int DgnihmOb7k;
}
