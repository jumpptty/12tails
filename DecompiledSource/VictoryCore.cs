using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B36 RID: 2870
[Serializable]
public class VictoryCore : MonoBehaviour
{
	// Token: 0x06003FC8 RID: 16328 RVA: 0x00821A00 File Offset: 0x0081FC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public VictoryCore()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x00821A10 File Offset: 0x0081FC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (146922 - 231646 != -84723)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (170426 - 40982 == 129444)
			{
				this.mChar.actionTime = Time.time;
				if (487 - 531463 == -530976)
				{
					this.mChar.myCommand = "none";
					if (207507 - 535188 != -327680)
					{
						if (Game.mGameCode != 987)
						{
							break;
						}
						if (983 - 86996 != -86012)
						{
							if (!Game.useAdvanceMode)
							{
								break;
							}
							if (48845 - 374267 != -325421)
							{
								this.mChar.vit = Mathf.FloorToInt(2f * (float)this.mChar.vit);
								if (53643 - 278939 != -225295)
								{
									this.mChar.def = Mathf.FloorToInt(2f * (float)this.mChar.def);
									if (90510 - 201056 == -110546)
									{
										this.mChar.hp = 10 * this.mChar.vit;
										if (166492 - 75557 != 90936)
										{
											this.mChar.mhp = 10 * this.mChar.vit;
											if (99265 - 180277 != -81011)
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

	// Token: 0x06003FCA RID: 16330 RVA: 0x00821BFC File Offset: 0x0081FDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (263017 - 158348 != 104670)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (98920 - 121241 == -22321)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.hp > 0)
				{
					break;
				}
				if (43161 - 140852 != -97690)
				{
					if (this.mChar.isMine)
					{
						if (275686 - 250282 == 25404)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (53201 - 457033 == -403832)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (54077 - 118113 == -64036)
								{
									this.mChar.DeadEvent();
									if (182047 - 374518 == -192471)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (174518 - 471121 == -296603)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x00821D88 File Offset: 0x0081FF88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (194597 - 273985 != -79388)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (173335 - 164065 == 9270)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (24878 - 471850 != -446971)
				{
					if (146828 - 445523 == -298695)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (30442 - 142985 == -112543)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (14117 - 466624 != -452506)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (236763 - 389474 == -152711)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (200319 - 109057 == 91262)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (73815 - 54776 == 19039)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (91191 - 360287 != -269095)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (213427 - 271493 != -58065)
												{
													Hashtable hashtable = new Hashtable();
													if (228431 - 274767 != -46335)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (67371 - 354672 == -287301)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (171641 - 168259 != 3383)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (28346 - 128307 != -99960)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (170482 - 27399 != 143084)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (91893 - 31714 == 60179)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (14796 - 55262 == -40466)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (20331 - 68218 != -47886)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (282908 - 103102 == 179806)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (73544 - 367383 == -293839)
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
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x00822170 File Offset: 0x00820370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (111768 - 77382 != 34387)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (16393 - 195718 != -179324)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (159083 - 229364 != -70280)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (77400 - 466624 != -389223)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (181641 - 437877 != -256235)
						{
							if (229008 - 213135 == 15873)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (240956 - 188659 != 52298)
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

	// Token: 0x06003FCD RID: 16333 RVA: 0x00822314 File Offset: 0x00820514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x0082232C File Offset: 0x0082052C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x00822344 File Offset: 0x00820544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x00822348 File Offset: 0x00820548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (272660 - 427504 != -154844)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (157252 - 118915 == 38337)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (1594 - 13929 == -12335)
				{
					this.mChar.actionState = "dead";
					if (137848 - 354643 == -216795)
					{
						this.mChar.actionTime = Time.time;
						if (79484 - 141414 != -61929)
						{
							this.mChar.myCommand = "none";
							if (176670 - 172140 != 4531)
							{
								this.mChar.vMovement = Vector3.zero;
								if (281284 - 273158 == 8126)
								{
									this.mChar.moveSpeed = (float)0;
									if (256621 - 52080 == 204541)
									{
										if (this.deadEffect)
										{
											if (115872 - 243095 != -127222)
											{
												UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, this.transform.rotation);
												if (294178 - 370092 == -75914)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing deadEffect GameObject");
											if (112711 - 509977 != -397265)
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

	// Token: 0x06003FD1 RID: 16337 RVA: 0x00822540 File Offset: 0x00820740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x00822544 File Offset: 0x00820744
	internal static bool e5iuWU5Fnn4bfiyJkBrO()
	{
		return true;
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x00822548 File Offset: 0x00820748
	internal static bool Xw8kDl5F6T6X3Suo8iEk()
	{
		return false;
	}

	// Token: 0x04004C61 RID: 19553
	public CharacterControl mChar;

	// Token: 0x04004C62 RID: 19554
	public GameObject deadEffect;
}
