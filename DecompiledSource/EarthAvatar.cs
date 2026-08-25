using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003EE RID: 1006
[Serializable]
public class EarthAvatar : MonoBehaviour
{
	// Token: 0x06001785 RID: 6021 RVA: 0x00268EC4 File Offset: 0x002670C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EarthAvatar()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00268ED4 File Offset: 0x002670D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (59490 - 413927 != -354437)
		{
		}
		for (;;)
		{
			this.SGnOmIT5kc = this.transform;
			if (86542 - 234518 == -147976)
			{
				this.PvKOjCyM7Z = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (64579 - 425733 != -361153)
				{
					GameObject gameObject = global::Math.findChildObject(this.transform, "Spine1").gameObject;
					if (166573 - 238318 == -71745)
					{
						if (gameObject)
						{
							if (195552 - 28821 != 166731)
							{
								continue;
							}
							this.W8sOouetqD = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (59739 - 254209 == -194469)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find Spine1 object");
							if (257623 - 139674 == 117950)
							{
								continue;
							}
						}
						GameObject gameObject2 = global::Math.findChildObject(this.transform, "UpperArm_L").gameObject;
						if (276386 - 312935 == -36549)
						{
							if (gameObject2)
							{
								if (213523 - 339268 == -125744)
								{
									continue;
								}
								this.VwcOk8IdHq = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
								if (196348 - 426633 == -230284)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find UpperArm_L object");
								if (253720 - 57941 == 195780)
								{
									continue;
								}
							}
							GameObject gameObject3 = global::Math.findChildObject(this.transform, "UpperArm_R").gameObject;
							if (34005 - 499214 == -465209)
							{
								if (gameObject3)
								{
									if (135498 - 175697 == -40198)
									{
										continue;
									}
									this.y2tOFAohMA = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
									if (253621 - 401153 == -147531)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find UpperArm_R object");
									if (241811 - 275909 == -34097)
									{
										continue;
									}
								}
								GameObject gameObject4 = global::Math.findChildObject(this.transform, "EarthAvatar_tri").gameObject;
								if (93182 - 163623 == -70441)
								{
									if (gameObject4)
									{
										if (264841 - 333010 != -68169)
										{
											continue;
										}
										this.UFyOAmoosn = (CharacterControl)gameObject4.GetComponent(typeof(CharacterControl));
										if (107729 - 164852 == -57122)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find EarthAvatar_tri object");
										if (299589 - 476416 == -176826)
										{
											continue;
										}
									}
									this.PvKOjCyM7Z.hp = (this.PvKOjCyM7Z.mhp = 70000);
									if (288880 - 136881 != 152000)
									{
										this.PvKOjCyM7Z.ko = (this.PvKOjCyM7Z.mko = 650);
										if (177364 - 280520 == -103156)
										{
											this.PvKOjCyM7Z.atk = 450;
											if (28487 - 152867 != -124379)
											{
												this.PvKOjCyM7Z.def = 500;
												if (236949 - 399595 == -162646)
												{
													this.PvKOjCyM7Z.agi = 150;
													if (88072 - 44705 != 43368)
													{
														this.PvKOjCyM7Z.vit = 7000;
														if (291514 - 328322 != -36807)
														{
															this.PvKOjCyM7Z.mag = 150;
															if (30516 - 565252 != -534735)
															{
																this.PvKOjCyM7Z.cha = 150;
																if (108292 - 49678 == 58614)
																{
																	this.PvKOjCyM7Z.tal = 150;
																	if (186112 - 310904 == -124792)
																	{
																		this.PvKOjCyM7Z.lck = 150;
																		if (282061 - 547945 != -265883)
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

	// Token: 0x06001787 RID: 6023 RVA: 0x002693F8 File Offset: 0x002675F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (187485 - 471977 != -284491)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (216028 - 451289 == -235260)
				{
					continue;
				}
				this.PvKOjCyM7Z.isMine = true;
				if (1659 - 285516 == -283856)
				{
					continue;
				}
			}
			if (this.PvKOjCyM7Z.ActorNr != 0)
			{
				if (109682 - 19087 != 90595)
				{
					continue;
				}
				if (this.W8sOouetqD)
				{
					if (125834 - 570364 != -444530)
					{
						continue;
					}
					this.W8sOouetqD.ActorNr = this.PvKOjCyM7Z.ActorNr + 1;
					if (75947 - 105801 != -29854)
					{
						continue;
					}
					this.W8sOouetqD.ownerID = this.PvKOjCyM7Z.ownerID;
					if (28762 - 78029 == -49266)
					{
						continue;
					}
					this.W8sOouetqD.gameObject.layer = this.gameObject.layer;
					if (204618 - 553612 == -348993)
					{
						continue;
					}
					this.W8sOouetqD.isPlayer = false;
					if (157385 - 576143 != -418758)
					{
						continue;
					}
					this.W8sOouetqD.isControlled = false;
					if (149717 - 345160 != -195443)
					{
						continue;
					}
					if (this.PvKOjCyM7Z.ownerID == PlayerData.UID)
					{
						if (214708 - 514663 != -299955)
						{
							continue;
						}
						this.W8sOouetqD.isMine = true;
						if (253606 - 489697 == -236090)
						{
							continue;
						}
					}
					else
					{
						this.W8sOouetqD.isMine = false;
						if (203137 - 147575 != 55562)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.W8sOouetqD.ActorNr], null))
					{
						if (8017 - 252256 == -244238)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.W8sOouetqD.ActorNr + " already existed");
						if (100091 - 560894 != -460803)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.W8sOouetqD.ActorNr];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (134114 - 253222 != -119108)
						{
							continue;
						}
						if (gameObject)
						{
							if (68345 - 465992 == -397646)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject);
							if (242268 - 242664 != -396)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.W8sOouetqD.ActorNr, this.W8sOouetqD.gameObject);
					if (19937 - 144803 == -124865)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mBodyChar");
					if (161711 - 305595 == -143883)
					{
						continue;
					}
				}
				if (this.VwcOk8IdHq)
				{
					if (62944 - 186294 != -123350)
					{
						continue;
					}
					this.VwcOk8IdHq.ActorNr = this.PvKOjCyM7Z.ActorNr + 2;
					if (160853 - 36412 != 124441)
					{
						continue;
					}
					this.VwcOk8IdHq.ownerID = this.PvKOjCyM7Z.ownerID;
					if (142953 - 540996 != -398043)
					{
						continue;
					}
					this.VwcOk8IdHq.gameObject.layer = this.gameObject.layer;
					if (278039 - 266902 != 11137)
					{
						continue;
					}
					this.VwcOk8IdHq.isPlayer = false;
					if (51258 - 487789 == -436530)
					{
						continue;
					}
					this.VwcOk8IdHq.isControlled = false;
					if (243574 - 19964 != 223610)
					{
						continue;
					}
					if (this.PvKOjCyM7Z.ownerID == PlayerData.UID)
					{
						if (277793 - 560286 == -282492)
						{
							continue;
						}
						this.VwcOk8IdHq.isMine = true;
						if (208589 - 138054 != 70535)
						{
							continue;
						}
					}
					else
					{
						this.VwcOk8IdHq.isMine = false;
						if (61978 - 295100 != -233122)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.VwcOk8IdHq.ActorNr], null))
					{
						if (79293 - 256359 == -177065)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.VwcOk8IdHq.ActorNr + " already existed");
						if (145887 - 264794 == -118906)
						{
							continue;
						}
						object obj4;
						object obj3 = obj4 = PhotonClient.ActorNrList[this.VwcOk8IdHq.ActorNr];
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj4;
						if (3121 - 342497 == -339375)
						{
							continue;
						}
						if (gameObject2)
						{
							if (58046 - 291863 == -233816)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject2);
							if (25552 - 228185 != -202633)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.VwcOk8IdHq.ActorNr, this.VwcOk8IdHq.gameObject);
					if (66711 - 217730 == -151018)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mLeftArmChar");
					if (52369 - 298762 != -246393)
					{
						continue;
					}
				}
				if (this.y2tOFAohMA)
				{
					if (13541 - 389681 == -376139)
					{
						continue;
					}
					this.y2tOFAohMA.ActorNr = this.PvKOjCyM7Z.ActorNr + 3;
					if (125084 - 40697 == 84388)
					{
						continue;
					}
					this.y2tOFAohMA.ownerID = this.PvKOjCyM7Z.ownerID;
					if (130438 - 554766 != -424328)
					{
						continue;
					}
					this.y2tOFAohMA.gameObject.layer = this.gameObject.layer;
					if (260999 - 462121 == -201121)
					{
						continue;
					}
					this.y2tOFAohMA.isPlayer = false;
					if (95915 - 181324 != -85409)
					{
						continue;
					}
					this.y2tOFAohMA.isControlled = false;
					if (256177 - 158808 != 97369)
					{
						continue;
					}
					if (this.PvKOjCyM7Z.ownerID == PlayerData.UID)
					{
						if (263715 - 556925 != -293210)
						{
							continue;
						}
						this.y2tOFAohMA.isMine = true;
						if (268610 - 171253 != 97357)
						{
							continue;
						}
					}
					else
					{
						this.y2tOFAohMA.isMine = false;
						if (225764 - 345387 == -119622)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.y2tOFAohMA.ActorNr], null))
					{
						if (90983 - 423912 == -332928)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.y2tOFAohMA.ActorNr + " already existed");
						if (196056 - 578476 != -382420)
						{
							continue;
						}
						object obj6;
						object obj5 = obj6 = PhotonClient.ActorNrList[this.y2tOFAohMA.ActorNr];
						if (!(obj5 is GameObject))
						{
							obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
						}
						GameObject gameObject3 = (GameObject)obj6;
						if (70618 - 568080 != -497462)
						{
							continue;
						}
						if (gameObject3)
						{
							if (49579 - 3320 != 46259)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject3);
							if (149118 - 82237 != 66881)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.y2tOFAohMA.ActorNr, this.y2tOFAohMA.gameObject);
					if (226777 - 157569 == 69209)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mRightArmChar");
					if (179100 - 289140 != -110040)
					{
						continue;
					}
				}
				if (this.UFyOAmoosn)
				{
					if (228163 - 569637 != -341474)
					{
						continue;
					}
					this.UFyOAmoosn.ActorNr = this.PvKOjCyM7Z.ActorNr + 4;
					if (25639 - 184906 == -159266)
					{
						continue;
					}
					this.UFyOAmoosn.ownerID = this.PvKOjCyM7Z.ownerID;
					if (41488 - 149373 != -107885)
					{
						continue;
					}
					this.UFyOAmoosn.gameObject.layer = this.gameObject.layer;
					if (117790 - 293825 == -176034)
					{
						continue;
					}
					this.UFyOAmoosn.isPlayer = false;
					if (96519 - 99693 != -3174)
					{
						continue;
					}
					this.UFyOAmoosn.isControlled = false;
					if (23248 - 393724 != -370476)
					{
						continue;
					}
					if (this.PvKOjCyM7Z.ownerID == PlayerData.UID)
					{
						if (295329 - 213543 != 81786)
						{
							continue;
						}
						this.UFyOAmoosn.isMine = true;
						if (150787 - 233193 == -82405)
						{
							continue;
						}
					}
					else
					{
						this.UFyOAmoosn.isMine = false;
						if (240418 - 107356 != 133062)
						{
							continue;
						}
					}
					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.UFyOAmoosn.ActorNr], null))
					{
						if (296258 - 267323 != 28935)
						{
							continue;
						}
						Debug.LogError("ActorNr: " + this.UFyOAmoosn.ActorNr + " already existed");
						if (76736 - 470044 == -393307)
						{
							continue;
						}
						object obj8;
						object obj7 = obj8 = PhotonClient.ActorNrList[this.UFyOAmoosn.ActorNr];
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						GameObject gameObject4 = (GameObject)obj8;
						if (185556 - 12269 != 173287)
						{
							continue;
						}
						if (gameObject4)
						{
							if (240071 - 559961 != -319890)
							{
								continue;
							}
							UnityEngine.Object.Destroy(gameObject4);
							if (74409 - 38177 == 36233)
							{
								continue;
							}
						}
					}
					PhotonClient.ActorNrList.Add(this.UFyOAmoosn.ActorNr, this.UFyOAmoosn.gameObject);
					if (177210 - 189297 != -12087)
					{
						continue;
					}
				}
				else
				{
					Debug.LogError("Missing mBaseChar");
					if (15683 - 207531 == -191847)
					{
						continue;
					}
				}
			}
			if (!this.PvKOjCyM7Z)
			{
				break;
			}
			if (141109 - 237478 != -96368)
			{
				this.PvKOjCyM7Z.mImmuneList = new UnityScript.Lang.Array(new object[]
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
				if (267029 - 502551 != -235521)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x0026A1A4 File Offset: 0x002683A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (175306 - 486526 != -311219)
		{
		}
		for (;;)
		{
			if (this.PvKOjCyM7Z)
			{
				if (125191 - 141177 != -15986)
				{
					continue;
				}
				if (this.W8sOouetqD)
				{
					if (252122 - 57263 == 194860)
					{
						continue;
					}
					if (this.VwcOk8IdHq)
					{
						if (91192 - 418639 != -327447)
						{
							continue;
						}
						if (this.y2tOFAohMA)
						{
							if (88245 - 328233 != -239988)
							{
								continue;
							}
							if (this.UFyOAmoosn)
							{
								if (40107 - 13500 != 26607)
								{
									continue;
								}
								this.PvKOjCyM7Z.hp = Mathf.Clamp(this.W8sOouetqD.hp + this.VwcOk8IdHq.hp + this.y2tOFAohMA.hp + this.UFyOAmoosn.hp, 0, 70000);
								if (252980 - 131826 != 121154)
								{
									continue;
								}
								if (this.W8sOouetqD.mLastDamageID != 0)
								{
									if (92762 - 361459 == -268696)
									{
										continue;
									}
									this.PvKOjCyM7Z.mLastDamageID = this.W8sOouetqD.mLastDamageID;
									if (295652 - 568902 == -273249)
									{
										continue;
									}
									this.W8sOouetqD.mLastDamageID = 0;
									if (12161 - 388775 != -376614)
									{
										continue;
									}
								}
								if (this.VwcOk8IdHq.mLastDamageID != 0)
								{
									if (56519 - 146527 != -90008)
									{
										continue;
									}
									this.PvKOjCyM7Z.mLastDamageID = this.VwcOk8IdHq.mLastDamageID;
									if (6279 - 531293 != -525014)
									{
										continue;
									}
									this.VwcOk8IdHq.mLastDamageID = 0;
									if (65004 - 555363 != -490359)
									{
										continue;
									}
								}
								if (this.y2tOFAohMA.mLastDamageID != 0)
								{
									if (69496 - 471039 == -401542)
									{
										continue;
									}
									this.PvKOjCyM7Z.mLastDamageID = this.y2tOFAohMA.mLastDamageID;
									if (1104 - 201591 != -200487)
									{
										continue;
									}
									this.y2tOFAohMA.mLastDamageID = 0;
									if (98163 - 508418 == -410254)
									{
										continue;
									}
								}
								if (this.UFyOAmoosn.mLastDamageID != 0)
								{
									if (181641 - 544689 != -363048)
									{
										continue;
									}
									this.PvKOjCyM7Z.mLastDamageID = this.UFyOAmoosn.mLastDamageID;
									if (37798 - 438657 == -400858)
									{
										continue;
									}
									this.UFyOAmoosn.mLastDamageID = 0;
									if (162142 - 381624 == -219481)
									{
										continue;
									}
								}
							}
						}
					}
				}
			}
			if (this.PvKOjCyM7Z.isControlled)
			{
				if (91280 - 82857 == 8424)
				{
					continue;
				}
				if (!(this.PvKOjCyM7Z.actionState == "standby"))
				{
					if (106937 - 121533 == -14595)
					{
						continue;
					}
					if (!(this.PvKOjCyM7Z.actionState == "run"))
					{
						goto IL_29B;
					}
					if (231277 - 356577 != -125300)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (156751 - 362561 == -205809)
				{
					continue;
				}
			}
			IL_29B:
			if (this.PvKOjCyM7Z.hp > 0)
			{
				break;
			}
			if (70028 - 397654 != -327625)
			{
				if (!(this.PvKOjCyM7Z.actionState != "dead"))
				{
					break;
				}
				if (180631 - 409987 == -229356)
				{
					if (this.PvKOjCyM7Z.isMine)
					{
						if (236673 - 185865 != 50809)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (214573 - 483651 == -269078)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (60849 - 202383 == -141534)
								{
									this.PvKOjCyM7Z.DeadEvent();
									if (266582 - 428382 != -161799)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.PvKOjCyM7Z.hp = 1;
						if (91786 - 267822 != -176035)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x0026A714 File Offset: 0x00268914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (139933 - 245659 != -105725)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (280603 - 522466 != -241862)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (200122 - 494007 != -293884 && 241013 - 180267 != 60747)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (243652 - 195358 != 48294)
						{
							continue;
						}
						v = 1;
						if (45654 - 443505 == -397850)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (32115 - 352192 == -320076)
						{
							continue;
						}
						v = 2;
						if (83408 - 229847 != -146439)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack3")
					{
						if (188610 - 302079 != -113469)
						{
							continue;
						}
						v = 3;
						if (153222 - 429609 == -276386)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack4")
					{
						if (179986 - 64027 == 115960)
						{
							continue;
						}
						v = 4;
						if (156783 - 397677 != -240894)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sweep1")
					{
						if (205613 - 236670 == -31056)
						{
							continue;
						}
						v = 11;
						if (159406 - 304229 != -144823)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sweep2")
					{
						if (284128 - 178230 == 105899)
						{
							continue;
						}
						v = 12;
						if (9845 - 222590 != -212745)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sweep3")
					{
						if (180531 - 387015 == -206483)
						{
							continue;
						}
						v = 13;
						if (30987 - 562312 == -531324)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sweep_hit")
					{
						if (5812 - 348271 == -342458)
						{
							continue;
						}
						v = -11;
						if (153991 - 97563 == 56429)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_groundStrike")
					{
						if (94633 - 556420 == -461786)
						{
							continue;
						}
						v = 21;
						if (28494 - 183053 != -154559)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_groundStrike_hit")
					{
						if (137380 - 545078 != -407698)
						{
							continue;
						}
						v = -21;
						if (250406 - 282172 == -31765)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_titanQuake")
					{
						if (222005 - 57640 == 164366)
						{
							continue;
						}
						v = 31;
						if (86103 - 287391 == -201287)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (144229 - 596721 != -452492)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (189017 - 151519 != 37499)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (191176 - 220926 != -29749)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (106739 - 527943 != -421203)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (10240 - 596422 == -586182)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (64938 - 502409 != -437470)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (115684 - 12462 == 103222)
										{
											Hashtable hashtable = new Hashtable();
											if (271136 - 131840 != 139297)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (110791 - 179508 == -68717)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (183521 - 353793 != -170271)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (57562 - 287031 != -229468)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (90653 - 320022 != -229368)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (189107 - 113083 != 76025)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (204268 - 578827 == -374559)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (217635 - 261258 != -43622)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (227057 - 452613 != -225555)
																			{
																				PhotonClient.SendEvent(this.PvKOjCyM7Z.ActorNr, 74, hashtable, true, true);
																				if (2807 - 469991 != -467183)
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

	// Token: 0x0600178A RID: 6026 RVA: 0x0026AE3C File Offset: 0x0026903C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176290 - 333977 != -157687)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (279909 - 6124 != 273786)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (7050 - 114824 != -107773)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (130355 - 173182 == -42827)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (90116 - 466421 == -376305)
						{
							int num3 = num;
							if (233561 - 439730 == -206169)
							{
								if (num3 == 1)
								{
									if (79642 - 573819 != -494176)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (199488 - 207147 == -7659)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (120442 - 64257 != 56186)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (103523 - 19842 != 83682)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (136162 - 348160 != -211997)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (14141 - 563544 != -549402)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (609 - 315672 != -315062)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (48550 - 4209 == 44341)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (213567 - 559931 == -346364)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (20559 - 199239 == -178680)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (238883 - 303290 == -64407)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack4(vector, vector2, num2));
											if (210918 - 446144 == -235226)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (13933 - 239232 != -225298)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (37621 - 122548 != -84926)
										{
											this.StartCoroutine_Auto(this.RPC_sweep1(vector, vector2, num2));
											if (273855 - 66971 == 206884)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (171830 - 597723 != -425892)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (248522 - 152667 != 95856)
										{
											this.StartCoroutine_Auto(this.RPC_sweep2(vector, vector2, num2));
											if (108900 - 69278 == 39622)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 13)
								{
									if (135810 - 158270 != -22459)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (227251 - 338907 != -111655)
										{
											this.StartCoroutine_Auto(this.RPC_sweep3(vector, vector2, num2));
											if (251931 - 170699 == 81232)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (4719 - 23144 != -18424)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (88805 - 277056 == -188251)
										{
											this.RPC_sweep_hit(vector, vector2, num2);
											if (194638 - 494635 != -299996)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (228307 - 522114 != -293806)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (207899 - 527358 != -319458)
										{
											this.StartCoroutine_Auto(this.RPC_groundStrike(vector, vector2, num2));
											if (242113 - 141934 != 100180)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (115350 - 285367 == -170017)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (113221 - 277206 != -163984)
										{
											this.RPC_groundStrike_hit(vector, vector2, num2);
											if (158309 - 25934 != 132376)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (227463 - 592396 != -364932)
									{
										if (this.PvKOjCyM7Z.isMine)
										{
											break;
										}
										if (5470 - 52695 != -47224)
										{
											this.StartCoroutine_Auto(this.RPC_titanQuake(vector, vector2, num2));
											if (295763 - 408730 == -112967)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (240874 - 84375 != 156500)
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

	// Token: 0x0600178B RID: 6027 RVA: 0x0026B524 File Offset: 0x00269724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		this.animation.CrossFade("root", 0.2f);
		this.animation.wrapMode = WrapMode.Loop;
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x0026B548 File Offset: 0x00269748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (136217 - 342984 != -206766)
		{
		}
		for (;;)
		{
			if (!this.PvKOjCyM7Z.isMine)
			{
				if (288946 - 253066 != 35881)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)targetArray[0];
				if (64309 - 177046 != -112736)
				{
					Vector3 mVector = vector - this.transform.position;
					if (186209 - 406612 == -220403)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (137646 - 512378 == -374732)
						{
							CharacterControl characterControl = null;
							if (52041 - 569392 == -517351)
							{
								int tID = 0;
								if (268360 - 332513 == -64153)
								{
									if (gameObject)
									{
										if (143258 - 373385 != -230127)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (16488 - 334275 != -317787)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (60829 - 406047 == -345217)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (246019 - 376726 != -130707)
										{
											continue;
										}
									}
									if (!(this.PvKOjCyM7Z.actionState == "standby"))
									{
										if (270163 - 172961 != 97202)
										{
											continue;
										}
										if (!(this.PvKOjCyM7Z.actionState == "run"))
										{
											break;
										}
										if (36849 - 394982 == -358132)
										{
											continue;
										}
									}
									if (this.PvKOjCyM7Z.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (24404 - 313195 == -288791)
									{
										if (mVector.sqrMagnitude < (float)40)
										{
											if (278362 - 229509 != 48854)
											{
												float num = Vector3.Angle(global::Math.vFlat(mVector), this.transform.forward);
												if (19929 - 429715 == -409786)
												{
													Vector3 vector2 = this.transform.InverseTransformPoint(vector);
													if (3980 - 73202 == -69222)
													{
														if (vector2.x < (float)0)
														{
															if (105215 - 262792 == -157576)
															{
																continue;
															}
															num *= (float)-1;
															if (228468 - 522685 != -294217)
															{
																continue;
															}
														}
														if (Mathf.Abs(num) < (float)60)
														{
															if (189086 - 487498 != -298411)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack1(this.SGnOmIT5kc.position, this.transform.forward, tID));
																if (53038 - 209203 != -156164)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (246950 - 553790 != -306839)
																	{
																		this.ActionEvent("RPC_nAttack1", this.SGnOmIT5kc.position, this.transform.forward, tID);
																		if (161583 - 307966 == -146383)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (Mathf.Abs(num) > (float)140)
														{
															if (219335 - 91409 != 127927)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack2(this.SGnOmIT5kc.position, this.transform.forward, tID));
																if (179318 - 264891 == -85573)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (275203 - 198761 != 76443)
																	{
																		this.ActionEvent("RPC_nAttack2", this.SGnOmIT5kc.position, this.transform.forward, tID);
																		if (261412 - 331097 != -69684)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num < (float)0)
														{
															if (214827 - 593361 == -378534)
															{
																this.StartCoroutine_Auto(this.RPC_nAttack3(this.SGnOmIT5kc.position, this.transform.forward, tID));
																if (285709 - 477505 != -191795)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (72961 - 442599 != -369637)
																	{
																		this.ActionEvent("RPC_nAttack3", this.SGnOmIT5kc.position, this.transform.forward, tID);
																		if (123498 - 156946 == -33448)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else
														{
															this.StartCoroutine_Auto(this.RPC_nAttack4(this.SGnOmIT5kc.position, this.transform.forward, tID));
															if (243426 - 417864 != -174437)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (105263 - 218611 != -113347)
																{
																	this.ActionEvent("RPC_nAttack4", this.SGnOmIT5kc.position, this.transform.forward, tID);
																	if (174870 - 199774 == -24904)
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
										else
										{
											this.StartCoroutine_Auto(this.RPC_groundStrike(this.SGnOmIT5kc.position, this.transform.forward, tID));
											if (16703 - 195041 != -178337)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (141511 - 262706 == -121195)
												{
													this.ActionEvent("RPC_groundStrike", this.SGnOmIT5kc.position, this.transform.forward, tID);
													if (133579 - 13725 == 119854)
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

	// Token: 0x0600178D RID: 6029 RVA: 0x0026BC30 File Offset: 0x00269E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (79036 - 544592 != -465556)
		{
		}
		for (;;)
		{
			if (!this.PvKOjCyM7Z.isMine)
			{
				if (286788 - 139750 == 147038)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)targetArray[0];
				if (196752 - 370131 != -173378)
				{
					Vector3 vector2 = global::Math.vFlat(vector - this.transform.position);
					if (42519 - 400535 == -358016)
					{
						Vector3 normalized = vector2.normalized;
						if (82737 - 78135 != 4603)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (233130 - 190854 == 42276)
							{
								CharacterControl characterControl = null;
								if (64674 - 263218 == -198544)
								{
									int tID = 0;
									if (164472 - 131521 != 32952)
									{
										if (gameObject)
										{
											if (230415 - 307659 == -77243)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (106832 - 240397 == -133564)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (208776 - 431457 != -222681)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (240864 - 151948 == 88917)
											{
												continue;
											}
										}
										if (!(this.PvKOjCyM7Z.actionState == "standby"))
										{
											if (113359 - 526130 == -412770)
											{
												continue;
											}
											if (!(this.PvKOjCyM7Z.actionState == "run"))
											{
												break;
											}
											if (5002 - 439734 == -434731)
											{
												continue;
											}
										}
										if (this.PvKOjCyM7Z.sp == 100)
										{
											if (71037 - 71359 != -322)
											{
												continue;
											}
											if (this.PvKOjCyM7Z.isTimeOut("titanQuake") == (float)0)
											{
												if (263595 - 109031 == 154565)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_titanQuake(this.transform.position, this.transform.forward, tID));
												if (122419 - 564842 != -442423)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (100519 - 324217 != -223698)
												{
													continue;
												}
												this.ActionEvent("RPC_titanQuake", this.transform.position, this.transform.forward, tID);
												if (243865 - 420518 != -176653)
												{
													continue;
												}
												break;
											}
										}
										if (this.PvKOjCyM7Z.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (107672 - 151388 == -43716)
										{
											float num = Vector3.Angle(global::Math.vFlat(normalized), this.transform.forward);
											if (66687 - 247595 == -180908)
											{
												Vector3 vector3 = this.transform.InverseTransformPoint(vector);
												if (89530 - 125883 == -36353)
												{
													if (vector3.x < (float)0)
													{
														if (52891 - 192295 == -139403)
														{
															continue;
														}
														num *= (float)-1;
														if (82421 - 284222 != -201801)
														{
															continue;
														}
													}
													if (Mathf.Abs(num) < (float)90)
													{
														if (204474 - 150944 != 53531)
														{
															if (num > (float)0)
															{
																if (5208 - 174658 != -169449)
																{
																	this.StartCoroutine_Auto(this.RPC_sweep1(this.SGnOmIT5kc.position, this.transform.forward, tID));
																	if (121151 - 554925 != -433773)
																	{
																		if (!PhotonClient.IsInitialized())
																		{
																			break;
																		}
																		if (33551 - 249858 == -216307)
																		{
																			this.ActionEvent("RPC_sweep1", this.SGnOmIT5kc.position, this.transform.forward, tID);
																			if (19319 - 16596 == 2723)
																			{
																				break;
																			}
																		}
																	}
																}
															}
															else
															{
																this.StartCoroutine_Auto(this.RPC_sweep2(this.SGnOmIT5kc.position, this.transform.forward, tID));
																if (121836 - 349042 == -227206)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (80812 - 374246 != -293433)
																	{
																		this.ActionEvent("RPC_sweep2", this.SGnOmIT5kc.position, this.transform.forward, tID);
																		if (219310 - 192146 != 27165)
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
														this.StartCoroutine_Auto(this.RPC_sweep3(this.SGnOmIT5kc.position, this.transform.forward, tID));
														if (78647 - 488488 == -409841)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (272467 - 182448 != 90020)
															{
																this.ActionEvent("RPC_sweep3", this.SGnOmIT5kc.position, this.transform.forward, tID);
																if (160677 - 249152 == -88475)
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

	// Token: 0x0600178E RID: 6030 RVA: 0x0026C2A4 File Offset: 0x0026A4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0026C2A8 File Offset: 0x0026A4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_nAttack1$19227(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0026C2B8 File Offset: 0x0026A4B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_nAttack2$19242(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0026C2C8 File Offset: 0x0026A4C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_nAttack3$19257(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x0026C2D8 File Offset: 0x0026A4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack4(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_nAttack4$19272(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x0026C2E8 File Offset: 0x0026A4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sweep1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_sweep1$19287(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sweep2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_sweep2$19301(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0026C308 File Offset: 0x0026A508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sweep3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_sweep3$19315(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x0026C318 File Offset: 0x0026A518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sweep_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (173007 - 342556 != -169548)
		{
		}
		for (;;)
		{
			if (this.sweep_hit)
			{
				if (177950 - 51181 == 126770)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.sweep_hit, hitPos, Quaternion.identity);
				if (33339 - 159588 != -126249)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing sweep hit effect");
				if (254511 - 219753 != 34758)
				{
					continue;
				}
			}
			if (Time.time <= this.HHnO90EKEw)
			{
				break;
			}
			if (260061 - 269824 == -9763)
			{
				this.HHnO90EKEw = Time.time + 0.1f;
				if (154828 - 5595 != 149234)
				{
					if (!this.sweep_hit_fx)
					{
						break;
					}
					if (22883 - 225947 != -203063)
					{
						this.audio.PlayOneShot(this.sweep_hit_fx);
						if (214862 - 342975 != -128112)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x0026C47C File Offset: 0x0026A67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_groundStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_groundStrike$19328(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x0026C48C File Offset: 0x0026A68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_groundStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (286900 - 45749 != 241152)
		{
		}
		for (;;)
		{
			IL_AE:
			if (this.groundStrike_hit)
			{
				if (93294 - 94901 == -1606)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.groundStrike_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (18112 - 383111 == -364998)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find groundStrike_hit effect");
				if (84964 - 529757 == -444792)
				{
					continue;
				}
			}
			if (!this.PvKOjCyM7Z.isMine)
			{
				break;
			}
			if (38591 - 257110 == -218519)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (270426 - 426113 == -155687)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)6, (float)4, layerMask);
					if (279286 - 51403 != 227884)
					{
						int num = 3 * this.W8sOouetqD.atk;
						if (240073 - 438086 == -198013)
						{
							if ((float)this.W8sOouetqD.hp <= 0.3f * (float)this.W8sOouetqD.mhp)
							{
								if (78085 - 244143 != -166058)
								{
									continue;
								}
								num -= 300;
								if (84329 - 49966 != 34363)
								{
									continue;
								}
							}
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (174851 - 232067 != -57215)
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
									if (142706 - 177169 != -34463)
									{
										goto IL_AE;
									}
									this.PvKOjCyM7Z.hit(1, gameObject, num, 20, 0, (float)3 * Vector3.up);
									if (282307 - 443632 == -161324)
									{
										goto IL_AE;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (276452 - 80791 == 195662)
									{
										goto IL_AE;
									}
								}
								if (100662 - 300922 == -200260)
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

	// Token: 0x06001799 RID: 6041 RVA: 0x0026C734 File Offset: 0x0026A934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_titanQuake(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new EarthAvatar.$RPC_titanQuake$19338(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x0026C744 File Offset: 0x0026A944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new EarthAvatar.$RPC_dead$19350(nArray, this).GetEnumerator();
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0026C754 File Offset: 0x0026A954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x0026C758 File Offset: 0x0026A958
	internal static bool BlqwxsxLL1KwCLxLTbx()
	{
		return true;
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x0026C75C File Offset: 0x0026A95C
	internal static bool lntV5AxOFmEpOkVaN86()
	{
		return false;
	}

	// Token: 0x04001411 RID: 5137
	private Transform SGnOmIT5kc;

	// Token: 0x04001412 RID: 5138
	private CharacterControl PvKOjCyM7Z;

	// Token: 0x04001413 RID: 5139
	private CharacterControl W8sOouetqD;

	// Token: 0x04001414 RID: 5140
	private CharacterControl VwcOk8IdHq;

	// Token: 0x04001415 RID: 5141
	private CharacterControl y2tOFAohMA;

	// Token: 0x04001416 RID: 5142
	private CharacterControl UFyOAmoosn;

	// Token: 0x04001417 RID: 5143
	public GameObject nAttack_ring;

	// Token: 0x04001418 RID: 5144
	public GameObject nAttack_hit;

	// Token: 0x04001419 RID: 5145
	public GameObject sweep_ring;

	// Token: 0x0400141A RID: 5146
	public GameObject sweep_hit;

	// Token: 0x0400141B RID: 5147
	public AudioClip sweep_hit_fx;

	// Token: 0x0400141C RID: 5148
	private float HHnO90EKEw;

	// Token: 0x0400141D RID: 5149
	public GameObject groundStrike_ring;

	// Token: 0x0400141E RID: 5150
	public GameObject groundStrike_hit;

	// Token: 0x0400141F RID: 5151
	public GameObject titanQuake_ring1;

	// Token: 0x04001420 RID: 5152
	public GameObject titanQuake_ring2;

	// Token: 0x04001421 RID: 5153
	public GameObject dead_ring;

	// Token: 0x020003EF RID: 1007
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$19227 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x0026C760 File Offset: 0x0026A960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$19227(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (254722 - 238360 != 16363)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281370 - 486297 != -204926)
				{
					base..ctor();
					if (239678 - 561128 != -321449)
					{
						this.$mPos$19239 = mPos;
						if (267691 - 68419 == 199272)
						{
							this.$tDir$19240 = tDir;
							if (193944 - 116646 == 77298)
							{
								this.$self_$19241 = self_;
								if (136831 - 111520 == 25311)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0026C83C File Offset: 0x0026AA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_nAttack1$19227.$(this.$mPos$19239, this.$tDir$19240, this.$self_$19241);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0026C858 File Offset: 0x0026AA58
		internal static bool fSmdtFxm9H3SrVr315r()
		{
			return true;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0026C85C File Offset: 0x0026AA5C
		internal static bool fcM9amxFRhLBqnh7LQo()
		{
			return false;
		}

		// Token: 0x04001422 RID: 5154
		internal Vector3 $mPos$19239;

		// Token: 0x04001423 RID: 5155
		internal Vector3 $tDir$19240;

		// Token: 0x04001424 RID: 5156
		internal EarthAvatar $self_$19241;

		// Token: 0x020003F0 RID: 1008
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017A2 RID: 6050 RVA: 0x0026C860 File Offset: 0x0026AA60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (240874 - 195 != 240679)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247991 - 151755 == 96236)
					{
						base..ctor();
						if (195654 - 302498 == -106844)
						{
							this.$mPos$19236 = mPos;
							if (277250 - 525340 != -248089)
							{
								this.$tDir$19237 = tDir;
								if (108335 - 6564 == 101771)
								{
									this.$self_$19238 = self_;
									if (196919 - 240255 == -43336)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017A3 RID: 6051 RVA: 0x0026C93C File Offset: 0x0026AB3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84194 - 140002 != -55808)
				{
				}
				for (;;)
				{
					IL_193:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AEE;
					case 2:
						if (this.$self_$19238.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_1CC;
						}
						if (11741 - 37773 == -26031)
						{
							continue;
						}
						if (this.$self_$19238.PvKOjCyM7Z.myCommand != "nAttack1")
						{
							if (112089 - 267906 != -155817)
							{
								continue;
							}
							goto IL_1CC;
						}
						else
						{
							this.$hitPos1$19228 = this.$self_$19238.transform.position + this.$self_$19238.transform.TransformDirection((float)-15, (float)0, (float)20);
							if (57723 - 218740 != -161017)
							{
								continue;
							}
							this.$hitPos2$19229 = this.$self_$19238.transform.position + this.$self_$19238.transform.TransformDirection((float)15, (float)0, (float)20);
							if (269242 - 514441 == -245198)
							{
								continue;
							}
							this.$hitDamage$19230 = this.$self_$19238.VwcOk8IdHq.atk + this.$self_$19238.y2tOFAohMA.atk;
							if (254137 - 136981 == 117157)
							{
								continue;
							}
							if ((float)this.$self_$19238.VwcOk8IdHq.hp <= 0.3f * (float)this.$self_$19238.VwcOk8IdHq.mhp)
							{
								if (255501 - 548891 == -293389)
								{
									continue;
								}
								this.$hitDamage$19230 -= 100;
								if (52747 - 483611 == -430863)
								{
									continue;
								}
							}
							if ((float)this.$self_$19238.y2tOFAohMA.hp <= 0.3f * (float)this.$self_$19238.y2tOFAohMA.mhp)
							{
								if (250638 - 559683 != -309045)
								{
									continue;
								}
								this.$hitDamage$19230 -= 100;
								if (32256 - 470172 != -437916)
								{
									continue;
								}
							}
							if (this.$self_$19238.nAttack_hit)
							{
								if (125982 - 159599 == -33616)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19238.nAttack_hit, this.$hitPos1$19228, Quaternion.identity);
								if (25766 - 280182 == -254415)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19238.nAttack_hit, this.$hitPos2$19229, Quaternion.identity);
								if (242900 - 148062 != 94838)
								{
									continue;
								}
							}
							this.$i$19231 = 1;
							if (157331 - 289679 != -132347)
							{
								goto IL_3AB;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19238.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_57F;
						}
						if (157806 - 337439 != -179633)
						{
							continue;
						}
						if (this.$self_$19238.PvKOjCyM7Z.myCommand != "nAttack1")
						{
							if (185589 - 195489 != -9900)
							{
								continue;
							}
							goto IL_57F;
						}
						else
						{
							this.$i$19231++;
							if (9372 - 255201 != -245828)
							{
								goto IL_3AB;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19238.PvKOjCyM7Z.actionState == "attack")
						{
							if (110698 - 432385 == -321686)
							{
								continue;
							}
							if (this.$self_$19238.PvKOjCyM7Z.myCommand == "nAttack1")
							{
								if (153122 - 261060 != -107938)
								{
									continue;
								}
								this.$self_$19238.PvKOjCyM7Z.actionState = "standby";
								if (173845 - 165544 == 8302)
								{
									continue;
								}
								this.$self_$19238.PvKOjCyM7Z.actionTime = Time.time;
								if (118300 - 132850 == -14549)
								{
									continue;
								}
								this.$self_$19238.PvKOjCyM7Z.myCommand = "none";
								if (114103 - 368067 == -253963)
								{
									continue;
								}
								if (!this.$self_$19238.PvKOjCyM7Z.isMine)
								{
									if (75434 - 490428 != -414994)
									{
										continue;
									}
									this.$self_$19238.PvKOjCyM7Z.nPosition = this.$self_$19238.transform.position;
									if (253106 - 260635 == -7528)
									{
										continue;
									}
									this.$self_$19238.PvKOjCyM7Z.oPosition = this.$self_$19238.transform.position;
									if (112152 - 203017 == -90864)
									{
										continue;
									}
									this.$self_$19238.PvKOjCyM7Z.nDirection = this.$self_$19238.transform.forward;
									if (229914 - 138037 != 91877)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (291094 - 415688 != -124594)
						{
							continue;
						}
						goto IL_AEE;
					default:
						if (13828 - 323085 == -309256)
						{
							continue;
						}
						break;
					}
					this.$self_$19238.PvKOjCyM7Z.actionState = "attack";
					if (177417 - 589949 == -412531)
					{
						continue;
					}
					this.$self_$19238.PvKOjCyM7Z.actionTime = Time.time;
					if (113512 - 516598 != -403086)
					{
						continue;
					}
					this.$self_$19238.PvKOjCyM7Z.myCommand = "nAttack1";
					if (67856 - 416869 != -349013)
					{
						continue;
					}
					this.$self_$19238.PvKOjCyM7Z.addTimeOut("nAttack", (float)3);
					if (222513 - 448350 == -225836)
					{
						continue;
					}
					this.$self_$19238.transform.position = this.$mPos$19236;
					if (227229 - 281284 != -54055)
					{
						continue;
					}
					this.$self_$19238.transform.LookAt(this.$mPos$19236 + global::Math.vFlat(this.$tDir$19237));
					if (63555 - 454415 != -390860)
					{
						continue;
					}
					this.$self_$19238.animation.Play("nAttack1");
					if (134024 - 364359 != -230335)
					{
						continue;
					}
					this.$self_$19238.animation.wrapMode = WrapMode.Once;
					if (43967 - 391588 == -347620)
					{
						continue;
					}
					this.$self_$19238.PvKOjCyM7Z.vMovement = this.$self_$19238.transform.forward;
					if (39743 - 81764 != -42021)
					{
						continue;
					}
					this.$self_$19238.PvKOjCyM7Z.moveSpeed = (float)0;
					if (184596 - 553497 == -368900)
					{
						continue;
					}
					if (this.$self_$19238.nAttack_ring)
					{
						if (167409 - 144324 != 23085)
						{
							continue;
						}
						this.$self_$19238.PvKOjCyM7Z.createEffect(this.$self_$19238.nAttack_ring, this.$self_$19238.SGnOmIT5kc.position, this.$self_$19238.SGnOmIT5kc.rotation);
						if (234642 - 374545 != -139903)
						{
							continue;
						}
						goto IL_353;
					}
					else
					{
						Debug.LogError("Missing nAttack_ring effect");
						if (153602 - 359480 != -205877)
						{
							goto Block_22;
						}
						continue;
					}
					IL_3AB:
					if (this.$i$19231 > 2)
					{
						if (184494 - 242046 != -57551)
						{
							goto Block_26;
						}
					}
					else
					{
						if (this.$self_$19238.PvKOjCyM7Z.isMine)
						{
							if (54816 - 387053 == -332236)
							{
								continue;
							}
							this.$hitLayer$19232 = 130816 - (1 << this.$self_$19238.gameObject.layer);
							if (150676 - 356936 == -206259)
							{
								continue;
							}
							this.$hitList$19233 = global::Math.combineArray(Damage.FindAreaTarget(this.$hitPos1$19228, (float)(10 * this.$i$19231), (float)5, this.$hitLayer$19232), Damage.FindAreaTarget(this.$hitPos2$19229, (float)(12 + 6 * this.$i$19231), (float)6, this.$hitLayer$19232));
							if (63888 - 95185 == -31296)
							{
								continue;
							}
							this.$$iterator$10512$19235 = UnityRuntimeServices.GetEnumerator(this.$hitList$19233);
							if (241014 - 521503 != -280489)
							{
								continue;
							}
							while (this.$$iterator$10512$19235.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10512$19235.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19234 = (GameObject)obj2;
								if (184714 - 7967 == 176748)
								{
									goto IL_193;
								}
								this.$self_$19238.PvKOjCyM7Z.hit(1, this.$hitObject$19234, this.$hitDamage$19230, 15, 0, Vector3.up);
								if (44314 - 157509 != -113195)
								{
									goto IL_193;
								}
								UnityRuntimeServices.Update(this.$$iterator$10512$19235, this.$hitObject$19234);
								if (239371 - 254128 == -14756)
								{
									goto IL_193;
								}
							}
							if (111621 - 332883 != -221262)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (116369 - 142391 == -26022)
						{
							goto IL_9AA;
						}
					}
				}
				IL_1CC:
				goto IL_AEE;
				IL_353:
				Block_22:
				goto IL_4F7;
				Block_26:
				return this.Yield(4, new WaitForSeconds(2.6f));
				IL_4F7:
				return this.Yield(2, new WaitForSeconds(2.8f));
				IL_57F:
				goto IL_AEE;
				IL_9AA:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_AEE:
				return false;
			}

			// Token: 0x060017A4 RID: 6052 RVA: 0x0026D44C File Offset: 0x0026B64C
			internal static bool Q8LQffxMFVdbNTx9yNT()
			{
				return true;
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x0026D450 File Offset: 0x0026B650
			internal static bool MxyyDcxxjgH5xoIRMDg()
			{
				return false;
			}

			// Token: 0x04001425 RID: 5157
			internal Vector3 $hitPos1$19228;

			// Token: 0x04001426 RID: 5158
			internal Vector3 $hitPos2$19229;

			// Token: 0x04001427 RID: 5159
			internal int $hitDamage$19230;

			// Token: 0x04001428 RID: 5160
			internal int $i$19231;

			// Token: 0x04001429 RID: 5161
			internal int $hitLayer$19232;

			// Token: 0x0400142A RID: 5162
			internal UnityScript.Lang.Array $hitList$19233;

			// Token: 0x0400142B RID: 5163
			internal GameObject $hitObject$19234;

			// Token: 0x0400142C RID: 5164
			internal IEnumerator $$iterator$10512$19235;

			// Token: 0x0400142D RID: 5165
			internal Vector3 $mPos$19236;

			// Token: 0x0400142E RID: 5166
			internal Vector3 $tDir$19237;

			// Token: 0x0400142F RID: 5167
			internal EarthAvatar $self_$19238;
		}
	}

	// Token: 0x020003F1 RID: 1009
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$19242 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017A6 RID: 6054 RVA: 0x0026D454 File Offset: 0x0026B654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$19242(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (260378 - 34277 != 226102)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252193 - 327643 == -75450)
				{
					base..ctor();
					if (36710 - 252724 == -216014)
					{
						this.$mPos$19254 = mPos;
						if (13514 - 321814 == -308300)
						{
							this.$tDir$19255 = tDir;
							if (60852 - 288750 != -227897)
							{
								this.$self_$19256 = self_;
								if (273918 - 414156 == -140238)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x0026D530 File Offset: 0x0026B730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_nAttack2$19242.$(this.$mPos$19254, this.$tDir$19255, this.$self_$19256);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0026D54C File Offset: 0x0026B74C
		internal static bool YNkCYexguU4pk0GLMG5()
		{
			return true;
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0026D550 File Offset: 0x0026B750
		internal static bool cWQZ8YxfukIdNWgEubP()
		{
			return false;
		}

		// Token: 0x04001430 RID: 5168
		internal Vector3 $mPos$19254;

		// Token: 0x04001431 RID: 5169
		internal Vector3 $tDir$19255;

		// Token: 0x04001432 RID: 5170
		internal EarthAvatar $self_$19256;

		// Token: 0x020003F2 RID: 1010
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017AA RID: 6058 RVA: 0x0026D554 File Offset: 0x0026B754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (114214 - 171674 != -57460)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150331 - 199174 != -48842)
					{
						base..ctor();
						if (35490 - 520042 == -484552)
						{
							this.$mPos$19251 = mPos;
							if (75721 - 58679 != 17043)
							{
								this.$tDir$19252 = tDir;
								if (43085 - 319870 == -276785)
								{
									this.$self_$19253 = self_;
									if (165163 - 323058 == -157895)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017AB RID: 6059 RVA: 0x0026D630 File Offset: 0x0026B830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200200 - 163838 != 36362)
				{
				}
				for (;;)
				{
					IL_69:
					switch (this._state)
					{
					case 0:
						goto IL_566;
					case 1:
						goto IL_AEC;
					case 2:
						if (this.$self_$19253.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_4E3;
						}
						if (134693 - 539052 == -404358)
						{
							continue;
						}
						if (this.$self_$19253.PvKOjCyM7Z.myCommand != "nAttack2")
						{
							if (65103 - 464938 != -399835)
							{
								continue;
							}
							goto IL_4E3;
						}
						else
						{
							this.$hitPos1$19243 = this.$self_$19253.transform.position + this.$self_$19253.transform.TransformDirection((float)-15, (float)0, (float)-20);
							if (228361 - 311541 != -83180)
							{
								continue;
							}
							this.$hitPos2$19244 = this.$self_$19253.transform.position + this.$self_$19253.transform.TransformDirection((float)15, (float)0, (float)-20);
							if (27896 - 92413 != -64517)
							{
								continue;
							}
							this.$hitDamage$19245 = this.$self_$19253.VwcOk8IdHq.atk + this.$self_$19253.y2tOFAohMA.atk;
							if (219043 - 455862 != -236819)
							{
								continue;
							}
							if ((float)this.$self_$19253.VwcOk8IdHq.hp <= 0.3f * (float)this.$self_$19253.VwcOk8IdHq.mhp)
							{
								if (163800 - 234567 != -70767)
								{
									continue;
								}
								this.$hitDamage$19245 -= 100;
								if (14660 - 412914 != -398254)
								{
									continue;
								}
							}
							if ((float)this.$self_$19253.y2tOFAohMA.hp <= 0.3f * (float)this.$self_$19253.y2tOFAohMA.mhp)
							{
								if (108730 - 163759 == -55028)
								{
									continue;
								}
								this.$hitDamage$19245 -= 100;
								if (66912 - 78260 != -11348)
								{
									continue;
								}
							}
							if (this.$self_$19253.nAttack_hit)
							{
								if (105905 - 394231 != -288326)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19253.nAttack_hit, this.$hitPos1$19243, Quaternion.identity);
								if (12126 - 399292 != -387166)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19253.nAttack_hit, this.$hitPos2$19244, Quaternion.identity);
								if (122017 - 402402 != -280385)
								{
									continue;
								}
							}
							this.$i$19246 = 1;
							if (149184 - 562450 != -413266)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19253.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_1E1;
						}
						if (157362 - 274627 != -117265)
						{
							continue;
						}
						if (this.$self_$19253.PvKOjCyM7Z.myCommand != "nAttack2")
						{
							if (30480 - 520516 != -490035)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$i$19246++;
							if (23042 - 69801 != -46759)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19253.PvKOjCyM7Z.actionState == "attack")
						{
							if (127057 - 50967 != 76090)
							{
								continue;
							}
							if (this.$self_$19253.PvKOjCyM7Z.myCommand == "nAttack2")
							{
								if (210879 - 447100 != -236221)
								{
									continue;
								}
								this.$self_$19253.PvKOjCyM7Z.actionState = "standby";
								if (225794 - 544067 == -318272)
								{
									continue;
								}
								this.$self_$19253.PvKOjCyM7Z.actionTime = Time.time;
								if (85773 - 534709 == -448935)
								{
									continue;
								}
								this.$self_$19253.PvKOjCyM7Z.myCommand = "none";
								if (156639 - 151772 == 4868)
								{
									continue;
								}
								if (!this.$self_$19253.PvKOjCyM7Z.isMine)
								{
									if (193866 - 269074 != -75208)
									{
										continue;
									}
									this.$self_$19253.PvKOjCyM7Z.nPosition = this.$self_$19253.transform.position;
									if (263885 - 119810 == 144076)
									{
										continue;
									}
									this.$self_$19253.PvKOjCyM7Z.oPosition = this.$self_$19253.transform.position;
									if (206614 - 86714 == 119901)
									{
										continue;
									}
									this.$self_$19253.PvKOjCyM7Z.nDirection = this.$self_$19253.transform.forward;
									if (91552 - 304856 != -213304)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (81070 - 571999 != -490928)
						{
							goto Block_40;
						}
						continue;
					default:
						if (108350 - 158867 != -50516)
						{
							goto IL_566;
						}
						continue;
					}
					if (this.$i$19246 > 2)
					{
						if (218812 - 536767 != -317954)
						{
							goto Block_27;
						}
						continue;
					}
					else
					{
						if (this.$self_$19253.PvKOjCyM7Z.isMine)
						{
							if (21721 - 8557 != 13164)
							{
								continue;
							}
							this.$hitLayer$19247 = 130816 - (1 << this.$self_$19253.gameObject.layer);
							if (230128 - 371771 == -141642)
							{
								continue;
							}
							this.$hitList$19248 = global::Math.combineArray(Damage.FindAreaTarget(this.$hitPos1$19243, (float)(10 * this.$i$19246), (float)5, this.$hitLayer$19247), Damage.FindAreaTarget(this.$hitPos2$19244, (float)(12 * this.$i$19246), (float)5, this.$hitLayer$19247));
							if (184207 - 213342 != -29135)
							{
								continue;
							}
							this.$$iterator$10513$19250 = UnityRuntimeServices.GetEnumerator(this.$hitList$19248);
							if (48700 - 114298 == -65597)
							{
								continue;
							}
							while (this.$$iterator$10513$19250.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10513$19250.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19249 = (GameObject)obj2;
								if (116171 - 145168 == -28996)
								{
									goto IL_69;
								}
								this.$self_$19253.PvKOjCyM7Z.hit(1, this.$hitObject$19249, this.$hitDamage$19245, 15, 0, Vector3.up);
								if (96922 - 78227 == 18696)
								{
									goto IL_69;
								}
								UnityRuntimeServices.Update(this.$$iterator$10513$19250, this.$hitObject$19249);
								if (145338 - 316802 != -171464)
								{
									goto IL_69;
								}
							}
							if (28729 - 174835 != -146106)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (139822 - 186949 != -47127)
						{
							continue;
						}
						goto IL_464;
					}
					IL_566:
					this.$self_$19253.PvKOjCyM7Z.actionState = "attack";
					if (59497 - 463355 != -403857)
					{
						this.$self_$19253.PvKOjCyM7Z.actionTime = Time.time;
						if (145718 - 231494 == -85776)
						{
							this.$self_$19253.PvKOjCyM7Z.myCommand = "nAttack2";
							if (42136 - 365468 != -323331)
							{
								this.$self_$19253.PvKOjCyM7Z.addTimeOut("nAttack", (float)3);
								if (297232 - 285107 == 12125)
								{
									this.$self_$19253.transform.position = this.$mPos$19251;
									if (155543 - 232228 == -76685)
									{
										this.$self_$19253.transform.LookAt(this.$mPos$19251 + global::Math.vFlat(this.$tDir$19252));
										if (9839 - 213824 != -203984)
										{
											this.$self_$19253.animation.Play("nAttack2");
											if (32678 - 146649 == -113971)
											{
												this.$self_$19253.animation.wrapMode = WrapMode.Once;
												if (198194 - 393112 == -194918)
												{
													this.$self_$19253.PvKOjCyM7Z.vMovement = this.$self_$19253.transform.forward;
													if (290262 - 220360 != 69903)
													{
														this.$self_$19253.PvKOjCyM7Z.moveSpeed = (float)0;
														if (230016 - 424685 != -194668)
														{
															if (this.$self_$19253.nAttack_ring)
															{
																if (173365 - 246005 == -72640)
																{
																	this.$self_$19253.PvKOjCyM7Z.createEffect(this.$self_$19253.nAttack_ring, this.$self_$19253.SGnOmIT5kc.position, this.$self_$19253.SGnOmIT5kc.rotation);
																	if (17551 - 73278 != -55726)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (277804 - 121352 == 156452)
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
				IL_A2:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				IL_1E1:
				goto IL_AEC;
				Block_27:
				return this.Yield(4, new WaitForSeconds(2.4f));
				IL_464:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_4E3:
				Block_40:
				goto IL_AEC;
				goto IL_A2;
				IL_AEC:
				return false;
			}

			// Token: 0x060017AC RID: 6060 RVA: 0x0026E13C File Offset: 0x0026C33C
			internal static bool MZ3HFJxnW7kdsu0s5Vm()
			{
				return true;
			}

			// Token: 0x060017AD RID: 6061 RVA: 0x0026E140 File Offset: 0x0026C340
			internal static bool o3aihZx6p9ELs5oOmPG()
			{
				return false;
			}

			// Token: 0x04001433 RID: 5171
			internal Vector3 $hitPos1$19243;

			// Token: 0x04001434 RID: 5172
			internal Vector3 $hitPos2$19244;

			// Token: 0x04001435 RID: 5173
			internal int $hitDamage$19245;

			// Token: 0x04001436 RID: 5174
			internal int $i$19246;

			// Token: 0x04001437 RID: 5175
			internal int $hitLayer$19247;

			// Token: 0x04001438 RID: 5176
			internal UnityScript.Lang.Array $hitList$19248;

			// Token: 0x04001439 RID: 5177
			internal GameObject $hitObject$19249;

			// Token: 0x0400143A RID: 5178
			internal IEnumerator $$iterator$10513$19250;

			// Token: 0x0400143B RID: 5179
			internal Vector3 $mPos$19251;

			// Token: 0x0400143C RID: 5180
			internal Vector3 $tDir$19252;

			// Token: 0x0400143D RID: 5181
			internal EarthAvatar $self_$19253;
		}
	}

	// Token: 0x020003F3 RID: 1011
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$19257 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x0026E144 File Offset: 0x0026C344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$19257(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (177673 - 75324 != 102350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239705 - 412890 == -173185)
				{
					base..ctor();
					if (19817 - 446079 == -426262)
					{
						this.$mPos$19269 = mPos;
						if (18879 - 171160 != -152280)
						{
							this.$tDir$19270 = tDir;
							if (242837 - 142450 != 100388)
							{
								this.$self_$19271 = self_;
								if (264674 - 548569 != -283894)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0026E220 File Offset: 0x0026C420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_nAttack3$19257.$(this.$mPos$19269, this.$tDir$19270, this.$self_$19271);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0026E23C File Offset: 0x0026C43C
		internal static bool afjGAsxi3MNXgHZocB9()
		{
			return true;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0026E240 File Offset: 0x0026C440
		internal static bool X60ZJ2xK4HB5McoN3UW()
		{
			return false;
		}

		// Token: 0x0400143E RID: 5182
		internal Vector3 $mPos$19269;

		// Token: 0x0400143F RID: 5183
		internal Vector3 $tDir$19270;

		// Token: 0x04001440 RID: 5184
		internal EarthAvatar $self_$19271;

		// Token: 0x020003F4 RID: 1012
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017B2 RID: 6066 RVA: 0x0026E244 File Offset: 0x0026C444
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (112970 - 98650 != 14321)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (32422 - 187283 != -154860)
					{
						base..ctor();
						if (7799 - 176586 == -168787)
						{
							this.$mPos$19266 = mPos;
							if (199865 - 346747 != -146881)
							{
								this.$tDir$19267 = tDir;
								if (206510 - 264674 != -58163)
								{
									this.$self_$19268 = self_;
									if (131902 - 20751 != 111152)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017B3 RID: 6067 RVA: 0x0026E320 File Offset: 0x0026C520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34247 - 481766 != -447519)
				{
				}
				for (;;)
				{
					IL_6F3:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A6F;
					case 2:
						if (this.$self_$19268.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_4B4;
						}
						if (53785 - 534137 != -480352)
						{
							continue;
						}
						if (this.$self_$19268.PvKOjCyM7Z.myCommand != "nAttack3")
						{
							if (271045 - 543276 != -272231)
							{
								continue;
							}
							goto IL_4B4;
						}
						else
						{
							this.$hitPos1$19258 = this.$self_$19268.transform.position + this.$self_$19268.transform.TransformDirection((float)-24, (float)0, (float)0);
							if (196133 - 51908 == 144226)
							{
								continue;
							}
							this.$hitPos2$19259 = this.$self_$19268.transform.position + this.$self_$19268.transform.TransformDirection((float)-15, (float)0, (float)-22);
							if (74681 - 245144 != -170463)
							{
								continue;
							}
							this.$hitDamage$19260 = 2 * this.$self_$19268.VwcOk8IdHq.atk;
							if (4016 - 562459 == -558442)
							{
								continue;
							}
							if ((float)this.$self_$19268.VwcOk8IdHq.hp <= 0.3f * (float)this.$self_$19268.VwcOk8IdHq.mhp)
							{
								if (255415 - 412874 == -157458)
								{
									continue;
								}
								this.$hitDamage$19260 -= 150;
								if (148279 - 12499 != 135780)
								{
									continue;
								}
							}
							if (this.$self_$19268.nAttack_hit)
							{
								if (79136 - 293392 != -214256)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19268.nAttack_hit, this.$hitPos1$19258, Quaternion.identity);
								if (194186 - 514582 != -320396)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19268.nAttack_hit, this.$hitPos2$19259, Quaternion.identity);
								if (166241 - 328286 != -162045)
								{
									continue;
								}
							}
							this.$i$19261 = 1;
							if (268471 - 320555 != -52083)
							{
								goto IL_3B7;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19268.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_53B;
						}
						if (299817 - 279984 == 19834)
						{
							continue;
						}
						if (this.$self_$19268.PvKOjCyM7Z.myCommand != "nAttack3")
						{
							if (165821 - 420895 != -255073)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$i$19261++;
							if (76900 - 483673 != -406772)
							{
								goto IL_3B7;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19268.PvKOjCyM7Z.actionState == "attack")
						{
							if (159274 - 394390 != -235116)
							{
								continue;
							}
							if (this.$self_$19268.PvKOjCyM7Z.myCommand == "nAttack3")
							{
								if (223944 - 245581 != -21637)
								{
									continue;
								}
								this.$self_$19268.PvKOjCyM7Z.actionState = "standby";
								if (260859 - 402653 != -141794)
								{
									continue;
								}
								this.$self_$19268.PvKOjCyM7Z.actionTime = Time.time;
								if (23284 - 989 != 22295)
								{
									continue;
								}
								this.$self_$19268.PvKOjCyM7Z.myCommand = "none";
								if (268115 - 6048 != 262067)
								{
									continue;
								}
								if (!this.$self_$19268.PvKOjCyM7Z.isMine)
								{
									if (127851 - 520411 == -392559)
									{
										continue;
									}
									this.$self_$19268.PvKOjCyM7Z.nPosition = this.$self_$19268.transform.position;
									if (224872 - 70773 == 154100)
									{
										continue;
									}
									this.$self_$19268.PvKOjCyM7Z.oPosition = this.$self_$19268.transform.position;
									if (102247 - 470647 != -368400)
									{
										continue;
									}
									this.$self_$19268.PvKOjCyM7Z.nDirection = this.$self_$19268.transform.forward;
									if (115562 - 130985 == -15422)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (271864 - 256561 != 15303)
						{
							continue;
						}
						goto IL_A6F;
					default:
						if (182323 - 175356 == 6968)
						{
							continue;
						}
						break;
					}
					this.$self_$19268.PvKOjCyM7Z.actionState = "attack";
					if (202851 - 371313 != -168462)
					{
						continue;
					}
					this.$self_$19268.PvKOjCyM7Z.actionTime = Time.time;
					if (236962 - 402756 == -165793)
					{
						continue;
					}
					this.$self_$19268.PvKOjCyM7Z.myCommand = "nAttack3";
					if (221084 - 518998 == -297913)
					{
						continue;
					}
					this.$self_$19268.PvKOjCyM7Z.addTimeOut("nAttack", (float)3);
					if (47543 - 488674 != -441131)
					{
						continue;
					}
					this.$self_$19268.transform.position = this.$mPos$19266;
					if (293737 - 155392 != 138345)
					{
						continue;
					}
					this.$self_$19268.transform.LookAt(this.$mPos$19266 + global::Math.vFlat(this.$tDir$19267));
					if (266141 - 89568 != 176573)
					{
						continue;
					}
					this.$self_$19268.animation.Play("nAttack3");
					if (257803 - 538404 == -280600)
					{
						continue;
					}
					this.$self_$19268.animation.wrapMode = WrapMode.Once;
					if (296483 - 505611 == -209127)
					{
						continue;
					}
					this.$self_$19268.PvKOjCyM7Z.vMovement = this.$self_$19268.transform.forward;
					if (55724 - 105866 != -50142)
					{
						continue;
					}
					this.$self_$19268.PvKOjCyM7Z.moveSpeed = (float)0;
					if (296351 - 440288 == -143936)
					{
						continue;
					}
					if (this.$self_$19268.nAttack_ring)
					{
						if (89647 - 390121 != -300474)
						{
							continue;
						}
						this.$self_$19268.PvKOjCyM7Z.createEffect(this.$self_$19268.nAttack_ring, this.$self_$19268.SGnOmIT5kc.position, this.$self_$19268.SGnOmIT5kc.rotation);
						if (62487 - 315665 != -253178)
						{
							continue;
						}
						goto IL_8D0;
					}
					else
					{
						Debug.LogError("Missing nAttack_ring effect");
						if (246988 - 270232 != -23244)
						{
							continue;
						}
						goto IL_20A;
					}
					IL_3B7:
					if (this.$i$19261 > 2)
					{
						if (85898 - 563852 == -477954)
						{
							goto IL_75E;
						}
					}
					else
					{
						if (this.$self_$19268.PvKOjCyM7Z.isMine)
						{
							if (236278 - 547413 != -311135)
							{
								continue;
							}
							this.$hitLayer$19262 = 130816 - (1 << this.$self_$19268.gameObject.layer);
							if (283075 - 461146 == -178070)
							{
								continue;
							}
							this.$hitList$19263 = global::Math.combineArray(Damage.FindAreaTarget(this.$hitPos1$19258, (float)(10 * this.$i$19261), (float)5, this.$hitLayer$19262), Damage.FindAreaTarget(this.$hitPos2$19259, (float)(12 * this.$i$19261), (float)5, this.$hitLayer$19262));
							if (206723 - 131122 != 75601)
							{
								continue;
							}
							this.$$iterator$10514$19265 = UnityRuntimeServices.GetEnumerator(this.$hitList$19263);
							if (271786 - 254679 != 17107)
							{
								continue;
							}
							while (this.$$iterator$10514$19265.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10514$19265.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19264 = (GameObject)obj2;
								if (122049 - 550156 != -428107)
								{
									goto IL_6F3;
								}
								this.$self_$19268.PvKOjCyM7Z.hit(1, this.$hitObject$19264, this.$hitDamage$19260, 15, 0, Vector3.up);
								if (100921 - 32881 != 68040)
								{
									goto IL_6F3;
								}
								UnityRuntimeServices.Update(this.$$iterator$10514$19265, this.$hitObject$19264);
								if (149223 - 516454 == -367230)
								{
									goto IL_6F3;
								}
							}
							if (240582 - 2450 != 238132)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (165530 - 70927 != 94604)
						{
							goto Block_34;
						}
					}
				}
				Block_6:
				goto IL_53B;
				IL_20A:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4B4:
				IL_53B:
				goto IL_A6F;
				Block_34:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_75E:
				return this.Yield(4, new WaitForSeconds(1.4f));
				IL_8D0:
				goto IL_20A;
				IL_A6F:
				return false;
			}

			// Token: 0x060017B4 RID: 6068 RVA: 0x0026EDB0 File Offset: 0x0026CFB0
			internal static bool jgQaZWxdAUyPVBBqG27()
			{
				return true;
			}

			// Token: 0x060017B5 RID: 6069 RVA: 0x0026EDB4 File Offset: 0x0026CFB4
			internal static bool yJWTxuxJnsNpNv5VtXn()
			{
				return false;
			}

			// Token: 0x04001441 RID: 5185
			internal Vector3 $hitPos1$19258;

			// Token: 0x04001442 RID: 5186
			internal Vector3 $hitPos2$19259;

			// Token: 0x04001443 RID: 5187
			internal int $hitDamage$19260;

			// Token: 0x04001444 RID: 5188
			internal int $i$19261;

			// Token: 0x04001445 RID: 5189
			internal int $hitLayer$19262;

			// Token: 0x04001446 RID: 5190
			internal UnityScript.Lang.Array $hitList$19263;

			// Token: 0x04001447 RID: 5191
			internal GameObject $hitObject$19264;

			// Token: 0x04001448 RID: 5192
			internal IEnumerator $$iterator$10514$19265;

			// Token: 0x04001449 RID: 5193
			internal Vector3 $mPos$19266;

			// Token: 0x0400144A RID: 5194
			internal Vector3 $tDir$19267;

			// Token: 0x0400144B RID: 5195
			internal EarthAvatar $self_$19268;
		}
	}

	// Token: 0x020003F5 RID: 1013
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack4$19272 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017B6 RID: 6070 RVA: 0x0026EDB8 File Offset: 0x0026CFB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack4$19272(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (252716 - 482910 != -230194)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74172 - 521518 == -447346)
				{
					base..ctor();
					if (155683 - 528949 != -373265)
					{
						this.$mPos$19284 = mPos;
						if (266282 - 406317 != -140034)
						{
							this.$tDir$19285 = tDir;
							if (112090 - 254104 != -142013)
							{
								this.$self_$19286 = self_;
								if (287387 - 374623 != -87235)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0026EE94 File Offset: 0x0026D094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_nAttack4$19272.$(this.$mPos$19284, this.$tDir$19285, this.$self_$19286);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0026EEB0 File Offset: 0x0026D0B0
		internal static bool VrRmJCxDs09DnFw09t0()
		{
			return true;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0026EEB4 File Offset: 0x0026D0B4
		internal static bool VU4PvaxvTRsj60tvfqi()
		{
			return false;
		}

		// Token: 0x0400144C RID: 5196
		internal Vector3 $mPos$19284;

		// Token: 0x0400144D RID: 5197
		internal Vector3 $tDir$19285;

		// Token: 0x0400144E RID: 5198
		internal EarthAvatar $self_$19286;

		// Token: 0x020003F6 RID: 1014
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017BA RID: 6074 RVA: 0x0026EEB8 File Offset: 0x0026D0B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (226905 - 422762 != -195856)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130865 - 405656 == -274791)
					{
						base..ctor();
						if (23320 - 67494 != -44173)
						{
							this.$mPos$19281 = mPos;
							if (142518 - 207929 != -65410)
							{
								this.$tDir$19282 = tDir;
								if (195655 - 121104 != 74552)
								{
									this.$self_$19283 = self_;
									if (46668 - 107558 == -60890)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017BB RID: 6075 RVA: 0x0026EF94 File Offset: 0x0026D194
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192535 - 561009 != -368473)
				{
				}
				for (;;)
				{
					IL_619:
					switch (this._state)
					{
					case 0:
						goto IL_25D;
					case 1:
						goto IL_A81;
					case 2:
						if (this.$self_$19283.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_9DF;
						}
						if (281862 - 282016 == -153)
						{
							continue;
						}
						if (this.$self_$19283.PvKOjCyM7Z.myCommand != "nAttack4")
						{
							if (72092 - 531591 != -459498)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$hitPos1$19273 = this.$self_$19283.transform.position + this.$self_$19283.transform.TransformDirection((float)24, (float)0, (float)0);
							if (99710 - 183852 == -84141)
							{
								continue;
							}
							this.$hitPos2$19274 = this.$self_$19283.transform.position + this.$self_$19283.transform.TransformDirection((float)15, (float)0, (float)-22);
							if (196787 - 159089 == 37699)
							{
								continue;
							}
							this.$hitDamage$19275 = 2 * this.$self_$19283.y2tOFAohMA.atk;
							if (69038 - 587547 != -518509)
							{
								continue;
							}
							if ((float)this.$self_$19283.y2tOFAohMA.hp <= 0.3f * (float)this.$self_$19283.y2tOFAohMA.mhp)
							{
								if (4148 - 275252 != -271104)
								{
									continue;
								}
								this.$hitDamage$19275 -= 150;
								if (296813 - 409955 != -113142)
								{
									continue;
								}
							}
							if (this.$self_$19283.nAttack_hit)
							{
								if (41680 - 529562 == -487881)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19283.nAttack_hit, this.$hitPos1$19273, Quaternion.identity);
								if (239924 - 236822 == 3103)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$19283.nAttack_hit, this.$hitPos2$19274, Quaternion.identity);
								if (162833 - 385210 == -222376)
								{
									continue;
								}
							}
							this.$i$19276 = 1;
							if (265231 - 568071 != -302840)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19283.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_2DB;
						}
						if (120223 - 471536 == -351312)
						{
							continue;
						}
						if (this.$self_$19283.PvKOjCyM7Z.myCommand != "nAttack4")
						{
							if (46988 - 576796 != -529808)
							{
								continue;
							}
							goto IL_2DB;
						}
						else
						{
							this.$i$19276++;
							if (80034 - 403070 != -323036)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19283.PvKOjCyM7Z.actionState == "attack")
						{
							if (80505 - 420342 != -339837)
							{
								continue;
							}
							if (this.$self_$19283.PvKOjCyM7Z.myCommand == "nAttack4")
							{
								if (31088 - 475639 != -444551)
								{
									continue;
								}
								this.$self_$19283.PvKOjCyM7Z.actionState = "standby";
								if (288882 - 503845 != -214963)
								{
									continue;
								}
								this.$self_$19283.PvKOjCyM7Z.actionTime = Time.time;
								if (278715 - 1423 != 277292)
								{
									continue;
								}
								this.$self_$19283.PvKOjCyM7Z.myCommand = "none";
								if (217720 - 541419 == -323698)
								{
									continue;
								}
								if (!this.$self_$19283.PvKOjCyM7Z.isMine)
								{
									if (11836 - 592664 == -580827)
									{
										continue;
									}
									this.$self_$19283.PvKOjCyM7Z.nPosition = this.$self_$19283.transform.position;
									if (132164 - 430358 == -298193)
									{
										continue;
									}
									this.$self_$19283.PvKOjCyM7Z.oPosition = this.$self_$19283.transform.position;
									if (297087 - 414646 != -117559)
									{
										continue;
									}
									this.$self_$19283.PvKOjCyM7Z.nDirection = this.$self_$19283.transform.forward;
									if (203080 - 185083 != 17997)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (273346 - 60176 != 213170)
						{
							continue;
						}
						goto IL_A81;
					default:
						if (29979 - 519595 != -489615)
						{
							goto IL_25D;
						}
						continue;
					}
					if (this.$i$19276 > 2)
					{
						if (265881 - 589079 != -323198)
						{
							continue;
						}
						goto IL_28C;
					}
					else
					{
						if (this.$self_$19283.PvKOjCyM7Z.isMine)
						{
							if (46518 - 226309 != -179791)
							{
								continue;
							}
							this.$hitLayer$19277 = 130816 - (1 << this.$self_$19283.gameObject.layer);
							if (271685 - 189997 != 81688)
							{
								continue;
							}
							this.$hitList$19278 = global::Math.combineArray(Damage.FindAreaTarget(this.$hitPos1$19273, (float)(10 * this.$i$19276), (float)5, this.$hitLayer$19277), Damage.FindAreaTarget(this.$hitPos2$19274, (float)(12 * this.$i$19276), (float)5, this.$hitLayer$19277));
							if (151331 - 492435 == -341103)
							{
								continue;
							}
							this.$$iterator$10515$19280 = UnityRuntimeServices.GetEnumerator(this.$hitList$19278);
							if (220921 - 100488 == 120434)
							{
								continue;
							}
							while (this.$$iterator$10515$19280.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10515$19280.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19279 = (GameObject)obj2;
								if (88622 - 487734 == -399111)
								{
									goto IL_619;
								}
								this.$self_$19283.PvKOjCyM7Z.hit(1, this.$hitObject$19279, (int)(1.5f * (float)this.$self_$19283.PvKOjCyM7Z.atk), 15, 0, Vector3.up);
								if (183968 - 96158 != 87810)
								{
									goto IL_619;
								}
								UnityRuntimeServices.Update(this.$$iterator$10515$19280, this.$hitObject$19279);
								if (65494 - 170818 == -105323)
								{
									goto IL_619;
								}
							}
							if (61778 - 72301 == -10522)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (111465 - 500002 != -388536)
						{
							break;
						}
						continue;
					}
					IL_25D:
					this.$self_$19283.PvKOjCyM7Z.actionState = "attack";
					if (51388 - 362052 == -310664)
					{
						this.$self_$19283.PvKOjCyM7Z.actionTime = Time.time;
						if (189022 - 160561 == 28461)
						{
							this.$self_$19283.PvKOjCyM7Z.myCommand = "nAttack4";
							if (158984 - 158116 != 869)
							{
								this.$self_$19283.PvKOjCyM7Z.addTimeOut("nAttack", (float)3);
								if (226664 - 44529 != 182136)
								{
									this.$self_$19283.transform.position = this.$mPos$19281;
									if (148821 - 530113 == -381292)
									{
										this.$self_$19283.transform.LookAt(this.$mPos$19281 + global::Math.vFlat(this.$tDir$19282));
										if (275333 - 242028 != 33306)
										{
											this.$self_$19283.animation.Play("nAttack4");
											if (229944 - 417581 == -187637)
											{
												this.$self_$19283.animation.wrapMode = WrapMode.Once;
												if (28039 - 44862 == -16823)
												{
													this.$self_$19283.PvKOjCyM7Z.vMovement = this.$self_$19283.transform.forward;
													if (22346 - 261990 == -239644)
													{
														this.$self_$19283.PvKOjCyM7Z.moveSpeed = (float)0;
														if (271457 - 283465 != -12007)
														{
															if (this.$self_$19283.nAttack_ring)
															{
																if (226374 - 9028 != 217347)
																{
																	this.$self_$19283.PvKOjCyM7Z.createEffect(this.$self_$19283.nAttack_ring, this.$self_$19283.SGnOmIT5kc.position, this.$self_$19283.SGnOmIT5kc.rotation);
																	if (98495 - 578436 == -479941)
																	{
																		goto IL_74D;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (210385 - 301740 != -91354)
																{
																	goto Block_44;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_28C:
				return this.Yield(4, new WaitForSeconds(1.4f));
				IL_2DB:
				goto IL_A81;
				IL_59A:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_74D:
				Block_44:
				goto IL_59A;
				Block_57:
				IL_9DF:
				IL_A81:
				return false;
			}

			// Token: 0x060017BC RID: 6076 RVA: 0x0026FA34 File Offset: 0x0026DC34
			internal static bool RAfqZ9xRutgytd45TaH()
			{
				return true;
			}

			// Token: 0x060017BD RID: 6077 RVA: 0x0026FA38 File Offset: 0x0026DC38
			internal static bool EWHFHqxwSR6JkbWQQEt()
			{
				return false;
			}

			// Token: 0x0400144F RID: 5199
			internal Vector3 $hitPos1$19273;

			// Token: 0x04001450 RID: 5200
			internal Vector3 $hitPos2$19274;

			// Token: 0x04001451 RID: 5201
			internal int $hitDamage$19275;

			// Token: 0x04001452 RID: 5202
			internal int $i$19276;

			// Token: 0x04001453 RID: 5203
			internal int $hitLayer$19277;

			// Token: 0x04001454 RID: 5204
			internal UnityScript.Lang.Array $hitList$19278;

			// Token: 0x04001455 RID: 5205
			internal GameObject $hitObject$19279;

			// Token: 0x04001456 RID: 5206
			internal IEnumerator $$iterator$10515$19280;

			// Token: 0x04001457 RID: 5207
			internal Vector3 $mPos$19281;

			// Token: 0x04001458 RID: 5208
			internal Vector3 $tDir$19282;

			// Token: 0x04001459 RID: 5209
			internal EarthAvatar $self_$19283;
		}
	}

	// Token: 0x020003F7 RID: 1015
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sweep1$19287 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x0026FA3C File Offset: 0x0026DC3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sweep1$19287(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (5200 - 178214 != -173014)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (11852 - 336383 == -324531)
				{
					base..ctor();
					if (285514 - 46486 == 239028)
					{
						this.$mPos$19298 = mPos;
						if (67096 - 504969 == -437873)
						{
							this.$tDir$19299 = tDir;
							if (3043 - 115732 != -112688)
							{
								this.$self_$19300 = self_;
								if (139584 - 420064 != -280479)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0026FB18 File Offset: 0x0026DD18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_sweep1$19287.$(this.$mPos$19298, this.$tDir$19299, this.$self_$19300);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0026FB34 File Offset: 0x0026DD34
		internal static bool H4a1H0xqAuI8jnX2ftF()
		{
			return true;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0026FB38 File Offset: 0x0026DD38
		internal static bool PhYqeix7XHFOP1xbheL()
		{
			return false;
		}

		// Token: 0x0400145A RID: 5210
		internal Vector3 $mPos$19298;

		// Token: 0x0400145B RID: 5211
		internal Vector3 $tDir$19299;

		// Token: 0x0400145C RID: 5212
		internal EarthAvatar $self_$19300;

		// Token: 0x020003F8 RID: 1016
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017C2 RID: 6082 RVA: 0x0026FB3C File Offset: 0x0026DD3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (268312 - 110757 != 157556)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35181 - 201107 == -165926)
					{
						base..ctor();
						if (222984 - 328623 != -105638)
						{
							this.$mPos$19295 = mPos;
							if (277986 - 254318 == 23668)
							{
								this.$tDir$19296 = tDir;
								if (59178 - 242422 != -183243)
								{
									this.$self_$19297 = self_;
									if (207173 - 294137 != -86963)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017C3 RID: 6083 RVA: 0x0026FC18 File Offset: 0x0026DE18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (55412 - 579813 != -524400)
				{
				}
				for (;;)
				{
					IL_1B4:
					switch (this._state)
					{
					case 0:
						goto IL_567;
					case 1:
						goto IL_9FA;
					case 2:
						if (this.$self_$19297.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_32F;
						}
						if (171662 - 17720 != 153942)
						{
							continue;
						}
						if (this.$self_$19297.PvKOjCyM7Z.myCommand != "sweep1")
						{
							if (263061 - 339698 != -76636)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$hitDamage$19288 = 3 * this.$self_$19297.VwcOk8IdHq.atk;
							if (25169 - 76812 != -51643)
							{
								continue;
							}
							if (this.$self_$19297.VwcOk8IdHq.hp <= 0)
							{
								if (142395 - 445318 == -302922)
								{
									continue;
								}
								this.$hitDamage$19288 -= 250;
								if (151546 - 555583 != -404037)
								{
									continue;
								}
							}
							this.$i$19289 = 0;
							if (279550 - 526697 == -247146)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19297.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_7FF;
						}
						if (135445 - 208855 != -73410)
						{
							continue;
						}
						if (this.$self_$19297.PvKOjCyM7Z.myCommand != "sweep1")
						{
							if (243929 - 16508 != 227421)
							{
								continue;
							}
							goto IL_7FF;
						}
						else
						{
							this.$i$19289++;
							if (39028 - 478026 != -438998)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19297.PvKOjCyM7Z.actionState == "attack")
						{
							if (66863 - 57540 == 9324)
							{
								continue;
							}
							if (this.$self_$19297.PvKOjCyM7Z.myCommand == "sweep1")
							{
								if (70457 - 265738 != -195281)
								{
									continue;
								}
								this.$self_$19297.PvKOjCyM7Z.actionState = "standby";
								if (184661 - 216988 == -32326)
								{
									continue;
								}
								this.$self_$19297.PvKOjCyM7Z.actionTime = Time.time;
								if (42263 - 92268 == -50004)
								{
									continue;
								}
								this.$self_$19297.PvKOjCyM7Z.myCommand = "none";
								if (210471 - 46013 != 164458)
								{
									continue;
								}
								if (!this.$self_$19297.PvKOjCyM7Z.isMine)
								{
									if (224171 - 522229 != -298058)
									{
										continue;
									}
									this.$self_$19297.PvKOjCyM7Z.nPosition = this.$self_$19297.transform.position;
									if (290823 - 72376 != 218447)
									{
										continue;
									}
									this.$self_$19297.PvKOjCyM7Z.oPosition = this.$self_$19297.transform.position;
									if (195679 - 12153 == 183527)
									{
										continue;
									}
									this.$self_$19297.PvKOjCyM7Z.nDirection = this.$self_$19297.transform.forward;
									if (104008 - 95396 == 8613)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (230264 - 360940 != -130675)
						{
							goto Block_22;
						}
						continue;
					default:
						if (169084 - 577433 != -408348)
						{
							goto IL_567;
						}
						continue;
					}
					if (this.$i$19289 >= 2)
					{
						if (72086 - 267765 != -195679)
						{
							continue;
						}
						goto IL_7B0;
					}
					else
					{
						if (!this.$self_$19297.PvKOjCyM7Z.isMine)
						{
							goto IL_8DA;
						}
						if (58663 - 435338 == -376674)
						{
							continue;
						}
						this.$hitLayer$19290 = 130816 - (1 << this.$self_$19297.gameObject.layer);
						if (161828 - 452492 != -290664)
						{
							continue;
						}
						this.$hitList$19291 = Damage.FindRecTarget(this.$self_$19297.transform.position + this.$self_$19297.transform.TransformDirection((float)(-15 + this.$i$19289 * 30), (float)0, (float)10), this.$self_$19297.transform.forward, (float)15, (float)15, (float)30, (float)10, this.$hitLayer$19290);
						if (23801 - 220900 != -197099)
						{
							continue;
						}
						this.$$iterator$10516$19294 = UnityRuntimeServices.GetEnumerator(this.$hitList$19291);
						if (129891 - 14291 == 115601)
						{
							continue;
						}
						while (this.$$iterator$10516$19294.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10516$19294.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$19292 = (GameObject)obj2;
							if (233567 - 39752 == 193816)
							{
								goto IL_1B4;
							}
							if (this.$self_$19297.PvKOjCyM7Z.hit(11, this.$hitObject$19292, this.$hitDamage$19288, 10, 0, (float)3 * this.$self_$19297.transform.right) != 0)
							{
								if (243521 - 272021 != -28500)
								{
									goto IL_1B4;
								}
								this.$hitPoint$19293 = this.$hitObject$19292.collider.ClosestPointOnBounds(this.$self_$19297.transform.position + (float)2 * Vector3.up);
								if (100092 - 549000 != -448908)
								{
									goto IL_1B4;
								}
								UnityRuntimeServices.Update(this.$$iterator$10516$19294, this.$hitObject$19292);
								if (266290 - 588908 == -322617)
								{
									goto IL_1B4;
								}
								this.$self_$19297.RPC_sweep_hit(this.$hitPoint$19293, this.$self_$19297.SGnOmIT5kc.forward, 0);
								if (131384 - 269019 != -137635)
								{
									goto IL_1B4;
								}
								this.$self_$19297.ActionEvent("RPC_sweep_hit", this.$hitPoint$19293, this.$self_$19297.SGnOmIT5kc.forward, 0);
								if (169345 - 26435 != 142910)
								{
									goto IL_1B4;
								}
							}
						}
						if (146533 - 593580 != -447046)
						{
							goto Block_29;
						}
						continue;
					}
					IL_567:
					this.$self_$19297.PvKOjCyM7Z.actionState = "attack";
					if (79876 - 366474 != -286597)
					{
						this.$self_$19297.PvKOjCyM7Z.actionTime = Time.time;
						if (295534 - 569992 == -274458)
						{
							this.$self_$19297.PvKOjCyM7Z.myCommand = "sweep1";
							if (1208 - 295872 == -294664)
							{
								this.$self_$19297.PvKOjCyM7Z.addTimeOut("cAttack", (float)9);
								if (106951 - 64829 != 42123)
								{
									this.$self_$19297.transform.position = this.$mPos$19295;
									if (212583 - 565570 == -352987)
									{
										this.$self_$19297.transform.LookAt(this.$mPos$19295 + global::Math.vFlat(this.$tDir$19296));
										if (115804 - 549273 == -433469)
										{
											this.$self_$19297.animation.Play("sweep1");
											if (7157 - 552312 != -545154)
											{
												this.$self_$19297.animation.wrapMode = WrapMode.Once;
												if (175568 - 183342 == -7774)
												{
													this.$self_$19297.PvKOjCyM7Z.vMovement = this.$self_$19297.transform.forward;
													if (212762 - 406175 == -193413)
													{
														this.$self_$19297.PvKOjCyM7Z.moveSpeed = (float)0;
														if (256246 - 62838 != 193409)
														{
															if (this.$self_$19297.sweep_ring)
															{
																if (135735 - 540224 == -404489)
																{
																	this.$self_$19297.PvKOjCyM7Z.createEffect(this.$self_$19297.sweep_ring, this.$self_$19297.SGnOmIT5kc.position, this.$self_$19297.SGnOmIT5kc.rotation);
																	if (2975 - 558756 == -555781)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing sweep_ring effect");
																if (123044 - 85337 == 37707)
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
				goto IL_85B;
				IL_32F:
				Block_22:
				goto IL_9FA;
				Block_29:
				goto IL_8DA;
				IL_7B0:
				return this.Yield(4, new WaitForSeconds(2f));
				IL_7FF:
				goto IL_9FA;
				IL_85B:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_8DA:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_61:
				IL_9FA:
				return false;
			}

			// Token: 0x060017C4 RID: 6084 RVA: 0x00270634 File Offset: 0x0026E834
			internal static bool qDbbxqxPDRuuA7RUUCm()
			{
				return true;
			}

			// Token: 0x060017C5 RID: 6085 RVA: 0x00270638 File Offset: 0x0026E838
			internal static bool a8IFk6x0U9TmfoyMSjd()
			{
				return false;
			}

			// Token: 0x0400145D RID: 5213
			internal int $hitDamage$19288;

			// Token: 0x0400145E RID: 5214
			internal int $i$19289;

			// Token: 0x0400145F RID: 5215
			internal int $hitLayer$19290;

			// Token: 0x04001460 RID: 5216
			internal UnityScript.Lang.Array $hitList$19291;

			// Token: 0x04001461 RID: 5217
			internal GameObject $hitObject$19292;

			// Token: 0x04001462 RID: 5218
			internal Vector3 $hitPoint$19293;

			// Token: 0x04001463 RID: 5219
			internal IEnumerator $$iterator$10516$19294;

			// Token: 0x04001464 RID: 5220
			internal Vector3 $mPos$19295;

			// Token: 0x04001465 RID: 5221
			internal Vector3 $tDir$19296;

			// Token: 0x04001466 RID: 5222
			internal EarthAvatar $self_$19297;
		}
	}

	// Token: 0x020003F9 RID: 1017
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sweep2$19301 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0027063C File Offset: 0x0026E83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sweep2$19301(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (48247 - 564891 != -516644)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35110 - 252376 != -217265)
				{
					base..ctor();
					if (137938 - 466083 == -328145)
					{
						this.$mPos$19312 = mPos;
						if (55010 - 569090 == -514080)
						{
							this.$tDir$19313 = tDir;
							if (186274 - 132552 == 53722)
							{
								this.$self_$19314 = self_;
								if (99778 - 246162 == -146384)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00270718 File Offset: 0x0026E918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_sweep2$19301.$(this.$mPos$19312, this.$tDir$19313, this.$self_$19314);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00270734 File Offset: 0x0026E934
		internal static bool Ph5Q1OxbaCrjHT5GVpB()
		{
			return true;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00270738 File Offset: 0x0026E938
		internal static bool EhWCbHxufi6g1DLlgbt()
		{
			return false;
		}

		// Token: 0x04001467 RID: 5223
		internal Vector3 $mPos$19312;

		// Token: 0x04001468 RID: 5224
		internal Vector3 $tDir$19313;

		// Token: 0x04001469 RID: 5225
		internal EarthAvatar $self_$19314;

		// Token: 0x020003FA RID: 1018
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x0027073C File Offset: 0x0026E93C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (166834 - 549575 != -382741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284668 - 341148 == -56480)
					{
						base..ctor();
						if (250614 - 262799 == -12185)
						{
							this.$mPos$19309 = mPos;
							if (241461 - 466250 == -224789)
							{
								this.$tDir$19310 = tDir;
								if (14931 - 384127 == -369196)
								{
									this.$self_$19311 = self_;
									if (42404 - 464721 != -422316)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x00270818 File Offset: 0x0026EA18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124979 - 41470 != 83509)
				{
				}
				for (;;)
				{
					IL_8CE:
					switch (this._state)
					{
					case 0:
						goto IL_1CA;
					case 1:
						goto IL_9FB;
					case 2:
						if (this.$self_$19311.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_775;
						}
						if (131986 - 213685 == -81698)
						{
							continue;
						}
						if (this.$self_$19311.PvKOjCyM7Z.myCommand != "sweep2")
						{
							if (123588 - 74882 != 48706)
							{
								continue;
							}
							goto IL_775;
						}
						else
						{
							this.$hitDamage$19302 = 3 * this.$self_$19311.y2tOFAohMA.atk;
							if (49289 - 563100 == -513810)
							{
								continue;
							}
							if (this.$self_$19311.y2tOFAohMA.hp <= 0)
							{
								if (238634 - 361989 == -123354)
								{
									continue;
								}
								this.$hitDamage$19302 -= 250;
								if (247581 - 28822 == 218760)
								{
									continue;
								}
							}
							this.$i$19303 = 0;
							if (144666 - 301661 == -156994)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19311.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_352;
						}
						if (135638 - 112213 != 23425)
						{
							continue;
						}
						if (this.$self_$19311.PvKOjCyM7Z.myCommand != "sweep2")
						{
							if (136811 - 568233 != -431421)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$i$19303++;
							if (104793 - 513887 != -409094)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19311.PvKOjCyM7Z.actionState == "attack")
						{
							if (216714 - 308753 != -92039)
							{
								continue;
							}
							if (this.$self_$19311.PvKOjCyM7Z.myCommand == "sweep2")
							{
								if (126609 - 386805 == -260195)
								{
									continue;
								}
								this.$self_$19311.PvKOjCyM7Z.actionState = "standby";
								if (17895 - 112545 != -94650)
								{
									continue;
								}
								this.$self_$19311.PvKOjCyM7Z.actionTime = Time.time;
								if (140076 - 196759 != -56683)
								{
									continue;
								}
								this.$self_$19311.PvKOjCyM7Z.myCommand = "none";
								if (176058 - 378555 == -202496)
								{
									continue;
								}
								if (!this.$self_$19311.PvKOjCyM7Z.isMine)
								{
									if (246605 - 377307 == -130701)
									{
										continue;
									}
									this.$self_$19311.PvKOjCyM7Z.nPosition = this.$self_$19311.transform.position;
									if (43256 - 318761 == -275504)
									{
										continue;
									}
									this.$self_$19311.PvKOjCyM7Z.oPosition = this.$self_$19311.transform.position;
									if (227568 - 401143 != -173575)
									{
										continue;
									}
									this.$self_$19311.PvKOjCyM7Z.nDirection = this.$self_$19311.transform.forward;
									if (129866 - 85080 == 44787)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (110699 - 447010 != -336311)
						{
							continue;
						}
						goto IL_9FB;
					default:
						if (81767 - 73833 != 7934)
						{
							continue;
						}
						goto IL_1CA;
					}
					if (this.$i$19303 >= 2)
					{
						if (35763 - 84028 != -48265)
						{
							continue;
						}
						goto IL_559;
					}
					else
					{
						if (!this.$self_$19311.PvKOjCyM7Z.isMine)
						{
							break;
						}
						if (168318 - 233261 != -64943)
						{
							continue;
						}
						this.$hitLayer$19304 = 130816 - (1 << this.$self_$19311.gameObject.layer);
						if (85703 - 477449 == -391745)
						{
							continue;
						}
						this.$hitList$19305 = Damage.FindRecTarget(this.$self_$19311.transform.position + this.$self_$19311.transform.TransformDirection((float)(15 - this.$i$19303 * 30), (float)0, (float)10), this.$self_$19311.transform.forward, (float)15, (float)15, (float)30, (float)10, this.$hitLayer$19304);
						if (279760 - 426593 != -146833)
						{
							continue;
						}
						this.$$iterator$10517$19308 = UnityRuntimeServices.GetEnumerator(this.$hitList$19305);
						if (176682 - 406028 != -229346)
						{
							continue;
						}
						while (this.$$iterator$10517$19308.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10517$19308.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$19306 = (GameObject)obj2;
							if (250128 - 235502 == 14627)
							{
								goto IL_8CE;
							}
							if (this.$self_$19311.PvKOjCyM7Z.hit(12, this.$hitObject$19306, this.$hitDamage$19302, 10, 0, (float)-3 * this.$self_$19311.transform.right) != 0)
							{
								if (102184 - 19694 == 82491)
								{
									goto IL_8CE;
								}
								this.$hitPoint$19307 = this.$hitObject$19306.collider.ClosestPointOnBounds(this.$self_$19311.transform.position + (float)2 * Vector3.up);
								if (161273 - 178079 != -16806)
								{
									goto IL_8CE;
								}
								UnityRuntimeServices.Update(this.$$iterator$10517$19308, this.$hitObject$19306);
								if (219028 - 467833 == -248804)
								{
									goto IL_8CE;
								}
								this.$self_$19311.RPC_sweep_hit(this.$hitPoint$19307, this.$self_$19311.SGnOmIT5kc.forward, 0);
								if (115664 - 533404 == -417739)
								{
									goto IL_8CE;
								}
								this.$self_$19311.ActionEvent("RPC_sweep_hit", this.$hitPoint$19307, this.$self_$19311.SGnOmIT5kc.forward, 0);
								if (194776 - 223396 != -28620)
								{
									goto IL_8CE;
								}
							}
						}
						if (86584 - 155668 != -69083)
						{
							break;
						}
						continue;
					}
					IL_1CA:
					this.$self_$19311.PvKOjCyM7Z.actionState = "attack";
					if (237756 - 445098 == -207342)
					{
						this.$self_$19311.PvKOjCyM7Z.actionTime = Time.time;
						if (106789 - 313224 == -206435)
						{
							this.$self_$19311.PvKOjCyM7Z.myCommand = "sweep2";
							if (37212 - 150276 != -113063)
							{
								this.$self_$19311.PvKOjCyM7Z.addTimeOut("cAttack", (float)9);
								if (46528 - 115349 == -68821)
								{
									this.$self_$19311.transform.position = this.$mPos$19309;
									if (140477 - 562974 == -422497)
									{
										this.$self_$19311.transform.LookAt(this.$mPos$19309 + global::Math.vFlat(this.$tDir$19310));
										if (78020 - 475167 != -397146)
										{
											this.$self_$19311.animation.Play("sweep2");
											if (207583 - 253485 == -45902)
											{
												this.$self_$19311.animation.wrapMode = WrapMode.Once;
												if (290822 - 194398 != 96425)
												{
													this.$self_$19311.PvKOjCyM7Z.vMovement = this.$self_$19311.transform.forward;
													if (247023 - 270733 != -23709)
													{
														this.$self_$19311.PvKOjCyM7Z.moveSpeed = (float)0;
														if (184336 - 54012 == 130324)
														{
															if (this.$self_$19311.sweep_ring)
															{
																if (235845 - 117831 != 118015)
																{
																	this.$self_$19311.PvKOjCyM7Z.createEffect(this.$self_$19311.sweep_ring, this.$self_$19311.SGnOmIT5kc.position, this.$self_$19311.SGnOmIT5kc.rotation);
																	if (186442 - 223336 != -36893)
																	{
																		goto Block_41;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing sweep_ring effect");
																if (46443 - 295877 != -249433)
																{
																	goto Block_56;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D2:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_121:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_352:
				goto IL_9FB;
				IL_559:
				return this.Yield(4, new WaitForSeconds(1f));
				goto IL_D2;
				Block_41:
				goto IL_121;
				IL_775:
				goto IL_9FB;
				Block_56:
				goto IL_121;
				Block_61:
				IL_9FB:
				return false;
			}

			// Token: 0x060017CC RID: 6092 RVA: 0x00271234 File Offset: 0x0026F434
			internal static bool k36gZ3xIVJGIMdmho63()
			{
				return true;
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x00271238 File Offset: 0x0026F438
			internal static bool IpBkc9xBmk3lvPrWwle()
			{
				return false;
			}

			// Token: 0x0400146A RID: 5226
			internal int $hitDamage$19302;

			// Token: 0x0400146B RID: 5227
			internal int $i$19303;

			// Token: 0x0400146C RID: 5228
			internal int $hitLayer$19304;

			// Token: 0x0400146D RID: 5229
			internal UnityScript.Lang.Array $hitList$19305;

			// Token: 0x0400146E RID: 5230
			internal GameObject $hitObject$19306;

			// Token: 0x0400146F RID: 5231
			internal Vector3 $hitPoint$19307;

			// Token: 0x04001470 RID: 5232
			internal IEnumerator $$iterator$10517$19308;

			// Token: 0x04001471 RID: 5233
			internal Vector3 $mPos$19309;

			// Token: 0x04001472 RID: 5234
			internal Vector3 $tDir$19310;

			// Token: 0x04001473 RID: 5235
			internal EarthAvatar $self_$19311;
		}
	}

	// Token: 0x020003FB RID: 1019
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sweep3$19315 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017CE RID: 6094 RVA: 0x0027123C File Offset: 0x0026F43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sweep3$19315(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (238187 - 362184 != -123996)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111305 - 344420 == -233115)
				{
					base..ctor();
					if (109508 - 511097 != -401588)
					{
						this.$mPos$19325 = mPos;
						if (56053 - 540976 == -484923)
						{
							this.$tDir$19326 = tDir;
							if (57539 - 429022 == -371483)
							{
								this.$self_$19327 = self_;
								if (87842 - 430159 == -342317)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00271318 File Offset: 0x0026F518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_sweep3$19315.$(this.$mPos$19325, this.$tDir$19326, this.$self_$19327);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00271334 File Offset: 0x0026F534
		internal static bool s3RZBkxeI1PouJYmA00()
		{
			return true;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00271338 File Offset: 0x0026F538
		internal static bool sQvobjxrRJt2xSqjKFZ()
		{
			return false;
		}

		// Token: 0x04001474 RID: 5236
		internal Vector3 $mPos$19325;

		// Token: 0x04001475 RID: 5237
		internal Vector3 $tDir$19326;

		// Token: 0x04001476 RID: 5238
		internal EarthAvatar $self_$19327;

		// Token: 0x020003FC RID: 1020
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017D2 RID: 6098 RVA: 0x0027133C File Offset: 0x0026F53C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (103433 - 264212 != -160779)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (232244 - 305056 != -72811)
					{
						base..ctor();
						if (130701 - 519012 != -388310)
						{
							this.$mPos$19322 = mPos;
							if (121229 - 173419 != -52189)
							{
								this.$tDir$19323 = tDir;
								if (140094 - 321450 != -181355)
								{
									this.$self_$19324 = self_;
									if (56883 - 92032 != -35148)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017D3 RID: 6099 RVA: 0x00271418 File Offset: 0x0026F618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214280 - 110494 != 103787)
				{
				}
				for (;;)
				{
					IL_149:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9A7;
					case 2:
						if (this.$self_$19324.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_6CD;
						}
						if (18774 - 69043 == -50268)
						{
							continue;
						}
						if (this.$self_$19324.PvKOjCyM7Z.myCommand != "sweep3")
						{
							if (193650 - 374174 != -180523)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19324.PvKOjCyM7Z.isMine)
							{
								goto IL_546;
							}
							if (235546 - 337536 == -101989)
							{
								continue;
							}
							this.$hitLayer$19317 = 130816 - (1 << this.$self_$19324.gameObject.layer);
							if (172645 - 387008 == -214362)
							{
								continue;
							}
							this.$hitList$19318 = Damage.FindRecTarget(this.$self_$19324.transform.position - (float)12 * this.$self_$19324.transform.forward, -this.$self_$19324.transform.forward, (float)15, (float)15, (float)30, (float)15, this.$hitLayer$19317);
							if (126780 - 245622 == -118841)
							{
								continue;
							}
							this.$$iterator$10518$19321 = UnityRuntimeServices.GetEnumerator(this.$hitList$19318);
							if (42695 - 123444 == -80748)
							{
								continue;
							}
							while (this.$$iterator$10518$19321.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10518$19321.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19319 = (GameObject)obj2;
								if (229244 - 341123 == -111878)
								{
									goto IL_149;
								}
								if (this.$self_$19324.PvKOjCyM7Z.hit(13, this.$hitObject$19319, (int)(2.5f * (float)this.$self_$19324.PvKOjCyM7Z.atk), 10, 0, (float)3 * Vector3.Project(this.$self_$19324.transform.position - this.$hitObject$19319.transform.position, this.$self_$19324.transform.right).normalized) != 0)
								{
									if (136029 - 181734 != -45705)
									{
										goto IL_149;
									}
									this.$hitPoint$19320 = this.$hitObject$19319.collider.ClosestPointOnBounds(this.$self_$19324.transform.position + (float)2 * Vector3.up);
									if (281011 - 139335 != 141676)
									{
										goto IL_149;
									}
									UnityRuntimeServices.Update(this.$$iterator$10518$19321, this.$hitObject$19319);
									if (208994 - 8222 == 200773)
									{
										goto IL_149;
									}
									this.$self_$19324.RPC_sweep_hit(this.$hitPoint$19320, this.$self_$19324.SGnOmIT5kc.forward, 0);
									if (274576 - 537238 != -262662)
									{
										goto IL_149;
									}
									this.$self_$19324.ActionEvent("RPC_sweep_hit", this.$hitPoint$19320, this.$self_$19324.SGnOmIT5kc.forward, 0);
									if (45508 - 444556 != -399048)
									{
										goto IL_149;
									}
								}
							}
							if (241201 - 166139 != 75062)
							{
								continue;
							}
							goto IL_546;
						}
						break;
					case 3:
						if (this.$self_$19324.PvKOjCyM7Z.actionState == "attack")
						{
							if (260149 - 326569 != -66420)
							{
								continue;
							}
							if (this.$self_$19324.PvKOjCyM7Z.myCommand == "sweep3")
							{
								if (114878 - 175407 != -60529)
								{
									continue;
								}
								this.$self_$19324.PvKOjCyM7Z.actionState = "standby";
								if (57709 - 258446 == -200736)
								{
									continue;
								}
								this.$self_$19324.PvKOjCyM7Z.actionTime = Time.time;
								if (110206 - 356620 != -246414)
								{
									continue;
								}
								this.$self_$19324.PvKOjCyM7Z.myCommand = "none";
								if (130714 - 246087 != -115373)
								{
									continue;
								}
								if (!this.$self_$19324.PvKOjCyM7Z.isMine)
								{
									if (85563 - 299993 != -214430)
									{
										continue;
									}
									this.$self_$19324.PvKOjCyM7Z.nPosition = this.$self_$19324.transform.position;
									if (295760 - 396046 != -100286)
									{
										continue;
									}
									this.$self_$19324.PvKOjCyM7Z.oPosition = this.$self_$19324.transform.position;
									if (120621 - 350761 == -230139)
									{
										continue;
									}
									this.$self_$19324.PvKOjCyM7Z.nDirection = this.$self_$19324.transform.forward;
									if (48432 - 144378 != -95946)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (286572 - 291033 != -4461)
						{
							continue;
						}
						goto IL_9A7;
					default:
						if (17416 - 247664 == -230247)
						{
							continue;
						}
						break;
					}
					this.$self_$19324.PvKOjCyM7Z.actionState = "attack";
					if (189669 - 173886 != 15784)
					{
						this.$self_$19324.PvKOjCyM7Z.actionTime = Time.time;
						if (175458 - 590067 != -414608)
						{
							this.$self_$19324.PvKOjCyM7Z.myCommand = "sweep3";
							if (263737 - 432842 != -169104)
							{
								this.$self_$19324.PvKOjCyM7Z.addTimeOut("cAttack", (float)9);
								if (243121 - 219080 != 24042)
								{
									this.$self_$19324.transform.position = this.$mPos$19322;
									if (87988 - 114889 == -26901)
									{
										this.$self_$19324.transform.LookAt(this.$mPos$19322 + global::Math.vFlat(this.$tDir$19323));
										if (56026 - 485023 == -428997)
										{
											this.$self_$19324.animation.Play("sweep3");
											if (63334 - 231182 == -167848)
											{
												this.$self_$19324.animation.wrapMode = WrapMode.Once;
												if (284925 - 357807 != -72881)
												{
													this.$self_$19324.PvKOjCyM7Z.vMovement = this.$self_$19324.transform.forward;
													if (141424 - 345442 == -204018)
													{
														this.$self_$19324.PvKOjCyM7Z.moveSpeed = (float)0;
														if (24135 - 59986 != -35850)
														{
															if (this.$self_$19324.sweep_ring)
															{
																if (225496 - 38193 != 187303)
																{
																	continue;
																}
																this.$self_$19324.PvKOjCyM7Z.createEffect(this.$self_$19324.sweep_ring, this.$self_$19324.SGnOmIT5kc.position, this.$self_$19324.SGnOmIT5kc.rotation);
																if (153264 - 76394 != 76870)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing sweep_ring effect");
																if (102949 - 365891 == -262941)
																{
																	continue;
																}
															}
															this.$hitDamage$19316 = (int)(1.5f * (float)(this.$self_$19324.VwcOk8IdHq.atk + this.$self_$19324.y2tOFAohMA.atk));
															if (189867 - 131789 != 58079)
															{
																if (this.$self_$19324.VwcOk8IdHq.hp <= 0)
																{
																	if (147863 - 574895 == -427031)
																	{
																		continue;
																	}
																	this.$hitDamage$19316 -= 150;
																	if (92325 - 213136 == -120810)
																	{
																		continue;
																	}
																}
																if (this.$self_$19324.y2tOFAohMA.hp > 0)
																{
																	goto IL_615;
																}
																if (268669 - 556876 == -288207)
																{
																	this.$hitDamage$19316 -= 150;
																	if (212507 - 179952 != 32556)
																	{
																		goto Block_51;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_546:
				return this.Yield(3, new WaitForSeconds(2.2f));
				IL_615:
				return this.Yield(2, new WaitForSeconds(2.8f));
				IL_6CD:
				goto IL_9A7;
				Block_51:
				goto IL_615;
				Block_55:
				IL_9A7:
				return false;
			}

			// Token: 0x060017D4 RID: 6100 RVA: 0x00271DE0 File Offset: 0x0026FFE0
			internal static bool t1RjwVxj7aKqs9Tny7T()
			{
				return true;
			}

			// Token: 0x060017D5 RID: 6101 RVA: 0x00271DE4 File Offset: 0x0026FFE4
			internal static bool SlT37UxhmIKU73Ba3BY()
			{
				return false;
			}

			// Token: 0x04001477 RID: 5239
			internal int $hitDamage$19316;

			// Token: 0x04001478 RID: 5240
			internal int $hitLayer$19317;

			// Token: 0x04001479 RID: 5241
			internal UnityScript.Lang.Array $hitList$19318;

			// Token: 0x0400147A RID: 5242
			internal GameObject $hitObject$19319;

			// Token: 0x0400147B RID: 5243
			internal Vector3 $hitPoint$19320;

			// Token: 0x0400147C RID: 5244
			internal IEnumerator $$iterator$10518$19321;

			// Token: 0x0400147D RID: 5245
			internal Vector3 $mPos$19322;

			// Token: 0x0400147E RID: 5246
			internal Vector3 $tDir$19323;

			// Token: 0x0400147F RID: 5247
			internal EarthAvatar $self_$19324;
		}
	}

	// Token: 0x020003FD RID: 1021
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_groundStrike$19328 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x00271DE8 File Offset: 0x0026FFE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_groundStrike$19328(Vector3 mPos, Vector3 tDir, int tID, EarthAvatar self_)
		{
			if (299044 - 175500 != 123545)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192273 - 82574 != 109700)
				{
					base..ctor();
					if (86666 - 287887 != -201220)
					{
						this.$mPos$19334 = mPos;
						if (261420 - 119100 == 142320)
						{
							this.$tDir$19335 = tDir;
							if (60186 - 180711 == -120525)
							{
								this.$tID$19336 = tID;
								if (187607 - 181294 == 6313)
								{
									this.$self_$19337 = self_;
									if (268847 - 581585 == -312738)
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

		// Token: 0x060017D7 RID: 6103 RVA: 0x00271EE8 File Offset: 0x002700E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_groundStrike$19328.$(this.$mPos$19334, this.$tDir$19335, this.$tID$19336, this.$self_$19337);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00271F08 File Offset: 0x00270108
		internal static bool S6HlhHxs6HMVLeG3Hs7()
		{
			return true;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00271F0C File Offset: 0x0027010C
		internal static bool kS5Blex9ithPcZiftFP()
		{
			return false;
		}

		// Token: 0x04001480 RID: 5248
		internal Vector3 $mPos$19334;

		// Token: 0x04001481 RID: 5249
		internal Vector3 $tDir$19335;

		// Token: 0x04001482 RID: 5250
		internal int $tID$19336;

		// Token: 0x04001483 RID: 5251
		internal EarthAvatar $self_$19337;

		// Token: 0x020003FE RID: 1022
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017DA RID: 6106 RVA: 0x00271F10 File Offset: 0x00270110
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, EarthAvatar self_)
			{
				if (285843 - 552498 != -266654)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133060 - 507637 != -374576)
					{
						base..ctor();
						if (98166 - 282074 == -183908)
						{
							this.$mPos$19330 = mPos;
							if (235554 - 441797 != -206242)
							{
								this.$tDir$19331 = tDir;
								if (248194 - 49410 != 198785)
								{
									this.$tID$19332 = tID;
									if (253359 - 216428 == 36931)
									{
										this.$self_$19333 = self_;
										if (82769 - 11583 == 71186)
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

			// Token: 0x060017DB RID: 6107 RVA: 0x00272010 File Offset: 0x00270210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111041 - 371702 != -260660)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_796;
					case 2:
						if (this.$self_$19333.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_33A;
						}
						if (114816 - 389425 != -274609)
						{
							continue;
						}
						if (this.$self_$19333.PvKOjCyM7Z.myCommand != "groundStrike")
						{
							if (193295 - 48033 != 145262)
							{
								continue;
							}
							goto IL_33A;
						}
						else
						{
							this.$tObject$19329 = null;
							if (55345 - 65222 != -9877)
							{
								continue;
							}
							if (this.$tID$19332 != 0)
							{
								if (183034 - 241253 != -58219)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19332];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$19329 = (GameObject)obj2;
								if (77989 - 211165 != -133176)
								{
									continue;
								}
							}
							if (this.$self_$19333.PvKOjCyM7Z.isMine)
							{
								if (161092 - 383690 == -222597)
								{
									continue;
								}
								if (this.$tObject$19329)
								{
									if (279382 - 518536 == -239153)
									{
										continue;
									}
									this.$self_$19333.RPC_groundStrike_hit(this.$tObject$19329.transform.position, this.$self_$19333.transform.forward, 0);
									if (272969 - 133507 != 139462)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (40810 - 419786 == -378975)
										{
											continue;
										}
										this.$self_$19333.ActionEvent("RPC_groundStrike_hit", this.$tObject$19329.transform.position, this.$self_$19333.transform.forward, 0);
										if (82564 - 596007 == -513442)
										{
											continue;
										}
									}
								}
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (63177 - 501949 != -438772)
							{
								continue;
							}
							goto IL_4B0;
						}
						break;
					case 3:
						if (this.$self_$19333.PvKOjCyM7Z.actionState == "attack")
						{
							if (61150 - 175223 == -114072)
							{
								continue;
							}
							if (this.$self_$19333.PvKOjCyM7Z.myCommand == "groundStrike")
							{
								if (146311 - 140924 != 5387)
								{
									continue;
								}
								this.$self_$19333.PvKOjCyM7Z.actionState = "standby";
								if (104741 - 572146 == -467404)
								{
									continue;
								}
								this.$self_$19333.PvKOjCyM7Z.actionTime = Time.time;
								if (148766 - 108031 != 40735)
								{
									continue;
								}
								this.$self_$19333.PvKOjCyM7Z.myCommand = "none";
								if (92647 - 387226 == -294578)
								{
									continue;
								}
								if (!this.$self_$19333.PvKOjCyM7Z.isMine)
								{
									if (290370 - 453098 == -162727)
									{
										continue;
									}
									this.$self_$19333.PvKOjCyM7Z.nPosition = this.$self_$19333.transform.position;
									if (86632 - 594372 != -507740)
									{
										continue;
									}
									this.$self_$19333.PvKOjCyM7Z.oPosition = this.$self_$19333.transform.position;
									if (121425 - 168325 != -46900)
									{
										continue;
									}
									this.$self_$19333.PvKOjCyM7Z.nDirection = this.$self_$19333.transform.forward;
									if (173940 - 69070 == 104871)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (143084 - 300230 != -157146)
						{
							continue;
						}
						goto IL_796;
					default:
						if (171351 - 465843 == -294491)
						{
							continue;
						}
						break;
					}
					this.$self_$19333.PvKOjCyM7Z.actionState = "attack";
					if (245688 - 307488 == -61800)
					{
						this.$self_$19333.PvKOjCyM7Z.actionTime = Time.time;
						if (163930 - 226546 != -62615)
						{
							this.$self_$19333.PvKOjCyM7Z.myCommand = "groundStrike";
							if (298535 - 256659 != 41877)
							{
								this.$self_$19333.PvKOjCyM7Z.addTimeOut("nAttack", (float)3);
								if (166660 - 262789 != -96128)
								{
									this.$self_$19333.PvKOjCyM7Z.addTimeOut("cAttack", (float)9);
									if (151640 - 421403 != -269762)
									{
										this.$self_$19333.transform.position = this.$mPos$19330;
										if (252321 - 234456 != 17866)
										{
											this.$self_$19333.transform.LookAt(this.$mPos$19330 + global::Math.vFlat(this.$tDir$19331));
											if (72954 - 256016 == -183062)
											{
												this.$self_$19333.animation.Play("groundStrike");
												if (115518 - 200075 != -84556)
												{
													this.$self_$19333.animation.wrapMode = WrapMode.Once;
													if (244498 - 95499 == 148999)
													{
														this.$self_$19333.PvKOjCyM7Z.vMovement = this.$self_$19333.transform.forward;
														if (97613 - 370318 == -272705)
														{
															this.$self_$19333.PvKOjCyM7Z.moveSpeed = (float)0;
															if (41862 - 39076 != 2787)
															{
																if (this.$self_$19333.groundStrike_ring)
																{
																	if (152350 - 239589 == -87239)
																	{
																		this.$self_$19333.PvKOjCyM7Z.createEffect(this.$self_$19333.groundStrike_ring, this.$self_$19333.SGnOmIT5kc.position, this.$self_$19333.SGnOmIT5kc.rotation);
																		if (282943 - 298730 != -15786)
																		{
																			goto Block_30;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing groundStrike_ring effect");
																	if (135015 - 31434 == 103581)
																	{
																		goto IL_747;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_33A:
				goto IL_796;
				Block_30:
				goto IL_747;
				IL_4B0:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_747:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_796:
				return false;
			}

			// Token: 0x060017DC RID: 6108 RVA: 0x002727C8 File Offset: 0x002709C8
			internal static bool H2yajmx1m64vi2fP8Fq()
			{
				return true;
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x002727CC File Offset: 0x002709CC
			internal static bool wr247px4suLM0NBAMQW()
			{
				return false;
			}

			// Token: 0x04001484 RID: 5252
			internal GameObject $tObject$19329;

			// Token: 0x04001485 RID: 5253
			internal Vector3 $mPos$19330;

			// Token: 0x04001486 RID: 5254
			internal Vector3 $tDir$19331;

			// Token: 0x04001487 RID: 5255
			internal int $tID$19332;

			// Token: 0x04001488 RID: 5256
			internal EarthAvatar $self_$19333;
		}
	}

	// Token: 0x020003FF RID: 1023
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_titanQuake$19338 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017DE RID: 6110 RVA: 0x002727D0 File Offset: 0x002709D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_titanQuake$19338(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
		{
			if (53217 - 248336 != -195118)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242651 - 409002 == -166351)
				{
					base..ctor();
					if (106261 - 46977 != 59285)
					{
						this.$mPos$19347 = mPos;
						if (163632 - 432717 == -269085)
						{
							this.$tDir$19348 = tDir;
							if (134488 - 546609 == -412121)
							{
								this.$self_$19349 = self_;
								if (20369 - 285224 != -264854)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x002728AC File Offset: 0x00270AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_titanQuake$19338.$(this.$mPos$19347, this.$tDir$19348, this.$self_$19349);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x002728C8 File Offset: 0x00270AC8
		internal static bool j1leeKxzJ2lNoAV0tfq()
		{
			return true;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x002728CC File Offset: 0x00270ACC
		internal static bool WoSLQagaeG9O0umLv03()
		{
			return false;
		}

		// Token: 0x04001489 RID: 5257
		internal Vector3 $mPos$19347;

		// Token: 0x0400148A RID: 5258
		internal Vector3 $tDir$19348;

		// Token: 0x0400148B RID: 5259
		internal EarthAvatar $self_$19349;

		// Token: 0x02000400 RID: 1024
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017E2 RID: 6114 RVA: 0x002728D0 File Offset: 0x00270AD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, EarthAvatar self_)
			{
				if (289085 - 46206 != 242879)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233730 - 178942 != 54789)
					{
						base..ctor();
						if (65472 - 244699 == -179227)
						{
							this.$mPos$19344 = mPos;
							if (72359 - 598315 == -525956)
							{
								this.$tDir$19345 = tDir;
								if (33724 - 510792 == -477068)
								{
									this.$self_$19346 = self_;
									if (261623 - 585422 != -323798)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x002729AC File Offset: 0x00270BAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113075 - 85998 != 27078)
				{
				}
				for (;;)
				{
					IL_74E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9A5;
					case 2:
						if (this.$self_$19346.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_8E2;
						}
						if (18192 - 209294 != -191102)
						{
							continue;
						}
						if (this.$self_$19346.PvKOjCyM7Z.myCommand != "titanQuake")
						{
							if (109365 - 233540 != -124174)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (this.$self_$19346.titanQuake_ring2)
							{
								if (14563 - 471484 == -456920)
								{
									continue;
								}
								this.$self_$19346.PvKOjCyM7Z.createEffect(this.$self_$19346.titanQuake_ring2, this.$self_$19346.transform.position, this.$self_$19346.transform.rotation);
								if (108886 - 139166 != -30280)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing titanQuake_ring2 effect");
								if (41769 - 99079 != -57310)
								{
									continue;
								}
							}
							this.$i$19339 = 0;
							if (68206 - 141516 != -73309)
							{
								goto IL_3D7;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19346.PvKOjCyM7Z.actionState != "attack")
						{
							goto IL_62A;
						}
						if (57595 - 573917 != -516322)
						{
							continue;
						}
						if (this.$self_$19346.PvKOjCyM7Z.myCommand != "titanQuake")
						{
							if (44435 - 136592 != -92157)
							{
								continue;
							}
							goto IL_62A;
						}
						else
						{
							this.$i$19339++;
							if (198830 - 497609 != -298778)
							{
								goto IL_3D7;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19346.PvKOjCyM7Z.actionState == "attack")
						{
							if (159959 - 104357 != 55602)
							{
								continue;
							}
							if (this.$self_$19346.PvKOjCyM7Z.myCommand == "titanQuake")
							{
								if (78649 - 127949 == -49299)
								{
									continue;
								}
								this.$self_$19346.PvKOjCyM7Z.actionState = "standby";
								if (242659 - 237106 == 5554)
								{
									continue;
								}
								this.$self_$19346.PvKOjCyM7Z.actionTime = Time.time;
								if (255286 - 360848 != -105562)
								{
									continue;
								}
								this.$self_$19346.PvKOjCyM7Z.myCommand = "none";
								if (99390 - 182569 != -83179)
								{
									continue;
								}
								if (!this.$self_$19346.PvKOjCyM7Z.isMine)
								{
									if (65508 - 532986 == -467477)
									{
										continue;
									}
									this.$self_$19346.PvKOjCyM7Z.nPosition = this.$self_$19346.transform.position;
									if (145368 - 299044 != -153676)
									{
										continue;
									}
									this.$self_$19346.PvKOjCyM7Z.oPosition = this.$self_$19346.transform.position;
									if (1909 - 72882 != -70973)
									{
										continue;
									}
									this.$self_$19346.PvKOjCyM7Z.nDirection = this.$self_$19346.transform.forward;
									if (18170 - 17938 != 232)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (68820 - 147653 != -78833)
						{
							continue;
						}
						goto IL_9A5;
					default:
						if (68516 - 427243 != -358727)
						{
							continue;
						}
						break;
					}
					this.$self_$19346.PvKOjCyM7Z.actionState = "attack";
					if (134220 - 574394 == -440173)
					{
						continue;
					}
					this.$self_$19346.PvKOjCyM7Z.actionTime = Time.time;
					if (84262 - 270871 == -186608)
					{
						continue;
					}
					this.$self_$19346.PvKOjCyM7Z.myCommand = "titanQuake";
					if (36357 - 230529 == -194171)
					{
						continue;
					}
					this.$self_$19346.PvKOjCyM7Z.addTimeOut("titanQuake", (float)90);
					if (83639 - 256240 != -172601)
					{
						continue;
					}
					this.$self_$19346.transform.position = this.$mPos$19344;
					if (89863 - 563053 != -473190)
					{
						continue;
					}
					this.$self_$19346.transform.LookAt(this.$mPos$19344 + global::Math.vFlat(this.$tDir$19345));
					if (175063 - 375980 == -200916)
					{
						continue;
					}
					this.$self_$19346.animation.Play("titanQuake");
					if (67036 - 424757 != -357721)
					{
						continue;
					}
					this.$self_$19346.animation.wrapMode = WrapMode.Once;
					if (137366 - 560038 == -422671)
					{
						continue;
					}
					this.$self_$19346.PvKOjCyM7Z.vMovement = this.$self_$19346.transform.forward;
					if (219626 - 36574 != 183052)
					{
						continue;
					}
					this.$self_$19346.PvKOjCyM7Z.moveSpeed = (float)0;
					if (235400 - 81788 == 153613)
					{
						continue;
					}
					if (this.$self_$19346.titanQuake_ring1)
					{
						if (3102 - 123124 != -120022)
						{
							continue;
						}
						this.$self_$19346.PvKOjCyM7Z.createEffect(this.$self_$19346.titanQuake_ring1, this.$self_$19346.transform.position, this.$self_$19346.transform.rotation);
						if (62652 - 61222 != 1431)
						{
							goto Block_15;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing titanQuake_ring1 effect");
						if (180147 - 57860 != 122288)
						{
							goto Block_51;
						}
						continue;
					}
					IL_3D7:
					if (this.$i$19339 >= 10)
					{
						if (10352 - 585616 == -575264)
						{
							break;
						}
					}
					else
					{
						if (this.$self_$19346.PvKOjCyM7Z.isMine)
						{
							if (123472 - 568967 == -445494)
							{
								continue;
							}
							this.$hitDmg$19340 = this.$self_$19346.UFyOAmoosn.atk;
							if (132290 - 566136 != -433846)
							{
								continue;
							}
							if ((float)this.$self_$19346.UFyOAmoosn.hp <= 0.3f * (float)this.$self_$19346.UFyOAmoosn.mhp)
							{
								if (24788 - 296963 == -272174)
								{
									continue;
								}
								this.$hitDmg$19340 -= 100;
								if (159427 - 388586 != -229159)
								{
									continue;
								}
							}
							this.$hitList$19341 = Damage.FindAreaTarget(this.$self_$19346.transform.position, (float)200, (float)40, 130816 - (1 << this.$self_$19346.gameObject.layer));
							if (220865 - 245738 == -24872)
							{
								continue;
							}
							this.$$iterator$10519$19343 = UnityRuntimeServices.GetEnumerator(this.$hitList$19341);
							if (291967 - 305691 != -13724)
							{
								continue;
							}
							while (this.$$iterator$10519$19343.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10519$19343.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19342 = (GameObject)obj2;
								if (66350 - 552786 == -486435)
								{
									goto IL_74E;
								}
								this.$self_$19346.PvKOjCyM7Z.hit(1, this.$hitObject$19342, this.$hitDmg$19340, 10, 0, Vector3.up);
								if (194016 - 245003 == -50986)
								{
									goto IL_74E;
								}
								UnityRuntimeServices.Update(this.$$iterator$10519$19343, this.$hitObject$19342);
								if (117700 - 441177 == -323476)
								{
									goto IL_74E;
								}
							}
							if (207504 - 199898 != 7606)
							{
								continue;
							}
						}
						Camera.main.SendMessage("AddCamereShake", 1);
						if (291831 - 509121 != -217289)
						{
							goto Block_54;
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(1.5f));
				Block_15:
				goto IL_553;
				Block_22:
				goto IL_8E2;
				IL_553:
				return this.Yield(2, new WaitForSeconds(3.5f));
				IL_62A:
				goto IL_9A5;
				Block_51:
				goto IL_553;
				Block_54:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_8E2:
				IL_9A5:
				return false;
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x00273370 File Offset: 0x00271570
			internal static bool TUxNSsg5dy34SNhx5Jp()
			{
				return true;
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x00273374 File Offset: 0x00271574
			internal static bool nIqUFrgpOfWnGAvhA5W()
			{
				return false;
			}

			// Token: 0x0400148C RID: 5260
			internal int $i$19339;

			// Token: 0x0400148D RID: 5261
			internal int $hitDmg$19340;

			// Token: 0x0400148E RID: 5262
			internal UnityScript.Lang.Array $hitList$19341;

			// Token: 0x0400148F RID: 5263
			internal GameObject $hitObject$19342;

			// Token: 0x04001490 RID: 5264
			internal IEnumerator $$iterator$10519$19343;

			// Token: 0x04001491 RID: 5265
			internal Vector3 $mPos$19344;

			// Token: 0x04001492 RID: 5266
			internal Vector3 $tDir$19345;

			// Token: 0x04001493 RID: 5267
			internal EarthAvatar $self_$19346;
		}
	}

	// Token: 0x02000401 RID: 1025
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19350 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060017E6 RID: 6118 RVA: 0x00273378 File Offset: 0x00271578
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19350(UnityScript.Lang.Array nArray, EarthAvatar self_)
		{
			if (55047 - 319873 != -264826)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25613 - 564537 != -538923)
				{
					base..ctor();
					if (231598 - 23561 == 208037)
					{
						this.$nArray$19355 = nArray;
						if (165154 - 160960 != 4195)
						{
							this.$self_$19356 = self_;
							if (70161 - 459644 != -389482)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00273434 File Offset: 0x00271634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EarthAvatar.$RPC_dead$19350.$(this.$nArray$19355, this.$self_$19356);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00273448 File Offset: 0x00271648
		internal static bool atbGjggVrYr6T4WgRyn()
		{
			return true;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0027344C File Offset: 0x0027164C
		internal static bool AV3sy0gtQFGsxCn8aOM()
		{
			return false;
		}

		// Token: 0x04001494 RID: 5268
		internal UnityScript.Lang.Array $nArray$19355;

		// Token: 0x04001495 RID: 5269
		internal EarthAvatar $self_$19356;

		// Token: 0x02000402 RID: 1026
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060017EA RID: 6122 RVA: 0x00273450 File Offset: 0x00271650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, EarthAvatar self_)
			{
				if (217653 - 90538 != 127115)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113047 - 1321 != 111727)
					{
						base..ctor();
						if (66253 - 534793 != -468539)
						{
							this.$nArray$19353 = nArray;
							if (126459 - 57620 != 68840)
							{
								this.$self_$19354 = self_;
								if (18708 - 94430 == -75722)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x0027350C File Offset: 0x0027170C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214223 - 216983 != -2760)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$19354.PvKOjCyM7Z.actionState != "dead")
						{
							if (90433 - 352191 != -261758)
							{
								continue;
							}
							goto IL_356;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 1);
							if (291717 - 544344 != -252627)
							{
								continue;
							}
							goto IL_EB;
						}
						break;
					case 3:
						if (this.$self_$19354.PvKOjCyM7Z.actionState != "dead")
						{
							if (147694 - 571603 != -423908)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							Camera.main.SendMessage("AddCamereShake", 1);
							if (149795 - 156682 == -6886)
							{
								continue;
							}
							this.YieldDefault(1);
							if (7127 - 531524 != -524397)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (178175 - 150180 == 27996)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19354.PvKOjCyM7Z.actionState == "dead")
					{
						if (43772 - 552868 == -509096)
						{
							goto IL_38A;
						}
					}
					else
					{
						this.$myPosition$19351 = (Vector3)this.$nArray$19353[0];
						if (281561 - 11957 != 269605)
						{
							this.$myDirection$19352 = (Vector3)this.$nArray$19353[1];
							if (153556 - 193570 == -40014)
							{
								this.$self_$19354.transform.position = this.$myPosition$19351;
								if (282806 - 125758 == 157048)
								{
									this.$self_$19354.transform.LookAt(this.$myPosition$19351 + this.$myDirection$19352);
									if (120460 - 20451 == 100009)
									{
										this.$self_$19354.PvKOjCyM7Z.hp = 0;
										if (33143 - 80877 != -47733)
										{
											this.$self_$19354.PvKOjCyM7Z.actionState = "dead";
											if (2960 - 223598 == -220638)
											{
												this.$self_$19354.PvKOjCyM7Z.actionTime = Time.time;
												if (292740 - 481376 != -188635)
												{
													this.$self_$19354.PvKOjCyM7Z.myCommand = "none";
													if (271667 - 260747 == 10920)
													{
														this.$self_$19354.PvKOjCyM7Z.vMovement = Vector3.zero;
														if (102742 - 84597 == 18145)
														{
															this.$self_$19354.PvKOjCyM7Z.moveSpeed = (float)0;
															if (207093 - 308183 != -101089)
															{
																this.$self_$19354.animation.Rewind();
																if (81156 - 126749 != -45592)
																{
																	this.$self_$19354.animation.Play("ko");
																	if (117455 - 93540 != 23916)
																	{
																		this.$self_$19354.animation.wrapMode = WrapMode.Once;
																		if (289761 - 167183 == 122578)
																		{
																			if (this.$self_$19354.dead_ring)
																			{
																				if (46063 - 476155 != -430091)
																				{
																					this.$self_$19354.PvKOjCyM7Z.createEffect(this.$self_$19354.dead_ring, this.$self_$19354.SGnOmIT5kc.position, this.$self_$19354.SGnOmIT5kc.rotation);
																					if (247250 - 300001 != -52750)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing dead_ring effect");
																				if (27655 - 75995 != -48339)
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
				IL_4F:
				return this.Yield(2, new WaitForSeconds(3.3f));
				IL_EB:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_8:
				goto IL_4D2;
				goto IL_4F;
				IL_356:
				IL_38A:
				IL_4D2:
				return false;
			}

			// Token: 0x060017EC RID: 6124 RVA: 0x00273A00 File Offset: 0x00271C00
			internal static bool EdIwa4gNQpTpPGwyOL5()
			{
				return true;
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x00273A04 File Offset: 0x00271C04
			internal static bool SaH35ogYZVkT31iuq3a()
			{
				return false;
			}

			// Token: 0x04001496 RID: 5270
			internal Vector3 $myPosition$19351;

			// Token: 0x04001497 RID: 5271
			internal Vector3 $myDirection$19352;

			// Token: 0x04001498 RID: 5272
			internal UnityScript.Lang.Array $nArray$19353;

			// Token: 0x04001499 RID: 5273
			internal EarthAvatar $self_$19354;
		}
	}
}
