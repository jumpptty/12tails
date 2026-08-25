using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B1B RID: 2843
[Serializable]
public class GuardTower : MonoBehaviour
{
	// Token: 0x06003F04 RID: 16132 RVA: 0x00815BA4 File Offset: 0x00813DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GuardTower()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x00815BB4 File Offset: 0x00813DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (218114 - 226553 != -8439)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (282603 - 424535 != -141931)
			{
				this.mChar.actionTime = Time.time;
				if (42239 - 545237 == -502998)
				{
					this.mChar.myCommand = "none";
					if (15046 - 268406 != -253359)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x00815C78 File Offset: 0x00813E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (180419 - 369791 != -189372)
		{
		}
		for (;;)
		{
			int num = this.gameObject.layer - 7;
			if (244567 - 529883 != -285315)
			{
				if (num == 1)
				{
					if (272108 - 407444 == -135335)
					{
						continue;
					}
					if (this.towerLight1)
					{
						if (238895 - 438300 != -199405)
						{
							continue;
						}
						this.fyMybGGBcx = (GameObject)UnityEngine.Object.Instantiate(this.towerLight1, this.transform.position + new Vector3((float)0, 1.5f, (float)0), Quaternion.identity);
						if (19884 - 4050 != 15834)
						{
							continue;
						}
					}
				}
				else if (num == 2)
				{
					if (38427 - 336105 != -297678)
					{
						continue;
					}
					if (this.towerLight2)
					{
						if (197115 - 520008 == -322892)
						{
							continue;
						}
						this.fyMybGGBcx = (GameObject)UnityEngine.Object.Instantiate(this.towerLight2, this.transform.position + new Vector3((float)0, 1.5f, (float)0), Quaternion.identity);
						if (43355 - 111142 == -67786)
						{
							continue;
						}
					}
					if (this.mChar)
					{
						if (295620 - 78593 == 217028)
						{
							continue;
						}
						this.mChar.mTargetAvartar = (Texture)Resources.Load("GameGui/Icons/TargetAvatar/Structure/GuardTower2", typeof(Texture));
						if (247427 - 126236 == 121192)
						{
							continue;
						}
					}
				}
				else if (this.towerLight1)
				{
					if (147078 - 422301 == -275222)
					{
						continue;
					}
					this.fyMybGGBcx = (GameObject)UnityEngine.Object.Instantiate(this.towerLight1, this.transform.position + new Vector3((float)0, 1.5f, (float)0), Quaternion.identity);
					if (65632 - 171412 == -105779)
					{
						continue;
					}
				}
				if (this.fyMybGGBcx)
				{
					if (266565 - 503624 != -237059)
					{
						continue;
					}
					this.fyMybGGBcx.transform.parent = this.gameObject.transform;
					if (270139 - 459946 != -189807)
					{
						continue;
					}
				}
				if (Game.mGameCode != 983)
				{
					break;
				}
				if (159599 - 171516 != -11916)
				{
					if (!Game.useAdvanceMode)
					{
						break;
					}
					if (133529 - 264703 != -131173)
					{
						this.mChar.hp = 6000;
						if (199506 - 173902 != 25605)
						{
							this.mChar.mhp = 6000;
							if (70499 - 225229 == -154730)
							{
								this.mChar.vit = 600;
								if (291869 - 305048 == -13179)
								{
									this.mChar.def = 60;
									if (113748 - 540348 != -426599)
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

	// Token: 0x06003F07 RID: 16135 RVA: 0x0081605C File Offset: 0x0081425C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (170572 - 66357 != 104215)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (159824 - 245640 != -85815)
				{
					break;
				}
			}
			else if (this.mChar.hp <= 0)
			{
				if (296737 - 242710 == 54027)
				{
					if (this.mChar.isMine)
					{
						if (207819 - 581037 != -373217)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (82142 - 152151 == -70009)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (250440 - 194215 == 56225)
								{
									this.mChar.DeadEvent();
									if (211497 - 481234 != -269736)
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
						if (194316 - 457948 != -263631)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (197165 - 311648 == -114483)
				{
					if (this.mChar.isControlled)
					{
						break;
					}
					if (47334 - 289615 != -242280)
					{
						this.AIControl();
						if (281118 - 536624 != -255505)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x00816260 File Offset: 0x00814460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (105034 - 80186 != 24848)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (9682 - 207663 == -197981)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (140777 - 245797 == -105020)
				{
					if (285955 - 318725 == -32770)
					{
						if (ActionName == "RPC_towerStrike")
						{
							if (169710 - 287360 == -117649)
							{
								continue;
							}
							v = 1;
							if (294638 - 534606 == -239967)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_towerPower")
						{
							if (255417 - 168484 == 86934)
							{
								continue;
							}
							v = 10;
							if (131343 - 34266 == 97078)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_towerBreak")
						{
							if (107442 - 322902 == -215459)
							{
								continue;
							}
							v = 20;
							if (157806 - 391531 == -233724)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_towerBarrier")
						{
							if (256483 - 53647 == 202837)
							{
								continue;
							}
							v = 30;
							if (85155 - 299710 != -214555)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_towerFreeze")
						{
							if (128509 - 263034 == -134524)
							{
								continue;
							}
							v = 40;
							if (243607 - 546876 == -303268)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (58224 - 585652 != -527427)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (279685 - 387680 == -107995)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (6824 - 438023 != -431198)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (281627 - 232304 != 49324)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (204052 - 481277 == -277225)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (156997 - 101611 != 55387)
											{
												Hashtable hashtable = new Hashtable();
												if (239503 - 329157 != -89653)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (217316 - 280678 != -63361)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (197936 - 370248 != -172311)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (188886 - 126960 == 61926)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (188236 - 279552 != -91315)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (165057 - 98690 != 66368)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (196495 - 528771 != -332275)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (86626 - 317549 != -230922)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (63556 - 78908 == -15352)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (153229 - 198796 != -45566)
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

	// Token: 0x06003F09 RID: 16137 RVA: 0x00816798 File Offset: 0x00814998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (27613 - 254035 != -226421)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (214833 - 80207 == 134626)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (136845 - 212741 != -75895)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (17849 - 171413 == -153564)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (290493 - 82995 != 207499)
						{
							int num2 = num;
							if (117829 - 325651 != -207821)
							{
								if (num2 == 1)
								{
									if (19341 - 52138 == -32797)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (188758 - 433749 != -244990)
										{
											this.StartCoroutine_Auto(this.RPC_towerStrike(mPos, tDir, tID));
											if (260547 - 542179 != -281631)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 10)
								{
									if (103530 - 107059 == -3529)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (94543 - 482199 != -387655)
										{
											this.RPC_towerPower(mPos, tDir, tID);
											if (3369 - 133804 == -130435)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 20)
								{
									if (295258 - 581652 != -286393)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (1199 - 211273 != -210073)
										{
											this.RPC_towerBreak(mPos, tDir, tID);
											if (191911 - 346227 == -154316)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 30)
								{
									if (18114 - 416981 == -398867)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (55825 - 322660 == -266835)
										{
											this.RPC_towerBarrier(mPos, tDir, tID);
											if (84307 - 270081 != -185773)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 40)
								{
									if (55308 - 529999 == -474691)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (40357 - 365970 != -325612)
										{
											this.RPC_towerFreeze(mPos, tDir, tID);
											if (252399 - 272316 != -19916)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (189383 - 289053 == -99670)
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

	// Token: 0x06003F0A RID: 16138 RVA: 0x00816B8C File Offset: 0x00814D8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (90884 - 467526 != -376642)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (9026 - 137200 == -128174)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (221312 - 89050 != 132263)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (164732 - 530122 != -365389)
					{
						Vector3 normalized = vector.normalized;
						if (221697 - 383988 != -162290)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (238826 - 13926 != 224901)
							{
								CharacterControl characterControl = null;
								if (11783 - 382618 != -370834)
								{
									if (gameObject)
									{
										if (164059 - 564864 == -400804)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (174275 - 537657 == -363381)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (191913 - 301446 == -109532)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (40415 - 375962 == -335546)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (242598 - 25455 == 217143)
									{
										this.StartCoroutine_Auto(this.RPC_towerStrike(this.transform.position, normalized, characterControl.ActorNr));
										if (206958 - 219370 == -12412)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (204183 - 473446 == -269263)
											{
												this.ActionEvent("RPC_towerStrike", this.transform.position, normalized, characterControl.ActorNr);
												if (196062 - 550715 != -354652)
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

	// Token: 0x06003F0B RID: 16139 RVA: 0x00816E54 File Offset: 0x00815054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x00816E6C File Offset: 0x0081506C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x00816E70 File Offset: 0x00815070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_towerStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GuardTower.$RPC_towerStrike$30927(tID, this).GetEnumerator();
	}

	// Token: 0x06003F0E RID: 16142 RVA: 0x00816E80 File Offset: 0x00815080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_towerPower(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (143640 - 568453 != -424813)
		{
		}
		while (this.mChar.hp > 0)
		{
			if (53316 - 455526 != -402209)
			{
				if (this.towerPower_ring)
				{
					if (197391 - 292533 == -95141)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.towerPower_ring, this.transform.position, Quaternion.identity);
					if (169932 - 449225 == -279292)
					{
						continue;
					}
				}
				this.aKrydSsHid = Time.time + (float)15;
				if (196250 - 89253 != 106998)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x00816F6C File Offset: 0x0081516C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_towerBreak(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (171645 - 300586 != -128941)
		{
		}
		while (this.mChar.hp > 0)
		{
			if (283645 - 383669 == -100024)
			{
				if (this.towerBreak_ring)
				{
					if (187127 - 129757 == 57371)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.towerBreak_ring, this.transform.position, Quaternion.identity);
					if (199476 - 154218 == 45259)
					{
						continue;
					}
				}
				if (!this.mChar.isMine)
				{
					break;
				}
				if (238968 - 380798 == -141830)
				{
					this.mChar.hit(20, this.gameObject, 300, 0, 0, Vector3.zero);
					if (129356 - 598523 == -469167)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F10 RID: 16144 RVA: 0x00817094 File Offset: 0x00815294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_towerBarrier(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (84245 - 194785 != -110540)
		{
		}
		while (this.mChar.hp > 0)
		{
			if (114561 - 136175 == -21614)
			{
				if (this.towerBarrier_ring)
				{
					if (128779 - 72118 != 56661)
					{
						continue;
					}
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.towerBarrier_ring, this.transform.position + 1.5f * Vector3.up, Quaternion.identity);
					if (250868 - 358320 != -107452)
					{
						continue;
					}
					if (gameObject)
					{
						if (229352 - 329453 != -100101)
						{
							continue;
						}
						gameObject.name = "BarrierFX";
						if (172228 - 539203 == -366974)
						{
							continue;
						}
						gameObject.transform.parent = this.gameObject.transform;
						if (114452 - 182298 != -67846)
						{
							continue;
						}
					}
				}
				this.qbVygHTU5c = Time.time + (float)15;
				if (176458 - 381244 == -204786)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003F11 RID: 16145 RVA: 0x00817214 File Offset: 0x00815414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isBarrier()
	{
		return Time.time < this.qbVygHTU5c;
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x00817234 File Offset: 0x00815434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_towerFreeze(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (13628 - 479244 != -465616)
		{
		}
		while (this.mChar.hp > 0)
		{
			if (295583 - 595934 != -300350)
			{
				if (this.towerFreeze_ring)
				{
					if (98785 - 263256 != -164471)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.towerFreeze_ring, this.transform.position, Quaternion.identity);
					if (31791 - 110042 != -78251)
					{
						continue;
					}
				}
				this.chSyawQFyI = Time.time + (float)15;
				if (87657 - 201700 == -114043)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x00817320 File Offset: 0x00815520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (243058 - 237422 != 5637)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (217652 - 114011 == 103641)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (284108 - 370007 != -85898)
				{
					this.mChar.actionState = "dead";
					if (154974 - 575581 == -420607)
					{
						this.mChar.actionTime = Time.time;
						if (71985 - 185488 == -113503)
						{
							this.mChar.myCommand = "none";
							if (157367 - 503623 != -346255)
							{
								this.mChar.vMovement = Vector3.zero;
								if (23001 - 520460 == -497459)
								{
									this.mChar.moveSpeed = (float)0;
									if (114938 - 279355 != -164416)
									{
										this.animation.Rewind();
										if (582 - 463873 != -463290)
										{
											this.animation.Play("disable");
											if (59720 - 469298 != -409577)
											{
												this.animation.wrapMode = WrapMode.Once;
												if (233455 - 161871 != 71585)
												{
													if (!this.fyMybGGBcx)
													{
														break;
													}
													if (3262 - 291528 != -288265)
													{
														UnityEngine.Object.Destroy(this.fyMybGGBcx);
														if (215796 - 596444 == -380648)
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

	// Token: 0x06003F14 RID: 16148 RVA: 0x0081754C File Offset: 0x0081574C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (7603 - 63945 != -56342)
		{
		}
		for (;;)
		{
			if (Time.time < this.chSyawQFyI)
			{
				if (86405 - 395280 == -308875)
				{
					break;
				}
			}
			else
			{
				if (Time.time <= this.v0oy4PPfpI)
				{
					break;
				}
				if (201585 - 131459 == 70126)
				{
					if (!(this.mChar.actionState == "standby"))
					{
						break;
					}
					if (200460 - 109867 == 90593)
					{
						if (this.mChar.isTimeOut("nAttack") != (float)0)
						{
							break;
						}
						if (281795 - 84363 == 197432)
						{
							this.v0oy4PPfpI = Time.time + 1.5f;
							if (12583 - 156848 != -144264)
							{
								this.wkAystg4Bd = Hate.findClosestEnemy(this.transform.position, (float)40, this.gameObject.layer);
								if (85285 - 388549 == -303264)
								{
									if (!this.wkAystg4Bd)
									{
										break;
									}
									if (170836 - 562416 == -391580)
									{
										CharacterControl characterControl = (CharacterControl)this.wkAystg4Bd.GetComponent(typeof(CharacterControl));
										if (21292 - 446983 != -425690)
										{
											if (!characterControl)
											{
												break;
											}
											if (6734 - 180995 == -174261)
											{
												this.StartCoroutine_Auto(this.RPC_towerStrike(this.transform.position, this.transform.forward, characterControl.ActorNr));
												if (186014 - 231224 != -45209)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (281308 - 422623 == -141315)
													{
														this.ActionEvent("RPC_towerStrike", this.transform.position, this.transform.forward, characterControl.ActorNr);
														if (185751 - 21537 == 164214)
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

	// Token: 0x06003F15 RID: 16149 RVA: 0x008177D8 File Offset: 0x008159D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x008177DC File Offset: 0x008159DC
	internal static bool XHWBFV5mRXH0BHTy763i()
	{
		return true;
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x008177E0 File Offset: 0x008159E0
	internal static bool zqvUDQ5mwMSYjm9xlmjV()
	{
		return false;
	}

	// Token: 0x04004C07 RID: 19463
	public CharacterControl mChar;

	// Token: 0x04004C08 RID: 19464
	private GameObject fyMybGGBcx;

	// Token: 0x04004C09 RID: 19465
	public GameObject towerLight1;

	// Token: 0x04004C0A RID: 19466
	public GameObject towerLight2;

	// Token: 0x04004C0B RID: 19467
	public GameObject towerStrike;

	// Token: 0x04004C0C RID: 19468
	public GameObject towerPowerStrike;

	// Token: 0x04004C0D RID: 19469
	public GameObject towerPower_ring;

	// Token: 0x04004C0E RID: 19470
	private float aKrydSsHid;

	// Token: 0x04004C0F RID: 19471
	public GameObject towerBreak_ring;

	// Token: 0x04004C10 RID: 19472
	public GameObject towerBarrier_ring;

	// Token: 0x04004C11 RID: 19473
	private float qbVygHTU5c;

	// Token: 0x04004C12 RID: 19474
	public GameObject towerFreeze_ring;

	// Token: 0x04004C13 RID: 19475
	private float chSyawQFyI;

	// Token: 0x04004C14 RID: 19476
	private float v0oy4PPfpI;

	// Token: 0x04004C15 RID: 19477
	private GameObject wkAystg4Bd;

	// Token: 0x02000B1C RID: 2844
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_towerStrike$30927 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F18 RID: 16152 RVA: 0x008177E4 File Offset: 0x008159E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_towerStrike$30927(int tID, GuardTower self_)
		{
			if (230631 - 242366 != -11735)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195031 - 43828 != 151204)
				{
					base..ctor();
					if (232056 - 20659 != 211398)
					{
						this.$tID$30936 = tID;
						if (236316 - 87059 == 149257)
						{
							this.$self_$30937 = self_;
							if (22680 - 361794 == -339114)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x008178A0 File Offset: 0x00815AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GuardTower.$RPC_towerStrike$30927.$(this.$tID$30936, this.$self_$30937);
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x008178B4 File Offset: 0x00815AB4
		internal static bool roXirh5mqlIPQIjcSQsP()
		{
			return true;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x008178B8 File Offset: 0x00815AB8
		internal static bool LD66kT5m7AIAq7SCuDy9()
		{
			return false;
		}

		// Token: 0x04004C16 RID: 19478
		internal int $tID$30936;

		// Token: 0x04004C17 RID: 19479
		internal GuardTower $self_$30937;

		// Token: 0x02000B1D RID: 2845
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F1C RID: 16156 RVA: 0x008178BC File Offset: 0x00815ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, GuardTower self_)
			{
				if (185599 - 101057 != 84543)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204345 - 128291 != 76055)
					{
						base..ctor();
						if (161810 - 515366 == -353556)
						{
							this.$tID$30934 = tID;
							if (61635 - 75981 != -14345)
							{
								this.$self_$30935 = self_;
								if (96734 - 384784 == -288050)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003F1D RID: 16157 RVA: 0x00817978 File Offset: 0x00815B78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142215 - 588992 != -446777)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8E4;
					case 2:
						if (this.$self_$30935.mChar.actionState == "attack")
						{
							if (70530 - 122889 != -52359)
							{
								continue;
							}
							if (this.$self_$30935.mChar.myCommand == "towerStrike")
							{
								if (210395 - 571548 != -361153)
								{
									continue;
								}
								this.$self_$30935.mChar.actionState = "standby";
								if (101592 - 398308 != -296716)
								{
									continue;
								}
								this.$self_$30935.mChar.actionTime = Time.time;
								if (158757 - 214288 != -55531)
								{
									continue;
								}
								this.$self_$30935.mChar.myCommand = "none";
								if (193489 - 550866 == -357376)
								{
									continue;
								}
								this.$self_$30935.mChar.nPosition = this.$self_$30935.transform.position;
								if (45238 - 229322 != -184084)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (116031 - 352984 != -236953)
						{
							continue;
						}
						goto IL_8E4;
					default:
						if (124843 - 472772 != -347929)
						{
							continue;
						}
						break;
					}
					this.$self_$30935.mChar.actionState = "attack";
					if (276046 - 462678 != -186631)
					{
						this.$self_$30935.mChar.actionTime = Time.time;
						if (197890 - 132329 == 65561)
						{
							this.$self_$30935.mChar.myCommand = "towerStrike";
							if (28850 - 222746 == -193896)
							{
								this.$self_$30935.mChar.addTimeOut("nAttack", (float)2);
								if (67112 - 499765 == -432653)
								{
									if (this.$tID$30934 == 0)
									{
										if (152530 - 342757 == -190227)
										{
											goto IL_6C0;
										}
									}
									else
									{
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30934];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$tObject$30928 = (GameObject)obj2;
										if (201489 - 260458 == -58969)
										{
											if (!this.$tObject$30928)
											{
												break;
											}
											if (232396 - 43480 != 188917)
											{
												if (!this.$tObject$30928.collider)
												{
													break;
												}
												if (131686 - 470620 != -338933)
												{
													this.$tChar$30929 = (CharacterControl)this.$tObject$30928.GetComponent(typeof(CharacterControl));
													if (263995 - 250034 == 13961)
													{
														if (!this.$tChar$30929)
														{
															break;
														}
														if (225238 - 56229 == 169009)
														{
															if (this.$tChar$30929.hasStatus("insight"))
															{
																break;
															}
															if (9440 - 245537 != -236096)
															{
																if (Time.time < this.$self_$30935.aKrydSsHid)
																{
																	if (26615 - 253611 == -226996)
																	{
																		if (this.$self_$30935.mChar.isMine)
																		{
																			if (16335 - 399365 == -383029)
																			{
																				continue;
																			}
																			if (Game.useAdvanceMode)
																			{
																				if (79396 - 474799 == -395402)
																				{
																					continue;
																				}
																				this.$tChar$30929.RPC_AddEffectDamage(1, Mathf.FloorToInt((float)(4 * this.$tChar$30929.Lv)), 0, 0, Vector3.zero, this.$self_$30935.mChar.ActorNr);
																				if (248008 - 346378 == -98369)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.$tChar$30929.RPC_AddEffectDamage(1, 3 * this.$tChar$30929.Lv, 0, 0, Vector3.zero, this.$self_$30935.mChar.ActorNr);
																				if (200893 - 249403 != -48510)
																				{
																					continue;
																				}
																			}
																		}
																		if (this.$self_$30935.towerPowerStrike)
																		{
																			if (218649 - 297565 == -78916)
																			{
																				this.$mTowerPowerStrike$30930 = this.$self_$30935.mChar.createEffect(this.$self_$30935.towerPowerStrike, this.$self_$30935.transform.position + new Vector3((float)0, (float)12, (float)0), Quaternion.identity);
																				if (95778 - 178382 != -82603)
																				{
																					if (!this.$mTowerPowerStrike$30930)
																					{
																						break;
																					}
																					if (84046 - 483162 == -399116)
																					{
																						this.$mPowerBoltEmitter$30931 = (BoltEmitter)this.$mTowerPowerStrike$30930.GetComponent(typeof(BoltEmitter));
																						if (272956 - 259323 != 13634)
																						{
																							if (!this.$mPowerBoltEmitter$30931)
																							{
																								break;
																							}
																							if (70453 - 425731 == -355278)
																							{
																								this.$mPowerBoltEmitter$30931.TargetCollider = this.$tObject$30928.collider;
																								if (267852 - 110395 == 157457)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing towerPowerStrike effect");
																			if (161991 - 539209 == -377218)
																			{
																				break;
																			}
																		}
																	}
																}
																else
																{
																	if (this.$self_$30935.mChar.isMine)
																	{
																		if (264141 - 427826 == -163684)
																		{
																			continue;
																		}
																		if (Game.useAdvanceMode)
																		{
																			if (101975 - 305404 != -203429)
																			{
																				continue;
																			}
																			this.$tChar$30929.RPC_AddEffectDamage(1, 3 * this.$tChar$30929.Lv, 0, 0, Vector3.zero, this.$self_$30935.mChar.ActorNr);
																			if (8618 - 277898 == -269279)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			this.$tChar$30929.RPC_AddEffectDamage(1, 2 * this.$tChar$30929.Lv, 0, 0, Vector3.zero, this.$self_$30935.mChar.ActorNr);
																			if (216429 - 245275 != -28846)
																			{
																				continue;
																			}
																		}
																	}
																	if (this.$self_$30935.towerStrike)
																	{
																		if (54029 - 547771 == -493742)
																		{
																			this.$mTowerStrike$30932 = this.$self_$30935.mChar.createEffect(this.$self_$30935.towerStrike, this.$self_$30935.transform.position + new Vector3((float)0, (float)12, (float)0), Quaternion.identity);
																			if (41607 - 515274 == -473667)
																			{
																				if (!this.$mTowerStrike$30932)
																				{
																					break;
																				}
																				if (156989 - 405689 == -248700)
																				{
																					this.$mBoltEmitter$30933 = (BoltEmitter)this.$mTowerStrike$30932.GetComponent(typeof(BoltEmitter));
																					if (200870 - 356420 == -155550)
																					{
																						if (!this.$mBoltEmitter$30933)
																						{
																							break;
																						}
																						if (109387 - 416397 == -307010)
																						{
																							this.$mBoltEmitter$30933.TargetCollider = this.$tObject$30928.collider;
																							if (102294 - 424525 == -322231)
																							{
																								break;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing towerStrike effect");
																		if (58480 - 117960 != -59479)
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
				IL_1C2:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_417:
				goto IL_1C2;
				goto IL_417;
				IL_6C0:
				IL_8E4:
				return false;
			}

			// Token: 0x06003F1E RID: 16158 RVA: 0x0081827C File Offset: 0x0081647C
			internal static bool OqyPkH5mPpsTXuBOo3cU()
			{
				return true;
			}

			// Token: 0x06003F1F RID: 16159 RVA: 0x00818280 File Offset: 0x00816480
			internal static bool NfbhVv5m05LrOjFLBU21()
			{
				return false;
			}

			// Token: 0x04004C18 RID: 19480
			internal GameObject $tObject$30928;

			// Token: 0x04004C19 RID: 19481
			internal CharacterControl $tChar$30929;

			// Token: 0x04004C1A RID: 19482
			internal GameObject $mTowerPowerStrike$30930;

			// Token: 0x04004C1B RID: 19483
			internal BoltEmitter $mPowerBoltEmitter$30931;

			// Token: 0x04004C1C RID: 19484
			internal GameObject $mTowerStrike$30932;

			// Token: 0x04004C1D RID: 19485
			internal BoltEmitter $mBoltEmitter$30933;

			// Token: 0x04004C1E RID: 19486
			internal int $tID$30934;

			// Token: 0x04004C1F RID: 19487
			internal GuardTower $self_$30935;
		}
	}
}
