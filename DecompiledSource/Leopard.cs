using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CC9 RID: 3273
[Serializable]
public class Leopard : MonoBehaviour
{
	// Token: 0x0600497A RID: 18810 RVA: 0x0091C1D8 File Offset: 0x0091A3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Leopard()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600497B RID: 18811 RVA: 0x0091C1E8 File Offset: 0x0091A3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (64847 - 589600 != -524752)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (223152 - 131712 != 91441)
			{
				this.mChar.actionState = "standby";
				if (230916 - 59191 != 171726)
				{
					this.mChar.actionTime = Time.time;
					if (93447 - 544889 == -451442)
					{
						this.mChar.myCommand = "none";
						if (169586 - 113510 == 56076)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600497C RID: 18812 RVA: 0x0091C2D4 File Offset: 0x0091A4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600497D RID: 18813 RVA: 0x0091C2F0 File Offset: 0x0091A4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (95143 - 252578 != -157435)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (178896 - 177865 == 1032)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (115583 - 449355 == -333771)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_360;
					}
					if (190398 - 480139 != -289741)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (207656 - 514827 != -307171)
				{
					continue;
				}
			}
			IL_360:
			if (this.mChar.hp <= 0)
			{
				if (268121 - 485369 != -217248)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (175132 - 111181 == 63952)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (278828 - 544484 == -265655)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (71205 - 392234 != -321029)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (26198 - 117395 != -91197)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (89296 - 305120 != -215823)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (158659 - 196118 != -37458)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (158801 - 68621 == 90180)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (182778 - 21364 != 161415)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (292852 - 389243 != -96390)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (27994 - 515368 != -487373)
						{
							if (this.mChar.isMine)
							{
								if (150538 - 332192 == -181654)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (110943 - 270547 != -159603)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (82182 - 164706 != -82523)
										{
											this.mChar.KoEvent();
											if (53252 - 233803 != -180550)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (146252 - 507540 != -361287)
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

	// Token: 0x0600497E RID: 18814 RVA: 0x0091C6E8 File Offset: 0x0091A8E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (149150 - 204876 != -55726)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (107088 - 53824 == 53264)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (16144 - 210035 != -193890)
				{
					if (172445 - 394284 == -221839)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (89520 - 536298 == -446777)
							{
								continue;
							}
							v = 1;
							if (260670 - 418336 != -157666)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (31002 - 166747 != -135745)
							{
								continue;
							}
							v = -1;
							if (81350 - 588072 == -506721)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leoSmash")
						{
							if (268511 - 583043 != -314532)
							{
								continue;
							}
							v = 11;
							if (258942 - 114322 == 144621)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (180831 - 566128 != -385297)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (255246 - 139476 == 115770)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (207363 - 43557 == 163806)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (130927 - 165910 != -34982)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (10729 - 400854 == -390125)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (246868 - 538921 == -292053)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (100622 - 479215 != -378592)
											{
												Hashtable hashtable = new Hashtable();
												if (224062 - 8646 == 215416)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (80860 - 232571 != -151710)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (276436 - 410112 == -133676)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (263289 - 108987 != 154303)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (99973 - 504640 != -404666)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (155531 - 403561 == -248030)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (202858 - 552444 == -349586)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (51527 - 222459 != -170931)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (235713 - 75535 != 160179)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (270568 - 32105 != 238464)
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

	// Token: 0x0600497F RID: 18815 RVA: 0x0091CBB4 File Offset: 0x0091ADB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (289167 - 201769 != 87398)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (73519 - 464039 == -390520)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (286836 - 112005 != 174832)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (286539 - 83085 != 203455)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (133381 - 356649 != -223267)
						{
							int num3 = num;
							if (152642 - 297470 != -144827)
							{
								if (num3 == 1)
								{
									if (98231 - 506952 == -408721)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (257462 - 73277 == 184185)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (18644 - 169914 == -151270)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (40728 - 251736 != -211007)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (182132 - 417526 == -235394)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (111609 - 373751 == -262142)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (188003 - 46437 != 141567)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (22584 - 459119 != -436534)
										{
											this.StartCoroutine_Auto(this.RPC_leoSmash(vector, vector2, num2));
											if (248516 - 551370 != -302853)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (95243 - 37010 != 58234)
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

	// Token: 0x06004980 RID: 18816 RVA: 0x0091CEC4 File Offset: 0x0091B0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (192868 - 404560 != -211692)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (39703 - 77276 != -37572)
			{
				float runSpeed = this.mChar.runSpeed;
				if (229673 - 546192 != -316518)
				{
					Vector3 a = default(Vector3);
					if (258259 - 585219 != -326959)
					{
						Vector3 vector = Vector3.zero;
						if (75592 - 341645 != -266052)
						{
							float num2 = (float)0;
							if (78860 - 19280 == 59580)
							{
								if (this.mChar.isMine)
								{
									if (120931 - 298076 != -177145)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (145745 - 348848 != -203103)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (117388 - 556105 != -438717)
										{
											continue;
										}
										a.y = (float)0;
										if (174022 - 409062 != -235040)
										{
											continue;
										}
										a = a.normalized;
										if (165187 - 542434 == -377246)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (138965 - 201084 == -62118)
										{
											continue;
										}
										vector = vector.normalized;
										if (253661 - 11471 == 242191)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (217292 - 468804 == -251511)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (231549 - 72152 != 159397)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (81454 - 122697 != -41243)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (12880 - 223041 == -210160)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (148962 - 361252 != -212290)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (118940 - 566469 != -447529)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (40400 - 415797 == -375396)
														{
															continue;
														}
														this.animation.Play("run");
														if (129422 - 304036 != -174614)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (188453 - 176222 != 12232)
														{
															goto IL_AC3;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (217796 - 364286 == -146489)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (192372 - 485815 == -293442)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (293191 - 68140 == 225052)
											{
												continue;
											}
											num = (float)0;
											if (16548 - 267076 != -250528)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (182072 - 255082 != -73010)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (267111 - 325734 != -58623)
										{
											continue;
										}
									}
									IL_AC3:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (115507 - 587487 == -471979)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (117042 - 323145 != -206103)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (263676 - 303370 == -39693)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (133970 - 362674 == -228703)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (210476 - 193747 != 16729)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (120438 - 32459 == 87980)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (54549 - 286592 == -232042)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (218425 - 563963 != -345538)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (24665 - 412553 != -387888)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (137703 - 6761 != 130942)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (109276 - 89239 != 20037)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (60793 - 337615 == -276821)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (272460 - 521742 == -249281)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (66769 - 110421 == -43651)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (145215 - 329548 == -184332)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (121689 - 173893 == -52203)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (228991 - 73757 == 155235)
												{
													continue;
												}
												num = (float)0;
												if (151832 - 294037 != -142205)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (109566 - 221625 != -112059)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (71944 - 356707 != -284763)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (287534 - 555577 != -268043)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (275025 - 582936 != -307911)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (126150 - 4147 == 122004)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (48806 - 270671 == -221864)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (45190 - 79651 == -34460)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (256608 - 308491 != -51883)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (25775 - 16943 == 8833)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (61860 - 504547 == -442686)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (114422 - 60662 == 53761)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (128453 - 43932 != 84521)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (124068 - 557065 == -432996)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (189183 - 115936 == 73248)
											{
												continue;
											}
											num = (float)0;
											if (290736 - 90486 != 200250)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (264841 - 511158 != -246317)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187042 - 306782 == -119739)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (53846 - 256779 != -202933)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (283955 - 173051 != 110904)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (110741 - 497718 != -386976)
								{
									this.mChar.moveSpeed = num;
									if (200071 - 24818 != 175254)
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

	// Token: 0x06004981 RID: 18817 RVA: 0x0091DA28 File Offset: 0x0091BC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (297328 - 253150 != 44178)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (183031 - 381457 != -198425)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (73482 - 524021 == -450539)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (211396 - 110116 != 101281)
					{
						Vector3 vector2 = vector.normalized;
						if (103320 - 481023 != -377702)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (206472 - 441266 != -234793)
							{
								if (132335 - 159626 == -27291)
								{
									if (gameObject)
									{
										if (112299 - 167268 != -54969)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (289712 - 24321 != 265391)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (290345 - 464022 != -173677)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (87451 - 400346 != -312895)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (24036 - 377968 == -353932)
									{
										if (gameObject == this.gameObject)
										{
											if (71854 - 145418 != -73564)
											{
												continue;
											}
											vector2 = this.transform.forward;
											if (86192 - 568700 != -482508)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
										if (187813 - 335652 == -147839)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (228920 - 153258 != 75663)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
												if (51043 - 107505 != -56461)
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

	// Token: 0x06004982 RID: 18818 RVA: 0x0091DD38 File Offset: 0x0091BF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (27760 - 267725 != -239965)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (119658 - 570211 == -450553)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (170366 - 93782 != 76585)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (286423 - 255098 == 31325)
					{
						Vector3 normalized = vector.normalized;
						if (109848 - 583734 != -473885)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (78823 - 581335 != -502511)
							{
								CharacterControl characterControl = null;
								if (34159 - 160596 != -126436)
								{
									int tID = 0;
									if (37946 - 34352 == 3594)
									{
										if (gameObject)
										{
											if (190945 - 333800 == -142854)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (40547 - 13919 != 26628)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (104510 - 424404 != -319894)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (30991 - 128895 == -97903)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (126619 - 538127 == -411507)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (198063 - 389927 == -191863)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("leoSmash") != (float)0)
										{
											if (81761 - 566694 == -484933)
											{
												Camera.main.SendMessage("newGameMessage", "leoSmash is not ready");
												if (243367 - 382034 == -138667)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_leoSmash(this.transform.position, normalized, tID));
											if (145914 - 490813 != -344898)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (78547 - 87917 != -9369)
												{
													this.ActionEvent("RPC_leoSmash", this.transform.position, normalized, tID);
													if (207269 - 463047 == -255778)
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

	// Token: 0x06004983 RID: 18819 RVA: 0x0091E090 File Offset: 0x0091C290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x0091E094 File Offset: 0x0091C294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Leopard.$RPC_nAttack$32605(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x0091E0A4 File Offset: 0x0091C2A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (160164 - 565965 != -405801)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
			if (89656 - 389283 != -299626)
			{
				if (this.gGXzK896gN >= Time.time)
				{
					break;
				}
				if (135750 - 114751 == 20999)
				{
					this.gGXzK896gN = Time.time + 0.2f;
					if (44540 - 557420 != -512879)
					{
						if (!this.nAttack_hitFx)
						{
							break;
						}
						if (78251 - 248845 != -170593)
						{
							this.audio.PlayOneShot(this.nAttack_hitFx);
							if (107558 - 99541 != 8018)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x0091E1B4 File Offset: 0x0091C3B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leoSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Leopard.$RPC_leoSmash$32617(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004987 RID: 18823 RVA: 0x0091E1C4 File Offset: 0x0091C3C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Leopard.$RPC_ko$32629(nArray, this).GetEnumerator();
	}

	// Token: 0x06004988 RID: 18824 RVA: 0x0091E1D4 File Offset: 0x0091C3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Leopard.$RPC_dead$32636(nArray, this).GetEnumerator();
	}

	// Token: 0x06004989 RID: 18825 RVA: 0x0091E1E4 File Offset: 0x0091C3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x0091E1E8 File Offset: 0x0091C3E8
	internal static bool RnvOIt5RnU65GcvWxseQ()
	{
		return true;
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x0091E1EC File Offset: 0x0091C3EC
	internal static bool ikJ4Jg5R60YUMX8hXfwW()
	{
		return false;
	}

	// Token: 0x04005444 RID: 21572
	public CharacterControl mChar;

	// Token: 0x04005445 RID: 21573
	public GameObject nAttack_hit;

	// Token: 0x04005446 RID: 21574
	public AudioClip nAttack_hitFx;

	// Token: 0x04005447 RID: 21575
	private float gGXzK896gN;

	// Token: 0x02000CCA RID: 3274
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32605 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600498C RID: 18828 RVA: 0x0091E1F0 File Offset: 0x0091C3F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32605(Vector3 mPos, Vector3 tDir, Leopard self_)
		{
			if (37043 - 240717 != -203673)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138304 - 320684 != -182379)
				{
					base..ctor();
					if (3745 - 218708 != -214962)
					{
						this.$mPos$32614 = mPos;
						if (243125 - 218336 != 24790)
						{
							this.$tDir$32615 = tDir;
							if (157269 - 574451 == -417182)
							{
								this.$self_$32616 = self_;
								if (121630 - 153458 == -31828)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x0091E2CC File Offset: 0x0091C4CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Leopard.$RPC_nAttack$32605.$(this.$mPos$32614, this.$tDir$32615, this.$self_$32616);
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x0091E2E8 File Offset: 0x0091C4E8
		internal static bool conSet5RiwomKjdls3tj()
		{
			return true;
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x0091E2EC File Offset: 0x0091C4EC
		internal static bool zvYFBi5RKv26SYEmtyJ7()
		{
			return false;
		}

		// Token: 0x04005448 RID: 21576
		internal Vector3 $mPos$32614;

		// Token: 0x04005449 RID: 21577
		internal Vector3 $tDir$32615;

		// Token: 0x0400544A RID: 21578
		internal Leopard $self_$32616;

		// Token: 0x02000CCB RID: 3275
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004990 RID: 18832 RVA: 0x0091E2F0 File Offset: 0x0091C4F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Leopard self_)
			{
				if (62205 - 451070 != -388864)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169807 - 30525 != 139283)
					{
						base..ctor();
						if (283285 - 202990 != 80296)
						{
							this.$mPos$32611 = mPos;
							if (281069 - 588252 != -307182)
							{
								this.$tDir$32612 = tDir;
								if (155638 - 409360 != -253721)
								{
									this.$self_$32613 = self_;
									if (98439 - 407004 == -308565)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004991 RID: 18833 RVA: 0x0091E3CC File Offset: 0x0091C5CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242357 - 235519 != 6839)
				{
				}
				for (;;)
				{
					IL_612:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_936;
					case 2:
						if (this.$self_$32613.mChar.actionState != "attack")
						{
							goto IL_A5;
						}
						if (206829 - 533055 != -326226)
						{
							continue;
						}
						if (this.$self_$32613.mChar.myCommand != "nAttack")
						{
							if (204119 - 553112 != -348992)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$self_$32613.mChar.moveSpeed = (float)2;
							if (33571 - 464352 != -430780)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32613.mChar.actionState != "attack")
						{
							goto IL_6C0;
						}
						if (28671 - 101583 != -72912)
						{
							continue;
						}
						if (this.$self_$32613.mChar.myCommand != "nAttack")
						{
							if (75697 - 529931 != -454233)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$self_$32613.mChar.moveSpeed = (float)4;
							if (244869 - 196838 != 48032)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32613.mChar.actionState != "attack")
						{
							goto IL_68F;
						}
						if (209710 - 465415 == -255704)
						{
							continue;
						}
						if (this.$self_$32613.mChar.myCommand != "nAttack")
						{
							if (285234 - 523288 != -238053)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$self_$32613.mChar.moveSpeed = (float)0;
							if (298356 - 146181 != 152175)
							{
								continue;
							}
							if (!this.$self_$32613.mChar.isMine)
							{
								goto IL_1D6;
							}
							if (80081 - 293215 != -213134)
							{
								continue;
							}
							this.$hitLayer$32606 = 130816 - (1 << this.$self_$32613.gameObject.layer);
							if (209595 - 168523 != 41072)
							{
								continue;
							}
							this.$hitList$32607 = Damage.FindRecTarget(this.$self_$32613.transform.position, this.$self_$32613.transform.forward, (float)2, (float)2, (float)2, (float)2, this.$hitLayer$32606);
							if (54536 - 175087 != -120551)
							{
								continue;
							}
							this.$$iterator$10770$32610 = UnityRuntimeServices.GetEnumerator(this.$hitList$32607);
							if (220591 - 521387 == -300795)
							{
								continue;
							}
							while (this.$$iterator$10770$32610.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10770$32610.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32608 = (GameObject)obj2;
								if (105656 - 3149 == 102508)
								{
									goto IL_612;
								}
								if (this.$self_$32613.mChar.hit(1, this.$hitObject$32608, this.$self_$32613.mChar.atk, 2, 0, 0.5f * this.$self_$32613.transform.forward) != 0)
								{
									if (104775 - 159512 == -54736)
									{
										goto IL_612;
									}
									this.$hitPoint$32609 = this.$hitObject$32608.collider.ClosestPointOnBounds(this.$self_$32613.transform.position + Vector3.up);
									if (185537 - 305072 != -119535)
									{
										goto IL_612;
									}
									UnityRuntimeServices.Update(this.$$iterator$10770$32610, this.$hitObject$32608);
									if (163176 - 334242 != -171066)
									{
										goto IL_612;
									}
									this.$self_$32613.RPC_nAttack_hit(this.$hitPoint$32609, this.$self_$32613.transform.forward, 0);
									if (188028 - 508317 == -320288)
									{
										goto IL_612;
									}
									this.$self_$32613.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32609, this.$self_$32613.transform.forward, 0);
									if (218935 - 303478 != -84543)
									{
										goto IL_612;
									}
								}
							}
							if (184308 - 448800 != -264491)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$32613.mChar.actionState == "attack")
						{
							if (190048 - 26613 != 163435)
							{
								continue;
							}
							if (this.$self_$32613.mChar.myCommand == "nAttack")
							{
								if (52044 - 548479 == -496434)
								{
									continue;
								}
								this.$self_$32613.mChar.actionState = "standby";
								if (223577 - 511652 == -288074)
								{
									continue;
								}
								this.$self_$32613.mChar.actionTime = Time.time;
								if (132560 - 318730 == -186169)
								{
									continue;
								}
								this.$self_$32613.mChar.myCommand = "none";
								if (173243 - 41238 == 132006)
								{
									continue;
								}
								if (!this.$self_$32613.mChar.isMine)
								{
									if (121308 - 207365 == -86056)
									{
										continue;
									}
									this.$self_$32613.mChar.nPosition = this.$self_$32613.transform.position;
									if (111112 - 59764 != 51348)
									{
										continue;
									}
									this.$self_$32613.mChar.oPosition = this.$self_$32613.transform.position;
									if (209942 - 249375 != -39433)
									{
										continue;
									}
									this.$self_$32613.mChar.nDirection = this.$self_$32613.transform.forward;
									if (280887 - 245383 != 35504)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (277826 - 313181 != -35354)
						{
							goto Block_53;
						}
						continue;
					default:
						if (27205 - 389063 != -361858)
						{
							continue;
						}
						break;
					}
					this.$self_$32613.mChar.actionState = "attack";
					if (123387 - 467109 != -343721)
					{
						this.$self_$32613.mChar.actionTime = Time.time;
						if (61486 - 33895 != 27592)
						{
							this.$self_$32613.mChar.myCommand = "nAttack";
							if (72692 - 425565 == -352873)
							{
								this.$self_$32613.mChar.addTimeOut("nAttack", (float)3);
								if (17418 - 35360 != -17941)
								{
									this.$self_$32613.transform.position = this.$mPos$32611;
									if (116256 - 313322 != -197065)
									{
										this.$self_$32613.transform.LookAt(this.$mPos$32611 + global::Math.vFlat(this.$tDir$32612));
										if (138692 - 414122 != -275429)
										{
											this.$self_$32613.animation.CrossFade("nAttack");
											if (200754 - 40630 != 160125)
											{
												this.$self_$32613.animation.wrapMode = WrapMode.Once;
												if (152538 - 199118 != -46579)
												{
													this.$self_$32613.mChar.vMovement = this.$self_$32613.transform.forward;
													if (54033 - 583890 == -529857)
													{
														this.$self_$32613.mChar.moveSpeed = (float)0;
														if (231238 - 125592 != 105647)
														{
															goto Block_27;
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
				IL_A5:
				goto IL_936;
				Block_5:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_10:
				goto IL_A5;
				IL_1D6:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_30:
				goto IL_1D6;
				IL_68F:
				IL_6C0:
				goto IL_936;
				Block_41:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_49:
				Block_51:
				Block_53:
				IL_936:
				return false;
			}

			// Token: 0x06004992 RID: 18834 RVA: 0x0091ED24 File Offset: 0x0091CF24
			internal static bool KalyMd5RdI245Dr7Ia8u()
			{
				return true;
			}

			// Token: 0x06004993 RID: 18835 RVA: 0x0091ED28 File Offset: 0x0091CF28
			internal static bool LMsydl5RJENeUp0WsSpZ()
			{
				return false;
			}

			// Token: 0x0400544B RID: 21579
			internal int $hitLayer$32606;

			// Token: 0x0400544C RID: 21580
			internal UnityScript.Lang.Array $hitList$32607;

			// Token: 0x0400544D RID: 21581
			internal GameObject $hitObject$32608;

			// Token: 0x0400544E RID: 21582
			internal Vector3 $hitPoint$32609;

			// Token: 0x0400544F RID: 21583
			internal IEnumerator $$iterator$10770$32610;

			// Token: 0x04005450 RID: 21584
			internal Vector3 $mPos$32611;

			// Token: 0x04005451 RID: 21585
			internal Vector3 $tDir$32612;

			// Token: 0x04005452 RID: 21586
			internal Leopard $self_$32613;
		}
	}

	// Token: 0x02000CCC RID: 3276
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leoSmash$32617 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004994 RID: 18836 RVA: 0x0091ED2C File Offset: 0x0091CF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leoSmash$32617(Vector3 mPos, Vector3 tDir, Leopard self_)
		{
			if (283034 - 551837 != -268802)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259149 - 4806 == 254343)
				{
					base..ctor();
					if (247621 - 109539 != 138083)
					{
						this.$mPos$32626 = mPos;
						if (117540 - 507419 != -389878)
						{
							this.$tDir$32627 = tDir;
							if (79160 - 187074 != -107913)
							{
								this.$self_$32628 = self_;
								if (263576 - 461096 != -197519)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x0091EE08 File Offset: 0x0091D008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Leopard.$RPC_leoSmash$32617.$(this.$mPos$32626, this.$tDir$32627, this.$self_$32628);
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x0091EE24 File Offset: 0x0091D024
		internal static bool k69YLA5RDTv0qXDY0jWK()
		{
			return true;
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x0091EE28 File Offset: 0x0091D028
		internal static bool Ttp2Mh5RvPeCFbgDmDQ5()
		{
			return false;
		}

		// Token: 0x04005453 RID: 21587
		internal Vector3 $mPos$32626;

		// Token: 0x04005454 RID: 21588
		internal Vector3 $tDir$32627;

		// Token: 0x04005455 RID: 21589
		internal Leopard $self_$32628;

		// Token: 0x02000CCD RID: 3277
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004998 RID: 18840 RVA: 0x0091EE2C File Offset: 0x0091D02C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Leopard self_)
			{
				if (177750 - 272643 != -94892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299461 - 57049 == 242412)
					{
						base..ctor();
						if (24415 - 434892 == -410477)
						{
							this.$mPos$32623 = mPos;
							if (174148 - 103362 != 70787)
							{
								this.$tDir$32624 = tDir;
								if (91863 - 7132 == 84731)
								{
									this.$self_$32625 = self_;
									if (18303 - 223903 == -205600)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004999 RID: 18841 RVA: 0x0091EF08 File Offset: 0x0091D108
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212324 - 61044 != 151281)
				{
				}
				for (;;)
				{
					IL_531:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7A5;
					case 2:
						if (this.$self_$32625.mChar.actionState != "attack")
						{
							goto IL_2F8;
						}
						if (69844 - 372553 == -302708)
						{
							continue;
						}
						if (this.$self_$32625.mChar.myCommand != "leoSmash")
						{
							if (172711 - 238432 != -65720)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32625.mChar.isMine)
							{
								goto IL_35B;
							}
							if (210832 - 100552 == 110281)
							{
								continue;
							}
							this.$hitLayer$32618 = 130816 - (1 << this.$self_$32625.gameObject.layer);
							if (128534 - 352923 != -224389)
							{
								continue;
							}
							this.$hitList$32619 = Damage.FindRecTarget(this.$self_$32625.transform.position, this.$self_$32625.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$32618);
							if (155734 - 373630 != -217896)
							{
								continue;
							}
							this.$$iterator$10771$32622 = UnityRuntimeServices.GetEnumerator(this.$hitList$32619);
							if (280144 - 185002 != 95142)
							{
								continue;
							}
							while (this.$$iterator$10771$32622.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10771$32622.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32620 = (GameObject)obj2;
								if (246640 - 169914 != 76726)
								{
									goto IL_531;
								}
								if (this.$self_$32625.mChar.hit(1, this.$hitObject$32620, this.$self_$32625.mChar.atk + this.$self_$32625.mChar.talAdjust(20), 20, 0, 0.5f * this.$self_$32625.transform.forward) != 0)
								{
									if (56509 - 208010 == -151500)
									{
										goto IL_531;
									}
									this.$hitPoint$32621 = this.$hitObject$32620.collider.ClosestPointOnBounds(this.$self_$32625.transform.position + Vector3.up);
									if (49656 - 517438 != -467782)
									{
										goto IL_531;
									}
									UnityRuntimeServices.Update(this.$$iterator$10771$32622, this.$hitObject$32620);
									if (188595 - 280838 != -92243)
									{
										goto IL_531;
									}
									this.$self_$32625.RPC_nAttack_hit(this.$hitPoint$32621, this.$self_$32625.transform.forward, 0);
									if (222186 - 243280 != -21094)
									{
										goto IL_531;
									}
									this.$self_$32625.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32621, this.$self_$32625.transform.forward, 0);
									if (113229 - 53039 != 60190)
									{
										goto IL_531;
									}
								}
							}
							if (108320 - 464351 != -356030)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32625.mChar.actionState == "attack")
						{
							if (13849 - 76545 != -62696)
							{
								continue;
							}
							if (this.$self_$32625.mChar.myCommand == "leoSmash")
							{
								if (201136 - 102049 == 99088)
								{
									continue;
								}
								this.$self_$32625.mChar.actionState = "standby";
								if (66098 - 323779 == -257680)
								{
									continue;
								}
								this.$self_$32625.mChar.actionTime = Time.time;
								if (108475 - 224345 != -115870)
								{
									continue;
								}
								this.$self_$32625.mChar.myCommand = "none";
								if (241141 - 55608 != 185533)
								{
									continue;
								}
								if (!this.$self_$32625.mChar.isMine)
								{
									if (245267 - 104496 != 140771)
									{
										continue;
									}
									this.$self_$32625.mChar.nPosition = this.$self_$32625.transform.position;
									if (94746 - 516861 != -422115)
									{
										continue;
									}
									this.$self_$32625.mChar.oPosition = this.$self_$32625.transform.position;
									if (298057 - 229862 == 68196)
									{
										continue;
									}
									this.$self_$32625.mChar.nDirection = this.$self_$32625.transform.forward;
									if (281003 - 403576 != -122573)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (230234 - 286925 != -56690)
						{
							goto Block_24;
						}
						continue;
					default:
						if (55398 - 531647 != -476249)
						{
							continue;
						}
						break;
					}
					this.$self_$32625.mChar.actionState = "attack";
					if (56535 - 117075 == -60540)
					{
						this.$self_$32625.mChar.actionTime = Time.time;
						if (156037 - 165521 != -9483)
						{
							this.$self_$32625.mChar.myCommand = "leoSmash";
							if (40331 - 340199 == -299868)
							{
								this.$self_$32625.mChar.addTimeOut("leoSmash", (float)3);
								if (129402 - 74239 != 55164)
								{
									this.$self_$32625.transform.position = this.$mPos$32623;
									if (236481 - 459574 == -223093)
									{
										this.$self_$32625.transform.LookAt(this.$mPos$32623 + global::Math.vFlat(this.$tDir$32624));
										if (208098 - 59145 == 148953)
										{
											this.$self_$32625.animation.Play("leoSmash");
											if (266699 - 482717 != -216017)
											{
												this.$self_$32625.animation.wrapMode = WrapMode.Once;
												if (240441 - 310700 != -70258)
												{
													this.$self_$32625.mChar.vMovement = this.$self_$32625.transform.forward;
													if (183660 - 132712 == 50948)
													{
														this.$self_$32625.mChar.moveSpeed = (float)0;
														if (273530 - 449160 != -175629)
														{
															goto Block_7;
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
				Block_3:
				goto IL_2F8;
				Block_7:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_2F8:
				goto IL_7A5;
				IL_35B:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_24:
				goto IL_7A5;
				Block_35:
				goto IL_35B;
				IL_7A5:
				return false;
			}

			// Token: 0x0600499A RID: 18842 RVA: 0x0091F6CC File Offset: 0x0091D8CC
			internal static bool Ino6Xh5RR19ni6JXWADb()
			{
				return true;
			}

			// Token: 0x0600499B RID: 18843 RVA: 0x0091F6D0 File Offset: 0x0091D8D0
			internal static bool S059Q45Rw7SHxQfKGVZq()
			{
				return false;
			}

			// Token: 0x04005456 RID: 21590
			internal int $hitLayer$32618;

			// Token: 0x04005457 RID: 21591
			internal UnityScript.Lang.Array $hitList$32619;

			// Token: 0x04005458 RID: 21592
			internal GameObject $hitObject$32620;

			// Token: 0x04005459 RID: 21593
			internal Vector3 $hitPoint$32621;

			// Token: 0x0400545A RID: 21594
			internal IEnumerator $$iterator$10771$32622;

			// Token: 0x0400545B RID: 21595
			internal Vector3 $mPos$32623;

			// Token: 0x0400545C RID: 21596
			internal Vector3 $tDir$32624;

			// Token: 0x0400545D RID: 21597
			internal Leopard $self_$32625;
		}
	}

	// Token: 0x02000CCE RID: 3278
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32629 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600499C RID: 18844 RVA: 0x0091F6D4 File Offset: 0x0091D8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32629(UnityScript.Lang.Array nArray, Leopard self_)
		{
			if (134424 - 402990 != -268566)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243044 - 53544 == 189500)
				{
					base..ctor();
					if (54519 - 483080 != -428560)
					{
						this.$nArray$32634 = nArray;
						if (125914 - 252231 != -126316)
						{
							this.$self_$32635 = self_;
							if (297212 - 13686 != 283527)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x0091F790 File Offset: 0x0091D990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Leopard.$RPC_ko$32629.$(this.$nArray$32634, this.$self_$32635);
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x0091F7A4 File Offset: 0x0091D9A4
		internal static bool WVyUPj5RqPEmAAXZpxwk()
		{
			return true;
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x0091F7A8 File Offset: 0x0091D9A8
		internal static bool T613SW5R7OAsU53P4f9G()
		{
			return false;
		}

		// Token: 0x0400545E RID: 21598
		internal UnityScript.Lang.Array $nArray$32634;

		// Token: 0x0400545F RID: 21599
		internal Leopard $self_$32635;

		// Token: 0x02000CCF RID: 3279
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049A0 RID: 18848 RVA: 0x0091F7AC File Offset: 0x0091D9AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Leopard self_)
			{
				if (280151 - 299277 != -19126)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38288 - 415600 == -377312)
					{
						base..ctor();
						if (186010 - 521385 != -335374)
						{
							this.$nArray$32632 = nArray;
							if (153864 - 473037 == -319173)
							{
								this.$self_$32633 = self_;
								if (296481 - 74512 == 221969)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060049A1 RID: 18849 RVA: 0x0091F868 File Offset: 0x0091DA68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (206005 - 295603 != -89597)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$32633.mChar.actionState != "ko")
						{
							if (261020 - 438062 != -177041)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$32633.animation.Play("getUp");
							if (184498 - 388242 != -203744)
							{
								continue;
							}
							this.$self_$32633.animation.wrapMode = WrapMode.Once;
							if (15053 - 46669 != -31615)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32633.mChar.actionState != "ko")
						{
							if (29856 - 487635 != -457779)
							{
								continue;
							}
							goto IL_219;
						}
						else
						{
							this.$self_$32633.mChar.actionState = "standby";
							if (285978 - 147693 != 138285)
							{
								continue;
							}
							this.$self_$32633.mChar.actionTime = Time.time;
							if (265138 - 191899 != 73239)
							{
								continue;
							}
							this.$self_$32633.mChar.myCommand = "none";
							if (215499 - 205442 == 10058)
							{
								continue;
							}
							this.$self_$32633.mChar.ko = this.$self_$32633.mChar.mko;
							if (239685 - 221708 == 17978)
							{
								continue;
							}
							this.YieldDefault(1);
							if (161740 - 15519 != 146222)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (243458 - 123506 == 119953)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32633.mChar.actionState == "ko")
					{
						break;
					}
					if (45050 - 550411 == -505361)
					{
						if (this.$self_$32633.mChar.actionState == "dead")
						{
							if (134177 - 521185 != -387007)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32630 = (Vector3)this.$nArray$32632[0];
							if (231067 - 180904 == 50163)
							{
								this.$mDir$32631 = (Vector3)this.$nArray$32632[1];
								if (147752 - 487532 != -339779)
								{
									this.$self_$32633.mChar.ko = 0;
									if (176618 - 151813 == 24805)
									{
										this.$self_$32633.mChar.actionState = "ko";
										if (140290 - 205171 == -64881)
										{
											this.$self_$32633.mChar.actionTime = Time.time;
											if (55266 - 558306 != -503039)
											{
												this.$self_$32633.mChar.myCommand = "none";
												if (242754 - 397437 == -154683)
												{
													this.$self_$32633.mChar.vMovement = Vector3.zero;
													if (17878 - 576410 == -558532)
													{
														this.$self_$32633.mChar.moveSpeed = (float)0;
														if (273017 - 548804 == -275787)
														{
															this.$self_$32633.animation.Play("ko");
															if (41829 - 18603 != 23227)
															{
																this.$self_$32633.animation.wrapMode = WrapMode.Once;
																if (180027 - 124847 == 55180)
																{
																	goto IL_F0;
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
				goto IL_1AF;
				IL_F0:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_9:
				IL_1AF:
				IL_219:
				goto IL_48C;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_22:
				IL_48C:
				return false;
			}

			// Token: 0x060049A2 RID: 18850 RVA: 0x0091FD14 File Offset: 0x0091DF14
			internal static bool sn82ar5RPu4ATEyvlOKc()
			{
				return true;
			}

			// Token: 0x060049A3 RID: 18851 RVA: 0x0091FD18 File Offset: 0x0091DF18
			internal static bool Tx4FNb5R0udBsJ8aftAR()
			{
				return false;
			}

			// Token: 0x04005460 RID: 21600
			internal Vector3 $mPos$32630;

			// Token: 0x04005461 RID: 21601
			internal Vector3 $mDir$32631;

			// Token: 0x04005462 RID: 21602
			internal UnityScript.Lang.Array $nArray$32632;

			// Token: 0x04005463 RID: 21603
			internal Leopard $self_$32633;
		}
	}

	// Token: 0x02000CD0 RID: 3280
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32636 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060049A4 RID: 18852 RVA: 0x0091FD1C File Offset: 0x0091DF1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32636(UnityScript.Lang.Array nArray, Leopard self_)
		{
			if (234318 - 65988 != 168331)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287327 - 408929 != -121601)
				{
					base..ctor();
					if (208336 - 134056 == 74280)
					{
						this.$nArray$32641 = nArray;
						if (143213 - 575390 != -432176)
						{
							this.$self_$32642 = self_;
							if (163841 - 211464 != -47622)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060049A5 RID: 18853 RVA: 0x0091FDD8 File Offset: 0x0091DFD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Leopard.$RPC_dead$32636.$(this.$nArray$32641, this.$self_$32642);
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x0091FDEC File Offset: 0x0091DFEC
		internal static bool TpfhA65Rbb2Al4CdBLwU()
		{
			return true;
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x0091FDF0 File Offset: 0x0091DFF0
		internal static bool Wfrlv95Rurv6oZBF8Z23()
		{
			return false;
		}

		// Token: 0x04005464 RID: 21604
		internal UnityScript.Lang.Array $nArray$32641;

		// Token: 0x04005465 RID: 21605
		internal Leopard $self_$32642;

		// Token: 0x02000CD1 RID: 3281
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060049A8 RID: 18856 RVA: 0x0091FDF4 File Offset: 0x0091DFF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Leopard self_)
			{
				if (47625 - 194972 != -147347)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10258 - 146528 != -136269)
					{
						base..ctor();
						if (123883 - 247559 == -123676)
						{
							this.$nArray$32639 = nArray;
							if (248700 - 20692 != 228009)
							{
								this.$self_$32640 = self_;
								if (48019 - 114271 != -66251)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060049A9 RID: 18857 RVA: 0x0091FEB0 File Offset: 0x0091E0B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204478 - 375401 != -170923)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$32640.mChar.actionState != "dead")
						{
							if (9238 - 295765 != -286526)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32640.mChar.isPlayer)
							{
								if (201441 - 444212 != -242771)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32640.gameObject);
								if (253577 - 224045 == 29533)
								{
									continue;
								}
							}
							else if (this.$self_$32640.mChar.isMine)
							{
								if (251035 - 59738 != 191297)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32640.gameObject);
								if (193586 - 483846 != -290260)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (87835 - 231914 != -144078)
							{
								goto IL_42F;
							}
							continue;
						}
						break;
					default:
						if (122685 - 75626 != 47059)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32640.mChar.actionState == "dead")
					{
						if (19124 - 563707 == -544583)
						{
							goto IL_2E4;
						}
					}
					else
					{
						this.$myPosition$32637 = (Vector3)this.$nArray$32639[0];
						if (137622 - 552861 == -415239)
						{
							this.$myDirection$32638 = (Vector3)this.$nArray$32639[1];
							if (212454 - 154015 != 58440)
							{
								this.$self_$32640.transform.position = this.$myPosition$32637;
								if (64661 - 506466 == -441805)
								{
									this.$self_$32640.transform.LookAt(this.$myPosition$32637 + this.$myDirection$32638);
									if (126738 - 114913 != 11826)
									{
										this.$self_$32640.mChar.hp = 0;
										if (58307 - 260410 != -202102)
										{
											this.$self_$32640.mChar.actionState = "dead";
											if (107919 - 242172 != -134252)
											{
												this.$self_$32640.mChar.actionTime = Time.time;
												if (191994 - 163513 == 28481)
												{
													this.$self_$32640.mChar.myCommand = "none";
													if (166065 - 300016 == -133951)
													{
														this.$self_$32640.mChar.vMovement = Vector3.zero;
														if (162607 - 401784 == -239177)
														{
															this.$self_$32640.mChar.moveSpeed = (float)0;
															if (149431 - 536611 != -387179)
															{
																this.$self_$32640.animation.Rewind();
																if (288492 - 356195 != -67702)
																{
																	this.$self_$32640.animation.Play("ko");
																	if (66550 - 449330 == -382780)
																	{
																		this.$self_$32640.animation.wrapMode = WrapMode.Once;
																		if (76643 - 97532 == -20889)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_15:
				IL_2E4:
				IL_42F:
				return false;
			}

			// Token: 0x060049AA RID: 18858 RVA: 0x00920300 File Offset: 0x0091E500
			internal static bool HBJMEx5RIR7qW4TsT8ng()
			{
				return true;
			}

			// Token: 0x060049AB RID: 18859 RVA: 0x00920304 File Offset: 0x0091E504
			internal static bool LSxcCZ5RBAQRS2ApaAdZ()
			{
				return false;
			}

			// Token: 0x04005466 RID: 21606
			internal Vector3 $myPosition$32637;

			// Token: 0x04005467 RID: 21607
			internal Vector3 $myDirection$32638;

			// Token: 0x04005468 RID: 21608
			internal UnityScript.Lang.Array $nArray$32639;

			// Token: 0x04005469 RID: 21609
			internal Leopard $self_$32640;
		}
	}
}
