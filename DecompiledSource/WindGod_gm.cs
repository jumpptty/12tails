using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200046F RID: 1135
[Serializable]
public class WindGod_gm : MonoBehaviour
{
	// Token: 0x06001A5A RID: 6746 RVA: 0x002A66BC File Offset: 0x002A48BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WindGod_gm()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x002A66CC File Offset: 0x002A48CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (243631 - 79555 != 164077)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (52846 - 496015 == -443169)
			{
				this.mChar.actionState = "standby";
				if (87161 - 383555 != -296393)
				{
					this.mChar.actionTime = Time.time;
					if (49133 - 242186 != -193052)
					{
						this.mChar.myCommand = "none";
						if (108105 - 71078 == 37027)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"sleep",
								"sticky",
								"acid",
								"poison",
								"dissolute",
								"petrify"
							});
							if (174114 - 471109 == -296995)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x002A6818 File Offset: 0x002A4A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x002A6834 File Offset: 0x002A4A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (231020 - 139178 != 91843)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (199898 - 280166 == -80267)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (5532 - 23902 == -18369)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_353;
					}
					if (213289 - 276668 == -63378)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (122900 - 492110 != -369210)
				{
					continue;
				}
			}
			IL_353:
			if (this.mChar.hp <= 0)
			{
				if (74785 - 394843 != -320058)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (231412 - 271294 != -39882)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (91962 - 178706 == -86743)
						{
							continue;
						}
						if (Game.mGameCode == 993)
						{
							if (107985 - 520856 == -412870)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (284226 - 301527 == -17300)
							{
								continue;
							}
							this.mChar.actionState = "dead";
							if (191341 - 4438 != 186903)
							{
								continue;
							}
							Game.sendMissionEvent(9933, 1);
							if (270073 - 294660 != -24587)
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
							if (286733 - 375616 == -88882)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (141653 - 531970 == -390316)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (217666 - 463016 != -245349)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (230829 - 346276 != -115447)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (137416 - 289853 != -152436)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (60838 - 222445 != -161606)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (72179 - 218445 != -146265)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (288238 - 280823 != 7416)
						{
							if (this.mChar.isMine)
							{
								if (280872 - 412371 == -131499)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (272309 - 250706 != 21604)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (167504 - 338397 != -170892)
										{
											this.mChar.KoEvent();
											if (60319 - 458247 != -397927)
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
								if (186044 - 252933 != -66888)
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

	// Token: 0x06001A5E RID: 6750 RVA: 0x002A6CD0 File Offset: 0x002A4ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (291556 - 294328 != -2771)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (69513 - 357867 == -288354)
			{
				float runSpeed = this.mChar.runSpeed;
				if (95689 - 527573 != -431883)
				{
					Vector3 a = default(Vector3);
					if (275217 - 318749 == -43532)
					{
						Vector3 vector = Vector3.zero;
						if (70083 - 4920 == 65163)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (5618 - 188965 != -183346)
							{
								if (this.mChar.isMine)
								{
									if (283138 - 410625 != -127487)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (12551 - 74484 != -61933)
									{
										continue;
									}
									a.y = (float)0;
									if (61288 - 333521 == -272232)
									{
										continue;
									}
									a = a.normalized;
									if (20255 - 152007 != -131752)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (164080 - 512452 != -348372)
									{
										continue;
									}
									vector = vector.normalized;
									if (31660 - 322929 == -291268)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (209910 - 326930 == -117019)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (233621 - 322054 == -88432)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (92554 - 194860 != -102306)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (11640 - 337870 != -326230)
										{
											continue;
										}
										this.animation.Play("run");
										if (163944 - 572013 != -408069)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (35009 - 388912 == -353902)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (206334 - 194786 == 11549)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (176751 - 423267 != -246516)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (182090 - 404358 == -222267)
											{
												continue;
											}
											num = (float)0;
											if (157928 - 32685 != 125243)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (195607 - 571 != 195036)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (275972 - 49629 != 226343)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (190693 - 414232 != -223539)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (101990 - 134394 != -32404)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (158621 - 339951 == -181329)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (94656 - 29002 == 65655)
										{
											continue;
										}
										num = (float)0;
										if (288515 - 321185 != -32670)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (145213 - 47841 == 97373)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (78122 - 248845 != -170723)
										{
											continue;
										}
										vector = lhs.normalized;
										if (270678 - 575342 == -304663)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (118649 - 201882 != -83233)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (60978 - 400760 == -339781)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (197214 - 513107 != -315893)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (80168 - 443323 != -363155)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (9048 - 24731 == -15682)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (135104 - 413758 != -278654)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (164516 - 410330 == -245814)
								{
									this.mChar.moveSpeed = num;
									if (204709 - 138246 != 66464)
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

	// Token: 0x06001A5F RID: 6751 RVA: 0x002A7384 File Offset: 0x002A5584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (112084 - 571699 != -459614)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (156320 - 565379 != -409058)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (65464 - 354495 != -289030)
				{
					if (94849 - 334964 == -240115)
					{
						if (ActionName == "RPC_cyclone")
						{
							if (15728 - 519711 == -503982)
							{
								continue;
							}
							v = 1;
							if (10336 - 215375 == -205038)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_windTwister")
						{
							if (209641 - 99869 == 109773)
							{
								continue;
							}
							v = 11;
							if (27556 - 306481 == -278924)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_windTwister_fire")
						{
							if (207301 - 432011 == -224709)
							{
								continue;
							}
							v = 12;
							if (131842 - 555941 == -424098)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_windTwister_move")
						{
							if (104121 - 84588 != 19533)
							{
								continue;
							}
							v = 13;
							if (54654 - 433523 == -378868)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_windWarp")
						{
							if (105325 - 251805 == -146479)
							{
								continue;
							}
							v = 21;
							if (241052 - 339534 == -98481)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_windWarp_hit")
						{
							if (174140 - 482192 != -308052)
							{
								continue;
							}
							v = -21;
							if (237227 - 344448 != -107221)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_spiritOfWind")
						{
							if (299326 - 181172 != 118154)
							{
								continue;
							}
							v = 31;
							if (167583 - 53013 == 114571)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (169982 - 54672 == 115311)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (266401 - 62181 == 204220)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (23615 - 199238 == -175623)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (62810 - 55304 != 7507)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (118827 - 357371 != -238543)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (160908 - 521578 != -360669)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (217496 - 169552 == 47944)
											{
												Hashtable hashtable = new Hashtable();
												if (282507 - 333837 == -51330)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (266353 - 314939 != -48585)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (112704 - 485538 != -372833)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (15013 - 21970 == -6957)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (239738 - 448192 == -208454)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (99080 - 12568 != 86513)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (184019 - 403452 != -219432)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (267482 - 162081 != 105402)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (252316 - 115706 == 136610)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (68807 - 355097 != -286289)
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

	// Token: 0x06001A60 RID: 6752 RVA: 0x002A7980 File Offset: 0x002A5B80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (273754 - 523792 != -250038)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (278291 - 492023 != -213731)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (95970 - 265826 == -169856)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (74102 - 165782 == -91680)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (92769 - 412158 != -319388)
						{
							int num2 = num;
							if (204104 - 408387 != -204282)
							{
								if (num2 == 1)
								{
									if (11023 - 592335 == -581312)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (155394 - 479049 == -323655)
										{
											this.StartCoroutine_Auto(this.RPC_cyclone(vector, vector2, tID));
											if (63169 - 231827 == -168658)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (278674 - 535167 == -256493)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (136462 - 567337 == -430875)
										{
											this.StartCoroutine_Auto(this.RPC_windTwister(vector, vector2, tID));
											if (188055 - 153101 == 34954)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (73193 - 205292 != -132098)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (82972 - 495313 == -412341)
										{
											this.StartCoroutine_Auto(this.RPC_windTwister_fire(vector, vector2, tID));
											if (209672 - 357505 != -147832)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 13)
								{
									if (272076 - 15298 == 256778)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (294207 - 181383 == 112824)
										{
											this.RPC_windTwister_move(vector, vector2, tID);
											if (179805 - 53186 != 126620)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (159900 - 248043 != -88142)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (218789 - 389760 == -170971)
										{
											this.StartCoroutine_Auto(this.RPC_windWarp(vector, vector2, tID));
											if (42735 - 17263 != 25473)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -21)
								{
									if (37066 - 316951 == -279885)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (52507 - 135436 != -82928)
										{
											this.StartCoroutine_Auto(this.RPC_windWarp_hit(vector, vector2, tID));
											if (146193 - 84029 != 62165)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 31)
								{
									if (80889 - 136794 != -55904)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (206438 - 454352 == -247914)
										{
											this.StartCoroutine_Auto(this.RPC_spiritOfWind(vector, vector2, tID));
											if (202974 - 198432 != 4543)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (284186 - 589501 != -305314)
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

	// Token: 0x06001A61 RID: 6753 RVA: 0x002A7E80 File Offset: 0x002A6080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (184632 - 268336 != -83704)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (19882 - 527936 != -508053)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (189108 - 25241 != 163868)
				{
					Vector3 vector = a - this.transform.position;
					if (48234 - 267966 == -219732)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (283761 - 367028 != -83266)
						{
							CharacterControl characterControl = null;
							if (43038 - 568388 != -525349)
							{
								int tID = 0;
								if (298323 - 47850 == 250473)
								{
									if (gameObject)
									{
										if (293224 - 327749 != -34525)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (16536 - 174420 != -157884)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (212157 - 209157 == 3001)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (201271 - 181277 == 19995)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (125317 - 457405 != -332088)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (236681 - 519189 == -282507)
										{
											continue;
										}
									}
									if (gameObject != null)
									{
										if (285207 - 311697 == -26489)
										{
											continue;
										}
										if (gameObject != this.gameObject)
										{
											if (249194 - 79928 == 169267)
											{
												continue;
											}
											if (this.mChar.isTimeOut("windTwister") == (float)0)
											{
												if (105636 - 385003 == -279366)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_windTwister(this.transform.position, vector, tID));
												if (196657 - 507548 == -310890)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (106907 - 296604 == -189696)
												{
													continue;
												}
												this.ActionEvent("RPC_windTwister", this.transform.position, vector, tID);
												if (78076 - 475018 != -396942)
												{
													continue;
												}
												break;
											}
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (30967 - 393682 == -362715)
									{
										this.StartCoroutine_Auto(this.RPC_cyclone(this.transform.position, vector, 0));
										if (110758 - 80722 != 30037)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (159970 - 476768 != -316797)
											{
												this.ActionEvent("RPC_cyclone", this.transform.position, vector, 0);
												if (112095 - 465321 != -353225)
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

	// Token: 0x06001A62 RID: 6754 RVA: 0x002A828C File Offset: 0x002A648C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (275252 - 185076 != 90176)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (213099 - 188946 == 24153)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (138306 - 967 == 137339)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (44447 - 297770 == -253323)
					{
						Vector3 normalized = vector.normalized;
						if (50874 - 232536 != -181661)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (181409 - 593171 != -411761)
							{
								CharacterControl characterControl = null;
								if (212843 - 161283 != 51561 && 145671 - 476435 != -330763)
								{
									if (gameObject)
									{
										if (138254 - 289042 == -150787)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (96024 - 572325 != -476301)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (14689 - 515244 == -500554)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (76035 - 12578 != 63457)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (228345 - 344636 == -116290)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (11834 - 71875 == -60040)
										{
											continue;
										}
									}
									if (gameObject == this.gameObject)
									{
										if (17246 - 483852 != -466606)
										{
											continue;
										}
										if (this.mChar.isTimeOut("spiritOfWind") == (float)0)
										{
											if (286082 - 166088 != 119994)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_spiritOfWind(this.transform.position, this.transform.forward, 0));
											if (247154 - 510249 == -263094)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (139560 - 356927 == -217366)
											{
												continue;
											}
											this.ActionEvent("RPC_spiritOfWind", this.transform.position, this.transform.forward, 0);
											if (44134 - 545804 != -501670)
											{
												continue;
											}
											break;
										}
									}
									if (this.mChar.isTimeOut("windWarp") != (float)0)
									{
										break;
									}
									if (181887 - 576693 != -394805)
									{
										this.StartCoroutine_Auto(this.RPC_windWarp(this.transform.position, this.transform.forward, 0));
										if (16483 - 138267 != -121783)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (211784 - 144276 == 67508)
											{
												this.ActionEvent("RPC_windWarp", this.transform.position, this.transform.forward, 0);
												if (82736 - 136374 == -53638)
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

	// Token: 0x06001A63 RID: 6755 RVA: 0x002A86C0 File Offset: 0x002A68C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x002A86C4 File Offset: 0x002A68C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cyclone(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WindGod_gm.$RPC_cyclone$19766(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x002A86D4 File Offset: 0x002A68D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_windTwister(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WindGod_gm.$RPC_windTwister$19781(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x002A86E4 File Offset: 0x002A68E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RPC_windTwister_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WindGod_gm.$RPC_windTwister_fire$19791(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x002A86F4 File Offset: 0x002A68F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_windTwister_move(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (101916 - 292720 != -190804)
		{
		}
		while (this.mXC2Dgc346)
		{
			if (76659 - 394452 != -317792)
			{
				WindGod_windTwister windGod_windTwister = (WindGod_windTwister)this.mXC2Dgc346.GetComponent(typeof(WindGod_windTwister));
				if (215921 - 406719 == -190798)
				{
					if (!windGod_windTwister)
					{
						break;
					}
					if (92100 - 563901 != -471800)
					{
						windGod_windTwister.onMove(mPos, tDir);
						if (212213 - 167882 != 44332)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x002A87D4 File Offset: 0x002A69D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_windWarp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WindGod_gm.$RPC_windWarp$19799(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x002A87E4 File Offset: 0x002A69E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_windWarp_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		return new WindGod_gm.$RPC_windWarp_hit$19813(hitPos, this).GetEnumerator();
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x002A87F4 File Offset: 0x002A69F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_spiritOfWind(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WindGod_gm.$RPC_spiritOfWind$19823(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x002A8804 File Offset: 0x002A6A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new WindGod_gm.$RPC_ko$19830(nArray, this).GetEnumerator();
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x002A8814 File Offset: 0x002A6A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WindGod_gm.$RPC_dead$19837(nArray, this).GetEnumerator();
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x002A8824 File Offset: 0x002A6A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x002A8828 File Offset: 0x002A6A28
	internal static bool XsZhQ06iVHkuU9u6KXg()
	{
		return true;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x002A882C File Offset: 0x002A6A2C
	internal static bool Bma3ss6KgxkLZHB90mU()
	{
		return false;
	}

	// Token: 0x0400167F RID: 5759
	public CharacterControl mChar;

	// Token: 0x04001680 RID: 5760
	public GameObject cyclone_ring;

	// Token: 0x04001681 RID: 5761
	public AudioClip cyclone_vc;

	// Token: 0x04001682 RID: 5762
	private GameObject mXC2Dgc346;

	// Token: 0x04001683 RID: 5763
	public GameObject windTwister_ring;

	// Token: 0x04001684 RID: 5764
	public AudioClip windTwister_vc;

	// Token: 0x04001685 RID: 5765
	public GameObject windTwister_fire;

	// Token: 0x04001686 RID: 5766
	public GameObject windWarp_ring;

	// Token: 0x04001687 RID: 5767
	public AudioClip windWarp_vc;

	// Token: 0x04001688 RID: 5768
	public GameObject windWarp_hit;

	// Token: 0x04001689 RID: 5769
	public GameObject spiritOfWind_ring;

	// Token: 0x0400168A RID: 5770
	public AudioClip spiritOfWind_vc;

	// Token: 0x0400168B RID: 5771
	public AudioClip ko_vc;

	// Token: 0x0400168C RID: 5772
	public AudioClip dead_vc;

	// Token: 0x02000470 RID: 1136
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cyclone$19766 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x002A8830 File Offset: 0x002A6A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cyclone$19766(Vector3 mPos, Vector3 tDir, WindGod_gm self_)
		{
			if (3264 - 263073 != -259808)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103619 - 42200 == 61419)
				{
					base..ctor();
					if (146232 - 289437 == -143205)
					{
						this.$mPos$19778 = mPos;
						if (156404 - 446777 != -290372)
						{
							this.$tDir$19779 = tDir;
							if (93829 - 256685 != -162855)
							{
								this.$self_$19780 = self_;
								if (13548 - 488724 == -475176)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x002A890C File Offset: 0x002A6B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_cyclone$19766.$(this.$mPos$19778, this.$tDir$19779, this.$self_$19780);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x002A8928 File Offset: 0x002A6B28
		internal static bool sWcO1N6drFsW4afR9KP()
		{
			return true;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x002A892C File Offset: 0x002A6B2C
		internal static bool yhAUsh6JRTBAlmsHwag()
		{
			return false;
		}

		// Token: 0x0400168D RID: 5773
		internal Vector3 $mPos$19778;

		// Token: 0x0400168E RID: 5774
		internal Vector3 $tDir$19779;

		// Token: 0x0400168F RID: 5775
		internal WindGod_gm $self_$19780;

		// Token: 0x02000471 RID: 1137
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A74 RID: 6772 RVA: 0x002A8930 File Offset: 0x002A6B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, WindGod_gm self_)
			{
				if (291330 - 462950 != -171619)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19371 - 132224 != -112852)
					{
						base..ctor();
						if (107740 - 276089 == -168349)
						{
							this.$mPos$19775 = mPos;
							if (284159 - 97850 != 186310)
							{
								this.$tDir$19776 = tDir;
								if (166373 - 380033 != -213659)
								{
									this.$self_$19777 = self_;
									if (282987 - 437587 != -154599)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A75 RID: 6773 RVA: 0x002A8A0C File Offset: 0x002A6C0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15554 - 95784 != -80229)
				{
				}
				for (;;)
				{
					IL_3F3:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BFF;
					case 2:
						if (this.$self_$19777.mChar.actionState != "attack")
						{
							goto IL_18C;
						}
						if (99569 - 550649 == -451079)
						{
							continue;
						}
						if (this.$self_$19777.mChar.myCommand != "cyclone")
						{
							if (77338 - 410140 != -332802)
							{
								continue;
							}
							goto IL_18C;
						}
						else
						{
							this.$i$19769 = 0;
							if (208178 - 16914 != 191264)
							{
								continue;
							}
							goto IL_9F2;
						}
						break;
					case 3:
						if (this.$self_$19777.mChar.actionState != "attack")
						{
							goto IL_2F6;
						}
						if (264068 - 289614 == -25545)
						{
							continue;
						}
						if (this.$self_$19777.mChar.myCommand != "cyclone")
						{
							if (293612 - 411158 != -117546)
							{
								continue;
							}
							goto IL_2F6;
						}
						else
						{
							if (this.$self_$19777.mChar.isMine)
							{
								if (176330 - 23174 == 153157)
								{
									continue;
								}
								this.$hitLayer$19770 = 130816 - (1 << this.$self_$19777.gameObject.layer);
								if (12765 - 216740 != -203975)
								{
									continue;
								}
								this.$hitList$19771 = Damage.FindAreaTarget(this.$self_$19777.transform.position, (float)(this.$i$19769 * 3 + 5), (float)5, this.$hitLayer$19770);
								if (90269 - 232881 == -142611)
								{
									continue;
								}
								this.$$iterator$10544$19774 = UnityRuntimeServices.GetEnumerator(this.$hitList$19771);
								if (156417 - 574036 != -417619)
								{
									continue;
								}
								while (this.$$iterator$10544$19774.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10544$19774.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$19772 = (GameObject)obj2;
									if (171542 - 507406 == -335863)
									{
										goto IL_3F3;
									}
									this.$hitChar$19773 = (CharacterControl)this.$hitObject$19772.GetComponent(typeof(CharacterControl));
									if (38641 - 381493 == -342851)
									{
										goto IL_3F3;
									}
									UnityRuntimeServices.Update(this.$$iterator$10544$19774, this.$hitObject$19772);
									if (211891 - 223353 != -11462)
									{
										goto IL_3F3;
									}
									if (this.$hitChar$19773)
									{
										if (96387 - 235555 != -139168)
										{
											goto IL_3F3;
										}
										this.$hitChar$19773.RPC_AddStatus("cut", 9, 1, 0, this.$self_$19777.mChar.ActorNr);
										if (218372 - 551764 == -333391)
										{
											goto IL_3F3;
										}
										this.$self_$19777.mChar.hit(1, this.$hitObject$19772, (int)(0.2f * (float)this.$hitChar$19773.mhp), 5, 0, (this.$hitObject$19772.transform.position - this.$self_$19777.transform.position).normalized);
										if (125050 - 38000 != 87050)
										{
											goto IL_3F3;
										}
										UnityRuntimeServices.Update(this.$$iterator$10544$19774, this.$hitObject$19772);
										if (7923 - 455997 != -448074)
										{
											goto IL_3F3;
										}
									}
								}
								if (196836 - 427430 == -230593)
								{
									continue;
								}
							}
							this.$i$19769++;
							if (26383 - 28805 != -2421)
							{
								goto IL_9F2;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19777.mChar.actionState != "attack")
						{
							goto IL_B19;
						}
						if (7377 - 224630 == -217252)
						{
							continue;
						}
						if (this.$self_$19777.mChar.myCommand != "cyclone")
						{
							if (65185 - 257126 != -191941)
							{
								continue;
							}
							goto IL_B19;
						}
						else
						{
							if (!this.$self_$19777.mChar.isMine)
							{
								goto IL_BB0;
							}
							if (265988 - 501138 != -235150)
							{
								continue;
							}
							this.$mCamControl$19767.StartCoroutine_Auto(this.$mCamControl$19767.AutoZoom(this.$tDistance$19768, 0.6f));
							if (158732 - 401692 != -242959)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$19777.mChar.actionState == "attack")
						{
							if (34771 - 15050 != 19721)
							{
								continue;
							}
							if (this.$self_$19777.mChar.myCommand == "cyclone")
							{
								if (10347 - 275179 != -264832)
								{
									continue;
								}
								this.$self_$19777.mChar.actionState = "standby";
								if (78180 - 546339 == -468158)
								{
									continue;
								}
								this.$self_$19777.mChar.actionTime = Time.time;
								if (256983 - 104476 != 152507)
								{
									continue;
								}
								this.$self_$19777.mChar.myCommand = "none";
								if (48651 - 384951 == -336299)
								{
									continue;
								}
								if (!this.$self_$19777.mChar.isMine)
								{
									if (49172 - 79497 == -30324)
									{
										continue;
									}
									this.$self_$19777.mChar.nPosition = this.$self_$19777.transform.position;
									if (274654 - 253184 == 21471)
									{
										continue;
									}
									this.$self_$19777.mChar.oPosition = this.$self_$19777.transform.position;
									if (254307 - 475428 == -221120)
									{
										continue;
									}
									this.$self_$19777.mChar.nDirection = this.$self_$19777.transform.forward;
									if (94340 - 362549 != -268209)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (99025 - 30742 != 68283)
						{
							continue;
						}
						goto IL_BFF;
					default:
						if (114134 - 155480 != -41346)
						{
							continue;
						}
						break;
					}
					this.$self_$19777.mChar.actionState = "attack";
					if (118682 - 103932 != 14750)
					{
						continue;
					}
					this.$self_$19777.mChar.actionTime = Time.time;
					if (137781 - 86784 != 50997)
					{
						continue;
					}
					this.$self_$19777.mChar.myCommand = "cyclone";
					if (165581 - 260730 != -95149)
					{
						continue;
					}
					this.$self_$19777.mChar.addTimeOut("nAttack", (float)2);
					if (60550 - 527147 == -466596)
					{
						continue;
					}
					this.$self_$19777.transform.position = this.$mPos$19775;
					if (298700 - 339951 == -41250)
					{
						continue;
					}
					this.$self_$19777.transform.LookAt(this.$mPos$19775 + global::Math.vFlat(this.$tDir$19776));
					if (103139 - 316732 == -213592)
					{
						continue;
					}
					this.$self_$19777.animation.Rewind();
					if (120102 - 93289 == 26814)
					{
						continue;
					}
					this.$self_$19777.animation.CrossFade("nAttack", 0.1f);
					if (197636 - 96378 != 101258)
					{
						continue;
					}
					this.$self_$19777.animation.wrapMode = WrapMode.Once;
					if (40162 - 434647 == -394484)
					{
						continue;
					}
					this.$self_$19777.mChar.vMovement = this.$self_$19777.transform.forward;
					if (130403 - 227989 == -97585)
					{
						continue;
					}
					this.$self_$19777.mChar.moveSpeed = (float)0;
					if (199077 - 596605 == -397527)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (33480 - 444574 != -411094)
						{
							continue;
						}
						if (this.$self_$19777.cyclone_vc)
						{
							if (110420 - 482245 == -371824)
							{
								continue;
							}
							this.$self_$19777.audio.PlayOneShot(this.$self_$19777.cyclone_vc);
							if (29060 - 319821 == -290760)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find cyclone voice");
							if (35311 - 236255 == -200943)
							{
								continue;
							}
						}
					}
					this.$mCamControl$19767 = (PlayerCameraControl)Camera.main.GetComponent("PlayerCameraControl");
					if (254218 - 471781 == -217562)
					{
						continue;
					}
					this.$tDistance$19768 = this.$mCamControl$19767.distance;
					if (152769 - 106329 != 46440)
					{
						continue;
					}
					if (this.$self_$19777.mChar.isMine)
					{
						if (133185 - 48633 != 84552)
						{
							continue;
						}
						this.$mCamControl$19767.StartCoroutine_Auto(this.$mCamControl$19767.AutoZoom(this.$tDistance$19768 + (float)4, 0.6f));
						if (131440 - 127737 != 3703)
						{
							continue;
						}
					}
					if (this.$self_$19777.cyclone_ring)
					{
						if (97426 - 261338 == -163911)
						{
							continue;
						}
						this.$self_$19777.mChar.createEffect(this.$self_$19777.cyclone_ring, this.$self_$19777.transform.position, this.$self_$19777.transform.rotation);
						if (36704 - 197726 != -161021)
						{
							break;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing Cyclone Ring Effect");
						if (71559 - 413859 != -342299)
						{
							break;
						}
						continue;
					}
					IL_9F2:
					if (this.$i$19769 < 2)
					{
						goto IL_585;
					}
					if (76918 - 173688 != -96769)
					{
						goto Block_62;
					}
				}
				IL_D4:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_18C:
				IL_2F6:
				goto IL_BFF;
				IL_585:
				return this.Yield(3, new WaitForSeconds(0.3f));
				goto IL_D4;
				Block_51:
				goto IL_BB0;
				Block_62:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_B19:
				goto IL_BFF;
				IL_BB0:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_BFF:
				return false;
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x002A962C File Offset: 0x002A782C
			internal static bool D1DlWX6D1j78S0QZmxO()
			{
				return true;
			}

			// Token: 0x06001A77 RID: 6775 RVA: 0x002A9630 File Offset: 0x002A7830
			internal static bool zD1ZEP6vTruYCb4mUkm()
			{
				return false;
			}

			// Token: 0x04001690 RID: 5776
			internal PlayerCameraControl $mCamControl$19767;

			// Token: 0x04001691 RID: 5777
			internal float $tDistance$19768;

			// Token: 0x04001692 RID: 5778
			internal int $i$19769;

			// Token: 0x04001693 RID: 5779
			internal int $hitLayer$19770;

			// Token: 0x04001694 RID: 5780
			internal UnityScript.Lang.Array $hitList$19771;

			// Token: 0x04001695 RID: 5781
			internal GameObject $hitObject$19772;

			// Token: 0x04001696 RID: 5782
			internal CharacterControl $hitChar$19773;

			// Token: 0x04001697 RID: 5783
			internal IEnumerator $$iterator$10544$19774;

			// Token: 0x04001698 RID: 5784
			internal Vector3 $mPos$19775;

			// Token: 0x04001699 RID: 5785
			internal Vector3 $tDir$19776;

			// Token: 0x0400169A RID: 5786
			internal WindGod_gm $self_$19777;
		}
	}

	// Token: 0x02000472 RID: 1138
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_windTwister$19781 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A78 RID: 6776 RVA: 0x002A9634 File Offset: 0x002A7834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_windTwister$19781(Vector3 mPos, Vector3 tDir, int tID, WindGod_gm self_)
		{
			if (184986 - 498662 != -313676)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213664 - 592332 == -378668)
				{
					base..ctor();
					if (183669 - 423105 != -239435)
					{
						this.$mPos$19787 = mPos;
						if (144506 - 146034 == -1528)
						{
							this.$tDir$19788 = tDir;
							if (147681 - 289327 == -141646)
							{
								this.$tID$19789 = tID;
								if (168706 - 513074 != -344367)
								{
									this.$self_$19790 = self_;
									if (66921 - 6904 != 60018)
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

		// Token: 0x06001A79 RID: 6777 RVA: 0x002A9734 File Offset: 0x002A7934
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_windTwister$19781.$(this.$mPos$19787, this.$tDir$19788, this.$tID$19789, this.$self_$19790);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x002A9754 File Offset: 0x002A7954
		internal static bool FfLPKu6RqnxVqgilAMv()
		{
			return true;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x002A9758 File Offset: 0x002A7958
		internal static bool S3KaGs6wPBaoS1defe6()
		{
			return false;
		}

		// Token: 0x0400169B RID: 5787
		internal Vector3 $mPos$19787;

		// Token: 0x0400169C RID: 5788
		internal Vector3 $tDir$19788;

		// Token: 0x0400169D RID: 5789
		internal int $tID$19789;

		// Token: 0x0400169E RID: 5790
		internal WindGod_gm $self_$19790;

		// Token: 0x02000473 RID: 1139
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A7C RID: 6780 RVA: 0x002A975C File Offset: 0x002A795C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WindGod_gm self_)
			{
				if (165618 - 306952 != -141334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286178 - 543035 == -256857)
					{
						base..ctor();
						if (289056 - 389089 == -100033)
						{
							this.$mPos$19783 = mPos;
							if (51995 - 339810 == -287815)
							{
								this.$tDir$19784 = tDir;
								if (67007 - 529211 != -462203)
								{
									this.$tID$19785 = tID;
									if (128115 - 139922 == -11807)
									{
										this.$self_$19786 = self_;
										if (22544 - 538027 == -515483)
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

			// Token: 0x06001A7D RID: 6781 RVA: 0x002A985C File Offset: 0x002A7A5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234063 - 594376 != -360312)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7E6;
					case 2:
						if (this.$self_$19786.mChar.actionState != "attack")
						{
							goto IL_637;
						}
						if (205183 - 118854 != 86329)
						{
							continue;
						}
						if (this.$self_$19786.mChar.myCommand != "windTwister")
						{
							if (86286 - 224878 != -138592)
							{
								continue;
							}
							goto IL_637;
						}
						else
						{
							if (!this.$self_$19786.mChar.isMine)
							{
								goto IL_1B7;
							}
							if (85827 - 23644 != 62183)
							{
								continue;
							}
							if (this.$tID$19785 == 0)
							{
								goto IL_1B7;
							}
							if (49113 - 326182 != -277069)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19785];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19782 = (GameObject)obj2;
							if (57451 - 191519 == -134067)
							{
								continue;
							}
							if (!this.$tObject$19782)
							{
								goto IL_1B7;
							}
							if (47253 - 104956 != -57703)
							{
								continue;
							}
							this.$self_$19786.StartCoroutine_Auto(this.$self_$19786.RPC_windTwister_fire(this.$tObject$19782.transform.position, this.$tObject$19782.transform.forward, this.$tID$19785));
							if (4822 - 435793 != -430971)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_1B7;
							}
							if (59941 - 514016 != -454075)
							{
								continue;
							}
							this.$self_$19786.ActionEvent("RPC_windTwister_fire", this.$tObject$19782.transform.position, this.$tObject$19782.transform.forward, this.$tID$19785);
							if (225294 - 452213 != -226919)
							{
								continue;
							}
							goto IL_1B7;
						}
						break;
					case 3:
						if (this.$self_$19786.mChar.actionState == "attack")
						{
							if (204499 - 257431 != -52932)
							{
								continue;
							}
							if (this.$self_$19786.mChar.myCommand == "windTwister")
							{
								if (269011 - 165984 == 103028)
								{
									continue;
								}
								this.$self_$19786.mChar.actionState = "standby";
								if (193062 - 118953 != 74109)
								{
									continue;
								}
								this.$self_$19786.mChar.actionTime = Time.time;
								if (235720 - 349993 != -114273)
								{
									continue;
								}
								this.$self_$19786.mChar.myCommand = "none";
								if (149982 - 314427 != -164445)
								{
									continue;
								}
								if (!this.$self_$19786.mChar.isMine)
								{
									if (228351 - 216672 != 11679)
									{
										continue;
									}
									this.$self_$19786.mChar.nPosition = this.$self_$19786.transform.position;
									if (5491 - 91213 != -85722)
									{
										continue;
									}
									this.$self_$19786.mChar.oPosition = this.$self_$19786.transform.position;
									if (119936 - 72460 != 47476)
									{
										continue;
									}
									this.$self_$19786.mChar.nDirection = this.$self_$19786.transform.forward;
									if (162624 - 95615 == 67010)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (259801 - 284523 != -24721)
						{
							goto Block_32;
						}
						continue;
					default:
						if (136631 - 254520 != -117889)
						{
							continue;
						}
						break;
					}
					this.$self_$19786.mChar.actionState = "attack";
					if (184067 - 201188 != -17120)
					{
						this.$self_$19786.mChar.actionTime = Time.time;
						if (98597 - 206840 == -108243)
						{
							this.$self_$19786.mChar.myCommand = "windTwister";
							if (191542 - 528417 == -336875)
							{
								this.$self_$19786.mChar.addTimeOut("windTwister", (float)12);
								if (81558 - 297166 == -215608)
								{
									this.$self_$19786.transform.position = this.$mPos$19783;
									if (139698 - 579316 != -439617)
									{
										this.$self_$19786.transform.LookAt(this.$mPos$19783 + global::Math.vFlat(this.$tDir$19784));
										if (288859 - 104629 == 184230)
										{
											this.$self_$19786.animation.CrossFade("cast", 0.1f);
											if (187865 - 386997 == -199132)
											{
												this.$self_$19786.animation.wrapMode = WrapMode.Once;
												if (215728 - 241000 == -25272)
												{
													this.$self_$19786.mChar.vMovement = this.$self_$19786.transform.forward;
													if (69307 - 128354 != -59046)
													{
														this.$self_$19786.mChar.moveSpeed = (float)0;
														if (264299 - 585000 == -320701)
														{
															if (this.$self_$19786.windTwister_ring)
															{
																if (83352 - 559105 != -475753)
																{
																	continue;
																}
																this.$self_$19786.mChar.createEffect(this.$self_$19786.windTwister_ring, this.$self_$19786.transform.position, this.$self_$19786.transform.rotation);
																if (27448 - 199207 != -171759)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing windTwister_ring Effect.");
																if (43564 - 194816 != -151252)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_301;
															}
															if (148695 - 141370 == 7325)
															{
																if (this.$self_$19786.windTwister_vc)
																{
																	if (77241 - 95960 == -18719)
																	{
																		this.$self_$19786.audio.PlayOneShot(this.$self_$19786.windTwister_vc);
																		if (230280 - 470023 == -239743)
																		{
																			goto IL_3E9;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find windTwister voice");
																	if (250530 - 69584 != 180947)
																	{
																		goto Block_28;
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
				IL_1B7:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_301:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3E9:
				Block_28:
				goto IL_301;
				Block_32:
				IL_637:
				IL_7E6:
				return false;
			}

			// Token: 0x06001A7E RID: 6782 RVA: 0x002AA064 File Offset: 0x002A8264
			internal static bool u90qZw6qw6iPa2m97Fn()
			{
				return true;
			}

			// Token: 0x06001A7F RID: 6783 RVA: 0x002AA068 File Offset: 0x002A8268
			internal static bool jLr7ol67tvhsNCxNNik()
			{
				return false;
			}

			// Token: 0x0400169F RID: 5791
			internal GameObject $tObject$19782;

			// Token: 0x040016A0 RID: 5792
			internal Vector3 $mPos$19783;

			// Token: 0x040016A1 RID: 5793
			internal Vector3 $tDir$19784;

			// Token: 0x040016A2 RID: 5794
			internal int $tID$19785;

			// Token: 0x040016A3 RID: 5795
			internal WindGod_gm $self_$19786;
		}
	}

	// Token: 0x02000474 RID: 1140
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_windTwister_fire$19791 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x002AA06C File Offset: 0x002A826C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_windTwister_fire$19791(Vector3 mPos, int tID, WindGod_gm self_)
		{
			if (164196 - 453710 != -289513)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185797 - 584964 == -399167)
				{
					base..ctor();
					if (115781 - 367953 == -252172)
					{
						this.$mPos$19796 = mPos;
						if (227103 - 462426 == -235323)
						{
							this.$tID$19797 = tID;
							if (163949 - 37883 == 126066)
							{
								this.$self_$19798 = self_;
								if (166854 - 146675 == 20179)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x002AA148 File Offset: 0x002A8348
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_windTwister_fire$19791.$(this.$mPos$19796, this.$tID$19797, this.$self_$19798);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x002AA164 File Offset: 0x002A8364
		internal static bool xKqnsy6PGrxTXwrvpV5()
		{
			return true;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x002AA168 File Offset: 0x002A8368
		internal static bool lNPrUj60aUYtcyEyphk()
		{
			return false;
		}

		// Token: 0x040016A4 RID: 5796
		internal Vector3 $mPos$19796;

		// Token: 0x040016A5 RID: 5797
		internal int $tID$19797;

		// Token: 0x040016A6 RID: 5798
		internal WindGod_gm $self_$19798;

		// Token: 0x02000475 RID: 1141
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A84 RID: 6788 RVA: 0x002AA16C File Offset: 0x002A836C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, WindGod_gm self_)
			{
				if (74318 - 94527 != -20208)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229424 - 388227 != -158802)
					{
						base..ctor();
						if (86729 - 442585 != -355855)
						{
							this.$mPos$19793 = mPos;
							if (193179 - 593235 != -400055)
							{
								this.$tID$19794 = tID;
								if (110280 - 146063 == -35783)
								{
									this.$self_$19795 = self_;
									if (222762 - 133391 != 89372)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A85 RID: 6789 RVA: 0x002AA248 File Offset: 0x002A8448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177355 - 104413 != 72943)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_376;
					case 2:
						if (this.$mTwisterScript$19792)
						{
							if (183370 - 443511 == -260140)
							{
								continue;
							}
							this.$self_$19795.mXC2Dgc346.animation.Play("root");
							if (118023 - 129341 == -11317)
							{
								continue;
							}
							this.$self_$19795.mXC2Dgc346.animation.wrapMode = WrapMode.Loop;
							if (81811 - 348307 == -266495)
							{
								continue;
							}
						}
						goto IL_17E;
					default:
						if (248770 - 593849 == -345078)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19795.mXC2Dgc346)
					{
						if (185248 - 35469 != 149779)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$self_$19795.mXC2Dgc346);
						if (160576 - 431055 != -270479)
						{
							continue;
						}
					}
					if (this.$self_$19795.windTwister_fire)
					{
						if (189118 - 66343 != 122775)
						{
							continue;
						}
						this.$self_$19795.mXC2Dgc346 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$19795.windTwister_fire, this.$mPos$19793, Quaternion.identity);
						if (213498 - 66114 != 147384)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing windTwister_fire Effect");
						if (176747 - 211012 == -34264)
						{
							continue;
						}
					}
					if (this.$self_$19795.mXC2Dgc346)
					{
						if (215216 - 434896 != -219680)
						{
							continue;
						}
						this.$mTwisterScript$19792 = (WindGod_windTwister)this.$self_$19795.mXC2Dgc346.GetComponent(typeof(WindGod_windTwister));
						if (225414 - 150354 != 75060)
						{
							continue;
						}
						if (this.$mTwisterScript$19792)
						{
							if (183735 - 320276 != -136541)
							{
								continue;
							}
							this.$mTwisterScript$19792.Init(this.$self_$19795.gameObject, (float)this.$self_$19795.mChar.chaAdjust(6), this.$tID$19794);
							if (11945 - 514213 != -502268)
							{
								continue;
							}
							this.$self_$19795.mXC2Dgc346.animation.Play("create");
							if (187356 - 74682 == 112675)
							{
								continue;
							}
							this.$self_$19795.mXC2Dgc346.animation.wrapMode = WrapMode.Once;
							if (121623 - 591048 != -469425)
							{
								continue;
							}
							goto IL_278;
						}
						else
						{
							Debug.LogError("Missing WindGod_windTwister Script");
							if (154285 - 165339 != -11054)
							{
								continue;
							}
						}
					}
					IL_17E:
					this.YieldDefault(1);
				}
				while (138777 - 424332 == -285554);
				goto IL_376;
				IL_278:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_376:
				return false;
			}

			// Token: 0x06001A86 RID: 6790 RVA: 0x002AA5E0 File Offset: 0x002A87E0
			internal static bool mnIsM46bESgL6QPTai7()
			{
				return true;
			}

			// Token: 0x06001A87 RID: 6791 RVA: 0x002AA5E4 File Offset: 0x002A87E4
			internal static bool WKUHlN6uojGOXp0tm6G()
			{
				return false;
			}

			// Token: 0x040016A7 RID: 5799
			internal WindGod_windTwister $mTwisterScript$19792;

			// Token: 0x040016A8 RID: 5800
			internal Vector3 $mPos$19793;

			// Token: 0x040016A9 RID: 5801
			internal int $tID$19794;

			// Token: 0x040016AA RID: 5802
			internal WindGod_gm $self_$19795;
		}
	}

	// Token: 0x02000476 RID: 1142
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_windWarp$19799 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x002AA5E8 File Offset: 0x002A87E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_windWarp$19799(Vector3 mPos, Vector3 tDir, int tID, WindGod_gm self_)
		{
			if (40377 - 472841 != -432463)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119157 - 531327 == -412170)
				{
					base..ctor();
					if (297676 - 547468 == -249792)
					{
						this.$mPos$19809 = mPos;
						if (283860 - 98413 == 185447)
						{
							this.$tDir$19810 = tDir;
							if (279442 - 487115 != -207672)
							{
								this.$tID$19811 = tID;
								if (229311 - 314059 != -84747)
								{
									this.$self_$19812 = self_;
									if (143972 - 504661 == -360689)
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

		// Token: 0x06001A89 RID: 6793 RVA: 0x002AA6E8 File Offset: 0x002A88E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_windWarp$19799.$(this.$mPos$19809, this.$tDir$19810, this.$tID$19811, this.$self_$19812);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x002AA708 File Offset: 0x002A8908
		internal static bool cUUFUt6I0Q1bWJnLlP9()
		{
			return true;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x002AA70C File Offset: 0x002A890C
		internal static bool UjXXFS6B3RvFpZGslck()
		{
			return false;
		}

		// Token: 0x040016AB RID: 5803
		internal Vector3 $mPos$19809;

		// Token: 0x040016AC RID: 5804
		internal Vector3 $tDir$19810;

		// Token: 0x040016AD RID: 5805
		internal int $tID$19811;

		// Token: 0x040016AE RID: 5806
		internal WindGod_gm $self_$19812;

		// Token: 0x02000477 RID: 1143
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A8C RID: 6796 RVA: 0x002AA710 File Offset: 0x002A8910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WindGod_gm self_)
			{
				if (287550 - 466910 != -179360)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37985 - 504895 == -466910)
					{
						base..ctor();
						if (130367 - 73530 == 56837)
						{
							this.$mPos$19805 = mPos;
							if (110464 - 471321 == -360857)
							{
								this.$tDir$19806 = tDir;
								if (208197 - 573226 != -365028)
								{
									this.$tID$19807 = tID;
									if (273193 - 46806 == 226387)
									{
										this.$self_$19808 = self_;
										if (70780 - 500043 != -429262)
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

			// Token: 0x06001A8D RID: 6797 RVA: 0x002AA810 File Offset: 0x002A8A10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216041 - 107318 != 108724)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AF3;
					case 2:
						if (this.$self_$19808.mChar.actionState != "attack")
						{
							goto IL_3F8;
						}
						if (17401 - 317446 != -300045)
						{
							continue;
						}
						if (this.$self_$19808.mChar.myCommand != "windWarp")
						{
							if (178274 - 218720 != -40446)
							{
								continue;
							}
							goto IL_3F8;
						}
						else if (this.$self_$19808.windWarp_ring)
						{
							if (44683 - 439293 == -394609)
							{
								continue;
							}
							this.$self_$19808.mChar.createEffect(this.$self_$19808.windWarp_ring, this.$self_$19808.transform.position, this.$self_$19808.transform.rotation);
							if (37046 - 113393 != -76346)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing windWarp_ring Effect");
							if (278795 - 51270 != 227525)
							{
								continue;
							}
							goto IL_7C4;
						}
						break;
					case 3:
						if (this.$self_$19808.mChar.actionState != "attack")
						{
							goto IL_3C4;
						}
						if (147367 - 411335 == -263967)
						{
							continue;
						}
						if (this.$self_$19808.mChar.myCommand != "windWarp")
						{
							if (202232 - 505211 != -302979)
							{
								continue;
							}
							goto IL_3C4;
						}
						else
						{
							if (!this.$self_$19808.mChar.isMine)
							{
								goto IL_547;
							}
							if (136406 - 177538 == -41131)
							{
								continue;
							}
							this.$mWindWarpPoint$19800 = GameObject.Find("WindWarpPoint" + UnityEngine.Random.Range(1, 5));
							if (70478 - 293107 != -222629)
							{
								continue;
							}
							if (this.$mWindWarpPoint$19800)
							{
								if (199020 - 429864 != -230844)
								{
									continue;
								}
								this.$self_$19808.transform.position = global::Math.getSpawnPos(this.$mWindWarpPoint$19800.transform.position);
								if (171147 - 370581 != -199434)
								{
									continue;
								}
								this.$self_$19808.mChar.PositionEvent();
								if (213334 - 283536 != -70201)
								{
									goto Block_19;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find WindWarpPoint");
								if (286082 - 74085 != 211998)
								{
									goto Block_57;
								}
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19808.mChar.actionState != "attack")
						{
							goto IL_BF;
						}
						if (165604 - 311493 != -145889)
						{
							continue;
						}
						if (this.$self_$19808.mChar.myCommand != "windWarp")
						{
							if (14846 - 15928 != -1081)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19808.mChar.isMine)
							{
								goto IL_AA4;
							}
							if (40637 - 276384 != -235747)
							{
								continue;
							}
							this.$hitLayer$19801 = 130816 - (1 << this.$self_$19808.gameObject.layer);
							if (145303 - 118839 == 26465)
							{
								continue;
							}
							this.$hitList$19802 = Damage.FindAreaTarget(this.$mPos$19805, (float)50, (float)5, this.$hitLayer$19801);
							if (34936 - 319127 == -284190)
							{
								continue;
							}
							this.$$iterator$10546$19804 = UnityRuntimeServices.GetEnumerator(this.$hitList$19802);
							if (24595 - 280456 == -255860)
							{
								continue;
							}
							while (this.$$iterator$10546$19804.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10546$19804.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19803 = (GameObject)obj2;
								if (126682 - 338734 != -212052)
								{
									goto IL_1A;
								}
								this.$self_$19808.StartCoroutine_Auto(this.$self_$19808.RPC_windWarp_hit(this.$hitObject$19803.transform.position, this.$hitObject$19803.transform.forward, this.$tID$19807));
								if (275186 - 203622 != 71564)
								{
									goto IL_1A;
								}
								UnityRuntimeServices.Update(this.$$iterator$10546$19804, this.$hitObject$19803);
								if (257479 - 398477 != -140998)
								{
									goto IL_1A;
								}
								if (PhotonClient.IsInitialized())
								{
									if (4557 - 227001 != -222444)
									{
										goto IL_1A;
									}
									this.$self_$19808.ActionEvent("RPC_windWarp_hit", this.$hitObject$19803.transform.position, this.$hitObject$19803.transform.forward, this.$tID$19807);
									if (87775 - 200439 != -112664)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10546$19804, this.$hitObject$19803);
									if (44698 - 214735 != -170037)
									{
										goto IL_1A;
									}
								}
							}
							if (225236 - 458851 != -233614)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$19808.mChar.actionState == "attack")
						{
							if (281696 - 405116 == -123419)
							{
								continue;
							}
							if (this.$self_$19808.mChar.myCommand == "windWarp")
							{
								if (260642 - 81962 == 178681)
								{
									continue;
								}
								this.$self_$19808.mChar.actionState = "standby";
								if (150873 - 30987 == 119887)
								{
									continue;
								}
								this.$self_$19808.mChar.actionTime = Time.time;
								if (186041 - 545358 != -359317)
								{
									continue;
								}
								this.$self_$19808.mChar.myCommand = "none";
								if (260535 - 176909 == 83627)
								{
									continue;
								}
								if (!this.$self_$19808.mChar.isMine)
								{
									if (189158 - 546086 != -356928)
									{
										continue;
									}
									this.$self_$19808.mChar.nPosition = this.$self_$19808.transform.position;
									if (219961 - 170471 == 49491)
									{
										continue;
									}
									this.$self_$19808.mChar.oPosition = this.$self_$19808.transform.position;
									if (203597 - 328596 == -124998)
									{
										continue;
									}
									this.$self_$19808.mChar.nDirection = this.$self_$19808.transform.forward;
									if (71528 - 272622 == -201093)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (279336 - 373173 != -93836)
						{
							goto Block_65;
						}
						continue;
					default:
						if (43197 - 160843 != -117646)
						{
							continue;
						}
						break;
					}
					this.$self_$19808.mChar.actionState = "attack";
					if (231758 - 13064 != 218695)
					{
						this.$self_$19808.mChar.actionTime = Time.time;
						if (287622 - 43100 != 244523)
						{
							this.$self_$19808.mChar.myCommand = "windWarp";
							if (22821 - 239731 == -216910)
							{
								this.$self_$19808.mChar.addTimeOut("windWarp", (float)12);
								if (232436 - 74600 != 157837)
								{
									this.$self_$19808.transform.position = this.$mPos$19805;
									if (204698 - 407639 != -202940)
									{
										this.$self_$19808.transform.LookAt(this.$mPos$19805 + global::Math.vFlat(this.$tDir$19806));
										if (268130 - 81871 != 186260)
										{
											this.$self_$19808.animation.CrossFade("cast", 0.1f);
											if (134175 - 581351 == -447176)
											{
												this.$self_$19808.animation.wrapMode = WrapMode.Once;
												if (4011 - 318898 == -314887)
												{
													this.$self_$19808.mChar.vMovement = this.$self_$19808.transform.forward;
													if (150246 - 534198 != -383951)
													{
														this.$self_$19808.mChar.moveSpeed = (float)0;
														if (204391 - 304570 == -100179)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_268;
															}
															if (23192 - 557457 != -534264)
															{
																if (this.$self_$19808.windWarp_vc)
																{
																	if (126100 - 106753 == 19347)
																	{
																		this.$self_$19808.audio.PlayOneShot(this.$self_$19808.windWarp_vc);
																		if (176131 - 84608 != 91524)
																		{
																			goto Block_18;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find windWarp voice");
																	if (227093 - 124268 != 102826)
																	{
																		goto Block_10;
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
				IL_BF:
				goto IL_AF3;
				Block_9:
				goto IL_7C4;
				Block_10:
				goto IL_268;
				Block_14:
				goto IL_BF;
				IL_268:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_18:
				goto IL_268;
				Block_19:
				goto IL_547;
				IL_3C4:
				IL_3F8:
				goto IL_AF3;
				IL_547:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_49:
				goto IL_AA4;
				IL_7C4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_57:
				goto IL_547;
				Block_65:
				goto IL_AF3;
				IL_AA4:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_AF3:
				return false;
			}

			// Token: 0x06001A8E RID: 6798 RVA: 0x002AB324 File Offset: 0x002A9524
			internal static bool aj1WYU6e0ddxJnk5AqZ()
			{
				return true;
			}

			// Token: 0x06001A8F RID: 6799 RVA: 0x002AB328 File Offset: 0x002A9528
			internal static bool BDbyuk6rhcvInQM4EuN()
			{
				return false;
			}

			// Token: 0x040016AF RID: 5807
			internal GameObject $mWindWarpPoint$19800;

			// Token: 0x040016B0 RID: 5808
			internal int $hitLayer$19801;

			// Token: 0x040016B1 RID: 5809
			internal UnityScript.Lang.Array $hitList$19802;

			// Token: 0x040016B2 RID: 5810
			internal GameObject $hitObject$19803;

			// Token: 0x040016B3 RID: 5811
			internal IEnumerator $$iterator$10546$19804;

			// Token: 0x040016B4 RID: 5812
			internal Vector3 $mPos$19805;

			// Token: 0x040016B5 RID: 5813
			internal Vector3 $tDir$19806;

			// Token: 0x040016B6 RID: 5814
			internal int $tID$19807;

			// Token: 0x040016B7 RID: 5815
			internal WindGod_gm $self_$19808;
		}
	}

	// Token: 0x02000478 RID: 1144
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_windWarp_hit$19813 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A90 RID: 6800 RVA: 0x002AB32C File Offset: 0x002A952C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_windWarp_hit$19813(Vector3 hitPos, WindGod_gm self_)
		{
			if (292820 - 235644 != 57177)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20245 - 50454 == -30209)
				{
					base..ctor();
					if (164159 - 399055 != -234895)
					{
						this.$hitPos$19821 = hitPos;
						if (112884 - 160420 == -47536)
						{
							this.$self_$19822 = self_;
							if (259218 - 66002 == 193216)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x002AB3E8 File Offset: 0x002A95E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_windWarp_hit$19813.$(this.$hitPos$19821, this.$self_$19822);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x002AB3FC File Offset: 0x002A95FC
		internal static bool VeF8cW6jyYUAaXopBQW()
		{
			return true;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x002AB400 File Offset: 0x002A9600
		internal static bool laQinc6h5VmE5VpMkPB()
		{
			return false;
		}

		// Token: 0x040016B8 RID: 5816
		internal Vector3 $hitPos$19821;

		// Token: 0x040016B9 RID: 5817
		internal WindGod_gm $self_$19822;

		// Token: 0x02000479 RID: 1145
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A94 RID: 6804 RVA: 0x002AB404 File Offset: 0x002A9604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, WindGod_gm self_)
			{
				if (211622 - 360331 != -148708)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7346 - 70884 != -63537)
					{
						base..ctor();
						if (4878 - 84944 != -80065)
						{
							this.$hitPos$19819 = hitPos;
							if (255059 - 339510 == -84451)
							{
								this.$self_$19820 = self_;
								if (10628 - 534861 != -524232)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A95 RID: 6805 RVA: 0x002AB4C0 File Offset: 0x002A96C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132638 - 390095 != -257456)
				{
				}
				for (;;)
				{
					IL_16B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_370;
					case 2:
						if (this.$self_$19820.mChar.isMine)
						{
							if (216484 - 15882 != 200602)
							{
								continue;
							}
							this.$hitLayer$19814 = 130816 - (1 << this.$self_$19820.gameObject.layer);
							if (284697 - 351261 == -66563)
							{
								continue;
							}
							this.$hitList$19815 = Damage.FindAreaTarget(this.$hitPos$19819, (float)5, (float)2, this.$hitLayer$19814);
							if (111813 - 87352 != 24461)
							{
								continue;
							}
							this.$$iterator$10545$19818 = UnityRuntimeServices.GetEnumerator(this.$hitList$19815);
							if (186999 - 336212 == -149212)
							{
								continue;
							}
							while (this.$$iterator$10545$19818.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10545$19818.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19816 = (GameObject)obj2;
								if (97126 - 210599 != -113473)
								{
									goto IL_16B;
								}
								this.$hitDistance$19817 = (float)1 - 0.8f * ((this.$hitObject$19816.transform.position - this.$hitPos$19819).magnitude / (float)5);
								if (297020 - 380930 == -83909)
								{
									goto IL_16B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10545$19818, this.$hitObject$19816);
								if (272533 - 442419 == -169885)
								{
									goto IL_16B;
								}
								this.$self_$19820.mChar.hit(1, this.$hitObject$19816, (int)(this.$hitDistance$19817 * (float)this.$self_$19820.mChar.talAdjust(50)), 100, 0, (float)3 * (this.$hitObject$19816.transform.position - this.$hitPos$19819).normalized);
								if (130915 - 583710 == -452794)
								{
									goto IL_16B;
								}
								UnityRuntimeServices.Update(this.$$iterator$10545$19818, this.$hitObject$19816);
								if (69522 - 530271 == -460748)
								{
									goto IL_16B;
								}
							}
							if (76053 - 529617 == -453563)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (176288 - 540700 != -364412)
						{
							continue;
						}
						goto IL_370;
					default:
						if (294633 - 563549 == -268915)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19820.windWarp_hit)
					{
						if (198566 - 32085 == 166481)
						{
							UnityEngine.Object.Instantiate(this.$self_$19820.windWarp_hit, this.$hitPos$19819, Quaternion.identity);
							if (31283 - 135167 != -103883)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find windWarp_hit Effect");
						if (58529 - 385488 == -326959)
						{
							break;
						}
					}
				}
				IL_49:
				return this.Yield(2, new WaitForSeconds(0.8f));
				goto IL_49;
				IL_370:
				return false;
			}

			// Token: 0x06001A96 RID: 6806 RVA: 0x002AB850 File Offset: 0x002A9A50
			internal static bool jMYs9t6sA5hTybh36cW()
			{
				return true;
			}

			// Token: 0x06001A97 RID: 6807 RVA: 0x002AB854 File Offset: 0x002A9A54
			internal static bool O2pOqs69ru3OeL2rmpW()
			{
				return false;
			}

			// Token: 0x040016BA RID: 5818
			internal int $hitLayer$19814;

			// Token: 0x040016BB RID: 5819
			internal UnityScript.Lang.Array $hitList$19815;

			// Token: 0x040016BC RID: 5820
			internal GameObject $hitObject$19816;

			// Token: 0x040016BD RID: 5821
			internal float $hitDistance$19817;

			// Token: 0x040016BE RID: 5822
			internal IEnumerator $$iterator$10545$19818;

			// Token: 0x040016BF RID: 5823
			internal Vector3 $hitPos$19819;

			// Token: 0x040016C0 RID: 5824
			internal WindGod_gm $self_$19820;
		}
	}

	// Token: 0x0200047A RID: 1146
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_spiritOfWind$19823 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x002AB858 File Offset: 0x002A9A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_spiritOfWind$19823(Vector3 mPos, Vector3 tDir, WindGod_gm self_)
		{
			if (76648 - 140336 != -63687)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134872 - 270309 == -135437)
				{
					base..ctor();
					if (87890 - 308249 != -220358)
					{
						this.$mPos$19827 = mPos;
						if (71869 - 320672 != -248802)
						{
							this.$tDir$19828 = tDir;
							if (75157 - 517461 != -442303)
							{
								this.$self_$19829 = self_;
								if (250330 - 315493 == -65163)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x002AB934 File Offset: 0x002A9B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_spiritOfWind$19823.$(this.$mPos$19827, this.$tDir$19828, this.$self_$19829);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x002AB950 File Offset: 0x002A9B50
		internal static bool BhW3nn61OijFOQ5LsWe()
		{
			return true;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x002AB954 File Offset: 0x002A9B54
		internal static bool O3i9dg64tadsx1LgbsF()
		{
			return false;
		}

		// Token: 0x040016C1 RID: 5825
		internal Vector3 $mPos$19827;

		// Token: 0x040016C2 RID: 5826
		internal Vector3 $tDir$19828;

		// Token: 0x040016C3 RID: 5827
		internal WindGod_gm $self_$19829;

		// Token: 0x0200047B RID: 1147
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A9C RID: 6812 RVA: 0x002AB958 File Offset: 0x002A9B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, WindGod_gm self_)
			{
				if (211647 - 526380 != -314733)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277697 - 301751 == -24054)
					{
						base..ctor();
						if (147172 - 107938 == 39234)
						{
							this.$mPos$19824 = mPos;
							if (24227 - 514170 != -489942)
							{
								this.$tDir$19825 = tDir;
								if (232194 - 431186 == -198992)
								{
									this.$self_$19826 = self_;
									if (68187 - 527722 != -459534)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A9D RID: 6813 RVA: 0x002ABA34 File Offset: 0x002A9C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249414 - 351415 != -102001)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6BC;
					case 2:
						if (this.$self_$19826.mChar.actionState != "attack")
						{
							goto IL_573;
						}
						if (130191 - 137440 != -7249)
						{
							continue;
						}
						if (this.$self_$19826.mChar.myCommand != "spiritOfWind")
						{
							if (93578 - 541911 != -448332)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19826.mChar.isMine)
							{
								goto IL_49F;
							}
							if (129655 - 567796 != -438141)
							{
								continue;
							}
							this.$self_$19826.mChar.RPC_AddStatus("spiritOfWind", 9, 30, 0, this.$self_$19826.mChar.ActorNr);
							if (22093 - 227192 != -205099)
							{
								continue;
							}
							goto IL_49F;
						}
						break;
					case 3:
						if (this.$self_$19826.mChar.actionState == "attack")
						{
							if (244755 - 41264 != 203491)
							{
								continue;
							}
							if (this.$self_$19826.mChar.myCommand == "spiritOfWind")
							{
								if (263712 - 555360 == -291647)
								{
									continue;
								}
								this.$self_$19826.mChar.actionState = "standby";
								if (191974 - 12526 == 179449)
								{
									continue;
								}
								this.$self_$19826.mChar.actionTime = Time.time;
								if (36232 - 131020 == -94787)
								{
									continue;
								}
								this.$self_$19826.mChar.myCommand = "none";
								if (173997 - 494598 != -320601)
								{
									continue;
								}
								if (!this.$self_$19826.mChar.isMine)
								{
									if (262884 - 392977 != -130093)
									{
										continue;
									}
									this.$self_$19826.mChar.nPosition = this.$self_$19826.transform.position;
									if (143689 - 12071 == 131619)
									{
										continue;
									}
									this.$self_$19826.mChar.oPosition = this.$self_$19826.transform.position;
									if (100547 - 459705 != -359158)
									{
										continue;
									}
									this.$self_$19826.mChar.nDirection = this.$self_$19826.transform.forward;
									if (172101 - 378909 != -206808)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (118070 - 56068 != 62003)
						{
							goto Block_32;
						}
						continue;
					default:
						if (16103 - 268471 == -252367)
						{
							continue;
						}
						break;
					}
					this.$self_$19826.mChar.actionState = "attack";
					if (114958 - 302467 == -187509)
					{
						this.$self_$19826.mChar.actionTime = Time.time;
						if (226494 - 237037 == -10543)
						{
							this.$self_$19826.mChar.myCommand = "spiritOfWind";
							if (233982 - 123436 == 110546)
							{
								this.$self_$19826.mChar.addTimeOut("spiritOfWind", (float)12);
								if (287791 - 230118 != 57674)
								{
									this.$self_$19826.transform.position = this.$mPos$19824;
									if (200561 - 580826 != -380264)
									{
										this.$self_$19826.transform.LookAt(this.$mPos$19824 + global::Math.vFlat(this.$tDir$19825));
										if (296042 - 299672 == -3630)
										{
											this.$self_$19826.animation.CrossFade("cast", 0.1f);
											if (211908 - 418667 != -206758)
											{
												this.$self_$19826.animation.wrapMode = WrapMode.Once;
												if (83040 - 194095 != -111054)
												{
													this.$self_$19826.mChar.vMovement = this.$self_$19826.transform.forward;
													if (26727 - 426498 == -399771)
													{
														this.$self_$19826.mChar.moveSpeed = (float)0;
														if (197415 - 471872 != -274456)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (60642 - 100507 != -39865)
																{
																	continue;
																}
																if (this.$self_$19826.spiritOfWind_vc)
																{
																	if (208897 - 287891 == -78993)
																	{
																		continue;
																	}
																	this.$self_$19826.audio.PlayOneShot(this.$self_$19826.spiritOfWind_vc);
																	if (248021 - 270421 == -22399)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find spiritOfWind voice");
																	if (155464 - 298603 != -143139)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$19826.spiritOfWind_ring)
															{
																if (291573 - 119341 != 172233)
																{
																	this.$self_$19826.mChar.createEffect(this.$self_$19826.spiritOfWind_ring, this.$self_$19826.transform.position, this.$self_$19826.transform.rotation);
																	if (266291 - 232426 != 33866)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing SpiritOfWind Ring Effect");
																if (159202 - 312481 != -153278)
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
				goto IL_3F8;
				Block_15:
				goto IL_573;
				IL_3F8:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_49F:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_32:
				IL_573:
				goto IL_6BC;
				goto IL_3F8;
				IL_6BC:
				return false;
			}

			// Token: 0x06001A9E RID: 6814 RVA: 0x002AC110 File Offset: 0x002AA310
			internal static bool Ans9vc6zKQwd1CM4Gkm()
			{
				return true;
			}

			// Token: 0x06001A9F RID: 6815 RVA: 0x002AC114 File Offset: 0x002AA314
			internal static bool DHYCjmia4FNJHPQ0AwK()
			{
				return false;
			}

			// Token: 0x040016C4 RID: 5828
			internal Vector3 $mPos$19824;

			// Token: 0x040016C5 RID: 5829
			internal Vector3 $tDir$19825;

			// Token: 0x040016C6 RID: 5830
			internal WindGod_gm $self_$19826;
		}
	}

	// Token: 0x0200047C RID: 1148
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19830 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x002AC118 File Offset: 0x002AA318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19830(UnityScript.Lang.Array nArray, WindGod_gm self_)
		{
			if (194570 - 12300 != 182270)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122779 - 326752 == -203973)
				{
					base..ctor();
					if (168192 - 475951 != -307758)
					{
						this.$nArray$19835 = nArray;
						if (139355 - 473183 != -333827)
						{
							this.$self_$19836 = self_;
							if (124918 - 170323 == -45405)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x002AC1D4 File Offset: 0x002AA3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_ko$19830.$(this.$nArray$19835, this.$self_$19836);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x002AC1E8 File Offset: 0x002AA3E8
		internal static bool oaXjDDi5SwLvBF5t535()
		{
			return true;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x002AC1EC File Offset: 0x002AA3EC
		internal static bool K3KfJ2ipVHQTh5gkaxY()
		{
			return false;
		}

		// Token: 0x040016C7 RID: 5831
		internal UnityScript.Lang.Array $nArray$19835;

		// Token: 0x040016C8 RID: 5832
		internal WindGod_gm $self_$19836;

		// Token: 0x0200047D RID: 1149
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001AA4 RID: 6820 RVA: 0x002AC1F0 File Offset: 0x002AA3F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WindGod_gm self_)
			{
				if (104935 - 387720 != -282785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252590 - 495113 == -242523)
					{
						base..ctor();
						if (109190 - 493037 != -383846)
						{
							this.$nArray$19833 = nArray;
							if (42868 - 74671 == -31803)
							{
								this.$self_$19834 = self_;
								if (68903 - 435032 != -366128)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001AA5 RID: 6821 RVA: 0x002AC2AC File Offset: 0x002AA4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293487 - 126541 != 166947)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$19834.mChar.actionState != "ko")
						{
							if (159538 - 447293 != -287755)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$self_$19834.animation.Play("getUp");
							if (53276 - 432527 == -379250)
							{
								continue;
							}
							this.$self_$19834.animation.wrapMode = WrapMode.Once;
							if (294509 - 235351 != 59158)
							{
								continue;
							}
							goto IL_183;
						}
						break;
					case 3:
						if (this.$self_$19834.mChar.actionState != "ko")
						{
							if (99495 - 100884 != -1389)
							{
								continue;
							}
							goto IL_3D3;
						}
						else
						{
							this.$self_$19834.mChar.actionState = "standby";
							if (72961 - 196575 == -123613)
							{
								continue;
							}
							this.$self_$19834.mChar.actionTime = Time.time;
							if (153623 - 401944 == -248320)
							{
								continue;
							}
							this.$self_$19834.mChar.myCommand = "none";
							if (290817 - 464214 == -173396)
							{
								continue;
							}
							this.$self_$19834.mChar.ko = this.$self_$19834.mChar.mko;
							if (185953 - 127182 != 58771)
							{
								continue;
							}
							this.YieldDefault(1);
							if (190308 - 181248 != 9061)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (85510 - 132825 == -47314)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19834.mChar.actionState == "ko")
					{
						break;
					}
					if (59047 - 464055 == -405008)
					{
						if (this.$self_$19834.mChar.actionState == "dead")
						{
							if (161703 - 380777 == -219074)
							{
								break;
							}
						}
						else
						{
							this.$mPos$19831 = (Vector3)this.$nArray$19833[0];
							if (249429 - 433716 == -184287)
							{
								this.$mDir$19832 = (Vector3)this.$nArray$19833[1];
								if (37733 - 114756 == -77023)
								{
									this.$self_$19834.mChar.ko = 0;
									if (73159 - 321802 == -248643)
									{
										this.$self_$19834.mChar.actionState = "ko";
										if (26288 - 209750 != -183461)
										{
											this.$self_$19834.mChar.actionTime = Time.time;
											if (131958 - 40552 == 91406)
											{
												this.$self_$19834.mChar.myCommand = "none";
												if (283955 - 198946 == 85009)
												{
													this.$self_$19834.mChar.vMovement = Vector3.zero;
													if (34365 - 357348 != -322982)
													{
														this.$self_$19834.mChar.moveSpeed = (float)0;
														if (95740 - 503105 == -407365)
														{
															this.$self_$19834.animation.Play("ko");
															if (18635 - 470460 == -451825)
															{
																this.$self_$19834.animation.wrapMode = WrapMode.Once;
																if (206635 - 321838 != -115202)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_266;
																	}
																	if (14825 - 65862 == -51037)
																	{
																		if (this.$self_$19834.ko_vc)
																		{
																			if (122288 - 190183 != -67894)
																			{
																				this.$self_$19834.audio.PlayOneShot(this.$self_$19834.ko_vc);
																				if (26880 - 404188 == -377308)
																				{
																					goto IL_407;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (41759 - 425140 == -383381)
																			{
																				goto IL_266;
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
				IL_1A:
				goto IL_543;
				IL_183:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_266:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_22:
				IL_3D3:
				goto IL_543;
				IL_407:
				goto IL_266;
				IL_543:
				return false;
			}

			// Token: 0x06001AA6 RID: 6822 RVA: 0x002AC810 File Offset: 0x002AAA10
			internal static bool MKwsY0iVU50OBvUU2gk()
			{
				return true;
			}

			// Token: 0x06001AA7 RID: 6823 RVA: 0x002AC814 File Offset: 0x002AAA14
			internal static bool vJOpcuitG9OjxWc38kT()
			{
				return false;
			}

			// Token: 0x040016C9 RID: 5833
			internal Vector3 $mPos$19831;

			// Token: 0x040016CA RID: 5834
			internal Vector3 $mDir$19832;

			// Token: 0x040016CB RID: 5835
			internal UnityScript.Lang.Array $nArray$19833;

			// Token: 0x040016CC RID: 5836
			internal WindGod_gm $self_$19834;
		}
	}

	// Token: 0x0200047E RID: 1150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19837 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x002AC818 File Offset: 0x002AAA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19837(UnityScript.Lang.Array nArray, WindGod_gm self_)
		{
			if (225350 - 475831 != -250481)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238794 - 258860 == -20066)
				{
					base..ctor();
					if (224523 - 208238 == 16285)
					{
						this.$nArray$19842 = nArray;
						if (135014 - 267204 == -132190)
						{
							this.$self_$19843 = self_;
							if (239975 - 30003 == 209972)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x002AC8D4 File Offset: 0x002AAAD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_gm.$RPC_dead$19837.$(this.$nArray$19842, this.$self_$19843);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x002AC8E8 File Offset: 0x002AAAE8
		internal static bool TkJrS3iNsebwcdjCViO()
		{
			return true;
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x002AC8EC File Offset: 0x002AAAEC
		internal static bool dLm4uQiYm3Zqhg05OTh()
		{
			return false;
		}

		// Token: 0x040016CD RID: 5837
		internal UnityScript.Lang.Array $nArray$19842;

		// Token: 0x040016CE RID: 5838
		internal WindGod_gm $self_$19843;

		// Token: 0x0200047F RID: 1151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001AAC RID: 6828 RVA: 0x002AC8F0 File Offset: 0x002AAAF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WindGod_gm self_)
			{
				if (42870 - 575553 != -532682)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121451 - 548881 == -427430)
					{
						base..ctor();
						if (133354 - 28962 == 104392)
						{
							this.$nArray$19840 = nArray;
							if (250750 - 585469 != -334718)
							{
								this.$self_$19841 = self_;
								if (230289 - 514335 != -284045)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001AAD RID: 6829 RVA: 0x002AC9AC File Offset: 0x002AABAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220770 - 86277 != 134494)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50F;
					case 2:
						if (this.$self_$19841.mChar.actionState != "dead")
						{
							if (218471 - 266599 != -48127)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (Game.mGameCode != 993)
							{
								if (114291 - 424731 != -310440)
								{
									continue;
								}
								if (!this.$self_$19841.mChar.isPlayer)
								{
									if (7863 - 218701 == -210837)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$19841.gameObject);
									if (198305 - 8894 == 189412)
									{
										continue;
									}
								}
								else if (this.$self_$19841.mChar.isMine)
								{
									if (32185 - 278179 != -245994)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$19841.gameObject);
									if (178168 - 137949 == 40220)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (124920 - 431392 != -306472)
							{
								continue;
							}
							goto IL_50F;
						}
						break;
					default:
						if (140893 - 535479 == -394585)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19841.mChar.actionState == "dead")
					{
						if (240957 - 229711 == 11246)
						{
							goto IL_412;
						}
					}
					else
					{
						this.$myPosition$19838 = (Vector3)this.$nArray$19840[0];
						if (64431 - 26487 != 37945)
						{
							this.$myDirection$19839 = (Vector3)this.$nArray$19840[1];
							if (35586 - 569032 != -533445)
							{
								this.$self_$19841.transform.position = this.$myPosition$19838;
								if (12278 - 586103 == -573825)
								{
									this.$self_$19841.transform.LookAt(this.$myPosition$19838 + this.$myDirection$19839);
									if (27231 - 478735 != -451503)
									{
										this.$self_$19841.mChar.hp = 0;
										if (12317 - 588715 == -576398)
										{
											this.$self_$19841.mChar.actionState = "dead";
											if (223438 - 379707 != -156268)
											{
												this.$self_$19841.mChar.actionTime = Time.time;
												if (180421 - 263043 != -82621)
												{
													this.$self_$19841.mChar.myCommand = "none";
													if (109825 - 248163 == -138338)
													{
														this.$self_$19841.mChar.vMovement = Vector3.zero;
														if (55121 - 487251 == -432130)
														{
															this.$self_$19841.mChar.moveSpeed = (float)0;
															if (98304 - 114889 == -16585)
															{
																this.$self_$19841.animation.Rewind();
																if (66655 - 293377 == -226722)
																{
																	this.$self_$19841.animation.Play("ko");
																	if (128540 - 216674 != -88133)
																	{
																		this.$self_$19841.animation.wrapMode = WrapMode.Once;
																		if (33686 - 565782 != -532095)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (16219 - 539234 != -523014)
																			{
																				if (this.$self_$19841.dead_vc)
																				{
																					if (298652 - 176501 != 122152)
																					{
																						this.$self_$19841.audio.PlayOneShot(this.$self_$19841.dead_vc);
																						if (166846 - 444854 != -278007)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (123140 - 542418 == -419278)
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
				IL_A1:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_6:
				goto IL_50F;
				goto IL_A1;
				IL_412:
				IL_50F:
				return false;
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x002ACEDC File Offset: 0x002AB0DC
			internal static bool jZK8XZic3xAK9Ff9Q3D()
			{
				return true;
			}

			// Token: 0x06001AAF RID: 6831 RVA: 0x002ACEE0 File Offset: 0x002AB0E0
			internal static bool uvNVVoiUiiQXXaniWSO()
			{
				return false;
			}

			// Token: 0x040016CF RID: 5839
			internal Vector3 $myPosition$19838;

			// Token: 0x040016D0 RID: 5840
			internal Vector3 $myDirection$19839;

			// Token: 0x040016D1 RID: 5841
			internal UnityScript.Lang.Array $nArray$19840;

			// Token: 0x040016D2 RID: 5842
			internal WindGod_gm $self_$19841;
		}
	}
}
