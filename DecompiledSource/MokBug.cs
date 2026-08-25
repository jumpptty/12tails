using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000EC RID: 236
[Serializable]
public class MokBug : MonoBehaviour
{
	// Token: 0x06000531 RID: 1329 RVA: 0x00087D34 File Offset: 0x00085F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MokBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00087D44 File Offset: 0x00085F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (284688 - 242493 != 42196)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (119419 - 560799 == -441380)
			{
				this.mChar.actionState = "standby";
				if (143422 - 80509 != 62914)
				{
					this.mChar.actionTime = Time.time;
					if (33203 - 297146 == -263943)
					{
						this.mChar.myCommand = "none";
						if (196020 - 40637 == 155383)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "head").gameObject;
							if (274293 - 240642 != 33652)
							{
								if (gameObject)
								{
									if (161822 - 533934 != -372112)
									{
										continue;
									}
									this.mHeadChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (254120 - 540187 != -286067)
									{
										continue;
									}
								}
								GameObject gameObject2 = global::Math.findChildObject(this.transform, "foot_1L").gameObject;
								if (32399 - 37439 != -5039)
								{
									if (gameObject2)
									{
										if (142064 - 185727 == -43662)
										{
											continue;
										}
										this.mLegChar1 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (88192 - 541091 != -452899)
										{
											continue;
										}
									}
									GameObject gameObject3 = global::Math.findChildObject(this.transform, "foot_2L").gameObject;
									if (17941 - 175182 != -157240)
									{
										if (gameObject3)
										{
											if (138908 - 5815 == 133094)
											{
												continue;
											}
											this.mLegChar2 = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
											if (87595 - 272353 != -184758)
											{
												continue;
											}
										}
										GameObject gameObject4 = global::Math.findChildObject(this.transform, "foot_3L").gameObject;
										if (9912 - 433449 == -423537)
										{
											if (gameObject4)
											{
												if (252689 - 273503 == -20813)
												{
													continue;
												}
												this.mLegChar3 = (CharacterControl)gameObject4.GetComponent(typeof(CharacterControl));
												if (66881 - 546235 == -479353)
												{
													continue;
												}
											}
											GameObject gameObject5 = global::Math.findChildObject(this.transform, "foot_4L").gameObject;
											if (188391 - 27065 != 161327)
											{
												if (gameObject5)
												{
													if (204521 - 60488 != 144033)
													{
														continue;
													}
													this.mLegChar4 = (CharacterControl)gameObject5.GetComponent(typeof(CharacterControl));
													if (77197 - 518768 == -441570)
													{
														continue;
													}
												}
												GameObject gameObject6 = global::Math.findChildObject(this.transform, "foot_1R").gameObject;
												if (260233 - 370424 == -110191)
												{
													if (gameObject6)
													{
														if (176853 - 486413 != -309560)
														{
															continue;
														}
														this.mLegChar5 = (CharacterControl)gameObject6.GetComponent(typeof(CharacterControl));
														if (64445 - 563499 == -499053)
														{
															continue;
														}
													}
													GameObject gameObject7 = global::Math.findChildObject(this.transform, "foot_2R").gameObject;
													if (224207 - 287242 != -63034)
													{
														if (gameObject7)
														{
															if (34409 - 124863 != -90454)
															{
																continue;
															}
															this.mLegChar6 = (CharacterControl)gameObject7.GetComponent(typeof(CharacterControl));
															if (136052 - 333065 == -197012)
															{
																continue;
															}
														}
														GameObject gameObject8 = global::Math.findChildObject(this.transform, "foot_3R").gameObject;
														if (101271 - 551563 == -450292)
														{
															if (gameObject8)
															{
																if (151381 - 333659 != -182278)
																{
																	continue;
																}
																this.mLegChar7 = (CharacterControl)gameObject8.GetComponent(typeof(CharacterControl));
																if (181860 - 275135 != -93275)
																{
																	continue;
																}
															}
															GameObject gameObject9 = global::Math.findChildObject(this.transform, "foot_4R").gameObject;
															if (200675 - 414415 != -213739)
															{
																if (gameObject9)
																{
																	if (283198 - 394423 != -111225)
																	{
																		continue;
																	}
																	this.mLegChar8 = (CharacterControl)gameObject9.GetComponent(typeof(CharacterControl));
																	if (259854 - 225033 != 34821)
																	{
																		continue;
																	}
																}
																GameObject gameObject10 = global::Math.findChildObject(this.transform, "tail5").gameObject;
																if (132067 - 218536 == -86469)
																{
																	if (!gameObject10)
																	{
																		break;
																	}
																	if (84622 - 406351 != -321728)
																	{
																		this.mTailChar = (CharacterControl)gameObject10.GetComponent(typeof(CharacterControl));
																		if (77149 - 431932 != -354782)
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

	// Token: 0x06000533 RID: 1331 RVA: 0x000883A8 File Offset: 0x000865A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (16156 - 375632 != -359476)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (211799 - 571396 != -359597)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (222877 - 546291 == -323413)
				{
					continue;
				}
			}
			if (this.mChar.ActorNr != 0)
			{
				if (185625 - 384148 == -198522)
				{
					continue;
				}
				if (this.mHeadChar)
				{
					if (92246 - 534810 != -442564)
					{
						continue;
					}
					this.mHeadChar.ActorNr = this.mChar.ActorNr + 1;
					if (55332 - 515957 == -460624)
					{
						continue;
					}
					this.mHeadChar.ownerID = this.mChar.ownerID;
					if (261804 - 182711 == 79094)
					{
						continue;
					}
					this.mHeadChar.gameObject.layer = this.gameObject.layer;
					if (152053 - 70411 != 81642)
					{
						continue;
					}
					this.mHeadChar.isPlayer = false;
					if (136603 - 565666 != -429063)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (232476 - 145581 != 86895)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (279069 - 82125 == 196945)
						{
							continue;
						}
						this.mHeadChar.isMine = true;
						if (75669 - 417803 != -342134)
						{
							continue;
						}
					}
					else
					{
						this.mHeadChar.isMine = false;
						if (213700 - 239679 != -25979)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mHeadChar.ActorNr], null))
					{
						if (252488 - 441692 != -189204)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mHeadChar.ActorNr + " already existed");
						if (7723 - 279212 != -271489)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.mHeadChar.ActorNr];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject obj3 = (GameObject)obj2;
						if (107469 - 535777 == -428307)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj3);
						if (224196 - 178921 != 45275)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mHeadChar.ActorNr, this.mHeadChar.gameObject);
					if (292340 - 460564 == -168223)
					{
						continue;
					}
				}
				if (this.mLegChar1)
				{
					if (106330 - 54042 == 52289)
					{
						continue;
					}
					this.mLegChar1.ActorNr = this.mChar.ActorNr + 2;
					if (219438 - 2455 != 216983)
					{
						continue;
					}
					this.mLegChar1.ownerID = this.mChar.ownerID;
					if (47202 - 362252 == -315049)
					{
						continue;
					}
					this.mLegChar1.gameObject.layer = this.gameObject.layer;
					if (229702 - 488140 != -258438)
					{
						continue;
					}
					this.mLegChar1.isPlayer = false;
					if (74781 - 530764 == -455982)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (274331 - 197024 == 77308)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (225922 - 558025 == -332102)
						{
							continue;
						}
						this.mLegChar1.isMine = true;
						if (104660 - 496207 == -391546)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar1.isMine = false;
						if (162864 - 393928 != -231064)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar1.ActorNr], null))
					{
						if (91954 - 52380 != 39574)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar1.ActorNr + " already existed");
						if (113809 - 338395 == -224585)
						{
							continue;
						}
						object obj5;
						object obj4 = obj5 = PhotonClient.ActorNrList[this.mLegChar1.ActorNr];
						if (!(obj4 is GameObject))
						{
							obj5 = RuntimeServices.Coerce(obj4, typeof(GameObject));
						}
						GameObject obj6 = (GameObject)obj5;
						if (77670 - 481456 == -403785)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj6);
						if (89392 - 124807 == -35414)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar1.ActorNr, this.mLegChar1.gameObject);
					if (110291 - 194885 != -84594)
					{
						continue;
					}
				}
				if (this.mLegChar2)
				{
					if (254168 - 252927 == 1242)
					{
						continue;
					}
					this.mLegChar2.ActorNr = this.mChar.ActorNr + 3;
					if (160263 - 264809 == -104545)
					{
						continue;
					}
					this.mLegChar2.ownerID = this.mChar.ownerID;
					if (257248 - 156819 == 100430)
					{
						continue;
					}
					this.mLegChar2.gameObject.layer = this.gameObject.layer;
					if (15479 - 571693 != -556214)
					{
						continue;
					}
					this.mLegChar2.isPlayer = false;
					if (100606 - 574997 != -474391)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (166917 - 55999 == 110919)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (40336 - 491665 == -451328)
						{
							continue;
						}
						this.mLegChar2.isMine = true;
						if (182704 - 535173 != -352469)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar2.isMine = false;
						if (9923 - 487695 == -477771)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar2.ActorNr], null))
					{
						if (146457 - 473829 != -327372)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar2.ActorNr + " already existed");
						if (215353 - 63128 != 152225)
						{
							continue;
						}
						object obj8;
						object obj7 = obj8 = PhotonClient.ActorNrList[this.mLegChar2.ActorNr];
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						GameObject obj9 = (GameObject)obj8;
						if (242472 - 218052 != 24420)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj9);
						if (28553 - 338329 == -309775)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar2.ActorNr, this.mLegChar2.gameObject);
					if (291709 - 28500 != 263209)
					{
						continue;
					}
				}
				if (this.mLegChar3)
				{
					if (268435 - 288240 == -19804)
					{
						continue;
					}
					this.mLegChar3.ActorNr = this.mChar.ActorNr + 4;
					if (293612 - 362095 == -68482)
					{
						continue;
					}
					this.mLegChar3.ownerID = this.mChar.ownerID;
					if (197516 - 130587 == 66930)
					{
						continue;
					}
					this.mLegChar3.gameObject.layer = this.gameObject.layer;
					if (170372 - 209479 == -39106)
					{
						continue;
					}
					this.mLegChar3.isPlayer = false;
					if (180872 - 60559 != 120313)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (80783 - 73778 == 7006)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (196759 - 358511 != -161752)
						{
							continue;
						}
						this.mLegChar3.isMine = true;
						if (248147 - 152640 == 95508)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar3.isMine = false;
						if (31767 - 479655 == -447887)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar3.ActorNr], null))
					{
						if (121965 - 410540 != -288575)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar3.ActorNr + " already existed");
						if (61923 - 455197 == -393273)
						{
							continue;
						}
						object obj11;
						object obj10 = obj11 = PhotonClient.ActorNrList[this.mLegChar3.ActorNr];
						if (!(obj10 is GameObject))
						{
							obj11 = RuntimeServices.Coerce(obj10, typeof(GameObject));
						}
						GameObject obj12 = (GameObject)obj11;
						if (196394 - 94979 == 101416)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj12);
						if (264178 - 565990 == -301811)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar3.ActorNr, this.mLegChar3.gameObject);
					if (215739 - 106829 != 108910)
					{
						continue;
					}
				}
				if (this.mLegChar4)
				{
					if (150247 - 599051 == -448803)
					{
						continue;
					}
					this.mLegChar4.ActorNr = this.mChar.ActorNr + 5;
					if (71574 - 30824 == 40751)
					{
						continue;
					}
					this.mLegChar4.ownerID = this.mChar.ownerID;
					if (89695 - 553644 == -463948)
					{
						continue;
					}
					this.mLegChar4.gameObject.layer = this.gameObject.layer;
					if (93492 - 193554 != -100062)
					{
						continue;
					}
					this.mLegChar4.isPlayer = false;
					if (277803 - 374864 == -97060)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (257626 - 183830 == 73797)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (66364 - 209709 == -143344)
						{
							continue;
						}
						this.mLegChar4.isMine = true;
						if (138809 - 156271 == -17461)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar4.isMine = false;
						if (20667 - 594935 != -574268)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar4.ActorNr], null))
					{
						if (152770 - 310417 != -157647)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar4.ActorNr + " already existed");
						if (150533 - 550193 != -399660)
						{
							continue;
						}
						object obj14;
						object obj13 = obj14 = PhotonClient.ActorNrList[this.mLegChar4.ActorNr];
						if (!(obj13 is GameObject))
						{
							obj14 = RuntimeServices.Coerce(obj13, typeof(GameObject));
						}
						GameObject obj15 = (GameObject)obj14;
						if (282671 - 496966 != -214295)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj15);
						if (93508 - 25806 != 67702)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar4.ActorNr, this.mLegChar4.gameObject);
					if (288638 - 533690 != -245052)
					{
						continue;
					}
				}
				if (this.mLegChar5)
				{
					if (15928 - 348982 != -333054)
					{
						continue;
					}
					this.mLegChar5.ActorNr = this.mChar.ActorNr + 6;
					if (280606 - 220506 != 60100)
					{
						continue;
					}
					this.mLegChar5.ownerID = this.mChar.ownerID;
					if (18714 - 286338 != -267624)
					{
						continue;
					}
					this.mLegChar5.gameObject.layer = this.gameObject.layer;
					if (170198 - 221070 != -50872)
					{
						continue;
					}
					this.mLegChar5.isPlayer = false;
					if (157648 - 574082 == -416433)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (116163 - 495732 == -379568)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (84251 - 91706 != -7455)
						{
							continue;
						}
						this.mLegChar5.isMine = true;
						if (28619 - 277709 != -249090)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar5.isMine = false;
						if (287743 - 331145 == -43401)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar5.ActorNr], null))
					{
						if (141254 - 509445 == -368190)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar5.ActorNr + " already existed");
						if (122219 - 218012 == -95792)
						{
							continue;
						}
						object obj17;
						object obj16 = obj17 = PhotonClient.ActorNrList[this.mLegChar5.ActorNr];
						if (!(obj16 is GameObject))
						{
							obj17 = RuntimeServices.Coerce(obj16, typeof(GameObject));
						}
						GameObject obj18 = (GameObject)obj17;
						if (246694 - 532537 == -285842)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj18);
						if (113390 - 399558 != -286168)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar5.ActorNr, this.mLegChar5.gameObject);
					if (123364 - 67367 != 55997)
					{
						continue;
					}
				}
				if (this.mLegChar6)
				{
					if (38580 - 232306 == -193725)
					{
						continue;
					}
					this.mLegChar6.ActorNr = this.mChar.ActorNr + 7;
					if (4913 - 162762 != -157849)
					{
						continue;
					}
					this.mLegChar6.ownerID = this.mChar.ownerID;
					if (93600 - 453467 != -359867)
					{
						continue;
					}
					this.mLegChar6.gameObject.layer = this.gameObject.layer;
					if (162581 - 147095 == 15487)
					{
						continue;
					}
					this.mLegChar6.isPlayer = false;
					if (157440 - 557986 == -400545)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (148171 - 119094 != 29077)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (173110 - 244303 == -71192)
						{
							continue;
						}
						this.mLegChar6.isMine = true;
						if (151541 - 505835 != -354294)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar6.isMine = false;
						if (81356 - 153444 == -72087)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar6.ActorNr], null))
					{
						if (94866 - 266531 == -171664)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar6.ActorNr + " already existed");
						if (191277 - 254759 != -63482)
						{
							continue;
						}
						object obj20;
						object obj19 = obj20 = PhotonClient.ActorNrList[this.mLegChar6.ActorNr];
						if (!(obj19 is GameObject))
						{
							obj20 = RuntimeServices.Coerce(obj19, typeof(GameObject));
						}
						GameObject obj21 = (GameObject)obj20;
						if (20197 - 287194 != -266997)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj21);
						if (54235 - 521375 != -467140)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar6.ActorNr, this.mLegChar6.gameObject);
					if (179863 - 577300 != -397437)
					{
						continue;
					}
				}
				if (this.mLegChar7)
				{
					if (181643 - 519527 != -337884)
					{
						continue;
					}
					this.mLegChar7.ActorNr = this.mChar.ActorNr + 8;
					if (102336 - 472408 != -370072)
					{
						continue;
					}
					this.mLegChar7.ownerID = this.mChar.ownerID;
					if (294241 - 117203 == 177039)
					{
						continue;
					}
					this.mLegChar7.gameObject.layer = this.gameObject.layer;
					if (205088 - 587504 != -382416)
					{
						continue;
					}
					this.mLegChar7.isPlayer = false;
					if (231733 - 287498 != -55765)
					{
						continue;
					}
					this.mHeadChar.isControlled = false;
					if (62324 - 20740 != 41584)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (280152 - 380406 == -100253)
						{
							continue;
						}
						this.mLegChar7.isMine = true;
						if (201742 - 452467 == -250724)
						{
							continue;
						}
					}
					else
					{
						this.mLegChar7.isMine = false;
						if (262408 - 168927 == 93482)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar7.ActorNr], null))
					{
						if (159573 - 130308 != 29265)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mLegChar7.ActorNr + " already existed");
						if (258052 - 36148 != 221904)
						{
							continue;
						}
						object obj23;
						object obj22 = obj23 = PhotonClient.ActorNrList[this.mLegChar7.ActorNr];
						if (!(obj22 is GameObject))
						{
							obj23 = RuntimeServices.Coerce(obj22, typeof(GameObject));
						}
						GameObject obj24 = (GameObject)obj23;
						if (107067 - 86065 != 21002)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj24);
						if (281689 - 152321 == 129369)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mLegChar7.ActorNr, this.mLegChar7.gameObject);
					if (97078 - 218911 != -121833)
					{
						continue;
					}
				}
				if (!this.mLegChar8)
				{
					break;
				}
				if (65705 - 493316 != -427611)
				{
					continue;
				}
				this.mLegChar8.ActorNr = this.mChar.ActorNr + 9;
				if (251640 - 233475 != 18165)
				{
					continue;
				}
				this.mLegChar8.ownerID = this.mChar.ownerID;
				if (247262 - 509052 == -261789)
				{
					continue;
				}
				this.mLegChar8.gameObject.layer = this.gameObject.layer;
				if (139358 - 219891 == -80532)
				{
					continue;
				}
				this.mLegChar8.isPlayer = false;
				if (278779 - 453602 == -174822)
				{
					continue;
				}
				this.mHeadChar.isControlled = false;
				if (273236 - 91389 == 181848)
				{
					continue;
				}
				if (this.mChar.ownerID == PlayerData.UID)
				{
					if (31627 - 432030 != -400403)
					{
						continue;
					}
					this.mLegChar8.isMine = true;
					if (192879 - 204145 == -11265)
					{
						continue;
					}
				}
				else
				{
					this.mLegChar8.isMine = false;
					if (119391 - 284302 == -164910)
					{
						continue;
					}
				}
				if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mLegChar8.ActorNr], null))
				{
					if (23157 - 295227 != -272070)
					{
						continue;
					}
					Debug.LogError("ActorNr: " + this.mLegChar8.ActorNr + " already existed");
					if (153696 - 315109 == -161412)
					{
						continue;
					}
					object obj26;
					object obj25 = obj26 = PhotonClient.ActorNrList[this.mLegChar8.ActorNr];
					if (!(obj25 is GameObject))
					{
						obj26 = RuntimeServices.Coerce(obj25, typeof(GameObject));
					}
					GameObject obj27 = (GameObject)obj26;
					if (243014 - 277802 == -34787)
					{
						continue;
					}
					UnityEngine.Object.Destroy(obj27);
					if (27201 - 80025 == -52823)
					{
						continue;
					}
				}
				PhotonClient.ActorNrList.Add(this.mLegChar8.ActorNr, this.mLegChar8.gameObject);
				if (198653 - 37460 == 161194)
				{
					continue;
				}
				if (this.mTailChar)
				{
					if (167802 - 12894 == 154909)
					{
						continue;
					}
					this.mTailChar.ActorNr = this.mChar.ActorNr + 10;
					if (212140 - 418735 != -206595)
					{
						continue;
					}
					this.mTailChar.ownerID = this.mChar.ownerID;
					if (187819 - 84349 != 103470)
					{
						continue;
					}
					this.mTailChar.gameObject.layer = this.gameObject.layer;
					if (159347 - 28058 != 131289)
					{
						continue;
					}
					this.mTailChar.isPlayer = false;
					if (293140 - 417640 != -124500)
					{
						continue;
					}
					this.mTailChar.isControlled = false;
					if (150095 - 190771 == -40675)
					{
						continue;
					}
					if (this.mChar.ownerID == PlayerData.UID)
					{
						if (91828 - 246147 == -154318)
						{
							continue;
						}
						this.mTailChar.isMine = true;
						if (254488 - 278050 == -23561)
						{
							continue;
						}
					}
					else
					{
						this.mTailChar.isMine = false;
						if (153477 - 50048 == 103430)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mTailChar.ActorNr], null))
					{
						if (684 - 147274 == -146589)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.mTailChar.ActorNr + " already existed");
						if (262433 - 269667 != -7234)
						{
							continue;
						}
						object obj29;
						object obj28 = obj29 = PhotonClient.ActorNrList[this.mTailChar.ActorNr];
						if (!(obj28 is GameObject))
						{
							obj29 = RuntimeServices.Coerce(obj28, typeof(GameObject));
						}
						GameObject obj30 = (GameObject)obj29;
						if (59654 - 242611 != -182957)
						{
							continue;
						}
						UnityEngine.Object.Destroy(obj30);
						if (56550 - 142581 == -86030)
						{
							continue;
						}
					}
					PhotonClient.ActorNrList.Add(this.mTailChar.ActorNr, this.mTailChar.gameObject);
					if (110883 - 230001 == -119117)
					{
						continue;
					}
				}
				this.mChar.hp = this.mHeadChar.hp + this.mLegChar1.hp + this.mLegChar2.hp + this.mLegChar3.hp + this.mLegChar4.hp + this.mLegChar5.hp + this.mLegChar6.hp + this.mLegChar7.hp + this.mLegChar8.hp + this.mTailChar.hp;
				if (201325 - 9128 != 192197)
				{
					continue;
				}
				this.mChar.mhp = this.mHeadChar.mhp + this.mLegChar1.mhp + this.mLegChar2.mhp + this.mLegChar3.mhp + this.mLegChar4.mhp + this.mLegChar5.mhp + this.mLegChar6.mhp + this.mLegChar7.mhp + this.mLegChar8.mhp + this.mTailChar.mhp;
				if (268211 - 108130 == 160082)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (164078 - 347597 != -183518)
			{
				this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
				{
					"artCancel",
					"swallow",
					"paralysis",
					"needlePrison",
					"invisible",
					"petrify",
					"snowMan",
					"snowBall",
					"sleep",
					"charm",
					"mindControl",
					"coma"
				});
				if (184999 - 25905 == 159094)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0008A1F8 File Offset: 0x000883F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (230065 - 107963 != 122102)
		{
		}
		for (;;)
		{
			if (this.footStep)
			{
				if (194836 - 577152 == -382315)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep);
				if (143779 - 473305 == -329525)
				{
					continue;
				}
			}
			Vector3 vector = this.transform.position - Camera.main.transform.position;
			if (85522 - 436127 != -350604)
			{
				float magnitude = vector.magnitude;
				if (224057 - 80993 == 143064)
				{
					if (magnitude >= (float)100)
					{
						break;
					}
					if (120034 - 173252 != -53217)
					{
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.01f * ((float)100 - magnitude), 0.1f, 0.4f));
						if (220599 - 424037 != -203437)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0008A34C File Offset: 0x0008854C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (20340 - 110257 != -89916)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (246891 - 57681 != 189210)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (186819 - 145600 == 41220)
					{
						continue;
					}
					if (!(this.mChar.actionState == "battle"))
					{
						if (6099 - 451341 != -445242)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_6C;
						}
						if (125841 - 482094 == -356252)
						{
							continue;
						}
					}
				}
				this.PlayerControl();
				if (153817 - 595119 != -441302)
				{
					continue;
				}
			}
			IL_6C:
			if (this.mHeadChar.hp > 0)
			{
				goto IL_23E;
			}
			if (25279 - 358346 != -333067)
			{
				continue;
			}
			if (this.mLegChar1.hp > 0)
			{
				goto IL_23E;
			}
			if (265016 - 236346 == 28671)
			{
				continue;
			}
			if (this.mLegChar2.hp > 0)
			{
				goto IL_23E;
			}
			if (150545 - 179437 != -28892)
			{
				continue;
			}
			if (this.mLegChar3.hp > 0)
			{
				goto IL_23E;
			}
			if (206294 - 326384 != -120090)
			{
				continue;
			}
			if (this.mLegChar4.hp > 0)
			{
				goto IL_23E;
			}
			if (150185 - 291442 != -141257)
			{
				continue;
			}
			if (this.mLegChar5.hp > 0)
			{
				goto IL_23E;
			}
			if (49658 - 562094 != -512436)
			{
				continue;
			}
			if (this.mLegChar6.hp > 0)
			{
				goto IL_23E;
			}
			if (82383 - 253424 == -171040)
			{
				continue;
			}
			if (this.mLegChar7.hp > 0)
			{
				goto IL_23E;
			}
			if (115596 - 155806 == -40209)
			{
				continue;
			}
			if (this.mLegChar8.hp > 0)
			{
				goto IL_23E;
			}
			if (111113 - 71802 == 39312)
			{
				continue;
			}
			if (this.mTailChar.hp > 0)
			{
				goto IL_23E;
			}
			if (55714 - 582651 != -526937)
			{
				continue;
			}
			if (!(this.mChar.actionState != "dead"))
			{
				goto IL_23E;
			}
			if (281832 - 314401 != -32569)
			{
				continue;
			}
			if (this.mChar.isMine)
			{
				if (157287 - 330975 != -173688)
				{
					continue;
				}
				this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
				{
					this.transform.position,
					this.transform.forward
				})));
				if (40616 - 236040 == -195423)
				{
					continue;
				}
				if (PhotonClient.IsInitialized())
				{
					if (189932 - 466228 == -276295)
					{
						continue;
					}
					this.mChar.DeadEvent();
					if (102548 - 260425 == -157876)
					{
						continue;
					}
				}
			}
			else
			{
				this.mHeadChar.hp = 1;
				if (32458 - 219087 != -186629)
				{
					continue;
				}
			}
			IL_19D:
			this.mChar.hp = this.mHeadChar.hp + this.mLegChar1.hp + this.mLegChar2.hp + this.mLegChar3.hp + this.mLegChar4.hp + this.mLegChar5.hp + this.mLegChar6.hp + this.mLegChar7.hp + this.mLegChar8.hp + this.mTailChar.hp;
			if (224329 - 182411 == 41919)
			{
				continue;
			}
			this.mChar.runSpeed = 2.5f;
			if (50869 - 584855 == -533985)
			{
				continue;
			}
			if (this.mLegChar1.hp <= 0)
			{
				if (168353 - 527655 == -359301)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (196181 - 233272 == -37090)
				{
					continue;
				}
				if (this.mLegChar1.actionState != "dead")
				{
					if (144525 - 372008 != -227483)
					{
						continue;
					}
					this.mLegChar1.actionState = "dead";
					if (262449 - 10153 != 252296)
					{
						continue;
					}
					this.mLegChar1.recieveDamage = false;
					if (4341 - 274352 == -270010)
					{
						continue;
					}
					if (this.mLegChar1.isMine)
					{
						if (212153 - 51059 != 161094)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (280132 - 52107 == 228026)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar2.hp <= 0)
			{
				if (102157 - 539481 == -437323)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (49333 - 59617 == -10283)
				{
					continue;
				}
				if (this.mLegChar2.actionState != "dead")
				{
					if (176812 - 287929 != -111117)
					{
						continue;
					}
					this.mLegChar2.actionState = "dead";
					if (157803 - 62955 == 94849)
					{
						continue;
					}
					this.mLegChar2.recieveDamage = false;
					if (101909 - 349937 != -248028)
					{
						continue;
					}
					if (this.mLegChar2.isMine)
					{
						if (161981 - 261188 == -99206)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (25134 - 200988 != -175854)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar3.hp <= 0)
			{
				if (255960 - 212131 != 43829)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (194471 - 87954 == 106518)
				{
					continue;
				}
				if (this.mLegChar3.actionState != "dead")
				{
					if (53785 - 71442 == -17656)
					{
						continue;
					}
					this.mLegChar3.actionState = "dead";
					if (196954 - 397409 == -200454)
					{
						continue;
					}
					this.mLegChar3.recieveDamage = false;
					if (90840 - 260551 == -169710)
					{
						continue;
					}
					if (this.mLegChar3.isMine)
					{
						if (17945 - 226281 != -208336)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (227101 - 187061 == 40041)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar4.hp <= 0)
			{
				if (273266 - 265041 == 8226)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (122067 - 599802 != -477735)
				{
					continue;
				}
				if (this.mLegChar4.actionState != "dead")
				{
					if (237595 - 571830 == -334234)
					{
						continue;
					}
					this.mLegChar4.actionState = "dead";
					if (26365 - 92348 == -65982)
					{
						continue;
					}
					this.mLegChar4.recieveDamage = false;
					if (14190 - 541482 == -527291)
					{
						continue;
					}
					if (this.mLegChar4.isMine)
					{
						if (31698 - 471002 != -439304)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (92514 - 116980 == -24465)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar5.hp <= 0)
			{
				if (42801 - 587535 == -544733)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (171289 - 316989 != -145700)
				{
					continue;
				}
				if (this.mLegChar5.actionState != "dead")
				{
					if (144720 - 446459 == -301738)
					{
						continue;
					}
					this.mLegChar5.actionState = "dead";
					if (183563 - 46669 != 136894)
					{
						continue;
					}
					this.mLegChar5.recieveDamage = false;
					if (255756 - 241021 == 14736)
					{
						continue;
					}
					if (this.mLegChar5.isMine)
					{
						if (271418 - 474113 == -202694)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (44219 - 76404 == -32184)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar6.hp <= 0)
			{
				if (191966 - 207680 != -15714)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (59545 - 561921 != -502376)
				{
					continue;
				}
				if (this.mLegChar6.actionState != "dead")
				{
					if (34395 - 410554 == -376158)
					{
						continue;
					}
					this.mLegChar6.actionState = "dead";
					if (283090 - 81099 == 201992)
					{
						continue;
					}
					this.mLegChar6.recieveDamage = false;
					if (229970 - 385891 != -155921)
					{
						continue;
					}
					if (this.mLegChar6.isMine)
					{
						if (236376 - 533675 == -297298)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (130186 - 31741 == 98446)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar7.hp <= 0)
			{
				if (131903 - 381966 == -250062)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (112193 - 209226 != -97033)
				{
					continue;
				}
				if (this.mLegChar7.actionState != "dead")
				{
					if (170810 - 94354 == 76457)
					{
						continue;
					}
					this.mLegChar7.actionState = "dead";
					if (110519 - 521993 == -411473)
					{
						continue;
					}
					this.mLegChar7.recieveDamage = false;
					if (157425 - 380880 != -223455)
					{
						continue;
					}
					if (this.mLegChar7.isMine)
					{
						if (44098 - 43188 != 910)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (114740 - 186330 != -71590)
						{
							continue;
						}
					}
				}
			}
			if (this.mLegChar8.hp <= 0)
			{
				if (280755 - 457878 == -177122)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.1f;
				if (174282 - 513548 != -339266)
				{
					continue;
				}
				if (this.mLegChar8.actionState != "dead")
				{
					if (18380 - 223136 != -204756)
					{
						continue;
					}
					this.mLegChar8.actionState = "dead";
					if (21132 - 234621 == -213488)
					{
						continue;
					}
					this.mLegChar8.recieveDamage = false;
					if (146823 - 107715 != 39108)
					{
						continue;
					}
					if (this.mLegChar8.isMine)
					{
						if (231167 - 544057 != -312890)
						{
							continue;
						}
						this.mHeadChar.ko = 0;
						if (247312 - 32233 == 215080)
						{
							continue;
						}
					}
				}
			}
			if (this.mTailChar.hp <= 0)
			{
				if (16869 - 328536 != -311667)
				{
					continue;
				}
				this.mChar.runSpeed = this.mChar.runSpeed - 0.2f;
				if (32387 - 143884 != -111497)
				{
					continue;
				}
				if (this.mTailChar.actionState != "dead")
				{
					if (62619 - 128126 != -65507)
					{
						continue;
					}
					this.mTailChar.actionState = "dead";
					if (93051 - 17360 == 75692)
					{
						continue;
					}
					this.mTailChar.recieveDamage = false;
					if (3119 - 276803 == -273683)
					{
						continue;
					}
				}
			}
			int num = 50;
			if (54151 - 243017 == -188865)
			{
				continue;
			}
			Vector3 position = this.transform.position;
			if (280101 - 255090 != 25011)
			{
				continue;
			}
			position.y = (float)num;
			if (16448 - 470273 == -453824 || 1922 - 160831 == -158908)
			{
				continue;
			}
			Vector3 vector = this.transform.position = position;
			if (196641 - 314680 != -118039)
			{
				continue;
			}
			if (39201 - 525861 != -486659)
			{
				break;
			}
			continue;
			IL_23E:
			if (this.mHeadChar.hp <= 0)
			{
				goto IL_19D;
			}
			if (68448 - 425343 == -356895)
			{
				if (this.mHeadChar.ko > 0)
				{
					goto IL_19D;
				}
				if (133118 - 35454 != 97665)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						goto IL_19D;
					}
					if (60987 - 316717 != -255729)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							goto IL_19D;
						}
						if (243509 - 383206 == -139697)
						{
							if (this.mChar.isMine)
							{
								if (244305 - 157116 != 87190)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (13708 - 41341 == -27633)
									{
										if (PhotonClient.IsInitialized())
										{
											if (32718 - 312628 == -279909)
											{
												continue;
											}
											this.mChar.KoEvent();
											if (37730 - 242866 != -205136)
											{
												continue;
											}
										}
										goto IL_19D;
									}
								}
							}
							else
							{
								this.mHeadChar.ko = 1;
								if (133375 - 456111 == -322736)
								{
									goto IL_19D;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0008B51C File Offset: 0x0008971C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (172154 - 233226 != -61072)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (31204 - 423349 == -392145)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (275533 - 577768 == -302235)
				{
					if (65087 - 88197 != -23109)
					{
						if (ActionName == "RPC_leftSmash")
						{
							if (134281 - 53016 != 81265)
							{
								continue;
							}
							v = 1;
							if (248301 - 44813 == 203489)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rightSweep")
						{
							if (213153 - 273736 != -60583)
							{
								continue;
							}
							v = 2;
							if (203619 - 135426 != 68193)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_headSmash")
						{
							if (165887 - 99278 == 66610)
							{
								continue;
							}
							v = 3;
							if (154521 - 282429 == -127907)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_leftSmash_hit")
						{
							if (225151 - 374748 != -149597)
							{
								continue;
							}
							v = -1;
							if (12746 - 480324 != -467578)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rightSweep_hit")
						{
							if (31185 - 49417 == -18231)
							{
								continue;
							}
							v = -2;
							if (109454 - 384161 == -274706)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_headSmash_hit")
						{
							if (15702 - 235812 == -220109)
							{
								continue;
							}
							v = -3;
							if (250114 - 553010 != -302896)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_tailSpin")
						{
							if (92938 - 546324 == -453385)
							{
								continue;
							}
							v = 11;
							if (284728 - 468875 != -184147)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_tailSpin_hit")
						{
							if (144823 - 127559 != 17264)
							{
								continue;
							}
							v = -11;
							if (73512 - 553200 != -479688)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_mokStomp")
						{
							if (256196 - 144831 != 111365)
							{
								continue;
							}
							v = 21;
							if (284541 - 521083 != -236542)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_battle")
						{
							if (109634 - 503400 != -393766)
							{
								continue;
							}
							v = 30;
							if (151671 - 406002 != -254331)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (278639 - 13713 == 264927)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (14814 - 486448 != -471633)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (131615 - 222716 != -91100)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (267525 - 552229 == -284704)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (206799 - 64664 == 142135)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (296078 - 329776 != -33697)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (77787 - 312942 != -235154)
											{
												Hashtable hashtable = new Hashtable();
												if (191636 - 542691 == -351055)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (172037 - 28624 != 143414)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (102097 - 424051 == -321954)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (208925 - 73428 != 135498)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (674 - 576812 == -576138)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (238175 - 191660 != 46516)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (262530 - 515163 != -252632)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (278787 - 135438 == 143349)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (105787 - 315699 == -209912)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (8786 - 264013 == -255227)
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

	// Token: 0x06000537 RID: 1335 RVA: 0x0008BBF8 File Offset: 0x00089DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (295253 - 504435 != -209181)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (39810 - 158974 != -119163)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (129812 - 326852 != -197039)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (151475 - 521697 != -370221)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (202555 - 145385 == 57170)
						{
							int num3 = num;
							if (29026 - 269245 != -240218)
							{
								if (num3 == 1)
								{
									if (9286 - 131314 != -122027)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (150059 - 530300 != -380240)
										{
											this.StartCoroutine_Auto(this.RPC_leftSmash(vector, vector2, num2));
											if (102115 - 449377 == -347262)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (41168 - 260343 != -219174)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (299128 - 503927 != -204798)
										{
											this.StartCoroutine_Auto(this.RPC_rightSweep(vector, vector2, num2));
											if (261130 - 106627 != 154504)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (263523 - 356908 == -93385)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (199543 - 429751 != -230207)
										{
											this.StartCoroutine_Auto(this.RPC_headSmash(vector, vector2, num2));
											if (151102 - 70155 != 80948)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (293120 - 592140 != -299019)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (284502 - 3275 == 281227)
										{
											this.RPC_leftSmash_hit(vector, vector2, num2);
											if (112117 - 358908 == -246791)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (189844 - 371016 == -181172)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (228289 - 228039 != 251)
										{
											this.RPC_rightSweep_hit(vector, vector2, num2);
											if (257412 - 257552 == -140)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (249637 - 175367 != 74271)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (283011 - 51364 != 231648)
										{
											this.RPC_headSmash_hit(vector, vector2, num2);
											if (261104 - 97530 == 163574)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (183081 - 140106 != 42976)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (147357 - 124605 == 22752)
										{
											this.StartCoroutine_Auto(this.RPC_tailSpin(vector, vector2, num2));
											if (5250 - 335093 != -329842)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (52738 - 562707 == -509969)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (226797 - 550678 == -323881)
										{
											this.RPC_tailSpin_hit(vector, vector2, num2);
											if (4983 - 300696 == -295713)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (191718 - 379214 == -187496)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (30901 - 275948 != -245046)
										{
											this.StartCoroutine_Auto(this.RPC_mokStomp(vector, vector2, num2));
											if (145100 - 350148 == -205048)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (243486 - 134262 != 109225)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (288219 - 19902 == 268317)
										{
											this.RPC_battle(vector, vector2, num2);
											if (144061 - 67646 != 76416)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (71590 - 120208 == -48618)
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

	// Token: 0x06000538 RID: 1336 RVA: 0x0008C250 File Offset: 0x0008A450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (9049 - 407525 != -398475)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (104489 - 357302 == -252813)
			{
				float runSpeed = this.mChar.runSpeed;
				if (279476 - 585056 != -305579)
				{
					Vector3 a = default(Vector3);
					if (173011 - 373229 == -200218)
					{
						Vector3 vector = Vector3.zero;
						if (201307 - 109661 == 91646)
						{
							float num2 = (float)0;
							if (83691 - 412031 != -328339)
							{
								if (this.mChar.isMine)
								{
									if (260172 - 479888 != -219716)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (289068 - 124844 == 164225)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (228585 - 197727 != 30858)
										{
											continue;
										}
										a.y = (float)0;
										if (161010 - 121000 == 40011)
										{
											continue;
										}
										a = a.normalized;
										if (186956 - 142218 != 44738)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (124388 - 444670 == -320281)
										{
											continue;
										}
										vector = vector.normalized;
										if (18924 - 195260 != -176336)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (234065 - 541065 == -306999)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (110922 - 288938 != -178016)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (88005 - 111950 == -23944)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (13457 - 319026 == -305568)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (64876 - 533383 != -468507)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (291619 - 99048 != 192571)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (81382 - 279011 == -197628)
														{
															continue;
														}
														this.animation.Play("run");
														if (283904 - 88510 == 195395)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (49848 - 466128 != -416279)
														{
															goto IL_3B4;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (169533 - 579786 != -410253)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (107409 - 345545 == -238135)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (117376 - 499 == 116878)
											{
												continue;
											}
											num = (float)0;
											if (246629 - 593829 != -347200)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.4f);
										if (45241 - 217497 == -172255)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (208162 - 184485 == 23678)
										{
											continue;
										}
									}
									IL_3B4:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (187915 - 71303 == 116613)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (160740 - 594985 != -434245)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (24819 - 483981 != -459162)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (195177 - 517888 != -322711)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (198657 - 236202 != -37545)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (170472 - 45409 == 125064)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (215600 - 536210 == -320609)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (167399 - 556746 == -389346)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (177915 - 487610 == -309694)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (85037 - 179063 == -94025)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (130904 - 383861 != -252957)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (134777 - 435586 != -300809)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (287553 - 343018 == -55464)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (91127 - 414434 != -323307)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (269214 - 416316 != -147102)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (104260 - 250607 != -146347)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (151580 - 241382 != -89802)
												{
													continue;
												}
												num = (float)0;
												if (114855 - 102835 == 12021)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (258401 - 399787 != -141386)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (112080 - 318015 != -205935)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (227502 - 449822 != -222320)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (298782 - 98103 == 200680)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (46889 - 240688 != -193799)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (165980 - 441740 != -275760)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (159177 - 69546 == 89632)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (126494 - 176800 == -50305)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (213420 - 201079 == 12342)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (85347 - 28932 == 56416)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (87218 - 391515 == -304296)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (58224 - 43149 == 15076)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54459 - 236444 != -181985)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (149672 - 354850 == -205177)
											{
												continue;
											}
											num = (float)0;
											if (17851 - 418423 != -400572)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (162091 - 212707 == -50615)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37969 - 79103 != -41134)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.4f);
										if (183738 - 333848 == -150109)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (60491 - 594468 != -533977)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (204997 - 244652 == -39655)
								{
									this.mChar.moveSpeed = num;
									if (213671 - 249745 == -36074)
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

	// Token: 0x06000539 RID: 1337 RVA: 0x0008CDB4 File Offset: 0x0008AFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (142713 - 351911 != -209197)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (280516 - 501125 != -220608)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (122531 - 286121 != -163589)
				{
					Vector3 vector = a - this.transform.position;
					if (156238 - 355016 != -198777)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (228455 - 490580 != -262124)
						{
							CharacterControl characterControl = null;
							if (83816 - 42493 == 41323 && 236607 - 378814 != -142206)
							{
								if (gameObject)
								{
									if (212056 - 152586 != 59470)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (214823 - 375379 != -160556)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (23891 - 84712 == -60820)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (200628 - 391013 != -190385)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (212136 - 301713 != -89577)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (154837 - 3739 != 151098)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (253403 - 206580 != 46824)
								{
									Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
									if (261112 - 529502 == -268390)
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

	// Token: 0x0600053A RID: 1338 RVA: 0x0008D058 File Offset: 0x0008B258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (243317 - 330943 != -87625)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (134785 - 413959 != -279173)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (159990 - 507574 == -347584)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (53975 - 348916 == -294941)
					{
						Vector3 normalized = vector.normalized;
						if (54218 - 282408 == -228190)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (247960 - 516908 != -268947)
							{
								CharacterControl characterControl = null;
								if (282068 - 368811 != -86742 && 21839 - 274229 != -252389)
								{
									if (gameObject)
									{
										if (226142 - 460759 == -234616)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (291602 - 572996 != -281394)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (80102 - 39865 != 40237)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (103748 - 469240 == -365491)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (3363 - 59358 != -55995)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (140669 - 332594 == -191924)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (254180 - 557158 != -302977)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (173377 - 296594 != -123216)
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

	// Token: 0x0600053B RID: 1339 RVA: 0x0008D324 File Offset: 0x0008B524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0008D328 File Offset: 0x0008B528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_leftSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MokBug.$RPC_leftSmash$16126(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0008D338 File Offset: 0x0008B538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_leftSmash_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (253966 - 266161 != -12195)
		{
		}
		for (;;)
		{
			if (this.leftSmash_hit)
			{
				if (150192 - 543473 != -393281)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.leftSmash_hit, hitPos, Quaternion.identity);
				if (190536 - 268569 != -78033)
				{
					continue;
				}
			}
			if (this.WtkchGWkKn >= Time.time)
			{
				break;
			}
			if (217449 - 376696 == -159247)
			{
				this.WtkchGWkKn = Time.time + 0.2f;
				if (101814 - 361732 != -259917)
				{
					if (!this.leftSmash_hitFx)
					{
						break;
					}
					if (182566 - 457984 == -275418)
					{
						this.audio.PlayOneShot(this.leftSmash_hitFx);
						if (123758 - 382802 == -259044)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0008D470 File Offset: 0x0008B670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rightSweep(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MokBug.$RPC_rightSweep$16140(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0008D480 File Offset: 0x0008B680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_rightSweep_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (150581 - 94351 != 56231)
		{
		}
		for (;;)
		{
			if (this.rightSweep_hit)
			{
				if (74561 - 169704 != -95143)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.rightSweep_hit, hitPos, Quaternion.identity);
				if (73166 - 4655 == 68512)
				{
					continue;
				}
			}
			if (this.UC9cKXZlWf >= Time.time)
			{
				break;
			}
			if (265845 - 390440 != -124594)
			{
				this.UC9cKXZlWf = Time.time + 0.2f;
				if (249228 - 526813 != -277584)
				{
					if (!this.rightSweep_hitFx)
					{
						break;
					}
					if (56480 - 309129 == -252649)
					{
						this.audio.PlayOneShot(this.rightSweep_hitFx);
						if (275063 - 172133 != 102931)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0008D5B8 File Offset: 0x0008B7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_headSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MokBug.$RPC_headSmash$16153(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0008D5C8 File Offset: 0x0008B7C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_headSmash_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (272230 - 32994 != 239237)
		{
		}
		for (;;)
		{
			if (this.headSmash_hit)
			{
				if (243853 - 200119 == 43735)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.headSmash_hit, hitPos, Quaternion.identity);
				if (173594 - 563091 != -389497)
				{
					continue;
				}
			}
			if (this.tYpczlcib0 >= Time.time)
			{
				break;
			}
			if (65685 - 446056 == -380371)
			{
				this.tYpczlcib0 = Time.time + 0.2f;
				if (147597 - 104997 != 42601)
				{
					if (!this.headSmash_hitFx)
					{
						break;
					}
					if (41122 - 465694 != -424571)
					{
						this.audio.PlayOneShot(this.headSmash_hitFx);
						if (127679 - 572117 == -444438)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0008D700 File Offset: 0x0008B900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_tailSpin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MokBug.$RPC_tailSpin$16166(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0008D710 File Offset: 0x0008B910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_tailSpin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (74064 - 221042 != -146978)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.tailSpin_hit, hitPos, Quaternion.identity);
			if (247406 - 267001 == -19595)
			{
				if (this.IAVn5q74iw >= Time.time)
				{
					break;
				}
				if (222059 - 365307 != -143247)
				{
					this.IAVn5q74iw = Time.time + 0.2f;
					if (98885 - 12216 == 86669)
					{
						if (!this.tailSpin_hitFx)
						{
							break;
						}
						if (221051 - 540855 != -319803)
						{
							this.audio.PlayOneShot(this.tailSpin_hitFx);
							if (178799 - 110626 != 68174)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0008D820 File Offset: 0x0008BA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_mokStomp(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MokBug.$RPC_mokStomp$16180(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0008D830 File Offset: 0x0008BA30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_battle(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (59184 - 380914 != -321730)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "battle";
			if (65659 - 5754 == 59905)
			{
				this.mChar.actionTime = Time.time;
				if (63952 - 119370 == -55418)
				{
					this.mChar.myCommand = "battle";
					if (179287 - 136677 == 42610)
					{
						this.mChar.addTimeOut("battle", (float)30);
						if (38848 - 170937 != -132088)
						{
							this.mChar.addTimeOut("standby", (float)180);
							if (273267 - 591564 == -318297)
							{
								this.transform.position = mPos;
								if (247381 - 434455 == -187074)
								{
									this.transform.LookAt(mPos + global::Math.vFlat(tDir));
									if (266834 - 583663 != -316828)
									{
										this.animation.CrossFade("battle", 0.5f);
										if (41104 - 203363 == -162259)
										{
											this.animation.wrapMode = WrapMode.Loop;
											if (122077 - 490812 == -368735)
											{
												this.mChar.vMovement = this.transform.forward;
												if (247947 - 515188 == -267241)
												{
													this.mChar.moveSpeed = (float)0;
													if (51397 - 222013 != -170615)
													{
														if (this.battle_fx)
														{
															if (82571 - 331179 == -248607)
															{
																continue;
															}
															this.audio.PlayOneShot(this.battle_fx);
															if (96744 - 438935 == -342190)
															{
																continue;
															}
														}
														if (this.mChar.isMine)
														{
															break;
														}
														if (37460 - 143574 != -106113)
														{
															this.mChar.nPosition = this.transform.position;
															if (212365 - 41039 == 171326)
															{
																this.mChar.oPosition = this.transform.position;
																if (80853 - 185196 != -104342)
																{
																	this.mChar.nDirection = this.transform.forward;
																	if (200058 - 60797 != 139262)
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

	// Token: 0x06000546 RID: 1350 RVA: 0x0008DB58 File Offset: 0x0008BD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MokBug.$RPC_ko$16192(nArray, this).GetEnumerator();
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0008DB68 File Offset: 0x0008BD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MokBug.$RPC_dead$16203(nArray, this).GetEnumerator();
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0008DB78 File Offset: 0x0008BD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0008DB7C File Offset: 0x0008BD7C
	internal static bool hmEkxScivdgvA4NoWTl()
	{
		return true;
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0008DB80 File Offset: 0x0008BD80
	internal static bool LQMOV8cKy6ywCrmNAfx()
	{
		return false;
	}

	// Token: 0x040004CC RID: 1228
	public CharacterControl mChar;

	// Token: 0x040004CD RID: 1229
	public CharacterControl mHeadChar;

	// Token: 0x040004CE RID: 1230
	public CharacterControl mLegChar1;

	// Token: 0x040004CF RID: 1231
	public CharacterControl mLegChar2;

	// Token: 0x040004D0 RID: 1232
	public CharacterControl mLegChar3;

	// Token: 0x040004D1 RID: 1233
	public CharacterControl mLegChar4;

	// Token: 0x040004D2 RID: 1234
	public CharacterControl mLegChar5;

	// Token: 0x040004D3 RID: 1235
	public CharacterControl mLegChar6;

	// Token: 0x040004D4 RID: 1236
	public CharacterControl mLegChar7;

	// Token: 0x040004D5 RID: 1237
	public CharacterControl mLegChar8;

	// Token: 0x040004D6 RID: 1238
	public CharacterControl mTailChar;

	// Token: 0x040004D7 RID: 1239
	public AudioClip footStep;

	// Token: 0x040004D8 RID: 1240
	public AudioClip leftSmash_fx;

	// Token: 0x040004D9 RID: 1241
	public GameObject leftSmash_hit;

	// Token: 0x040004DA RID: 1242
	public AudioClip leftSmash_hitFx;

	// Token: 0x040004DB RID: 1243
	private float WtkchGWkKn;

	// Token: 0x040004DC RID: 1244
	public AudioClip rightSweep_fx;

	// Token: 0x040004DD RID: 1245
	public GameObject rightSweep_hit;

	// Token: 0x040004DE RID: 1246
	public AudioClip rightSweep_hitFx;

	// Token: 0x040004DF RID: 1247
	private float UC9cKXZlWf;

	// Token: 0x040004E0 RID: 1248
	public AudioClip headSmash_fx;

	// Token: 0x040004E1 RID: 1249
	public GameObject headSmash_hit;

	// Token: 0x040004E2 RID: 1250
	public AudioClip headSmash_hitFx;

	// Token: 0x040004E3 RID: 1251
	private float tYpczlcib0;

	// Token: 0x040004E4 RID: 1252
	public GameObject tailSpin_ring;

	// Token: 0x040004E5 RID: 1253
	public GameObject tailSpin_hit;

	// Token: 0x040004E6 RID: 1254
	public AudioClip tailSpin_hitFx;

	// Token: 0x040004E7 RID: 1255
	private float IAVn5q74iw;

	// Token: 0x040004E8 RID: 1256
	public GameObject mokStomp_ring;

	// Token: 0x040004E9 RID: 1257
	public AudioClip battle_fx;

	// Token: 0x040004EA RID: 1258
	public GameObject ko_ring;

	// Token: 0x040004EB RID: 1259
	public AudioClip ko_fx;

	// Token: 0x020000ED RID: 237
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_leftSmash$16126 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x0008DB84 File Offset: 0x0008BD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_leftSmash$16126(Vector3 mPos, Vector3 tDir, MokBug self_)
		{
			if (83194 - 542826 != -459631)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247294 - 236297 != 10998)
				{
					base..ctor();
					if (126780 - 331902 != -205121)
					{
						this.$mPos$16137 = mPos;
						if (286050 - 538069 != -252018)
						{
							this.$tDir$16138 = tDir;
							if (60841 - 8076 == 52765)
							{
								this.$self_$16139 = self_;
								if (142748 - 70173 != 72576)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0008DC60 File Offset: 0x0008BE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_leftSmash$16126.$(this.$mPos$16137, this.$tDir$16138, this.$self_$16139);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0008DC7C File Offset: 0x0008BE7C
		internal static bool FOO78ycdQ7XekkIqVww()
		{
			return true;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0008DC80 File Offset: 0x0008BE80
		internal static bool K3nhSdcJEdMD54WPQyf()
		{
			return false;
		}

		// Token: 0x040004EC RID: 1260
		internal Vector3 $mPos$16137;

		// Token: 0x040004ED RID: 1261
		internal Vector3 $tDir$16138;

		// Token: 0x040004EE RID: 1262
		internal MokBug $self_$16139;

		// Token: 0x020000EE RID: 238
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600054F RID: 1359 RVA: 0x0008DC84 File Offset: 0x0008BE84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MokBug self_)
			{
				if (263128 - 451296 != -188167)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (170815 - 132418 != 38398)
					{
						base..ctor();
						if (11081 - 301845 == -290764)
						{
							this.$mPos$16134 = mPos;
							if (145394 - 490539 != -345144)
							{
								this.$tDir$16135 = tDir;
								if (148953 - 331450 != -182496)
								{
									this.$self_$16136 = self_;
									if (211607 - 40676 != 170932)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x0008DD60 File Offset: 0x0008BF60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48520 - 273769 != -225249)
				{
				}
				for (;;)
				{
					IL_108:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9C0;
					case 2:
						if (this.$self_$16136.mChar.actionState != "attack")
						{
							goto IL_8EE;
						}
						if (50030 - 355042 != -305012)
						{
							continue;
						}
						if (this.$self_$16136.mChar.myCommand != "leftSmash")
						{
							if (193958 - 10578 != 183380)
							{
								continue;
							}
							goto IL_8EE;
						}
						else
						{
							if (this.$self_$16136.mChar.isMine)
							{
								if (240928 - 297088 == -56159)
								{
									continue;
								}
								this.$hitPos$16127 = this.$self_$16136.transform.position + this.$self_$16136.transform.TransformDirection((float)-2, (float)0, (float)6);
								if (200994 - 513301 == -312306)
								{
									continue;
								}
								this.$hitLayer$16128 = 130816 - (1 << this.$self_$16136.gameObject.layer);
								if (283031 - 287369 != -4338)
								{
									continue;
								}
								this.$hitList$16129 = Damage.FindAreaTarget(this.$hitPos$16127, (float)8, (float)4, this.$hitLayer$16128);
								if (209248 - 249169 != -39921)
								{
									continue;
								}
								this.$hitDmg$16130 = this.$self_$16136.mLegChar1.atk;
								if (291677 - 121564 != 170113)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) < 24)
								{
									if (271757 - 113746 == 158012)
									{
										continue;
									}
									this.$hitDmg$16130 *= 2;
									if (87138 - 373306 != -286168)
									{
										continue;
									}
								}
								this.$$iterator$9944$16132 = UnityRuntimeServices.GetEnumerator(this.$hitList$16129);
								if (52954 - 435358 != -382404)
								{
									continue;
								}
								while (this.$$iterator$9944$16132.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9944$16132.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16131 = (GameObject)obj2;
									if (254099 - 273176 == -19076)
									{
										goto IL_108;
									}
									if (this.$self_$16136.mHeadChar.hit(1, this.$hitObject$16131, this.$hitDmg$16130, 10, 0, this.$hitObject$16131.transform.position - this.$hitPos$16127) != 0)
									{
										if (78287 - 143700 != -65413)
										{
											goto IL_108;
										}
										this.$self_$16136.RPC_leftSmash_hit(this.$hitObject$16131.collider.bounds.center, this.$self_$16136.transform.forward, 0);
										if (297692 - 485077 == -187384)
										{
											goto IL_108;
										}
										UnityRuntimeServices.Update(this.$$iterator$9944$16132, this.$hitObject$16131);
										if (288762 - 129847 != 158915)
										{
											goto IL_108;
										}
										this.$self_$16136.ActionEvent("RPC_leftSmash_hit", this.$hitObject$16131.collider.bounds.center, this.$self_$16136.transform.forward, 0);
										if (223762 - 2944 == 220819)
										{
											goto IL_108;
										}
										UnityRuntimeServices.Update(this.$$iterator$9944$16132, this.$hitObject$16131);
										if (223460 - 332278 == -108817)
										{
											goto IL_108;
										}
									}
								}
								if (294348 - 131646 != 162702)
								{
									continue;
								}
							}
							this.$mCamDistance$16133 = (this.$self_$16136.transform.position - Camera.main.transform.position).magnitude;
							if (18777 - 302652 != -283875)
							{
								continue;
							}
							if (this.$mCamDistance$16133 >= (float)40)
							{
								goto IL_16C;
							}
							if (209029 - 331906 != -122877)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.05f * ((float)40 - this.$mCamDistance$16133), 0.1f, 0.6f));
							if (170085 - 513155 != -343069)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16136.mChar.actionState == "attack")
						{
							if (229971 - 173826 != 56145)
							{
								continue;
							}
							if (this.$self_$16136.mChar.myCommand == "leftSmash")
							{
								if (279798 - 463325 == -183526)
								{
									continue;
								}
								this.$self_$16136.animation.CrossFade("battle", 0.4f);
								if (275159 - 43973 != 231186)
								{
									continue;
								}
								this.$self_$16136.animation.wrapMode = WrapMode.Loop;
								if (221353 - 140724 != 80629)
								{
									continue;
								}
								this.$self_$16136.mChar.actionState = "battle";
								if (214774 - 39735 == 175040)
								{
									continue;
								}
								this.$self_$16136.mChar.actionTime = Time.time;
								if (126407 - 554932 == -428524)
								{
									continue;
								}
								this.$self_$16136.mChar.myCommand = "none";
								if (235580 - 196355 == 39226)
								{
									continue;
								}
								if (!this.$self_$16136.mChar.isMine)
								{
									if (33773 - 555095 != -521322)
									{
										continue;
									}
									this.$self_$16136.mChar.nPosition = this.$self_$16136.transform.position;
									if (277702 - 298772 != -21070)
									{
										continue;
									}
									this.$self_$16136.mChar.oPosition = this.$self_$16136.transform.position;
									if (17009 - 87055 == -70045)
									{
										continue;
									}
									this.$self_$16136.mChar.nDirection = this.$self_$16136.transform.forward;
									if (184166 - 329864 != -145698)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (40315 - 304069 != -263754)
						{
							continue;
						}
						goto IL_9C0;
					default:
						if (292118 - 551361 != -259243)
						{
							continue;
						}
						break;
					}
					this.$self_$16136.mChar.actionState = "attack";
					if (140136 - 449935 == -309799)
					{
						this.$self_$16136.mChar.actionTime = Time.time;
						if (292701 - 91533 == 201168)
						{
							this.$self_$16136.mChar.myCommand = "leftSmash";
							if (61593 - 525224 != -463630)
							{
								this.$self_$16136.mChar.addTimeOut("nAttack", (float)2);
								if (144749 - 125491 == 19258)
								{
									this.$self_$16136.transform.position = this.$mPos$16134;
									if (44716 - 286756 != -242039)
									{
										this.$self_$16136.transform.LookAt(this.$mPos$16134 + global::Math.vFlat(this.$tDir$16135));
										if (216702 - 517178 != -300475)
										{
											this.$self_$16136.animation.CrossFade("leftSmash");
											if (17816 - 555687 != -537870)
											{
												this.$self_$16136.animation.wrapMode = WrapMode.Once;
												if (100336 - 586675 != -486338)
												{
													this.$self_$16136.mChar.vMovement = this.$self_$16136.transform.forward;
													if (213982 - 49194 == 164788)
													{
														this.$self_$16136.mChar.moveSpeed = (float)0;
														if (271940 - 352334 != -80393)
														{
															if (!this.$self_$16136.leftSmash_fx)
															{
																goto IL_971;
															}
															if (104760 - 456186 != -351425)
															{
																this.$self_$16136.audio.PlayOneShot(this.$self_$16136.leftSmash_fx);
																if (101061 - 92623 == 8438)
																{
																	goto IL_971;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_16C:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_29:
				goto IL_16C;
				IL_8EE:
				goto IL_9C0;
				IL_971:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_9C0:
				return false;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x0008E740 File Offset: 0x0008C940
			internal static bool kvqKnccDkot1PrjfFy8()
			{
				return true;
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x0008E744 File Offset: 0x0008C944
			internal static bool YWgBmIcv4AqHymsxhDd()
			{
				return false;
			}

			// Token: 0x040004EF RID: 1263
			internal Vector3 $hitPos$16127;

			// Token: 0x040004F0 RID: 1264
			internal int $hitLayer$16128;

			// Token: 0x040004F1 RID: 1265
			internal UnityScript.Lang.Array $hitList$16129;

			// Token: 0x040004F2 RID: 1266
			internal int $hitDmg$16130;

			// Token: 0x040004F3 RID: 1267
			internal GameObject $hitObject$16131;

			// Token: 0x040004F4 RID: 1268
			internal IEnumerator $$iterator$9944$16132;

			// Token: 0x040004F5 RID: 1269
			internal float $mCamDistance$16133;

			// Token: 0x040004F6 RID: 1270
			internal Vector3 $mPos$16134;

			// Token: 0x040004F7 RID: 1271
			internal Vector3 $tDir$16135;

			// Token: 0x040004F8 RID: 1272
			internal MokBug $self_$16136;
		}
	}

	// Token: 0x020000EF RID: 239
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rightSweep$16140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x0008E748 File Offset: 0x0008C948
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rightSweep$16140(Vector3 mPos, Vector3 tDir, MokBug self_)
		{
			if (10430 - 568351 != -557921)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237011 - 580500 == -343489)
				{
					base..ctor();
					if (68606 - 34694 == 33912)
					{
						this.$mPos$16150 = mPos;
						if (65765 - 207847 == -142082)
						{
							this.$tDir$16151 = tDir;
							if (263924 - 106271 != 157654)
							{
								this.$self_$16152 = self_;
								if (223633 - 540653 != -317019)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0008E824 File Offset: 0x0008CA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_rightSweep$16140.$(this.$mPos$16150, this.$tDir$16151, this.$self_$16152);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0008E840 File Offset: 0x0008CA40
		internal static bool aXEdxncRjq6MyQBQinW()
		{
			return true;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0008E844 File Offset: 0x0008CA44
		internal static bool GIhDbucw0oUbVwrs4IU()
		{
			return false;
		}

		// Token: 0x040004F9 RID: 1273
		internal Vector3 $mPos$16150;

		// Token: 0x040004FA RID: 1274
		internal Vector3 $tDir$16151;

		// Token: 0x040004FB RID: 1275
		internal MokBug $self_$16152;

		// Token: 0x020000F0 RID: 240
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000557 RID: 1367 RVA: 0x0008E848 File Offset: 0x0008CA48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MokBug self_)
			{
				if (103532 - 326463 != -222931)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90524 - 519201 == -428677)
					{
						base..ctor();
						if (11552 - 449602 != -438049)
						{
							this.$mPos$16147 = mPos;
							if (268629 - 117313 != 151317)
							{
								this.$tDir$16148 = tDir;
								if (15812 - 146838 != -131025)
								{
									this.$self_$16149 = self_;
									if (236847 - 122444 != 114404)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0008E924 File Offset: 0x0008CB24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159966 - 518363 != -358396)
				{
				}
				for (;;)
				{
					IL_570:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9DB;
					case 2:
						if (this.$self_$16149.mChar.actionState != "attack")
						{
							goto IL_7E4;
						}
						if (121262 - 502342 == -381079)
						{
							continue;
						}
						if (this.$self_$16149.mChar.myCommand != "rightSweep")
						{
							if (205268 - 59606 != 145663)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$hitLayer$16141 = 130816 - (1 << this.$self_$16149.gameObject.layer);
							if (289879 - 49452 == 240428)
							{
								continue;
							}
							this.$hitList$16142 = null;
							if (197651 - 429617 == -231965)
							{
								continue;
							}
							this.$hitDmg$16143 = this.$self_$16149.mLegChar5.atk;
							if (276361 - 36392 == 239970)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 100) < 24)
							{
								if (262954 - 399935 != -136981)
								{
									continue;
								}
								this.$hitDmg$16143 *= 2;
								if (222878 - 160786 != 62092)
								{
									continue;
								}
							}
							if (this.$self_$16149.mChar.isMine)
							{
								if (3002 - 147793 != -144791)
								{
									continue;
								}
								this.$hitList$16142 = Damage.FindRecTarget(this.$self_$16149.transform.position + this.$self_$16149.transform.TransformDirection((float)0, (float)0, (float)6), this.$self_$16149.transform.forward, (float)8, (float)6, (float)8, (float)4, this.$hitLayer$16141);
								if (252374 - 403114 != -150740)
								{
									continue;
								}
								this.$$iterator$9945$16145 = UnityRuntimeServices.GetEnumerator(this.$hitList$16142);
								if (78477 - 175999 != -97522)
								{
									continue;
								}
								while (this.$$iterator$9945$16145.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9945$16145.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16144 = (GameObject)obj2;
									if (256597 - 84685 == 171913)
									{
										goto IL_570;
									}
									if (this.$self_$16149.mHeadChar.hit(1, this.$hitObject$16144, this.$hitDmg$16143, 10, 0, (float)-2 * this.$self_$16149.transform.right) != 0)
									{
										if (240790 - 380545 != -139755)
										{
											goto IL_570;
										}
										this.$self_$16149.RPC_rightSweep_hit(this.$hitObject$16144.collider.bounds.center, (float)-2 * this.$self_$16149.transform.right, 0);
										if (34869 - 65319 != -30450)
										{
											goto IL_570;
										}
										UnityRuntimeServices.Update(this.$$iterator$9945$16145, this.$hitObject$16144);
										if (288309 - 527446 == -239136)
										{
											goto IL_570;
										}
										this.$self_$16149.ActionEvent("RPC_rightSweep_hit", this.$hitObject$16144.collider.bounds.center, (float)-2 * this.$self_$16149.transform.right, 0);
										if (28938 - 521984 == -493045)
										{
											goto IL_570;
										}
										UnityRuntimeServices.Update(this.$$iterator$9945$16145, this.$hitObject$16144);
										if (292953 - 256698 == 36256)
										{
											goto IL_570;
										}
									}
								}
								if (175243 - 319936 == -144692)
								{
									continue;
								}
							}
							this.$mCamDistance$16146 = (this.$self_$16149.transform.position - Camera.main.transform.position).magnitude;
							if (138315 - 416734 != -278419)
							{
								continue;
							}
							if (this.$mCamDistance$16146 >= (float)40)
							{
								goto IL_933;
							}
							if (154380 - 485265 == -330884)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.05f * ((float)40 - this.$mCamDistance$16146), 0.1f, 0.5f));
							if (88008 - 108049 != -20040)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16149.mChar.actionState == "attack")
						{
							if (56874 - 429535 != -372661)
							{
								continue;
							}
							if (this.$self_$16149.mChar.myCommand == "rightSweep")
							{
								if (135220 - 1004 == 134217)
								{
									continue;
								}
								this.$self_$16149.animation.CrossFade("battle", 0.4f);
								if (40761 - 175650 != -134889)
								{
									continue;
								}
								this.$self_$16149.animation.wrapMode = WrapMode.Loop;
								if (134457 - 50254 == 84204)
								{
									continue;
								}
								this.$self_$16149.mChar.actionState = "battle";
								if (298514 - 246738 != 51776)
								{
									continue;
								}
								this.$self_$16149.mChar.actionTime = Time.time;
								if (179435 - 438604 != -259169)
								{
									continue;
								}
								this.$self_$16149.mChar.myCommand = "none";
								if (219546 - 491624 != -272078)
								{
									continue;
								}
								if (!this.$self_$16149.mChar.isMine)
								{
									if (275311 - 347792 == -72480)
									{
										continue;
									}
									this.$self_$16149.mChar.nPosition = this.$self_$16149.transform.position;
									if (144852 - 535247 == -390394)
									{
										continue;
									}
									this.$self_$16149.mChar.oPosition = this.$self_$16149.transform.position;
									if (204658 - 22796 == 181863)
									{
										continue;
									}
									this.$self_$16149.mChar.nDirection = this.$self_$16149.transform.forward;
									if (215700 - 122935 == 92766)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (224791 - 310978 != -86187)
						{
							continue;
						}
						goto IL_9DB;
					default:
						if (240455 - 179963 != 60492)
						{
							continue;
						}
						break;
					}
					this.$self_$16149.mChar.actionState = "attack";
					if (264738 - 410021 == -145283)
					{
						this.$self_$16149.mChar.actionTime = Time.time;
						if (290879 - 188360 == 102519)
						{
							this.$self_$16149.mChar.myCommand = "rightSweep";
							if (268256 - 376517 != -108260)
							{
								this.$self_$16149.mChar.addTimeOut("nAttack", (float)2);
								if (163654 - 84143 != 79512)
								{
									this.$self_$16149.transform.position = this.$mPos$16147;
									if (7501 - 438239 == -430738)
									{
										this.$self_$16149.transform.LookAt(this.$mPos$16147 + global::Math.vFlat(this.$tDir$16148));
										if (198144 - 364659 == -166515)
										{
											this.$self_$16149.animation.CrossFade("rightSweep");
											if (10521 - 26977 == -16456)
											{
												this.$self_$16149.animation.wrapMode = WrapMode.Once;
												if (145823 - 391503 != -245679)
												{
													this.$self_$16149.mChar.vMovement = this.$self_$16149.transform.forward;
													if (247172 - 494102 == -246930)
													{
														this.$self_$16149.mChar.moveSpeed = (float)0;
														if (260169 - 192136 != 68034)
														{
															if (!this.$self_$16149.rightSweep_fx)
															{
																goto IL_5D4;
															}
															if (203611 - 234424 != -30812)
															{
																this.$self_$16149.audio.PlayOneShot(this.$self_$16149.rightSweep_fx);
																if (95929 - 2255 == 93674)
																{
																	goto IL_5D4;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_29:
				goto IL_933;
				IL_5D4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_37:
				IL_7E4:
				goto IL_9DB;
				IL_933:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_9DB:
				return false;
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0008F320 File Offset: 0x0008D520
			internal static bool yr2bgqcqohjmvE1nglF()
			{
				return true;
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x0008F324 File Offset: 0x0008D524
			internal static bool Il90KUc7xReOjKrqH6m()
			{
				return false;
			}

			// Token: 0x040004FC RID: 1276
			internal int $hitLayer$16141;

			// Token: 0x040004FD RID: 1277
			internal UnityScript.Lang.Array $hitList$16142;

			// Token: 0x040004FE RID: 1278
			internal int $hitDmg$16143;

			// Token: 0x040004FF RID: 1279
			internal GameObject $hitObject$16144;

			// Token: 0x04000500 RID: 1280
			internal IEnumerator $$iterator$9945$16145;

			// Token: 0x04000501 RID: 1281
			internal float $mCamDistance$16146;

			// Token: 0x04000502 RID: 1282
			internal Vector3 $mPos$16147;

			// Token: 0x04000503 RID: 1283
			internal Vector3 $tDir$16148;

			// Token: 0x04000504 RID: 1284
			internal MokBug $self_$16149;
		}
	}

	// Token: 0x020000F1 RID: 241
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_headSmash$16153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x0008F328 File Offset: 0x0008D528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_headSmash$16153(Vector3 mPos, Vector3 tDir, MokBug self_)
		{
			if (136887 - 290932 != -154044)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258921 - 501465 == -242544)
				{
					base..ctor();
					if (137596 - 136453 == 1143)
					{
						this.$mPos$16163 = mPos;
						if (299746 - 509681 != -209934)
						{
							this.$tDir$16164 = tDir;
							if (189597 - 61249 != 128349)
							{
								this.$self_$16165 = self_;
								if (204527 - 223683 != -19155)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0008F404 File Offset: 0x0008D604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_headSmash$16153.$(this.$mPos$16163, this.$tDir$16164, this.$self_$16165);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0008F420 File Offset: 0x0008D620
		internal static bool J8LDYbcPqG5pP7xO92Q()
		{
			return true;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0008F424 File Offset: 0x0008D624
		internal static bool mYjcgDc0rZBJCx4taYW()
		{
			return false;
		}

		// Token: 0x04000505 RID: 1285
		internal Vector3 $mPos$16163;

		// Token: 0x04000506 RID: 1286
		internal Vector3 $tDir$16164;

		// Token: 0x04000507 RID: 1287
		internal MokBug $self_$16165;

		// Token: 0x020000F2 RID: 242
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600055F RID: 1375 RVA: 0x0008F428 File Offset: 0x0008D628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MokBug self_)
			{
				if (96380 - 361238 != -264857)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23171 - 423795 == -400624)
					{
						base..ctor();
						if (163383 - 428797 != -265413)
						{
							this.$mPos$16160 = mPos;
							if (175819 - 153338 == 22481)
							{
								this.$tDir$16161 = tDir;
								if (18470 - 513696 != -495225)
								{
									this.$self_$16162 = self_;
									if (218168 - 381844 == -163676)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x0008F504 File Offset: 0x0008D704
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234119 - 11959 != 222160)
				{
				}
				for (;;)
				{
					IL_500:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9DE;
					case 2:
						if (this.$self_$16162.mChar.actionState != "attack")
						{
							goto IL_85;
						}
						if (271284 - 278454 == -7169)
						{
							continue;
						}
						if (this.$self_$16162.mChar.myCommand != "headSmash")
						{
							if (163901 - 347753 != -183851)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$hitLayer$16154 = 130816 - (1 << this.$self_$16162.gameObject.layer);
							if (4670 - 260966 != -256296)
							{
								continue;
							}
							this.$hitList$16155 = null;
							if (148374 - 369048 == -220673)
							{
								continue;
							}
							this.$hitDmg$16156 = this.$self_$16162.mLegChar5.atk;
							if (186453 - 16225 == 170229)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 100) < 24)
							{
								if (118296 - 78546 == 39751)
								{
									continue;
								}
								this.$hitDmg$16156 *= 2;
								if (56706 - 459766 == -403059)
								{
									continue;
								}
							}
							if (this.$self_$16162.mChar.isMine)
							{
								if (120999 - 169488 != -48489)
								{
									continue;
								}
								this.$hitList$16155 = Damage.FindRecTarget(this.$self_$16162.transform.position + this.$self_$16162.transform.TransformDirection((float)0, (float)0, (float)6), this.$self_$16162.transform.forward, (float)4, (float)4, (float)8, (float)7, this.$hitLayer$16154);
								if (228819 - 377723 != -148904)
								{
									continue;
								}
								this.$$iterator$9946$16158 = UnityRuntimeServices.GetEnumerator(this.$hitList$16155);
								if (225996 - 41230 == 184767)
								{
									continue;
								}
								while (this.$$iterator$9946$16158.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9946$16158.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16157 = (GameObject)obj2;
									if (41076 - 111090 != -70014)
									{
										goto IL_500;
									}
									if (this.$self_$16162.mHeadChar.hit(1, this.$hitObject$16157, this.$hitDmg$16156, 10, 0, (float)3 * this.$self_$16162.transform.forward) != 0)
									{
										if (51816 - 240797 != -188981)
										{
											goto IL_500;
										}
										this.$self_$16162.RPC_headSmash_hit(this.$hitObject$16157.collider.bounds.center, 1.5f * this.$self_$16162.transform.forward, 0);
										if (280459 - 284011 == -3551)
										{
											goto IL_500;
										}
										UnityRuntimeServices.Update(this.$$iterator$9946$16158, this.$hitObject$16157);
										if (211328 - 454506 != -243178)
										{
											goto IL_500;
										}
										this.$self_$16162.ActionEvent("RPC_headSmash_hit", this.$hitObject$16157.collider.bounds.center, 1.5f * this.$self_$16162.transform.forward, 0);
										if (7600 - 58288 != -50688)
										{
											goto IL_500;
										}
										UnityRuntimeServices.Update(this.$$iterator$9946$16158, this.$hitObject$16157);
										if (288360 - 45314 != 243046)
										{
											goto IL_500;
										}
									}
								}
								if (262658 - 368621 != -105963)
								{
									continue;
								}
							}
							this.$mCamDistance$16159 = (this.$self_$16162.transform.position - Camera.main.transform.position).magnitude;
							if (49106 - 519724 == -470617)
							{
								continue;
							}
							if (this.$mCamDistance$16159 >= (float)40)
							{
								goto IL_98F;
							}
							if (63924 - 88342 == -24417)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.05f * ((float)40 - this.$mCamDistance$16159), 0.1f, 0.5f));
							if (242672 - 369625 != -126952)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16162.mChar.actionState == "attack")
						{
							if (46523 - 181443 == -134919)
							{
								continue;
							}
							if (this.$self_$16162.mChar.myCommand == "headSmash")
							{
								if (278585 - 192971 == 85615)
								{
									continue;
								}
								this.$self_$16162.animation.CrossFade("battle", 0.4f);
								if (17563 - 105895 == -88331)
								{
									continue;
								}
								this.$self_$16162.animation.wrapMode = WrapMode.Loop;
								if (55550 - 468576 != -413026)
								{
									continue;
								}
								this.$self_$16162.mChar.actionState = "battle";
								if (226082 - 501929 != -275847)
								{
									continue;
								}
								this.$self_$16162.mChar.actionTime = Time.time;
								if (256124 - 283059 == -26934)
								{
									continue;
								}
								this.$self_$16162.mChar.myCommand = "none";
								if (138304 - 505588 != -367284)
								{
									continue;
								}
								if (!this.$self_$16162.mChar.isMine)
								{
									if (246486 - 332700 != -86214)
									{
										continue;
									}
									this.$self_$16162.mChar.nPosition = this.$self_$16162.transform.position;
									if (948 - 292314 != -291366)
									{
										continue;
									}
									this.$self_$16162.mChar.oPosition = this.$self_$16162.transform.position;
									if (278099 - 346939 == -68839)
									{
										continue;
									}
									this.$self_$16162.mChar.nDirection = this.$self_$16162.transform.forward;
									if (59870 - 375344 == -315473)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (282779 - 272573 != 10207)
						{
							goto Block_23;
						}
						continue;
					default:
						if (173064 - 47629 == 125436)
						{
							continue;
						}
						break;
					}
					this.$self_$16162.mChar.actionState = "attack";
					if (227751 - 85090 == 142661)
					{
						this.$self_$16162.mChar.actionTime = Time.time;
						if (33365 - 52701 == -19336)
						{
							this.$self_$16162.mChar.myCommand = "headSmash";
							if (50048 - 569464 != -519415)
							{
								this.$self_$16162.mChar.addTimeOut("nAttack", (float)2);
								if (31684 - 361126 != -329441)
								{
									this.$self_$16162.transform.position = this.$mPos$16160;
									if (264542 - 430877 == -166335)
									{
										this.$self_$16162.transform.LookAt(this.$mPos$16160 + global::Math.vFlat(this.$tDir$16161));
										if (171739 - 306954 == -135215)
										{
											this.$self_$16162.animation.CrossFade("headSmash");
											if (195330 - 192364 == 2966)
											{
												this.$self_$16162.animation.wrapMode = WrapMode.Once;
												if (7225 - 497735 != -490509)
												{
													this.$self_$16162.mChar.vMovement = this.$self_$16162.transform.forward;
													if (73265 - 252580 != -179314)
													{
														this.$self_$16162.mChar.moveSpeed = (float)0;
														if (24936 - 5218 != 19719)
														{
															if (!this.$self_$16162.headSmash_fx)
															{
																goto IL_613;
															}
															if (180253 - 416392 != -236138)
															{
																this.$self_$16162.audio.PlayOneShot(this.$self_$16162.headSmash_fx);
																if (266227 - 592040 != -325812)
																{
																	goto Block_55;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_85:
				Block_10:
				Block_23:
				goto IL_9DE;
				IL_613:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_43:
				goto IL_98F;
				Block_55:
				goto IL_613;
				IL_98F:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_9DE:
				return false;
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x0008FF04 File Offset: 0x0008E104
			internal static bool ICxUeNcb2gf4cEsCfNk()
			{
				return true;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0008FF08 File Offset: 0x0008E108
			internal static bool NFsEu7cuqGE4gA1eGry()
			{
				return false;
			}

			// Token: 0x04000508 RID: 1288
			internal int $hitLayer$16154;

			// Token: 0x04000509 RID: 1289
			internal UnityScript.Lang.Array $hitList$16155;

			// Token: 0x0400050A RID: 1290
			internal int $hitDmg$16156;

			// Token: 0x0400050B RID: 1291
			internal GameObject $hitObject$16157;

			// Token: 0x0400050C RID: 1292
			internal IEnumerator $$iterator$9946$16158;

			// Token: 0x0400050D RID: 1293
			internal float $mCamDistance$16159;

			// Token: 0x0400050E RID: 1294
			internal Vector3 $mPos$16160;

			// Token: 0x0400050F RID: 1295
			internal Vector3 $tDir$16161;

			// Token: 0x04000510 RID: 1296
			internal MokBug $self_$16162;
		}
	}

	// Token: 0x020000F3 RID: 243
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_tailSpin$16166 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x0008FF0C File Offset: 0x0008E10C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_tailSpin$16166(Vector3 mPos, Vector3 tDir, MokBug self_)
		{
			if (30427 - 230604 != -200177)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188007 - 35915 != 152093)
				{
					base..ctor();
					if (242892 - 57807 != 185086)
					{
						this.$mPos$16177 = mPos;
						if (214282 - 218065 == -3783)
						{
							this.$tDir$16178 = tDir;
							if (188689 - 453666 != -264976)
							{
								this.$self_$16179 = self_;
								if (225761 - 297554 == -71793)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0008FFE8 File Offset: 0x0008E1E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_tailSpin$16166.$(this.$mPos$16177, this.$tDir$16178, this.$self_$16179);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00090004 File Offset: 0x0008E204
		internal static bool yPEyJqcIy6hv4CcPyRN()
		{
			return true;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00090008 File Offset: 0x0008E208
		internal static bool YlUqSTcBBOtJEi28ftZ()
		{
			return false;
		}

		// Token: 0x04000511 RID: 1297
		internal Vector3 $mPos$16177;

		// Token: 0x04000512 RID: 1298
		internal Vector3 $tDir$16178;

		// Token: 0x04000513 RID: 1299
		internal MokBug $self_$16179;

		// Token: 0x020000F4 RID: 244
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000567 RID: 1383 RVA: 0x0009000C File Offset: 0x0008E20C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MokBug self_)
			{
				if (250188 - 259607 != -9418)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (186454 - 447137 != -260682)
					{
						base..ctor();
						if (208631 - 563822 == -355191)
						{
							this.$mPos$16174 = mPos;
							if (74540 - 479923 != -405382)
							{
								this.$tDir$16175 = tDir;
								if (287476 - 51743 == 235733)
								{
									this.$self_$16176 = self_;
									if (55478 - 209677 == -154199)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x000900E8 File Offset: 0x0008E2E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278177 - 96557 != 181620)
				{
				}
				for (;;)
				{
					IL_92D:
					switch (this._state)
					{
					case 0:
						goto IL_3AE;
					case 1:
						goto IL_A18;
					case 2:
						if (this.$self_$16176.mChar.actionState != "attack")
						{
							goto IL_115;
						}
						if (209256 - 255279 == -46022)
						{
							continue;
						}
						if (this.$self_$16176.mChar.myCommand != "tailSpin")
						{
							if (273752 - 516113 != -242361)
							{
								continue;
							}
							goto IL_115;
						}
						else
						{
							if (!this.$self_$16176.tailSpin_ring)
							{
								goto IL_1A;
							}
							if (78747 - 282633 != -203886)
							{
								continue;
							}
							this.$self_$16176.mChar.createEffect(this.$self_$16176.tailSpin_ring, this.$self_$16176.transform.position, Quaternion.identity);
							if (179978 - 184700 != -4721)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16176.mChar.actionState != "attack")
						{
							goto IL_630;
						}
						if (288550 - 469102 != -180552)
						{
							continue;
						}
						if (this.$self_$16176.mChar.myCommand != "tailSpin")
						{
							if (292379 - 514519 != -222140)
							{
								continue;
							}
							goto IL_630;
						}
						else
						{
							this.$i$16167 = 0;
							if (211506 - 425369 == -213862)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16176.mChar.actionState != "attack")
						{
							goto IL_701;
						}
						if (209340 - 599365 != -390025)
						{
							continue;
						}
						if (this.$self_$16176.mChar.myCommand != "tailSpin")
						{
							if (30077 - 418597 != -388520)
							{
								continue;
							}
							goto IL_701;
						}
						else
						{
							this.$i$16167++;
							if (198882 - 536552 != -337670)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$16176.mChar.actionState == "attack")
						{
							if (157059 - 121874 != 35185)
							{
								continue;
							}
							if (this.$self_$16176.mChar.myCommand == "tailSpin")
							{
								if (244180 - 241494 != 2686)
								{
									continue;
								}
								this.$self_$16176.animation.CrossFade("battle", 0.4f);
								if (290898 - 509125 != -218227)
								{
									continue;
								}
								this.$self_$16176.animation.wrapMode = WrapMode.Loop;
								if (63002 - 43832 != 19170)
								{
									continue;
								}
								this.$self_$16176.mChar.actionState = "battle";
								if (139681 - 214248 == -74566)
								{
									continue;
								}
								this.$self_$16176.mChar.actionTime = Time.time;
								if (263726 - 56551 != 207175)
								{
									continue;
								}
								this.$self_$16176.mChar.myCommand = "none";
								if (207657 - 35824 == 171834)
								{
									continue;
								}
								if (!this.$self_$16176.mChar.isMine)
								{
									if (213353 - 361780 == -148426)
									{
										continue;
									}
									this.$self_$16176.mChar.nPosition = this.$self_$16176.transform.position;
									if (266071 - 95418 != 170653)
									{
										continue;
									}
									this.$self_$16176.mChar.oPosition = this.$self_$16176.transform.position;
									if (259419 - 222439 == 36981)
									{
										continue;
									}
									this.$self_$16176.mChar.nDirection = this.$self_$16176.transform.forward;
									if (163229 - 410206 != -246977)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (72237 - 584244 != -512007)
						{
							continue;
						}
						goto IL_A18;
					default:
						if (150595 - 245123 != -94527)
						{
							goto IL_3AE;
						}
						continue;
					}
					if (this.$i$16167 >= 6)
					{
						if (3767 - 71645 != -67878)
						{
							continue;
						}
						goto IL_567;
					}
					else
					{
						if (this.$self_$16176.mChar.isMine)
						{
							if (104157 - 36910 == 67248)
							{
								continue;
							}
							this.$hitLayer$16168 = 130816 - (1 << this.$self_$16176.gameObject.layer);
							if (6574 - 206049 == -199474)
							{
								continue;
							}
							this.$hitList$16169 = Damage.FindAreaTarget(this.$self_$16176.transform.position, (float)32, (float)4, this.$hitLayer$16168);
							if (204909 - 173195 != 31714)
							{
								continue;
							}
							this.$hitDmg$16170 = 80;
							if (195212 - 489839 == -294626)
							{
								continue;
							}
							this.$$iterator$9947$16172 = UnityRuntimeServices.GetEnumerator(this.$hitList$16169);
							if (233697 - 465500 != -231803)
							{
								continue;
							}
							while (this.$$iterator$9947$16172.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9947$16172.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16171 = (GameObject)obj2;
								if (175789 - 33183 != 142606)
								{
									goto IL_92D;
								}
								this.$self_$16176.mHeadChar.hit(1, this.$hitObject$16171, this.$hitDmg$16170, 5, 0, 0.3f * Vector3.up);
								if (215370 - 108969 == 106402)
								{
									goto IL_92D;
								}
								UnityRuntimeServices.Update(this.$$iterator$9947$16172, this.$hitObject$16171);
								if (192327 - 189401 == 2927)
								{
									goto IL_92D;
								}
							}
							if (122585 - 135620 != -13035)
							{
								continue;
							}
						}
						if (this.$i$16167 % 2 != 1)
						{
							goto IL_3DD;
						}
						if (187027 - 110183 == 76845)
						{
							continue;
						}
						this.$mCamDistance$16173 = (this.$self_$16176.transform.position - Camera.main.transform.position).magnitude;
						if (28262 - 154226 != -125964)
						{
							continue;
						}
						if (this.$mCamDistance$16173 >= (float)40)
						{
							goto IL_3DD;
						}
						if (290217 - 1339 == 288879)
						{
							continue;
						}
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.05f * ((float)40 - this.$mCamDistance$16173), 0.1f, 0.5f));
						if (249111 - 49308 != 199804)
						{
							goto Block_21;
						}
						continue;
					}
					IL_3AE:
					this.$self_$16176.mChar.actionState = "attack";
					if (125686 - 589881 == -464195)
					{
						this.$self_$16176.mChar.actionTime = Time.time;
						if (194655 - 472765 != -278109)
						{
							this.$self_$16176.mChar.myCommand = "tailSpin";
							if (111468 - 75475 != 35994)
							{
								this.$self_$16176.mChar.addTimeOut("tailSpin", (float)18);
								if (182495 - 117067 != 65429)
								{
									this.$self_$16176.transform.position = this.$mPos$16174;
									if (192838 - 549786 == -356948)
									{
										this.$self_$16176.transform.LookAt(this.$mPos$16174 + global::Math.vFlat(this.$tDir$16175));
										if (200880 - 297739 != -96858)
										{
											this.$self_$16176.animation.CrossFade("tailSpin");
											if (199985 - 206143 != -6157)
											{
												this.$self_$16176.animation.wrapMode = WrapMode.Once;
												if (96221 - 457804 != -361582)
												{
													this.$self_$16176.mChar.vMovement = this.$self_$16176.transform.forward;
													if (37722 - 403765 != -366042)
													{
														this.$self_$16176.mChar.moveSpeed = (float)0;
														if (17405 - 400628 == -383223)
														{
															goto IL_283;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_115:
				goto IL_A18;
				IL_283:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_21:
				IL_3DD:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_567:
				return this.Yield(5, new WaitForSeconds(0.6f));
				IL_630:
				IL_701:
				goto IL_A18;
				Block_64:
				goto IL_1A;
				IL_A18:
				return false;
			}

			// Token: 0x06000569 RID: 1385 RVA: 0x00090B20 File Offset: 0x0008ED20
			internal static bool d47oAIceCDmQmtNwJck()
			{
				return true;
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x00090B24 File Offset: 0x0008ED24
			internal static bool H8JSSecrLqIMSRKl8U2()
			{
				return false;
			}

			// Token: 0x04000514 RID: 1300
			internal int $i$16167;

			// Token: 0x04000515 RID: 1301
			internal int $hitLayer$16168;

			// Token: 0x04000516 RID: 1302
			internal UnityScript.Lang.Array $hitList$16169;

			// Token: 0x04000517 RID: 1303
			internal int $hitDmg$16170;

			// Token: 0x04000518 RID: 1304
			internal GameObject $hitObject$16171;

			// Token: 0x04000519 RID: 1305
			internal IEnumerator $$iterator$9947$16172;

			// Token: 0x0400051A RID: 1306
			internal float $mCamDistance$16173;

			// Token: 0x0400051B RID: 1307
			internal Vector3 $mPos$16174;

			// Token: 0x0400051C RID: 1308
			internal Vector3 $tDir$16175;

			// Token: 0x0400051D RID: 1309
			internal MokBug $self_$16176;
		}
	}

	// Token: 0x020000F5 RID: 245
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_mokStomp$16180 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600056B RID: 1387 RVA: 0x00090B28 File Offset: 0x0008ED28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_mokStomp$16180(Vector3 mPos, Vector3 tDir, MokBug self_)
		{
			if (181228 - 526043 != -344815)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184338 - 97069 == 87269)
				{
					base..ctor();
					if (68851 - 481242 != -412390)
					{
						this.$mPos$16189 = mPos;
						if (14587 - 114928 == -100341)
						{
							this.$tDir$16190 = tDir;
							if (84089 - 523110 != -439020)
							{
								this.$self_$16191 = self_;
								if (11273 - 158401 == -147128)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00090C04 File Offset: 0x0008EE04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_mokStomp$16180.$(this.$mPos$16189, this.$tDir$16190, this.$self_$16191);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00090C20 File Offset: 0x0008EE20
		internal static bool CKIXsYcjd1JhLldMxEt()
		{
			return true;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00090C24 File Offset: 0x0008EE24
		internal static bool TkPihZchDaxXdTLpKcc()
		{
			return false;
		}

		// Token: 0x0400051E RID: 1310
		internal Vector3 $mPos$16189;

		// Token: 0x0400051F RID: 1311
		internal Vector3 $tDir$16190;

		// Token: 0x04000520 RID: 1312
		internal MokBug $self_$16191;

		// Token: 0x020000F6 RID: 246
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600056F RID: 1391 RVA: 0x00090C28 File Offset: 0x0008EE28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MokBug self_)
			{
				if (220852 - 514072 != -293220)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250957 - 511022 == -260065)
					{
						base..ctor();
						if (288092 - 52130 == 235962)
						{
							this.$mPos$16186 = mPos;
							if (218482 - 587493 == -369011)
							{
								this.$tDir$16187 = tDir;
								if (38328 - 59283 != -20954)
								{
									this.$self_$16188 = self_;
									if (71759 - 424752 == -352993)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00090D04 File Offset: 0x0008EF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227622 - 171800 != 55822)
				{
				}
				for (;;)
				{
					IL_4EB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_84A;
					case 2:
						if (this.$self_$16188.mChar.actionState != "attack")
						{
							goto IL_44F;
						}
						if (23855 - 142605 == -118749)
						{
							continue;
						}
						if (this.$self_$16188.mChar.myCommand != "mokStomp")
						{
							if (188503 - 259149 != -70646)
							{
								continue;
							}
							goto IL_44F;
						}
						else
						{
							if (this.$self_$16188.mokStomp_ring)
							{
								if (198731 - 490265 != -291534)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16188.mokStomp_ring, this.$self_$16188.transform.position + 4.5f * this.$self_$16188.transform.forward, Quaternion.identity);
								if (146378 - 284368 == -137989)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 2);
							if (53763 - 55660 != -1897)
							{
								continue;
							}
							if (!this.$self_$16188.mChar.isMine)
							{
								goto IL_682;
							}
							if (215501 - 367419 != -151918)
							{
								continue;
							}
							this.$hitLayer$16181 = 130816 - (1 << this.$self_$16188.gameObject.layer);
							if (249483 - 175868 == 73616)
							{
								continue;
							}
							this.$hitList$16182 = Damage.FindAreaTarget(this.$self_$16188.transform.position, (float)500, (float)4, this.$hitLayer$16181);
							if (104809 - 395216 != -290407)
							{
								continue;
							}
							this.$$iterator$9948$16185 = UnityRuntimeServices.GetEnumerator(this.$hitList$16182);
							if (13807 - 496314 != -482507)
							{
								continue;
							}
							while (this.$$iterator$9948$16185.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9948$16185.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16183 = (GameObject)obj2;
								if (6879 - 184164 == -177284)
								{
									goto IL_4EB;
								}
								this.$hitDmg$16184 = (int)Mathf.Clamp((float)2 * (this.$hitObject$16183.transform.position - this.$self_$16188.transform.position).magnitude, (float)200, (float)500);
								if (105069 - 402736 != -297667)
								{
									goto IL_4EB;
								}
								UnityRuntimeServices.Update(this.$$iterator$9948$16185, this.$hitObject$16183);
								if (199702 - 423720 == -224017)
								{
									goto IL_4EB;
								}
								this.$self_$16188.mHeadChar.hit(1, this.$hitObject$16183, this.$hitDmg$16184, 5, 0, 0.3f * Vector3.up);
								if (122941 - 329203 != -206262)
								{
									goto IL_4EB;
								}
								UnityRuntimeServices.Update(this.$$iterator$9948$16185, this.$hitObject$16183);
								if (25385 - 123742 == -98356)
								{
									goto IL_4EB;
								}
							}
							if (249950 - 329318 != -79367)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16188.mChar.actionState == "attack")
						{
							if (206054 - 111622 != 94432)
							{
								continue;
							}
							if (this.$self_$16188.mChar.myCommand == "mokStomp")
							{
								if (289143 - 570127 != -280984)
								{
									continue;
								}
								this.$self_$16188.animation.CrossFade("battle", 0.4f);
								if (85101 - 218920 != -133819)
								{
									continue;
								}
								this.$self_$16188.animation.wrapMode = WrapMode.Loop;
								if (232349 - 289526 != -57177)
								{
									continue;
								}
								this.$self_$16188.mChar.actionState = "battle";
								if (52463 - 466214 == -413750)
								{
									continue;
								}
								this.$self_$16188.mChar.actionTime = Time.time;
								if (102980 - 222252 != -119272)
								{
									continue;
								}
								this.$self_$16188.mChar.myCommand = "none";
								if (235847 - 363115 != -127268)
								{
									continue;
								}
								if (!this.$self_$16188.mChar.isMine)
								{
									if (115633 - 389954 == -274320)
									{
										continue;
									}
									this.$self_$16188.mChar.nPosition = this.$self_$16188.transform.position;
									if (257394 - 512974 == -255579)
									{
										continue;
									}
									this.$self_$16188.mChar.oPosition = this.$self_$16188.transform.position;
									if (285617 - 30892 == 254726)
									{
										continue;
									}
									this.$self_$16188.mChar.nDirection = this.$self_$16188.transform.forward;
									if (114230 - 218083 == -103852)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (45800 - 353904 != -308103)
						{
							goto Block_5;
						}
						continue;
					default:
						if (15562 - 96100 == -80537)
						{
							continue;
						}
						break;
					}
					this.$self_$16188.mChar.actionState = "attack";
					if (188601 - 341717 != -153115)
					{
						this.$self_$16188.mChar.actionTime = Time.time;
						if (1355 - 88677 == -87322)
						{
							this.$self_$16188.mChar.myCommand = "mokStomp";
							if (137256 - 124246 == 13010)
							{
								this.$self_$16188.mChar.addTimeOut("mokStomp", (float)30);
								if (32561 - 259955 == -227394)
								{
									this.$self_$16188.transform.position = this.$mPos$16186;
									if (11544 - 211632 != -200087)
									{
										this.$self_$16188.transform.LookAt(this.$mPos$16186 + global::Math.vFlat(this.$tDir$16187));
										if (169561 - 205873 != -36311)
										{
											this.$self_$16188.animation.CrossFade("mokStomp");
											if (58110 - 102504 != -44393)
											{
												this.$self_$16188.animation.wrapMode = WrapMode.Once;
												if (195143 - 87638 == 107505)
												{
													this.$self_$16188.mChar.vMovement = this.$self_$16188.transform.forward;
													if (139001 - 595543 == -456542)
													{
														this.$self_$16188.mChar.moveSpeed = (float)0;
														if (219518 - 92485 == 127033)
														{
															goto IL_768;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				IL_44F:
				goto IL_84A;
				IL_682:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_768:
				return this.Yield(2, new WaitForSeconds(1.3f));
				Block_46:
				goto IL_682;
				IL_84A:
				return false;
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00091570 File Offset: 0x0008F770
			internal static bool qvYwFZcsGBDJgTIu1WK()
			{
				return true;
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00091574 File Offset: 0x0008F774
			internal static bool l4jp9Zc9f20Kl9M4ZRw()
			{
				return false;
			}

			// Token: 0x04000521 RID: 1313
			internal int $hitLayer$16181;

			// Token: 0x04000522 RID: 1314
			internal UnityScript.Lang.Array $hitList$16182;

			// Token: 0x04000523 RID: 1315
			internal GameObject $hitObject$16183;

			// Token: 0x04000524 RID: 1316
			internal int $hitDmg$16184;

			// Token: 0x04000525 RID: 1317
			internal IEnumerator $$iterator$9948$16185;

			// Token: 0x04000526 RID: 1318
			internal Vector3 $mPos$16186;

			// Token: 0x04000527 RID: 1319
			internal Vector3 $tDir$16187;

			// Token: 0x04000528 RID: 1320
			internal MokBug $self_$16188;
		}
	}

	// Token: 0x020000F7 RID: 247
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16192 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00091578 File Offset: 0x0008F778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16192(UnityScript.Lang.Array nArray, MokBug self_)
		{
			if (14280 - 471052 != -456771)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160462 - 581324 != -420861)
				{
					base..ctor();
					if (23964 - 565122 == -541158)
					{
						this.$nArray$16201 = nArray;
						if (129758 - 530921 != -401162)
						{
							this.$self_$16202 = self_;
							if (114501 - 523587 == -409086)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00091634 File Offset: 0x0008F834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_ko$16192.$(this.$nArray$16201, this.$self_$16202);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00091648 File Offset: 0x0008F848
		internal static bool AtjbCGc1T3hRwO03RTj()
		{
			return true;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0009164C File Offset: 0x0008F84C
		internal static bool sZPKxJc4jQRMlHxbWnO()
		{
			return false;
		}

		// Token: 0x04000529 RID: 1321
		internal UnityScript.Lang.Array $nArray$16201;

		// Token: 0x0400052A RID: 1322
		internal MokBug $self_$16202;

		// Token: 0x020000F8 RID: 248
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000577 RID: 1399 RVA: 0x00091650 File Offset: 0x0008F850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MokBug self_)
			{
				if (72946 - 335403 != -262457)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5936 - 452095 == -446159)
					{
						base..ctor();
						if (32180 - 358678 == -326498)
						{
							this.$nArray$16199 = nArray;
							if (34082 - 394162 != -360079)
							{
								this.$self_$16200 = self_;
								if (66073 - 322526 != -256452)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x0009170C File Offset: 0x0008F90C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289004 - 598230 != -309226)
				{
				}
				for (;;)
				{
					IL_27D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9DA;
					case 2:
						if (this.$self_$16200.mChar.actionState != "ko")
						{
							if (169703 - 552730 != -383026)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							if (this.$self_$16200.ko_ring)
							{
								if (185133 - 334090 == -148956)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16200.ko_ring, this.$self_$16200.transform.position, this.$self_$16200.transform.rotation);
								if (191592 - 542761 != -351169)
								{
									continue;
								}
							}
							Vector3 vector = this.$self_$16200.transform.position - Camera.main.transform.position;
							if (159576 - 460969 == -301392)
							{
								continue;
							}
							if (vector.sqrMagnitude < (float)2500)
							{
								if (188471 - 278726 != -90255)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 2);
								if (206863 - 417183 != -210320)
								{
									continue;
								}
							}
							if (!this.$self_$16200.mChar.isMine)
							{
								goto IL_147;
							}
							if (109621 - 455246 != -345625)
							{
								continue;
							}
							this.$hitLayer$16195 = 130816 - (1 << this.$self_$16200.gameObject.layer);
							if (202454 - 401367 != -198913)
							{
								continue;
							}
							this.$hitList$16196 = Damage.FindAreaTarget(this.$self_$16200.transform.position, (float)6, (float)6, this.$hitLayer$16195);
							if (49313 - 340439 != -291126)
							{
								continue;
							}
							this.$$iterator$9943$16198 = UnityRuntimeServices.GetEnumerator(this.$hitList$16196);
							if (189873 - 104852 == 85022)
							{
								continue;
							}
							while (this.$$iterator$9943$16198.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9943$16198.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16197 = (GameObject)obj2;
								if (284417 - 238299 != 46118)
								{
									goto IL_27D;
								}
								this.$self_$16200.mHeadChar.hit(1, this.$hitObject$16197, 999, 20, 0, Vector3.up);
								if (184040 - 565989 != -381949)
								{
									goto IL_27D;
								}
								UnityRuntimeServices.Update(this.$$iterator$9943$16198, this.$hitObject$16197);
								if (219637 - 168331 != 51306)
								{
									goto IL_27D;
								}
							}
							if (233256 - 71424 != 161833)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16200.mChar.actionState != "ko")
						{
							if (236136 - 189883 != 46253)
							{
								continue;
							}
							goto IL_354;
						}
						else
						{
							this.$self_$16200.animation.Play("getUp");
							if (217836 - 279103 != -61267)
							{
								continue;
							}
							this.$self_$16200.animation.wrapMode = WrapMode.Once;
							if (289551 - 204664 != 84888)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16200.mChar.actionState != "ko")
						{
							if (232845 - 369525 != -136680)
							{
								continue;
							}
							goto IL_3C8;
						}
						else
						{
							this.$self_$16200.mChar.addTimeOut("battle", (float)12);
							if (142633 - 115096 == 27538)
							{
								continue;
							}
							this.$self_$16200.mChar.isAlert = false;
							if (211944 - 281538 != -69594)
							{
								continue;
							}
							this.$self_$16200.mChar.myAttackTarget = null;
							if (179199 - 567919 != -388720)
							{
								continue;
							}
							this.$self_$16200.mChar.actionState = "standby";
							if (84731 - 317096 == -232364)
							{
								continue;
							}
							this.$self_$16200.mChar.actionTime = Time.time;
							if (65295 - 39178 == 26118)
							{
								continue;
							}
							this.$self_$16200.mChar.myCommand = "none";
							if (89168 - 436062 != -346894)
							{
								continue;
							}
							this.$self_$16200.mChar.ko = this.$self_$16200.mChar.mko;
							if (213535 - 154164 == 59372)
							{
								continue;
							}
							this.$self_$16200.mHeadChar.ko = this.$self_$16200.mHeadChar.mko;
							if (42303 - 108355 != -66052)
							{
								continue;
							}
							if (!this.$self_$16200.mChar.isMine)
							{
								if (52445 - 451978 == -399532)
								{
									continue;
								}
								this.$self_$16200.mChar.nPosition = this.$self_$16200.transform.position;
								if (53355 - 14191 == 39165)
								{
									continue;
								}
								this.$self_$16200.mChar.oPosition = this.$self_$16200.transform.position;
								if (51369 - 139791 == -88421)
								{
									continue;
								}
								this.$self_$16200.mChar.nDirection = this.$self_$16200.transform.forward;
								if (200927 - 108996 == 91932)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (96098 - 196778 != -100679)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					default:
						if (78503 - 212868 != -134365)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16200.mChar.actionState == "ko")
					{
						goto IL_1B8;
					}
					if (142715 - 492082 != -349366)
					{
						if (this.$self_$16200.mChar.actionState == "dead")
						{
							if (181373 - 393604 != -212230)
							{
								goto Block_55;
							}
						}
						else
						{
							this.$mPos$16193 = (Vector3)this.$nArray$16199[0];
							if (71013 - 326610 == -255597)
							{
								this.$mDir$16194 = (Vector3)this.$nArray$16199[1];
								if (107977 - 398120 == -290143)
								{
									this.$self_$16200.mChar.ko = 0;
									if (17651 - 270240 == -252589)
									{
										this.$self_$16200.mHeadChar.ko = 0;
										if (289164 - 285685 != 3480)
										{
											this.$self_$16200.mChar.actionState = "ko";
											if (213706 - 166209 != 47498)
											{
												this.$self_$16200.mChar.actionTime = Time.time;
												if (47571 - 282186 != -234614)
												{
													this.$self_$16200.mChar.myCommand = "none";
													if (75692 - 396907 != -321214)
													{
														this.$self_$16200.mChar.vMovement = Vector3.zero;
														if (197328 - 194858 == 2470)
														{
															this.$self_$16200.mChar.moveSpeed = (float)0;
															if (204761 - 70711 != 134051)
															{
																this.$self_$16200.animation.Play("ko");
																if (223617 - 467807 != -244189)
																{
																	this.$self_$16200.animation.wrapMode = WrapMode.Once;
																	if (100544 - 235243 == -134699)
																	{
																		if (!this.$self_$16200.ko_fx)
																		{
																			goto IL_7E1;
																		}
																		if (6007 - 113323 != -107315)
																		{
																			this.$self_$16200.audio.PlayOneShot(this.$self_$16200.ko_fx);
																			if (163907 - 330809 == -166902)
																			{
																				goto IL_7E1;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_147:
				return this.Yield(3, new WaitForSeconds(7.2f));
				Block_12:
				IL_1B8:
				IL_354:
				IL_3C8:
				goto IL_9DA;
				Block_30:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_39:
				goto IL_147;
				IL_7E1:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_50:
				Block_55:
				IL_9DA:
				return false;
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00092108 File Offset: 0x00090308
			internal static bool rojPuqczfH6gHvhjCrp()
			{
				return true;
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x0009210C File Offset: 0x0009030C
			internal static bool igHjSIUad4ZxTW0baBV()
			{
				return false;
			}

			// Token: 0x0400052B RID: 1323
			internal Vector3 $mPos$16193;

			// Token: 0x0400052C RID: 1324
			internal Vector3 $mDir$16194;

			// Token: 0x0400052D RID: 1325
			internal int $hitLayer$16195;

			// Token: 0x0400052E RID: 1326
			internal UnityScript.Lang.Array $hitList$16196;

			// Token: 0x0400052F RID: 1327
			internal GameObject $hitObject$16197;

			// Token: 0x04000530 RID: 1328
			internal IEnumerator $$iterator$9943$16198;

			// Token: 0x04000531 RID: 1329
			internal UnityScript.Lang.Array $nArray$16199;

			// Token: 0x04000532 RID: 1330
			internal MokBug $self_$16200;
		}
	}

	// Token: 0x020000F9 RID: 249
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16203 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00092110 File Offset: 0x00090310
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16203(UnityScript.Lang.Array nArray, MokBug self_)
		{
			if (296593 - 557353 != -260759)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111662 - 67132 != 44531)
				{
					base..ctor();
					if (225318 - 510780 == -285462)
					{
						this.$nArray$16208 = nArray;
						if (277316 - 840 == 276476)
						{
							this.$self_$16209 = self_;
							if (230751 - 29571 == 201180)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000921CC File Offset: 0x000903CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MokBug.$RPC_dead$16203.$(this.$nArray$16208, this.$self_$16209);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000921E0 File Offset: 0x000903E0
		internal static bool MnlDq9U5In8UrQTgcU9()
		{
			return true;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000921E4 File Offset: 0x000903E4
		internal static bool HO35KLUp2rUgcn6Wn77()
		{
			return false;
		}

		// Token: 0x04000533 RID: 1331
		internal UnityScript.Lang.Array $nArray$16208;

		// Token: 0x04000534 RID: 1332
		internal MokBug $self_$16209;

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600057F RID: 1407 RVA: 0x000921E8 File Offset: 0x000903E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MokBug self_)
			{
				if (171514 - 441799 != -270284)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (236834 - 317352 != -80517)
					{
						base..ctor();
						if (149128 - 296139 != -147010)
						{
							this.$nArray$16206 = nArray;
							if (17244 - 292461 == -275217)
							{
								this.$self_$16207 = self_;
								if (243986 - 239756 == 4230)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x000922A4 File Offset: 0x000904A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192297 - 5670 != 186627)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_71A;
					case 2:
					{
						if (this.$self_$16207.ko_ring)
						{
							if (111170 - 477205 == -366034)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16207.ko_ring, this.$self_$16207.transform.position, this.$self_$16207.transform.rotation);
							if (41300 - 342060 == -300759)
							{
								continue;
							}
						}
						Vector3 vector = this.$self_$16207.transform.position - Camera.main.transform.position;
						if (140188 - 387030 != -246842)
						{
							continue;
						}
						if (vector.sqrMagnitude >= (float)2500)
						{
							goto IL_74;
						}
						if (245009 - 380749 != -135740)
						{
							continue;
						}
						Camera.main.SendMessage("AddCamereShake", 3);
						if (245719 - 359721 != -114001)
						{
							goto Block_13;
						}
						continue;
					}
					case 3:
						if (this.$self_$16207.mChar.actionState != "dead")
						{
							if (298050 - 224161 != 73889)
							{
								continue;
							}
							goto IL_2D8;
						}
						else
						{
							if (!this.$self_$16207.mChar.isPlayer)
							{
								if (166568 - 452142 == -285573)
								{
									continue;
								}
							}
							else if (this.$self_$16207.mChar.isMine)
							{
								if (128679 - 585152 != -456473)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16207.gameObject);
								if (98041 - 181687 == -83645)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (181133 - 307063 != -125930)
							{
								continue;
							}
							goto IL_71A;
						}
						break;
					default:
						if (299152 - 361566 == -62413)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16207.mChar.actionState == "dead")
					{
						if (209904 - 288688 == -78784)
						{
							goto IL_29D;
						}
					}
					else
					{
						this.$myPosition$16204 = (Vector3)this.$nArray$16206[0];
						if (215162 - 577972 == -362810)
						{
							this.$myDirection$16205 = (Vector3)this.$nArray$16206[1];
							if (291628 - 354329 == -62701)
							{
								this.$self_$16207.transform.position = this.$myPosition$16204;
								if (96157 - 270122 == -173965)
								{
									this.$self_$16207.transform.LookAt(this.$myPosition$16204 + this.$myDirection$16205);
									if (203887 - 337750 == -133863)
									{
										this.$self_$16207.mChar.hp = 0;
										if (264780 - 346470 == -81690)
										{
											this.$self_$16207.mHeadChar.hp = 0;
											if (281516 - 304585 == -23069)
											{
												this.$self_$16207.mLegChar1.hp = 0;
												if (222823 - 372353 == -149530)
												{
													this.$self_$16207.mLegChar2.hp = 0;
													if (192655 - 148897 == 43758)
													{
														this.$self_$16207.mLegChar3.hp = 0;
														if (281647 - 234380 != 47268)
														{
															this.$self_$16207.mLegChar4.hp = 0;
															if (21280 - 200983 != -179702)
															{
																this.$self_$16207.mLegChar5.hp = 0;
																if (137943 - 77901 != 60043)
																{
																	this.$self_$16207.mLegChar6.hp = 0;
																	if (229542 - 11623 != 217920)
																	{
																		this.$self_$16207.mLegChar7.hp = 0;
																		if (168256 - 181441 == -13185)
																		{
																			this.$self_$16207.mLegChar8.hp = 0;
																			if (285804 - 517356 == -231552)
																			{
																				this.$self_$16207.mChar.actionState = "dead";
																				if (252840 - 121579 == 131261)
																				{
																					this.$self_$16207.mChar.actionTime = Time.time;
																					if (41090 - 589255 != -548164)
																					{
																						this.$self_$16207.mChar.myCommand = "none";
																						if (244670 - 266485 != -21814)
																						{
																							this.$self_$16207.mChar.vMovement = Vector3.zero;
																							if (292248 - 225429 == 66819)
																							{
																								this.$self_$16207.mChar.moveSpeed = (float)0;
																								if (41543 - 487448 == -445905)
																								{
																									this.$self_$16207.animation.Rewind();
																									if (65583 - 333173 == -267590)
																									{
																										this.$self_$16207.animation.Play("ko");
																										if (52137 - 407422 == -355285)
																										{
																											this.$self_$16207.animation.wrapMode = WrapMode.Once;
																											if (51910 - 554461 != -502550)
																											{
																												if (!this.$self_$16207.ko_fx)
																												{
																													goto IL_168;
																												}
																												if (44199 - 206117 == -161918)
																												{
																													this.$self_$16207.audio.PlayOneShot(this.$self_$16207.ko_fx);
																													if (23367 - 324620 != -301252)
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
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_74:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_168:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_13:
				goto IL_74;
				IL_29D:
				IL_2D8:
				goto IL_71A;
				Block_30:
				goto IL_168;
				IL_71A:
				return false;
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x000929E0 File Offset: 0x00090BE0
			internal static bool nYUbwHUVMpoMK06oK6S()
			{
				return true;
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x000929E4 File Offset: 0x00090BE4
			internal static bool ih9nX1Ut132oSjTnEvZ()
			{
				return false;
			}

			// Token: 0x04000535 RID: 1333
			internal Vector3 $myPosition$16204;

			// Token: 0x04000536 RID: 1334
			internal Vector3 $myDirection$16205;

			// Token: 0x04000537 RID: 1335
			internal UnityScript.Lang.Array $nArray$16206;

			// Token: 0x04000538 RID: 1336
			internal MokBug $self_$16207;
		}
	}
}
