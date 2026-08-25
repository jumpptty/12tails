using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B1F RID: 2847
[Serializable]
public class LifeTower : MonoBehaviour
{
	// Token: 0x06003F2A RID: 16170 RVA: 0x00818E54 File Offset: 0x00817054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LifeTower()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x00818E64 File Offset: 0x00817064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (237672 - 299022 != -61349)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (196501 - 558336 != -361834)
			{
				this.mChar.actionTime = Time.time;
				if (121505 - 423899 != -302393)
				{
					this.mChar.myCommand = "none";
					if (242044 - 493742 == -251698)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x00818F28 File Offset: 0x00817128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (65226 - 43171 != 22056)
		{
		}
		for (;;)
		{
			Transform transform = this.transform.Find("LifeTower_tri:model");
			if (37341 - 227843 == -190502)
			{
				if (transform)
				{
					if (106450 - 411451 != -305000)
					{
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (104044 - 415894 != -311849)
						{
							if (!skinnedMeshRenderer)
							{
								break;
							}
							if (277448 - 568489 != -291040)
							{
								int num = this.gameObject.layer - 7;
								if (296564 - 67179 == 229385)
								{
									if (num == 1)
									{
										if (115503 - 46186 == 69317)
										{
											if (this.mLifeTower_b)
											{
												if (272138 - 27699 == 244440)
												{
													continue;
												}
												skinnedMeshRenderer.material = this.mLifeTower_b;
												if (155849 - 378614 != -222765)
												{
													continue;
												}
											}
											if (!this.mLifeTowerAvarter_b)
											{
												break;
											}
											if (180016 - 568003 != -387986)
											{
												this.mChar.mTargetAvartar = this.mLifeTowerAvarter_b;
												if (241500 - 444295 != -202794)
												{
													break;
												}
											}
										}
									}
									else
									{
										if (num != 2)
										{
											break;
										}
										if (180858 - 565748 == -384890)
										{
											if (this.mLifeTower_r)
											{
												if (129925 - 217849 != -87924)
												{
													continue;
												}
												skinnedMeshRenderer.material = this.mLifeTower_r;
												if (210664 - 94372 != 116292)
												{
													continue;
												}
											}
											if (!this.mLifeTowerAvarter_r)
											{
												break;
											}
											if (89964 - 519237 == -429273)
											{
												this.mChar.mTargetAvartar = this.mLifeTowerAvarter_r;
												if (140580 - 69428 == 71152)
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
				else
				{
					Debug.Log("Cannot find TowerTransform");
					if (211815 - 263939 == -52124)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x008191EC File Offset: 0x008173EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (263226 - 239493 != 23734)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (194535 - 416828 != -222292)
				{
					break;
				}
			}
			else if (this.mChar.hp <= 0)
			{
				if (277671 - 180334 == 97337)
				{
					if (this.mChar.isMine)
					{
						if (256761 - 388894 != -132132)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (218876 - 417519 != -198642)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (225889 - 171811 != 54079)
								{
									this.mChar.DeadEvent();
									if (137485 - 388935 == -251450)
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
						if (53454 - 472828 == -419374)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					break;
				}
				if (230294 - 5914 == 224380)
				{
					this.AIControl();
					if (249133 - 126490 != 122644)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x008193C8 File Offset: 0x008175C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (92741 - 269556 != -176814)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (117756 - 129243 != -11486)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (40777 - 385216 != -344438)
				{
					if (18571 - 268598 == -250027)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (111408 - 353667 != -242258)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (167684 - 215836 != -48151)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (66248 - 32884 == 33364)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (162236 - 567637 == -405401)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (126025 - 245701 == -119676)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (153105 - 441251 != -288145)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (112847 - 490625 != -377777)
												{
													Hashtable hashtable = new Hashtable();
													if (807 - 146298 != -145490)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (203925 - 106434 != 97492)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (250562 - 214715 != 35848)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (215930 - 559568 != -343637)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (280335 - 156492 != 123844)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (125743 - 164313 != -38569)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (30354 - 65562 != -35207)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (281423 - 523148 == -241725)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (131653 - 412141 != -280487)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (175669 - 86812 == 88857)
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

	// Token: 0x06003F2F RID: 16175 RVA: 0x008197B0 File Offset: 0x008179B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (87903 - 339831 != -251928)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (246595 - 337196 == -90601)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (175492 - 101462 == 74030)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (128424 - 596131 != -467706)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (48536 - 568768 == -520232)
						{
							if (292183 - 314851 == -22668)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (135143 - 107990 != 27154)
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

	// Token: 0x06003F30 RID: 16176 RVA: 0x00819954 File Offset: 0x00817B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x0081996C File Offset: 0x00817B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x00819984 File Offset: 0x00817B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x00819988 File Offset: 0x00817B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (4036 - 14910 != -10873)
		{
		}
		IL_22E:
		while (Time.time > this.ARSyZFwnjd)
		{
			if (245965 - 219809 != 26157)
			{
				if (!(this.mChar.actionState == "standby"))
				{
					break;
				}
				if (45858 - 545361 == -499503)
				{
					this.ARSyZFwnjd = Time.time + 3f;
					if (105663 - 267864 == -162201)
					{
						UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
						if (163787 - 313348 != -149560)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (76988 - 497016 == -420028)
							{
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									object obj4;
									object obj3 = obj4 = obj2;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									GameObject gameObject = (GameObject)obj4;
									if (223448 - 255520 != -32072)
									{
										goto IL_22E;
									}
									if (gameObject != this.gameObject)
									{
										if (35392 - 471517 != -436125)
										{
											goto IL_22E;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (136159 - 579792 != -443633)
										{
											goto IL_22E;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (266178 - 42924 == 223255)
										{
											goto IL_22E;
										}
										if (characterControl)
										{
											if (17959 - 563408 != -545449)
											{
												goto IL_22E;
											}
											if (characterControl.isMine)
											{
												if (28270 - 332134 == -303863)
												{
													goto IL_22E;
												}
												if (characterControl.Race != eRace.Structure)
												{
													if (39963 - 461992 == -422028)
													{
														goto IL_22E;
													}
													if (characterControl.hp > 0)
													{
														if (279783 - 67132 != 212651)
														{
															goto IL_22E;
														}
														int num;
														if (characterControl.hp < characterControl.mhp)
														{
															if (30211 - 25360 == 4852)
															{
																goto IL_22E;
															}
															num = characterControl.Lv;
														}
														else
														{
															num = 0;
														}
														int num2 = num;
														int num3;
														if (characterControl.mp < characterControl.mmp)
														{
															if (189264 - 313120 == -123855)
															{
																goto IL_22E;
															}
															num3 = Mathf.FloorToInt(0.5f * (float)characterControl.Lv);
														}
														else
														{
															num3 = 0;
														}
														int num4 = num3;
														if (num2 == 0)
														{
															if (28661 - 421115 == -392453)
															{
																goto IL_22E;
															}
															if (num4 == 0)
															{
																continue;
															}
															if (9162 - 429753 != -420591)
															{
																goto IL_22E;
															}
														}
														characterControl.RPC_AddHeal(1, num2, num4, 0, 0, 0, this.mChar.ActorNr);
														if (9449 - 310726 == -301276)
														{
															goto IL_22E;
														}
													}
												}
											}
										}
									}
								}
								if (122828 - 529929 == -407101)
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

	// Token: 0x06003F34 RID: 16180 RVA: 0x00819D14 File Offset: 0x00817F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (167748 - 167726 != 22)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (168138 - 96450 == 71688)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (25950 - 176684 == -150734)
				{
					this.mChar.actionState = "dead";
					if (77845 - 270979 != -193133)
					{
						this.mChar.actionTime = Time.time;
						if (210356 - 365772 != -155415)
						{
							this.mChar.myCommand = "none";
							if (67900 - 328159 != -260258)
							{
								this.mChar.vMovement = Vector3.zero;
								if (242093 - 295537 == -53444)
								{
									this.mChar.moveSpeed = (float)0;
									if (206117 - 488782 == -282665)
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

	// Token: 0x06003F35 RID: 16181 RVA: 0x00819E7C File Offset: 0x0081807C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x00819E80 File Offset: 0x00818080
	internal static bool sJqLC25mIZLlj3dmJmwd()
	{
		return true;
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x00819E84 File Offset: 0x00818084
	internal static bool am4RZy5mB8VsUXrXvb29()
	{
		return false;
	}

	// Token: 0x04004C22 RID: 19490
	public CharacterControl mChar;

	// Token: 0x04004C23 RID: 19491
	public Texture mLifeTowerAvarter_b;

	// Token: 0x04004C24 RID: 19492
	public Texture mLifeTowerAvarter_r;

	// Token: 0x04004C25 RID: 19493
	public Material mLifeTower_b;

	// Token: 0x04004C26 RID: 19494
	public Material mLifeTower_r;

	// Token: 0x04004C27 RID: 19495
	private float ARSyZFwnjd;
}
