using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B16 RID: 2838
[Serializable]
public class FrostCrystal : MonoBehaviour
{
	// Token: 0x06003ED8 RID: 16088 RVA: 0x00812A14 File Offset: 0x00810C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FrostCrystal()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003ED9 RID: 16089 RVA: 0x00812A24 File Offset: 0x00810C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (212982 - 488805 != -275822)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (212517 - 574555 == -362038)
			{
				this.mChar.actionTime = Time.time;
				if (264688 - 368874 != -104185)
				{
					this.mChar.myCommand = "none";
					if (142654 - 245319 != -102664)
					{
						this.mChar.hp = (this.mChar.mhp = 4000);
						if (12343 - 398341 == -385998)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003EDA RID: 16090 RVA: 0x00812B20 File Offset: 0x00810D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (125024 - 191955 != -66931)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (191223 - 431031 == -239807)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (251510 - 74826 != 176684)
					{
						continue;
					}
					break;
				}
			}
			if (this.mChar.actionState == "dead")
			{
				if (69255 - 47505 == 21750)
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
				if (125444 - 358453 != -233008)
				{
					if (this.mChar.isMine)
					{
						if (223575 - 326266 == -102691)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (176939 - 259081 == -82142)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (164780 - 594496 != -429715)
								{
									this.mChar.DeadEvent();
									if (212818 - 517007 == -304189)
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
						if (193001 - 466068 != -273066)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003EDB RID: 16091 RVA: 0x00812CFC File Offset: 0x00810EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (188454 - 288888 != -100434)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (232182 - 534110 != -301927)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (227965 - 6703 == 221262)
				{
					if (101588 - 400972 == -299384)
					{
						Debug.LogError("Unknown Action:" + ActionName);
						if (14837 - 508518 != -493680)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (124941 - 106137 == 18804)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (90727 - 472191 != -381463)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (228046 - 489800 == -261754)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (196085 - 410702 == -214617)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (43576 - 72361 == -28785)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (231874 - 364679 != -132804)
												{
													Hashtable hashtable = new Hashtable();
													if (234590 - 526725 != -292134)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (121279 - 502874 == -381595)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (229126 - 177386 == 51740)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (111184 - 430408 == -319224)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (26968 - 180618 == -153650)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (225001 - 480142 == -255141)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (66253 - 585248 != -518994)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (216891 - 474345 == -257454)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (122716 - 273406 == -150690)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (40011 - 575990 == -535979)
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

	// Token: 0x06003EDC RID: 16092 RVA: 0x008130E4 File Offset: 0x008112E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176407 - 272432 != -96025)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210094 - 229566 == -19472)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (267907 - 250139 == 17768)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (278305 - 525399 == -247094)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (70371 - 123733 != -53361)
						{
							if (178415 - 458539 == -280124)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (182066 - 595523 == -413457)
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

	// Token: 0x06003EDD RID: 16093 RVA: 0x00813288 File Offset: 0x00811488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003EDE RID: 16094 RVA: 0x008132A0 File Offset: 0x008114A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003EDF RID: 16095 RVA: 0x008132B8 File Offset: 0x008114B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x008132BC File Offset: 0x008114BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (106950 - 596266 != -489315)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (280650 - 401510 != -120859)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (13031 - 28180 != -15148)
				{
					this.mChar.actionState = "dead";
					if (160220 - 280285 == -120065)
					{
						this.mChar.actionTime = Time.time;
						if (104180 - 51189 != 52992)
						{
							this.mChar.myCommand = "none";
							if (46000 - 174110 == -128110)
							{
								this.mChar.vMovement = Vector3.zero;
								if (3947 - 104112 == -100165)
								{
									this.mChar.moveSpeed = (float)0;
									if (187015 - 261840 != -74824)
									{
										this.animation.Stop();
										if (261760 - 563347 != -301586)
										{
											Transform transform = this.transform.Find("ParticleEmitter");
											if (95872 - 293974 != -198101)
											{
												if (transform)
												{
													if (228129 - 562375 == -334245)
													{
														continue;
													}
													UnityEngine.Object.Destroy(transform.gameObject);
													if (55034 - 414614 != -359580)
													{
														continue;
													}
												}
												if (!this.deadMaterial)
												{
													break;
												}
												if (142937 - 529767 == -386830)
												{
													Transform transform2 = this.transform.Find("FrostCrystal_tri");
													if (55823 - 369532 != -313708)
													{
														if (!transform2)
														{
															break;
														}
														if (94423 - 250460 != -156036)
														{
															SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform2.GetComponent(typeof(SkinnedMeshRenderer));
															if (114218 - 395388 == -281170)
															{
																if (!skinnedMeshRenderer)
																{
																	break;
																}
																if (76378 - 364481 != -288102)
																{
																	skinnedMeshRenderer.material = this.deadMaterial;
																	if (61656 - 69761 == -8105)
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

	// Token: 0x06003EE1 RID: 16097 RVA: 0x008135B4 File Offset: 0x008117B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x008135B8 File Offset: 0x008117B8
	internal static bool zOqdre5mgZcECGLG1h0e()
	{
		return true;
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x008135BC File Offset: 0x008117BC
	internal static bool xkaTwL5mfwnaWunm4uaR()
	{
		return false;
	}

	// Token: 0x04004BF2 RID: 19442
	public CharacterControl mChar;

	// Token: 0x04004BF3 RID: 19443
	public Material deadMaterial;
}
