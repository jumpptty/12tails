using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020004FB RID: 1275
[Serializable]
public class Bat_illusion : MonoBehaviour
{
	// Token: 0x06001D35 RID: 7477 RVA: 0x0031B720 File Offset: 0x00319920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_illusion()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x0031B730 File Offset: 0x00319930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWingFlapEvent(AnimationEvent animEvent)
	{
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x0031B734 File Offset: 0x00319934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (193388 - 186553 != 6835)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (226832 - 205063 == 21769)
			{
				this.mChar.actionState = "standby";
				if (43828 - 241617 == -197789)
				{
					this.mChar.actionTime = Time.time;
					if (179357 - 335007 == -155650)
					{
						this.mChar.myCommand = "none";
						if (13872 - 587732 != -573859)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x0031B820 File Offset: 0x00319A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void summon(GameObject nOwner, float nDamageMod, float nHitMod, float nTimer)
	{
		if (18530 - 55151 != -36620)
		{
		}
		for (;;)
		{
			this.gN2GAWX4jm = nOwner;
			if (268697 - 248562 == 20135)
			{
				this.Q8EG9xe4rf = (CharacterControl)this.gN2GAWX4jm.GetComponent(typeof(CharacterControl));
				if (208731 - 58142 != 150590)
				{
					this.eeOGFcJNyu = nTimer + Time.time;
					if (285802 - 413650 != -127847)
					{
						Camera.main.SendMessage("onSummon", this.gameObject, SendMessageOptions.DontRequireReceiver);
						if (37868 - 464491 == -426623)
						{
							this.mChar.hp = this.Q8EG9xe4rf.hp;
							if (31321 - 435478 == -404157)
							{
								this.mChar.mhp = this.Q8EG9xe4rf.mhp;
								if (231578 - 34248 != 197331)
								{
									this.mChar.mp = this.Q8EG9xe4rf.mp;
									if (297725 - 492321 == -194596)
									{
										this.mChar.mmp = this.Q8EG9xe4rf.mmp;
										if (193913 - 80906 != 113008)
										{
											this.mChar.sp = this.Q8EG9xe4rf.sp;
											if (226211 - 404180 == -177969)
											{
												this.mChar.msp = this.Q8EG9xe4rf.msp;
												if (223704 - 138525 == 85179)
												{
													this.mChar.ko = this.Q8EG9xe4rf.ko;
													if (39753 - 429235 != -389481)
													{
														this.mChar.mko = this.Q8EG9xe4rf.mko;
														if (297981 - 447928 != -149946)
														{
															this.mChar.atk = this.Q8EG9xe4rf.atk;
															if (237033 - 29008 != 208026)
															{
																this.mChar.def = this.Q8EG9xe4rf.def;
																if (231703 - 100385 != 131319)
																{
																	this.mChar.agi = this.Q8EG9xe4rf.agi;
																	if (225967 - 464530 != -238562)
																	{
																		this.mChar.mag = this.Q8EG9xe4rf.mag;
																		if (144408 - 80413 != 63996)
																		{
																			this.mChar.cha = this.Q8EG9xe4rf.cha;
																			if (80439 - 548823 != -468383)
																			{
																				this.mChar.tal = this.Q8EG9xe4rf.tal;
																				if (47811 - 178902 == -131091)
																				{
																					this.mChar.lck = this.Q8EG9xe4rf.lck;
																					if (129133 - 87566 == 41567)
																					{
																						this.mChar.weapon = this.Q8EG9xe4rf.weapon;
																						if (128788 - 336095 == -207307)
																						{
																							this.mChar.armor = this.Q8EG9xe4rf.armor;
																							if (37279 - 155919 != -118639)
																							{
																								this.mChar.accessory = this.Q8EG9xe4rf.accessory;
																								if (108223 - 144880 == -36657)
																								{
																									this.mChar.boot = this.Q8EG9xe4rf.boot;
																									if (294930 - 247287 != 47644)
																									{
																										this.mChar.trinket = this.Q8EG9xe4rf.trinket;
																										if (177590 - 23341 == 154249)
																										{
																											this.mChar.pet = this.Q8EG9xe4rf.pet;
																											if (41694 - 561412 != -519717)
																											{
																												this.mChar.weight = this.Q8EG9xe4rf.weight;
																												if (259384 - 219413 != 39972)
																												{
																													this.mChar.runSpeed = this.Q8EG9xe4rf.runSpeed;
																													if (59973 - 201217 == -141244)
																													{
																														this.mChar.mSkillList = this.Q8EG9xe4rf.mSkillList;
																														if (172550 - 474715 == -302165)
																														{
																															this.mChar.damageMod = Mathf.Clamp(nDamageMod, 0.5f, 1f);
																															if (245354 - 415331 != -169976)
																															{
																																this.mChar.hitMod = Mathf.Clamp(nHitMod, 1.4f, 2f);
																																if (34129 - 147365 != -113235)
																																{
																																	GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.Q8EG9xe4rf.mWep1, Vector3.zero, Quaternion.identity);
																																	if (64341 - 497760 != -433418)
																																	{
																																		gameObject.transform.parent = this.transform.Find("Bat_tri/root/Spine2/Spine1/UpperArm_L/Arm_L/Hand_L/mount_Hand_L");
																																		if (17809 - 12021 == 5788)
																																		{
																																			gameObject.transform.localPosition = Vector3.zero;
																																			if (203246 - 115397 == 87849)
																																			{
																																				gameObject.transform.localRotation = Quaternion.identity;
																																				if (279245 - 143976 != 135270)
																																				{
																																					if (this.Q8EG9xe4rf.mAcc != null)
																																					{
																																						if (112596 - 521714 != -409118)
																																						{
																																							continue;
																																						}
																																						GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.Q8EG9xe4rf.mAcc, Vector3.zero, Quaternion.identity);
																																						if (262720 - 94812 != 167908)
																																						{
																																							continue;
																																						}
																																						gameObject2.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head").transform;
																																						if (221679 - 523467 == -301787)
																																						{
																																							continue;
																																						}
																																						gameObject2.transform.localPosition = Vector3.zero;
																																						if (57222 - 506732 == -449509)
																																						{
																																							continue;
																																						}
																																						gameObject2.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																																						if (79508 - 503401 != -423893)
																																						{
																																							continue;
																																						}
																																						gameObject2.transform.localScale = Vector3.one;
																																						if (53427 - 395791 != -342364)
																																						{
																																							continue;
																																						}
																																					}
																																					if (this.Q8EG9xe4rf.mTrn != null)
																																					{
																																						if (162677 - 65543 == 97135)
																																						{
																																							continue;
																																						}
																																						GameObject gameObject3 = (GameObject)UnityEngine.Object.Instantiate(this.Q8EG9xe4rf.mTrn, Vector3.zero, Quaternion.identity);
																																						if (109100 - 212457 == -103356)
																																						{
																																							continue;
																																						}
																																						string trinket = this.Q8EG9xe4rf.trinket;
																																						if (193497 - 117570 != 75927)
																																						{
																																							continue;
																																						}
																																						if (!(trinket == "t_all71"))
																																						{
																																							if (269081 - 413085 == -144003)
																																							{
																																								continue;
																																							}
																																							if (!(trinket == "t_all72"))
																																							{
																																								if (194520 - 408190 != -213670)
																																								{
																																									continue;
																																								}
																																								if (!(trinket == "t_all73"))
																																								{
																																									if (227140 - 318823 != -91683)
																																									{
																																										continue;
																																									}
																																									if (!(trinket == "t_all74"))
																																									{
																																										if (164547 - 488109 == -323561)
																																										{
																																											continue;
																																										}
																																										if (trinket == "t_all75")
																																										{
																																											if (203032 - 258582 == -55549)
																																											{
																																												continue;
																																											}
																																										}
																																										else
																																										{
																																											if (!(trinket == "t_fem2"))
																																											{
																																												if (65087 - 140219 != -75132)
																																												{
																																													continue;
																																												}
																																												if (trinket == "t_fem46")
																																												{
																																													if (262186 - 441881 != -179695)
																																													{
																																														continue;
																																													}
																																												}
																																												else
																																												{
																																													gameObject3.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Head");
																																													if (223236 - 283233 != -59997)
																																													{
																																														continue;
																																													}
																																													gameObject3.transform.localPosition = Vector3.zero;
																																													if (63202 - 291311 != -228109)
																																													{
																																														continue;
																																													}
																																													gameObject3.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																																													if (87413 - 19191 != 68222)
																																													{
																																														continue;
																																													}
																																													gameObject3.transform.localScale = Vector3.one;
																																													if (170474 - 236198 != -65723)
																																													{
																																														goto IL_D59;
																																													}
																																													continue;
																																												}
																																											}
																																											gameObject3.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine1");
																																											if (168575 - 331048 == -162472)
																																											{
																																												continue;
																																											}
																																											gameObject3.transform.localPosition = Vector3.zero;
																																											if (65498 - 279555 == -214056)
																																											{
																																												continue;
																																											}
																																											gameObject3.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																																											if (239598 - 508178 == -268579)
																																											{
																																												continue;
																																											}
																																											gameObject3.transform.localScale = Vector3.one;
																																											if (277905 - 319630 != -41725)
																																											{
																																												continue;
																																											}
																																											goto IL_D59;
																																										}
																																									}
																																								}
																																							}
																																						}
																																						gameObject3.transform.parent = global::Math.findChildObject(this.gameObject.transform, "Spine2");
																																						if (2621 - 391289 != -388668)
																																						{
																																							continue;
																																						}
																																						gameObject3.transform.localPosition = Vector3.zero;
																																						if (55043 - 472504 == -417460)
																																						{
																																							continue;
																																						}
																																						gameObject3.transform.localRotation = Quaternion.Euler((float)0, (float)-90, (float)90);
																																						if (274892 - 16881 != 258011)
																																						{
																																							continue;
																																						}
																																						gameObject3.transform.localScale = Vector3.one;
																																						if (121789 - 51144 == 70646)
																																						{
																																							continue;
																																						}
																																					}
																																					IL_D59:
																																					Transform transform = this.gN2GAWX4jm.transform.Find("Bat_tri");
																																					if (34155 - 169473 == -135318)
																																					{
																																						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
																																						if (202488 - 365347 != -162858)
																																						{
																																							Transform transform2 = this.transform.Find("Bat_tri");
																																							if (215654 - 166658 == 48996)
																																							{
																																								SkinnedMeshRenderer skinnedMeshRenderer2 = (SkinnedMeshRenderer)transform2.GetComponent(typeof(SkinnedMeshRenderer));
																																								if (1501 - 323475 == -321974)
																																								{
																																									skinnedMeshRenderer2.sharedMesh = skinnedMeshRenderer.sharedMesh;
																																									if (72174 - 292011 != -219836)
																																									{
																																										skinnedMeshRenderer2.material = skinnedMeshRenderer.material;
																																										if (204334 - 84472 == 119862)
																																										{
																																											if (Game.mPlayer)
																																											{
																																												if (8391 - 159250 != -150859)
																																												{
																																													continue;
																																												}
																																												CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
																																												if (240213 - 308805 == -68591)
																																												{
																																													continue;
																																												}
																																												if (characterControl)
																																												{
																																													if (30482 - 27928 == 2555)
																																													{
																																														continue;
																																													}
																																													if (this.Q8EG9xe4rf.mOriginalLayer == characterControl.mOriginalLayer)
																																													{
																																														if (224553 - 421352 != -196799)
																																														{
																																															continue;
																																														}
																																														this.mChar.setColor(new Color(0.3f, 0.2f, 0.5f, (float)1));
																																														if (163951 - 452855 != -288904)
																																														{
																																															continue;
																																														}
																																														this.mChar.mColor = new Color(0.3f, 0.2f, 0.5f, (float)1);
																																														if (129585 - 508478 != -378892)
																																														{
																																															goto IL_9D1;
																																														}
																																														continue;
																																													}
																																												}
																																												this.mChar.setColor(new Color(0.86f, 0.86f, 0.86f, (float)1));
																																												if (119315 - 396650 != -277335)
																																												{
																																													continue;
																																												}
																																												this.mChar.mColor = new Color(0.86f, 0.86f, 0.86f, (float)1);
																																												if (192923 - 166173 != 26750)
																																												{
																																													continue;
																																												}
																																												IL_9D1:;
																																											}
																																											else
																																											{
																																												this.mChar.setColor(new Color(0.86f, 0.86f, 0.86f, (float)1));
																																												if (185365 - 145267 == 40099)
																																												{
																																													continue;
																																												}
																																												this.mChar.mColor = new Color(0.86f, 0.86f, 0.86f, (float)1);
																																												if (226743 - 118642 == 108102)
																																												{
																																													continue;
																																												}
																																											}
																																											Debug.Log("Illusion created for " + nTimer + "ID=" + this.mChar.ActorNr);
																																											if (295709 - 515254 == -219545)
																																											{
																																												this.GOsGuFKDUi = true;
																																												if (81095 - 33740 != 47356)
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

	// Token: 0x06001D39 RID: 7481 RVA: 0x0031C794 File Offset: 0x0031A994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (181955 - 498366 != -316411)
		{
		}
		for (;;)
		{
			if (!this.GOsGuFKDUi)
			{
				if (110175 - 530882 != -420706)
				{
					break;
				}
			}
			else if (!this.gN2GAWX4jm)
			{
				if (191844 - 524701 != -332856)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (19927 - 64537 != -44609)
					{
						break;
					}
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					if (56103 - 129133 == -73029)
					{
						continue;
					}
					if (!(this.mChar.actionState == "standby"))
					{
						if (120091 - 430912 == -310820)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_215;
						}
						if (108926 - 547628 == -438701)
						{
							continue;
						}
					}
					this.PlayerControl();
					if (105492 - 369095 != -263603)
					{
						continue;
					}
				}
				IL_215:
				if (this.mChar.hp <= 0)
				{
					if (161412 - 587006 == -425593)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (260056 - 444467 != -184411)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (107884 - 493007 != -385123)
							{
								continue;
							}
							statusClass status = this.mChar.getStatus("autoLife");
							if (83113 - 236376 == -153262)
							{
								continue;
							}
							if (status != null)
							{
								if (149631 - 211013 == -61381)
								{
									continue;
								}
								this.mChar.hp = 1;
								if (217119 - 437796 != -220677)
								{
									continue;
								}
								this.mChar.RPC_RemoveStatus("autoLife");
								if (283910 - 285105 != -1195)
								{
									continue;
								}
								this.mChar.RPC_createEffect("autoLife");
								if (298619 - 85772 != 212847)
								{
									continue;
								}
								this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
								if (185448 - 570668 != -385219)
								{
									break;
								}
								continue;
							}
							else
							{
								this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (241361 - 403651 == -162289)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (117024 - 65760 != 51264)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (100584 - 499710 != -399125)
								{
									break;
								}
								continue;
							}
						}
						else
						{
							this.mChar.hp = 1;
							if (252626 - 88669 != 163957)
							{
								continue;
							}
							break;
						}
					}
				}
				if (this.mChar.isMine)
				{
					if (12732 - 159981 == -147248)
					{
						continue;
					}
					Vector3 vector = this.gN2GAWX4jm.transform.position - this.transform.position;
					if (27648 - 580355 != -552707)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)400)
					{
						if (65491 - 371062 != -305571)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (288612 - 506023 != -217411)
							{
								continue;
							}
							Camera.main.SendMessage("newGameMessage", "Illusion is too far to control");
							if (114592 - 500745 != -386153)
							{
								continue;
							}
							this.RPC_disappear(this.transform.position, this.transform.forward, 0);
							if (212913 - 366896 == -153982)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (167916 - 168175 == -258)
							{
								continue;
							}
							this.ActionEvent("RPC_disappear", this.transform.position, this.transform.forward, 0);
							if (206801 - 265555 != -58754)
							{
								continue;
							}
							break;
						}
					}
				}
				if (this.mChar.isMine)
				{
					if (37297 - 257433 == -220135)
					{
						continue;
					}
					if (Time.time > this.eeOGFcJNyu)
					{
						if (178226 - 58313 == 119914)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (182987 - 424949 != -241962)
							{
								continue;
							}
							this.RPC_disappear(this.transform.position, this.transform.forward, 0);
							if (63020 - 359601 != -296581)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (242191 - 480128 == -237936)
							{
								continue;
							}
							this.ActionEvent("RPC_disappear", this.transform.position, this.transform.forward, 0);
							if (81244 - 491104 != -409859)
							{
								break;
							}
							continue;
						}
					}
				}
				if (!this.Q8EG9xe4rf)
				{
					break;
				}
				if (121748 - 309108 == -187360)
				{
					if (!this.mChar.isMine)
					{
						break;
					}
					if (203592 - 548129 != -344536)
					{
						if (this.Q8EG9xe4rf.hp > 0)
						{
							break;
						}
						if (119201 - 47809 != 71393)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (81803 - 373372 != -291568)
							{
								this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (12713 - 149853 == -137140)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (153738 - 157278 == -3540)
									{
										this.mChar.DeadEvent();
										if (106770 - 218019 != -111248)
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

	// Token: 0x06001D3A RID: 7482 RVA: 0x0031CF64 File Offset: 0x0031B164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (37341 - 173429 != -136087)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (174489 - 225010 == -50520)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (79696 - 595376 != -515680)
					{
						continue;
					}
					break;
				}
			}
			float num = this.mChar.moveSpeed;
			if (214583 - 594494 == -379911)
			{
				float runSpeed = this.mChar.runSpeed;
				if (264331 - 419257 != -154925)
				{
					Vector3 a = default(Vector3);
					if (3703 - 234253 != -230549)
					{
						Vector3 vector = Vector3.zero;
						if (65192 - 267360 == -202168)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (45145 - 62652 == -17507)
							{
								if (this.mChar.isMine)
								{
									if (229728 - 495446 != -265718)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (30232 - 361988 == -331755)
									{
										continue;
									}
									a.y = (float)0;
									if (71620 - 164765 == -93144)
									{
										continue;
									}
									a = a.normalized;
									if (213649 - 242566 == -28916)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (190615 - 354877 == -164261)
									{
										continue;
									}
									vector = vector.normalized;
									if (160258 - 260077 == -99818)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (150096 - 33080 != 117016)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (180639 - 421603 != -240964)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (244578 - 228124 == 16455)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (105901 - 103314 != 2587)
										{
											continue;
										}
										this.animation.Play("run");
										if (242716 - 239434 != 3282)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (88524 - 275681 != -187157)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (294304 - 536004 == -241699)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (154069 - 242573 == -88503)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (84199 - 28472 == 55728)
											{
												continue;
											}
											num = (float)0;
											if (41411 - 394714 != -353303)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (198036 - 135395 != 62641)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (283406 - 429090 != -145684)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (274598 - 381102 != -106504)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (59859 - 186378 != -126519)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (250843 - 154131 == 96713)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (58189 - 324985 == -266795)
										{
											continue;
										}
										num = (float)0;
										if (265944 - 560278 != -294334)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (13501 - 252555 == -239053)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (1832 - 79404 != -77572)
										{
											continue;
										}
										vector = lhs.normalized;
										if (180090 - 63129 == 116962)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (113841 - 343778 == -229936)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (244410 - 359701 != -115291)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (12959 - 207551 == -194591)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (97566 - 77482 == 20085)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (224232 - 526576 == -302343)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (245857 - 404475 != -158618)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (144432 - 471045 != -326612)
								{
									this.mChar.moveSpeed = num;
									if (278268 - 246926 == 31342)
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

	// Token: 0x06001D3B RID: 7483 RVA: 0x0031D684 File Offset: 0x0031B884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (4494 - 382527 != -378032)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (71258 - 339576 != -268317)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (17173 - 168289 == -151116)
				{
					if (270117 - 500015 == -229898)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (45998 - 147519 != -101521)
							{
								continue;
							}
							v = 1;
							if (26061 - 119596 == -93534)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (100169 - 395729 != -295560)
							{
								continue;
							}
							v = 2;
							if (124436 - 553317 != -428881)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack3")
						{
							if (85440 - 207175 != -121735)
							{
								continue;
							}
							v = 3;
							if (217508 - 425805 == -208296)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire1")
						{
							if (299135 - 367697 != -68562)
							{
								continue;
							}
							v = -1;
							if (15487 - 552341 == -536853)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire2")
						{
							if (296344 - 177015 == 119330)
							{
								continue;
							}
							v = -2;
							if (208526 - 151897 != 56629)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (40334 - 60165 == -19830)
							{
								continue;
							}
							v = -3;
							if (71484 - 168516 == -97031)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack1")
						{
							if (236103 - 574852 == -338748)
							{
								continue;
							}
							v = 11;
							if (267243 - 528748 != -261505)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack0")
						{
							if (54097 - 396096 == -341998)
							{
								continue;
							}
							v = 12;
							if (180906 - 590303 != -409397)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (31336 - 290959 == -259622)
							{
								continue;
							}
							v = -11;
							if (142399 - 336566 == -194166)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cast0")
						{
							if (292222 - 366955 != -74733)
							{
								continue;
							}
							v = 20;
							if (227926 - 516879 != -288953)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cast1")
						{
							if (121359 - 224874 != -103515)
							{
								continue;
							}
							v = 21;
							if (13525 - 56058 != -42533)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cast2")
						{
							if (49919 - 274793 != -224874)
							{
								continue;
							}
							v = 22;
							if (123853 - 324058 == -200204)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_disappear")
						{
							if (153098 - 248659 == -95560)
							{
								continue;
							}
							v = 80;
							if (236959 - 262329 != -25370)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_dreamBurst_hit")
						{
							if (29219 - 278782 != -249563)
							{
								continue;
							}
							v = -361;
							if (179705 - 585465 == -405759)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_allMimic")
						{
							if (61507 - 241121 == -179613)
							{
								continue;
							}
							v = 373;
							if (262220 - 21027 != 241193)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_emotion0")
						{
							if (288282 - 115624 == 172659)
							{
								continue;
							}
							v = 500;
							if (24304 - 525081 != -500777)
							{
								continue;
							}
						}
						else if (ActionName == "emo_wave")
						{
							if (116788 - 366119 == -249330)
							{
								continue;
							}
							v = 501;
							if (271705 - 458648 == -186942)
							{
								continue;
							}
						}
						else if (ActionName == "emo_bow")
						{
							if (49919 - 47109 != 2810)
							{
								continue;
							}
							v = 502;
							if (91474 - 404596 == -313121)
							{
								continue;
							}
						}
						else if (ActionName == "emo_sit")
						{
							if (227569 - 588877 == -361307)
							{
								continue;
							}
							v = 503;
							if (69372 - 269067 == -199694)
							{
								continue;
							}
						}
						else if (ActionName == "emo_sleep")
						{
							if (139302 - 508978 != -369676)
							{
								continue;
							}
							v = 504;
							if (269567 - 248081 != 21486)
							{
								continue;
							}
						}
						else if (ActionName == "emo_laugh")
						{
							if (210413 - 253024 != -42611)
							{
								continue;
							}
							v = 511;
							if (216225 - 243258 != -27033)
							{
								continue;
							}
						}
						else if (ActionName == "emo_cry")
						{
							if (108333 - 590816 != -482483)
							{
								continue;
							}
							v = 512;
							if (212238 - 240425 != -28187)
							{
								continue;
							}
						}
						else if (ActionName == "emo_cheer")
						{
							if (71551 - 245081 == -173529)
							{
								continue;
							}
							v = 513;
							if (283297 - 433297 != -150000)
							{
								continue;
							}
						}
						else if (ActionName == "emo_beg")
						{
							if (71114 - 125650 == -54535)
							{
								continue;
							}
							v = 514;
							if (190621 - 539358 == -348736)
							{
								continue;
							}
						}
						else if (ActionName == "emo_chat")
						{
							if (234248 - 100125 == 134124)
							{
								continue;
							}
							v = 521;
							if (201507 - 184720 != 16787)
							{
								continue;
							}
						}
						else if (ActionName == "emo_pose")
						{
							if (96673 - 242487 != -145814)
							{
								continue;
							}
							v = 522;
							if (158506 - 75821 != 82685)
							{
								continue;
							}
						}
						else if (ActionName == "emo_battle")
						{
							if (195768 - 118273 != 77495)
							{
								continue;
							}
							v = 523;
							if (58096 - 535973 != -477877)
							{
								continue;
							}
						}
						else if (ActionName == "emo_dance")
						{
							if (194193 - 36713 == 157481)
							{
								continue;
							}
							v = 524;
							if (63935 - 82573 != -18638)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Command: " + ActionName);
							if (244443 - 340863 == -96419)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (143693 - 39867 != 103827)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (18153 - 314788 == -296635)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (22709 - 565182 == -542473)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (292444 - 557701 != -265256)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (173052 - 15516 != 157537)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (284625 - 146129 != 138497)
											{
												Hashtable hashtable = new Hashtable();
												if (58862 - 476694 == -417832)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (116314 - 312290 != -195975)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (42245 - 187204 != -144958)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (260800 - 373921 != -113120)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (109321 - 540011 != -430689)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (276812 - 592569 != -315756)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (158559 - 521574 != -363014)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (149753 - 355875 == -206122)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (297860 - 488621 != -190760)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (9257 - 367960 == -358703)
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

	// Token: 0x06001D3C RID: 7484 RVA: 0x0031E2E4 File Offset: 0x0031C4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (295265 - 416006 != -120740)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (159216 - 492939 != -333722)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (206641 - 517059 == -310418)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (41629 - 146107 == -104478)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (249349 - 464551 != -215201)
						{
							object value;
							if (num == 373)
							{
								if (64863 - 509217 == -444353)
								{
									continue;
								}
								value = evData[126];
								if (78601 - 431465 != -352864)
								{
									continue;
								}
							}
							int num3 = num;
							if (104401 - 331099 != -226697)
							{
								if (num3 == 1)
								{
									if (117729 - 327604 == -209875)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (66196 - 561060 != -494863)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (287050 - 100195 != 186856)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (121862 - 27091 == 94771)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (196354 - 98578 != 97777)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (48123 - 595032 != -546908)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (55499 - 306890 == -251391)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (226827 - 34233 != 192595)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (272819 - 188966 != 83854)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (5129 - 372636 == -367507)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (37537 - 90360 == -52823)
										{
											this.RPC_nAttack_fire1(vector, vector2, num2);
											if (172529 - 567263 != -394733)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (140991 - 93683 == 47308)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (13200 - 569420 == -556220)
										{
											this.RPC_nAttack_fire2(vector, vector2, num2);
											if (157441 - 339314 != -181872)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (894 - 175083 == -174189)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (109273 - 164872 == -55599)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (201404 - 35525 == 165879)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (270670 - 392502 == -121832)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (278378 - 478333 == -199955)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack1(vector, vector2, num2));
											if (11072 - 301075 == -290003)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (197584 - 125482 == 72102)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (290416 - 316588 != -26171)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack0(vector, vector2, num2));
											if (41240 - 164950 == -123710)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (250496 - 297443 != -46946)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (204479 - 275347 != -70867)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (292865 - 448068 != -155202)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (131789 - 459679 != -327889)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (232762 - 58885 != 173878)
										{
											this.RPC_cast0(vector, vector2, num2);
											if (191945 - 358104 == -166159)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (269662 - 69562 != 200101)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (218669 - 433400 == -214731)
										{
											this.StartCoroutine_Auto(this.RPC_cast1(vector, vector2, num2));
											if (226011 - 420486 == -194475)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (219219 - 367763 != -148543)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (64211 - 16092 != 48120)
										{
											this.StartCoroutine_Auto(this.RPC_cast2(vector, vector2, num2));
											if (13069 - 240866 == -227797)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 80)
								{
									if (231644 - 578676 == -347032)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (138286 - 560907 == -422621)
										{
											this.RPC_disappear(vector, vector2, num2);
											if (279385 - 340481 != -61095)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -361)
								{
									if (81180 - 555109 == -473929)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (114117 - 48205 != 65913)
										{
											this.RPC_dreamBurst_hit(vector, vector2, num2);
											if (286912 - 374221 != -87308)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 373)
								{
									if (105698 - 22005 != 83694)
									{
										this.RPC_allMimic(vector, vector2, num2, RuntimeServices.UnboxInt32(value));
										if (71608 - 579329 == -507721)
										{
											break;
										}
									}
								}
								else if (num3 == 501)
								{
									if (176731 - 269476 == -92745)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (141534 - 346134 == -204600)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_wave", vector, vector2, num2));
											if (65936 - 281206 != -215269)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 502)
								{
									if (161721 - 345192 == -183471)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (250533 - 211528 != 39006)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_bow", vector, vector2, num2));
											if (294466 - 226295 == 68171)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 503)
								{
									if (174708 - 206024 != -31315)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (68016 - 5624 != 62393)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_sit", vector, vector2, num2));
											if (172676 - 586965 != -414288)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 504)
								{
									if (272453 - 430673 == -158220)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (191434 - 435280 == -243846)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_sleep", vector, vector2, num2));
											if (188249 - 521668 != -333418)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 511)
								{
									if (75497 - 592504 == -517007)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (116493 - 160384 == -43891)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_laugh", vector, vector2, num2));
											if (60886 - 42872 == 18014)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 512)
								{
									if (265392 - 277722 != -12329)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (92812 - 45267 != 47546)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_cry", vector, vector2, num2));
											if (270471 - 112676 == 157795)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 513)
								{
									if (56697 - 444377 == -387680)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (33974 - 77656 != -43681)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_cheer", vector, vector2, num2));
											if (126984 - 369637 != -242652)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 514)
								{
									if (264945 - 255175 == 9770)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (177380 - 468143 != -290762)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_beg", vector, vector2, num2));
											if (175891 - 548877 == -372986)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 521)
								{
									if (277666 - 440190 == -162524)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (292729 - 369085 == -76356)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_chat", vector, vector2, num2));
											if (283748 - 201650 == 82098)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 522)
								{
									if (239916 - 119483 != 120434)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (36638 - 18545 != 18094)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_pose", vector, vector2, num2));
											if (283621 - 569016 == -285395)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 523)
								{
									if (238022 - 51925 == 186097)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (18674 - 81718 == -63044)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_battle", vector, vector2, num2));
											if (230783 - 416788 != -186004)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 524)
								{
									if (1821 - 435610 != -433788)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (136909 - 62966 == 73943)
										{
											this.StartCoroutine_Auto(this.RPC_emotion("emo_dance", vector, vector2, num2));
											if (243347 - 56790 != 186558)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 500)
								{
									if (87464 - 438457 == -350993)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (213172 - 544203 != -331030)
										{
											this.RPC_emotion0(vector, vector2, num2);
											if (279852 - 58300 == 221552)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (159580 - 46377 != 113204)
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

	// Token: 0x06001D3D RID: 7485 RVA: 0x0031F26C File Offset: 0x0031D46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_nAttack1$20804(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x0031F27C File Offset: 0x0031D47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_nAttack2$20815(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x0031F28C File Offset: 0x0031D48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_nAttack3$20826(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x0031F29C File Offset: 0x0031D49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire1(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (225556 - 99803 != 125754)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
			if (6120 - 20377 == -14257)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (185422 - 216186 == -30764)
				{
					projectileControl.Init(this.mChar.ActorNr);
					if (294989 - 425949 == -130960)
					{
						projectileControl.life = 1.25f * this.mChar.rangeMod;
						if (241278 - 592415 != -351136)
						{
							if (!(this.mChar.weapon == "w_bat59"))
							{
								break;
							}
							if (266007 - 34018 == 231989)
							{
								if (tID == 0)
								{
									break;
								}
								if (219512 - 402603 == -183091)
								{
									Bat_illusionFire bat_illusionFire = (Bat_illusionFire)gameObject.GetComponent(typeof(Bat_illusionFire));
									if (87368 - 289803 == -202435)
									{
										if (!bat_illusionFire)
										{
											break;
										}
										if (225662 - 535380 == -309718)
										{
											bat_illusionFire.InitHoming(tID);
											if (46066 - 233443 == -187377)
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

	// Token: 0x06001D41 RID: 7489 RVA: 0x0031F464 File Offset: 0x0031D664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire2(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (90819 - 258943 != -168123)
		{
		}
		for (;;)
		{
			IL_2B3:
			Quaternion lhs = Quaternion.FromToRotation(Vector3.forward, fireDir);
			if (3203 - 412988 == -409785)
			{
				int num = 0;
				if (150768 - 219747 != -68978)
				{
					Vector3 eulerAngles = lhs.eulerAngles;
					if (268480 - 211393 != 57088)
					{
						eulerAngles.z = (float)num;
						if (6448 - 117883 != -111434)
						{
							if (186514 - 373556 == -187042)
							{
								Vector3 vector = lhs.eulerAngles = eulerAngles;
								if (262211 - 17406 == 244805)
								{
									if (1389 - 502091 == -500702)
									{
										int i = -1;
										if (243977 - 402599 == -158622)
										{
											while (i <= 1)
											{
												GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos + (float)i * this.transform.right, lhs * Quaternion.Euler((float)0, (float)(i * 15), (float)0));
												if (182862 - 450998 != -268136)
												{
													goto IL_2B3;
												}
												ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
												if (176052 - 194411 == -18358)
												{
													goto IL_2B3;
												}
												projectileControl.Init(this.mChar.ActorNr);
												if (198645 - 542879 != -344234)
												{
													goto IL_2B3;
												}
												projectileControl.life = 1.25f * this.mChar.rangeMod;
												if (51997 - 343220 == -291222)
												{
													goto IL_2B3;
												}
												if (this.mChar.weapon == "w_bat59")
												{
													if (206004 - 273317 == -67312)
													{
														goto IL_2B3;
													}
													if (tID != 0)
													{
														if (201757 - 190324 == 11434)
														{
															goto IL_2B3;
														}
														Bat_illusionFire bat_illusionFire = (Bat_illusionFire)gameObject.GetComponent(typeof(Bat_illusionFire));
														if (121381 - 357997 != -236616)
														{
															goto IL_2B3;
														}
														if (bat_illusionFire)
														{
															if (187146 - 206771 == -19624)
															{
																goto IL_2B3;
															}
															bat_illusionFire.InitHoming(tID);
															if (219430 - 420558 == -201127)
															{
																goto IL_2B3;
															}
														}
													}
												}
												i++;
												if (32104 - 208087 == -175982)
												{
													goto IL_2B3;
												}
											}
											if (143231 - 176340 != -33108)
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

	// Token: 0x06001D42 RID: 7490 RVA: 0x0031F7A0 File Offset: 0x0031D9A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x0031F7BC File Offset: 0x0031D9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_cAttack1$20837(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x0031F7CC File Offset: 0x0031D9CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack0(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_cAttack0$20858(mPos, this).GetEnumerator();
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x0031F7DC File Offset: 0x0031D9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x0031F7F8 File Offset: 0x0031D9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cast1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_cast1$20863(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x0031F808 File Offset: 0x0031DA08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cast2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_cast2$20876(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x0031F818 File Offset: 0x0031DA18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cast0(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (160112 - 344199 != -184087)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (157138 - 16910 == 140229)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (283343 - 478439 == -195095)
					{
						continue;
					}
					if (this.mChar.actionState != "attack")
					{
						if (181090 - 76451 != 104640)
						{
							break;
						}
						continue;
					}
				}
			}
			this.mChar.actionState = "standby";
			if (177681 - 118178 == 59503)
			{
				this.mChar.actionTime = Time.time;
				if (113216 - 36949 == 76267)
				{
					this.mChar.myCommand = "none";
					if (147431 - 596441 != -449009)
					{
						this.mChar.nPosition = this.transform.position;
						if (242601 - 462911 == -220310)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x0031F9A0 File Offset: 0x0031DBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator channel(GameObject tObject)
	{
		return new Bat_illusion.$channel$20883(tObject, this).GetEnumerator();
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x0031F9B0 File Offset: 0x0031DBB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void channel0()
	{
		if (131522 - 333185 != -201662)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (134900 - 521864 != -386964)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (265973 - 290104 == -24130)
					{
						continue;
					}
					if (this.mChar.actionState != "attack")
					{
						if (190353 - 579743 != -389390)
						{
							continue;
						}
						break;
					}
				}
			}
			this.mChar.actionState = "standby";
			if (204627 - 278408 == -73781)
			{
				this.mChar.actionTime = Time.time;
				if (86032 - 24241 != 61792)
				{
					this.mChar.myCommand = "none";
					if (72195 - 88953 != -16757)
					{
						this.mChar.nPosition = this.transform.position;
						if (253032 - 114666 == 138366)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x0031FB38 File Offset: 0x0031DD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getDreamBurstLv()
	{
		if (13948 - 81842 != -67893)
		{
		}
		for (;;)
		{
			if (this.mChar.hasSkill(363))
			{
				if (259467 - 559904 == -300437)
				{
					break;
				}
			}
			else if (this.mChar.hasSkill(362))
			{
				if (12004 - 361976 == -349972)
				{
					goto IL_4F;
				}
			}
			else
			{
				if (!this.mChar.hasSkill(361))
				{
					goto IL_B9;
				}
				if (175469 - 254688 != -79218)
				{
					goto Block_5;
				}
			}
		}
		return 3;
		IL_4F:
		return 2;
		Block_5:
		return 1;
		IL_B9:
		return 0;
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x0031FC10 File Offset: 0x0031DE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dreamBurst_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (287868 - 61376 != 226492)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[hitID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (298264 - 88964 != 209301)
			{
				if (!gameObject)
				{
					break;
				}
				if (104522 - 302006 != -197483)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (252508 - 11923 != 240586)
					{
						if (!characterControl)
						{
							break;
						}
						if (263204 - 592363 != -329158)
						{
							if (!this.mrmGV8sgRF)
							{
								if (58758 - 70129 == -11370)
								{
									continue;
								}
								this.mrmGV8sgRF = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Effects/dreamBurst_hit", typeof(GameObject));
								if (99294 - 284154 == -184859)
								{
									continue;
								}
							}
							if (this.mrmGV8sgRF)
							{
								if (268945 - 246955 != 21991)
								{
									characterControl.createEffect(this.mrmGV8sgRF, gameObject.collider.bounds.center - 0.4f * hitDir, this.transform.rotation);
									if (296324 - 57441 == 238883)
									{
										break;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find dreamBurst_hit Effect");
								if (201348 - 448400 == -247052)
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

	// Token: 0x06001D4D RID: 7501 RVA: 0x0031FE18 File Offset: 0x0031E018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_allMimic(Vector3 mPos, Vector3 tDir, int tID, int nID)
	{
		if (87931 - 526983 != -439052)
		{
		}
		for (;;)
		{
			IL_18F:
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (230387 - 472999 != -242611)
			{
				CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
				if (102953 - 200642 == -97689)
				{
					if (gameObject)
					{
						if (54087 - 407170 == -353082)
						{
							continue;
						}
						if (characterControl)
						{
							if (179829 - 329610 == -149780)
							{
								continue;
							}
							GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(gameObject, this.transform.position, this.transform.rotation);
							if (96505 - 245298 != -148793)
							{
								continue;
							}
							gameObject2.name = this.gameObject.name;
							if (250828 - 200912 != 49916)
							{
								continue;
							}
							gameObject2.tag = "Enemy";
							if (248555 - 189966 == 58590)
							{
								continue;
							}
							gameObject2.layer = this.gameObject.layer;
							if (49749 - 121147 != -71398)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (269773 - 194637 == 75137)
							{
								continue;
							}
							if (characterControl2)
							{
								if (204365 - 560654 != -356289)
								{
									continue;
								}
								characterControl2.Name = this.mChar.Name;
								if (88969 - 467387 != -378418)
								{
									continue;
								}
								characterControl2.ActorNr = nID;
								if (252466 - 453567 != -201101)
								{
									continue;
								}
								characterControl2.ownerID = this.mChar.ownerID;
								if (17685 - 208769 == -191083)
								{
									continue;
								}
								characterControl2.ownerGuild = this.mChar.ownerGuild;
								if (96444 - 540720 != -444276)
								{
									continue;
								}
								characterControl2.mGuildIcon = this.mChar.mGuildIcon;
								if (142452 - 184566 == -42113)
								{
									continue;
								}
								characterControl2.mGuildRankIcon = this.mChar.mGuildRankIcon;
								if (51899 - 106971 == -55071)
								{
									continue;
								}
								characterControl2.isPlayer = false;
								if (256216 - 439789 != -183573)
								{
									continue;
								}
								characterControl2.isControlled = true;
								if (7771 - 468318 != -460547)
								{
									continue;
								}
								characterControl2.isSummon = true;
								if (258593 - 505758 == -247164)
								{
									continue;
								}
								characterControl2.mOriginalLayer = this.mChar.mOriginalLayer;
								if (8623 - 336227 != -327604)
								{
									continue;
								}
								if (characterControl2.ownerID == PlayerData.UID)
								{
									if (240782 - 51172 == 189611)
									{
										continue;
									}
									characterControl2.isMine = true;
									if (256897 - 402288 == -145390)
									{
										continue;
									}
								}
								else
								{
									characterControl2.isMine = false;
									if (246090 - 474390 == -228299)
									{
										continue;
									}
								}
								characterControl2.nPosition = mPos;
								if (144580 - 195642 == -51061)
								{
									continue;
								}
								characterControl2.nSpeed = (float)0;
								if (63736 - 180580 != -116844)
								{
									continue;
								}
								if (characterControl.mSkillList.length > 0)
								{
									if (204967 - 307850 != -102883)
									{
										continue;
									}
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(characterControl.mSkillList);
									if (83993 - 503254 != -419261)
									{
										continue;
									}
									while (enumerator.MoveNext())
									{
										object value = enumerator.Current;
										int num = RuntimeServices.UnboxInt32(value);
										if (148020 - 217663 != -69643)
										{
											goto IL_18F;
										}
										if (num < 200)
										{
											if (296684 - 599156 == -302471)
											{
												goto IL_18F;
											}
											characterControl2.mSkillList.Add(num);
											if (13783 - 401109 == -387325)
											{
												goto IL_18F;
											}
											UnityRuntimeServices.Update(enumerator, num);
											if (140975 - 234838 == -93862)
											{
												goto IL_18F;
											}
										}
										else if (num < 400)
										{
											if (212929 - 396942 != -184013)
											{
												goto IL_18F;
											}
											if (this.mChar.hasSkill(373))
											{
												if (293215 - 505023 == -211807)
												{
													goto IL_18F;
												}
												characterControl2.mSkillList.Add(num);
												if (173907 - 453624 != -279717)
												{
													goto IL_18F;
												}
												UnityRuntimeServices.Update(enumerator, num);
												if (3974 - 382651 != -378677)
												{
													goto IL_18F;
												}
											}
										}
									}
									if (179022 - 431685 == -252662)
									{
										continue;
									}
								}
								characterControl2.StartCoroutine_Auto(characterControl2.addStatus("allMimic", 1, this.mChar.chaAdjust(60), 0, tID));
								if (146482 - 589379 == -442896)
								{
									continue;
								}
							}
							if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[nID], null))
							{
								if (119501 - 534944 == -415442)
								{
									continue;
								}
								Debug.LogError("ActorNr: " + nID + " already existed");
								if (290987 - 191515 != 99472)
								{
									continue;
								}
								object obj4;
								object obj3 = obj4 = PhotonClient.ActorNrList[nID];
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject obj5 = (GameObject)obj4;
								if (25199 - 349695 == -324495)
								{
									continue;
								}
								UnityEngine.Object.Destroy(obj5);
								if (161665 - 363186 == -201520)
								{
									continue;
								}
								PhotonClient.ActorNrList[nID] = gameObject2;
								if (161075 - 380306 != -219231)
								{
									continue;
								}
							}
							else
							{
								PhotonClient.ActorNrList.Add(nID, gameObject2);
								if (15562 - 60294 != -44732)
								{
									continue;
								}
							}
							Bat_allMimic bat_allMimic = (Bat_allMimic)gameObject.GetComponent(typeof(Bat_allMimic));
							if (54337 - 68241 != -13904)
							{
								continue;
							}
							if (!bat_allMimic)
							{
								if (140850 - 391510 != -250660)
								{
									continue;
								}
								bat_allMimic = (Bat_allMimic)gameObject.AddComponent(typeof(Bat_allMimic));
								if (275469 - 57421 == 218049)
								{
									continue;
								}
							}
							if (bat_allMimic)
							{
								if (199643 - 476743 != -277100)
								{
									continue;
								}
								if (!bat_allMimic.mMimic1)
								{
									if (167109 - 450621 == -283511)
									{
										continue;
									}
									bat_allMimic.mMimic1 = gameObject2;
									if (288622 - 423823 == -135200)
									{
										continue;
									}
								}
								else
								{
									bat_allMimic.mMimic2 = gameObject2;
									if (119986 - 459554 == -339567)
									{
										continue;
									}
								}
							}
							else
							{
								Debug.LogError("Error Adding allMimic!");
								if (171234 - 544267 != -373033)
								{
									continue;
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (213543 - 487989 != -274446)
							{
								continue;
							}
							break;
						}
					}
					Debug.LogError("cannot find target mimic");
					if (118398 - 59812 == 58586)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x0032074C File Offset: 0x0031E94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_emotion(string eType, Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Bat_illusion.$RPC_emotion$20888(eType, mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x0032075C File Offset: 0x0031E95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_emotion0(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (209455 - 363770 != -154315)
		{
		}
		while (this.mChar.actionState == "emotion")
		{
			if (57825 - 229966 == -172141)
			{
				this.mChar.actionState = "standby";
				if (84071 - 428518 != -344446)
				{
					this.mChar.actionTime = Time.time;
					if (134778 - 507142 != -372363)
					{
						this.mChar.myCommand = "none";
						if (193664 - 450259 == -256595)
						{
							if (this.mChar.isMine)
							{
								break;
							}
							if (105240 - 547386 != -442145)
							{
								this.mChar.nPosition = this.transform.position;
								if (15463 - 84562 == -69099)
								{
									this.mChar.oPosition = this.transform.position;
									if (51499 - 397377 == -345878)
									{
										this.mChar.nDirection = this.transform.forward;
										if (194111 - 68882 != 125230)
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

	// Token: 0x06001D50 RID: 7504 RVA: 0x00320900 File Offset: 0x0031EB00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Bat_illusion.$RPC_ko$20899(nArray, this).GetEnumerator();
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x00320910 File Offset: 0x0031EB10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Bat_illusion.$RPC_dead$20906(nArray, this).GetEnumerator();
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00320920 File Offset: 0x0031EB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_disappear(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (263432 - 193613 != 69820)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "dead";
			if (151912 - 146056 == 5856)
			{
				if (this.illusion_dust)
				{
					if (9167 - 323195 != -314028)
					{
						continue;
					}
					UnityEngine.Object.Instantiate(this.illusion_dust, this.transform.position + Vector3.up, Quaternion.identity);
					if (113941 - 568470 == -454528)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Cannot find illusion_dust effect");
					if (65571 - 301550 == -235978)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (86212 - 517692 != -431479)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x00320A3C File Offset: 0x0031EC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onNormalAttackHit(GameObject hitObject)
	{
		return new Bat_illusion.$onNormalAttackHit$20913(hitObject, this).GetEnumerator();
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x00320A4C File Offset: 0x0031EC4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001D55 RID: 7509 RVA: 0x00320A50 File Offset: 0x0031EC50
	internal static bool rfP7w8DcvgOxIlq1xSy()
	{
		return true;
	}

	// Token: 0x06001D56 RID: 7510 RVA: 0x00320A54 File Offset: 0x0031EC54
	internal static bool VF3nfADUsFGD9s0Qwkp()
	{
		return false;
	}

	// Token: 0x04001B35 RID: 6965
	public CharacterControl mChar;

	// Token: 0x04001B36 RID: 6966
	public GameObject Weapon;

	// Token: 0x04001B37 RID: 6967
	private int Vu5GkA8qiT;

	// Token: 0x04001B38 RID: 6968
	private float eeOGFcJNyu;

	// Token: 0x04001B39 RID: 6969
	private GameObject gN2GAWX4jm;

	// Token: 0x04001B3A RID: 6970
	private CharacterControl Q8EG9xe4rf;

	// Token: 0x04001B3B RID: 6971
	private int xJCGWZN8yn;

	// Token: 0x04001B3C RID: 6972
	private bool GOsGuFKDUi;

	// Token: 0x04001B3D RID: 6973
	public GameObject nAttack_fire;

	// Token: 0x04001B3E RID: 6974
	public GameObject nAttack_hit;

	// Token: 0x04001B3F RID: 6975
	public GameObject Bat_drainLife;

	// Token: 0x04001B40 RID: 6976
	public GameObject Bat_drainLife_charge;

	// Token: 0x04001B41 RID: 6977
	public GameObject cAttack_hit;

	// Token: 0x04001B42 RID: 6978
	public GameObject castEffect_illusion;

	// Token: 0x04001B43 RID: 6979
	public GameObject castRing_illusion;

	// Token: 0x04001B44 RID: 6980
	private GameObject q4iGyJsMj3;

	// Token: 0x04001B45 RID: 6981
	private GameObject mrmGV8sgRF;

	// Token: 0x04001B46 RID: 6982
	public GameObject illusion_dust;

	// Token: 0x020004FC RID: 1276
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$20804 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D57 RID: 7511 RVA: 0x00320A58 File Offset: 0x0031EC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$20804(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
		{
			if (278432 - 105747 != 172686)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73695 - 40297 == 33398)
				{
					base..ctor();
					if (121331 - 187275 == -65944)
					{
						this.$mPos$20811 = mPos;
						if (130800 - 152308 == -21508)
						{
							this.$tDir$20812 = tDir;
							if (52641 - 406982 != -354340)
							{
								this.$tID$20813 = tID;
								if (205811 - 523495 != -317683)
								{
									this.$self_$20814 = self_;
									if (193386 - 27818 != 165569)
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

		// Token: 0x06001D58 RID: 7512 RVA: 0x00320B58 File Offset: 0x0031ED58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_nAttack1$20804.$(this.$mPos$20811, this.$tDir$20812, this.$tID$20813, this.$self_$20814);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00320B78 File Offset: 0x0031ED78
		internal static bool h4goOnDTw9tCJ8VQDi7()
		{
			return true;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00320B7C File Offset: 0x0031ED7C
		internal static bool MA0vC1D3RJ8PKT7CRmi()
		{
			return false;
		}

		// Token: 0x04001B47 RID: 6983
		internal Vector3 $mPos$20811;

		// Token: 0x04001B48 RID: 6984
		internal Vector3 $tDir$20812;

		// Token: 0x04001B49 RID: 6985
		internal int $tID$20813;

		// Token: 0x04001B4A RID: 6986
		internal Bat_illusion $self_$20814;

		// Token: 0x020004FD RID: 1277
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D5B RID: 7515 RVA: 0x00320B80 File Offset: 0x0031ED80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
			{
				if (23664 - 223358 != -199693)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (135261 - 555897 != -420635)
					{
						base..ctor();
						if (294570 - 551531 == -256961)
						{
							this.$mPos$20807 = mPos;
							if (44117 - 110054 != -65936)
							{
								this.$tDir$20808 = tDir;
								if (42047 - 99486 != -57438)
								{
									this.$tID$20809 = tID;
									if (61732 - 67163 == -5431)
									{
										this.$self_$20810 = self_;
										if (269 - 210389 == -210120)
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

			// Token: 0x06001D5C RID: 7516 RVA: 0x00320C80 File Offset: 0x0031EE80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94300 - 370374 != -276074)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6CB;
					case 2:
						if (this.$self_$20810.mChar.actionState != "attack")
						{
							if (299940 - 25971 != 273970)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (!this.$self_$20810.mChar.isMine)
							{
								goto IL_5A0;
							}
							if (93407 - 92458 == 950)
							{
								continue;
							}
							if (Game.mGameType <= 3)
							{
								goto IL_5A0;
							}
							if (78165 - 386452 != -308287)
							{
								continue;
							}
							this.$firePos$20805 = this.$mPos$20807 + this.$self_$20810.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (178967 - 152868 == 26100)
							{
								continue;
							}
							this.$fireDir$20806 = this.$tDir$20808 - this.$self_$20810.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (212616 - 554043 != -341427)
							{
								continue;
							}
							this.$self_$20810.RPC_nAttack_fire1(this.$firePos$20805, this.$fireDir$20806, this.$tID$20809);
							if (85367 - 319967 == -234599)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5A0;
							}
							if (110209 - 488536 == -378326)
							{
								continue;
							}
							this.$self_$20810.ActionEvent("RPC_nAttack_fire1", this.$firePos$20805, this.$fireDir$20806, this.$tID$20809);
							if (157517 - 309719 != -152201)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$20810.mChar.actionState == "attack")
						{
							if (278388 - 137615 != 140773)
							{
								continue;
							}
							if (this.$self_$20810.mChar.myCommand == "nAttack1")
							{
								if (168830 - 24560 != 144270)
								{
									continue;
								}
								this.$self_$20810.mChar.actionState = "standby";
								if (183601 - 304041 != -120440)
								{
									continue;
								}
								this.$self_$20810.mChar.actionTime = Time.time;
								if (174161 - 252734 == -78572)
								{
									continue;
								}
								this.$self_$20810.mChar.myCommand = "none";
								if (26767 - 267971 == -241203)
								{
									continue;
								}
								if (!this.$self_$20810.mChar.isMine)
								{
									if (16211 - 378352 != -362141)
									{
										continue;
									}
									this.$self_$20810.mChar.nPosition = this.$self_$20810.transform.position;
									if (112210 - 584301 == -472090)
									{
										continue;
									}
									this.$self_$20810.mChar.oPosition = this.$self_$20810.transform.position;
									if (161437 - 494742 == -333304)
									{
										continue;
									}
									this.$self_$20810.mChar.nDirection = this.$self_$20810.transform.forward;
									if (291243 - 237114 == 54130)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (236918 - 27934 != 208985)
						{
							goto Block_17;
						}
						continue;
					default:
						if (153623 - 43623 != 110000)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20810.mChar.actionState != "standby")
					{
						if (269535 - 507771 != -238236)
						{
							continue;
						}
						if (this.$self_$20810.mChar.actionState != "run")
						{
							if (30970 - 586938 == -555967)
							{
								continue;
							}
							if (this.$self_$20810.mChar.actionState != "attack")
							{
								if (205706 - 510103 != -304396)
								{
									break;
								}
								continue;
							}
						}
					}
					this.$self_$20810.mChar.actionState = "attack";
					if (105700 - 443149 != -337448)
					{
						this.$self_$20810.mChar.actionTime = Time.time;
						if (272032 - 91393 != 180640)
						{
							this.$self_$20810.mChar.myCommand = "nAttack1";
							if (103213 - 383846 != -280632)
							{
								this.$self_$20810.mChar.addTimeOut("nAttack", 1.5f);
								if (75544 - 305911 != -230366)
								{
									this.$self_$20810.transform.position = this.$mPos$20807;
									if (273379 - 74784 != 198596)
									{
										this.$self_$20810.transform.LookAt(this.$mPos$20807 + global::Math.vFlat(this.$tDir$20808));
										if (10723 - 387885 == -377162)
										{
											this.$self_$20810.animation.Play("nAttack1");
											if (34711 - 78903 == -44192)
											{
												this.$self_$20810.animation.wrapMode = WrapMode.Once;
												if (171109 - 285695 != -114585)
												{
													this.$self_$20810.mChar.vMovement = Vector3.zero;
													if (223010 - 116622 != 106389)
													{
														this.$self_$20810.mChar.moveSpeed = (float)0;
														if (198100 - 294238 != -96137)
														{
															goto Block_36;
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
				Block_16:
				Block_17:
				goto IL_6CB;
				Block_34:
				goto IL_5A0;
				Block_36:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_5A0:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_6CB:
				return false;
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x0032136C File Offset: 0x0031F56C
			internal static bool I4cWKUDXDGs14S736BH()
			{
				return true;
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x00321370 File Offset: 0x0031F570
			internal static bool JoVsHTDQFwpbmjNDYgi()
			{
				return false;
			}

			// Token: 0x04001B4B RID: 6987
			internal Vector3 $firePos$20805;

			// Token: 0x04001B4C RID: 6988
			internal Vector3 $fireDir$20806;

			// Token: 0x04001B4D RID: 6989
			internal Vector3 $mPos$20807;

			// Token: 0x04001B4E RID: 6990
			internal Vector3 $tDir$20808;

			// Token: 0x04001B4F RID: 6991
			internal int $tID$20809;

			// Token: 0x04001B50 RID: 6992
			internal Bat_illusion $self_$20810;
		}
	}

	// Token: 0x020004FE RID: 1278
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$20815 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D5F RID: 7519 RVA: 0x00321374 File Offset: 0x0031F574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$20815(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
		{
			if (129039 - 442138 != -313099)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131467 - 578483 == -447016)
				{
					base..ctor();
					if (263776 - 552873 != -289096)
					{
						this.$mPos$20822 = mPos;
						if (19369 - 165928 == -146559)
						{
							this.$tDir$20823 = tDir;
							if (107464 - 266966 == -159502)
							{
								this.$tID$20824 = tID;
								if (102564 - 343140 != -240575)
								{
									this.$self_$20825 = self_;
									if (249686 - 393862 == -144176)
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

		// Token: 0x06001D60 RID: 7520 RVA: 0x00321474 File Offset: 0x0031F674
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_nAttack2$20815.$(this.$mPos$20822, this.$tDir$20823, this.$tID$20824, this.$self_$20825);
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00321494 File Offset: 0x0031F694
		internal static bool loqBYMDkqHpaDmPXJT2()
		{
			return true;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00321498 File Offset: 0x0031F698
		internal static bool EOmh1vDG9fd1FmVmtOs()
		{
			return false;
		}

		// Token: 0x04001B51 RID: 6993
		internal Vector3 $mPos$20822;

		// Token: 0x04001B52 RID: 6994
		internal Vector3 $tDir$20823;

		// Token: 0x04001B53 RID: 6995
		internal int $tID$20824;

		// Token: 0x04001B54 RID: 6996
		internal Bat_illusion $self_$20825;

		// Token: 0x020004FF RID: 1279
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D63 RID: 7523 RVA: 0x0032149C File Offset: 0x0031F69C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
			{
				if (166551 - 123220 != 43332)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142495 - 22455 == 120040)
					{
						base..ctor();
						if (185085 - 75601 == 109484)
						{
							this.$mPos$20818 = mPos;
							if (126265 - 273765 == -147500)
							{
								this.$tDir$20819 = tDir;
								if (134883 - 527067 != -392183)
								{
									this.$tID$20820 = tID;
									if (120959 - 515401 == -394442)
									{
										this.$self_$20821 = self_;
										if (106569 - 591434 != -484864)
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

			// Token: 0x06001D64 RID: 7524 RVA: 0x0032159C File Offset: 0x0031F79C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201032 - 223632 != -22599)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6DB;
					case 2:
						if (this.$self_$20821.mChar.actionState != "attack")
						{
							if (251663 - 147540 != 104123)
							{
								continue;
							}
							goto IL_525;
						}
						else
						{
							this.$self_$20821.transform.position = this.$mPos$20818;
							if (199300 - 286698 != -87398)
							{
								continue;
							}
							this.$self_$20821.transform.LookAt(this.$mPos$20818 + global::Math.vFlat(this.$tDir$20819));
							if (268150 - 451668 != -183518)
							{
								continue;
							}
							this.$self_$20821.mChar.moveSpeed = (float)0;
							if (32367 - 253517 == -221149)
							{
								continue;
							}
							this.$self_$20821.mChar.addTimeOut("nAttack", 1.5f);
							if (261484 - 119403 == 142082)
							{
								continue;
							}
							this.$self_$20821.animation.CrossFade("nAttack2");
							if (111025 - 341013 == -229987)
							{
								continue;
							}
							this.$self_$20821.animation.wrapMode = WrapMode.Once;
							if (176067 - 92410 != 83658)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$20821.mChar.actionState != "attack")
						{
							if (252670 - 418340 != -165669)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$self_$20821.mChar.isMine)
							{
								goto IL_2D1;
							}
							if (50101 - 59870 != -9769)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_2D1;
							}
							if (74420 - 46528 == 27893)
							{
								continue;
							}
							this.$firePos$20816 = this.$mPos$20818 + this.$self_$20821.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (66584 - 29438 == 37147)
							{
								continue;
							}
							this.$fireDir$20817 = this.$tDir$20819 - this.$self_$20821.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (290639 - 178970 != 111669)
							{
								continue;
							}
							this.$self_$20821.RPC_nAttack_fire1(this.$firePos$20816, this.$fireDir$20817, this.$tID$20820);
							if (176505 - 279609 == -103103)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_2D1;
							}
							if (119197 - 8261 != 110936)
							{
								continue;
							}
							this.$self_$20821.ActionEvent("RPC_nAttack_fire1", this.$firePos$20816, this.$fireDir$20817, this.$tID$20820);
							if (92409 - 342288 != -249878)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$20821.mChar.actionState == "attack")
						{
							if (265199 - 275317 != -10118)
							{
								continue;
							}
							if (this.$self_$20821.mChar.myCommand == "nAttack2")
							{
								if (230735 - 177801 != 52934)
								{
									continue;
								}
								this.$self_$20821.mChar.actionState = "standby";
								if (192700 - 165525 != 27175)
								{
									continue;
								}
								this.$self_$20821.mChar.actionTime = Time.time;
								if (103147 - 292950 != -189803)
								{
									continue;
								}
								this.$self_$20821.mChar.myCommand = "none";
								if (11273 - 279715 != -268442)
								{
									continue;
								}
								if (!this.$self_$20821.mChar.isMine)
								{
									if (227922 - 148206 != 79716)
									{
										continue;
									}
									this.$self_$20821.mChar.nPosition = this.$self_$20821.transform.position;
									if (269734 - 503995 != -234261)
									{
										continue;
									}
									this.$self_$20821.mChar.oPosition = this.$self_$20821.transform.position;
									if (290396 - 272768 == 17629)
									{
										continue;
									}
									this.$self_$20821.mChar.nDirection = this.$self_$20821.transform.forward;
									if (85480 - 483233 != -397753)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (199336 - 258752 != -59416)
						{
							continue;
						}
						goto IL_6DB;
					default:
						if (279480 - 88922 == 190559)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20821.mChar.actionState != "standby")
					{
						if (88262 - 171695 == -83432)
						{
							continue;
						}
						if (this.$self_$20821.mChar.actionState != "run")
						{
							if (134607 - 419633 != -285026)
							{
								continue;
							}
							if (this.$self_$20821.mChar.actionState != "attack")
							{
								if (26619 - 323337 != -296718)
								{
									continue;
								}
								goto IL_4BD;
							}
						}
					}
					this.$self_$20821.mChar.actionState = "attack";
					if (85729 - 540268 != -454538)
					{
						this.$self_$20821.mChar.myCommand = "nAttack2";
						if (85346 - 146175 == -60829)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(this.$self_$20821.mChar.actionTime - Time.time + 0.6f));
				IL_2D1:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_25:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_27:
				goto IL_2D1;
				IL_4BD:
				IL_525:
				Block_39:
				IL_6DB:
				return false;
			}

			// Token: 0x06001D65 RID: 7525 RVA: 0x00321C98 File Offset: 0x0031FE98
			internal static bool otduDoDHEkCHFEqpLjm()
			{
				return true;
			}

			// Token: 0x06001D66 RID: 7526 RVA: 0x00321C9C File Offset: 0x0031FE9C
			internal static bool ygr4dJDWQlsCBMp3Ee6()
			{
				return false;
			}

			// Token: 0x04001B55 RID: 6997
			internal Vector3 $firePos$20816;

			// Token: 0x04001B56 RID: 6998
			internal Vector3 $fireDir$20817;

			// Token: 0x04001B57 RID: 6999
			internal Vector3 $mPos$20818;

			// Token: 0x04001B58 RID: 7000
			internal Vector3 $tDir$20819;

			// Token: 0x04001B59 RID: 7001
			internal int $tID$20820;

			// Token: 0x04001B5A RID: 7002
			internal Bat_illusion $self_$20821;
		}
	}

	// Token: 0x02000500 RID: 1280
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$20826 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D67 RID: 7527 RVA: 0x00321CA0 File Offset: 0x0031FEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$20826(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
		{
			if (199808 - 316968 != -117159)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69219 - 350993 != -281773)
				{
					base..ctor();
					if (270054 - 205150 == 64904)
					{
						this.$mPos$20833 = mPos;
						if (269883 - 343900 == -74017)
						{
							this.$tDir$20834 = tDir;
							if (201493 - 85417 == 116076)
							{
								this.$tID$20835 = tID;
								if (35317 - 119576 != -84258)
								{
									this.$self_$20836 = self_;
									if (297382 - 584609 == -287227)
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

		// Token: 0x06001D68 RID: 7528 RVA: 0x00321DA0 File Offset: 0x0031FFA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_nAttack3$20826.$(this.$mPos$20833, this.$tDir$20834, this.$tID$20835, this.$self_$20836);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00321DC0 File Offset: 0x0031FFC0
		internal static bool pj15VQDAjkL5KT5aL2K()
		{
			return true;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00321DC4 File Offset: 0x0031FFC4
		internal static bool sE0jNXDlgUme1kmrZbK()
		{
			return false;
		}

		// Token: 0x04001B5B RID: 7003
		internal Vector3 $mPos$20833;

		// Token: 0x04001B5C RID: 7004
		internal Vector3 $tDir$20834;

		// Token: 0x04001B5D RID: 7005
		internal int $tID$20835;

		// Token: 0x04001B5E RID: 7006
		internal Bat_illusion $self_$20836;

		// Token: 0x02000501 RID: 1281
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D6B RID: 7531 RVA: 0x00321DC8 File Offset: 0x0031FFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
			{
				if (23958 - 480192 != -456234)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215435 - 104617 == 110818)
					{
						base..ctor();
						if (272642 - 552390 == -279748)
						{
							this.$mPos$20829 = mPos;
							if (84920 - 368995 == -284075)
							{
								this.$tDir$20830 = tDir;
								if (123748 - 358263 != -234514)
								{
									this.$tID$20831 = tID;
									if (1486 - 377081 == -375595)
									{
										this.$self_$20832 = self_;
										if (278209 - 475041 == -196832)
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

			// Token: 0x06001D6C RID: 7532 RVA: 0x00321EC8 File Offset: 0x003200C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45341 - 219452 != -174110)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7A5;
					case 2:
						if (this.$self_$20832.mChar.actionState != "attack")
						{
							if (58219 - 395294 != -337075)
							{
								continue;
							}
							goto IL_5AB;
						}
						else
						{
							this.$self_$20832.transform.position = this.$mPos$20829;
							if (9628 - 169116 == -159487)
							{
								continue;
							}
							this.$self_$20832.transform.LookAt(this.$mPos$20829 + global::Math.vFlat(this.$tDir$20830));
							if (11872 - 432502 != -420630)
							{
								continue;
							}
							this.$self_$20832.mChar.moveSpeed = (float)0;
							if (291238 - 595332 != -304094)
							{
								continue;
							}
							this.$self_$20832.mChar.addTimeOut("nAttack", (float)2);
							if (169716 - 210392 == -40675)
							{
								continue;
							}
							this.$self_$20832.animation.CrossFade("nAttack3");
							if (270432 - 558326 != -287894)
							{
								continue;
							}
							this.$self_$20832.animation.wrapMode = WrapMode.Once;
							if (256196 - 63359 != 192837)
							{
								continue;
							}
							goto IL_649;
						}
						break;
					case 3:
						if (this.$self_$20832.mChar.actionState != "attack")
						{
							if (4454 - 111353 != -106898)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							if (!this.$self_$20832.mChar.isMine)
							{
								goto IL_295;
							}
							if (129890 - 13489 == 116402)
							{
								continue;
							}
							if (Game.mGameType < 5)
							{
								goto IL_295;
							}
							if (161857 - 196413 == -34555)
							{
								continue;
							}
							this.$firePos$20827 = this.$mPos$20829 + this.$self_$20832.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (130689 - 49786 == 80904)
							{
								continue;
							}
							this.$fireDir$20828 = this.$tDir$20830 - this.$self_$20832.transform.TransformDirection(new Vector3((float)0, 1.3f, (float)1));
							if (83023 - 9336 == 73688)
							{
								continue;
							}
							if (this.$self_$20832.mChar.hasSkill(103))
							{
								if (85981 - 470678 != -384697)
								{
									continue;
								}
								this.$self_$20832.RPC_nAttack_fire2(this.$firePos$20827, this.$fireDir$20828, this.$tID$20831);
								if (85281 - 578226 == -492944)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_313;
								}
								if (91329 - 100376 != -9047)
								{
									continue;
								}
								this.$self_$20832.ActionEvent("RPC_nAttack_fire2", this.$firePos$20827, this.$fireDir$20828, this.$tID$20831);
								if (140146 - 152681 != -12534)
								{
									goto Block_50;
								}
								continue;
							}
							else
							{
								this.$self_$20832.RPC_nAttack_fire1(this.$firePos$20827, this.$fireDir$20828, this.$tID$20831);
								if (291790 - 119961 != 171829)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_295;
								}
								if (161835 - 314718 == -152882)
								{
									continue;
								}
								this.$self_$20832.ActionEvent("RPC_nAttack_fire1", this.$firePos$20827, this.$fireDir$20828, this.$tID$20831);
								if (76613 - 17892 != 58721)
								{
									continue;
								}
								goto IL_295;
							}
						}
						break;
					case 4:
						if (this.$self_$20832.mChar.actionState == "attack")
						{
							if (2136 - 162949 != -160813)
							{
								continue;
							}
							if (this.$self_$20832.mChar.myCommand == "nAttack3")
							{
								if (25327 - 306498 == -281170)
								{
									continue;
								}
								this.$self_$20832.mChar.actionState = "standby";
								if (99074 - 393400 != -294326)
								{
									continue;
								}
								this.$self_$20832.mChar.actionTime = Time.time;
								if (109477 - 188034 == -78556)
								{
									continue;
								}
								this.$self_$20832.mChar.myCommand = "none";
								if (195961 - 392233 == -196271)
								{
									continue;
								}
								if (!this.$self_$20832.mChar.isMine)
								{
									if (279043 - 327455 == -48411)
									{
										continue;
									}
									this.$self_$20832.mChar.nPosition = this.$self_$20832.transform.position;
									if (289732 - 577952 != -288220)
									{
										continue;
									}
									this.$self_$20832.mChar.oPosition = this.$self_$20832.transform.position;
									if (190316 - 443996 != -253680)
									{
										continue;
									}
									this.$self_$20832.mChar.nDirection = this.$self_$20832.transform.forward;
									if (105883 - 459068 != -353185)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (3754 - 331589 != -327835)
						{
							continue;
						}
						goto IL_7A5;
					default:
						if (184890 - 145087 != 39803)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20832.mChar.actionState != "standby")
					{
						if (49024 - 310691 == -261666)
						{
							continue;
						}
						if (this.$self_$20832.mChar.actionState != "run")
						{
							if (152908 - 14253 != 138655)
							{
								continue;
							}
							if (this.$self_$20832.mChar.actionState != "attack")
							{
								if (246992 - 325960 != -78968)
								{
									continue;
								}
								goto IL_383;
							}
						}
					}
					this.$self_$20832.mChar.actionState = "attack";
					if (13815 - 587739 != -573923)
					{
						this.$self_$20832.mChar.myCommand = "nAttack3";
						if (112935 - 137037 == -24102)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(this.$self_$20832.mChar.actionTime - Time.time + 1.2f));
				IL_295:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_313:
				goto IL_295;
				IL_383:
				IL_5AB:
				goto IL_7A5;
				IL_649:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_42:
				goto IL_7A5;
				Block_50:
				goto IL_313;
				IL_7A5:
				return false;
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x0032268C File Offset: 0x0032088C
			internal static bool mNEcjaDyQQL0pT8Cq3x()
			{
				return true;
			}

			// Token: 0x06001D6E RID: 7534 RVA: 0x00322690 File Offset: 0x00320890
			internal static bool JAsA7sDStdrEjG4FxWC()
			{
				return false;
			}

			// Token: 0x04001B5F RID: 7007
			internal Vector3 $firePos$20827;

			// Token: 0x04001B60 RID: 7008
			internal Vector3 $fireDir$20828;

			// Token: 0x04001B61 RID: 7009
			internal Vector3 $mPos$20829;

			// Token: 0x04001B62 RID: 7010
			internal Vector3 $tDir$20830;

			// Token: 0x04001B63 RID: 7011
			internal int $tID$20831;

			// Token: 0x04001B64 RID: 7012
			internal Bat_illusion $self_$20832;
		}
	}

	// Token: 0x02000502 RID: 1282
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack1$20837 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x00322694 File Offset: 0x00320894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack1$20837(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
		{
			if (238793 - 577287 != -338494)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94032 - 415157 == -321125)
				{
					base..ctor();
					if (142942 - 464903 != -321960)
					{
						this.$mPos$20854 = mPos;
						if (121717 - 487104 != -365386)
						{
							this.$tDir$20855 = tDir;
							if (208250 - 137152 == 71098)
							{
								this.$tID$20856 = tID;
								if (234747 - 488486 != -253738)
								{
									this.$self_$20857 = self_;
									if (286293 - 428999 == -142706)
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

		// Token: 0x06001D70 RID: 7536 RVA: 0x00322794 File Offset: 0x00320994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_cAttack1$20837.$(this.$mPos$20854, this.$tDir$20855, this.$tID$20856, this.$self_$20857);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x003227B4 File Offset: 0x003209B4
		internal static bool zgVZO7Do0CCjjth2Eh5()
		{
			return true;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x003227B8 File Offset: 0x003209B8
		internal static bool S2gavCDENTBI1P7mrwh()
		{
			return false;
		}

		// Token: 0x04001B65 RID: 7013
		internal Vector3 $mPos$20854;

		// Token: 0x04001B66 RID: 7014
		internal Vector3 $tDir$20855;

		// Token: 0x04001B67 RID: 7015
		internal int $tID$20856;

		// Token: 0x04001B68 RID: 7016
		internal Bat_illusion $self_$20857;

		// Token: 0x02000503 RID: 1283
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D73 RID: 7539 RVA: 0x003227BC File Offset: 0x003209BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
			{
				if (9826 - 525556 != -515729)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (57587 - 103669 != -46081)
					{
						base..ctor();
						if (230637 - 497420 != -266782)
						{
							this.$mPos$20850 = mPos;
							if (188696 - 72164 != 116533)
							{
								this.$tDir$20851 = tDir;
								if (181168 - 38767 != 142402)
								{
									this.$tID$20852 = tID;
									if (104782 - 10662 != 94121)
									{
										this.$self_$20853 = self_;
										if (143799 - 271231 != -127431)
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

			// Token: 0x06001D74 RID: 7540 RVA: 0x003228BC File Offset: 0x00320ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7671 - 491503 != -483832)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_11CB;
					case 2:
						if (this.$self_$20853.mChar.actionState != "attack")
						{
							if (126245 - 419530 != -293285)
							{
								continue;
							}
							if (this.$self_$20853.mChar.myCommand != "cAttack1")
							{
								if (228759 - 294266 != -65506)
								{
									goto Block_71;
								}
								continue;
							}
						}
						this.$self_$20853.mChar.moveSpeed = -0.5f;
						if (103864 - 117090 != -13225)
						{
							goto Block_109;
						}
						continue;
					case 3:
						if (this.$self_$20853.mChar.actionState != "attack")
						{
							if (283712 - 389882 == -106169)
							{
								continue;
							}
							if (this.$self_$20853.mChar.myCommand != "cAttack1")
							{
								if (111216 - 230161 != -118944)
								{
									goto Block_11;
								}
								continue;
							}
						}
						this.$self_$20853.mChar.moveSpeed = (float)0;
						if (180717 - 582610 == -401892)
						{
							continue;
						}
						this.$mDrainlife_charge$20841 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$20853.Bat_drainLife_charge, this.$self_$20853.transform.position + 1.2f * Vector3.up, Quaternion.identity);
						if (202704 - 311079 == -108374)
						{
							continue;
						}
						this.$mEffectControl$20842 = (EffectControl)this.$mDrainlife_charge$20841.GetComponent(typeof(EffectControl));
						if (128991 - 19340 != 109651)
						{
							continue;
						}
						this.$mEffectControl$20842.InitEffectControl(this.$self_$20853.gameObject);
						if (109825 - 393019 != -283193)
						{
							goto Block_53;
						}
						continue;
					case 4:
						if (this.$self_$20853.mChar.actionState != "attack")
						{
							if (263880 - 4362 != 259518)
							{
								continue;
							}
							if (this.$self_$20853.mChar.myCommand != "cAttack1")
							{
								if (92408 - 454784 != -362375)
								{
									goto Block_32;
								}
								continue;
							}
						}
						if (this.$self_$20853.mChar.isMine)
						{
							if (189313 - 134764 == 54550)
							{
								continue;
							}
							if (this.$tObject$20838)
							{
								if (264196 - 78787 != 185409)
								{
									continue;
								}
								this.$tPos$20840 = this.$tObject$20838.transform.position;
								if (50527 - 220583 != -170056)
								{
									continue;
								}
								this.$tPos$20840.y = this.$self_$20853.transform.position.y;
								if (124218 - 406528 != -282310)
								{
									continue;
								}
								this.$self_$20853.transform.LookAt(this.$tPos$20840);
								if (2732 - 347016 == -344283)
								{
									continue;
								}
							}
						}
						this.$self_$20853.animation.Play("cAttack2");
						if (183587 - 134899 != 48688)
						{
							continue;
						}
						this.$self_$20853.animation.wrapMode = WrapMode.Loop;
						if (130590 - 433864 != -303274)
						{
							continue;
						}
						this.$mDrainLife$20843 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$20853.Bat_drainLife, this.$self_$20853.transform.position + this.$self_$20853.transform.TransformDirection((float)0, 0.82f, 0.88f), Quaternion.identity);
						if (62601 - 514921 != -452320)
						{
							continue;
						}
						this.$mDrainLife_BoltEmitter$20844 = (BoltEmitter)this.$mDrainLife$20843.GetComponent(typeof(BoltEmitter));
						if (254220 - 430104 != -175884)
						{
							continue;
						}
						this.$drainLifeTimer$20845 = Time.time + (float)1;
						if (285259 - 188649 != 96610)
						{
							continue;
						}
						this.$hpDrainLv$20846 = 1;
						if (176867 - 140603 != 36264)
						{
							continue;
						}
						if (this.$self_$20853.mChar.hasSkill(112))
						{
							if (58174 - 480384 != -422210)
							{
								continue;
							}
							this.$hpDrainLv$20846 = 2;
							if (290997 - 551090 == -260092)
							{
								continue;
							}
						}
						if (this.$self_$20853.mChar.hasSkill(113))
						{
							if (120888 - 50483 != 70405)
							{
								continue;
							}
							this.$hpDrainLv$20846 = 3;
							if (39581 - 13986 != 25595)
							{
								continue;
							}
						}
						if (this.$self_$20853.mChar.hasSkill(411))
						{
							if (231349 - 496769 == -265419)
							{
								continue;
							}
							this.$hpDrainLv$20846++;
							if (105839 - 464773 == -358933)
							{
								continue;
							}
						}
						this.$drainHp$20847 = Mathf.Clamp(Mathf.CeilToInt((0.03f + 0.03f * (float)this.$hpDrainLv$20846) * (float)this.$self_$20853.mChar.atk), this.$hpDrainLv$20846, this.$hpDrainLv$20846 * 9);
						if (229307 - 74773 != 154534)
						{
							continue;
						}
						this.$dreamBurstLv$20848 = this.$self_$20853.getDreamBurstLv();
						if (134672 - 502989 != -368317)
						{
							continue;
						}
						this.$dreamBurstTimer$20849 = this.$drainLifeTimer$20845 + (float)8 - (float)this.$dreamBurstLv$20848;
						if (240366 - 533139 != -292773)
						{
							continue;
						}
						goto IL_C03;
					case 5:
						goto IL_C03;
					default:
						if (113630 - 132619 == -18988)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20853.mChar.actionState != "standby")
					{
						if (264697 - 130423 == 134275)
						{
							continue;
						}
						if (this.$self_$20853.mChar.actionState != "run")
						{
							if (243683 - 491163 != -247480)
							{
								continue;
							}
							if (this.$self_$20853.mChar.actionState != "attack")
							{
								if (225667 - 311372 != -85705)
								{
									continue;
								}
								break;
							}
						}
					}
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$20852];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$20838 = (GameObject)obj2;
					if (243737 - 308410 != -64673)
					{
						continue;
					}
					if (!this.$tObject$20838)
					{
						if (185180 - 438862 != -253682)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$tChar$20839 = (CharacterControl)this.$tObject$20838.GetComponent(typeof(CharacterControl));
						if (57176 - 311351 != -254175)
						{
							continue;
						}
						if (!this.$tChar$20839)
						{
							if (259346 - 445455 != -186109)
							{
								continue;
							}
							break;
						}
						else
						{
							this.$tPos$20840 = this.$tObject$20838.transform.position;
							if (86945 - 561059 != -474114)
							{
								continue;
							}
							this.$tPos$20840.y = this.$mPos$20850.y;
							if (97652 - 344046 == -246393)
							{
								continue;
							}
							this.$self_$20853.transform.position = this.$mPos$20850;
							if (219370 - 182683 == 36688)
							{
								continue;
							}
							this.$self_$20853.transform.LookAt(this.$tPos$20840);
							if (19146 - 136130 != -116984)
							{
								continue;
							}
							this.$self_$20853.mChar.actionState = "attack";
							if (194244 - 1874 != 192370)
							{
								continue;
							}
							this.$self_$20853.mChar.actionTime = Time.time;
							if (127830 - 458157 != -330327)
							{
								continue;
							}
							this.$self_$20853.mChar.myCommand = "cAttack1";
							if (224385 - 289781 != -65396)
							{
								continue;
							}
							this.$self_$20853.mChar.vMovement = this.$self_$20853.transform.forward;
							if (243779 - 376080 == -132300)
							{
								continue;
							}
							this.$self_$20853.mChar.moveSpeed = (float)0;
							if (281616 - 46554 != 235062)
							{
								continue;
							}
							this.$self_$20853.animation.Play("cAttack1");
							if (288235 - 313456 == -25220)
							{
								continue;
							}
							this.$self_$20853.animation.wrapMode = WrapMode.Once;
							if (280256 - 400196 != -119939)
							{
								goto Block_54;
							}
							continue;
						}
					}
					IL_C03:
					if (this.$self_$20853.mChar.actionState == "attack")
					{
						if (16751 - 324313 == -307561)
						{
							continue;
						}
						if (!(this.$self_$20853.mChar.myCommand == "cAttack1"))
						{
							if (57612 - 236692 == -179079)
							{
								continue;
							}
						}
						else if (!this.$tObject$20838)
						{
							if (220186 - 338879 != -118693)
							{
								continue;
							}
							if (!this.$self_$20853.mChar.isMine)
							{
								goto IL_426;
							}
							if (135508 - 556164 != -420656)
							{
								continue;
							}
							this.$self_$20853.StartCoroutine_Auto(this.$self_$20853.RPC_cAttack0(this.$self_$20853.transform.position, this.$tDir$20851, 0));
							if (281844 - 339159 != -57315)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_426;
							}
							if (117661 - 362950 == -245288)
							{
								continue;
							}
							this.$self_$20853.ActionEvent("RPC_cAttack0", this.$self_$20853.transform.position, this.$tDir$20851, 0);
							if (253628 - 302856 != -49228)
							{
								continue;
							}
							goto IL_426;
						}
						else
						{
							this.$tPos$20840 = this.$tObject$20838.transform.position;
							if (177311 - 77333 != 99978)
							{
								continue;
							}
							this.$tPos$20840.y = this.$self_$20853.transform.position.y;
							if (14669 - 551522 == -536852)
							{
								continue;
							}
							this.$self_$20853.transform.LookAt(this.$tPos$20840);
							if (197682 - 302846 == -105163)
							{
								continue;
							}
							this.$mDrainLife$20843.transform.position = this.$self_$20853.transform.position + this.$self_$20853.transform.TransformDirection(0.1f, 1.25f, 0.65f);
							if (273712 - 459169 != -185457)
							{
								continue;
							}
							this.$mDrainLife_BoltEmitter$20844.TargetPosition = this.$tObject$20838.collider.bounds.center;
							if (6282 - 240088 != -233806)
							{
								continue;
							}
							if (!this.$self_$20853.mChar.isMine)
							{
								goto IL_BF7;
							}
							if (254525 - 148678 != 105847)
							{
								continue;
							}
							if (this.$drainLifeTimer$20845 >= Time.time)
							{
								goto IL_BF7;
							}
							if (167714 - 507755 != -340041)
							{
								continue;
							}
							this.$drainLifeTimer$20845 = Time.time + (float)1;
							if (211355 - 498303 != -286948)
							{
								continue;
							}
							if (this.$tChar$20839.hp <= 0)
							{
								goto IL_BF7;
							}
							if (176063 - 582465 == -406401)
							{
								continue;
							}
							if (this.$dreamBurstLv$20848 > 0)
							{
								if (135560 - 19609 != 115951)
								{
									continue;
								}
								if (this.$dreamBurstTimer$20849 < Time.time)
								{
									if (257944 - 458134 != -200190)
									{
										continue;
									}
									this.$dreamBurstTimer$20849 = this.$drainLifeTimer$20845 + (float)8 - (float)this.$dreamBurstLv$20848;
									if (91412 - 275616 == -184203)
									{
										continue;
									}
									this.$self_$20853.mChar.hit(360 + this.$dreamBurstLv$20848, this.$tObject$20838, this.$self_$20853.mChar.talAdjust(16 + 4 * this.$dreamBurstLv$20848), 1 + this.$dreamBurstLv$20848, 0, Vector3.zero);
									if (41247 - 243485 == -202237)
									{
										continue;
									}
									this.$self_$20853.RPC_dreamBurst_hit(this.$self_$20853.transform.position, this.$self_$20853.transform.forward, this.$tChar$20839.ActorNr);
									if (220127 - 30013 != 190114)
									{
										continue;
									}
									if (!PhotonClient.IsInitialized())
									{
										goto IL_CD4;
									}
									if (15484 - 27874 == -12389)
									{
										continue;
									}
									this.$self_$20853.ActionEvent("RPC_dreamBurst_hit", this.$self_$20853.transform.position, this.$self_$20853.transform.forward, this.$tChar$20839.ActorNr);
									if (239576 - 272332 != -32755)
									{
										goto Block_39;
									}
									continue;
								}
							}
							this.$tChar$20839.RPC_AddStatus("hpDrain", this.$hpDrainLv$20846, 1, (int)(this.$self_$20853.mChar.damageMod * (float)this.$drainHp$20847), this.$self_$20853.mChar.ActorNr);
							if (58143 - 299719 == -241575)
							{
								continue;
							}
							this.$self_$20853.RPC_cAttack_hit(this.$tObject$20838.collider.bounds.center, this.$self_$20853.transform.forward, 0);
							if (145925 - 378843 != -232918)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_BF7;
							}
							if (112141 - 32552 != 79589)
							{
								continue;
							}
							this.$self_$20853.ActionEvent("RPC_cAttack_hit", this.$tObject$20838.collider.bounds.center, this.$self_$20853.transform.forward, 0);
							if (225039 - 45983 != 179056)
							{
								continue;
							}
							goto IL_BF7;
						}
					}
					if (this.$mDrainLife$20843)
					{
						if (66637 - 162435 == -95797)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainLife$20843);
						if (227089 - 40854 != 186235)
						{
							continue;
						}
					}
					if (this.$mDrainlife_charge$20841)
					{
						if (298489 - 291202 == 7288)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mDrainlife_charge$20841);
						if (227188 - 341686 == -114497)
						{
							continue;
						}
					}
					this.YieldDefault(1);
				}
				while (110492 - 261697 == -151204);
				Block_11:
				goto IL_11CB;
				IL_426:
				goto IL_BF7;
				Block_32:
				goto IL_11CB;
				Block_39:
				goto IL_CD4;
				Block_53:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_54:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_71:
				goto IL_11CB;
				IL_BF7:
				return this.YieldDefault(5);
				IL_CD4:
				goto IL_BF7;
				goto IL_11CB;
				Block_109:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_11CB:
				return false;
			}

			// Token: 0x06001D75 RID: 7541 RVA: 0x00323AA8 File Offset: 0x00321CA8
			internal static bool OYacydD2hfD5NLxaABK()
			{
				return true;
			}

			// Token: 0x06001D76 RID: 7542 RVA: 0x00323AAC File Offset: 0x00321CAC
			internal static bool QYTsdRD81kRix35FiJl()
			{
				return false;
			}

			// Token: 0x04001B69 RID: 7017
			internal GameObject $tObject$20838;

			// Token: 0x04001B6A RID: 7018
			internal CharacterControl $tChar$20839;

			// Token: 0x04001B6B RID: 7019
			internal Vector3 $tPos$20840;

			// Token: 0x04001B6C RID: 7020
			internal GameObject $mDrainlife_charge$20841;

			// Token: 0x04001B6D RID: 7021
			internal EffectControl $mEffectControl$20842;

			// Token: 0x04001B6E RID: 7022
			internal GameObject $mDrainLife$20843;

			// Token: 0x04001B6F RID: 7023
			internal BoltEmitter $mDrainLife_BoltEmitter$20844;

			// Token: 0x04001B70 RID: 7024
			internal float $drainLifeTimer$20845;

			// Token: 0x04001B71 RID: 7025
			internal int $hpDrainLv$20846;

			// Token: 0x04001B72 RID: 7026
			internal int $drainHp$20847;

			// Token: 0x04001B73 RID: 7027
			internal int $dreamBurstLv$20848;

			// Token: 0x04001B74 RID: 7028
			internal float $dreamBurstTimer$20849;

			// Token: 0x04001B75 RID: 7029
			internal Vector3 $mPos$20850;

			// Token: 0x04001B76 RID: 7030
			internal Vector3 $tDir$20851;

			// Token: 0x04001B77 RID: 7031
			internal int $tID$20852;

			// Token: 0x04001B78 RID: 7032
			internal Bat_illusion $self_$20853;
		}
	}

	// Token: 0x02000504 RID: 1284
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack0$20858 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x00323AB0 File Offset: 0x00321CB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack0$20858(Vector3 mPos, Bat_illusion self_)
		{
			if (79101 - 151280 != -72178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212318 - 19912 == 192406)
				{
					base..ctor();
					if (191159 - 283252 != -92092)
					{
						this.$mPos$20861 = mPos;
						if (27148 - 186681 == -159533)
						{
							this.$self_$20862 = self_;
							if (285194 - 416929 == -131735)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00323B6C File Offset: 0x00321D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_cAttack0$20858.$(this.$mPos$20861, this.$self_$20862);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00323B80 File Offset: 0x00321D80
		internal static bool vRm8gPDZ7oX2CS72BaC()
		{
			return true;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00323B84 File Offset: 0x00321D84
		internal static bool CiSuQ0DCgSQqk5EjY2P()
		{
			return false;
		}

		// Token: 0x04001B79 RID: 7033
		internal Vector3 $mPos$20861;

		// Token: 0x04001B7A RID: 7034
		internal Bat_illusion $self_$20862;

		// Token: 0x02000505 RID: 1285
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D7B RID: 7547 RVA: 0x00323B88 File Offset: 0x00321D88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Bat_illusion self_)
			{
				if (263536 - 379610 != -116074)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226094 - 117255 != 108840)
					{
						base..ctor();
						if (72294 - 309469 != -237174)
						{
							this.$mPos$20859 = mPos;
							if (159544 - 144063 == 15481)
							{
								this.$self_$20860 = self_;
								if (61217 - 347740 == -286523)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D7C RID: 7548 RVA: 0x00323C44 File Offset: 0x00321E44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56906 - 461990 != -405083)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_323;
					case 2:
						if (this.$self_$20860.mChar.actionState == "attack")
						{
							if (294944 - 139417 != 155527)
							{
								continue;
							}
							if (this.$self_$20860.mChar.myCommand == "cAttack0")
							{
								if (130053 - 546811 == -416757)
								{
									continue;
								}
								this.$self_$20860.mChar.actionState = "standby";
								if (278636 - 205456 == 73181)
								{
									continue;
								}
								this.$self_$20860.mChar.actionTime = Time.time;
								if (97129 - 353416 != -256287)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (203975 - 554048 != -350073)
						{
							continue;
						}
						goto IL_323;
					default:
						if (77297 - 27506 == 49792)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20860.mChar.actionState != "standby")
					{
						if (198745 - 167947 == 30799)
						{
							continue;
						}
						if (this.$self_$20860.mChar.actionState != "run")
						{
							if (96671 - 147146 != -50475)
							{
								continue;
							}
							if (this.$self_$20860.mChar.actionState != "attack")
							{
								if (268311 - 164361 != 103951)
								{
									goto Block_21;
								}
								continue;
							}
						}
					}
					this.$self_$20860.mChar.actionState = "attack";
					if (204052 - 527596 != -323543)
					{
						this.$self_$20860.mChar.actionTime = Time.time;
						if (30984 - 177710 == -146726)
						{
							this.$self_$20860.mChar.myCommand = "cAttack0";
							if (41036 - 443930 != -402893)
							{
								this.$self_$20860.mChar.vMovement = Vector3.zero;
								if (187321 - 358106 != -170784)
								{
									this.$self_$20860.transform.position = this.$mPos$20859;
									if (142165 - 78879 != 63287)
									{
										this.$self_$20860.animation.CrossFade("root", 0.35f);
										if (38654 - 518423 == -479769)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.35f));
				Block_21:
				IL_323:
				return false;
			}

			// Token: 0x06001D7D RID: 7549 RVA: 0x00323F88 File Offset: 0x00322188
			internal static bool hVSXJsDLebPuT1gXgjI()
			{
				return true;
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x00323F8C File Offset: 0x0032218C
			internal static bool HDHWBaDONZ0mJdeG5q9()
			{
				return false;
			}

			// Token: 0x04001B7B RID: 7035
			internal Vector3 $mPos$20859;

			// Token: 0x04001B7C RID: 7036
			internal Bat_illusion $self_$20860;
		}
	}

	// Token: 0x02000506 RID: 1286
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cast1$20863 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x00323F90 File Offset: 0x00322190
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cast1$20863(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
		{
			if (267361 - 51370 != 215991)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165808 - 208879 != -43070)
				{
					base..ctor();
					if (116449 - 13552 != 102898)
					{
						this.$mPos$20872 = mPos;
						if (101441 - 454672 == -353231)
						{
							this.$tDir$20873 = tDir;
							if (191463 - 272069 == -80606)
							{
								this.$tID$20874 = tID;
								if (89232 - 528876 != -439643)
								{
									this.$self_$20875 = self_;
									if (158457 - 533259 != -374801)
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

		// Token: 0x06001D80 RID: 7552 RVA: 0x00324090 File Offset: 0x00322290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_cast1$20863.$(this.$mPos$20872, this.$tDir$20873, this.$tID$20874, this.$self_$20875);
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x003240B0 File Offset: 0x003222B0
		internal static bool qKRh4hDmirZFHN4mUTu()
		{
			return true;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x003240B4 File Offset: 0x003222B4
		internal static bool kpGp7LDFAl8w2Zxr1uw()
		{
			return false;
		}

		// Token: 0x04001B7D RID: 7037
		internal Vector3 $mPos$20872;

		// Token: 0x04001B7E RID: 7038
		internal Vector3 $tDir$20873;

		// Token: 0x04001B7F RID: 7039
		internal int $tID$20874;

		// Token: 0x04001B80 RID: 7040
		internal Bat_illusion $self_$20875;

		// Token: 0x02000507 RID: 1287
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D83 RID: 7555 RVA: 0x003240B8 File Offset: 0x003222B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Bat_illusion self_)
			{
				if (275212 - 370937 != -95725)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199685 - 322771 == -123086)
					{
						base..ctor();
						if (115583 - 582131 != -466547)
						{
							this.$mPos$20868 = mPos;
							if (221844 - 494818 == -272974)
							{
								this.$tDir$20869 = tDir;
								if (240582 - 9794 != 230789)
								{
									this.$tID$20870 = tID;
									if (239979 - 228298 != 11682)
									{
										this.$self_$20871 = self_;
										if (38374 - 409496 != -371121)
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

			// Token: 0x06001D84 RID: 7556 RVA: 0x003241B8 File Offset: 0x003223B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86212 - 20281 != 65931)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4AF;
					case 1:
						goto IL_B01;
					case 2:
						if (this.$self_$20871.mChar.actionState != "attack")
						{
							goto IL_A97;
						}
						if (297174 - 528130 != -230956)
						{
							continue;
						}
						if (this.$self_$20871.mChar.myCommand != "cast1")
						{
							if (81692 - 36722 != 44971)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$self_$20871.mChar.moveSpeed = (float)-1;
							if (78847 - 395231 == -316383)
							{
								continue;
							}
							if (this.$self_$20871.q4iGyJsMj3)
							{
								if (2405 - 13130 != -10725)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$20871.q4iGyJsMj3);
								if (110311 - 130404 != -20093)
								{
									continue;
								}
							}
							this.$self_$20871.q4iGyJsMj3 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$20871.castRing_illusion, this.$self_$20871.transform.position, Quaternion.Euler((float)270, (float)90, (float)0));
							if (21349 - 157785 != -136436)
							{
								continue;
							}
							this.$mcastRing_illusionControl$20867 = (EffectControl)this.$self_$20871.q4iGyJsMj3.GetComponent(typeof(EffectControl));
							if (63131 - 358368 == -295236)
							{
								continue;
							}
							this.$mcastRing_illusionControl$20867.InitEffectControl(this.$self_$20871.gameObject);
							if (140465 - 437683 != -297217)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$20871.mChar.actionState != "attack")
						{
							goto IL_8C5;
						}
						if (141150 - 534742 == -393591)
						{
							continue;
						}
						if (this.$self_$20871.mChar.myCommand != "cast1")
						{
							if (124117 - 314789 != -190672)
							{
								continue;
							}
							goto IL_8C5;
						}
						else
						{
							this.$self_$20871.mChar.moveSpeed = (float)0;
							if (139946 - 189093 != -49146)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$20871.mChar.actionState != "attack")
						{
							goto IL_613;
						}
						if (176564 - 443440 != -266876)
						{
							continue;
						}
						if (this.$self_$20871.mChar.myCommand != "cast1")
						{
							if (50108 - 537563 != -487455)
							{
								continue;
							}
							goto IL_613;
						}
						else
						{
							this.$self_$20871.animation.Play("cast2");
							if (83561 - 296042 != -212481)
							{
								continue;
							}
							this.$self_$20871.animation.wrapMode = WrapMode.Loop;
							if (270195 - 494368 == -224172)
							{
								continue;
							}
							this.$self_$20871.q4iGyJsMj3.animation.Play("root");
							if (83165 - 97773 != -14608)
							{
								continue;
							}
							this.$self_$20871.q4iGyJsMj3.animation.wrapMode = WrapMode.Loop;
							if (289690 - 33228 != 256462)
							{
								continue;
							}
						}
						break;
					case 5:
						break;
					default:
						if (240966 - 34746 != 206220)
						{
							continue;
						}
						goto IL_4AF;
					}
					if (this.$self_$20871.Q8EG9xe4rf.actionState == "attack")
					{
						if (19802 - 15439 == 4364)
						{
							continue;
						}
						if (!(this.$self_$20871.Q8EG9xe4rf.myCommand == "cast"))
						{
							if (211324 - 350817 == -139492)
							{
								continue;
							}
						}
						else
						{
							if (!this.$tObject$20864)
							{
								break;
							}
							if (220826 - 498446 != -277620)
							{
								continue;
							}
							if (!(this.$tObject$20864 != this.$self_$20871.gameObject))
							{
								break;
							}
							if (150878 - 449739 != -298861)
							{
								continue;
							}
							this.$tPos$20866 = global::Math.vFlat(this.$tObject$20864.transform.position) + Vector3.up * this.$self_$20871.transform.position.y;
							if (135009 - 28970 == 106040)
							{
								continue;
							}
							this.$self_$20871.transform.LookAt(this.$tPos$20866);
							if (56858 - 547441 != -490583)
							{
								continue;
							}
							break;
						}
					}
					if (this.$self_$20871.Q8EG9xe4rf.actionState != "attack")
					{
						if (62371 - 88301 == -25929)
						{
							continue;
						}
						this.$self_$20871.mChar.actionState = "standby";
						if (57422 - 481184 != -423762)
						{
							continue;
						}
						this.$self_$20871.mChar.actionTime = Time.time;
						if (50691 - 64334 != -13643)
						{
							continue;
						}
						this.$self_$20871.mChar.myCommand = "none";
						if (14673 - 97113 != -82440)
						{
							continue;
						}
						this.$self_$20871.mChar.nPosition = this.$self_$20871.transform.position;
						if (122303 - 183368 != -61065)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (232582 - 156271 != 76312)
					{
						goto Block_69;
					}
					continue;
					IL_4AF:
					if (this.$self_$20871.mChar.actionState != "standby")
					{
						if (40228 - 38873 == 1356)
						{
							continue;
						}
						if (this.$self_$20871.mChar.actionState != "run")
						{
							if (286156 - 280986 != 5170)
							{
								continue;
							}
							if (this.$self_$20871.mChar.actionState != "attack")
							{
								if (220426 - 130818 != 89608)
								{
									continue;
								}
								goto IL_5ED;
							}
						}
					}
					this.$tObject$20864 = null;
					if (198298 - 495043 != -296744)
					{
						this.$tChar$20865 = null;
						if (127825 - 271001 != -143175)
						{
							this.$tPos$20866 = default(Vector3);
							if (164840 - 297210 != -132369)
							{
								if (this.$tID$20870 != 0)
								{
									if (261838 - 70210 == 191629)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[this.$tID$20870];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$20864 = (GameObject)obj2;
									if (47604 - 323731 == -276126)
									{
										continue;
									}
								}
								if (this.$tObject$20864)
								{
									if (2156 - 494265 == -492108)
									{
										continue;
									}
									if (this.$tObject$20864 != this.$self_$20871.gameObject)
									{
										if (208336 - 20693 == 187644)
										{
											continue;
										}
										this.$tDir$20869 = global::Math.vFlat(this.$tObject$20864.transform.position - this.$self_$20871.transform.position).normalized;
										if (254813 - 201933 != 52880)
										{
											continue;
										}
										this.$tChar$20865 = (CharacterControl)this.$tObject$20864.GetComponent(typeof(CharacterControl));
										if (86810 - 47507 != 39303)
										{
											continue;
										}
									}
								}
								this.$self_$20871.mChar.actionState = "attack";
								if (113160 - 324465 != -211304)
								{
									this.$self_$20871.mChar.actionTime = Time.time;
									if (107651 - 436474 == -328823)
									{
										this.$self_$20871.mChar.myCommand = "cast1";
										if (179976 - 87458 == 92518)
										{
											this.$self_$20871.transform.position = this.$mPos$20868;
											if (72475 - 4482 != 67994)
											{
												this.$self_$20871.transform.LookAt(this.$mPos$20868 + global::Math.vFlat(this.$tDir$20869));
												if (110162 - 378510 == -268348)
												{
													this.$self_$20871.animation.CrossFade("cast1");
													if (291463 - 405036 == -113573)
													{
														this.$self_$20871.animation.wrapMode = WrapMode.Once;
														if (29239 - 209707 == -180468)
														{
															this.$self_$20871.mChar.vMovement = this.$self_$20871.transform.forward;
															if (190400 - 79503 != 110898)
															{
																this.$self_$20871.mChar.moveSpeed = (float)0;
																if (173079 - 591522 == -418443)
																{
																	goto IL_876;
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
				return this.YieldDefault(5);
				Block_16:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_5ED:
				IL_613:
				goto IL_B01;
				IL_876:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_8C5:
				goto IL_B01;
				Block_57:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_59:
				Block_69:
				IL_A97:
				IL_B01:
				return false;
			}

			// Token: 0x06001D85 RID: 7557 RVA: 0x00324CD8 File Offset: 0x00322ED8
			internal static bool TmMH7vDMNfGBrKoN3OR()
			{
				return true;
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x00324CDC File Offset: 0x00322EDC
			internal static bool yCX2fLDx9jNJqpgRJrU()
			{
				return false;
			}

			// Token: 0x04001B81 RID: 7041
			internal GameObject $tObject$20864;

			// Token: 0x04001B82 RID: 7042
			internal CharacterControl $tChar$20865;

			// Token: 0x04001B83 RID: 7043
			internal Vector3 $tPos$20866;

			// Token: 0x04001B84 RID: 7044
			internal EffectControl $mcastRing_illusionControl$20867;

			// Token: 0x04001B85 RID: 7045
			internal Vector3 $mPos$20868;

			// Token: 0x04001B86 RID: 7046
			internal Vector3 $tDir$20869;

			// Token: 0x04001B87 RID: 7047
			internal int $tID$20870;

			// Token: 0x04001B88 RID: 7048
			internal Bat_illusion $self_$20871;
		}
	}

	// Token: 0x02000508 RID: 1288
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cast2$20876 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x00324CE0 File Offset: 0x00322EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cast2$20876(Vector3 mPos, Vector3 tDir, Bat_illusion self_)
		{
			if (153689 - 11919 != 141770)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109369 - 559106 != -449736)
				{
					base..ctor();
					if (30155 - 538664 != -508508)
					{
						this.$mPos$20880 = mPos;
						if (28123 - 492652 != -464528)
						{
							this.$tDir$20881 = tDir;
							if (39237 - 473573 == -434336)
							{
								this.$self_$20882 = self_;
								if (278932 - 47310 == 231622)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00324DBC File Offset: 0x00322FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_cast2$20876.$(this.$mPos$20880, this.$tDir$20881, this.$self_$20882);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00324DD8 File Offset: 0x00322FD8
		internal static bool mdasFrDgfF0AW2Od8iK()
		{
			return true;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00324DDC File Offset: 0x00322FDC
		internal static bool nFLGf4DfwppMLVjRTMn()
		{
			return false;
		}

		// Token: 0x04001B89 RID: 7049
		internal Vector3 $mPos$20880;

		// Token: 0x04001B8A RID: 7050
		internal Vector3 $tDir$20881;

		// Token: 0x04001B8B RID: 7051
		internal Bat_illusion $self_$20882;

		// Token: 0x02000509 RID: 1289
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D8B RID: 7563 RVA: 0x00324DE0 File Offset: 0x00322FE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Bat_illusion self_)
			{
				if (137153 - 295455 != -158301)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100384 - 257530 != -157145)
					{
						base..ctor();
						if (86995 - 199093 != -112097)
						{
							this.$mPos$20877 = mPos;
							if (2385 - 401805 != -399419)
							{
								this.$tDir$20878 = tDir;
								if (1739 - 176616 != -174876)
								{
									this.$self_$20879 = self_;
									if (36584 - 452678 == -416094)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D8C RID: 7564 RVA: 0x00324EBC File Offset: 0x003230BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (197499 - 282437 != -84937)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5E8;
					case 2:
						if (this.$self_$20879.mChar.actionState != "attack")
						{
							goto IL_450;
						}
						if (29282 - 587822 == -558539)
						{
							continue;
						}
						if (!(this.$self_$20879.mChar.myCommand != "cast2"))
						{
							goto IL_455;
						}
						if (33107 - 533982 != -500875)
						{
							continue;
						}
						goto IL_450;
					case 3:
						if (this.$self_$20879.mChar.actionState != "attack")
						{
							goto IL_315;
						}
						if (165597 - 344375 == -178777)
						{
							continue;
						}
						if (this.$self_$20879.mChar.myCommand != "cast2")
						{
							if (105329 - 406850 != -301521)
							{
								continue;
							}
							goto IL_315;
						}
						else
						{
							this.$self_$20879.mChar.moveSpeed = (float)0;
							if (140090 - 81989 != 58102)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$20879.mChar.actionState != "attack")
						{
							goto IL_4DD;
						}
						if (282919 - 521791 == -238871)
						{
							continue;
						}
						if (this.$self_$20879.mChar.myCommand != "cast2")
						{
							if (258120 - 175763 != 82358)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$20879.mChar.actionState = "standby";
							if (47564 - 557846 != -510282)
							{
								continue;
							}
							this.$self_$20879.mChar.actionTime = Time.time;
							if (209738 - 108691 == 101048)
							{
								continue;
							}
							this.$self_$20879.mChar.myCommand = "none";
							if (143090 - 56267 != 86823)
							{
								continue;
							}
							this.$self_$20879.mChar.nPosition = this.$self_$20879.transform.position;
							if (13100 - 384953 != -371853)
							{
								continue;
							}
							this.YieldDefault(1);
							if (163423 - 562000 != -398577)
							{
								continue;
							}
							goto IL_5E8;
						}
						break;
					default:
						if (107517 - 417070 != -309553)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20879.mChar.actionState != "standby")
					{
						if (48364 - 335330 != -286966)
						{
							continue;
						}
						if (this.$self_$20879.mChar.actionState != "run")
						{
							if (65665 - 137407 != -71742)
							{
								continue;
							}
							if (this.$self_$20879.mChar.actionState != "attack")
							{
								if (246819 - 403664 != -156844)
								{
									goto Block_27;
								}
								continue;
							}
						}
					}
					this.$self_$20879.mChar.actionState = "attack";
					if (289067 - 491963 == -202896)
					{
						this.$self_$20879.mChar.actionTime = Time.time;
						if (164190 - 92837 == 71353)
						{
							this.$self_$20879.mChar.myCommand = "cast2";
							if (99824 - 131616 == -31792)
							{
								this.$self_$20879.animation.CrossFade("cast3");
								if (12938 - 92417 == -79479)
								{
									this.$self_$20879.animation.wrapMode = WrapMode.Once;
									if (105923 - 12044 != 93880)
									{
										this.$self_$20879.transform.position = this.$mPos$20877;
										if (147200 - 144222 != 2979)
										{
											this.$self_$20879.transform.LookAt(this.$mPos$20877 + global::Math.vFlat(this.$tDir$20878));
											if (24920 - 324946 != -300025)
											{
												this.$self_$20879.mChar.vMovement = this.$self_$20879.transform.forward;
												if (148804 - 175413 == -26609)
												{
													this.$self_$20879.mChar.moveSpeed = -0.5f;
													if (259590 - 273561 == -13971)
													{
														UnityEngine.Object.Instantiate(this.$self_$20879.castEffect_illusion, this.$self_$20879.transform.position + this.$self_$20879.transform.TransformDirection((float)0, 1.3f, (float)1), this.$self_$20879.transform.rotation);
														if (115649 - 369011 == -253362)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_19:
				IL_315:
				goto IL_5E8;
				Block_21:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_27:
				IL_450:
				goto IL_5E8;
				IL_455:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_4DD:
				IL_5E8:
				return false;
			}

			// Token: 0x06001D8D RID: 7565 RVA: 0x003254C4 File Offset: 0x003236C4
			internal static bool R85ZCEDnNvdoEqqIep5()
			{
				return true;
			}

			// Token: 0x06001D8E RID: 7566 RVA: 0x003254C8 File Offset: 0x003236C8
			internal static bool I0RwuuD6WMPLadqWOlr()
			{
				return false;
			}

			// Token: 0x04001B8C RID: 7052
			internal Vector3 $mPos$20877;

			// Token: 0x04001B8D RID: 7053
			internal Vector3 $tDir$20878;

			// Token: 0x04001B8E RID: 7054
			internal Bat_illusion $self_$20879;
		}
	}

	// Token: 0x0200050A RID: 1290
	[CompilerGenerated]
	[Serializable]
	internal sealed class $channel$20883 : GenericGenerator<object>
	{
		// Token: 0x06001D8F RID: 7567 RVA: 0x003254CC File Offset: 0x003236CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $channel$20883(GameObject tObject, Bat_illusion self_)
		{
			if (62802 - 591235 != -528433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (245360 - 223580 != 21781)
				{
					base..ctor();
					if (41813 - 28789 == 13024)
					{
						this.$tObject$20886 = tObject;
						if (288407 - 393424 != -105016)
						{
							this.$self_$20887 = self_;
							if (138815 - 218187 == -79372)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00325588 File Offset: 0x00323788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new Bat_illusion.$channel$20883.$(this.$tObject$20886, this.$self_$20887);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0032559C File Offset: 0x0032379C
		internal static bool KlpYqQDi2wecsiVSnUb()
		{
			return true;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x003255A0 File Offset: 0x003237A0
		internal static bool jllWlODKGGqS6VNmCWF()
		{
			return false;
		}

		// Token: 0x04001B8F RID: 7055
		internal GameObject $tObject$20886;

		// Token: 0x04001B90 RID: 7056
		internal Bat_illusion $self_$20887;

		// Token: 0x0200050B RID: 1291
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06001D93 RID: 7571 RVA: 0x003255A4 File Offset: 0x003237A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject tObject, Bat_illusion self_)
			{
				if (227956 - 346443 != -118487)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213205 - 207746 == 5459)
					{
						base..ctor();
						if (250991 - 72907 != 178085)
						{
							this.$tObject$20884 = tObject;
							if (271532 - 224793 != 46740)
							{
								this.$self_$20885 = self_;
								if (6960 - 174910 == -167950)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001D94 RID: 7572 RVA: 0x00325660 File Offset: 0x00323860
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169459 - 363068 != -193609)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_BB;
					case 1:
						goto IL_46B;
					case 2:
						break;
					default:
						if (174676 - 519488 != -344811)
						{
							goto IL_BB;
						}
						continue;
					}
					IL_100:
					if (this.$self_$20885.mChar.actionState == "attack")
					{
						if (202307 - 430926 != -228619)
						{
							continue;
						}
						if (!(this.$self_$20885.mChar.myCommand == "channel"))
						{
							if (274679 - 196738 != 77941)
							{
								continue;
							}
						}
						else
						{
							if (!this.$tObject$20884)
							{
								goto IL_F4;
							}
							if (205052 - 335758 != -130706)
							{
								continue;
							}
							this.$self_$20885.transform.LookAt(global::Math.vFlat(this.$tObject$20884.transform.position) + Vector3.up * this.$self_$20885.transform.position.y);
							if (17736 - 269312 != -251575)
							{
								goto Block_24;
							}
							continue;
						}
					}
					this.YieldDefault(1);
					if (99892 - 365572 != -265679)
					{
						break;
					}
					continue;
					IL_BB:
					if (this.$self_$20885.mChar.actionState != "standby")
					{
						if (8546 - 535601 == -527054)
						{
							continue;
						}
						if (this.$self_$20885.mChar.actionState != "run")
						{
							if (39652 - 296101 == -256448)
							{
								continue;
							}
							if (this.$self_$20885.mChar.actionState != "attack")
							{
								if (199781 - 133667 != 66114)
								{
									continue;
								}
								break;
							}
						}
					}
					if (!this.$tObject$20884)
					{
						if (133199 - 28537 == 104662)
						{
							break;
						}
					}
					else
					{
						this.$self_$20885.mChar.actionState = "attack";
						if (290307 - 469372 != -179064)
						{
							this.$self_$20885.mChar.actionTime = Time.time;
							if (158846 - 387544 == -228698)
							{
								this.$self_$20885.mChar.myCommand = "channel";
								if (28821 - 588431 != -559609)
								{
									this.$self_$20885.animation.CrossFade("channel");
									if (191824 - 288314 == -96490)
									{
										this.$self_$20885.animation.wrapMode = WrapMode.Loop;
										if (98459 - 268260 != -169800)
										{
											this.$self_$20885.transform.LookAt(global::Math.vFlat(this.$tObject$20884.transform.position) + Vector3.up * this.$self_$20885.transform.position.y);
											if (269954 - 351473 != -81518)
											{
												this.$self_$20885.mChar.vMovement = this.$self_$20885.transform.forward;
												if (282685 - 572341 != -289655)
												{
													this.$self_$20885.mChar.moveSpeed = (float)0;
													if (165285 - 413698 == -248413)
													{
														if (this.$self_$20885.mChar.isMine)
														{
															if (115130 - 426959 != -311829)
															{
																continue;
															}
															this.$self_$20885.mChar.PositionEvent();
															if (211755 - 81889 == 129867)
															{
																continue;
															}
														}
														goto IL_100;
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
				goto IL_46B;
				IL_F4:
				return this.YieldDefault(2);
				goto IL_46B;
				Block_24:
				goto IL_F4;
				IL_46B:
				return false;
			}

			// Token: 0x06001D95 RID: 7573 RVA: 0x00325AEC File Offset: 0x00323CEC
			internal static bool M3bo7vDdQ2Yhoj4VEhb()
			{
				return true;
			}

			// Token: 0x06001D96 RID: 7574 RVA: 0x00325AF0 File Offset: 0x00323CF0
			internal static bool QY2wXiDJDbeqBTAsal3()
			{
				return false;
			}

			// Token: 0x04001B91 RID: 7057
			internal GameObject $tObject$20884;

			// Token: 0x04001B92 RID: 7058
			internal Bat_illusion $self_$20885;
		}
	}

	// Token: 0x0200050C RID: 1292
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_emotion$20888 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D97 RID: 7575 RVA: 0x00325AF4 File Offset: 0x00323CF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_emotion$20888(string eType, Vector3 mPos, Vector3 tDir, Bat_illusion self_)
		{
			if (179770 - 222542 != -42772)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151270 - 87529 == 63741)
				{
					base..ctor();
					if (278141 - 465652 == -187511)
					{
						this.$eType$20895 = eType;
						if (143476 - 221137 != -77660)
						{
							this.$mPos$20896 = mPos;
							if (99366 - 210245 == -110879)
							{
								this.$tDir$20897 = tDir;
								if (42901 - 90580 == -47679)
								{
									this.$self_$20898 = self_;
									if (1009 - 590082 == -589073)
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

		// Token: 0x06001D98 RID: 7576 RVA: 0x00325BF4 File Offset: 0x00323DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_emotion$20888.$(this.$eType$20895, this.$mPos$20896, this.$tDir$20897, this.$self_$20898);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00325C14 File Offset: 0x00323E14
		internal static bool uJHGs9DDaDgXhFmKqEU()
		{
			return true;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00325C18 File Offset: 0x00323E18
		internal static bool wdB2CrDvuEIGnfT1Ogs()
		{
			return false;
		}

		// Token: 0x04001B93 RID: 7059
		internal string $eType$20895;

		// Token: 0x04001B94 RID: 7060
		internal Vector3 $mPos$20896;

		// Token: 0x04001B95 RID: 7061
		internal Vector3 $tDir$20897;

		// Token: 0x04001B96 RID: 7062
		internal Bat_illusion $self_$20898;

		// Token: 0x0200050D RID: 1293
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001D9B RID: 7579 RVA: 0x00325C1C File Offset: 0x00323E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(string eType, Vector3 mPos, Vector3 tDir, Bat_illusion self_)
			{
				if (39370 - 15355 != 24016)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4806 - 527199 != -522392)
					{
						base..ctor();
						if (49242 - 525243 == -476001)
						{
							this.$eType$20891 = eType;
							if (203992 - 407486 == -203494)
							{
								this.$mPos$20892 = mPos;
								if (170250 - 397739 == -227489)
								{
									this.$tDir$20893 = tDir;
									if (156599 - 95098 == 61501)
									{
										this.$self_$20894 = self_;
										if (40568 - 401770 != -361201)
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

			// Token: 0x06001D9C RID: 7580 RVA: 0x00325D1C File Offset: 0x00323F1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150311 - 398924 != -248613)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B8C;
					case 2:
						goto IL_91F;
					case 3:
						goto IL_91F;
					case 4:
						if (this.$self_$20894.mChar.actionState != "emotion")
						{
							goto IL_63B;
						}
						if (292276 - 272657 == 19620)
						{
							continue;
						}
						if (this.$self_$20894.mChar.myCommand != this.$eType$20891)
						{
							if (254495 - 239666 != 14829)
							{
								continue;
							}
							goto IL_63B;
						}
						else
						{
							this.$self_$20894.mChar.actionState = "standby";
							if (83500 - 459921 != -376421)
							{
								continue;
							}
							this.$self_$20894.mChar.actionTime = Time.time;
							if (174555 - 498764 != -324209)
							{
								continue;
							}
							this.$self_$20894.mChar.myCommand = "none";
							if (2324 - 129134 != -126810)
							{
								continue;
							}
							this.$self_$20894.mChar.nPosition = this.$self_$20894.transform.position;
							if (54164 - 562562 != -508398)
							{
								continue;
							}
							this.YieldDefault(1);
							if (298547 - 49379 != 249169)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					default:
						if (233088 - 207882 == 25207)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20894.mChar.actionState != "standby")
					{
						if (54616 - 523343 == -468726)
						{
							continue;
						}
						if (this.$self_$20894.mChar.actionState != "run")
						{
							if (33078 - 551246 == -518167)
							{
								continue;
							}
							if (this.$self_$20894.mChar.actionState != "attack")
							{
								if (140688 - 423447 != -282758)
								{
									break;
								}
								continue;
							}
						}
					}
					this.$self_$20894.transform.position = this.$mPos$20892;
					if (142628 - 260402 != -117774)
					{
						continue;
					}
					this.$self_$20894.transform.LookAt(this.$mPos$20892 + global::Math.vFlat(this.$tDir$20893));
					if (263613 - 122296 != 141317)
					{
						continue;
					}
					this.$self_$20894.mChar.actionState = "emotion";
					if (262647 - 363797 != -101150)
					{
						continue;
					}
					this.$self_$20894.mChar.actionTime = Time.time;
					if (242990 - 104728 != 138262)
					{
						continue;
					}
					this.$self_$20894.mChar.myCommand = this.$eType$20891;
					if (859 - 73810 == -72950)
					{
						continue;
					}
					this.$self_$20894.mChar.addTimeOut(this.$eType$20891, 0.3f);
					if (264445 - 141277 == 123169)
					{
						continue;
					}
					this.$self_$20894.mChar.vMovement = this.$self_$20894.transform.forward;
					if (208415 - 52829 != 155586)
					{
						continue;
					}
					this.$self_$20894.mChar.moveSpeed = (float)0;
					if (204738 - 503619 == -298880)
					{
						continue;
					}
					this.$$switch$1519$20889 = this.$eType$20891;
					if (251377 - 504945 != -253568)
					{
						continue;
					}
					if (this.$$switch$1519$20889 == "emo_hi")
					{
						if (89654 - 320827 != -231172)
						{
							goto IL_190;
						}
						continue;
					}
					else if (this.$$switch$1519$20889 == "emo_wave")
					{
						if (70645 - 287594 != -216949)
						{
							continue;
						}
						goto IL_190;
					}
					else
					{
						if (this.$$switch$1519$20889 == "emo_ty")
						{
							if (88910 - 529837 != -440927)
							{
								continue;
							}
						}
						else if (this.$$switch$1519$20889 == "emo_bow")
						{
							if (148396 - 455905 == -307508)
							{
								continue;
							}
						}
						else if (this.$$switch$1519$20889 == "emo_laugh")
						{
							if (178253 - 390490 != -212237)
							{
								continue;
							}
							this.$self_$20894.animation.CrossFade("laugh", 0.2f);
							if (81612 - 142608 != -60996)
							{
								continue;
							}
							goto IL_53;
						}
						else
						{
							this.$$switch$1516$20890 = this.$eType$20891;
							if (20578 - 266405 == -245826)
							{
								continue;
							}
							if (this.$$switch$1516$20890 == "emo_sit")
							{
								if (169040 - 588417 != -419377)
								{
									continue;
								}
								this.$self_$20894.animation.CrossFade("sit", 0.2f);
								if (273524 - 310255 != -36731)
								{
									continue;
								}
							}
							else if (this.$$switch$1516$20890 == "emo_sleep")
							{
								if (243841 - 289109 == -45267)
								{
									continue;
								}
								this.$self_$20894.animation.CrossFade("sleep", 0.2f);
								if (252830 - 391252 != -138422)
								{
									continue;
								}
							}
							else if (this.$$switch$1516$20890 == "emo_cheer")
							{
								if (293991 - 490459 == -196467)
								{
									continue;
								}
								this.$self_$20894.animation.CrossFade("cheer", 0.2f);
								if (240211 - 481830 == -241618)
								{
									continue;
								}
							}
							else if (this.$$switch$1516$20890 == "emo_beg")
							{
								if (276355 - 595695 == -319339)
								{
									continue;
								}
								this.$self_$20894.animation.CrossFade("beg", 0.2f);
								if (236131 - 425853 != -189722)
								{
									continue;
								}
							}
							else if (this.$$switch$1516$20890 == "emo_cry")
							{
								if (165937 - 435410 == -269472)
								{
									continue;
								}
								this.$self_$20894.animation.CrossFade("cry", 0.2f);
								if (257635 - 364260 != -106625)
								{
									continue;
								}
							}
							else
							{
								if (this.$$switch$1516$20890 == "emo_talk")
								{
									if (281728 - 526784 == -245055)
									{
										continue;
									}
								}
								else if (this.$$switch$1516$20890 == "emo_chat")
								{
									if (142147 - 476618 == -334470)
									{
										continue;
									}
								}
								else if (this.$$switch$1516$20890 == "emo_pose")
								{
									if (89440 - 373832 == -284391)
									{
										continue;
									}
									this.$self_$20894.animation.CrossFade("pose", 0.2f);
									if (85810 - 340681 != -254871)
									{
										continue;
									}
									goto IL_1FD;
								}
								else
								{
									if (!(this.$$switch$1516$20890 == "emo_dance"))
									{
										goto IL_1FD;
									}
									if (223623 - 139128 == 84496)
									{
										continue;
									}
									this.$self_$20894.animation.CrossFade("dance", 0.2f);
									if (283675 - 505512 != -221836)
									{
										goto IL_1FD;
									}
									continue;
								}
								this.$self_$20894.animation.CrossFade("talk", 0.2f);
								if (142627 - 237610 == -94982)
								{
									continue;
								}
							}
							IL_1FD:
							this.$self_$20894.animation.wrapMode = WrapMode.Loop;
							if (34112 - 227474 == -193361)
							{
								continue;
							}
							if (this.$self_$20894.mChar.isMine)
							{
								goto IL_9F9;
							}
							if (68551 - 582968 != -514417)
							{
								continue;
							}
							break;
						}
						this.$self_$20894.animation.CrossFade("bow", 0.2f);
						if (32101 - 244426 != -212325)
						{
							continue;
						}
					}
					IL_53:
					this.$self_$20894.animation.wrapMode = WrapMode.Once;
					if (202900 - 359324 != -156424)
					{
						continue;
					}
					goto IL_B09;
					IL_190:
					this.$self_$20894.animation.CrossFade("wave", 0.2f);
					if (24717 - 260661 != -235944)
					{
						continue;
					}
					goto IL_53;
					IL_91F:
					if (!(this.$self_$20894.mChar.actionState == "emotion"))
					{
						break;
					}
					if (38326 - 417343 != -379016)
					{
						if (!(this.$self_$20894.mChar.myCommand == this.$eType$20891))
						{
							if (118259 - 540042 != -421782)
							{
								break;
							}
						}
						else
						{
							if (Chat.ChatActive)
							{
								goto IL_913;
							}
							if (256736 - 57011 == 199725)
							{
								if (Input.GetAxisRaw("Vertical") + Input.GetAxisRaw("Horizontal") == (float)0)
								{
									goto IL_913;
								}
								if (95790 - 103901 != -8110)
								{
									this.$self_$20894.RPC_emotion0(this.$self_$20894.transform.position, this.$self_$20894.transform.forward, 0);
									if (212514 - 27561 == 184953)
									{
										this.$self_$20894.ActionEvent("RPC_emotion0", this.$self_$20894.transform.position, this.$self_$20894.transform.forward, 0);
										if (11952 - 288816 == -276864)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_4E:
				IL_63B:
				Block_58:
				goto IL_B8C;
				IL_913:
				return this.YieldDefault(3);
				goto IL_B8C;
				IL_9F9:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_4E;
				IL_B09:
				return this.Yield(4, new WaitForSeconds(1.2f));
				IL_B8C:
				return false;
			}

			// Token: 0x06001D9D RID: 7581 RVA: 0x003268C8 File Offset: 0x00324AC8
			internal static bool OshGmEDRqaUgJ4WsBvf()
			{
				return true;
			}

			// Token: 0x06001D9E RID: 7582 RVA: 0x003268CC File Offset: 0x00324ACC
			internal static bool wQWgPwDw1IhAYDSWyk2()
			{
				return false;
			}

			// Token: 0x04001B97 RID: 7063
			internal string $$switch$1519$20889;

			// Token: 0x04001B98 RID: 7064
			internal string $$switch$1516$20890;

			// Token: 0x04001B99 RID: 7065
			internal string $eType$20891;

			// Token: 0x04001B9A RID: 7066
			internal Vector3 $mPos$20892;

			// Token: 0x04001B9B RID: 7067
			internal Vector3 $tDir$20893;

			// Token: 0x04001B9C RID: 7068
			internal Bat_illusion $self_$20894;
		}
	}

	// Token: 0x0200050E RID: 1294
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$20899 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x003268D0 File Offset: 0x00324AD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$20899(UnityScript.Lang.Array nArray, Bat_illusion self_)
		{
			if (221277 - 306047 != -84769)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (99123 - 299948 != -200824)
				{
					base..ctor();
					if (182831 - 242164 != -59332)
					{
						this.$nArray$20904 = nArray;
						if (104951 - 536416 == -431465)
						{
							this.$self_$20905 = self_;
							if (100975 - 284168 != -183192)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0032698C File Offset: 0x00324B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_ko$20899.$(this.$nArray$20904, this.$self_$20905);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x003269A0 File Offset: 0x00324BA0
		internal static bool eCTyt8DqUq004iYhYP6()
		{
			return true;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x003269A4 File Offset: 0x00324BA4
		internal static bool lqvFpuD7JZIpfqeLFOo()
		{
			return false;
		}

		// Token: 0x04001B9D RID: 7069
		internal UnityScript.Lang.Array $nArray$20904;

		// Token: 0x04001B9E RID: 7070
		internal Bat_illusion $self_$20905;

		// Token: 0x0200050F RID: 1295
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001DA3 RID: 7587 RVA: 0x003269A8 File Offset: 0x00324BA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Bat_illusion self_)
			{
				if (78453 - 410627 != -332173)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60627 - 531683 != -471055)
					{
						base..ctor();
						if (121917 - 437775 == -315858)
						{
							this.$nArray$20902 = nArray;
							if (128013 - 179756 == -51743)
							{
								this.$self_$20903 = self_;
								if (33135 - 352901 == -319766)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x00326A64 File Offset: 0x00324C64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159832 - 233480 != -73647)
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
						if (this.$self_$20903.mChar.actionState != "ko")
						{
							if (219690 - 423959 != -204268)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$20903.animation.Play("getUp");
							if (248896 - 412358 != -163462)
							{
								continue;
							}
							this.$self_$20903.animation.wrapMode = WrapMode.Once;
							if (157133 - 266522 != -109388)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$20903.mChar.actionState != "ko")
						{
							if (159603 - 441829 != -282225)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$20903.mChar.actionState = "standby";
							if (88313 - 193355 == -105041)
							{
								continue;
							}
							this.$self_$20903.mChar.actionTime = Time.time;
							if (179449 - 113826 != 65623)
							{
								continue;
							}
							this.$self_$20903.mChar.myCommand = "none";
							if (104008 - 475453 != -371445)
							{
								continue;
							}
							this.$self_$20903.mChar.ko = this.$self_$20903.mChar.mko;
							if (46758 - 278907 == -232148)
							{
								continue;
							}
							this.YieldDefault(1);
							if (80742 - 205566 != -124823)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (217958 - 111306 != 106652)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20903.mChar.actionState == "ko")
					{
						break;
					}
					if (82741 - 46669 == 36072)
					{
						if (this.$self_$20903.mChar.actionState == "dead")
						{
							if (53686 - 414259 == -360573)
							{
								break;
							}
						}
						else
						{
							this.$mPos$20900 = (Vector3)this.$nArray$20902[0];
							if (292657 - 200909 == 91748)
							{
								this.$mDir$20901 = (Vector3)this.$nArray$20902[1];
								if (107366 - 157755 == -50389)
								{
									this.$self_$20903.mChar.ko = 0;
									if (81831 - 551987 == -470156)
									{
										this.$self_$20903.mChar.actionState = "ko";
										if (256630 - 145170 == 111460)
										{
											this.$self_$20903.mChar.actionTime = Time.time;
											if (298288 - 474750 == -176462)
											{
												this.$self_$20903.mChar.myCommand = "none";
												if (66934 - 355567 != -288632)
												{
													this.$self_$20903.mChar.vMovement = Vector3.zero;
													if (241401 - 10425 != 230977)
													{
														this.$self_$20903.mChar.moveSpeed = (float)0;
														if (298131 - 462794 != -164662)
														{
															this.$self_$20903.animation.Play("ko");
															if (157772 - 161241 != -3468)
															{
																this.$self_$20903.animation.wrapMode = WrapMode.Once;
																if (163992 - 66822 != 97171)
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
					}
				}
				Block_4:
				Block_12:
				Block_14:
				goto IL_48C;
				Block_21:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_27:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06001DA5 RID: 7589 RVA: 0x00326F10 File Offset: 0x00325110
			internal static bool oABr5ODPLg44Ug6L7fV()
			{
				return true;
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x00326F14 File Offset: 0x00325114
			internal static bool fqOo09D051eikxI7S7l()
			{
				return false;
			}

			// Token: 0x04001B9F RID: 7071
			internal Vector3 $mPos$20900;

			// Token: 0x04001BA0 RID: 7072
			internal Vector3 $mDir$20901;

			// Token: 0x04001BA1 RID: 7073
			internal UnityScript.Lang.Array $nArray$20902;

			// Token: 0x04001BA2 RID: 7074
			internal Bat_illusion $self_$20903;
		}
	}

	// Token: 0x02000510 RID: 1296
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$20906 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001DA7 RID: 7591 RVA: 0x00326F18 File Offset: 0x00325118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$20906(UnityScript.Lang.Array nArray, Bat_illusion self_)
		{
			if (112713 - 366047 != -253334)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2324 - 47009 == -44685)
				{
					base..ctor();
					if (292611 - 91846 == 200765)
					{
						this.$nArray$20911 = nArray;
						if (71925 - 173617 != -101691)
						{
							this.$self_$20912 = self_;
							if (45338 - 60047 == -14709)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00326FD4 File Offset: 0x003251D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Bat_illusion.$RPC_dead$20906.$(this.$nArray$20911, this.$self_$20912);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00326FE8 File Offset: 0x003251E8
		internal static bool gCHqtEDbZ3aTNeKZ1u1()
		{
			return true;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00326FEC File Offset: 0x003251EC
		internal static bool deYRtKDuwi985CiSeew()
		{
			return false;
		}

		// Token: 0x04001BA3 RID: 7075
		internal UnityScript.Lang.Array $nArray$20911;

		// Token: 0x04001BA4 RID: 7076
		internal Bat_illusion $self_$20912;

		// Token: 0x02000511 RID: 1297
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001DAB RID: 7595 RVA: 0x00326FF0 File Offset: 0x003251F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Bat_illusion self_)
			{
				if (157288 - 204115 != -46826)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76608 - 16853 != 59756)
					{
						base..ctor();
						if (56351 - 323450 == -267099)
						{
							this.$nArray$20909 = nArray;
							if (221565 - 143511 != 78055)
							{
								this.$self_$20910 = self_;
								if (7100 - 129678 == -122578)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001DAC RID: 7596 RVA: 0x003270AC File Offset: 0x003252AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47219 - 527790 != -480571)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_49D;
					case 2:
						if (!this.$self_$20910.mChar.isPlayer)
						{
							goto IL_9F;
						}
						if (236139 - 162797 == 73343)
						{
							continue;
						}
						if (!this.$self_$20910.mChar.isMine)
						{
							goto IL_9F;
						}
						if (139476 - 420187 == -280710)
						{
							continue;
						}
						Camera.main.SendMessage("onDeadPlayer", this.$self_$20910.gameObject);
						if (130327 - 117163 == 13165)
						{
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (174826 - 426809 != -251982)
						{
							goto Block_2;
						}
						continue;
						IL_9F:
						if (this.$self_$20910.illusion_dust)
						{
							if (295774 - 75998 != 219776)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$20910.illusion_dust, this.$self_$20910.transform.position + 0.2f * Vector3.up, Quaternion.identity);
							if (55587 - 575540 != -519953)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find illusion_dust effect");
							if (182921 - 475763 != -292842)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.$self_$20910.gameObject);
						if (33581 - 146018 != -112437)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (21380 - 227500 != -206120)
						{
							continue;
						}
						break;
					}
					if (this.$self_$20910.mChar.actionState == "dead")
					{
						if (161431 - 259658 != -98226)
						{
							break;
						}
					}
					else
					{
						this.$mPos$20907 = (Vector3)this.$nArray$20909[0];
						if (219876 - 137336 == 82540)
						{
							this.$myDirection$20908 = (Vector3)this.$nArray$20909[1];
							if (235729 - 275801 != -40071)
							{
								this.$self_$20910.transform.position = this.$mPos$20907;
								if (259348 - 102556 == 156792)
								{
									this.$self_$20910.transform.LookAt(this.$mPos$20907 + this.$myDirection$20908);
									if (146253 - 512808 != -366554)
									{
										this.$self_$20910.mChar.hp = 0;
										if (220745 - 401472 == -180727)
										{
											this.$self_$20910.mChar.actionState = "dead";
											if (240194 - 311580 != -71385)
											{
												this.$self_$20910.mChar.actionTime = Time.time;
												if (196690 - 494147 != -297456)
												{
													this.$self_$20910.mChar.myCommand = "none";
													if (111483 - 161760 == -50277)
													{
														this.$self_$20910.mChar.vMovement = Vector3.zero;
														if (167842 - 524501 != -356658)
														{
															this.$self_$20910.mChar.moveSpeed = (float)0;
															if (87663 - 21125 == 66538)
															{
																this.$self_$20910.animation.Rewind();
																if (47859 - 38990 == 8869)
																{
																	this.$self_$20910.animation.Play("ko");
																	if (212660 - 87592 != 125069)
																	{
																		this.$self_$20910.animation.wrapMode = WrapMode.Once;
																		if (205537 - 507926 != -302388)
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
							}
						}
					}
				}
				Block_2:
				goto IL_49D;
				Block_7:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_49D:
				return false;
			}

			// Token: 0x06001DAD RID: 7597 RVA: 0x00327568 File Offset: 0x00325768
			internal static bool C4omuODI2hGZRTS4tgB()
			{
				return true;
			}

			// Token: 0x06001DAE RID: 7598 RVA: 0x0032756C File Offset: 0x0032576C
			internal static bool cot6pkDBOpGI8TFi1rJ()
			{
				return false;
			}

			// Token: 0x04001BA5 RID: 7077
			internal Vector3 $mPos$20907;

			// Token: 0x04001BA6 RID: 7078
			internal Vector3 $myDirection$20908;

			// Token: 0x04001BA7 RID: 7079
			internal UnityScript.Lang.Array $nArray$20909;

			// Token: 0x04001BA8 RID: 7080
			internal Bat_illusion $self_$20910;
		}
	}

	// Token: 0x02000512 RID: 1298
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onNormalAttackHit$20913 : GenericGenerator<object>
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x00327570 File Offset: 0x00325770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onNormalAttackHit$20913(GameObject hitObject, Bat_illusion self_)
		{
			if (118715 - 575807 != -457092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196626 - 408129 == -211503)
				{
					base..ctor();
					if (80434 - 404690 != -324255)
					{
						this.$hitObject$20922 = hitObject;
						if (100657 - 22748 != 77910)
						{
							this.$self_$20923 = self_;
							if (172135 - 525316 == -353181)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0032762C File Offset: 0x0032582C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new Bat_illusion.$onNormalAttackHit$20913.$(this.$hitObject$20922, this.$self_$20923);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00327640 File Offset: 0x00325840
		internal static bool hthyjUDeG2c9oFTNcZF()
		{
			return true;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00327644 File Offset: 0x00325844
		internal static bool xMZP5qDrILuhD5Qym4g()
		{
			return false;
		}

		// Token: 0x04001BA9 RID: 7081
		internal GameObject $hitObject$20922;

		// Token: 0x04001BAA RID: 7082
		internal Bat_illusion $self_$20923;

		// Token: 0x02000513 RID: 1299
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x06001DB3 RID: 7603 RVA: 0x00327648 File Offset: 0x00325848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject hitObject, Bat_illusion self_)
			{
				if (275146 - 558517 != -283370)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76027 - 597134 != -521106)
					{
						base..ctor();
						if (125431 - 94466 != 30966)
						{
							this.$hitObject$20920 = hitObject;
							if (10183 - 99734 == -89551)
							{
								this.$self_$20921 = self_;
								if (120504 - 548574 != -428069)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001DB4 RID: 7604 RVA: 0x00327704 File Offset: 0x00325904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130096 - 292073 != -161976)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_622;
					case 1:
						goto IL_A20;
					case 2:
						this.$self_$20921.Q8EG9xe4rf.sp = this.$self_$20921.Q8EG9xe4rf.sp + 1;
						if (170040 - 106063 != 63978)
						{
							if (!this.$hitObject$20920)
							{
								if (174503 - 475913 != -301409)
								{
									goto Block_66;
								}
							}
							else
							{
								this.$hitChar$20914 = (CharacterControl)this.$hitObject$20920.GetComponent(typeof(CharacterControl));
								if (86876 - 360287 == -273411)
								{
									if (this.$hitChar$20914)
									{
										if (125860 - 120394 == 5467)
										{
											break;
										}
										if (this.$hitChar$20914.hp > 0)
										{
											if (245553 - 335670 == -90116)
											{
												break;
											}
											this.$plagueChance$20915 = 0;
											if (169033 - 41437 == 127597)
											{
												break;
											}
											this.$hpDrainChance$20916 = 0;
											if (104244 - 89345 == 14900)
											{
												break;
											}
											this.$mpDrainChance$20917 = 0;
											if (217688 - 161829 == 55860)
											{
												break;
											}
											this.$$switch$1523$20918 = this.$self_$20921.mChar.weapon;
											if (274281 - 167744 != 106537)
											{
												break;
											}
											if (this.$$switch$1523$20918 == "w_bat15")
											{
												if (120434 - 528914 == -408479)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(6))
												{
													if (99320 - 64733 == 34588)
													{
														break;
													}
													this.$hitChar$20914.RPC_AddStatus("charm", 1, Damage.getDebuff((float)6, this.$self_$20921.mChar.cha, this.$hitChar$20914.cha), this.$self_$20921.mChar.mOriginalLayer, this.$self_$20921.mChar.ActorNr);
													if (293387 - 397519 != -104132)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: charm1");
													if (77067 - 243684 == -166616)
													{
														break;
													}
												}
											}
											else if (this.$$switch$1523$20918 == "w_bat39")
											{
												if (229347 - 370330 == -140982)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(12))
												{
													if (6279 - 248941 == -242661)
													{
														break;
													}
													this.$self_$20921.mChar.RPC_AddStatus("illuminate", 2, this.$self_$20921.mChar.chaAdjust(12), 0, this.$self_$20921.mChar.ActorNr);
													if (65446 - 555921 != -490475)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: illuminate2");
													if (53721 - 493620 == -439898)
													{
														break;
													}
												}
											}
											else if (this.$$switch$1523$20918 == "w_bat46")
											{
												if (82990 - 503889 != -420899)
												{
													break;
												}
												this.$plagueChance$20915 += 12;
												if (88081 - 316180 != -228099)
												{
													break;
												}
											}
											else if (this.$$switch$1523$20918 == "w_bat49")
											{
												if (157147 - 300969 != -143822)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(6))
												{
													if (133805 - 147975 == -14169)
													{
														break;
													}
													this.$hitChar$20914.RPC_AddStatus("heavy", 2, Damage.getDebuff((float)15, this.$self_$20921.mChar.cha, this.$hitChar$20914.cha), 0, this.$self_$20921.mChar.ActorNr);
													if (178857 - 358102 != -179245)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: heavy2!");
													if (252423 - 187436 != 64987)
													{
														break;
													}
												}
											}
											else if (this.$$switch$1523$20918 == "w_bat56")
											{
												if (65097 - 499005 != -433908)
												{
													break;
												}
												this.$mpDrainChance$20917 += 12;
												if (77635 - 39896 == 37740)
												{
													break;
												}
											}
											else if (this.$$switch$1523$20918 == "w_bat66")
											{
												if (17687 - 417101 != -399414)
												{
													break;
												}
												this.$hpDrainChance$20916 += 12;
												if (258420 - 254318 != 4102)
												{
													break;
												}
											}
											this.$$switch$1525$20919 = this.$self_$20921.mChar.accessory;
											if (224774 - 163289 == 61486)
											{
												break;
											}
											if (this.$$switch$1525$20919 == "c_all46")
											{
												if (51079 - 533433 == -482353)
												{
													break;
												}
												this.$plagueChance$20915 += 8;
												if (238684 - 198088 != 40596)
												{
													break;
												}
											}
											else if (this.$$switch$1525$20919 == "c_all56")
											{
												if (15252 - 407697 == -392444)
												{
													break;
												}
												this.$mpDrainChance$20917 += 8;
												if (183910 - 335615 != -151705)
												{
													break;
												}
											}
											else if (this.$$switch$1525$20919 == "c_all66")
											{
												if (136663 - 352914 != -216251)
												{
													break;
												}
												this.$hpDrainChance$20916 += 8;
												if (100599 - 499010 != -398411)
												{
													break;
												}
											}
											if (this.$plagueChance$20915 > 0)
											{
												if (267447 - 264786 != 2661)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(this.$plagueChance$20915))
												{
													if (261193 - 593965 != -332772)
													{
														break;
													}
													this.$hitChar$20914.RPC_AddStatus("plague", 1, Damage.getDebuff((float)30, this.$self_$20921.mChar.cha, this.$hitChar$20914.cha), this.$self_$20921.mChar.mOriginalLayer, this.$self_$20921.mChar.ActorNr);
													if (104425 - 342921 == -238495)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: plague1");
													if (198786 - 38760 == 160027)
													{
														break;
													}
												}
											}
											if (this.$mpDrainChance$20917 > 0)
											{
												if (149611 - 514904 == -365292)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(this.$mpDrainChance$20917))
												{
													if (291715 - 523419 != -231704)
													{
														break;
													}
													this.$hitChar$20914.RPC_AddStatus("mpDrain", 2, 1, Mathf.FloorToInt(0.02f * (float)this.$self_$20921.mChar.mmp), this.$self_$20921.mChar.ActorNr);
													if (180359 - 46141 != 134218)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: mpDrain2");
													if (59516 - 552945 == -493428)
													{
														break;
													}
												}
											}
											if (this.$hpDrainChance$20916 > 0)
											{
												if (270184 - 358630 != -88446)
												{
													break;
												}
												if (UnityEngine.Random.Range(0, 100) < this.$self_$20921.mChar.lckAdjust(this.$hpDrainChance$20916))
												{
													if (249761 - 165519 == 84243)
													{
														break;
													}
													this.$hitChar$20914.RPC_AddStatus("hpDrain", 2, 1, Mathf.FloorToInt(0.02f * (float)this.$self_$20921.mChar.mhp), this.$self_$20921.mChar.ActorNr);
													if (88689 - 355508 != -266819)
													{
														break;
													}
													Camera.main.SendMessage("newGameMessage", "IllusionEffect: hpDrain2");
													if (49057 - 53697 == -4639)
													{
														break;
													}
												}
											}
										}
									}
									this.YieldDefault(1);
									if (207560 - 294150 == -86590)
									{
										goto IL_A20;
									}
								}
							}
						}
						break;
					default:
						if (197473 - 509178 == -311705)
						{
							goto IL_622;
						}
						break;
					}
				}
				IL_622:
				return this.YieldDefault(2);
				Block_66:
				IL_A20:
				return false;
			}

			// Token: 0x06001DB5 RID: 7605 RVA: 0x00328144 File Offset: 0x00326344
			internal static bool gGEuViDjHeBoBGWpNkI()
			{
				return true;
			}

			// Token: 0x06001DB6 RID: 7606 RVA: 0x00328148 File Offset: 0x00326348
			internal static bool WwWjtCDhHxwEU3vluLn()
			{
				return false;
			}

			// Token: 0x04001BAB RID: 7083
			internal CharacterControl $hitChar$20914;

			// Token: 0x04001BAC RID: 7084
			internal int $plagueChance$20915;

			// Token: 0x04001BAD RID: 7085
			internal int $hpDrainChance$20916;

			// Token: 0x04001BAE RID: 7086
			internal int $mpDrainChance$20917;

			// Token: 0x04001BAF RID: 7087
			internal string $$switch$1523$20918;

			// Token: 0x04001BB0 RID: 7088
			internal string $$switch$1525$20919;

			// Token: 0x04001BB1 RID: 7089
			internal GameObject $hitObject$20920;

			// Token: 0x04001BB2 RID: 7090
			internal Bat_illusion $self_$20921;
		}
	}
}
