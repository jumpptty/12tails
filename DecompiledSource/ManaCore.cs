using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B23 RID: 2851
[Serializable]
public class ManaCore : MonoBehaviour
{
	// Token: 0x06003F52 RID: 16210 RVA: 0x0081B830 File Offset: 0x00819A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ManaCore()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x0081B840 File Offset: 0x00819A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (228040 - 19495 != 208545)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (228116 - 452017 != -223900)
			{
				this.mChar.actionTime = Time.time;
				if (69414 - 446011 != -376596)
				{
					this.mChar.myCommand = "none";
					if (213574 - 196730 == 16844)
					{
						if (Game.mGameCode != 983)
						{
							break;
						}
						if (237904 - 295208 == -57304)
						{
							this.mGuardTowerCount = 10;
							if (157623 - 200321 == -42698)
							{
								if (!Game.useAdvanceMode)
								{
									break;
								}
								if (2198 - 332031 == -329833)
								{
									this.mChar.hp = 18000;
									if (102896 - 205658 != -102761)
									{
										this.mChar.mhp = 18000;
										if (132973 - 202486 == -69513)
										{
											this.mChar.vit = 1800;
											if (71316 - 322879 == -251563)
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

	// Token: 0x06003F54 RID: 16212 RVA: 0x0081B9F0 File Offset: 0x00819BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (278514 - 26170 != 252345)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (105297 - 542470 == -437173)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.hp <= 0)
				{
					if (126534 - 540468 != -413934)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (95109 - 576123 != -481014)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (206209 - 435527 != -229318)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (201488 - 444965 != -243477)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (214003 - 234051 != -20048)
							{
								continue;
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (100450 - 28855 == 71596)
						{
							continue;
						}
					}
				}
				else if (!this.mChar.isControlled)
				{
					if (11261 - 533834 != -522573)
					{
						continue;
					}
					this.AIControl();
					if (1322 - 548303 != -546981)
					{
						continue;
					}
				}
				if (Game.mGameCode != 983)
				{
					break;
				}
				if (73012 - 133815 != -60802)
				{
					this.mChar.def = 100 + this.mGuardTowerCount * 50;
					if (121978 - 134081 != -12102)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x0081BC24 File Offset: 0x00819E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (204514 - 416276 != -211762)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (144310 - 570006 != -425695)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (106614 - 19031 == 87583)
				{
					if (54914 - 387211 != -332296)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (143461 - 427639 != -284177)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (23592 - 121653 == -98061)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (210027 - 397634 != -187606)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (152595 - 585783 == -433188)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (58952 - 14135 != 44818)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (106679 - 63926 == 42753)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (197657 - 430589 != -232931)
												{
													Hashtable hashtable = new Hashtable();
													if (152804 - 292761 == -139957)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (109974 - 589184 != -479209)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (104745 - 464085 == -359340)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (220469 - 573539 != -353069)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (107722 - 576199 != -468476)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (43954 - 67799 == -23845)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (120697 - 193685 != -72987)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (145685 - 553852 != -408166)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (118309 - 347472 == -229163)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (97210 - 371631 != -274420)
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

	// Token: 0x06003F56 RID: 16214 RVA: 0x0081C00C File Offset: 0x0081A20C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (130501 - 542957 != -412455)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (240395 - 154037 != 86359)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (244841 - 10238 == 234603)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (3298 - 377012 == -373714)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (41408 - 387680 != -346271)
						{
							if (168345 - 7665 == 160680)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (29656 - 401018 == -371362)
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

	// Token: 0x06003F57 RID: 16215 RVA: 0x0081C1B0 File Offset: 0x0081A3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x0081C1C8 File Offset: 0x0081A3C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x0081C1E0 File Offset: 0x0081A3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x0081C1E4 File Offset: 0x0081A3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (258813 - 114761 != 144052)
		{
		}
		IL_65:
		while (Time.time > this.gYAyw4NTlI)
		{
			if (234551 - 452551 != -217999)
			{
				if (!(this.mChar.actionState == "standby"))
				{
					break;
				}
				if (282718 - 29046 != 253673)
				{
					this.gYAyw4NTlI = Time.time + 3f;
					if (236615 - 146110 != 90506)
					{
						UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
						if (211440 - 129971 != 81470)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (118247 - 446032 == -327785)
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
									if (45810 - 296279 == -250468)
									{
										goto IL_65;
									}
									if (gameObject != this.gameObject)
									{
										if (268419 - 284403 != -15984)
										{
											goto IL_65;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (258627 - 191256 == 67372)
										{
											goto IL_65;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (232108 - 327105 != -94997)
										{
											goto IL_65;
										}
										if (characterControl)
										{
											if (170841 - 491333 == -320491)
											{
												goto IL_65;
											}
											if (characterControl.isMine)
											{
												if (297852 - 97846 != 200006)
												{
													goto IL_65;
												}
												if (characterControl.Race != eRace.Structure)
												{
													if (274842 - 159039 != 115803)
													{
														goto IL_65;
													}
													if (characterControl.hp > 0)
													{
														if (55019 - 313020 != -258001)
														{
															goto IL_65;
														}
														int num;
														if (characterControl.hp < characterControl.mhp)
														{
															if (200273 - 66149 == 134125)
															{
																goto IL_65;
															}
															num = 100;
														}
														else
														{
															num = 0;
														}
														int num2 = num;
														int num3;
														if (characterControl.mp < characterControl.mmp)
														{
															if (106794 - 455147 != -348353)
															{
																goto IL_65;
															}
															num3 = 30;
														}
														else
														{
															num3 = 0;
														}
														int num4 = num3;
														if (num2 == 0)
														{
															if (9972 - 224471 == -214498)
															{
																goto IL_65;
															}
															if (num4 == 0)
															{
																continue;
															}
															if (1818 - 64627 == -62808)
															{
																goto IL_65;
															}
														}
														characterControl.RPC_AddHeal(1, num2, num4, 0, 0, 0, this.mChar.ActorNr);
														if (271732 - 335642 == -63909)
														{
															goto IL_65;
														}
													}
												}
											}
										}
									}
								}
								if (257844 - 144628 != 113217)
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

	// Token: 0x06003F5B RID: 16219 RVA: 0x0081C55C File Offset: 0x0081A75C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (235840 - 462150 != -226309)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (133429 - 435205 != -301775)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (260147 - 182513 != 77635)
				{
					this.mChar.actionState = "dead";
					if (161908 - 393747 != -231838)
					{
						this.mChar.actionTime = Time.time;
						if (74182 - 599344 != -525161)
						{
							this.mChar.myCommand = "none";
							if (186308 - 475117 == -288809)
							{
								this.mChar.vMovement = Vector3.zero;
								if (267069 - 376732 == -109663)
								{
									this.mChar.moveSpeed = (float)0;
									if (10130 - 509952 == -499822)
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

	// Token: 0x06003F5C RID: 16220 RVA: 0x0081C6C4 File Offset: 0x0081A8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x0081C6C8 File Offset: 0x0081A8C8
	internal static bool yda5tr5m1lvP9reXji14()
	{
		return true;
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x0081C6CC File Offset: 0x0081A8CC
	internal static bool LiEebp5m4D06wUEhZLm1()
	{
		return false;
	}

	// Token: 0x04004C36 RID: 19510
	public CharacterControl mChar;

	// Token: 0x04004C37 RID: 19511
	public int mGuardTowerCount;

	// Token: 0x04004C38 RID: 19512
	private float gYAyw4NTlI;
}
