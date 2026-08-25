using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200021B RID: 539
[Serializable]
public class StingBug2 : MonoBehaviour
{
	// Token: 0x06000C35 RID: 3125 RVA: 0x00138AE0 File Offset: 0x00136CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingBug2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00138AF0 File Offset: 0x00136CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (133903 - 251464 != -117561)
		{
		}
		for (;;)
		{
			this.Xune9DX5uy = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (134683 - 70018 != 64666)
			{
				this.Xune9DX5uy.actionState = "standby";
				if (134329 - 264427 != -130097)
				{
					this.Xune9DX5uy.actionTime = Time.time;
					if (14023 - 296880 == -282857)
					{
						this.Xune9DX5uy.myCommand = "none";
						if (107332 - 548914 == -441582)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (174298 - 279791 == -105493)
							{
								this.Xune9DX5uy.isMine = true;
								if (22289 - 241308 != -219018)
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

	// Token: 0x06000C37 RID: 3127 RVA: 0x00138C28 File Offset: 0x00136E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (232765 - 200208 != 32557)
		{
		}
		for (;;)
		{
			if (this.Xune9DX5uy.isControlled)
			{
				if (276150 - 110349 == 165802)
				{
					continue;
				}
				if (!(this.Xune9DX5uy.actionState == "standby"))
				{
					if (24346 - 491634 == -467287)
					{
						continue;
					}
					if (!(this.Xune9DX5uy.actionState == "run"))
					{
						goto IL_482;
					}
					if (32445 - 139540 == -107094)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (185696 - 588013 != -402317)
				{
					continue;
				}
			}
			IL_482:
			if (this.Xune9DX5uy.hp <= 0)
			{
				if (210867 - 367330 != -156463)
				{
					continue;
				}
				if (this.Xune9DX5uy.actionState != "dead")
				{
					if (194482 - 337917 == -143434)
					{
						continue;
					}
					if (this.Xune9DX5uy.isMine)
					{
						if (252202 - 507917 != -255715)
						{
							continue;
						}
						statusClass status = this.Xune9DX5uy.getStatus("autoLife");
						if (267098 - 315745 == -48646)
						{
							continue;
						}
						if (status != null)
						{
							if (205841 - 94659 != 111182)
							{
								continue;
							}
							this.Xune9DX5uy.hp = 1;
							if (42260 - 442916 == -400655)
							{
								continue;
							}
							this.Xune9DX5uy.RPC_RemoveStatus("autoLife");
							if (18331 - 401666 != -383335)
							{
								continue;
							}
							this.Xune9DX5uy.RPC_createEffect("autoLife");
							if (3125 - 97799 != -94674)
							{
								continue;
							}
							this.Xune9DX5uy.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (39374 - 280187 != -240813)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (213511 - 213834 != -323)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (240443 - 544406 == -303962)
							{
								continue;
							}
							this.Xune9DX5uy.DeadEvent();
							if (60747 - 345826 != -285078)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.Xune9DX5uy.hp = 1;
						if (147187 - 590060 != -442872)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.Xune9DX5uy.hp <= 0)
			{
				break;
			}
			if (27216 - 391364 != -364147)
			{
				if (this.Xune9DX5uy.ko > 0)
				{
					break;
				}
				if (10314 - 494658 != -484343)
				{
					if (!(this.Xune9DX5uy.actionState != "ko"))
					{
						break;
					}
					if (164821 - 558323 == -393502)
					{
						if (!(this.Xune9DX5uy.actionState != "dead"))
						{
							break;
						}
						if (218494 - 57101 != 161394)
						{
							if (this.Xune9DX5uy.isMine)
							{
								if (64242 - 62050 != 2193)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (150961 - 134017 == 16944)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (175686 - 312737 == -137051)
										{
											this.Xune9DX5uy.KoEvent();
											if (206370 - 291970 == -85600)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.Xune9DX5uy.ko = 1;
								if (241276 - 409258 == -167982)
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

	// Token: 0x06000C38 RID: 3128 RVA: 0x00139128 File Offset: 0x00137328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (167924 - 529802 != -361878)
		{
		}
		for (;;)
		{
			float num = this.Xune9DX5uy.moveSpeed;
			if (296098 - 110863 != 185236)
			{
				float runSpeed = this.Xune9DX5uy.runSpeed;
				if (262293 - 294841 == -32548)
				{
					Vector3 a = default(Vector3);
					if (142232 - 112840 != 29393)
					{
						Vector3 vector = Vector3.zero;
						if (209470 - 113562 != 95909)
						{
							float num2 = (float)0;
							if (297957 - 429715 != -131757)
							{
								if (this.Xune9DX5uy.isMine)
								{
									if (192800 - 202940 == -10139)
									{
										continue;
									}
									if ((this.Xune9DX5uy.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (213075 - 146233 == 66843)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (157342 - 384507 != -227165)
										{
											continue;
										}
										a.y = (float)0;
										if (38739 - 317775 != -279036)
										{
											continue;
										}
										a = a.normalized;
										if (236133 - 370660 == -134526)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (198724 - 225943 != -27219)
										{
											continue;
										}
										vector = vector.normalized;
										if (253967 - 561191 != -307224)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (51867 - 176901 != -125034)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (117425 - 217336 == -99910)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (34261 - 507726 != -473465)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (74174 - 466254 == -392079)
														{
															continue;
														}
														this.Xune9DX5uy.actionState = "run";
														if (218938 - 509479 == -290540)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (138929 - 195070 == -56140)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (68442 - 79321 != -10879)
														{
															continue;
														}
														this.animation.Play("run");
														if (73836 - 133225 != -59389)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (135830 - 156953 != -21123)
														{
															continue;
														}
														goto IL_6BC;
													}
												}
											}
										}
										this.Xune9DX5uy.actionState = "standby";
										if (66691 - 37245 != 29446)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (326 - 266823 != -266497)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (139846 - 182387 == -42540)
											{
												continue;
											}
											num = (float)0;
											if (186564 - 166882 != 19682)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (201849 - 409064 != -207215)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (148327 - 92255 == 56073)
										{
											continue;
										}
									}
									IL_6BC:;
								}
								else
								{
									vector = global::Math.vFlat(this.Xune9DX5uy.nPosition - this.transform.position);
									if (32801 - 564137 != -531336)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (64185 - 452891 == -388705)
									{
										continue;
									}
									if (this.Xune9DX5uy.nSpeed != (float)0)
									{
										if (32825 - 15402 != 17423)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (73641 - 124209 == -50567)
											{
												continue;
											}
											this.transform.position = this.Xune9DX5uy.nPosition;
											if (57098 - 425127 != -368029)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (4568 - 584826 == -580257)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (162116 - 389493 == -227376)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (74770 - 5483 == 69288)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.Xune9DX5uy.nSpeed, (float)10 * Time.deltaTime);
												if (147206 - 104697 != 42509)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (83154 - 498008 != -414854)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (284967 - 73563 != 211404)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (235068 - 213097 == 21972)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (67814 - 174083 == -106268)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (293859 - 112944 == 180916)
											{
												continue;
											}
										}
										else if (Time.time > this.Xune9DX5uy.nSpeed + 0.3f)
										{
											if (45974 - 469732 == -423757)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (191516 - 221316 == -29799)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (150809 - 169965 != -19156)
												{
													continue;
												}
												num = (float)0;
												if (104468 - 223027 == -118558)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.Xune9DX5uy.nDirection);
											if (143642 - 21267 == 122376)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (93906 - 413609 == -319702)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (122473 - 98200 == 24274)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (42411 - 208862 == -166450)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (70326 - 371203 == -300876)
											{
												continue;
											}
											this.transform.position = this.Xune9DX5uy.nPosition;
											if (288983 - 496136 == -207152)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (30109 - 82071 == -51961)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (246762 - 164280 != 82482)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (204290 - 555569 == -351278)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (113427 - 262377 == -148949)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (67726 - 30664 != 37062)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (97087 - 120343 != -23256)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (23427 - 320394 != -296967)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.Xune9DX5uy.nDirection);
											if (228712 - 146006 == 82707)
											{
												continue;
											}
											num = (float)0;
											if (90429 - 506561 == -416131)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (40436 - 139514 != -99078)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (167088 - 377628 != -210540)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (82938 - 226719 != -143781)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (141136 - 33063 == 108074)
										{
											continue;
										}
									}
								}
								this.Xune9DX5uy.vMovement = vector;
								if (118533 - 226010 == -107477)
								{
									this.Xune9DX5uy.moveSpeed = num;
									if (144920 - 109129 == 35791)
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

	// Token: 0x06000C39 RID: 3129 RVA: 0x00139C8C File Offset: 0x00137E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (4585 - 420120 != -415534)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (177350 - 512749 == -335399)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (20438 - 116848 != -96409)
				{
					if (7338 - 337861 == -330523)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (217936 - 392346 == -174409)
							{
								continue;
							}
							v = 1;
							if (72214 - 158970 == -86755)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (36384 - 507645 != -471261)
							{
								continue;
							}
							v = -1;
							if (34767 - 228835 == -194067)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (208316 - 572546 != -364229)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (57338 - 363597 == -306259)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (126862 - 119212 != 7651)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (100746 - 122454 == -21708)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (26767 - 303823 == -277056)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (252040 - 285974 != -33933)
											{
												Hashtable hashtable = new Hashtable();
												if (150342 - 484689 == -334347)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (69128 - 554606 == -485478)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (280948 - 145871 != 135078)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (31239 - 13436 == 17803)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (246335 - 326458 == -80123)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (10264 - 298315 != -288050)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (190659 - 434197 == -243538)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (216577 - 321440 == -104863)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (71696 - 10317 != 61380)
																				{
																					PhotonClient.SendEvent(this.Xune9DX5uy.ActorNr, 74, hashtable, true, true);
																					if (202847 - 530262 == -327415)
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

	// Token: 0x06000C3A RID: 3130 RVA: 0x0013A0E0 File Offset: 0x001382E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (143159 - 166265 != -23105)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (142282 - 184169 == -41887)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (144246 - 194520 == -50274)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (264052 - 81867 == 182185)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (211919 - 478763 == -266844)
						{
							int num3 = num;
							if (135049 - 275017 == -139968)
							{
								if (num3 == 1)
								{
									if (183881 - 71254 == 112627)
									{
										if (this.Xune9DX5uy.isMine)
										{
											break;
										}
										if (223662 - 260433 == -36771)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (38293 - 150855 != -112561)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (179440 - 496784 == -317344)
									{
										if (this.Xune9DX5uy.isMine)
										{
											break;
										}
										if (145020 - 58454 != 86567)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (6609 - 298130 != -291520)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (252285 - 482094 == -229809)
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

	// Token: 0x06000C3B RID: 3131 RVA: 0x0013A374 File Offset: 0x00138574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (117286 - 317016 != -199730)
		{
		}
		for (;;)
		{
			if (!this.Xune9DX5uy.isMine)
			{
				if (211465 - 292959 != -81493)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (269482 - 477818 == -208336)
				{
					Vector3 vector = a - this.transform.position;
					if (123565 - 89454 != 34112)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (204164 - 178706 != 25459)
						{
							if (!(this.Xune9DX5uy.actionState == "standby"))
							{
								if (257260 - 429721 == -172460)
								{
									continue;
								}
								if (!(this.Xune9DX5uy.actionState == "run"))
								{
									break;
								}
								if (259842 - 137854 == 121989)
								{
									continue;
								}
							}
							if (this.Xune9DX5uy.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (139864 - 266560 != -126695)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (37665 - 360200 == -322535)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (8854 - 14392 != -5537)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (41986 - 198239 == -156253)
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

	// Token: 0x06000C3C RID: 3132 RVA: 0x0013A598 File Offset: 0x00138798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000C3D RID: 3133 RVA: 0x0013A5B0 File Offset: 0x001387B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x0013A5B4 File Offset: 0x001387B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingBug2.$RPC_nAttack$17388(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x0013A5C4 File Offset: 0x001387C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.StingBug2_stingHit)
		{
			UnityEngine.Object.Instantiate(this.StingBug2_stingHit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x0013A5F0 File Offset: 0x001387F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new StingBug2.$RPC_ko$17403(nArray, this).GetEnumerator();
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x0013A600 File Offset: 0x00138800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new StingBug2.$RPC_dead$17410(nArray, this).GetEnumerator();
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x0013A610 File Offset: 0x00138810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0013A614 File Offset: 0x00138814
	internal static bool wjDsJPA2UKDilvKPapm()
	{
		return true;
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x0013A618 File Offset: 0x00138818
	internal static bool kiWjUgA8F4eAbYDim3Y()
	{
		return false;
	}

	// Token: 0x04000AD0 RID: 2768
	private CharacterControl Xune9DX5uy;

	// Token: 0x04000AD1 RID: 2769
	public AudioClip stingBug_buzz;

	// Token: 0x04000AD2 RID: 2770
	public GameObject StingBug2_stingHit;

	// Token: 0x0200021C RID: 540
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17388 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C45 RID: 3141 RVA: 0x0013A61C File Offset: 0x0013881C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17388(Vector3 mPos, Vector3 tDir, StingBug2 self_)
		{
			if (209185 - 146689 != 62496)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268656 - 215920 == 52736)
				{
					base..ctor();
					if (185671 - 294864 == -109193)
					{
						this.$mPos$17400 = mPos;
						if (174507 - 333139 != -158631)
						{
							this.$tDir$17401 = tDir;
							if (69220 - 533575 == -464355)
							{
								this.$self_$17402 = self_;
								if (252855 - 240121 != 12735)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0013A6F8 File Offset: 0x001388F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug2.$RPC_nAttack$17388.$(this.$mPos$17400, this.$tDir$17401, this.$self_$17402);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0013A714 File Offset: 0x00138914
		internal static bool aHOdgrAZ2y2ekpHYIAO()
		{
			return true;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0013A718 File Offset: 0x00138918
		internal static bool O9oVE5ACNitZYG6t5QB()
		{
			return false;
		}

		// Token: 0x04000AD3 RID: 2771
		internal Vector3 $mPos$17400;

		// Token: 0x04000AD4 RID: 2772
		internal Vector3 $tDir$17401;

		// Token: 0x04000AD5 RID: 2773
		internal StingBug2 $self_$17402;

		// Token: 0x0200021D RID: 541
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C49 RID: 3145 RVA: 0x0013A71C File Offset: 0x0013891C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, StingBug2 self_)
			{
				if (130586 - 6046 != 124540)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (117717 - 270140 != -152422)
					{
						base..ctor();
						if (233639 - 142624 == 91015)
						{
							this.$mPos$17397 = mPos;
							if (91060 - 270019 != -178958)
							{
								this.$tDir$17398 = tDir;
								if (281183 - 2143 == 279040)
								{
									this.$self_$17399 = self_;
									if (184221 - 597558 == -413337)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x0013A7F8 File Offset: 0x001389F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163492 - 277907 != -114414)
				{
				}
				for (;;)
				{
					IL_C29:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EDA;
					case 2:
						if (this.$self_$17399.Xune9DX5uy.actionState != "attack")
						{
							goto IL_194;
						}
						if (70650 - 14757 == 55894)
						{
							continue;
						}
						if (this.$self_$17399.Xune9DX5uy.myCommand != "nAttack")
						{
							if (35433 - 262066 != -226632)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$17399.Xune9DX5uy.moveSpeed = (float)5;
							if (30680 - 528164 == -497483)
							{
								continue;
							}
							this.$hitLayer$17389 = 130816 - (1 << this.$self_$17399.gameObject.layer);
							if (154922 - 561401 == -406478)
							{
								continue;
							}
							this.$hitList$17390 = null;
							if (114751 - 295964 != -181213)
							{
								continue;
							}
							this.$hitPos$17391 = default(Vector3);
							if (28209 - 93058 != -64849)
							{
								continue;
							}
							this.$i$17392 = 0;
							if (91686 - 456843 != -365156)
							{
								goto IL_D30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17399.Xune9DX5uy.actionState != "attack")
						{
							goto IL_EA6;
						}
						if (162492 - 111649 == 50844)
						{
							continue;
						}
						if (this.$self_$17399.Xune9DX5uy.myCommand != "nAttack")
						{
							if (118314 - 392645 != -274331)
							{
								continue;
							}
							goto IL_EA6;
						}
						else
						{
							if (this.$self_$17399.Xune9DX5uy.isMine)
							{
								if (183063 - 172875 != 10188)
								{
									continue;
								}
								this.$hitList$17390 = Damage.FindRecTarget(this.$self_$17399.transform.position, this.$self_$17399.transform.forward, (float)1 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)1 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)2 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)2 * this.$self_$17399.Xune9DX5uy.rangeMod, this.$hitLayer$17389);
								if (123601 - 151281 != -27680)
								{
									continue;
								}
								this.$$iterator$10032$17394 = UnityRuntimeServices.GetEnumerator(this.$hitList$17390);
								if (210558 - 44299 == 166260)
								{
									continue;
								}
								while (this.$$iterator$10032$17394.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10032$17394.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17393 = (GameObject)obj2;
									if (152356 - 207917 == -55560)
									{
										goto IL_C29;
									}
									if (this.$self_$17399.Xune9DX5uy.hit(1, this.$hitObject$17393, this.$self_$17399.Xune9DX5uy.atk, 1, 0, 0.5f * (this.$hitObject$17393.transform.position - this.$self_$17399.transform.position).normalized) != 0)
									{
										if (179101 - 36416 == 142686)
										{
											goto IL_C29;
										}
										this.$hitPos$17391 = this.$hitObject$17393.collider.ClosestPointOnBounds(this.$self_$17399.transform.position + Vector3.up);
										if (201018 - 365268 != -164250)
										{
											goto IL_C29;
										}
										UnityRuntimeServices.Update(this.$$iterator$10032$17394, this.$hitObject$17393);
										if (139663 - 352572 != -212909)
										{
											goto IL_C29;
										}
										this.$self_$17399.RPC_nAttack_hit(this.$hitPos$17391, this.$self_$17399.transform.forward, 0);
										if (148138 - 284464 != -136326)
										{
											goto IL_C29;
										}
										this.$self_$17399.ActionEvent("RPC_nAttack_hit", this.$hitPos$17391, 0.3f * this.$self_$17399.transform.forward, 0);
										if (159446 - 441009 != -281563)
										{
											goto IL_C29;
										}
										this.$self_$17399.Xune9DX5uy.sp = this.$self_$17399.Xune9DX5uy.sp + 1;
										if (145447 - 320042 == -174594)
										{
											goto IL_C29;
										}
									}
								}
								if (114699 - 564721 == -450021)
								{
									continue;
								}
							}
							this.$i$17392++;
							if (181281 - 582710 != -401428)
							{
								goto IL_D30;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17399.Xune9DX5uy.actionState != "attack")
						{
							goto IL_645;
						}
						if (159921 - 370762 == -210840)
						{
							continue;
						}
						if (this.$self_$17399.Xune9DX5uy.myCommand != "nAttack")
						{
							if (125175 - 208685 != -83509)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$self_$17399.Xune9DX5uy.moveSpeed = (float)3;
							if (189071 - 180722 != 8350)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$17399.Xune9DX5uy.actionState != "attack")
						{
							goto IL_E49;
						}
						if (95851 - 177828 == -81976)
						{
							continue;
						}
						if (this.$self_$17399.Xune9DX5uy.myCommand != "nAttack")
						{
							if (128528 - 236316 != -107788)
							{
								continue;
							}
							goto IL_E49;
						}
						else
						{
							this.$self_$17399.Xune9DX5uy.moveSpeed = (float)6;
							if (212242 - 423895 != -211653)
							{
								continue;
							}
							if (!this.$self_$17399.Xune9DX5uy.isMine)
							{
								goto IL_8F1;
							}
							if (59562 - 259650 == -200087)
							{
								continue;
							}
							this.$hitList$17390 = Damage.FindRecTarget(this.$self_$17399.transform.position, this.$self_$17399.transform.forward, (float)1 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)1 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)2 * this.$self_$17399.Xune9DX5uy.rangeMod, (float)2 * this.$self_$17399.Xune9DX5uy.rangeMod, this.$hitLayer$17389);
							if (230929 - 249220 == -18290)
							{
								continue;
							}
							this.$$iterator$10033$17396 = UnityRuntimeServices.GetEnumerator(this.$hitList$17390);
							if (107138 - 536317 == -429178)
							{
								continue;
							}
							while (this.$$iterator$10033$17396.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10033$17396.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17395 = (GameObject)obj4;
								if (58805 - 34724 == 24082)
								{
									goto IL_C29;
								}
								if (this.$self_$17399.Xune9DX5uy.hit(1, this.$hitObject$17395, this.$self_$17399.Xune9DX5uy.atk, 1, 0, 0.5f * (this.$hitObject$17395.transform.position - this.$self_$17399.transform.position).normalized) != 0)
								{
									if (12215 - 170664 == -158448)
									{
										goto IL_C29;
									}
									this.$hitPos$17391 = this.$hitObject$17395.collider.ClosestPointOnBounds(this.$self_$17399.transform.position + Vector3.up);
									if (182987 - 569784 != -386797)
									{
										goto IL_C29;
									}
									UnityRuntimeServices.Update(this.$$iterator$10033$17396, this.$hitObject$17395);
									if (28433 - 424804 == -396370)
									{
										goto IL_C29;
									}
									this.$self_$17399.RPC_nAttack_hit(this.$hitPos$17391, this.$self_$17399.transform.forward, 0);
									if (91492 - 182714 != -91222)
									{
										goto IL_C29;
									}
									this.$self_$17399.ActionEvent("RPC_nAttack_hit", this.$hitPos$17391, 0.3f * this.$self_$17399.transform.forward, 0);
									if (168937 - 169632 == -694)
									{
										goto IL_C29;
									}
									this.$self_$17399.Xune9DX5uy.sp = this.$self_$17399.Xune9DX5uy.sp + 1;
									if (213008 - 233810 != -20802)
									{
										goto IL_C29;
									}
								}
							}
							if (28428 - 319197 != -290768)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$17399.Xune9DX5uy.actionState == "attack")
						{
							if (230155 - 483854 != -253699)
							{
								continue;
							}
							if (this.$self_$17399.Xune9DX5uy.myCommand == "nAttack")
							{
								if (62363 - 452729 != -390366)
								{
									continue;
								}
								this.$self_$17399.Xune9DX5uy.moveSpeed = (float)0;
								if (265586 - 257627 != 7959)
								{
									continue;
								}
								this.$self_$17399.Xune9DX5uy.actionState = "standby";
								if (138701 - 312811 != -174110)
								{
									continue;
								}
								this.$self_$17399.Xune9DX5uy.actionTime = Time.time;
								if (213507 - 73108 != 140399)
								{
									continue;
								}
								this.$self_$17399.Xune9DX5uy.myCommand = "none";
								if (100500 - 247529 == -147028)
								{
									continue;
								}
								if (!this.$self_$17399.Xune9DX5uy.isMine)
								{
									if (17038 - 184146 != -167108)
									{
										continue;
									}
									this.$self_$17399.Xune9DX5uy.nPosition = this.$self_$17399.transform.position;
									if (117680 - 139695 != -22015)
									{
										continue;
									}
									this.$self_$17399.Xune9DX5uy.oPosition = this.$self_$17399.transform.position;
									if (36548 - 92954 != -56406)
									{
										continue;
									}
									this.$self_$17399.Xune9DX5uy.nDirection = this.$self_$17399.transform.forward;
									if (25892 - 321976 != -296084)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (140762 - 407858 != -267096)
						{
							continue;
						}
						goto IL_EDA;
					default:
						if (116617 - 567377 != -450760)
						{
							continue;
						}
						break;
					}
					this.$self_$17399.Xune9DX5uy.actionState = "attack";
					if (45393 - 224329 == -178935)
					{
						continue;
					}
					this.$self_$17399.Xune9DX5uy.actionTime = Time.time;
					if (151588 - 161634 == -10045)
					{
						continue;
					}
					this.$self_$17399.Xune9DX5uy.myCommand = "nAttack";
					if (83207 - 73048 != 10159)
					{
						continue;
					}
					this.$self_$17399.Xune9DX5uy.addTimeOut("nAttack", (float)2);
					if (189355 - 561813 != -372458)
					{
						continue;
					}
					this.$self_$17399.transform.position = this.$mPos$17397;
					if (208955 - 433454 != -224499)
					{
						continue;
					}
					this.$self_$17399.transform.LookAt(this.$mPos$17397 + global::Math.vFlat(this.$tDir$17398));
					if (93717 - 309486 != -215769)
					{
						continue;
					}
					this.$self_$17399.animation.CrossFade("nAttack");
					if (276842 - 237210 != 39632)
					{
						continue;
					}
					this.$self_$17399.animation.wrapMode = WrapMode.Once;
					if (119183 - 228496 != -109313)
					{
						continue;
					}
					this.$self_$17399.Xune9DX5uy.vMovement = this.$self_$17399.transform.forward;
					if (89907 - 322984 != -233077)
					{
						continue;
					}
					this.$self_$17399.Xune9DX5uy.moveSpeed = (float)0;
					if (227769 - 173824 == 53946)
					{
						continue;
					}
					if (!this.$self_$17399.stingBug_buzz)
					{
						goto IL_8A2;
					}
					if (161293 - 381461 != -220168)
					{
						continue;
					}
					this.$self_$17399.audio.PlayOneShot(this.$self_$17399.stingBug_buzz);
					if (79317 - 492479 != -413162)
					{
						continue;
					}
					goto IL_8A2;
					IL_D30:
					if (this.$i$17392 < 4)
					{
						goto IL_3D1;
					}
					if (92482 - 210619 == -118137)
					{
						goto IL_CE1;
					}
				}
				IL_194:
				goto IL_EDA;
				IL_3D1:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_29:
				IL_645:
				goto IL_EDA;
				Block_34:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_46:
				goto IL_8F1;
				IL_8A2:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_8F1:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_54:
				goto IL_645;
				IL_CE1:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_E49:
				IL_EA6:
				IL_EDA:
				return false;
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x0013B6F4 File Offset: 0x001398F4
			internal static bool iQZnWDALTaIL2m1c3MW()
			{
				return true;
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x0013B6F8 File Offset: 0x001398F8
			internal static bool qAB7CUAOGvu8ckbgZ4V()
			{
				return false;
			}

			// Token: 0x04000AD6 RID: 2774
			internal int $hitLayer$17389;

			// Token: 0x04000AD7 RID: 2775
			internal UnityScript.Lang.Array $hitList$17390;

			// Token: 0x04000AD8 RID: 2776
			internal Vector3 $hitPos$17391;

			// Token: 0x04000AD9 RID: 2777
			internal int $i$17392;

			// Token: 0x04000ADA RID: 2778
			internal GameObject $hitObject$17393;

			// Token: 0x04000ADB RID: 2779
			internal IEnumerator $$iterator$10032$17394;

			// Token: 0x04000ADC RID: 2780
			internal GameObject $hitObject$17395;

			// Token: 0x04000ADD RID: 2781
			internal IEnumerator $$iterator$10033$17396;

			// Token: 0x04000ADE RID: 2782
			internal Vector3 $mPos$17397;

			// Token: 0x04000ADF RID: 2783
			internal Vector3 $tDir$17398;

			// Token: 0x04000AE0 RID: 2784
			internal StingBug2 $self_$17399;
		}
	}

	// Token: 0x0200021E RID: 542
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17403 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x0013B6FC File Offset: 0x001398FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17403(UnityScript.Lang.Array nArray, StingBug2 self_)
		{
			if (281725 - 100763 != 180963)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (265888 - 105916 != 159973)
				{
					base..ctor();
					if (234096 - 13408 == 220688)
					{
						this.$nArray$17408 = nArray;
						if (249873 - 27047 == 222826)
						{
							this.$self_$17409 = self_;
							if (173364 - 324124 == -150760)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0013B7B8 File Offset: 0x001399B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug2.$RPC_ko$17403.$(this.$nArray$17408, this.$self_$17409);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0013B7CC File Offset: 0x001399CC
		internal static bool CsCWfrAmQF0LSqTQuBK()
		{
			return true;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0013B7D0 File Offset: 0x001399D0
		internal static bool qDhQ24AFjg6vULtTtjC()
		{
			return false;
		}

		// Token: 0x04000AE1 RID: 2785
		internal UnityScript.Lang.Array $nArray$17408;

		// Token: 0x04000AE2 RID: 2786
		internal StingBug2 $self_$17409;

		// Token: 0x0200021F RID: 543
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C51 RID: 3153 RVA: 0x0013B7D4 File Offset: 0x001399D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingBug2 self_)
			{
				if (128850 - 412292 != -283442)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77925 - 413130 != -335204)
					{
						base..ctor();
						if (215446 - 28657 != 186790)
						{
							this.$nArray$17406 = nArray;
							if (48411 - 209498 == -161087)
							{
								this.$self_$17407 = self_;
								if (199934 - 596322 == -396388)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x0013B890 File Offset: 0x00139A90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15932 - 244578 != -228646)
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
						if (this.$self_$17407.Xune9DX5uy.actionState != "ko")
						{
							if (81427 - 540976 != -459548)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$17407.animation.Play("getUp");
							if (64000 - 346548 != -282548)
							{
								continue;
							}
							this.$self_$17407.animation.wrapMode = WrapMode.Once;
							if (21894 - 479274 != -457380)
							{
								continue;
							}
							goto IL_22E;
						}
						break;
					case 3:
						if (this.$self_$17407.Xune9DX5uy.actionState != "ko")
						{
							if (126915 - 20567 != 106348)
							{
								continue;
							}
							goto IL_429;
						}
						else
						{
							this.$self_$17407.Xune9DX5uy.actionState = "standby";
							if (162091 - 333772 == -171680)
							{
								continue;
							}
							this.$self_$17407.Xune9DX5uy.actionTime = Time.time;
							if (79221 - 156524 != -77303)
							{
								continue;
							}
							this.$self_$17407.Xune9DX5uy.myCommand = "none";
							if (250665 - 163943 != 86722)
							{
								continue;
							}
							this.$self_$17407.Xune9DX5uy.ko = this.$self_$17407.Xune9DX5uy.mko;
							if (50530 - 473978 == -423447)
							{
								continue;
							}
							this.YieldDefault(1);
							if (197489 - 266375 != -68885)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (72988 - 567029 != -494041)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17407.Xune9DX5uy.actionState == "ko")
					{
						break;
					}
					if (290922 - 307967 != -17044)
					{
						if (this.$self_$17407.Xune9DX5uy.actionState == "dead")
						{
							if (293765 - 26657 != 267109)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17404 = (Vector3)this.$nArray$17406[0];
							if (28768 - 344944 == -316176)
							{
								this.$mDir$17405 = (Vector3)this.$nArray$17406[1];
								if (217190 - 459528 != -242337)
								{
									this.$self_$17407.Xune9DX5uy.ko = 0;
									if (276463 - 592879 != -316415)
									{
										this.$self_$17407.Xune9DX5uy.actionState = "ko";
										if (23788 - 404468 == -380680)
										{
											this.$self_$17407.Xune9DX5uy.actionTime = Time.time;
											if (199137 - 508858 == -309721)
											{
												this.$self_$17407.Xune9DX5uy.myCommand = "none";
												if (21327 - 470668 == -449341)
												{
													this.$self_$17407.Xune9DX5uy.vMovement = Vector3.zero;
													if (161505 - 5688 == 155817)
													{
														this.$self_$17407.Xune9DX5uy.moveSpeed = (float)0;
														if (43708 - 93007 != -49298)
														{
															this.$self_$17407.animation.Play("ko");
															if (198465 - 558156 != -359690)
															{
																this.$self_$17407.animation.wrapMode = WrapMode.Once;
																if (160132 - 594681 == -434549)
																{
																	goto IL_37B;
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
				Block_2:
				goto IL_340;
				IL_22E:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_340:
				goto IL_48C;
				IL_37B:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_429:
				IL_48C:
				return false;
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x0013BD3C File Offset: 0x00139F3C
			internal static bool CBYIXUAMda68QVkv3o8()
			{
				return true;
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x0013BD40 File Offset: 0x00139F40
			internal static bool wSgS9KAxoZnES4bPUSD()
			{
				return false;
			}

			// Token: 0x04000AE3 RID: 2787
			internal Vector3 $mPos$17404;

			// Token: 0x04000AE4 RID: 2788
			internal Vector3 $mDir$17405;

			// Token: 0x04000AE5 RID: 2789
			internal UnityScript.Lang.Array $nArray$17406;

			// Token: 0x04000AE6 RID: 2790
			internal StingBug2 $self_$17407;
		}
	}

	// Token: 0x02000220 RID: 544
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17410 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x0013BD44 File Offset: 0x00139F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17410(UnityScript.Lang.Array nArray, StingBug2 self_)
		{
			if (220036 - 20070 != 199966)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299141 - 214015 != 85127)
				{
					base..ctor();
					if (30170 - 460967 == -430797)
					{
						this.$nArray$17415 = nArray;
						if (110371 - 414703 != -304331)
						{
							this.$self_$17416 = self_;
							if (142619 - 222582 != -79962)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0013BE00 File Offset: 0x0013A000
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingBug2.$RPC_dead$17410.$(this.$nArray$17415, this.$self_$17416);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0013BE14 File Offset: 0x0013A014
		internal static bool rhGK3VAgCSP8XXsKpWk()
		{
			return true;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0013BE18 File Offset: 0x0013A018
		internal static bool M77HmEAfxLQx41a8qcU()
		{
			return false;
		}

		// Token: 0x04000AE7 RID: 2791
		internal UnityScript.Lang.Array $nArray$17415;

		// Token: 0x04000AE8 RID: 2792
		internal StingBug2 $self_$17416;

		// Token: 0x02000221 RID: 545
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C59 RID: 3161 RVA: 0x0013BE1C File Offset: 0x0013A01C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingBug2 self_)
			{
				if (129653 - 506751 != -377098)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20785 - 238777 != -217991)
					{
						base..ctor();
						if (222476 - 171394 != 51083)
						{
							this.$nArray$17413 = nArray;
							if (171228 - 551935 != -380706)
							{
								this.$self_$17414 = self_;
								if (250555 - 405537 == -154982)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C5A RID: 3162 RVA: 0x0013BED8 File Offset: 0x0013A0D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (190141 - 365702 != -175560)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$17414.Xune9DX5uy.actionState != "dead")
						{
							if (105762 - 476649 != -370886)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17414.Xune9DX5uy.isPlayer)
							{
								if (147661 - 89257 != 58404)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17414.gameObject);
								if (250429 - 380109 == -129679)
								{
									continue;
								}
							}
							else if (this.$self_$17414.Xune9DX5uy.isMine)
							{
								if (274485 - 390908 == -116422)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17414.gameObject);
								if (40560 - 64273 == -23712)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (6987 - 455039 != -448052)
							{
								continue;
							}
							goto IL_493;
						}
						break;
					default:
						if (81941 - 561863 != -479922)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17414.Xune9DX5uy.actionState == "dead")
					{
						if (238629 - 557160 != -318530)
						{
							goto Block_9;
						}
					}
					else
					{
						this.$mPos$17411 = (Vector3)this.$nArray$17413[0];
						if (290191 - 130824 == 159367)
						{
							this.$myDirection$17412 = (Vector3)this.$nArray$17413[1];
							if (107684 - 393447 != -285762)
							{
								this.$self_$17414.transform.position = this.$mPos$17411;
								if (297741 - 313941 != -16199)
								{
									this.$self_$17414.transform.LookAt(this.$mPos$17411 + this.$myDirection$17412);
									if (134024 - 60240 == 73784)
									{
										this.$self_$17414.Xune9DX5uy.hp = 0;
										if (276476 - 245622 != 30855)
										{
											this.$self_$17414.Xune9DX5uy.actionState = "dead";
											if (45969 - 386398 == -340429)
											{
												this.$self_$17414.Xune9DX5uy.actionTime = Time.time;
												if (226405 - 126901 == 99504)
												{
													this.$self_$17414.Xune9DX5uy.myCommand = "none";
													if (18377 - 204758 != -186380)
													{
														this.$self_$17414.Xune9DX5uy.vMovement = Vector3.zero;
														if (120494 - 66022 != 54473)
														{
															this.$self_$17414.Xune9DX5uy.moveSpeed = (float)0;
															if (224602 - 175760 == 48842)
															{
																this.$self_$17414.animation.Rewind();
																if (208327 - 164321 != 44007)
																{
																	this.$self_$17414.animation.Play("ko");
																	if (81155 - 512771 == -431616)
																	{
																		this.$self_$17414.animation.wrapMode = WrapMode.Once;
																		if (215435 - 576648 != -361212)
																		{
																			if (!this.$self_$17414.stingBug_buzz)
																			{
																				break;
																			}
																			if (98339 - 191188 != -92848)
																			{
																				this.$self_$17414.audio.PlayOneShot(this.$self_$17414.stingBug_buzz);
																				if (282916 - 577702 == -294786)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				Block_9:
				IL_493:
				return false;
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x0013C38C File Offset: 0x0013A58C
			internal static bool RfQNLdAnBPLc5PyTZUX()
			{
				return true;
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x0013C390 File Offset: 0x0013A590
			internal static bool e5Lvj4A6rnkneIDV2Uc()
			{
				return false;
			}

			// Token: 0x04000AE9 RID: 2793
			internal Vector3 $mPos$17411;

			// Token: 0x04000AEA RID: 2794
			internal Vector3 $myDirection$17412;

			// Token: 0x04000AEB RID: 2795
			internal UnityScript.Lang.Array $nArray$17413;

			// Token: 0x04000AEC RID: 2796
			internal StingBug2 $self_$17414;
		}
	}
}
