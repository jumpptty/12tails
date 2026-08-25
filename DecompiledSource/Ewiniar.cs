using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200028B RID: 651
[Serializable]
public class Ewiniar : MonoBehaviour
{
	// Token: 0x06000EE1 RID: 3809 RVA: 0x00178838 File Offset: 0x00176A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ewiniar()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00178848 File Offset: 0x00176A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (9472 - 507543 != -498070)
		{
		}
		for (;;)
		{
			this.DDuJ7TpOZs = this.transform;
			if (177827 - 130750 == 47077)
			{
				this.JHgJZHTwOf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (110070 - 119146 == -9076)
				{
					this.JHgJZHTwOf.actionState = "swim";
					if (23409 - 90077 != -66667)
					{
						this.JHgJZHTwOf.actionTime = Time.time;
						if (296444 - 76093 == 220351)
						{
							this.JHgJZHTwOf.myCommand = "none";
							if (233116 - 302976 != -69859)
							{
								this.JHgJZHTwOf.hp = (this.JHgJZHTwOf.mhp = 61500);
								if (18235 - 408218 != -389982)
								{
									this.JHgJZHTwOf.ko = (this.JHgJZHTwOf.mko = 215);
									if (90828 - 147860 != -57031)
									{
										GameObject gameObject = global::Math.findChildObject(this.transform, "head").gameObject;
										if (284401 - 415284 == -130883)
										{
											if (gameObject)
											{
												if (185482 - 558048 == -372565)
												{
													continue;
												}
												this.AEXJC7SMYA = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
												if (235933 - 258805 != -22872)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Cannot find head object");
												if (232316 - 406636 == -174319)
												{
													continue;
												}
											}
											GameObject gameObject2 = global::Math.findChildObject(this.transform, "body1").gameObject;
											if (148890 - 177349 == -28459)
											{
												if (gameObject2)
												{
													if (245772 - 456630 == -210857)
													{
														continue;
													}
													this.Qh3JMwjqh2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
													if (217281 - 390510 != -173229)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Cannot find body object");
													if (298217 - 19719 != 278498)
													{
														continue;
													}
												}
												GameObject gameObject3 = global::Math.findChildObject(this.transform, "tail2").gameObject;
												if (195831 - 332411 != -136579)
												{
													if (gameObject3)
													{
														if (293554 - 444204 != -150650)
														{
															continue;
														}
														this.olYJffcaV7 = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
														if (220709 - 431765 != -211056)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find tail2 object");
														if (84588 - 153102 == -68513)
														{
															continue;
														}
													}
													GameObject gameObject4 = global::Math.findChildObject(this.transform, "tail5").gameObject;
													if (124517 - 204325 != -79807)
													{
														if (gameObject4)
														{
															if (155870 - 538236 == -382366)
															{
																this.v6uJLnvciV = (CharacterControl)gameObject4.GetComponent(typeof(CharacterControl));
																if (286022 - 238621 == 47401)
																{
																	break;
																}
															}
														}
														else
														{
															Debug.LogError("Cannot find tail5 object");
															if (23784 - 275028 == -251244)
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

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00178C9C File Offset: 0x00176E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197982 - 46048 != 151935)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (188713 - 314977 == -126263)
				{
					continue;
				}
				this.JHgJZHTwOf.isMine = true;
				if (175068 - 291986 != -116918)
				{
					continue;
				}
			}
			if (this.JHgJZHTwOf.ActorNr != 0)
			{
				if (136836 - 457025 != -320189)
				{
					continue;
				}
				if (this.AEXJC7SMYA)
				{
					if (168373 - 509469 == -341095)
					{
						continue;
					}
					this.AEXJC7SMYA.ActorNr = this.JHgJZHTwOf.ActorNr + 1;
					if (147496 - 368297 != -220801)
					{
						continue;
					}
					this.AEXJC7SMYA.ownerID = this.JHgJZHTwOf.ownerID;
					if (112235 - 476311 != -364076)
					{
						continue;
					}
					this.AEXJC7SMYA.gameObject.layer = this.gameObject.layer;
					if (274048 - 317796 == -43747)
					{
						continue;
					}
					this.AEXJC7SMYA.isPlayer = false;
					if (67284 - 16657 != 50627)
					{
						continue;
					}
					this.AEXJC7SMYA.isControlled = false;
					if (48667 - 158136 == -109468)
					{
						continue;
					}
					if (this.JHgJZHTwOf.ownerID == PlayerData.UID)
					{
						if (11342 - 70115 != -58773)
						{
							continue;
						}
						this.AEXJC7SMYA.isMine = true;
						if (288675 - 340154 != -51479)
						{
							continue;
						}
					}
					else
					{
						this.AEXJC7SMYA.isMine = false;
						if (180993 - 519310 != -338317)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.AEXJC7SMYA.ActorNr], null))
					{
						if (9511 - 17235 == -7723)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.AEXJC7SMYA.ActorNr + " already existed");
						if (165024 - 251974 == -86949)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.AEXJC7SMYA.ActorNr];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (248846 - 477203 != -228357)
						{
							continue;
						}
						if (gameObject)
						{
							if (177208 - 321816 != -144608)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject);
							if (233566 - 558988 != -325422)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.AEXJC7SMYA.ActorNr, this.AEXJC7SMYA.gameObject);
					if (213968 - 27847 == 186122)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mHeadChar");
					if (40653 - 87415 != -46762)
					{
						continue;
					}
				}
				if (this.Qh3JMwjqh2)
				{
					if (159006 - 81089 == 77918)
					{
						continue;
					}
					this.Qh3JMwjqh2.ActorNr = this.JHgJZHTwOf.ActorNr + 2;
					if (74340 - 457168 == -382827)
					{
						continue;
					}
					this.Qh3JMwjqh2.ownerID = this.JHgJZHTwOf.ownerID;
					if (54851 - 261297 == -206445)
					{
						continue;
					}
					this.Qh3JMwjqh2.gameObject.layer = this.gameObject.layer;
					if (106613 - 28 != 106585)
					{
						continue;
					}
					this.Qh3JMwjqh2.isPlayer = false;
					if (166135 - 17738 != 148397)
					{
						continue;
					}
					this.Qh3JMwjqh2.isControlled = false;
					if (59460 - 359834 == -300373)
					{
						continue;
					}
					if (this.JHgJZHTwOf.ownerID == PlayerData.UID)
					{
						if (38412 - 584354 == -545941)
						{
							continue;
						}
						this.Qh3JMwjqh2.isMine = true;
						if (277161 - 577492 == -300330)
						{
							continue;
						}
					}
					else
					{
						this.Qh3JMwjqh2.isMine = false;
						if (274468 - 38878 != 235590)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.Qh3JMwjqh2.ActorNr], null))
					{
						if (208870 - 553985 != -345115)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.Qh3JMwjqh2.ActorNr + " already existed");
						if (179851 - 483623 == -303771)
						{
							continue;
						}
						object obj4;
						object obj3 = obj4 = PhotonClient.ActorNrList[this.Qh3JMwjqh2.ActorNr];
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj4;
						if (216819 - 550884 != -334065)
						{
							continue;
						}
						if (gameObject2)
						{
							if (87339 - 499127 != -411788)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject2);
							if (35256 - 248223 == -212966)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.Qh3JMwjqh2.ActorNr, this.Qh3JMwjqh2.gameObject);
					if (168455 - 146590 == 21866)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mBodyChar");
					if (138502 - 12486 == 126017)
					{
						continue;
					}
				}
				if (this.olYJffcaV7)
				{
					if (278180 - 57965 == 220216)
					{
						continue;
					}
					this.olYJffcaV7.ActorNr = this.JHgJZHTwOf.ActorNr + 3;
					if (259759 - 139730 != 120029)
					{
						continue;
					}
					this.olYJffcaV7.ownerID = this.JHgJZHTwOf.ownerID;
					if (283031 - 239135 != 43896)
					{
						continue;
					}
					this.olYJffcaV7.gameObject.layer = this.gameObject.layer;
					if (214576 - 260208 != -45632)
					{
						continue;
					}
					this.olYJffcaV7.isPlayer = false;
					if (274449 - 324098 == -49648)
					{
						continue;
					}
					this.olYJffcaV7.isControlled = false;
					if (47377 - 188889 != -141512)
					{
						continue;
					}
					if (this.JHgJZHTwOf.ownerID == PlayerData.UID)
					{
						if (115501 - 88222 != 27279)
						{
							continue;
						}
						this.olYJffcaV7.isMine = true;
						if (210805 - 407248 != -196443)
						{
							continue;
						}
					}
					else
					{
						this.olYJffcaV7.isMine = false;
						if (277757 - 168194 != 109563)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.olYJffcaV7.ActorNr], null))
					{
						if (189160 - 238156 != -48996)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.olYJffcaV7.ActorNr + " already existed");
						if (151033 - 278492 == -127458)
						{
							continue;
						}
						object obj6;
						object obj5 = obj6 = PhotonClient.ActorNrList[this.olYJffcaV7.ActorNr];
						if (!(obj5 is GameObject))
						{
							obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
						}
						GameObject gameObject3 = (GameObject)obj6;
						if (72192 - 420408 != -348216)
						{
							continue;
						}
						if (gameObject3)
						{
							if (228352 - 95394 == 132959)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject3);
							if (77731 - 231483 == -153751)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.olYJffcaV7.ActorNr, this.olYJffcaV7.gameObject);
					if (53166 - 472872 != -419706)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mTail1Char");
					if (255701 - 9957 != 245744)
					{
						continue;
					}
				}
				if (this.v6uJLnvciV)
				{
					if (56459 - 291169 != -234710)
					{
						continue;
					}
					this.v6uJLnvciV.ActorNr = this.JHgJZHTwOf.ActorNr + 4;
					if (28274 - 159895 != -131621)
					{
						continue;
					}
					this.v6uJLnvciV.ownerID = this.JHgJZHTwOf.ownerID;
					if (174843 - 320567 != -145724)
					{
						continue;
					}
					this.v6uJLnvciV.gameObject.layer = this.gameObject.layer;
					if (280091 - 534209 == -254117)
					{
						continue;
					}
					this.v6uJLnvciV.isPlayer = false;
					if (71821 - 477427 == -405605)
					{
						continue;
					}
					this.v6uJLnvciV.isControlled = false;
					if (183760 - 556458 == -372697)
					{
						continue;
					}
					if (this.JHgJZHTwOf.ownerID == PlayerData.UID)
					{
						if (53526 - 472271 != -418745)
						{
							continue;
						}
						this.v6uJLnvciV.isMine = true;
						if (209130 - 576852 == -367721)
						{
							continue;
						}
					}
					else
					{
						this.v6uJLnvciV.isMine = false;
						if (157424 - 366936 == -209511)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.v6uJLnvciV.ActorNr], null))
					{
						if (42278 - 31099 != 11179)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.v6uJLnvciV.ActorNr + " already existed");
						if (127278 - 505177 != -377899)
						{
							continue;
						}
						object obj8;
						object obj7 = obj8 = PhotonClient.ActorNrList[this.v6uJLnvciV.ActorNr];
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						GameObject gameObject4 = (GameObject)obj8;
						if (280361 - 225210 != 55151)
						{
							continue;
						}
						if (gameObject4)
						{
							if (54293 - 109654 != -55361)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject4);
							if (280276 - 238883 != 41393)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.v6uJLnvciV.ActorNr, this.v6uJLnvciV.gameObject);
					if (37605 - 347085 == -309479)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mTail2Char");
					if (56867 - 397834 != -340967)
					{
						continue;
					}
				}
			}
			this.JHgJZHTwOf.actionState = "swim";
			if (193312 - 382217 == -188905)
			{
				this.JHgJZHTwOf.actionTime = Time.time;
				if (136777 - 297841 == -161064)
				{
					this.JHgJZHTwOf.myCommand = "none";
					if (59486 - 590636 != -531149)
					{
						this.JHgJZHTwOf.addTimeOut("hold", 60f);
						if (12207 - 78695 != -66487)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00179A38 File Offset: 0x00177C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (153282 - 241974 != -88691)
		{
		}
		for (;;)
		{
			if (this.JHgJZHTwOf)
			{
				if (151293 - 251934 == -100640)
				{
					continue;
				}
				if (this.AEXJC7SMYA)
				{
					if (90854 - 56633 != 34221)
					{
						continue;
					}
					if (this.Qh3JMwjqh2)
					{
						if (187211 - 561285 != -374074)
						{
							continue;
						}
						if (this.olYJffcaV7)
						{
							if (254569 - 150629 != 103940)
							{
								continue;
							}
							if (this.v6uJLnvciV)
							{
								if (4953 - 2353 == 2601)
								{
									continue;
								}
								int num = Mathf.Max(0, this.JHgJZHTwOf.hp - this.AEXJC7SMYA.hp);
								if (143648 - 408161 == -264512)
								{
									continue;
								}
								num += Mathf.Max(0, this.JHgJZHTwOf.hp - this.Qh3JMwjqh2.hp);
								if (279852 - 112951 != 166901)
								{
									continue;
								}
								num += Mathf.Max(0, this.JHgJZHTwOf.hp - this.olYJffcaV7.hp);
								if (110539 - 464422 != -353883)
								{
									continue;
								}
								num += Mathf.Max(0, this.JHgJZHTwOf.hp - this.v6uJLnvciV.hp);
								if (220627 - 295168 == -74540)
								{
									continue;
								}
								this.JHgJZHTwOf.hp = this.JHgJZHTwOf.hp - num;
								if (67754 - 380383 != -312629)
								{
									continue;
								}
								this.AEXJC7SMYA.hp = this.JHgJZHTwOf.hp;
								if (88439 - 583954 == -495514)
								{
									continue;
								}
								this.Qh3JMwjqh2.hp = this.JHgJZHTwOf.hp;
								if (158827 - 268708 == -109880)
								{
									continue;
								}
								this.olYJffcaV7.hp = this.JHgJZHTwOf.hp;
								if (20519 - 500152 != -479633)
								{
									continue;
								}
								this.v6uJLnvciV.hp = this.JHgJZHTwOf.hp;
								if (77558 - 168053 != -90495)
								{
									continue;
								}
							}
						}
					}
				}
			}
			if (this.JHgJZHTwOf.hp > 0)
			{
				break;
			}
			if (152191 - 422209 == -270018)
			{
				if (!(this.JHgJZHTwOf.actionState != "dead"))
				{
					break;
				}
				if (129280 - 61452 != 67829)
				{
					if (this.JHgJZHTwOf.isMine)
					{
						if (69675 - 506727 == -437052)
						{
							if (Game.mGameState != eGameState.Normal)
							{
								break;
							}
							if (75044 - 517651 != -442606)
							{
								this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (154084 - 335541 == -181457)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (273676 - 320788 == -47112)
									{
										this.JHgJZHTwOf.DeadEvent();
										if (297920 - 213694 != 84227)
										{
											break;
										}
									}
								}
							}
						}
					}
					else
					{
						this.JHgJZHTwOf.hp = 1;
						if (67317 - 27197 != 40121)
						{
							this.AEXJC7SMYA.hp = 1;
							if (61471 - 304969 != -243497)
							{
								this.Qh3JMwjqh2.hp = 1;
								if (66963 - 396279 != -329315)
								{
									this.olYJffcaV7.hp = 1;
									if (260123 - 465236 == -205113)
									{
										this.v6uJLnvciV.hp = 1;
										if (277234 - 578973 == -301739)
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

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00179F2C File Offset: 0x0017812C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (16789 - 451230 != -434440)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (192200 - 130290 != 61911)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (268811 - 201597 == 67214)
				{
					if (18378 - 596920 == -578542)
					{
						if (ActionName == "RPC_swimLeft")
						{
							if (17130 - 279748 != -262618)
							{
								continue;
							}
							v = 1;
							if (215491 - 174660 != 40831)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_swimRight")
						{
							if (215336 - 52100 != 163236)
							{
								continue;
							}
							v = 2;
							if (265353 - 192645 == 72709)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_jump")
						{
							if (164151 - 48787 != 115364)
							{
								continue;
							}
							v = 3;
							if (225854 - 504684 != -278830)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_release")
						{
							if (52037 - 134218 == -82180)
							{
								continue;
							}
							v = 4;
							if (248841 - 468071 == -219229)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_waterBlast")
						{
							if (233627 - 493050 != -259423)
							{
								continue;
							}
							v = 11;
							if (110277 - 299760 != -189483)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_lightning")
						{
							if (54238 - 382883 == -328644)
							{
								continue;
							}
							v = 21;
							if (232615 - 406417 != -173802)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_lightning_hit")
						{
							if (58793 - 20739 != 38054)
							{
								continue;
							}
							v = -21;
							if (85477 - 91354 != -5877)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cyclone")
						{
							if (241499 - 6729 != 234770)
							{
								continue;
							}
							v = 31;
							if (76427 - 107242 != -30815)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_followLeft")
						{
							if (1285 - 597156 != -595871)
							{
								continue;
							}
							v = 41;
							if (10440 - 484637 != -474197)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_followRight")
						{
							if (277617 - 376703 == -99085)
							{
								continue;
							}
							v = 51;
							if (93833 - 322676 == -228842)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (277639 - 105901 != 171738)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (226300 - 280145 == -53845)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (29816 - 133066 != -103249)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (12480 - 370472 != -357991)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (224146 - 314722 == -90576)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (59533 - 376745 == -317212)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (79716 - 73084 != 6633)
											{
												Hashtable hashtable = new Hashtable();
												if (155256 - 568500 != -413243)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (201572 - 475876 == -274304)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (204038 - 43337 != 160702)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (120630 - 110091 == 10539)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (274977 - 30316 == 244661)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (191919 - 241181 == -49262)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (98282 - 513398 != -415115)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (162578 - 95840 == 66738)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (264486 - 425211 == -160725)
																				{
																					PhotonClient.SendEvent(this.JHgJZHTwOf.ActorNr, 74, hashtable, true, true);
																					if (93902 - 148143 == -54241)
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

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0017A608 File Offset: 0x00178808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (270460 - 491827 != -221367)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (200175 - 50765 == 149410)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (234255 - 535439 != -301183)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (267314 - 42293 == 225021)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (128124 - 202627 != -74502)
						{
							int num3 = num;
							if (158939 - 155998 != 2942)
							{
								if (num3 == 1)
								{
									if (279054 - 261309 == 17745)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (250105 - 131957 != 118149)
										{
											this.StartCoroutine_Auto(this.RPC_swimLeft(vector, vector2, num2));
											if (88425 - 594027 == -505602)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (64095 - 511221 == -447126)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (113936 - 507197 == -393261)
										{
											this.StartCoroutine_Auto(this.RPC_swimRight(vector, vector2, num2));
											if (99378 - 586180 == -486802)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (39032 - 58462 != -19429)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (219656 - 554532 != -334875)
										{
											this.StartCoroutine_Auto(this.RPC_jump(vector, vector2, num2));
											if (161620 - 429754 != -268133)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (46212 - 586053 == -539841)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (51801 - 264165 == -212364)
										{
											this.StartCoroutine_Auto(this.RPC_release(vector, vector2, num2));
											if (20519 - 373106 == -352587)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (13110 - 19524 != -6413)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (40484 - 395938 != -355453)
										{
											this.StartCoroutine_Auto(this.RPC_waterBlast(vector, vector2, num2));
											if (63731 - 273749 != -210017)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (32621 - 146045 == -113424)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (294502 - 192690 != 101813)
										{
											this.StartCoroutine_Auto(this.RPC_lightning(vector, vector2, num2));
											if (31407 - 353300 == -321893)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (5048 - 281304 != -276255)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (12351 - 282722 != -270370)
										{
											this.RPC_lightning_hit(vector, vector2, num2);
											if (238060 - 343017 != -104956)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (181187 - 283615 == -102428)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (16131 - 298677 != -282545)
										{
											this.StartCoroutine_Auto(this.RPC_cyclone(vector, vector2, num2));
											if (230231 - 503295 != -273063)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (298916 - 330385 == -31469)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (264057 - 312664 == -48607)
										{
											this.StartCoroutine_Auto(this.RPC_followLeft(vector, vector2, num2));
											if (30103 - 212199 == -182096)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 51)
								{
									if (37089 - 316138 == -279049)
									{
										if (this.JHgJZHTwOf.isMine)
										{
											break;
										}
										if (139015 - 214458 == -75443)
										{
											this.StartCoroutine_Auto(this.RPC_followRight(vector, vector2, num2));
											if (253285 - 406816 == -153531)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (137317 - 423615 == -286298)
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

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0017AC7C File Offset: 0x00178E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot be controled");
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0017AC94 File Offset: 0x00178E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0017ACAC File Offset: 0x00178EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x0017ACC4 File Offset: 0x00178EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x0017ACC8 File Offset: 0x00178EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_swimLeft(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_swimLeft$17767(this).GetEnumerator();
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x0017ACD8 File Offset: 0x00178ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_swimRight(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_swimRight$17770(this).GetEnumerator();
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x0017ACE8 File Offset: 0x00178EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_jump(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_jump$17773(this).GetEnumerator();
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x0017ACF8 File Offset: 0x00178EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_release(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_release$17776(this).GetEnumerator();
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0017AD08 File Offset: 0x00178F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_waterBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_waterBlast$17779(this).GetEnumerator();
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x0017AD18 File Offset: 0x00178F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_lightning(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_lightning$17788(this).GetEnumerator();
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0017AD28 File Offset: 0x00178F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_lightning_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.lightning_hit)
		{
			UnityEngine.Object.Instantiate(this.lightning_hit, hitPos, Quaternion.identity);
		}
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0017AD4C File Offset: 0x00178F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cyclone(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_cyclone$17798(this).GetEnumerator();
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0017AD5C File Offset: 0x00178F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_followLeft(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_followLeft$17807(this).GetEnumerator();
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0017AD6C File Offset: 0x00178F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_followRight(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Ewiniar.$RPC_followRight$17817(this).GetEnumerator();
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x0017AD7C File Offset: 0x00178F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Ewiniar.$RPC_dead$17826(nArray, this).GetEnumerator();
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0017AD8C File Offset: 0x00178F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0017AD90 File Offset: 0x00178F90
	internal static bool AZ6IqOSzXr5LJh1d4My()
	{
		return true;
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x0017AD94 File Offset: 0x00178F94
	internal static bool tEAD0noabeSDIDGcUyP()
	{
		return false;
	}

	// Token: 0x04000CD0 RID: 3280
	public AudioClip ewiniar_cry;

	// Token: 0x04000CD1 RID: 3281
	private Transform DDuJ7TpOZs;

	// Token: 0x04000CD2 RID: 3282
	private CharacterControl JHgJZHTwOf;

	// Token: 0x04000CD3 RID: 3283
	private CharacterControl AEXJC7SMYA;

	// Token: 0x04000CD4 RID: 3284
	private CharacterControl Qh3JMwjqh2;

	// Token: 0x04000CD5 RID: 3285
	private CharacterControl olYJffcaV7;

	// Token: 0x04000CD6 RID: 3286
	private CharacterControl v6uJLnvciV;

	// Token: 0x04000CD7 RID: 3287
	public GameObject swim_ring1;

	// Token: 0x04000CD8 RID: 3288
	public GameObject swim_ring2;

	// Token: 0x04000CD9 RID: 3289
	public GameObject jump_ring;

	// Token: 0x04000CDA RID: 3290
	public GameObject release_ring;

	// Token: 0x04000CDB RID: 3291
	public GameObject waterBlast_ring;

	// Token: 0x04000CDC RID: 3292
	public GameObject lightning_ring;

	// Token: 0x04000CDD RID: 3293
	public GameObject lightning_hit;

	// Token: 0x04000CDE RID: 3294
	public GameObject cyclone_ring;

	// Token: 0x04000CDF RID: 3295
	public GameObject cyclone;

	// Token: 0x04000CE0 RID: 3296
	public GameObject follow_ring1;

	// Token: 0x04000CE1 RID: 3297
	public GameObject follow_ring2;

	// Token: 0x04000CE2 RID: 3298
	public GameObject dead_ring;

	// Token: 0x0200028C RID: 652
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_swimLeft$17767 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x0017AD98 File Offset: 0x00178F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_swimLeft$17767(Ewiniar self_)
		{
			if (59463 - 335510 != -276047)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68434 - 543138 != -474703)
				{
					base..ctor();
					if (189230 - 427252 != -238021)
					{
						this.$self_$17769 = self_;
						if (184393 - 569125 == -384732)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0017AE30 File Offset: 0x00179030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_swimLeft$17767.$(this.$self_$17769);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0017AE40 File Offset: 0x00179040
		internal static bool GKWlWbo5qjmKxCAjDWR()
		{
			return true;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0017AE44 File Offset: 0x00179044
		internal static bool e8TsAeopNhO6anh564f()
		{
			return false;
		}

		// Token: 0x04000CE3 RID: 3299
		internal Ewiniar $self_$17769;

		// Token: 0x0200028D RID: 653
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EFD RID: 3837 RVA: 0x0017AE48 File Offset: 0x00179048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (83653 - 243007 != -159353)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30126 - 180088 == -149962)
					{
						base..ctor();
						if (177573 - 85735 != 91839)
						{
							this.$self_$17768 = self_;
							if (67906 - 342725 == -274819)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000EFE RID: 3838 RVA: 0x0017AEE0 File Offset: 0x001790E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153048 - 526214 != -373166)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6BB;
					case 2:
						if (this.$self_$17768.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_4E0;
						}
						if (287150 - 499893 == -212742)
						{
							continue;
						}
						if (this.$self_$17768.JHgJZHTwOf.myCommand != "swimLeft")
						{
							if (168249 - 142582 != 25667)
							{
								continue;
							}
							goto IL_4E0;
						}
						else if (this.$self_$17768.swim_ring1)
						{
							if (34350 - 17232 != 17118)
							{
								continue;
							}
							this.$self_$17768.JHgJZHTwOf.createEffect(this.$self_$17768.swim_ring1, this.$self_$17768.transform.position + this.$self_$17768.transform.TransformDirection((float)36, (float)0, (float)81), this.$self_$17768.transform.rotation);
							if (281149 - 268736 != 12413)
							{
								continue;
							}
							goto IL_2A0;
						}
						else
						{
							Debug.LogError("Missing swim_ring1 effect");
							if (71989 - 304802 != -232813)
							{
								continue;
							}
							goto IL_514;
						}
						break;
					case 3:
						if (this.$self_$17768.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_1A8;
						}
						if (211590 - 587173 != -375583)
						{
							continue;
						}
						if (this.$self_$17768.JHgJZHTwOf.myCommand != "swimLeft")
						{
							if (109516 - 367526 != -258009)
							{
								goto Block_28;
							}
							continue;
						}
						else if (this.$self_$17768.swim_ring2)
						{
							if (57494 - 479179 == -421684)
							{
								continue;
							}
							this.$self_$17768.JHgJZHTwOf.createEffect(this.$self_$17768.swim_ring2, this.$self_$17768.transform.position + this.$self_$17768.transform.TransformDirection((float)36, (float)0, (float)-89), this.$self_$17768.transform.rotation);
							if (183415 - 493663 != -310247)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing swim_ring2 effect");
							if (18936 - 341859 != -322923)
							{
								continue;
							}
							goto IL_371;
						}
						break;
					case 4:
						if (this.$self_$17768.JHgJZHTwOf.actionState == "attack")
						{
							if (262315 - 319044 == -56728)
							{
								continue;
							}
							if (this.$self_$17768.JHgJZHTwOf.myCommand == "swimLeft")
							{
								if (219501 - 506272 != -286771)
								{
									continue;
								}
								this.$self_$17768.JHgJZHTwOf.moveSpeed = (float)0;
								if (245298 - 73053 == 172246)
								{
									continue;
								}
								this.$self_$17768.JHgJZHTwOf.actionState = "swim";
								if (267897 - 391951 != -124054)
								{
									continue;
								}
								this.$self_$17768.JHgJZHTwOf.actionTime = Time.time;
								if (84344 - 288625 != -204281)
								{
									continue;
								}
								this.$self_$17768.JHgJZHTwOf.myCommand = "none";
								if (121917 - 534853 == -412935)
								{
									continue;
								}
								if (!this.$self_$17768.JHgJZHTwOf.isMine)
								{
									if (69917 - 57491 != 12426)
									{
										continue;
									}
									this.$self_$17768.JHgJZHTwOf.nPosition = this.$self_$17768.transform.position;
									if (59734 - 162843 == -103108)
									{
										continue;
									}
									this.$self_$17768.JHgJZHTwOf.oPosition = this.$self_$17768.transform.position;
									if (181526 - 233979 == -52452)
									{
										continue;
									}
									this.$self_$17768.JHgJZHTwOf.nDirection = this.$self_$17768.transform.forward;
									if (18435 - 380061 != -361626)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (239837 - 61637 != 178201)
						{
							goto Block_4;
						}
						continue;
					default:
						if (71962 - 265559 == -193596)
						{
							continue;
						}
						break;
					}
					this.$self_$17768.JHgJZHTwOf.actionState = "attack";
					if (148513 - 3035 == 145478)
					{
						this.$self_$17768.JHgJZHTwOf.actionTime = Time.time;
						if (100275 - 570147 != -469871)
						{
							this.$self_$17768.JHgJZHTwOf.myCommand = "swimLeft";
							if (13539 - 498434 == -484895)
							{
								this.$self_$17768.animation.Rewind();
								if (89617 - 94054 != -4436)
								{
									this.$self_$17768.animation.Play("swimLeft");
									if (96672 - 505825 == -409153)
									{
										this.$self_$17768.animation.wrapMode = WrapMode.Once;
										if (296996 - 216851 == 80145)
										{
											this.$self_$17768.JHgJZHTwOf.vMovement = this.$self_$17768.transform.forward;
											if (79544 - 450677 != -371132)
											{
												this.$self_$17768.JHgJZHTwOf.moveSpeed = (float)0;
												if (248577 - 345285 == -96708)
												{
													goto IL_2C9;
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
				goto IL_6BB;
				Block_6:
				goto IL_371;
				IL_1A8:
				goto IL_6BB;
				IL_2A0:
				goto IL_514;
				IL_2C9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_371:
				return this.Yield(4, new WaitForSeconds(5.5f));
				Block_28:
				IL_4E0:
				goto IL_6BB;
				IL_514:
				return this.Yield(3, new WaitForSeconds(17.5f));
				IL_6BB:
				return false;
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x0017B5BC File Offset: 0x001797BC
			internal static bool fkPHc3oVSna2C7Y8ye6()
			{
				return true;
			}

			// Token: 0x06000F00 RID: 3840 RVA: 0x0017B5C0 File Offset: 0x001797C0
			internal static bool EcgoELot3aOfTOvNd49()
			{
				return false;
			}

			// Token: 0x04000CE4 RID: 3300
			internal Ewiniar $self_$17768;
		}
	}

	// Token: 0x0200028E RID: 654
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_swimRight$17770 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x0017B5C4 File Offset: 0x001797C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_swimRight$17770(Ewiniar self_)
		{
			if (87386 - 57810 != 29576)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291042 - 141326 != 149717)
				{
					base..ctor();
					if (2317 - 78386 != -76068)
					{
						this.$self_$17772 = self_;
						if (188365 - 267745 != -79379)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0017B65C File Offset: 0x0017985C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_swimRight$17770.$(this.$self_$17772);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0017B66C File Offset: 0x0017986C
		internal static bool s9c1oPoNTZfZKrev6ys()
		{
			return true;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0017B670 File Offset: 0x00179870
		internal static bool W10ah1oYoSTIPOZDK4j()
		{
			return false;
		}

		// Token: 0x04000CE5 RID: 3301
		internal Ewiniar $self_$17772;

		// Token: 0x0200028F RID: 655
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F05 RID: 3845 RVA: 0x0017B674 File Offset: 0x00179874
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (252074 - 582884 != -330809)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245707 - 497113 == -251406)
					{
						base..ctor();
						if (250153 - 209177 == 40976)
						{
							this.$self_$17771 = self_;
							if (236730 - 395323 != -158592)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F06 RID: 3846 RVA: 0x0017B70C File Offset: 0x0017990C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161813 - 342682 != -180868)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6BB;
					case 2:
						if (this.$self_$17771.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_3C8;
						}
						if (198168 - 174476 == 23693)
						{
							continue;
						}
						if (this.$self_$17771.JHgJZHTwOf.myCommand != "swimRight")
						{
							if (232433 - 441927 != -209494)
							{
								continue;
							}
							goto IL_3C8;
						}
						else if (this.$self_$17771.swim_ring1)
						{
							if (1854 - 282576 == -280721)
							{
								continue;
							}
							this.$self_$17771.JHgJZHTwOf.createEffect(this.$self_$17771.swim_ring1, this.$self_$17771.transform.position + this.$self_$17771.transform.TransformDirection((float)-36, (float)0, (float)81), this.$self_$17771.transform.rotation);
							if (38594 - 319187 != -280593)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							Debug.LogError("Missing swim_ring1 effect");
							if (51776 - 274060 != -222283)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17771.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_2F1;
						}
						if (38705 - 290394 != -251689)
						{
							continue;
						}
						if (this.$self_$17771.JHgJZHTwOf.myCommand != "swimRight")
						{
							if (149503 - 240170 != -90666)
							{
								goto Block_13;
							}
							continue;
						}
						else if (this.$self_$17771.swim_ring2)
						{
							if (111888 - 437879 == -325990)
							{
								continue;
							}
							this.$self_$17771.JHgJZHTwOf.createEffect(this.$self_$17771.swim_ring2, this.$self_$17771.transform.position + this.$self_$17771.transform.TransformDirection((float)-36, (float)0, (float)-89), this.$self_$17771.transform.rotation);
							if (147945 - 570160 != -422214)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing swim_ring2 effect");
							if (250742 - 190623 != 60119)
							{
								continue;
							}
							goto IL_239;
						}
						break;
					case 4:
						if (this.$self_$17771.JHgJZHTwOf.actionState == "attack")
						{
							if (265594 - 325468 != -59874)
							{
								continue;
							}
							if (this.$self_$17771.JHgJZHTwOf.myCommand == "swimRight")
							{
								if (29870 - 536880 == -507009)
								{
									continue;
								}
								this.$self_$17771.JHgJZHTwOf.moveSpeed = (float)0;
								if (208654 - 150268 != 58386)
								{
									continue;
								}
								this.$self_$17771.JHgJZHTwOf.actionState = "swim";
								if (191050 - 288600 == -97549)
								{
									continue;
								}
								this.$self_$17771.JHgJZHTwOf.actionTime = Time.time;
								if (52963 - 418373 != -365410)
								{
									continue;
								}
								this.$self_$17771.JHgJZHTwOf.myCommand = "none";
								if (218197 - 18135 != 200062)
								{
									continue;
								}
								if (!this.$self_$17771.JHgJZHTwOf.isMine)
								{
									if (208304 - 310067 != -101763)
									{
										continue;
									}
									this.$self_$17771.JHgJZHTwOf.nPosition = this.$self_$17771.transform.position;
									if (150857 - 127832 == 23026)
									{
										continue;
									}
									this.$self_$17771.JHgJZHTwOf.oPosition = this.$self_$17771.transform.position;
									if (227028 - 365031 != -138003)
									{
										continue;
									}
									this.$self_$17771.JHgJZHTwOf.nDirection = this.$self_$17771.transform.forward;
									if (192818 - 441777 != -248959)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (101261 - 443419 != -342158)
						{
							continue;
						}
						goto IL_6BB;
					default:
						if (36270 - 116509 != -80239)
						{
							continue;
						}
						break;
					}
					this.$self_$17771.JHgJZHTwOf.actionState = "attack";
					if (188715 - 86581 != 102135)
					{
						this.$self_$17771.JHgJZHTwOf.actionTime = Time.time;
						if (174463 - 298688 == -124225)
						{
							this.$self_$17771.JHgJZHTwOf.myCommand = "swimRight";
							if (199313 - 145805 == 53508)
							{
								this.$self_$17771.animation.Rewind();
								if (181476 - 349682 == -168206)
								{
									this.$self_$17771.animation.Play("swimRight");
									if (24208 - 257970 != -233761)
									{
										this.$self_$17771.animation.wrapMode = WrapMode.Once;
										if (297900 - 393772 != -95871)
										{
											this.$self_$17771.JHgJZHTwOf.vMovement = this.$self_$17771.transform.forward;
											if (201986 - 584702 != -382715)
											{
												this.$self_$17771.JHgJZHTwOf.moveSpeed = (float)0;
												if (29879 - 190388 != -160508)
												{
													goto Block_37;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				Block_3:
				return this.Yield(3, new WaitForSeconds(17.5f));
				Block_13:
				goto IL_2F1;
				IL_239:
				return this.Yield(4, new WaitForSeconds(5.5f));
				IL_2F1:
				IL_3C8:
				goto IL_6BB;
				Block_37:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_38:
				goto IL_239;
				IL_6BB:
				return false;
			}

			// Token: 0x06000F07 RID: 3847 RVA: 0x0017BDE8 File Offset: 0x00179FE8
			internal static bool HPnoxkoctdLyTGE0Q5h()
			{
				return true;
			}

			// Token: 0x06000F08 RID: 3848 RVA: 0x0017BDEC File Offset: 0x00179FEC
			internal static bool eAsiMIoUYOWgRk55LGC()
			{
				return false;
			}

			// Token: 0x04000CE6 RID: 3302
			internal Ewiniar $self_$17771;
		}
	}

	// Token: 0x02000290 RID: 656
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_jump$17773 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F09 RID: 3849 RVA: 0x0017BDF0 File Offset: 0x00179FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_jump$17773(Ewiniar self_)
		{
			if (179745 - 348437 != -168691)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295819 - 251406 == 44413)
				{
					base..ctor();
					if (20262 - 357362 == -337100)
					{
						this.$self_$17775 = self_;
						if (234628 - 324791 == -90163)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0017BE88 File Offset: 0x0017A088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_jump$17773.$(this.$self_$17775);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0017BE98 File Offset: 0x0017A098
		internal static bool r3gH60oTcTglbqNuUOE()
		{
			return true;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0017BE9C File Offset: 0x0017A09C
		internal static bool zLIkK1o3HbnEAgEFHCQ()
		{
			return false;
		}

		// Token: 0x04000CE7 RID: 3303
		internal Ewiniar $self_$17775;

		// Token: 0x02000291 RID: 657
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F0D RID: 3853 RVA: 0x0017BEA0 File Offset: 0x0017A0A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (150713 - 47993 != 102720)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266178 - 443060 == -176882)
					{
						base..ctor();
						if (23082 - 552534 != -529451)
						{
							this.$self_$17774 = self_;
							if (84213 - 454402 != -370188)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F0E RID: 3854 RVA: 0x0017BF38 File Offset: 0x0017A138
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144562 - 383390 != -238828)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5BC;
					case 2:
						if (this.$self_$17774.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_198;
						}
						if (9850 - 349700 == -339849)
						{
							continue;
						}
						if (this.$self_$17774.JHgJZHTwOf.myCommand != "jump")
						{
							if (181338 - 405041 != -223703)
							{
								continue;
							}
							goto IL_198;
						}
						else if (this.$self_$17774.jump_ring)
						{
							if (111903 - 100221 != 11682)
							{
								continue;
							}
							this.$self_$17774.JHgJZHTwOf.createEffect(this.$self_$17774.jump_ring, this.$self_$17774.transform.position + this.$self_$17774.transform.TransformDirection((float)-5, (float)0, (float)-60), this.$self_$17774.transform.rotation);
							if (10933 - 438464 != -427530)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing jump ring effect");
							if (111110 - 569935 != -458825)
							{
								continue;
							}
							goto IL_449;
						}
						break;
					case 3:
						if (this.$self_$17774.JHgJZHTwOf.actionState == "attack")
						{
							if (194192 - 281973 != -87781)
							{
								continue;
							}
							if (this.$self_$17774.JHgJZHTwOf.myCommand == "jump")
							{
								if (186256 - 351007 != -164751)
								{
									continue;
								}
								this.$self_$17774.JHgJZHTwOf.moveSpeed = (float)0;
								if (251397 - 472558 != -221161)
								{
									continue;
								}
								this.$self_$17774.JHgJZHTwOf.actionState = "hold";
								if (282678 - 42983 == 239696)
								{
									continue;
								}
								this.$self_$17774.JHgJZHTwOf.actionTime = Time.time;
								if (154885 - 424139 == -269253)
								{
									continue;
								}
								this.$self_$17774.JHgJZHTwOf.myCommand = "none";
								if (7960 - 513488 == -505527)
								{
									continue;
								}
								if (!this.$self_$17774.JHgJZHTwOf.isMine)
								{
									if (228351 - 343906 != -115555)
									{
										continue;
									}
									this.$self_$17774.JHgJZHTwOf.nPosition = this.$self_$17774.transform.position;
									if (263545 - 458733 != -195188)
									{
										continue;
									}
									this.$self_$17774.JHgJZHTwOf.oPosition = this.$self_$17774.transform.position;
									if (210074 - 264985 != -54911)
									{
										continue;
									}
									this.$self_$17774.JHgJZHTwOf.nDirection = this.$self_$17774.transform.forward;
									if (244421 - 283772 == -39350)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (44225 - 230038 != -185812)
						{
							goto Block_17;
						}
						continue;
					default:
						if (116731 - 583074 != -466343)
						{
							continue;
						}
						break;
					}
					this.$self_$17774.JHgJZHTwOf.actionState = "attack";
					if (168454 - 35141 == 133313)
					{
						this.$self_$17774.JHgJZHTwOf.actionTime = Time.time;
						if (140123 - 9107 == 131016)
						{
							this.$self_$17774.JHgJZHTwOf.myCommand = "jump";
							if (227625 - 92476 == 135149)
							{
								this.$self_$17774.JHgJZHTwOf.addTimeOut("swim", 60f);
								if (217273 - 352935 != -135661)
								{
									this.$self_$17774.animation.Rewind();
									if (158775 - 299865 != -141089)
									{
										this.$self_$17774.animation.Play("jump");
										if (208092 - 488181 != -280088)
										{
											this.$self_$17774.animation.wrapMode = WrapMode.Once;
											if (32145 - 132038 != -99892)
											{
												this.$self_$17774.JHgJZHTwOf.vMovement = this.$self_$17774.transform.forward;
												if (37917 - 178119 == -140202)
												{
													this.$self_$17774.JHgJZHTwOf.moveSpeed = (float)0;
													if (87411 - 412764 == -325353)
													{
														Camera.main.SendMessage("EwiniarJumpEvent");
														if (261073 - 108120 != 152954)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_198:
				goto IL_5BC;
				Block_14:
				goto IL_449;
				Block_17:
				goto IL_5BC;
				IL_449:
				return this.Yield(3, new WaitForSeconds(4f));
				IL_5BC:
				return false;
			}

			// Token: 0x06000F0F RID: 3855 RVA: 0x0017C514 File Offset: 0x0017A714
			internal static bool Jj1VjjoXWxTnGI7LAtc()
			{
				return true;
			}

			// Token: 0x06000F10 RID: 3856 RVA: 0x0017C518 File Offset: 0x0017A718
			internal static bool cBDtCBoQZm8nEZHfT2T()
			{
				return false;
			}

			// Token: 0x04000CE8 RID: 3304
			internal Ewiniar $self_$17774;
		}
	}

	// Token: 0x02000292 RID: 658
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_release$17776 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x0017C51C File Offset: 0x0017A71C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_release$17776(Ewiniar self_)
		{
			if (246147 - 495739 != -249591)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292526 - 280931 != 11596)
				{
					base..ctor();
					if (253332 - 514594 == -261262)
					{
						this.$self_$17778 = self_;
						if (141929 - 473757 != -331827)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0017C5B4 File Offset: 0x0017A7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_release$17776.$(this.$self_$17778);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0017C5C4 File Offset: 0x0017A7C4
		internal static bool kc5iZDokbrqaaRta7C9()
		{
			return true;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0017C5C8 File Offset: 0x0017A7C8
		internal static bool zKheLOoGXlTCwvHAbQ3()
		{
			return false;
		}

		// Token: 0x04000CE9 RID: 3305
		internal Ewiniar $self_$17778;

		// Token: 0x02000293 RID: 659
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F15 RID: 3861 RVA: 0x0017C5CC File Offset: 0x0017A7CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (247549 - 405765 != -158216)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80300 - 242960 != -162659)
					{
						base..ctor();
						if (38898 - 176929 == -138031)
						{
							this.$self_$17777 = self_;
							if (85879 - 531833 != -445953)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F16 RID: 3862 RVA: 0x0017C664 File Offset: 0x0017A864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111957 - 164007 != -52050)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_620;
					case 2:
						if (this.$self_$17777.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_75;
						}
						if (42124 - 447716 != -405592)
						{
							continue;
						}
						if (this.$self_$17777.JHgJZHTwOf.myCommand != "release")
						{
							if (89337 - 593031 != -503694)
							{
								continue;
							}
							goto IL_75;
						}
						else if (this.$self_$17777.release_ring)
						{
							if (203061 - 1522 == 201540)
							{
								continue;
							}
							this.$self_$17777.JHgJZHTwOf.createEffect(this.$self_$17777.release_ring, this.$self_$17777.transform.position + this.$self_$17777.transform.TransformDirection((float)-27, (float)0, (float)12), this.$self_$17777.transform.rotation);
							if (261391 - 170134 != 91257)
							{
								continue;
							}
							goto IL_58E;
						}
						else
						{
							Debug.LogError("Missing release ring effect");
							if (27838 - 391582 != -363743)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17777.JHgJZHTwOf.actionState == "attack")
						{
							if (171047 - 329585 == -158537)
							{
								continue;
							}
							if (this.$self_$17777.JHgJZHTwOf.myCommand == "release")
							{
								if (195294 - 317512 != -122218)
								{
									continue;
								}
								this.$self_$17777.JHgJZHTwOf.moveSpeed = (float)0;
								if (69199 - 396080 != -326881)
								{
									continue;
								}
								this.$self_$17777.JHgJZHTwOf.actionState = "swim";
								if (298105 - 381168 != -83063)
								{
									continue;
								}
								this.$self_$17777.JHgJZHTwOf.actionTime = Time.time;
								if (159312 - 245261 != -85949)
								{
									continue;
								}
								this.$self_$17777.JHgJZHTwOf.myCommand = "none";
								if (30597 - 34123 != -3526)
								{
									continue;
								}
								if (!this.$self_$17777.JHgJZHTwOf.isMine)
								{
									if (204056 - 197659 == 6398)
									{
										continue;
									}
									this.$self_$17777.JHgJZHTwOf.nPosition = this.$self_$17777.transform.position;
									if (18129 - 389728 == -371598)
									{
										continue;
									}
									this.$self_$17777.JHgJZHTwOf.oPosition = this.$self_$17777.transform.position;
									if (20699 - 517535 == -496835)
									{
										continue;
									}
									this.$self_$17777.JHgJZHTwOf.nDirection = this.$self_$17777.transform.forward;
									if (253610 - 315257 == -61646)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (294818 - 268095 != 26723)
						{
							continue;
						}
						goto IL_620;
					default:
						if (220534 - 409029 != -188495)
						{
							continue;
						}
						break;
					}
					this.$self_$17777.JHgJZHTwOf.actionState = "attack";
					if (91868 - 276829 != -184960)
					{
						this.$self_$17777.JHgJZHTwOf.actionTime = Time.time;
						if (295194 - 345432 == -50238)
						{
							this.$self_$17777.JHgJZHTwOf.myCommand = "release";
							if (174438 - 222455 != -48016)
							{
								this.$self_$17777.JHgJZHTwOf.addTimeOut("hold", 60f);
								if (8337 - 164190 == -155853)
								{
									this.$self_$17777.animation.Rewind();
									if (229927 - 94906 != 135022)
									{
										this.$self_$17777.animation.Play("release");
										if (176549 - 566603 != -390053)
										{
											this.$self_$17777.animation.wrapMode = WrapMode.Once;
											if (44339 - 329206 != -284866)
											{
												this.$self_$17777.JHgJZHTwOf.vMovement = this.$self_$17777.transform.forward;
												if (238096 - 222654 != 15443)
												{
													this.$self_$17777.JHgJZHTwOf.moveSpeed = (float)0;
													if (148469 - 492646 != -344176)
													{
														if (this.$self_$17777.ewiniar_cry)
														{
															if (114252 - 345253 == -231000)
															{
																continue;
															}
															this.$self_$17777.audio.PlayOneShot(this.$self_$17777.ewiniar_cry);
															if (249479 - 155335 != 94144)
															{
																continue;
															}
														}
														Camera.main.SendMessage("EwiniarReleaseEvent");
														if (26299 - 524590 == -498291)
														{
															goto IL_26E;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_75:
				goto IL_620;
				IL_26E:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_2EC:
				return this.Yield(3, new WaitForSeconds(4f));
				IL_58E:
				Block_35:
				goto IL_2EC;
				IL_620:
				return false;
			}

			// Token: 0x06000F17 RID: 3863 RVA: 0x0017CCA4 File Offset: 0x0017AEA4
			internal static bool Cy7sAloHRmQnhcdObg5()
			{
				return true;
			}

			// Token: 0x06000F18 RID: 3864 RVA: 0x0017CCA8 File Offset: 0x0017AEA8
			internal static bool w2uipPoW2CyAlSS16Lk()
			{
				return false;
			}

			// Token: 0x04000CEA RID: 3306
			internal Ewiniar $self_$17777;
		}
	}

	// Token: 0x02000294 RID: 660
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_waterBlast$17779 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x0017CCAC File Offset: 0x0017AEAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_waterBlast$17779(Ewiniar self_)
		{
			if (1983 - 272849 != -270865)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (50970 - 375224 != -324253)
				{
					base..ctor();
					if (190554 - 292954 == -102400)
					{
						this.$self_$17787 = self_;
						if (107852 - 93022 != 14831)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0017CD44 File Offset: 0x0017AF44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_waterBlast$17779.$(this.$self_$17787);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0017CD54 File Offset: 0x0017AF54
		internal static bool CTQuWooAIDm1U4HgJq6()
		{
			return true;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0017CD58 File Offset: 0x0017AF58
		internal static bool GkCyDfol0RsOYX66l3c()
		{
			return false;
		}

		// Token: 0x04000CEB RID: 3307
		internal Ewiniar $self_$17787;

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F1D RID: 3869 RVA: 0x0017CD5C File Offset: 0x0017AF5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (17419 - 277021 != -259601)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (15673 - 548220 == -532547)
					{
						base..ctor();
						if (263286 - 45050 != 218237)
						{
							this.$self_$17786 = self_;
							if (83004 - 584901 == -501897)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F1E RID: 3870 RVA: 0x0017CDF4 File Offset: 0x0017AFF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60307 - 64006 != -3698)
				{
				}
				for (;;)
				{
					IL_215:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_966;
					case 2:
						if (this.$self_$17786.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_572;
						}
						if (124745 - 458938 != -334193)
						{
							continue;
						}
						if (this.$self_$17786.JHgJZHTwOf.myCommand != "waterBlast")
						{
							if (157963 - 273724 != -115761)
							{
								continue;
							}
							goto IL_572;
						}
						else if (this.$self_$17786.waterBlast_ring)
						{
							if (234836 - 46559 == 188278)
							{
								continue;
							}
							this.$self_$17786.JHgJZHTwOf.createEffect(this.$self_$17786.waterBlast_ring, this.$self_$17786.transform.position + this.$self_$17786.transform.TransformDirection((float)0, (float)16, (float)-18), this.$self_$17786.transform.rotation);
							if (284713 - 68215 != 216499)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing waterBlast ring effect");
							if (275857 - 442136 != -166279)
							{
								continue;
							}
							goto IL_734;
						}
						break;
					case 3:
						if (this.$self_$17786.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_783;
						}
						if (215182 - 269908 == -54725)
						{
							continue;
						}
						if (this.$self_$17786.JHgJZHTwOf.myCommand != "waterBlast")
						{
							if (241827 - 309136 != -67309)
							{
								continue;
							}
							goto IL_783;
						}
						else
						{
							this.$i$17780 = 0;
							if (294229 - 500455 != -206226)
							{
								continue;
							}
							goto IL_3EB;
						}
						break;
					case 4:
						if (this.$self_$17786.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_7A9;
						}
						if (195816 - 517638 != -321822)
						{
							continue;
						}
						if (this.$self_$17786.JHgJZHTwOf.myCommand != "waterBlast")
						{
							if (103296 - 135476 != -32179)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$i$17780++;
							if (120876 - 49569 != 71308)
							{
								goto IL_3EB;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$17786.JHgJZHTwOf.actionState == "attack")
						{
							if (147543 - 430488 == -282944)
							{
								continue;
							}
							if (this.$self_$17786.JHgJZHTwOf.myCommand == "waterBlast")
							{
								if (63750 - 265634 == -201883)
								{
									continue;
								}
								this.$self_$17786.JHgJZHTwOf.moveSpeed = (float)0;
								if (47058 - 106859 != -59801)
								{
									continue;
								}
								this.$self_$17786.JHgJZHTwOf.actionState = "hold";
								if (269271 - 329863 != -60592)
								{
									continue;
								}
								this.$self_$17786.JHgJZHTwOf.actionTime = Time.time;
								if (196101 - 281277 == -85175)
								{
									continue;
								}
								this.$self_$17786.JHgJZHTwOf.myCommand = "none";
								if (50432 - 122550 == -72117)
								{
									continue;
								}
								if (!this.$self_$17786.JHgJZHTwOf.isMine)
								{
									if (253219 - 439754 == -186534)
									{
										continue;
									}
									this.$self_$17786.JHgJZHTwOf.nPosition = this.$self_$17786.transform.position;
									if (71590 - 151108 != -79518)
									{
										continue;
									}
									this.$self_$17786.JHgJZHTwOf.oPosition = this.$self_$17786.transform.position;
									if (196133 - 82935 != 113198)
									{
										continue;
									}
									this.$self_$17786.JHgJZHTwOf.nDirection = this.$self_$17786.transform.forward;
									if (261214 - 354288 != -93074)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (269205 - 5059 != 264146)
						{
							continue;
						}
						goto IL_966;
					default:
						if (62437 - 424637 == -362199)
						{
							continue;
						}
						break;
					}
					this.$self_$17786.JHgJZHTwOf.actionState = "attack";
					if (56189 - 90764 != -34575)
					{
						continue;
					}
					this.$self_$17786.JHgJZHTwOf.actionTime = Time.time;
					if (20312 - 393988 != -373676)
					{
						continue;
					}
					this.$self_$17786.JHgJZHTwOf.myCommand = "waterBlast";
					if (8590 - 442958 == -434367)
					{
						continue;
					}
					this.$self_$17786.JHgJZHTwOf.addTimeOut("nAttack", 6f);
					if (116171 - 451723 != -335552)
					{
						continue;
					}
					this.$self_$17786.animation.Rewind();
					if (170685 - 533890 != -363205)
					{
						continue;
					}
					this.$self_$17786.animation.Play("waterBlast");
					if (10721 - 411655 != -400934)
					{
						continue;
					}
					this.$self_$17786.animation.wrapMode = WrapMode.Once;
					if (175744 - 403603 == -227858)
					{
						continue;
					}
					this.$self_$17786.JHgJZHTwOf.vMovement = this.$self_$17786.transform.forward;
					if (127771 - 166394 == -38622)
					{
						continue;
					}
					this.$self_$17786.JHgJZHTwOf.moveSpeed = (float)0;
					if (96676 - 297490 != -200813)
					{
						goto Block_55;
					}
					continue;
					IL_3EB:
					if (this.$i$17780 >= 5)
					{
						if (28538 - 187714 != -159175)
						{
							break;
						}
					}
					else
					{
						if (!this.$self_$17786.JHgJZHTwOf.isMine)
						{
							goto IL_411;
						}
						if (192772 - 463388 != -270615)
						{
							this.$hitLayer$17781 = 130816 - (1 << this.$self_$17786.gameObject.layer);
							if (134628 - 97415 != 37214)
							{
								this.$hitPos$17782 = this.$self_$17786.transform.position + this.$self_$17786.transform.TransformDirection((float)0, (float)12, (float)(-30 + 6 * this.$i$17780));
								if (29577 - 289577 != -259999)
								{
									this.$hitList$17783 = Damage.FindRecTarget(this.$hitPos$17782, this.$self_$17786.transform.forward, (float)12, (float)12, (float)30, (float)30, this.$hitLayer$17781);
									if (88068 - 435092 == -347024)
									{
										this.$$iterator$10060$17785 = UnityRuntimeServices.GetEnumerator(this.$hitList$17783);
										if (138365 - 27138 == 111227)
										{
											while (this.$$iterator$10060$17785.MoveNext())
											{
												object obj2;
												object obj = obj2 = this.$$iterator$10060$17785.Current;
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												this.$hitObject$17784 = (GameObject)obj2;
												if (105006 - 437048 != -332042)
												{
													goto IL_215;
												}
												this.$self_$17786.JHgJZHTwOf.hit(11, this.$hitObject$17784, (int)(0.5f * (float)this.$self_$17786.JHgJZHTwOf.atk), 1, 0, (float)3 * this.$self_$17786.transform.forward);
												if (79045 - 455792 == -376746)
												{
													goto IL_215;
												}
												UnityRuntimeServices.Update(this.$$iterator$10060$17785, this.$hitObject$17784);
												if (161247 - 205716 != -44469)
												{
													goto IL_215;
												}
											}
											if (199777 - 552058 != -352280)
											{
												goto Block_30;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_411:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_30:
				goto IL_411;
				IL_572:
				goto IL_966;
				Block_38:
				IL_734:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_783:
				IL_7A9:
				goto IL_966;
				Block_54:
				goto IL_7A9;
				Block_55:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_966:
				return false;
			}

			// Token: 0x06000F1F RID: 3871 RVA: 0x0017D77C File Offset: 0x0017B97C
			internal static bool zNEehroykOCvJrmHb9i()
			{
				return true;
			}

			// Token: 0x06000F20 RID: 3872 RVA: 0x0017D780 File Offset: 0x0017B980
			internal static bool qMNqs4oSwYKcSlBubND()
			{
				return false;
			}

			// Token: 0x04000CEC RID: 3308
			internal int $i$17780;

			// Token: 0x04000CED RID: 3309
			internal int $hitLayer$17781;

			// Token: 0x04000CEE RID: 3310
			internal Vector3 $hitPos$17782;

			// Token: 0x04000CEF RID: 3311
			internal UnityScript.Lang.Array $hitList$17783;

			// Token: 0x04000CF0 RID: 3312
			internal GameObject $hitObject$17784;

			// Token: 0x04000CF1 RID: 3313
			internal IEnumerator $$iterator$10060$17785;

			// Token: 0x04000CF2 RID: 3314
			internal Ewiniar $self_$17786;
		}
	}

	// Token: 0x02000296 RID: 662
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_lightning$17788 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F21 RID: 3873 RVA: 0x0017D784 File Offset: 0x0017B984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_lightning$17788(Ewiniar self_)
		{
			if (111200 - 514762 != -403561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168764 - 561739 != -392974)
				{
					base..ctor();
					if (101506 - 523885 != -422378)
					{
						this.$self_$17797 = self_;
						if (195585 - 10689 != 184897)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0017D81C File Offset: 0x0017BA1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_lightning$17788.$(this.$self_$17797);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0017D82C File Offset: 0x0017BA2C
		internal static bool pAjXShoofa90CUMN6To()
		{
			return true;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0017D830 File Offset: 0x0017BA30
		internal static bool QK9vXFoEKFCeIEEJCv1()
		{
			return false;
		}

		// Token: 0x04000CF3 RID: 3315
		internal Ewiniar $self_$17797;

		// Token: 0x02000297 RID: 663
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F25 RID: 3877 RVA: 0x0017D834 File Offset: 0x0017BA34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (296620 - 371900 != -75280)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (178059 - 311303 == -133244)
					{
						base..ctor();
						if (32079 - 8712 != 23368)
						{
							this.$self_$17796 = self_;
							if (2984 - 543479 != -540494)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F26 RID: 3878 RVA: 0x0017D8CC File Offset: 0x0017BACC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237458 - 525497 != -288038)
				{
				}
				for (;;)
				{
					IL_817:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B32;
					case 2:
						if (this.$self_$17796.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_291;
						}
						if (275467 - 145794 != 129673)
						{
							continue;
						}
						if (!(this.$self_$17796.JHgJZHTwOf.myCommand != "lightning"))
						{
							goto IL_296;
						}
						if (277774 - 303657 != -25883)
						{
							continue;
						}
						goto IL_291;
					case 3:
						if (this.$self_$17796.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_7E3;
						}
						if (44056 - 333529 == -289472)
						{
							continue;
						}
						if (this.$self_$17796.JHgJZHTwOf.myCommand != "lightning")
						{
							if (6654 - 530244 != -523589)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (this.$self_$17796.lightning_ring)
							{
								if (56750 - 209480 == -152729)
								{
									continue;
								}
								this.$self_$17796.JHgJZHTwOf.createEffect(this.$self_$17796.lightning_ring, this.$self_$17796.transform.position, this.$self_$17796.transform.rotation);
								if (185345 - 463249 == -277903)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing lightning_ring ring effect");
								if (171000 - 162639 != 8361)
								{
									continue;
								}
							}
							this.$mCameraEffect$17789 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (258675 - 38181 != 220494)
							{
								continue;
							}
							this.$mCameraEffect$17789.AddColorRamp("whiteRamp", "none", (float)1, new Vector4((float)0, (float)0, 0.1f, 0.2f));
							if (221823 - 307618 == -85794)
							{
								continue;
							}
							if (!this.$self_$17796.JHgJZHTwOf.isMine)
							{
								goto IL_242;
							}
							if (163755 - 239710 != -75955)
							{
								continue;
							}
							this.$hitLayer$17790 = 130816 - (1 << this.$self_$17796.gameObject.layer);
							if (229187 - 410026 != -180839)
							{
								continue;
							}
							this.$hitList$17791 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$17796.transform.position, (float)80, (float)30, this.$hitLayer$17790));
							if (63017 - 226116 != -163099)
							{
								continue;
							}
							this.$hitCount$17792 = 0;
							if (114920 - 237213 == -122292)
							{
								continue;
							}
							this.$$iterator$10061$17795 = UnityRuntimeServices.GetEnumerator(global::Math.shuffleArray(this.$hitList$17791));
							if (89830 - 394776 != -304946)
							{
								continue;
							}
							while (this.$$iterator$10061$17795.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10061$17795.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17793 = (GameObject)obj2;
								if (132518 - 8395 == 124124)
								{
									goto IL_817;
								}
								if (this.$hitCount$17792 < 3)
								{
									if (151354 - 207255 == -55900)
									{
										goto IL_817;
									}
									this.$hitCount$17792++;
									if (172676 - 105849 != 66827)
									{
										goto IL_817;
									}
									if (this.$self_$17796.JHgJZHTwOf.hit(21, this.$hitObject$17793, this.$self_$17796.JHgJZHTwOf.talAdjust(120), 1, 0, Vector3.zero) != 0)
									{
										if (248699 - 321325 == -72625)
										{
											goto IL_817;
										}
										this.$hitChar$17794 = (CharacterControl)this.$hitObject$17793.GetComponent(typeof(CharacterControl));
										if (210846 - 412479 != -201633)
										{
											goto IL_817;
										}
										UnityRuntimeServices.Update(this.$$iterator$10061$17795, this.$hitObject$17793);
										if (172054 - 151701 != 20353)
										{
											goto IL_817;
										}
										if (this.$hitChar$17794)
										{
											if (216294 - 385121 == -168826)
											{
												goto IL_817;
											}
											if (!(this.$hitChar$17794.actionState == "standby"))
											{
												if (211974 - 369604 == -157629)
												{
													goto IL_817;
												}
												if (!(this.$hitChar$17794.actionState == "run"))
												{
													if (109950 - 591912 != -481962)
													{
														goto IL_817;
													}
													if (!(this.$hitChar$17794.actionState == "emotion"))
													{
														goto IL_66A;
													}
													if (117805 - 376694 != -258889)
													{
														goto IL_817;
													}
												}
											}
											this.$hitChar$17794.RPC_AddStatus("paralysis", 2, Damage.getDebuff((float)6, this.$self_$17796.JHgJZHTwOf.cha, this.$hitChar$17794.cha), 0, this.$self_$17796.JHgJZHTwOf.ActorNr);
											if (67049 - 251107 == -184057)
											{
												goto IL_817;
											}
										}
									}
									IL_66A:
									this.$self_$17796.RPC_lightning_hit(this.$hitObject$17793.transform.position, this.$self_$17796.transform.forward, 0);
									if (242886 - 185565 == 57322)
									{
										goto IL_817;
									}
									UnityRuntimeServices.Update(this.$$iterator$10061$17795, this.$hitObject$17793);
									if (81709 - 340384 == -258674)
									{
										goto IL_817;
									}
									if (PhotonClient.IsInitialized())
									{
										if (222538 - 122351 != 100187)
										{
											goto IL_817;
										}
										this.$self_$17796.ActionEvent("RPC_lightning_hit", this.$hitObject$17793.transform.position, this.$self_$17796.transform.forward, 0);
										if (206684 - 148007 == 58678)
										{
											goto IL_817;
										}
										UnityRuntimeServices.Update(this.$$iterator$10061$17795, this.$hitObject$17793);
										if (153981 - 461206 != -307225)
										{
											goto IL_817;
										}
									}
								}
							}
							if (262951 - 183713 != 79238)
							{
								continue;
							}
							goto IL_242;
						}
						break;
					case 4:
						if (this.$self_$17796.JHgJZHTwOf.actionState == "attack")
						{
							if (50249 - 524089 != -473840)
							{
								continue;
							}
							if (this.$self_$17796.JHgJZHTwOf.myCommand == "lightning")
							{
								if (81139 - 241698 != -160559)
								{
									continue;
								}
								this.$self_$17796.JHgJZHTwOf.moveSpeed = (float)0;
								if (103477 - 572803 == -469325)
								{
									continue;
								}
								this.$self_$17796.JHgJZHTwOf.actionState = "hold";
								if (288580 - 467730 == -179149)
								{
									continue;
								}
								this.$self_$17796.JHgJZHTwOf.actionTime = Time.time;
								if (214138 - 176195 == 37944)
								{
									continue;
								}
								this.$self_$17796.JHgJZHTwOf.myCommand = "none";
								if (35717 - 270862 == -235144)
								{
									continue;
								}
								if (!this.$self_$17796.JHgJZHTwOf.isMine)
								{
									if (130501 - 385697 == -255195)
									{
										continue;
									}
									this.$self_$17796.JHgJZHTwOf.nPosition = this.$self_$17796.transform.position;
									if (74232 - 425931 == -351698)
									{
										continue;
									}
									this.$self_$17796.JHgJZHTwOf.oPosition = this.$self_$17796.transform.position;
									if (47790 - 503279 != -455489)
									{
										continue;
									}
									this.$self_$17796.JHgJZHTwOf.nDirection = this.$self_$17796.transform.forward;
									if (228698 - 402247 != -173549)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (173017 - 262002 != -88985)
						{
							continue;
						}
						goto IL_B32;
					default:
						if (201957 - 249885 != -47928)
						{
							continue;
						}
						break;
					}
					this.$self_$17796.JHgJZHTwOf.actionState = "attack";
					if (55003 - 114132 != -59128)
					{
						this.$self_$17796.JHgJZHTwOf.actionTime = Time.time;
						if (70272 - 247369 == -177097)
						{
							this.$self_$17796.JHgJZHTwOf.myCommand = "lightning";
							if (284726 - 268671 == 16055)
							{
								this.$self_$17796.JHgJZHTwOf.addTimeOut("nAttack", 9f);
								if (128227 - 84226 != 44002)
								{
									this.$self_$17796.animation.Rewind();
									if (177552 - 391980 != -214427)
									{
										this.$self_$17796.animation.Play("cast");
										if (224011 - 115246 == 108765)
										{
											this.$self_$17796.animation.wrapMode = WrapMode.Once;
											if (276659 - 46735 != 229925)
											{
												this.$self_$17796.JHgJZHTwOf.vMovement = this.$self_$17796.transform.forward;
												if (203865 - 546652 != -342786)
												{
													this.$self_$17796.JHgJZHTwOf.moveSpeed = (float)0;
													if (184612 - 319109 != -134496)
													{
														goto Block_65;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_242:
				return this.Yield(4, new WaitForSeconds(1.5f));
				IL_291:
				goto IL_B32;
				IL_296:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_48:
				IL_7E3:
				goto IL_B32;
				Block_65:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_B32:
				return false;
			}

			// Token: 0x06000F27 RID: 3879 RVA: 0x0017E420 File Offset: 0x0017C620
			internal static bool PlKVEDo2mAYPME0Slut()
			{
				return true;
			}

			// Token: 0x06000F28 RID: 3880 RVA: 0x0017E424 File Offset: 0x0017C624
			internal static bool G3V24io8NbkibrZtq2D()
			{
				return false;
			}

			// Token: 0x04000CF4 RID: 3316
			internal CameraEffect $mCameraEffect$17789;

			// Token: 0x04000CF5 RID: 3317
			internal int $hitLayer$17790;

			// Token: 0x04000CF6 RID: 3318
			internal UnityScript.Lang.Array $hitList$17791;

			// Token: 0x04000CF7 RID: 3319
			internal int $hitCount$17792;

			// Token: 0x04000CF8 RID: 3320
			internal GameObject $hitObject$17793;

			// Token: 0x04000CF9 RID: 3321
			internal CharacterControl $hitChar$17794;

			// Token: 0x04000CFA RID: 3322
			internal IEnumerator $$iterator$10061$17795;

			// Token: 0x04000CFB RID: 3323
			internal Ewiniar $self_$17796;
		}
	}

	// Token: 0x02000298 RID: 664
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cyclone$17798 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0017E428 File Offset: 0x0017C628
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cyclone$17798(Ewiniar self_)
		{
			if (29554 - 335511 != -305956)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76270 - 356912 != -280641)
				{
					base..ctor();
					if (74501 - 498641 != -424139)
					{
						this.$self_$17806 = self_;
						if (166659 - 97148 != 69512)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0017E4C0 File Offset: 0x0017C6C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_cyclone$17798.$(this.$self_$17806);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0017E4D0 File Offset: 0x0017C6D0
		internal static bool pnTHl5oZX35Gw7RDGI5()
		{
			return true;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0017E4D4 File Offset: 0x0017C6D4
		internal static bool U8v0QyoCpJtotK7omme()
		{
			return false;
		}

		// Token: 0x04000CFC RID: 3324
		internal Ewiniar $self_$17806;

		// Token: 0x02000299 RID: 665
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F2D RID: 3885 RVA: 0x0017E4D8 File Offset: 0x0017C6D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (155995 - 305292 != -149296)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25600 - 298956 != -273355)
					{
						base..ctor();
						if (45743 - 580790 == -535047)
						{
							this.$self_$17805 = self_;
							if (47915 - 171309 == -123394)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F2E RID: 3886 RVA: 0x0017E570 File Offset: 0x0017C770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130343 - 236317 != -105973)
				{
				}
				for (;;)
				{
					IL_446:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8C5;
					case 2:
						if (this.$self_$17805.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_AF;
						}
						if (240824 - 223467 == 17358)
						{
							continue;
						}
						if (this.$self_$17805.JHgJZHTwOf.myCommand != "cyclone")
						{
							if (287724 - 149049 != 138676)
							{
								goto Block_53;
							}
							continue;
						}
						else if (this.$self_$17805.cyclone_ring)
						{
							if (13079 - 481722 != -468643)
							{
								continue;
							}
							this.$self_$17805.JHgJZHTwOf.createEffect(this.$self_$17805.cyclone_ring, this.$self_$17805.transform.position, this.$self_$17805.transform.rotation);
							if (20150 - 193695 != -173544)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing cyclone_ring ring effect");
							if (212726 - 102765 != 109961)
							{
								continue;
							}
							goto IL_E3;
						}
						break;
					case 3:
						if (this.$self_$17805.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_5D7;
						}
						if (212490 - 125651 == 86840)
						{
							continue;
						}
						if (this.$self_$17805.JHgJZHTwOf.myCommand != "cyclone")
						{
							if (241067 - 526502 != -285435)
							{
								continue;
							}
							goto IL_5D7;
						}
						else
						{
							this.$hitLayer$17799 = 130816 - (1 << this.$self_$17805.gameObject.layer);
							if (203500 - 490638 == -287137)
							{
								continue;
							}
							this.$hitList$17800 = Damage.RemoveDeadChar(Damage.FindPlayerTarget(this.$self_$17805.transform.position, (float)80, this.$hitLayer$17799));
							if (22383 - 309657 == -287273)
							{
								continue;
							}
							this.$$iterator$10062$17804 = UnityRuntimeServices.GetEnumerator(this.$hitList$17800);
							if (72555 - 533055 != -460500)
							{
								continue;
							}
							while (this.$$iterator$10062$17804.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10062$17804.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17801 = (GameObject)obj2;
								if (8814 - 272258 != -263444)
								{
									goto IL_446;
								}
								if (this.$self_$17805.cyclone)
								{
									if (136830 - 209939 != -73109)
									{
										goto IL_446;
									}
									this.$mCyclone$17802 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$17805.cyclone, this.$hitObject$17801.transform.position, Quaternion.identity);
									if (22172 - 296114 == -273941)
									{
										goto IL_446;
									}
									UnityRuntimeServices.Update(this.$$iterator$10062$17804, this.$hitObject$17801);
									if (15230 - 150662 != -135432)
									{
										goto IL_446;
									}
									if (this.$mCyclone$17802)
									{
										if (288095 - 3879 != 284216)
										{
											goto IL_446;
										}
										this.$mCycloneScript$17803 = (Ewiniar_cyclone)this.$mCyclone$17802.GetComponent(typeof(Ewiniar_cyclone));
										if (236309 - 314243 == -77933)
										{
											goto IL_446;
										}
										if (this.$mCycloneScript$17803)
										{
											if (15535 - 565050 != -549515)
											{
												goto IL_446;
											}
											this.$mCycloneScript$17803.StartCoroutine_Auto(this.$mCycloneScript$17803.Init(this.$self_$17805.gameObject, this.$hitObject$17801));
											if (31987 - 63030 != -31043)
											{
												goto IL_446;
											}
											UnityRuntimeServices.Update(this.$$iterator$10062$17804, this.$hitObject$17801);
											if (299150 - 438210 == -139059)
											{
												goto IL_446;
											}
										}
									}
								}
							}
							if (215461 - 293959 != -78498)
							{
								continue;
							}
							goto IL_657;
						}
						break;
					case 4:
						if (this.$self_$17805.JHgJZHTwOf.actionState == "attack")
						{
							if (75883 - 53585 == 22299)
							{
								continue;
							}
							if (this.$self_$17805.JHgJZHTwOf.myCommand == "cyclone")
							{
								if (66350 - 264454 == -198103)
								{
									continue;
								}
								this.$self_$17805.JHgJZHTwOf.moveSpeed = (float)0;
								if (259913 - 55987 != 203926)
								{
									continue;
								}
								this.$self_$17805.JHgJZHTwOf.actionState = "hold";
								if (237626 - 153407 != 84219)
								{
									continue;
								}
								this.$self_$17805.JHgJZHTwOf.actionTime = Time.time;
								if (20416 - 546342 == -525925)
								{
									continue;
								}
								this.$self_$17805.JHgJZHTwOf.myCommand = "none";
								if (182594 - 549404 == -366809)
								{
									continue;
								}
								if (!this.$self_$17805.JHgJZHTwOf.isMine)
								{
									if (148768 - 239156 != -90388)
									{
										continue;
									}
									this.$self_$17805.JHgJZHTwOf.nPosition = this.$self_$17805.transform.position;
									if (16380 - 538527 != -522147)
									{
										continue;
									}
									this.$self_$17805.JHgJZHTwOf.oPosition = this.$self_$17805.transform.position;
									if (93689 - 340906 != -247217)
									{
										continue;
									}
									this.$self_$17805.JHgJZHTwOf.nDirection = this.$self_$17805.transform.forward;
									if (26537 - 483916 == -457378)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (210223 - 330079 != -119856)
						{
							continue;
						}
						goto IL_8C5;
					default:
						if (213096 - 25958 != 187138)
						{
							continue;
						}
						break;
					}
					this.$self_$17805.JHgJZHTwOf.actionState = "attack";
					if (245147 - 509833 == -264686)
					{
						this.$self_$17805.JHgJZHTwOf.actionTime = Time.time;
						if (262460 - 309720 != -47259)
						{
							this.$self_$17805.JHgJZHTwOf.myCommand = "cyclone";
							if (15681 - 244738 != -229056)
							{
								this.$self_$17805.JHgJZHTwOf.addTimeOut("cyclone", 24f);
								if (13418 - 21511 == -8093)
								{
									this.$self_$17805.animation.Rewind();
									if (123854 - 582632 != -458777)
									{
										this.$self_$17805.animation.Play("cast");
										if (207170 - 211214 == -4044)
										{
											this.$self_$17805.animation.wrapMode = WrapMode.Once;
											if (157518 - 295400 != -137881)
											{
												this.$self_$17805.JHgJZHTwOf.vMovement = this.$self_$17805.transform.forward;
												if (56549 - 537967 == -481418)
												{
													this.$self_$17805.JHgJZHTwOf.moveSpeed = (float)0;
													if (257415 - 543701 == -286286)
													{
														goto IL_588;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AF:
				goto IL_8C5;
				IL_E3:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_35:
				goto IL_E3;
				IL_588:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_5D7:
				goto IL_8C5;
				IL_657:
				return this.Yield(4, new WaitForSeconds(1.5f));
				Block_53:
				IL_8C5:
				return false;
			}

			// Token: 0x06000F2F RID: 3887 RVA: 0x0017EE54 File Offset: 0x0017D054
			internal static bool jGjR1AoL6tPguC0E7gx()
			{
				return true;
			}

			// Token: 0x06000F30 RID: 3888 RVA: 0x0017EE58 File Offset: 0x0017D058
			internal static bool Up5mdboO81pKbH2kowf()
			{
				return false;
			}

			// Token: 0x04000CFD RID: 3325
			internal int $hitLayer$17799;

			// Token: 0x04000CFE RID: 3326
			internal UnityScript.Lang.Array $hitList$17800;

			// Token: 0x04000CFF RID: 3327
			internal GameObject $hitObject$17801;

			// Token: 0x04000D00 RID: 3328
			internal GameObject $mCyclone$17802;

			// Token: 0x04000D01 RID: 3329
			internal Ewiniar_cyclone $mCycloneScript$17803;

			// Token: 0x04000D02 RID: 3330
			internal IEnumerator $$iterator$10062$17804;

			// Token: 0x04000D03 RID: 3331
			internal Ewiniar $self_$17805;
		}
	}

	// Token: 0x0200029A RID: 666
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_followLeft$17807 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x0017EE5C File Offset: 0x0017D05C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_followLeft$17807(Ewiniar self_)
		{
			if (161945 - 579612 != -417666)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88594 - 179003 == -90409)
				{
					base..ctor();
					if (177258 - 45385 == 131873)
					{
						this.$self_$17816 = self_;
						if (1907 - 306547 == -304640)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0017EEF4 File Offset: 0x0017D0F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_followLeft$17807.$(this.$self_$17816);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0017EF04 File Offset: 0x0017D104
		internal static bool Hv1snjomS8KDV9HabsS()
		{
			return true;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0017EF08 File Offset: 0x0017D108
		internal static bool ayHHE9oFBmkiW4PMbnD()
		{
			return false;
		}

		// Token: 0x04000D04 RID: 3332
		internal Ewiniar $self_$17816;

		// Token: 0x0200029B RID: 667
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F35 RID: 3893 RVA: 0x0017EF0C File Offset: 0x0017D10C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (144472 - 270924 != -126451)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (38142 - 56346 != -18203)
					{
						base..ctor();
						if (27254 - 198107 == -170853)
						{
							this.$self_$17815 = self_;
							if (166488 - 352934 != -186445)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F36 RID: 3894 RVA: 0x0017EFA4 File Offset: 0x0017D1A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191958 - 101975 != 89983)
				{
				}
				for (;;)
				{
					IL_809:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D2D;
					case 2:
						if (this.$self_$17815.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_2EB;
						}
						if (258612 - 39504 == 219109)
						{
							continue;
						}
						if (this.$self_$17815.JHgJZHTwOf.myCommand != "followLeft")
						{
							if (170818 - 139587 != 31232)
							{
								goto Block_72;
							}
							continue;
						}
						else if (this.$self_$17815.follow_ring1)
						{
							if (63747 - 433582 != -369835)
							{
								continue;
							}
							this.$self_$17815.JHgJZHTwOf.createEffect(this.$self_$17815.follow_ring1, this.$self_$17815.transform.position + this.$self_$17815.transform.TransformDirection((float)20, (float)0, (float)60), this.$self_$17815.transform.rotation);
							if (164222 - 347930 != -183708)
							{
								continue;
							}
							goto IL_7E0;
						}
						else
						{
							Debug.LogError("Missing follow_ring1 effect");
							if (75810 - 512059 != -436249)
							{
								continue;
							}
							goto IL_9BA;
						}
						break;
					case 3:
						if (this.$self_$17815.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_A38;
						}
						if (74379 - 576707 != -502328)
						{
							continue;
						}
						if (this.$self_$17815.JHgJZHTwOf.myCommand != "followLeft")
						{
							if (296266 - 4503 != 291763)
							{
								continue;
							}
							goto IL_A38;
						}
						else
						{
							if (this.$self_$17815.lightning_ring)
							{
								if (134841 - 28864 != 105977)
								{
									continue;
								}
								this.$self_$17815.JHgJZHTwOf.createEffect(this.$self_$17815.lightning_ring, this.$self_$17815.transform.position, this.$self_$17815.transform.rotation);
								if (78061 - 426323 == -348261)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing lightning_ring ring effect");
								if (290560 - 189934 == 100627)
								{
									continue;
								}
							}
							this.$mCameraEffect$17808 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (233353 - 446547 != -213194)
							{
								continue;
							}
							this.$mCameraEffect$17808.AddColorRamp("whiteRamp", "none", (float)1, new Vector4((float)0, (float)0, 0.1f, 0.2f));
							if (182701 - 213468 != -30767)
							{
								continue;
							}
							if (!this.$self_$17815.JHgJZHTwOf.isMine)
							{
								goto IL_424;
							}
							if (284018 - 199187 != 84831)
							{
								continue;
							}
							this.$hitLayer$17809 = 130816 - (1 << this.$self_$17815.gameObject.layer);
							if (242472 - 512788 != -270316)
							{
								continue;
							}
							this.$hitList$17810 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$17815.transform.position, (float)80, (float)30, this.$hitLayer$17809));
							if (213635 - 148657 == 64979)
							{
								continue;
							}
							this.$hitCount$17811 = 0;
							if (212451 - 246359 != -33908)
							{
								continue;
							}
							this.$$iterator$10063$17814 = UnityRuntimeServices.GetEnumerator(global::Math.shuffleArray(this.$hitList$17810));
							if (131469 - 346048 == -214578)
							{
								continue;
							}
							while (this.$$iterator$10063$17814.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10063$17814.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17812 = (GameObject)obj2;
								if (278944 - 73965 == 204980)
								{
									goto IL_809;
								}
								if (this.$hitCount$17811 < 3)
								{
									if (181679 - 130122 != 51557)
									{
										goto IL_809;
									}
									this.$hitCount$17811++;
									if (222429 - 230946 == -8516)
									{
										goto IL_809;
									}
									if (this.$self_$17815.JHgJZHTwOf.hit(21, this.$hitObject$17812, this.$self_$17815.JHgJZHTwOf.talAdjust(120), 1, 0, Vector3.zero) != 0)
									{
										if (152989 - 177384 == -24394)
										{
											goto IL_809;
										}
										this.$hitChar$17813 = (CharacterControl)this.$hitObject$17812.GetComponent(typeof(CharacterControl));
										if (289746 - 67720 == 222027)
										{
											goto IL_809;
										}
										UnityRuntimeServices.Update(this.$$iterator$10063$17814, this.$hitObject$17812);
										if (125891 - 366176 == -240284)
										{
											goto IL_809;
										}
										if (this.$hitChar$17813)
										{
											if (178811 - 356254 != -177443)
											{
												goto IL_809;
											}
											if (!(this.$hitChar$17813.actionState == "standby"))
											{
												if (115622 - 177194 != -61572)
												{
													goto IL_809;
												}
												if (!(this.$hitChar$17813.actionState == "run"))
												{
													if (57770 - 7842 != 49928)
													{
														goto IL_809;
													}
													if (!(this.$hitChar$17813.actionState == "emotion"))
													{
														goto IL_691;
													}
													if (249962 - 312112 != -62150)
													{
														goto IL_809;
													}
												}
											}
											this.$hitChar$17813.RPC_AddStatus("paralysis", 2, 3, 0, this.$self_$17815.JHgJZHTwOf.ActorNr);
											if (29863 - 386585 == -356721)
											{
												goto IL_809;
											}
										}
									}
									IL_691:
									this.$self_$17815.RPC_lightning_hit(this.$hitObject$17812.transform.position, this.$self_$17815.transform.forward, 0);
									if (8866 - 458227 == -449360)
									{
										goto IL_809;
									}
									UnityRuntimeServices.Update(this.$$iterator$10063$17814, this.$hitObject$17812);
									if (230400 - 160805 != 69595)
									{
										goto IL_809;
									}
									if (PhotonClient.IsInitialized())
									{
										if (97645 - 175875 != -78230)
										{
											goto IL_809;
										}
										this.$self_$17815.ActionEvent("RPC_lightning_hit", this.$hitObject$17812.transform.position, this.$self_$17815.transform.forward, 0);
										if (131825 - 437640 != -305815)
										{
											goto IL_809;
										}
										UnityRuntimeServices.Update(this.$$iterator$10063$17814, this.$hitObject$17812);
										if (111153 - 456423 != -345270)
										{
											goto IL_809;
										}
									}
								}
							}
							if (285672 - 232947 != 52725)
							{
								continue;
							}
							goto IL_424;
						}
						break;
					case 4:
						if (this.$self_$17815.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_3AC;
						}
						if (299755 - 142972 == 156784)
						{
							continue;
						}
						if (this.$self_$17815.JHgJZHTwOf.myCommand != "followLeft")
						{
							if (123843 - 457290 != -333446)
							{
								goto Block_35;
							}
							continue;
						}
						else if (this.$self_$17815.follow_ring2)
						{
							if (151575 - 317086 != -165511)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$17815.follow_ring2, this.$self_$17815.transform.position + this.$self_$17815.transform.TransformDirection((float)20, (float)0, (float)60), this.$self_$17815.transform.rotation);
							if (67935 - 283214 != -215279)
							{
								continue;
							}
							goto IL_349;
						}
						else
						{
							Debug.LogError("Missing follow_ring2 effect");
							if (22569 - 560604 != -538035)
							{
								continue;
							}
							goto IL_268;
						}
						break;
					case 5:
						if (this.$self_$17815.JHgJZHTwOf.actionState == "attack")
						{
							if (195304 - 393330 == -198025)
							{
								continue;
							}
							if (this.$self_$17815.JHgJZHTwOf.myCommand == "followLeft")
							{
								if (272499 - 22978 != 249521)
								{
									continue;
								}
								this.$self_$17815.JHgJZHTwOf.moveSpeed = (float)0;
								if (231587 - 259541 == -27953)
								{
									continue;
								}
								this.$self_$17815.JHgJZHTwOf.actionState = "swim";
								if (85948 - 286152 == -200203)
								{
									continue;
								}
								this.$self_$17815.JHgJZHTwOf.actionTime = Time.time;
								if (120123 - 343676 != -223553)
								{
									continue;
								}
								this.$self_$17815.JHgJZHTwOf.myCommand = "none";
								if (180648 - 577253 == -396604)
								{
									continue;
								}
								if (!this.$self_$17815.JHgJZHTwOf.isMine)
								{
									if (4404 - 380677 == -376272)
									{
										continue;
									}
									this.$self_$17815.JHgJZHTwOf.nPosition = this.$self_$17815.transform.position;
									if (293583 - 547501 == -253917)
									{
										continue;
									}
									this.$self_$17815.JHgJZHTwOf.oPosition = this.$self_$17815.transform.position;
									if (280822 - 89174 == 191649)
									{
										continue;
									}
									this.$self_$17815.JHgJZHTwOf.nDirection = this.$self_$17815.transform.forward;
									if (57508 - 473986 == -416477)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (169500 - 131340 != 38160)
						{
							continue;
						}
						goto IL_D2D;
					default:
						if (107503 - 321135 == -213631)
						{
							continue;
						}
						break;
					}
					this.$self_$17815.JHgJZHTwOf.actionState = "attack";
					if (181794 - 81823 == 99971)
					{
						this.$self_$17815.JHgJZHTwOf.actionTime = Time.time;
						if (293118 - 255511 == 37607)
						{
							this.$self_$17815.JHgJZHTwOf.myCommand = "followLeft";
							if (297404 - 4925 != 292480)
							{
								this.$self_$17815.JHgJZHTwOf.addTimeOut("follow", 30f);
								if (119352 - 491621 != -372268)
								{
									this.$self_$17815.animation.Rewind();
									if (126609 - 486337 != -359727)
									{
										this.$self_$17815.animation.Play("followLeft");
										if (297245 - 456417 != -159171)
										{
											this.$self_$17815.animation.wrapMode = WrapMode.Once;
											if (108650 - 344305 != -235654)
											{
												this.$self_$17815.JHgJZHTwOf.vMovement = this.$self_$17815.transform.forward;
												if (193833 - 152410 == 41423)
												{
													this.$self_$17815.JHgJZHTwOf.moveSpeed = (float)0;
													if (261338 - 164740 == 96598)
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
				return this.Yield(2, new WaitForSeconds(2f));
				IL_268:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_2EB:
				goto IL_D2D;
				IL_349:
				goto IL_268;
				IL_3AC:
				goto IL_D2D;
				IL_424:
				return this.Yield(4, new WaitForSeconds(8f));
				Block_35:
				goto IL_3AC;
				IL_7E0:
				IL_9BA:
				return this.Yield(3, new WaitForSeconds(6f));
				IL_A38:
				Block_72:
				IL_D2D:
				return false;
			}

			// Token: 0x06000F37 RID: 3895 RVA: 0x0017FCF0 File Offset: 0x0017DEF0
			internal static bool r0t8HloMwqViNBZVnqn()
			{
				return true;
			}

			// Token: 0x06000F38 RID: 3896 RVA: 0x0017FCF4 File Offset: 0x0017DEF4
			internal static bool KMCVIuoxUyOiEF6v1Sw()
			{
				return false;
			}

			// Token: 0x04000D05 RID: 3333
			internal CameraEffect $mCameraEffect$17808;

			// Token: 0x04000D06 RID: 3334
			internal int $hitLayer$17809;

			// Token: 0x04000D07 RID: 3335
			internal UnityScript.Lang.Array $hitList$17810;

			// Token: 0x04000D08 RID: 3336
			internal int $hitCount$17811;

			// Token: 0x04000D09 RID: 3337
			internal GameObject $hitObject$17812;

			// Token: 0x04000D0A RID: 3338
			internal CharacterControl $hitChar$17813;

			// Token: 0x04000D0B RID: 3339
			internal IEnumerator $$iterator$10063$17814;

			// Token: 0x04000D0C RID: 3340
			internal Ewiniar $self_$17815;
		}
	}

	// Token: 0x0200029C RID: 668
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_followRight$17817 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x0017FCF8 File Offset: 0x0017DEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_followRight$17817(Ewiniar self_)
		{
			if (176463 - 324435 != -147971)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165762 - 418233 != -252470)
				{
					base..ctor();
					if (66163 - 108178 != -42014)
					{
						this.$self_$17825 = self_;
						if (196412 - 117426 != 78987)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0017FD90 File Offset: 0x0017DF90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_followRight$17817.$(this.$self_$17825);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0017FDA0 File Offset: 0x0017DFA0
		internal static bool dVBLuyogJpIo1riLWay()
		{
			return true;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0017FDA4 File Offset: 0x0017DFA4
		internal static bool luiYhXofVpkbTk3mjB9()
		{
			return false;
		}

		// Token: 0x04000D0D RID: 3341
		internal Ewiniar $self_$17825;

		// Token: 0x0200029D RID: 669
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F3D RID: 3901 RVA: 0x0017FDA8 File Offset: 0x0017DFA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar self_)
			{
				if (201054 - 444721 != -243667)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (223818 - 369627 == -145809)
					{
						base..ctor();
						if (136133 - 88582 == 47551)
						{
							this.$self_$17824 = self_;
							if (100605 - 280815 != -180209)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000F3E RID: 3902 RVA: 0x0017FE40 File Offset: 0x0017E040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227098 - 434092 != -206993)
				{
				}
				for (;;)
				{
					IL_63C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A3E;
					case 2:
						if (this.$self_$17824.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_595;
						}
						if (98598 - 54716 != 43882)
						{
							continue;
						}
						if (this.$self_$17824.JHgJZHTwOf.myCommand != "followRight")
						{
							if (139272 - 137485 != 1788)
							{
								goto Block_14;
							}
							continue;
						}
						else if (this.$self_$17824.follow_ring1)
						{
							if (104069 - 556550 != -452481)
							{
								continue;
							}
							this.$self_$17824.JHgJZHTwOf.createEffect(this.$self_$17824.follow_ring1, this.$self_$17824.transform.position + this.$self_$17824.transform.TransformDirection((float)-20, (float)0, (float)60), this.$self_$17824.transform.rotation);
							if (50456 - 5034 != 45422)
							{
								continue;
							}
							goto IL_72B;
						}
						else
						{
							Debug.LogError("Missing follow_ring1 effect");
							if (105407 - 2911 != 102497)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17824.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_9A8;
						}
						if (76974 - 328801 == -251826)
						{
							continue;
						}
						if (this.$self_$17824.JHgJZHTwOf.myCommand != "followRight")
						{
							if (218002 - 302012 != -84009)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17818 = 130816 - (1 << this.$self_$17824.gameObject.layer);
							if (152483 - 6287 == 146197)
							{
								continue;
							}
							this.$hitList$17819 = Damage.RemoveDeadChar(Damage.FindPlayerTarget(this.$self_$17824.transform.position, (float)80, this.$hitLayer$17818));
							if (294692 - 330782 == -36089)
							{
								continue;
							}
							this.$$iterator$10064$17823 = UnityRuntimeServices.GetEnumerator(this.$hitList$17819);
							if (82096 - 284266 != -202170)
							{
								continue;
							}
							while (this.$$iterator$10064$17823.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10064$17823.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17820 = (GameObject)obj2;
								if (297413 - 473521 != -176108)
								{
									goto IL_63C;
								}
								if (this.$self_$17824.cyclone)
								{
									if (232226 - 231491 != 735)
									{
										goto IL_63C;
									}
									this.$mCyclone$17821 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$17824.cyclone, this.$hitObject$17820.transform.position, Quaternion.identity);
									if (122855 - 588768 != -465913)
									{
										goto IL_63C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10064$17823, this.$hitObject$17820);
									if (122782 - 415638 != -292856)
									{
										goto IL_63C;
									}
									if (this.$mCyclone$17821)
									{
										if (256329 - 308265 != -51936)
										{
											goto IL_63C;
										}
										this.$mCycloneScript$17822 = (Ewiniar_cyclone)this.$mCyclone$17821.GetComponent(typeof(Ewiniar_cyclone));
										if (185849 - 388069 != -202220)
										{
											goto IL_63C;
										}
										if (this.$mCycloneScript$17822)
										{
											if (249573 - 578947 == -329373)
											{
												goto IL_63C;
											}
											this.$mCycloneScript$17822.StartCoroutine_Auto(this.$mCycloneScript$17822.Init(this.$self_$17824.gameObject, this.$hitObject$17820));
											if (256677 - 483876 != -227199)
											{
												goto IL_63C;
											}
											UnityRuntimeServices.Update(this.$$iterator$10064$17823, this.$hitObject$17820);
											if (162729 - 39835 == 122895)
											{
												goto IL_63C;
											}
										}
									}
								}
							}
							if (157122 - 550312 != -393189)
							{
								goto Block_61;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17824.JHgJZHTwOf.actionState != "attack")
						{
							goto IL_6F7;
						}
						if (185550 - 317907 == -132356)
						{
							continue;
						}
						if (this.$self_$17824.JHgJZHTwOf.myCommand != "followRight")
						{
							if (121236 - 171854 != -50617)
							{
								goto Block_30;
							}
							continue;
						}
						else if (this.$self_$17824.follow_ring2)
						{
							if (186325 - 213564 != -27239)
							{
								continue;
							}
							this.$self_$17824.JHgJZHTwOf.createEffect(this.$self_$17824.follow_ring2, this.$self_$17824.transform.position + this.$self_$17824.transform.TransformDirection((float)-20, (float)0, (float)60), this.$self_$17824.transform.rotation);
							if (201228 - 485153 != -283925)
							{
								continue;
							}
							goto IL_5C9;
						}
						else
						{
							Debug.LogError("Missing follow_ring2 effect");
							if (95455 - 158878 != -63422)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$17824.JHgJZHTwOf.actionState == "attack")
						{
							if (298214 - 27650 == 270565)
							{
								continue;
							}
							if (this.$self_$17824.JHgJZHTwOf.myCommand == "followRight")
							{
								if (145269 - 174344 == -29074)
								{
									continue;
								}
								this.$self_$17824.JHgJZHTwOf.moveSpeed = (float)0;
								if (135714 - 441181 == -305466)
								{
									continue;
								}
								this.$self_$17824.JHgJZHTwOf.actionState = "swim";
								if (71398 - 124072 != -52674)
								{
									continue;
								}
								this.$self_$17824.JHgJZHTwOf.actionTime = Time.time;
								if (161423 - 518516 == -357092)
								{
									continue;
								}
								this.$self_$17824.JHgJZHTwOf.myCommand = "none";
								if (159262 - 570925 == -411662)
								{
									continue;
								}
								if (!this.$self_$17824.JHgJZHTwOf.isMine)
								{
									if (211598 - 21508 != 190090)
									{
										continue;
									}
									this.$self_$17824.JHgJZHTwOf.nPosition = this.$self_$17824.transform.position;
									if (203875 - 361774 == -157898)
									{
										continue;
									}
									this.$self_$17824.JHgJZHTwOf.oPosition = this.$self_$17824.transform.position;
									if (239955 - 400762 != -160807)
									{
										continue;
									}
									this.$self_$17824.JHgJZHTwOf.nDirection = this.$self_$17824.transform.forward;
									if (93537 - 347081 != -253544)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (37981 - 530560 != -492579)
						{
							continue;
						}
						goto IL_A3E;
					default:
						if (183073 - 37485 == 145589)
						{
							continue;
						}
						break;
					}
					this.$self_$17824.JHgJZHTwOf.actionState = "attack";
					if (90558 - 55290 != 35269)
					{
						this.$self_$17824.JHgJZHTwOf.actionTime = Time.time;
						if (190404 - 508937 == -318533)
						{
							this.$self_$17824.JHgJZHTwOf.myCommand = "followRight";
							if (241019 - 441191 != -200171)
							{
								this.$self_$17824.JHgJZHTwOf.addTimeOut("follow", 30f);
								if (200414 - 138732 != 61683)
								{
									this.$self_$17824.animation.Rewind();
									if (185167 - 74314 != 110854)
									{
										this.$self_$17824.animation.Play("followRight");
										if (54077 - 383819 == -329742)
										{
											this.$self_$17824.animation.wrapMode = WrapMode.Once;
											if (240094 - 469157 != -229062)
											{
												this.$self_$17824.JHgJZHTwOf.vMovement = this.$self_$17824.transform.forward;
												if (254885 - 73724 != 181162)
												{
													this.$self_$17824.JHgJZHTwOf.moveSpeed = (float)0;
													if (293806 - 90931 == 202875)
													{
														goto IL_361;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_8D:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_12B:
				return this.Yield(3, new WaitForSeconds(6f));
				Block_14:
				Block_21:
				goto IL_9A8;
				IL_361:
				return this.Yield(2, new WaitForSeconds(2f));
				Block_30:
				IL_595:
				goto IL_A3E;
				IL_5C9:
				Block_39:
				goto IL_8D;
				IL_6F7:
				goto IL_A3E;
				IL_72B:
				Block_47:
				goto IL_12B;
				IL_9A8:
				goto IL_A3E;
				Block_61:
				return this.Yield(4, new WaitForSeconds(8f));
				IL_A3E:
				return false;
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x001808A0 File Offset: 0x0017EAA0
			internal static bool T5lbdConrtJKGkoKMIF()
			{
				return true;
			}

			// Token: 0x06000F40 RID: 3904 RVA: 0x001808A4 File Offset: 0x0017EAA4
			internal static bool nOn3bNo6W1Yllv9gkon()
			{
				return false;
			}

			// Token: 0x04000D0E RID: 3342
			internal int $hitLayer$17818;

			// Token: 0x04000D0F RID: 3343
			internal UnityScript.Lang.Array $hitList$17819;

			// Token: 0x04000D10 RID: 3344
			internal GameObject $hitObject$17820;

			// Token: 0x04000D11 RID: 3345
			internal GameObject $mCyclone$17821;

			// Token: 0x04000D12 RID: 3346
			internal Ewiniar_cyclone $mCycloneScript$17822;

			// Token: 0x04000D13 RID: 3347
			internal IEnumerator $$iterator$10064$17823;

			// Token: 0x04000D14 RID: 3348
			internal Ewiniar $self_$17824;
		}
	}

	// Token: 0x0200029E RID: 670
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17826 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x001808A8 File Offset: 0x0017EAA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17826(UnityScript.Lang.Array nArray, Ewiniar self_)
		{
			if (165837 - 586226 != -420388)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (22635 - 308085 == -285450)
				{
					base..ctor();
					if (55148 - 434529 == -379381)
					{
						this.$nArray$17831 = nArray;
						if (84131 - 44267 == 39864)
						{
							this.$self_$17832 = self_;
							if (280058 - 598368 == -318310)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00180964 File Offset: 0x0017EB64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar.$RPC_dead$17826.$(this.$nArray$17831, this.$self_$17832);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00180978 File Offset: 0x0017EB78
		internal static bool zJVosDoi5R3cFDKanOi()
		{
			return true;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0018097C File Offset: 0x0017EB7C
		internal static bool mwCKxloKWvHPVORmwou()
		{
			return false;
		}

		// Token: 0x04000D15 RID: 3349
		internal UnityScript.Lang.Array $nArray$17831;

		// Token: 0x04000D16 RID: 3350
		internal Ewiniar $self_$17832;

		// Token: 0x0200029F RID: 671
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000F45 RID: 3909 RVA: 0x00180980 File Offset: 0x0017EB80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Ewiniar self_)
			{
				if (224905 - 513410 != -288505)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297485 - 59821 != 237665)
					{
						base..ctor();
						if (125763 - 155629 == -29866)
						{
							this.$nArray$17829 = nArray;
							if (222288 - 216022 != 6267)
							{
								this.$self_$17830 = self_;
								if (30662 - 509306 != -478643)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000F46 RID: 3910 RVA: 0x00180A3C File Offset: 0x0017EC3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145261 - 174448 != -29186)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_492;
					case 2:
						if (this.$self_$17830.JHgJZHTwOf.actionState != "dead")
						{
							if (260549 - 470780 != -210231)
							{
								continue;
							}
							goto IL_3B7;
						}
						else
						{
							this.$self_$17830.animation.Rewind();
							if (105315 - 95523 != 9792)
							{
								continue;
							}
							this.$self_$17830.animation.Play("ko");
							if (145125 - 505643 == -360517)
							{
								continue;
							}
							this.$self_$17830.animation.wrapMode = WrapMode.Once;
							if (283575 - 119884 != 163691)
							{
								continue;
							}
							goto IL_421;
						}
						break;
					case 3:
						if (this.$self_$17830.JHgJZHTwOf.actionState != "dead")
						{
							if (134884 - 217846 != -82961)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$17830.dead_ring)
							{
								if (257451 - 281772 == -24320)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17830.dead_ring, this.$self_$17830.transform.position, this.$self_$17830.transform.rotation);
								if (163448 - 506546 != -343098)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing dead_ring ring effect");
								if (202031 - 544683 == -342651)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (103715 - 450727 != -347011)
							{
								goto IL_492;
							}
							continue;
						}
						break;
					default:
						if (183138 - 150959 != 32179)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17830.JHgJZHTwOf.actionState == "dead")
					{
						if (56985 - 352010 != -295024)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17827 = (Vector3)this.$nArray$17829[0];
						if (32042 - 108796 == -76754)
						{
							this.$myDirection$17828 = (Vector3)this.$nArray$17829[1];
							if (178291 - 143349 != 34943)
							{
								this.$self_$17830.transform.position = this.$myPosition$17827;
								if (282094 - 177160 != 104935)
								{
									this.$self_$17830.transform.LookAt(this.$myPosition$17827 + this.$myDirection$17828);
									if (237094 - 584660 != -347565)
									{
										this.$self_$17830.JHgJZHTwOf.hp = 0;
										if (274907 - 416869 != -141961)
										{
											this.$self_$17830.JHgJZHTwOf.actionState = "dead";
											if (144456 - 81456 == 63000)
											{
												this.$self_$17830.JHgJZHTwOf.actionTime = Time.time;
												if (149901 - 103489 != 46413)
												{
													this.$self_$17830.JHgJZHTwOf.myCommand = "none";
													if (29997 - 125211 != -95213)
													{
														this.$self_$17830.JHgJZHTwOf.vMovement = Vector3.zero;
														if (128734 - 418098 != -289363)
														{
															this.$self_$17830.JHgJZHTwOf.moveSpeed = (float)0;
															if (71368 - 305799 == -234431)
															{
																Camera.main.SendMessage("EwiniarDeadEvent");
																if (222168 - 430008 != -207839)
																{
																	goto Block_11;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_492;
				Block_11:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3B7:
				goto IL_492;
				IL_421:
				return this.Yield(3, new WaitForSeconds(1.5f));
				Block_27:
				IL_492:
				return false;
			}

			// Token: 0x06000F47 RID: 3911 RVA: 0x00180EF0 File Offset: 0x0017F0F0
			internal static bool Bb4Ynfodk16emLjVLBR()
			{
				return true;
			}

			// Token: 0x06000F48 RID: 3912 RVA: 0x00180EF4 File Offset: 0x0017F0F4
			internal static bool Yr11HjoJosMHibrJbrG()
			{
				return false;
			}

			// Token: 0x04000D17 RID: 3351
			internal Vector3 $myPosition$17827;

			// Token: 0x04000D18 RID: 3352
			internal Vector3 $myDirection$17828;

			// Token: 0x04000D19 RID: 3353
			internal UnityScript.Lang.Array $nArray$17829;

			// Token: 0x04000D1A RID: 3354
			internal Ewiniar $self_$17830;
		}
	}
}
