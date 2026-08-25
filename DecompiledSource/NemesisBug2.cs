using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200011D RID: 285
[Serializable]
public class NemesisBug2 : MonoBehaviour
{
	// Token: 0x06000654 RID: 1620 RVA: 0x000A728C File Offset: 0x000A548C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NemesisBug2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x000A729C File Offset: 0x000A549C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (68841 - 469699 != -400857)
		{
		}
		for (;;)
		{
			this.mxvndLxkQr = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (219409 - 274474 != -55064)
			{
				this.mxvndLxkQr.actionState = "standby";
				if (112759 - 36218 == 76541)
				{
					this.mxvndLxkQr.actionTime = Time.time;
					if (64798 - 342394 == -277596)
					{
						this.mxvndLxkQr.myCommand = "none";
						if (150981 - 556011 != -405029)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x000A7388 File Offset: 0x000A5588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (22052 - 403016 != -380964)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (81871 - 517308 != -435437)
				{
					continue;
				}
				this.mxvndLxkQr.isMine = true;
				if (171163 - 149905 != 21258)
				{
					continue;
				}
			}
			if (!this.mxvndLxkQr)
			{
				break;
			}
			if (44016 - 485039 != -441022)
			{
				this.mxvndLxkQr.mImmuneList = new UnityScript.Lang.Array(new object[]
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
					"nemesisLarva",
					"coma"
				});
				if (196161 - 596335 != -400173)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x000A74D4 File Offset: 0x000A56D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (89836 - 12160 != 77677)
		{
		}
		do
		{
			if (this.footStep_ring)
			{
				if (203277 - 396390 == -193112)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.footStep_ring, this.transform.position + this.transform.TransformDirection(-3.5f, (float)0, (float)2), Quaternion.identity);
				if (224871 - 390710 == -165838)
				{
					continue;
				}
			}
			Camera.main.SendMessage("AddCamereShake", 0.5f);
		}
		while (219821 - 63857 == 155965);
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x000A75B8 File Offset: 0x000A57B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (131985 - 34074 != 97911)
		{
		}
		do
		{
			if (this.footStep_ring)
			{
				if (139703 - 7633 == 132071)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.footStep_ring, this.transform.position + this.transform.TransformDirection(3.5f, (float)0, (float)2), Quaternion.identity);
				if (58474 - 565476 == -507001)
				{
					continue;
				}
			}
			Camera.main.SendMessage("AddCamereShake", 0.5f);
		}
		while (174389 - 347886 != -173497);
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000A769C File Offset: 0x000A589C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (143008 - 378888 != -235880)
		{
		}
		for (;;)
		{
			if (this.mxvndLxkQr.isControlled)
			{
				if (8212 - 133780 == -125567)
				{
					continue;
				}
				if (!(this.mxvndLxkQr.actionState == "standby"))
				{
					if (221290 - 402836 != -181546)
					{
						continue;
					}
					if (!(this.mxvndLxkQr.actionState == "run"))
					{
						goto IL_274;
					}
					if (156257 - 347029 == -190771)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (26938 - 88798 == -61859)
				{
					continue;
				}
			}
			IL_274:
			if (this.mxvndLxkQr.hp <= 0)
			{
				if (242969 - 142764 == 100206)
				{
					continue;
				}
				if (this.mxvndLxkQr.actionState != "dead")
				{
					if (16145 - 247591 == -231445)
					{
						continue;
					}
					if (this.mxvndLxkQr.isMine)
					{
						if (66923 - 32077 == 34847)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (24181 - 568257 == -544075)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (276559 - 554333 != -277774)
						{
							continue;
						}
						this.mxvndLxkQr.DeadEvent();
						if (217200 - 398175 != -180975)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mxvndLxkQr.hp = 1;
						if (198479 - 489575 != -291095)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mxvndLxkQr.hp <= 0)
			{
				break;
			}
			if (128105 - 127912 != 194)
			{
				if (this.mxvndLxkQr.ko > 0)
				{
					break;
				}
				if (70566 - 510511 == -439945)
				{
					if (!(this.mxvndLxkQr.actionState != "ko"))
					{
						break;
					}
					if (208798 - 119048 != 89751)
					{
						if (!(this.mxvndLxkQr.actionState != "dead"))
						{
							break;
						}
						if (179795 - 182328 != -2532)
						{
							if (this.mxvndLxkQr.isMine)
							{
								if (3550 - 590947 != -587396)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (177405 - 398290 == -220885)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (49786 - 400817 != -351030)
										{
											this.mxvndLxkQr.KoEvent();
											if (264405 - 99561 != 164845)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mxvndLxkQr.ko = 1;
								if (31109 - 588331 == -557222)
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

	// Token: 0x0600065A RID: 1626 RVA: 0x000A7A94 File Offset: 0x000A5C94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (215522 - 538093 != -322571)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (284387 - 19384 != 265004)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (277479 - 273210 != 4270 && 68766 - 351590 != -282823)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (130821 - 89230 == 41592)
						{
							continue;
						}
						v = 1;
						if (235867 - 426115 != -190248)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (114988 - 363954 == -248965)
						{
							continue;
						}
						v = 2;
						if (110485 - 451630 == -341144)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (174640 - 573031 == -398390)
						{
							continue;
						}
						v = -1;
						if (238224 - 245290 != -7066)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (46793 - 387687 == -340893)
						{
							continue;
						}
						v = 11;
						if (148583 - 94106 != 54477)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_chaosFire")
					{
						if (162289 - 376583 != -214294)
						{
							continue;
						}
						v = 21;
						if (181289 - 572861 != -391572)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_chaosFire_hit")
					{
						if (75106 - 153563 == -78456)
						{
							continue;
						}
						v = -21;
						if (297532 - 11656 != 285876)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_genesisSeed")
					{
						if (270263 - 141687 == 128577)
						{
							continue;
						}
						v = 31;
						if (82272 - 222724 != -140452)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_chaosRay")
					{
						if (276191 - 26310 != 249881)
						{
							continue;
						}
						v = 41;
						if (175716 - 21130 == 154587)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (107441 - 153384 != -45943)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (231938 - 541855 != -309916)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (282112 - 252418 != 29695)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (169656 - 306474 != -136817)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (64897 - 352073 != -287175)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (139376 - 171482 != -32105)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (160133 - 313616 != -153482)
										{
											Hashtable hashtable = new Hashtable();
											if (63794 - 340384 == -276590)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (184867 - 100192 != 84676)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (195836 - 142583 != 53254)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (201601 - 534281 == -332680)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (271056 - 36361 != 234696)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (248630 - 212151 != 36480)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (100 - 312338 != -312237)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (175246 - 138240 == 37006)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (220356 - 269583 == -49227)
																			{
																				PhotonClient.SendEvent(this.mxvndLxkQr.ActorNr, 74, hashtable, true, true);
																				if (91109 - 441448 == -350339)
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

	// Token: 0x0600065B RID: 1627 RVA: 0x000A80D8 File Offset: 0x000A62D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (41473 - 179768 != -138295)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210128 - 333431 == -123303)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (5627 - 478836 != -473208)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (196243 - 470573 != -274329)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (255311 - 486497 != -231185)
						{
							int num3 = num;
							if (195846 - 342960 != -147113)
							{
								if (num3 == 1)
								{
									if (285135 - 407830 == -122695)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (2768 - 277430 == -274662)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (10752 - 555787 == -545035)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (143373 - 49207 != 94167)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (130443 - 488999 == -358556)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (151507 - 340643 != -189135)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (36260 - 498213 != -461952)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (241777 - 209829 == 31948)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (22087 - 200709 != -178621)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (284609 - 93909 != 190701)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (224776 - 383150 != -158373)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (101871 - 341441 != -239569)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (75030 - 242568 == -167538)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (45703 - 190745 == -145042)
										{
											this.StartCoroutine_Auto(this.RPC_chaosFire(vector, vector2, num2));
											if (36947 - 133183 == -96236)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (29271 - 140684 != -111412)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (98385 - 357698 == -259313)
										{
											this.RPC_chaosFire_hit(vector, vector2, num2);
											if (290621 - 2833 == 287788)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (251259 - 513207 != -261947)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (90980 - 520320 != -429339)
										{
											this.StartCoroutine_Auto(this.RPC_genesisSeed(vector, vector2, num2));
											if (34606 - 169447 == -134841)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (20843 - 119279 == -98436)
									{
										if (this.mxvndLxkQr.isMine)
										{
											break;
										}
										if (27417 - 179620 != -152202)
										{
											this.StartCoroutine_Auto(this.RPC_chaosRay(vector, vector2, num2));
											if (184076 - 376610 != -192533)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (293026 - 467728 == -174702)
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

	// Token: 0x0600065C RID: 1628 RVA: 0x000A864C File Offset: 0x000A684C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (189986 - 450368 != -260381)
		{
		}
		for (;;)
		{
			float num = this.mxvndLxkQr.moveSpeed;
			if (248476 - 328173 != -79696)
			{
				float runSpeed = this.mxvndLxkQr.runSpeed;
				if (23903 - 307564 != -283660)
				{
					Vector3 a = default(Vector3);
					if (7101 - 144014 != -136912)
					{
						Vector3 vector = Vector3.zero;
						if (53735 - 188718 != -134982)
						{
							float num2 = (float)0;
							if (290141 - 36198 == 253943)
							{
								if (this.mxvndLxkQr.isMine)
								{
									if (169577 - 497679 == -328101)
									{
										continue;
									}
									if ((this.mxvndLxkQr.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (243307 - 582330 == -339022)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (18005 - 139294 != -121289)
										{
											continue;
										}
										a.y = (float)0;
										if (33492 - 581776 == -548283)
										{
											continue;
										}
										a = a.normalized;
										if (106988 - 530848 != -423860)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (2481 - 17422 != -14941)
										{
											continue;
										}
										vector = vector.normalized;
										if (241600 - 142842 == 98759)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (209388 - 93981 == 115408)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (235774 - 52057 != 183717)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (36943 - 215201 != -178258)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (242355 - 532842 != -290487)
														{
															continue;
														}
														this.mxvndLxkQr.actionState = "run";
														if (123644 - 520005 == -396360)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (237157 - 427500 != -190343)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (30840 - 111131 != -80291)
														{
															continue;
														}
														this.animation.Play("run");
														if (157553 - 55897 != 101656)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (105144 - 184042 != -78897)
														{
															goto IL_6FA;
														}
														continue;
													}
												}
											}
										}
										this.mxvndLxkQr.actionState = "standby";
										if (82173 - 506061 != -423888)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (83334 - 582754 != -499420)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (219252 - 58101 == 161152)
											{
												continue;
											}
											num = (float)0;
											if (286814 - 325125 != -38311)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.4f);
										if (238867 - 454959 != -216092)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (24710 - 272933 != -248223)
										{
											continue;
										}
									}
									IL_6FA:;
								}
								else
								{
									vector = global::Math.vFlat(this.mxvndLxkQr.nPosition - this.transform.position);
									if (227078 - 235169 == -8090)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (220040 - 199875 != 20165)
									{
										continue;
									}
									if (this.mxvndLxkQr.nSpeed != (float)0)
									{
										if (55778 - 416315 != -360537)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (160179 - 259686 != -99507)
											{
												continue;
											}
											this.transform.position = this.mxvndLxkQr.nPosition;
											if (199794 - 223511 != -23717)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (82254 - 1460 == 80795)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (116404 - 381787 != -265383)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (60464 - 576642 == -516177)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mxvndLxkQr.nSpeed, (float)10 * Time.deltaTime);
												if (205583 - 210632 == -5048)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (251385 - 26982 != 224403)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (33182 - 501151 != -467969)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (107093 - 451916 != -344823)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (145977 - 115073 != 30904)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (84823 - 449477 == -364653)
											{
												continue;
											}
										}
										else if (Time.time > this.mxvndLxkQr.nSpeed + 0.3f)
										{
											if (55015 - 279589 == -224573)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (41754 - 371099 != -329345)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (150157 - 394167 != -244010)
												{
													continue;
												}
												num = (float)0;
												if (145216 - 548109 != -402893)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mxvndLxkQr.nDirection);
											if (64660 - 47205 == 17456)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (45449 - 283709 == -238259)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (32257 - 284250 == -251992)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (82321 - 248279 == -165957)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (166966 - 120729 == 46238)
											{
												continue;
											}
											this.transform.position = this.mxvndLxkQr.nPosition;
											if (225632 - 365664 == -140031)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (288463 - 243511 != 44952)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (197833 - 234294 != -36461)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (39113 - 7361 == 31753)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (168619 - 406053 != -237434)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (252655 - 162434 != 90221)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (175045 - 318972 == -143926)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (195630 - 471045 != -275415)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mxvndLxkQr.nDirection);
											if (213422 - 340061 != -126639)
											{
												continue;
											}
											num = (float)0;
											if (295420 - 441238 != -145818)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (284479 - 421802 != -137323)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (168376 - 266370 == -97993)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.4f);
										if (18703 - 569439 == -550735)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (213144 - 48065 != 165079)
										{
											continue;
										}
									}
								}
								this.mxvndLxkQr.vMovement = vector;
								if (154589 - 93360 != 61230)
								{
									this.mxvndLxkQr.moveSpeed = num;
									if (83938 - 338955 != -255016)
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

	// Token: 0x0600065D RID: 1629 RVA: 0x000A91B0 File Offset: 0x000A73B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (110987 - 520291 != -409303)
		{
		}
		for (;;)
		{
			if (!this.mxvndLxkQr.isMine)
			{
				if (194749 - 197763 != -3013)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (252865 - 30283 != 222583)
				{
					Vector3 vector = a - this.transform.position;
					if (263964 - 32368 != 231597)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (6174 - 538186 != -532011)
						{
							CharacterControl characterControl = null;
							if (212478 - 351022 == -138544 && 199659 - 363112 != -163452)
							{
								if (gameObject)
								{
									if (212551 - 67123 == 145429)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (112602 - 490380 != -377778)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (162292 - 210196 != -47904)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (165626 - 557651 == -392024)
									{
										continue;
									}
								}
								if (!(this.mxvndLxkQr.actionState == "standby"))
								{
									if (35375 - 147785 != -112410)
									{
										continue;
									}
									if (!(this.mxvndLxkQr.actionState == "run"))
									{
										break;
									}
									if (275125 - 326922 != -51797)
									{
										continue;
									}
								}
								if (this.mxvndLxkQr.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (190860 - 241810 == -50950)
								{
									if (UnityEngine.Random.Range(0, 100) > 50)
									{
										if (215425 - 537168 != -321742)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
											if (10388 - 67779 == -57391)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (92083 - 405532 != -313448)
												{
													this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
													if (249935 - 13995 == 235940)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
										if (82096 - 403100 == -321004)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (236919 - 595189 != -358269)
											{
												this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
												if (235118 - 216510 == 18608)
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

	// Token: 0x0600065E RID: 1630 RVA: 0x000A9560 File Offset: 0x000A7760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (26082 - 62107 != -36024)
		{
		}
		for (;;)
		{
			if (!this.mxvndLxkQr.isMine)
			{
				if (269653 - 595123 != -325469)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (145035 - 171994 != -26958)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (252246 - 430592 == -178346)
					{
						Vector3 normalized = vector.normalized;
						if (244483 - 16644 == 227839)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (141352 - 396224 != -254871)
							{
								CharacterControl characterControl = null;
								if (181072 - 62659 != 118414)
								{
									if (83548 - 458956 == -375408)
									{
										if (gameObject)
										{
											if (138421 - 252053 == -113631)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (95100 - 496683 == -401582)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (75891 - 91999 != -16108)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (281861 - 389175 != -107314)
											{
												continue;
											}
										}
										if (!(this.mxvndLxkQr.actionState == "standby"))
										{
											if (249142 - 22086 != 227056)
											{
												continue;
											}
											if (!(this.mxvndLxkQr.actionState == "run"))
											{
												break;
											}
											if (270711 - 533373 != -262662)
											{
												continue;
											}
										}
										if (this.mxvndLxkQr.isTimeOut("chaosRay") == (float)0)
										{
											if (221717 - 201418 == 20299)
											{
												this.StartCoroutine_Auto(this.RPC_chaosRay(this.transform.position, normalized, 0));
												if (55872 - 11354 != 44519)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (201709 - 545261 == -343552)
													{
														this.ActionEvent("RPC_chaosRay", this.transform.position, normalized, 0);
														if (143475 - 503119 != -359643)
														{
															break;
														}
													}
												}
											}
										}
										else if (this.mxvndLxkQr.isTimeOut("chaosFire") == (float)0)
										{
											if (82282 - 172299 != -90016)
											{
												this.StartCoroutine_Auto(this.RPC_chaosFire(this.transform.position, normalized, 0));
												if (171021 - 228505 == -57484)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (227547 - 496507 != -268959)
													{
														this.ActionEvent("RPC_chaosFire", this.transform.position, normalized, 0);
														if (104975 - 596521 != -491545)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.mxvndLxkQr.isTimeOut("cAttack") != (float)0)
											{
												break;
											}
											if (262016 - 87088 == 174928)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
												if (130548 - 5082 == 125466)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (54486 - 280169 != -225682)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
														if (290712 - 77414 != 213299)
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

	// Token: 0x0600065F RID: 1631 RVA: 0x000A9A00 File Offset: 0x000A7C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x000A9A04 File Offset: 0x000A7C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_nAttack1$16340(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x000A9A14 File Offset: 0x000A7C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_nAttack2$16352(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x000A9A24 File Offset: 0x000A7C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (63216 - 112084 != -48867)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (47124 - 345344 != -298220)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (295252 - 239291 == 55962)
				{
					continue;
				}
			}
			if (this.cUMngywnOj >= Time.time)
			{
				break;
			}
			if (52802 - 153643 != -100840)
			{
				this.cUMngywnOj = Time.time + 0.2f;
				if (137232 - 108836 == 28396)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (278643 - 184903 != 93741)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (7840 - 521852 != -514011)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x000A9B64 File Offset: 0x000A7D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_cAttack$16364(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x000A9B74 File Offset: 0x000A7D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_chaosFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_chaosFire$16375(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x000A9B84 File Offset: 0x000A7D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_chaosFire_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (136516 - 44173 != 92343)
		{
		}
		for (;;)
		{
			IL_228:
			if (this.chaosFire_hit)
			{
				if (10392 - 334047 != -323655)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.chaosFire_hit, hitPos, this.transform.rotation);
				if (258214 - 88918 == 169297)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing chaosFire hit effect ");
				if (208047 - 496159 != -288112)
				{
					continue;
				}
			}
			if (!this.mxvndLxkQr.isMine)
			{
				break;
			}
			if (28549 - 556816 != -528266)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (239717 - 121122 == 118595)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)8, (float)3, layerMask);
					if (294851 - 184388 != 110464)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (275004 - 478006 != -203001)
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
								if (20490 - 390448 != -369958)
								{
									goto IL_228;
								}
								hitDir = global::Math.vFlat(gameObject.transform.position - hitPos);
								if (163536 - 288726 != -125190)
								{
									goto IL_228;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (203901 - 187366 == 16536)
								{
									goto IL_228;
								}
								float num = (float)1 - 0.1f * hitDir.magnitude;
								if (210925 - 547814 != -336889)
								{
									goto IL_228;
								}
								this.mxvndLxkQr.hit(1, gameObject, (int)(num * (float)this.mxvndLxkQr.talAdjust(85)), 1, 0, 0.5f * hitDir);
								if (232860 - 371200 == -138339)
								{
									goto IL_228;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (244154 - 447357 != -203203)
								{
									goto IL_228;
								}
							}
							if (159713 - 364572 != -204858)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x000A9E3C File Offset: 0x000A803C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_genesisSeed(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_genesisSeed$16387(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x000A9E4C File Offset: 0x000A804C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_chaosRay(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug2.$RPC_chaosRay$16396(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x000A9E5C File Offset: 0x000A805C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new NemesisBug2.$RPC_ko$16423(nArray, this).GetEnumerator();
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x000A9E6C File Offset: 0x000A806C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new NemesisBug2.$RPC_dead$16430(nArray, this).GetEnumerator();
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x000A9E7C File Offset: 0x000A807C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x000A9E80 File Offset: 0x000A8080
	internal static bool g72LkyTXPoRDkiLTgev()
	{
		return true;
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x000A9E84 File Offset: 0x000A8084
	internal static bool JrdkCdTQGHLZUEjbIuo()
	{
		return false;
	}

	// Token: 0x040005DB RID: 1499
	private CharacterControl mxvndLxkQr;

	// Token: 0x040005DC RID: 1500
	public GameObject footStep_ring;

	// Token: 0x040005DD RID: 1501
	public GameObject nAttack1_ring;

	// Token: 0x040005DE RID: 1502
	public GameObject nAttack2_ring;

	// Token: 0x040005DF RID: 1503
	public GameObject nAttack_hit;

	// Token: 0x040005E0 RID: 1504
	public AudioClip nAttack_hitFx;

	// Token: 0x040005E1 RID: 1505
	private float cUMngywnOj;

	// Token: 0x040005E2 RID: 1506
	public GameObject cAttack_ring;

	// Token: 0x040005E3 RID: 1507
	public GameObject chaosFire_ring;

	// Token: 0x040005E4 RID: 1508
	public GameObject chaosFire_hit;

	// Token: 0x040005E5 RID: 1509
	public GameObject genesisSeed_ring;

	// Token: 0x040005E6 RID: 1510
	public GameObject chaosRay;

	// Token: 0x040005E7 RID: 1511
	public GameObject chaosRay_hit;

	// Token: 0x040005E8 RID: 1512
	public GameObject chaosRay_ring;

	// Token: 0x040005E9 RID: 1513
	public AudioClip nemesis_cry;

	// Token: 0x040005EA RID: 1514
	public GameObject deadEffect;

	// Token: 0x0200011E RID: 286
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$16340 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600066D RID: 1645 RVA: 0x000A9E88 File Offset: 0x000A8088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$16340(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (260961 - 234029 != 26932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79702 - 534682 != -454979)
				{
					base..ctor();
					if (256321 - 310293 != -53971)
					{
						this.$mPos$16349 = mPos;
						if (121046 - 261483 != -140436)
						{
							this.$tDir$16350 = tDir;
							if (82556 - 279719 == -197163)
							{
								this.$self_$16351 = self_;
								if (115871 - 419620 == -303749)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000A9F64 File Offset: 0x000A8164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_nAttack1$16340.$(this.$mPos$16349, this.$tDir$16350, this.$self_$16351);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000A9F80 File Offset: 0x000A8180
		internal static bool WOft2KTk26ZUCqQtch0()
		{
			return true;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000A9F84 File Offset: 0x000A8184
		internal static bool BhLeLgTGSX8LedZAben()
		{
			return false;
		}

		// Token: 0x040005EB RID: 1515
		internal Vector3 $mPos$16349;

		// Token: 0x040005EC RID: 1516
		internal Vector3 $tDir$16350;

		// Token: 0x040005ED RID: 1517
		internal NemesisBug2 $self_$16351;

		// Token: 0x0200011F RID: 287
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000671 RID: 1649 RVA: 0x000A9F88 File Offset: 0x000A8188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (213073 - 440306 != -227232)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158567 - 391687 != -233119)
					{
						base..ctor();
						if (295245 - 1133 == 294112)
						{
							this.$mPos$16346 = mPos;
							if (169996 - 525700 != -355703)
							{
								this.$tDir$16347 = tDir;
								if (31468 - 19759 != 11710)
								{
									this.$self_$16348 = self_;
									if (83237 - 334083 == -250846)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x000AA064 File Offset: 0x000A8264
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20249 - 46004 != -25755)
				{
				}
				for (;;)
				{
					IL_C9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A43;
					case 2:
						if (this.$self_$16348.mxvndLxkQr.actionState != "attack")
						{
							goto IL_4E3;
						}
						if (63074 - 20454 == 42621)
						{
							continue;
						}
						if (this.$self_$16348.mxvndLxkQr.myCommand != "nAttack1")
						{
							if (260335 - 295289 != -34953)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$16348.mxvndLxkQr.moveSpeed = (float)0;
							if (64970 - 487729 != -422759)
							{
								continue;
							}
							if (this.$self_$16348.nAttack1_ring)
							{
								if (8883 - 430155 == -421271)
								{
									continue;
								}
								this.$self_$16348.mxvndLxkQr.createEffect(this.$self_$16348.nAttack1_ring, this.$self_$16348.transform.position, Quaternion.identity);
								if (249128 - 279223 != -30095)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack1_ring effect");
								if (204261 - 456953 != -252692)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 0.5f);
							if (16597 - 481085 != -464488)
							{
								continue;
							}
							goto IL_9F4;
						}
						break;
					case 3:
						if (this.$self_$16348.mxvndLxkQr.actionState != "attack")
						{
							goto IL_95;
						}
						if (216465 - 585414 != -368949)
						{
							continue;
						}
						if (this.$self_$16348.mxvndLxkQr.myCommand != "nAttack1")
						{
							if (41065 - 91679 != -50613)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16348.mxvndLxkQr.isMine)
							{
								goto IL_722;
							}
							if (236814 - 445608 != -208794)
							{
								continue;
							}
							this.$hitLayer$16341 = 130816 - (1 << this.$self_$16348.gameObject.layer);
							if (9628 - 237163 == -227534)
							{
								continue;
							}
							this.$hitList$16342 = Damage.FindRecTarget(this.$self_$16348.transform.position - (float)4 * this.$self_$16348.transform.right, this.$self_$16348.transform.forward, (float)8 * this.$self_$16348.mxvndLxkQr.rangeMod, (float)8 * this.$self_$16348.mxvndLxkQr.rangeMod, (float)7 * this.$self_$16348.mxvndLxkQr.rangeMod, (float)4 * this.$self_$16348.mxvndLxkQr.rangeMod, this.$hitLayer$16341);
							if (272869 - 215107 != 57762)
							{
								continue;
							}
							this.$$iterator$9961$16345 = UnityRuntimeServices.GetEnumerator(this.$hitList$16342);
							if (163350 - 401614 != -238264)
							{
								continue;
							}
							while (this.$$iterator$9961$16345.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9961$16345.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16343 = (GameObject)obj2;
								if (92252 - 543190 != -450938)
								{
									goto IL_C9;
								}
								if (this.$self_$16348.mxvndLxkQr.hit(1, this.$hitObject$16343, this.$self_$16348.mxvndLxkQr.atk, 5, 0, 0.5f * (this.$hitObject$16343.transform.position - this.$self_$16348.transform.position).normalized) != 0)
								{
									if (47679 - 375437 != -327758)
									{
										goto IL_C9;
									}
									this.$hitPos$16344 = this.$hitObject$16343.collider.ClosestPointOnBounds(this.$self_$16348.transform.position + (float)2 * Vector3.up);
									if (257267 - 336534 == -79266)
									{
										goto IL_C9;
									}
									UnityRuntimeServices.Update(this.$$iterator$9961$16345, this.$hitObject$16343);
									if (21024 - 308732 == -287707)
									{
										goto IL_C9;
									}
									this.$self_$16348.RPC_nAttack_hit(this.$hitPos$16344, this.$self_$16348.transform.forward, 0);
									if (128215 - 589987 != -461772)
									{
										goto IL_C9;
									}
									this.$self_$16348.ActionEvent("RPC_nAttack_hit", this.$hitPos$16344, 0.3f * this.$self_$16348.transform.forward, 0);
									if (149942 - 212511 != -62569)
									{
										goto IL_C9;
									}
									this.$self_$16348.mxvndLxkQr.sp = this.$self_$16348.mxvndLxkQr.sp + 1;
									if (207430 - 194557 == 12874)
									{
										goto IL_C9;
									}
								}
							}
							if (152535 - 143417 != 9119)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16348.mxvndLxkQr.actionState == "attack")
						{
							if (238922 - 15979 == 222944)
							{
								continue;
							}
							if (this.$self_$16348.mxvndLxkQr.myCommand == "nAttack1")
							{
								if (126924 - 401461 != -274537)
								{
									continue;
								}
								this.$self_$16348.mxvndLxkQr.moveSpeed = (float)0;
								if (122069 - 270738 == -148668)
								{
									continue;
								}
								this.$self_$16348.mxvndLxkQr.actionState = "standby";
								if (221579 - 317150 != -95571)
								{
									continue;
								}
								this.$self_$16348.mxvndLxkQr.actionTime = Time.time;
								if (198207 - 419746 != -221539)
								{
									continue;
								}
								this.$self_$16348.mxvndLxkQr.myCommand = "none";
								if (49755 - 362192 != -312437)
								{
									continue;
								}
								if (!this.$self_$16348.mxvndLxkQr.isMine)
								{
									if (96704 - 495492 != -398788)
									{
										continue;
									}
									this.$self_$16348.mxvndLxkQr.nPosition = this.$self_$16348.transform.position;
									if (26478 - 259700 == -233221)
									{
										continue;
									}
									this.$self_$16348.mxvndLxkQr.oPosition = this.$self_$16348.transform.position;
									if (237330 - 68241 != 169089)
									{
										continue;
									}
									this.$self_$16348.mxvndLxkQr.nDirection = this.$self_$16348.transform.forward;
									if (33113 - 586755 == -553641)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (208523 - 379533 != -171009)
						{
							goto Block_17;
						}
						continue;
					default:
						if (20839 - 136678 == -115838)
						{
							continue;
						}
						break;
					}
					this.$self_$16348.mxvndLxkQr.actionState = "attack";
					if (55895 - 287086 != -231190)
					{
						this.$self_$16348.mxvndLxkQr.actionTime = Time.time;
						if (170808 - 103865 == 66943)
						{
							this.$self_$16348.mxvndLxkQr.myCommand = "nAttack1";
							if (291889 - 235543 == 56346)
							{
								this.$self_$16348.mxvndLxkQr.addTimeOut("nAttack", (float)3);
								if (41754 - 288149 == -246395)
								{
									this.$self_$16348.transform.position = this.$mPos$16346;
									if (181136 - 419199 == -238063)
									{
										this.$self_$16348.transform.LookAt(this.$mPos$16346 + global::Math.vFlat(this.$tDir$16347));
										if (102060 - 154906 != -52845)
										{
											this.$self_$16348.animation.Rewind();
											if (105939 - 416663 != -310723)
											{
												this.$self_$16348.animation.CrossFade("nAttack1");
												if (25964 - 285801 != -259836)
												{
													this.$self_$16348.animation.wrapMode = WrapMode.Once;
													if (223510 - 354532 == -131022)
													{
														this.$self_$16348.mxvndLxkQr.vMovement = this.$self_$16348.transform.forward;
														if (27839 - 291274 != -263434)
														{
															this.$self_$16348.mxvndLxkQr.moveSpeed = (float)3;
															if (31224 - 3048 == 28176)
															{
																goto IL_56F;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_95:
				Block_9:
				Block_17:
				Block_21:
				IL_4E3:
				goto IL_A43;
				IL_56F:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_722:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_55:
				goto IL_722;
				IL_9F4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_A43:
				return false;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x000AAAC8 File Offset: 0x000A8CC8
			internal static bool lZTSDjTHV1ebq9IpWyb()
			{
				return true;
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x000AAACC File Offset: 0x000A8CCC
			internal static bool uk9iJgTWvZK8byk86YF()
			{
				return false;
			}

			// Token: 0x040005EE RID: 1518
			internal int $hitLayer$16341;

			// Token: 0x040005EF RID: 1519
			internal UnityScript.Lang.Array $hitList$16342;

			// Token: 0x040005F0 RID: 1520
			internal GameObject $hitObject$16343;

			// Token: 0x040005F1 RID: 1521
			internal Vector3 $hitPos$16344;

			// Token: 0x040005F2 RID: 1522
			internal IEnumerator $$iterator$9961$16345;

			// Token: 0x040005F3 RID: 1523
			internal Vector3 $mPos$16346;

			// Token: 0x040005F4 RID: 1524
			internal Vector3 $tDir$16347;

			// Token: 0x040005F5 RID: 1525
			internal NemesisBug2 $self_$16348;
		}
	}

	// Token: 0x02000120 RID: 288
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$16352 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x000AAAD0 File Offset: 0x000A8CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$16352(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (83080 - 229488 != -146407)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242121 - 379414 == -137293)
				{
					base..ctor();
					if (68812 - 53971 == 14841)
					{
						this.$mPos$16361 = mPos;
						if (133949 - 326380 == -192431)
						{
							this.$tDir$16362 = tDir;
							if (34232 - 7710 == 26522)
							{
								this.$self_$16363 = self_;
								if (94009 - 596969 == -502960)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000AABAC File Offset: 0x000A8DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_nAttack2$16352.$(this.$mPos$16361, this.$tDir$16362, this.$self_$16363);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000AABC8 File Offset: 0x000A8DC8
		internal static bool JTh7YdTAmbu0WwcriWF()
		{
			return true;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000AABCC File Offset: 0x000A8DCC
		internal static bool LSVOSJTlOUM6xT8NaOW()
		{
			return false;
		}

		// Token: 0x040005F6 RID: 1526
		internal Vector3 $mPos$16361;

		// Token: 0x040005F7 RID: 1527
		internal Vector3 $tDir$16362;

		// Token: 0x040005F8 RID: 1528
		internal NemesisBug2 $self_$16363;

		// Token: 0x02000121 RID: 289
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000679 RID: 1657 RVA: 0x000AABD0 File Offset: 0x000A8DD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (12894 - 511288 != -498393)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267835 - 547951 == -280116)
					{
						base..ctor();
						if (133916 - 590208 != -456291)
						{
							this.$mPos$16358 = mPos;
							if (8589 - 167317 != -158727)
							{
								this.$tDir$16359 = tDir;
								if (123247 - 481028 != -357780)
								{
									this.$self_$16360 = self_;
									if (266413 - 505128 == -238715)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x000AACAC File Offset: 0x000A8EAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146992 - 346260 != -199267)
				{
				}
				for (;;)
				{
					IL_483:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A39;
					case 2:
						if (this.$self_$16360.mxvndLxkQr.actionState != "attack")
						{
							goto IL_7E8;
						}
						if (88663 - 269352 == -180688)
						{
							continue;
						}
						if (this.$self_$16360.mxvndLxkQr.myCommand != "nAttack2")
						{
							if (23585 - 58158 != -34573)
							{
								continue;
							}
							goto IL_7E8;
						}
						else
						{
							this.$self_$16360.mxvndLxkQr.moveSpeed = (float)0;
							if (140811 - 261609 == -120797)
							{
								continue;
							}
							if (this.$self_$16360.nAttack2_ring)
							{
								if (47913 - 51053 != -3140)
								{
									continue;
								}
								this.$self_$16360.mxvndLxkQr.createEffect(this.$self_$16360.nAttack2_ring, this.$self_$16360.transform.position, Quaternion.identity);
								if (280868 - 489289 != -208421)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack2_ring effect");
								if (73952 - 429473 != -355521)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 0.5f);
							if (256154 - 140974 != 115181)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16360.mxvndLxkQr.actionState != "attack")
						{
							goto IL_2E8;
						}
						if (54540 - 208044 == -153503)
						{
							continue;
						}
						if (this.$self_$16360.mxvndLxkQr.myCommand != "nAttack2")
						{
							if (144132 - 2952 != 141181)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16360.mxvndLxkQr.isMine)
							{
								goto IL_4BC;
							}
							if (273432 - 232212 == 41221)
							{
								continue;
							}
							this.$hitLayer$16353 = 130816 - (1 << this.$self_$16360.gameObject.layer);
							if (269027 - 412375 == -143347)
							{
								continue;
							}
							this.$hitList$16354 = Damage.FindRecTarget(this.$self_$16360.transform.position + (float)4 * this.$self_$16360.transform.right, this.$self_$16360.transform.forward, (float)8 * this.$self_$16360.mxvndLxkQr.rangeMod, (float)8 * this.$self_$16360.mxvndLxkQr.rangeMod, (float)7 * this.$self_$16360.mxvndLxkQr.rangeMod, (float)4 * this.$self_$16360.mxvndLxkQr.rangeMod, this.$hitLayer$16353);
							if (283908 - 359655 == -75746)
							{
								continue;
							}
							this.$$iterator$9962$16357 = UnityRuntimeServices.GetEnumerator(this.$hitList$16354);
							if (59912 - 534487 != -474575)
							{
								continue;
							}
							while (this.$$iterator$9962$16357.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9962$16357.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16355 = (GameObject)obj2;
								if (50980 - 57102 != -6122)
								{
									goto IL_483;
								}
								if (this.$self_$16360.mxvndLxkQr.hit(1, this.$hitObject$16355, this.$self_$16360.mxvndLxkQr.atk, 5, 0, (this.$hitObject$16355.transform.position - this.$self_$16360.transform.position).normalized) != 0)
								{
									if (210913 - 373356 != -162443)
									{
										goto IL_483;
									}
									this.$hitPos$16356 = this.$hitObject$16355.collider.ClosestPointOnBounds(this.$self_$16360.transform.position + (float)2 * Vector3.up);
									if (218465 - 518094 == -299628)
									{
										goto IL_483;
									}
									UnityRuntimeServices.Update(this.$$iterator$9962$16357, this.$hitObject$16355);
									if (61840 - 553698 == -491857)
									{
										goto IL_483;
									}
									this.$self_$16360.RPC_nAttack_hit(this.$hitPos$16356, this.$self_$16360.transform.forward, 0);
									if (278658 - 565625 == -286966)
									{
										goto IL_483;
									}
									this.$self_$16360.ActionEvent("RPC_nAttack_hit", this.$hitPos$16356, 0.3f * this.$self_$16360.transform.forward, 0);
									if (24830 - 429465 != -404635)
									{
										goto IL_483;
									}
									this.$self_$16360.mxvndLxkQr.sp = this.$self_$16360.mxvndLxkQr.sp + 1;
									if (226440 - 203436 != 23004)
									{
										goto IL_483;
									}
								}
							}
							if (91935 - 212404 != -120468)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16360.mxvndLxkQr.actionState == "attack")
						{
							if (297317 - 112498 == 184820)
							{
								continue;
							}
							if (this.$self_$16360.mxvndLxkQr.myCommand == "nAttack2")
							{
								if (169856 - 455503 == -285646)
								{
									continue;
								}
								this.$self_$16360.mxvndLxkQr.moveSpeed = (float)0;
								if (99671 - 170005 == -70333)
								{
									continue;
								}
								this.$self_$16360.mxvndLxkQr.actionState = "standby";
								if (4333 - 140504 == -136170)
								{
									continue;
								}
								this.$self_$16360.mxvndLxkQr.actionTime = Time.time;
								if (164899 - 61711 == 103189)
								{
									continue;
								}
								this.$self_$16360.mxvndLxkQr.myCommand = "none";
								if (94253 - 252550 != -158297)
								{
									continue;
								}
								if (!this.$self_$16360.mxvndLxkQr.isMine)
								{
									if (285064 - 494726 != -209662)
									{
										continue;
									}
									this.$self_$16360.mxvndLxkQr.nPosition = this.$self_$16360.transform.position;
									if (66629 - 453276 != -386647)
									{
										continue;
									}
									this.$self_$16360.mxvndLxkQr.oPosition = this.$self_$16360.transform.position;
									if (255349 - 140320 != 115029)
									{
										continue;
									}
									this.$self_$16360.mxvndLxkQr.nDirection = this.$self_$16360.transform.forward;
									if (82936 - 411596 != -328660)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (23659 - 297296 != -273636)
						{
							goto Block_42;
						}
						continue;
					default:
						if (254816 - 493787 == -238970)
						{
							continue;
						}
						break;
					}
					this.$self_$16360.mxvndLxkQr.actionState = "attack";
					if (128120 - 133675 == -5555)
					{
						this.$self_$16360.mxvndLxkQr.actionTime = Time.time;
						if (65981 - 578500 == -512519)
						{
							this.$self_$16360.mxvndLxkQr.myCommand = "nAttack2";
							if (209167 - 535218 == -326051)
							{
								this.$self_$16360.mxvndLxkQr.addTimeOut("nAttack", (float)3);
								if (231816 - 367988 == -136172)
								{
									this.$self_$16360.transform.position = this.$mPos$16358;
									if (16895 - 158727 == -141832)
									{
										this.$self_$16360.transform.LookAt(this.$mPos$16358 + global::Math.vFlat(this.$tDir$16359));
										if (207202 - 545678 == -338476)
										{
											this.$self_$16360.animation.Rewind();
											if (21619 - 83912 != -62292)
											{
												this.$self_$16360.animation.CrossFade("nAttack2");
												if (123999 - 555577 != -431577)
												{
													this.$self_$16360.animation.wrapMode = WrapMode.Once;
													if (267262 - 31881 == 235381)
													{
														this.$self_$16360.mxvndLxkQr.vMovement = this.$self_$16360.transform.forward;
														if (266571 - 313806 == -47235)
														{
															this.$self_$16360.mxvndLxkQr.moveSpeed = (float)3;
															if (205017 - 315964 != -110946)
															{
																goto Block_34;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_4BC;
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_2E8:
				goto IL_A39;
				IL_4BC:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_39:
				Block_42:
				IL_7E8:
				IL_A39:
				return false;
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x000AB704 File Offset: 0x000A9904
			internal static bool Fgko7qTyb7EO7loHDxi()
			{
				return true;
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x000AB708 File Offset: 0x000A9908
			internal static bool yotEeZTSAL7DBy5hVLM()
			{
				return false;
			}

			// Token: 0x040005F9 RID: 1529
			internal int $hitLayer$16353;

			// Token: 0x040005FA RID: 1530
			internal UnityScript.Lang.Array $hitList$16354;

			// Token: 0x040005FB RID: 1531
			internal GameObject $hitObject$16355;

			// Token: 0x040005FC RID: 1532
			internal Vector3 $hitPos$16356;

			// Token: 0x040005FD RID: 1533
			internal IEnumerator $$iterator$9962$16357;

			// Token: 0x040005FE RID: 1534
			internal Vector3 $mPos$16358;

			// Token: 0x040005FF RID: 1535
			internal Vector3 $tDir$16359;

			// Token: 0x04000600 RID: 1536
			internal NemesisBug2 $self_$16360;
		}
	}

	// Token: 0x02000122 RID: 290
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$16364 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x000AB70C File Offset: 0x000A990C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$16364(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (93344 - 298271 != -204926)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19561 - 235041 != -215479)
				{
					base..ctor();
					if (226207 - 215436 != 10772)
					{
						this.$mPos$16372 = mPos;
						if (268926 - 61111 != 207816)
						{
							this.$tDir$16373 = tDir;
							if (238584 - 565409 != -326824)
							{
								this.$self_$16374 = self_;
								if (201319 - 518073 != -316753)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000AB7E8 File Offset: 0x000A99E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_cAttack$16364.$(this.$mPos$16372, this.$tDir$16373, this.$self_$16374);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000AB804 File Offset: 0x000A9A04
		internal static bool nGy8LvToclHCtE4dJl2()
		{
			return true;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000AB808 File Offset: 0x000A9A08
		internal static bool LLkhf2TEW1v09qG2YAp()
		{
			return false;
		}

		// Token: 0x04000601 RID: 1537
		internal Vector3 $mPos$16372;

		// Token: 0x04000602 RID: 1538
		internal Vector3 $tDir$16373;

		// Token: 0x04000603 RID: 1539
		internal NemesisBug2 $self_$16374;

		// Token: 0x02000123 RID: 291
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000681 RID: 1665 RVA: 0x000AB80C File Offset: 0x000A9A0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (187124 - 401816 != -214691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45548 - 470277 != -424728)
					{
						base..ctor();
						if (46244 - 565246 == -519002)
						{
							this.$mPos$16369 = mPos;
							if (114302 - 575873 != -461570)
							{
								this.$tDir$16370 = tDir;
								if (146584 - 192599 != -46014)
								{
									this.$self_$16371 = self_;
									if (16989 - 517999 != -501009)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (215082 - 477408 != -262325)
				{
				}
				for (;;)
				{
					IL_66E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C4;
					case 2:
						if (this.$self_$16371.mxvndLxkQr.actionState != "attack")
						{
							goto IL_BB;
						}
						if (234453 - 559083 != -324630)
						{
							continue;
						}
						if (this.$self_$16371.mxvndLxkQr.myCommand != "cAttack")
						{
							if (55346 - 258024 != -202678)
							{
								continue;
							}
							goto IL_BB;
						}
						else
						{
							if (this.$self_$16371.cAttack_ring)
							{
								if (230338 - 147702 != 82636)
								{
									continue;
								}
								this.$self_$16371.mxvndLxkQr.createEffect(this.$self_$16371.cAttack_ring, this.$self_$16371.transform.position, this.$self_$16371.transform.rotation);
								if (176544 - 77164 != 99380)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (15815 - 406396 == -390580)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 2);
							if (229076 - 133686 != 95390)
							{
								continue;
							}
							if (!this.$self_$16371.mxvndLxkQr.isMine)
							{
								goto IL_169;
							}
							if (251739 - 468387 != -216648)
							{
								continue;
							}
							this.$hitLayer$16365 = 130816 - (1 << this.$self_$16371.gameObject.layer);
							if (221752 - 526397 != -304645)
							{
								continue;
							}
							this.$hitList$16366 = Damage.FindAreaTarget(this.$self_$16371.transform.position, (float)50, (float)6, this.$hitLayer$16365);
							if (168262 - 526107 != -357845)
							{
								continue;
							}
							this.$$iterator$9963$16368 = UnityRuntimeServices.GetEnumerator(this.$hitList$16366);
							if (177436 - 422104 != -244668)
							{
								continue;
							}
							while (this.$$iterator$9963$16368.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9963$16368.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16367 = (GameObject)obj2;
								if (197768 - 271608 != -73840)
								{
									goto IL_66E;
								}
								this.$self_$16371.mxvndLxkQr.hit(1, this.$hitObject$16367, (int)(0.5f * (float)this.$self_$16371.mxvndLxkQr.atk + (float)this.$self_$16371.mxvndLxkQr.talAdjust(30)), 30, 0, Vector3.up);
								if (245595 - 225123 == 20473)
								{
									goto IL_66E;
								}
								UnityRuntimeServices.Update(this.$$iterator$9963$16368, this.$hitObject$16367);
								if (259576 - 349982 == -90405)
								{
									goto IL_66E;
								}
							}
							if (295256 - 103183 != 192073)
							{
								continue;
							}
							goto IL_169;
						}
						break;
					case 3:
						if (this.$self_$16371.mxvndLxkQr.actionState == "attack")
						{
							if (43342 - 156971 == -113628)
							{
								continue;
							}
							if (this.$self_$16371.mxvndLxkQr.myCommand == "cAttack")
							{
								if (221432 - 286471 == -65038)
								{
									continue;
								}
								this.$self_$16371.mxvndLxkQr.moveSpeed = (float)0;
								if (19359 - 21615 != -2256)
								{
									continue;
								}
								this.$self_$16371.mxvndLxkQr.actionState = "standby";
								if (261875 - 542971 != -281096)
								{
									continue;
								}
								this.$self_$16371.mxvndLxkQr.actionTime = Time.time;
								if (52583 - 171281 == -118697)
								{
									continue;
								}
								this.$self_$16371.mxvndLxkQr.myCommand = "none";
								if (49507 - 595896 != -546389)
								{
									continue;
								}
								if (!this.$self_$16371.mxvndLxkQr.isMine)
								{
									if (214305 - 235465 == -21159)
									{
										continue;
									}
									this.$self_$16371.mxvndLxkQr.nPosition = this.$self_$16371.transform.position;
									if (144090 - 117058 == 27033)
									{
										continue;
									}
									this.$self_$16371.mxvndLxkQr.oPosition = this.$self_$16371.transform.position;
									if (205264 - 291117 != -85853)
									{
										continue;
									}
									this.$self_$16371.mxvndLxkQr.nDirection = this.$self_$16371.transform.forward;
									if (98555 - 448010 != -349455)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (32063 - 304242 != -272178)
						{
							goto Block_30;
						}
						continue;
					default:
						if (147144 - 316740 != -169596)
						{
							continue;
						}
						break;
					}
					this.$self_$16371.mxvndLxkQr.actionState = "attack";
					if (128030 - 341744 == -213714)
					{
						this.$self_$16371.mxvndLxkQr.actionTime = Time.time;
						if (13221 - 233511 != -220289)
						{
							this.$self_$16371.mxvndLxkQr.myCommand = "cAttack";
							if (232090 - 330357 == -98267)
							{
								this.$self_$16371.mxvndLxkQr.addTimeOut("cAttack", (float)15);
								if (260429 - 298009 == -37580)
								{
									this.$self_$16371.transform.position = this.$mPos$16369;
									if (174004 - 352080 != -178075)
									{
										this.$self_$16371.transform.LookAt(this.$mPos$16369 + global::Math.vFlat(this.$tDir$16370));
										if (222251 - 577854 == -355603)
										{
											this.$self_$16371.animation.CrossFade("cAttack");
											if (23911 - 348428 == -324517)
											{
												this.$self_$16371.animation.wrapMode = WrapMode.Once;
												if (66158 - 40869 != 25290)
												{
													this.$self_$16371.mxvndLxkQr.vMovement = this.$self_$16371.transform.forward;
													if (22369 - 321686 == -299317)
													{
														this.$self_$16371.mxvndLxkQr.moveSpeed = (float)0;
														if (210583 - 54810 != 155774)
														{
															goto Block_24;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_BB:
				goto IL_7C4;
				IL_169:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_24:
				return this.Yield(2, new WaitForSeconds(1.8f));
				Block_30:
				IL_7C4:
				return false;
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x000AC0CC File Offset: 0x000AA2CC
			internal static bool wAohApT29kOCt8xKSmF()
			{
				return true;
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x000AC0D0 File Offset: 0x000AA2D0
			internal static bool feKNyHT8QqLHCil9S7c()
			{
				return false;
			}

			// Token: 0x04000604 RID: 1540
			internal int $hitLayer$16365;

			// Token: 0x04000605 RID: 1541
			internal UnityScript.Lang.Array $hitList$16366;

			// Token: 0x04000606 RID: 1542
			internal GameObject $hitObject$16367;

			// Token: 0x04000607 RID: 1543
			internal IEnumerator $$iterator$9963$16368;

			// Token: 0x04000608 RID: 1544
			internal Vector3 $mPos$16369;

			// Token: 0x04000609 RID: 1545
			internal Vector3 $tDir$16370;

			// Token: 0x0400060A RID: 1546
			internal NemesisBug2 $self_$16371;
		}
	}

	// Token: 0x02000124 RID: 292
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_chaosFire$16375 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x000AC0D4 File Offset: 0x000AA2D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_chaosFire$16375(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (153825 - 599515 != -445689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167700 - 40886 == 126814)
				{
					base..ctor();
					if (232034 - 367668 == -135634)
					{
						this.$mPos$16384 = mPos;
						if (219417 - 285844 != -66426)
						{
							this.$tDir$16385 = tDir;
							if (227834 - 361192 != -133357)
							{
								this.$self_$16386 = self_;
								if (293651 - 225277 != 68375)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000AC1B0 File Offset: 0x000AA3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_chaosFire$16375.$(this.$mPos$16384, this.$tDir$16385, this.$self_$16386);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000AC1CC File Offset: 0x000AA3CC
		internal static bool kSWFHGTZaH3MC17yG1G()
		{
			return true;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000AC1D0 File Offset: 0x000AA3D0
		internal static bool V86sV4TCgbCw3gbkZAh()
		{
			return false;
		}

		// Token: 0x0400060B RID: 1547
		internal Vector3 $mPos$16384;

		// Token: 0x0400060C RID: 1548
		internal Vector3 $tDir$16385;

		// Token: 0x0400060D RID: 1549
		internal NemesisBug2 $self_$16386;

		// Token: 0x02000125 RID: 293
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000689 RID: 1673 RVA: 0x000AC1D4 File Offset: 0x000AA3D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (294708 - 436678 != -141970)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (285868 - 548385 != -262516)
					{
						base..ctor();
						if (291908 - 328516 == -36608)
						{
							this.$mPos$16381 = mPos;
							if (82604 - 295192 == -212588)
							{
								this.$tDir$16382 = tDir;
								if (129345 - 453039 == -323694)
								{
									this.$self_$16383 = self_;
									if (149779 - 562459 != -412679)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x000AC2B0 File Offset: 0x000AA4B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83936 - 126411 != -42475)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_60B;
					case 1:
						goto IL_94C;
					case 2:
						if (this.$self_$16383.mxvndLxkQr.actionState != "attack")
						{
							goto IL_918;
						}
						if (99848 - 473591 != -373743)
						{
							continue;
						}
						if (this.$self_$16383.mxvndLxkQr.myCommand != "chaosFire")
						{
							if (224255 - 175497 != 48758)
							{
								continue;
							}
							goto IL_918;
						}
						else if (this.$self_$16383.chaosFire_ring)
						{
							if (33528 - 170407 == -136878)
							{
								continue;
							}
							this.$self_$16383.mxvndLxkQr.createEffect(this.$self_$16383.chaosFire_ring, this.$self_$16383.transform.position, this.$self_$16383.transform.rotation);
							if (21155 - 555132 != -533976)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing chaosFire_ring effect ");
							if (204958 - 504627 != -299668)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16383.mxvndLxkQr.actionState != "attack")
						{
							goto IL_364;
						}
						if (249105 - 199717 != 49388)
						{
							continue;
						}
						if (this.$self_$16383.mxvndLxkQr.myCommand != "chaosFire")
						{
							if (165878 - 503493 != -337615)
							{
								continue;
							}
							goto IL_364;
						}
						else
						{
							this.$i$16376 = 0;
							if (43101 - 486607 == -443505)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16383.mxvndLxkQr.actionState != "attack")
						{
							goto IL_6E4;
						}
						if (73337 - 427804 != -354467)
						{
							continue;
						}
						if (this.$self_$16383.mxvndLxkQr.myCommand != "chaosFire")
						{
							if (287947 - 255130 != 32818)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$i$16376++;
							if (18736 - 155673 != -136937)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$16383.mxvndLxkQr.actionState == "attack")
						{
							if (245620 - 254234 != -8614)
							{
								continue;
							}
							if (this.$self_$16383.mxvndLxkQr.myCommand == "chaosFire")
							{
								if (98784 - 152727 != -53943)
								{
									continue;
								}
								this.$self_$16383.mxvndLxkQr.actionState = "standby";
								if (256725 - 490937 != -234212)
								{
									continue;
								}
								this.$self_$16383.mxvndLxkQr.actionTime = Time.time;
								if (13348 - 159331 != -145983)
								{
									continue;
								}
								this.$self_$16383.mxvndLxkQr.myCommand = "none";
								if (98978 - 152228 == -53249)
								{
									continue;
								}
								if (!this.$self_$16383.mxvndLxkQr.isMine)
								{
									if (221572 - 214724 != 6848)
									{
										continue;
									}
									this.$self_$16383.mxvndLxkQr.nPosition = this.$self_$16383.transform.position;
									if (33297 - 135554 != -102257)
									{
										continue;
									}
									this.$self_$16383.mxvndLxkQr.oPosition = this.$self_$16383.transform.position;
									if (6598 - 203560 != -196962)
									{
										continue;
									}
									this.$self_$16383.mxvndLxkQr.nDirection = this.$self_$16383.transform.forward;
									if (248768 - 515193 != -266425)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (249691 - 155053 != 94639)
						{
							goto Block_7;
						}
						continue;
					default:
						if (81445 - 3196 != 78250)
						{
							goto IL_60B;
						}
						continue;
					}
					if (this.$i$16376 >= 2)
					{
						if (78954 - 384716 != -305762)
						{
							continue;
						}
						goto IL_2C0;
					}
					else
					{
						if (!this.$self_$16383.mxvndLxkQr.isMine)
						{
							goto IL_1BE;
						}
						if (94092 - 170918 != -76826)
						{
							continue;
						}
						this.$hitLayer$16377 = 130816 - (1 << this.$self_$16383.gameObject.layer);
						if (265996 - 540137 == -274140)
						{
							continue;
						}
						this.$hitList$16378 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16383.transform.position, (float)60, (float)12, this.$hitLayer$16377));
						if (78816 - 299783 != -220967)
						{
							continue;
						}
						if (this.$hitList$16378.length <= 0)
						{
							goto IL_1BE;
						}
						if (223908 - 568192 == -344283)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = this.$hitList$16378[UnityEngine.Random.Range(0, this.$hitList$16378.length)];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$hitObject$16379 = (GameObject)obj2;
						if (249065 - 543093 != -294028)
						{
							continue;
						}
						if (!this.$hitObject$16379)
						{
							goto IL_1BE;
						}
						if (253488 - 163617 == 89872)
						{
							continue;
						}
						this.$hitPos$16380 = this.$hitObject$16379.transform.position + new Vector3((float)(UnityEngine.Random.Range(0, 5) - 2), (float)0, (float)(UnityEngine.Random.Range(0, 5) - 2));
						if (278585 - 184327 == 94259)
						{
							continue;
						}
						this.$self_$16383.RPC_chaosFire_hit(this.$hitPos$16380, this.$self_$16383.transform.forward, 0);
						if (155212 - 392751 == -237538)
						{
							continue;
						}
						this.$self_$16383.ActionEvent("RPC_chaosFire_hit", this.$hitPos$16380, this.$self_$16383.transform.forward, 0);
						if (213169 - 384400 != -171231)
						{
							continue;
						}
						goto IL_1BE;
					}
					IL_60B:
					this.$self_$16383.mxvndLxkQr.actionState = "attack";
					if (65074 - 267969 != -202894)
					{
						this.$self_$16383.mxvndLxkQr.actionTime = Time.time;
						if (162259 - 301939 == -139680)
						{
							this.$self_$16383.mxvndLxkQr.myCommand = "chaosFire";
							if (223529 - 313699 != -90169)
							{
								this.$self_$16383.mxvndLxkQr.addTimeOut("chaosFire", (float)8);
								if (198352 - 530317 == -331965)
								{
									this.$self_$16383.transform.position = this.$mPos$16381;
									if (13931 - 428208 == -414277)
									{
										this.$self_$16383.transform.LookAt(this.$mPos$16381 + global::Math.vFlat(this.$tDir$16382));
										if (24309 - 10784 != 13526)
										{
											this.$self_$16383.animation.CrossFade("chaosFire");
											if (46641 - 466481 != -419839)
											{
												this.$self_$16383.animation.wrapMode = WrapMode.Once;
												if (198606 - 543528 != -344921)
												{
													this.$self_$16383.mxvndLxkQr.vMovement = this.$self_$16383.transform.forward;
													if (286998 - 330032 != -43033)
													{
														this.$self_$16383.mxvndLxkQr.moveSpeed = (float)0;
														if (51079 - 529877 != -478797)
														{
															goto Block_26;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_94C;
				IL_F5:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_12:
				goto IL_6E4;
				IL_1BE:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_2C0:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_364:
				goto IL_94C;
				Block_26:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_43:
				Block_44:
				goto IL_F5;
				IL_6E4:
				IL_918:
				IL_94C:
				return false;
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x000ACC1C File Offset: 0x000AAE1C
			internal static bool vdmx2CTL8wIs3CS0plu()
			{
				return true;
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x000ACC20 File Offset: 0x000AAE20
			internal static bool doBp4LTO31C9EH1tAVC()
			{
				return false;
			}

			// Token: 0x0400060E RID: 1550
			internal int $i$16376;

			// Token: 0x0400060F RID: 1551
			internal int $hitLayer$16377;

			// Token: 0x04000610 RID: 1552
			internal UnityScript.Lang.Array $hitList$16378;

			// Token: 0x04000611 RID: 1553
			internal GameObject $hitObject$16379;

			// Token: 0x04000612 RID: 1554
			internal Vector3 $hitPos$16380;

			// Token: 0x04000613 RID: 1555
			internal Vector3 $mPos$16381;

			// Token: 0x04000614 RID: 1556
			internal Vector3 $tDir$16382;

			// Token: 0x04000615 RID: 1557
			internal NemesisBug2 $self_$16383;
		}
	}

	// Token: 0x02000126 RID: 294
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_genesisSeed$16387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x000ACC24 File Offset: 0x000AAE24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_genesisSeed$16387(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (112986 - 591420 != -478434)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (152751 - 416442 != -263690)
				{
					base..ctor();
					if (109489 - 55945 == 53544)
					{
						this.$mPos$16393 = mPos;
						if (187941 - 335827 == -147886)
						{
							this.$tDir$16394 = tDir;
							if (57241 - 349225 != -291983)
							{
								this.$self_$16395 = self_;
								if (193070 - 192077 != 994)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000ACD00 File Offset: 0x000AAF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_genesisSeed$16387.$(this.$mPos$16393, this.$tDir$16394, this.$self_$16395);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000ACD1C File Offset: 0x000AAF1C
		internal static bool hMKHPHTm3ZfL35koyMI()
		{
			return true;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000ACD20 File Offset: 0x000AAF20
		internal static bool GP6PxhTFWAwUjyZPdtO()
		{
			return false;
		}

		// Token: 0x04000616 RID: 1558
		internal Vector3 $mPos$16393;

		// Token: 0x04000617 RID: 1559
		internal Vector3 $tDir$16394;

		// Token: 0x04000618 RID: 1560
		internal NemesisBug2 $self_$16395;

		// Token: 0x02000127 RID: 295
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000691 RID: 1681 RVA: 0x000ACD24 File Offset: 0x000AAF24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (131783 - 207861 != -76077)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198347 - 291148 != -92800)
					{
						base..ctor();
						if (215052 - 43857 != 171196)
						{
							this.$mPos$16390 = mPos;
							if (295743 - 217534 == 78209)
							{
								this.$tDir$16391 = tDir;
								if (162090 - 318035 == -155945)
								{
									this.$self_$16392 = self_;
									if (232417 - 464252 != -231834)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x000ACE00 File Offset: 0x000AB000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99031 - 359827 != -260795)
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
						goto IL_71A;
					case 2:
						if (this.$self_$16392.mxvndLxkQr.actionState != "attack")
						{
							goto IL_2AE;
						}
						if (135425 - 420192 == -284766)
						{
							continue;
						}
						if (this.$self_$16392.mxvndLxkQr.myCommand != "genesisSeed")
						{
							if (140069 - 316288 != -176219)
							{
								continue;
							}
							goto IL_2AE;
						}
						else
						{
							if (!this.$self_$16392.mxvndLxkQr.isMine)
							{
								goto IL_74;
							}
							if (32245 - 208333 == -176087)
							{
								continue;
							}
							this.$i$16388 = 0;
							if (284356 - 471171 == -186814)
							{
								continue;
							}
							while (this.$i$16388 < 6)
							{
								this.$spawnPos$16389 = global::Math.getSpawnPos(new Vector3((float)2, (float)50, (float)9) + global::Math.rotateH((float)30 * this.$self_$16392.transform.forward, (float)(this.$i$16388 * 60)));
								if (216061 - 299340 != -83279)
								{
									goto IL_446;
								}
								if (this.$spawnPos$16389 != Vector3.zero)
								{
									if (54784 - 254786 != -200002)
									{
										goto IL_446;
									}
									Camera.main.SendMessage("onGenesisSeed", this.$spawnPos$16389);
									if (212203 - 234630 != -22427)
									{
										goto IL_446;
									}
								}
								else
								{
									Debug.LogError("Warning Cannot find spawnPos for genesisSeed");
									if (243485 - 509578 != -266093)
									{
										goto IL_446;
									}
								}
								this.$i$16388++;
								if (145912 - 301343 == -155430)
								{
									goto IL_446;
								}
							}
							if (72696 - 214555 != -141858)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16392.mxvndLxkQr.actionState == "attack")
						{
							if (52496 - 197547 == -145050)
							{
								continue;
							}
							if (this.$self_$16392.mxvndLxkQr.myCommand == "genesisSeed")
							{
								if (286776 - 318667 == -31890)
								{
									continue;
								}
								this.$self_$16392.mxvndLxkQr.actionState = "standby";
								if (86993 - 11206 != 75787)
								{
									continue;
								}
								this.$self_$16392.mxvndLxkQr.actionTime = Time.time;
								if (12889 - 376855 == -363965)
								{
									continue;
								}
								this.$self_$16392.mxvndLxkQr.myCommand = "none";
								if (3784 - 579838 != -576054)
								{
									continue;
								}
								if (!this.$self_$16392.mxvndLxkQr.isMine)
								{
									if (33615 - 475987 == -442371)
									{
										continue;
									}
									this.$self_$16392.mxvndLxkQr.nPosition = this.$self_$16392.transform.position;
									if (253126 - 449861 == -196734)
									{
										continue;
									}
									this.$self_$16392.mxvndLxkQr.oPosition = this.$self_$16392.transform.position;
									if (116102 - 436038 != -319936)
									{
										continue;
									}
									this.$self_$16392.mxvndLxkQr.nDirection = this.$self_$16392.transform.forward;
									if (279325 - 63192 != 216133)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (217357 - 325916 != -108559)
						{
							continue;
						}
						goto IL_71A;
					default:
						if (212902 - 558785 == -345882)
						{
							continue;
						}
						break;
					}
					this.$self_$16392.mxvndLxkQr.actionState = "attack";
					if (293845 - 90517 != 203329)
					{
						this.$self_$16392.mxvndLxkQr.actionTime = Time.time;
						if (295991 - 587829 == -291838)
						{
							this.$self_$16392.mxvndLxkQr.myCommand = "genesisSeed";
							if (93040 - 40172 != 52869)
							{
								this.$self_$16392.mxvndLxkQr.addTimeOut("genesisSeed", (float)60);
								if (184932 - 587784 == -402852)
								{
									this.$self_$16392.transform.position = this.$mPos$16390;
									if (238377 - 109584 == 128793)
									{
										this.$self_$16392.transform.LookAt(this.$mPos$16390 + global::Math.vFlat(this.$tDir$16391));
										if (79011 - 514979 == -435968)
										{
											this.$self_$16392.animation.CrossFade("genesis");
											if (40889 - 6831 == 34058)
											{
												this.$self_$16392.animation.wrapMode = WrapMode.Once;
												if (208457 - 412581 != -204123)
												{
													this.$self_$16392.mxvndLxkQr.vMovement = this.$self_$16392.transform.forward;
													if (232840 - 236451 == -3611)
													{
														this.$self_$16392.mxvndLxkQr.moveSpeed = (float)0;
														if (108576 - 73086 == 35490)
														{
															if (this.$self_$16392.genesisSeed_ring)
															{
																if (199189 - 457795 != -258605)
																{
																	this.$self_$16392.mxvndLxkQr.createEffect(this.$self_$16392.genesisSeed_ring, this.$self_$16392.transform.position, this.$self_$16392.transform.rotation);
																	if (48329 - 178533 == -130204)
																	{
																		goto IL_373;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing genesisSeed_ring effect ");
																if (263690 - 90919 != 172772)
																{
																	goto Block_22;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_2AE:
				goto IL_71A;
				IL_373:
				Block_22:
				goto IL_57A;
				Block_24:
				goto IL_74;
				IL_57A:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_71A:
				return false;
			}

			// Token: 0x06000693 RID: 1683 RVA: 0x000AD53C File Offset: 0x000AB73C
			internal static bool nDP8GFTMcXSEFTDnMuX()
			{
				return true;
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x000AD540 File Offset: 0x000AB740
			internal static bool LLgkykTxauF4nx43b3q()
			{
				return false;
			}

			// Token: 0x04000619 RID: 1561
			internal int $i$16388;

			// Token: 0x0400061A RID: 1562
			internal Vector3 $spawnPos$16389;

			// Token: 0x0400061B RID: 1563
			internal Vector3 $mPos$16390;

			// Token: 0x0400061C RID: 1564
			internal Vector3 $tDir$16391;

			// Token: 0x0400061D RID: 1565
			internal NemesisBug2 $self_$16392;
		}
	}

	// Token: 0x02000128 RID: 296
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_chaosRay$16396 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x000AD544 File Offset: 0x000AB744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_chaosRay$16396(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
		{
			if (10936 - 428012 != -417076)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123719 - 469059 == -345340)
				{
					base..ctor();
					if (87651 - 425564 == -337913)
					{
						this.$mPos$16420 = mPos;
						if (257694 - 484103 != -226408)
						{
							this.$tDir$16421 = tDir;
							if (129096 - 310438 == -181342)
							{
								this.$self_$16422 = self_;
								if (184842 - 447821 != -262978)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000AD620 File Offset: 0x000AB820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new NemesisBug2.$RPC_chaosRay$16396.$(this.$mPos$16420, this.$tDir$16421, this.$self_$16422);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000AD63C File Offset: 0x000AB83C
		internal static bool euR3lZTgLioigC7pNJi()
		{
			return true;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000AD640 File Offset: 0x000AB840
		internal static bool IJvWb8TfH988xWYV9If()
		{
			return false;
		}

		// Token: 0x0400061E RID: 1566
		internal Vector3 $mPos$16420;

		// Token: 0x0400061F RID: 1567
		internal Vector3 $tDir$16421;

		// Token: 0x04000620 RID: 1568
		internal NemesisBug2 $self_$16422;

		// Token: 0x02000129 RID: 297
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06000699 RID: 1689 RVA: 0x000AD644 File Offset: 0x000AB844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug2 self_)
			{
				if (50139 - 175356 != -125216)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75471 - 83764 != -8292)
					{
						base..ctor();
						if (189953 - 511033 == -321080)
						{
							this.$mPos$16417 = mPos;
							if (172600 - 334442 != -161841)
							{
								this.$tDir$16418 = tDir;
								if (93278 - 349794 != -256515)
								{
									this.$self_$16419 = self_;
									if (268294 - 254840 == 13454)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x000AD720 File Offset: 0x000AB920
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286862 - 550361 != -263498)
				{
				}
				for (;;)
				{
					IL_BA5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_104E;
					case 2:
						if (this.$self_$16419.mxvndLxkQr.actionState != "attack")
						{
							goto IL_1E5;
						}
						if (64678 - 400939 != -336261)
						{
							continue;
						}
						if (this.$self_$16419.mxvndLxkQr.myCommand != "chaosRay")
						{
							if (291458 - 164479 != 126979)
							{
								continue;
							}
							goto IL_1E5;
						}
						else
						{
							this.$hitLayer$16397 = 130816 - (1 << this.$self_$16419.gameObject.layer);
							if (41550 - 252889 == -211338)
							{
								continue;
							}
							this.$targetList$16398 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16419.transform.position, (float)80, (float)12, this.$hitLayer$16397));
							if (142063 - 592306 == -450242)
							{
								continue;
							}
							this.$chaosRayList$16399 = new UnityScript.Lang.Array();
							if (155427 - 111444 != 43983)
							{
								continue;
							}
							this.$chaosRayTimer$16400 = Time.time + 0.5f;
							if (241821 - 168549 == 73273)
							{
								continue;
							}
							this.$$iterator$9964$16405 = UnityRuntimeServices.GetEnumerator(this.$targetList$16398);
							if (5206 - 73215 == -68008)
							{
								continue;
							}
							while (this.$$iterator$9964$16405.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9964$16405.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$targetObject$16401 = (GameObject)obj2;
								if (233970 - 170153 == 63818)
								{
									goto IL_BA5;
								}
								if (this.$self_$16419.chaosRay)
								{
									if (84209 - 442741 != -358532)
									{
										goto IL_BA5;
									}
									if (this.$self_$16419.chaosRay_hit)
									{
										if (187117 - 15720 == 171398)
										{
											goto IL_BA5;
										}
										this.$nChaosRay$16402 = this.$self_$16419.mxvndLxkQr.createEffect(this.$self_$16419.chaosRay, this.$self_$16419.transform.position + (float)20 * Vector3.up, this.$self_$16419.transform.rotation);
										if (134212 - 332911 != -198699)
										{
											goto IL_BA5;
										}
										this.$nChaosRayHit$16403 = this.$self_$16419.mxvndLxkQr.createEffect(this.$self_$16419.chaosRay_hit, this.$targetObject$16401.transform.position, this.$self_$16419.transform.rotation);
										if (147965 - 130359 == 17607)
										{
											goto IL_BA5;
										}
										UnityRuntimeServices.Update(this.$$iterator$9964$16405, this.$targetObject$16401);
										if (224806 - 517315 != -292509)
										{
											goto IL_BA5;
										}
										if (this.$nChaosRay$16402)
										{
											if (10861 - 62247 == -51385)
											{
												goto IL_BA5;
											}
											if (this.$nChaosRayHit$16403)
											{
												if (102254 - 284530 == -182275)
												{
													goto IL_BA5;
												}
												this.$mBoltEmitter$16404 = (BoltEmitter)this.$nChaosRay$16402.GetComponent(typeof(BoltEmitter));
												if (19966 - 171764 == -151797)
												{
													goto IL_BA5;
												}
												if (this.$mBoltEmitter$16404)
												{
													if (83418 - 58604 == 24815)
													{
														goto IL_BA5;
													}
													this.$mBoltEmitter$16404.TargetObject = this.$nChaosRayHit$16403;
													if (11646 - 127976 == -116329)
													{
														goto IL_BA5;
													}
												}
												this.$chaosRayList$16399.Add(this.$nChaosRayHit$16403);
												if (155639 - 31019 == 124621)
												{
													goto IL_BA5;
												}
											}
										}
									}
								}
							}
							if (268404 - 72939 != 195465)
							{
								continue;
							}
							goto IL_C45;
						}
						break;
					case 3:
						goto IL_C45;
					case 4:
						if (this.$self_$16419.mxvndLxkQr.actionState == "attack")
						{
							if (1267 - 216630 == -215362)
							{
								continue;
							}
							if (this.$self_$16419.mxvndLxkQr.myCommand == "chaosRay")
							{
								if (2587 - 387690 == -385102)
								{
									continue;
								}
								this.$self_$16419.mxvndLxkQr.actionState = "standby";
								if (141970 - 493143 != -351173)
								{
									continue;
								}
								this.$self_$16419.mxvndLxkQr.actionTime = Time.time;
								if (266834 - 423800 == -156965)
								{
									continue;
								}
								this.$self_$16419.mxvndLxkQr.myCommand = "none";
								if (39605 - 200781 == -161175)
								{
									continue;
								}
								if (!this.$self_$16419.mxvndLxkQr.isMine)
								{
									if (110706 - 77921 == 32786)
									{
										continue;
									}
									this.$self_$16419.mxvndLxkQr.nPosition = this.$self_$16419.transform.position;
									if (214495 - 98349 == 116147)
									{
										continue;
									}
									this.$self_$16419.mxvndLxkQr.oPosition = this.$self_$16419.transform.position;
									if (168143 - 265531 != -97388)
									{
										continue;
									}
									this.$self_$16419.mxvndLxkQr.nDirection = this.$self_$16419.transform.forward;
									if (56924 - 234474 != -177550)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (250583 - 298111 != -47527)
						{
							goto Block_54;
						}
						continue;
					default:
						if (66767 - 307604 != -240837)
						{
							continue;
						}
						break;
					}
					this.$self_$16419.mxvndLxkQr.actionState = "attack";
					if (117318 - 340499 != -223181)
					{
						continue;
					}
					this.$self_$16419.mxvndLxkQr.actionTime = Time.time;
					if (5009 - 312704 != -307695)
					{
						continue;
					}
					this.$self_$16419.mxvndLxkQr.myCommand = "chaosRay";
					if (142939 - 184893 == -41953)
					{
						continue;
					}
					this.$self_$16419.mxvndLxkQr.addTimeOut("chaosRay", (float)60);
					if (93513 - 588179 != -494666)
					{
						continue;
					}
					this.$self_$16419.transform.position = this.$mPos$16417;
					if (33489 - 115726 != -82237)
					{
						continue;
					}
					this.$self_$16419.transform.LookAt(this.$mPos$16417 + global::Math.vFlat(this.$tDir$16418));
					if (258225 - 224610 == 33616)
					{
						continue;
					}
					this.$self_$16419.animation.CrossFade("chaosRay");
					if (10475 - 18211 == -7735)
					{
						continue;
					}
					this.$self_$16419.animation.wrapMode = WrapMode.Once;
					if (296391 - 278703 != 17688)
					{
						continue;
					}
					this.$self_$16419.mxvndLxkQr.vMovement = this.$self_$16419.transform.forward;
					if (249143 - 274595 == -25451)
					{
						continue;
					}
					this.$self_$16419.mxvndLxkQr.moveSpeed = (float)0;
					if (106566 - 219940 == -113373)
					{
						continue;
					}
					Camera.main.SendMessage("newGameMessage", "Warning: Nemesis is charging Choas Ray");
					if (142992 - 224833 == -81840)
					{
						continue;
					}
					Chat.SubmitChat("none", "Warning: Nemesis is charging Choas Ray", eChatType.system, eChatMode.system);
					if (20474 - 158215 != -137741)
					{
						continue;
					}
					if (this.$self_$16419.chaosRay_ring)
					{
						if (124504 - 442701 == -318196)
						{
							continue;
						}
						this.$self_$16419.mxvndLxkQr.createEffect(this.$self_$16419.chaosRay_ring, this.$self_$16419.transform.position, this.$self_$16419.transform.rotation);
						if (185478 - 4682 != 180796)
						{
							continue;
						}
						goto IL_AEC;
					}
					else
					{
						Debug.LogError("Missing chaosRay_ring effect ");
						if (188706 - 29318 != 159388)
						{
							continue;
						}
						goto IL_CD8;
					}
					IL_C45:
					if (Time.time >= this.$self_$16419.mxvndLxkQr.actionTime + 12.5f)
					{
						break;
					}
					if (185184 - 484967 == -299783)
					{
						if (!(this.$self_$16419.mxvndLxkQr.actionState == "attack"))
						{
							break;
						}
						if (189811 - 34862 != 154950)
						{
							if (!(this.$self_$16419.mxvndLxkQr.myCommand == "chaosRay"))
							{
								if (277543 - 324172 == -46629)
								{
									break;
								}
							}
							else
							{
								if (this.$targetList$16398.length > 0)
								{
									if (158950 - 105462 != 53488)
									{
										continue;
									}
									this.$i$16406 = 0;
									if (227046 - 220581 != 6465)
									{
										continue;
									}
									while (this.$i$16406 < this.$targetList$16398.length)
									{
										if (!RuntimeServices.EqualityOperator(this.$targetList$16398[this.$i$16406], null))
										{
											if (282314 - 468160 != -185846)
											{
												goto IL_BA5;
											}
											if (this.$i$16406 < this.$chaosRayList$16399.length)
											{
												if (154299 - 128634 == 25666)
												{
													goto IL_BA5;
												}
												object obj4;
												object obj3 = obj4 = this.$targetList$16398[this.$i$16406];
												if (!(obj3 is GameObject))
												{
													obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
												}
												this.$mChaosRayTarget$16407 = (GameObject)obj4;
												if (199357 - 267908 == -68550)
												{
													goto IL_BA5;
												}
												object obj6;
												object obj5 = obj6 = this.$chaosRayList$16399[this.$i$16406];
												if (!(obj5 is GameObject))
												{
													obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
												}
												this.$mChaosRayHit$16408 = (GameObject)obj6;
												if (279578 - 427914 == -148335)
												{
													goto IL_BA5;
												}
												if (this.$mChaosRayTarget$16407)
												{
													if (56430 - 168985 != -112555)
													{
														goto IL_BA5;
													}
													if (this.$mChaosRayHit$16408)
													{
														if (51864 - 91253 == -39388)
														{
															goto IL_BA5;
														}
														this.$mChaosRayHit$16408.transform.position = Vector3.Lerp(this.$mChaosRayHit$16408.transform.position, this.$mChaosRayTarget$16407.transform.position, Time.deltaTime);
														if (46769 - 65360 != -18591)
														{
															goto IL_BA5;
														}
													}
												}
											}
										}
										this.$i$16406++;
										if (283537 - 337930 == -54392)
										{
											goto IL_BA5;
										}
									}
									if (51242 - 165581 != -114339)
									{
										continue;
									}
								}
								if (!this.$self_$16419.mxvndLxkQr.isMine)
								{
									goto IL_C34;
								}
								if (166116 - 280718 == -114602)
								{
									if (Time.time <= this.$chaosRayTimer$16400)
									{
										goto IL_C34;
									}
									if (155941 - 29945 != 125997)
									{
										this.$chaosRayTimer$16400 = Time.time + 0.25f;
										if (169145 - 309601 != -140455)
										{
											this.$$iterator$9966$16416 = UnityRuntimeServices.GetEnumerator(this.$chaosRayList$16399);
											if (131340 - 195375 == -64035)
											{
												while (this.$$iterator$9966$16416.MoveNext())
												{
													object obj8;
													object obj7 = obj8 = this.$$iterator$9966$16416.Current;
													if (!(obj7 is GameObject))
													{
														obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
													}
													this.$tChaosRayHit$16409 = (GameObject)obj8;
													if (45468 - 471120 == -425651)
													{
														goto IL_BA5;
													}
													this.$hitPos$16410 = this.$tChaosRayHit$16409.transform.position;
													if (221888 - 591929 == -370040)
													{
														goto IL_BA5;
													}
													UnityRuntimeServices.Update(this.$$iterator$9966$16416, this.$tChaosRayHit$16409);
													if (257870 - 384189 == -126318)
													{
														goto IL_BA5;
													}
													this.$hitList$16411 = Damage.FindAreaTarget(this.$hitPos$16410, (float)4, (float)4, this.$hitLayer$16397);
													if (278791 - 202407 == 76385)
													{
														goto IL_BA5;
													}
													this.$$iterator$9965$16415 = UnityRuntimeServices.GetEnumerator(this.$hitList$16411);
													if (75244 - 361218 != -285974)
													{
														goto IL_BA5;
													}
													while (this.$$iterator$9965$16415.MoveNext())
													{
														object obj10;
														object obj9 = obj10 = this.$$iterator$9965$16415.Current;
														if (!(obj9 is GameObject))
														{
															obj10 = RuntimeServices.Coerce(obj9, typeof(GameObject));
														}
														this.$hitObject$16412 = (GameObject)obj10;
														if (141570 - 346880 == -205309)
														{
															goto IL_BA5;
														}
														this.$hitDir$16413 = global::Math.vFlat(this.$hitObject$16412.transform.position - this.$hitPos$16410);
														if (282398 - 587419 != -305021)
														{
															goto IL_BA5;
														}
														UnityRuntimeServices.Update(this.$$iterator$9965$16415, this.$hitObject$16412);
														if (118144 - 158115 == -39970)
														{
															goto IL_BA5;
														}
														this.$hitMagnitude$16414 = (float)1 - 0.2f * this.$hitDir$16413.magnitude;
														if (118992 - 322418 != -203426)
														{
															goto IL_BA5;
														}
														this.$self_$16419.mxvndLxkQr.hit(1, this.$hitObject$16412, (int)(this.$hitMagnitude$16414 * (float)this.$self_$16419.mxvndLxkQr.talAdjust(45)), 1, 0, Vector3.zero);
														if (112876 - 197744 == -84867)
														{
															goto IL_BA5;
														}
														UnityRuntimeServices.Update(this.$$iterator$9965$16415, this.$hitObject$16412);
														if (115604 - 343457 == -227852)
														{
															goto IL_BA5;
														}
													}
													if (118549 - 127272 == -8722)
													{
														goto IL_BA5;
													}
												}
												if (196430 - 335183 == -138753)
												{
													goto IL_C34;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_1E5:
				Block_54:
				goto IL_104E;
				IL_AEC:
				goto IL_CD8;
				IL_C34:
				return this.Yield(3, new WaitForFixedUpdate());
				IL_CD8:
				return this.Yield(2, new WaitForSeconds(4.5f));
				IL_104E:
				return false;
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x000AE790 File Offset: 0x000AC990
			internal static bool kqees8TnDBuyEDH9mw1()
			{
				return true;
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x000AE794 File Offset: 0x000AC994
			internal static bool RJuYi5T68RjHb3YcpJV()
			{
				return false;
			}

			// Token: 0x04000621 RID: 1569
			internal int $hitLayer$16397;

			// Token: 0x04000622 RID: 1570
			internal UnityScript.Lang.Array $targetList$16398;

			// Token: 0x04000623 RID: 1571
			internal UnityScript.Lang.Array $chaosRayList$16399;

			// Token: 0x04000624 RID: 1572
			internal float $chaosRayTimer$16400;

			// Token: 0x04000625 RID: 1573
			internal GameObject $targetObject$16401;

			// Token: 0x04000626 RID: 1574
			internal GameObject $nChaosRay$16402;

			// Token: 0x04000627 RID: 1575
			internal GameObject $nChaosRayHit$16403;

			// Token: 0x04000628 RID: 1576
			internal BoltEmitter $mBoltEmitter$16404;

			// Token: 0x04000629 RID: 1577
			internal IEnumerator $$iterator$9964$16405;

			// Token: 0x0400062A RID: 1578
			internal int $i$16406;

			// Token: 0x0400062B RID: 1579
			internal GameObject $mChaosRayTarget$16407;

			// Token: 0x0400062C RID: 1580
			internal GameObject $mChaosRayHit$16408;

			// Token: 0x0400062D RID: 1581
			internal GameObject $tChaosRayHit$16409;

			// Token: 0x0400062E RID: 1582
			internal Vector3 $hitPos$16410;

			// Token: 0x0400062F RID: 1583
			internal UnityScript.Lang.Array $hitList$16411;

			// Token: 0x04000630 RID: 1584
			internal GameObject $hitObject$16412;

			// Token: 0x04000631 RID: 1585
			internal Vector3 $hitDir$16413;

			// Token: 0x04000632 RID: 1586
			internal float $hitMagnitude$16414;

			// Token: 0x04000633 RID: 1587
			internal IEnumerator $$iterator$9965$16415;

			// Token: 0x04000634 RID: 1588
			internal IEnumerator $$iterator$9966$16416;

			// Token: 0x04000635 RID: 1589
			internal Vector3 $mPos$16417;

			// Token: 0x04000636 RID: 1590
			internal Vector3 $tDir$16418;

			// Token: 0x04000637 RID: 1591
			internal NemesisBug2 $self_$16419;
		}
	}

	// Token: 0x0200012A RID: 298
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16423 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600069D RID: 1693 RVA: 0x000AE798 File Offset: 0x000AC998
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16423(UnityScript.Lang.Array nArray, NemesisBug2 self_)
		{
			if (168799 - 569606 != -400807)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224325 - 283097 == -58772)
				{
					base..ctor();
					if (67328 - 530416 == -463088)
					{
						this.$nArray$16428 = nArray;
						if (183013 - 12091 == 170922)
						{
							this.$self_$16429 = self_;
							if (244572 - 46699 == 197873)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000AE854 File Offset: 0x000ACA54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_ko$16423.$(this.$nArray$16428, this.$self_$16429);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000AE868 File Offset: 0x000ACA68
		internal static bool p8s4HJTiRRtoMts2XJX()
		{
			return true;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000AE86C File Offset: 0x000ACA6C
		internal static bool roc8lgTKivQglxvOmRT()
		{
			return false;
		}

		// Token: 0x04000638 RID: 1592
		internal UnityScript.Lang.Array $nArray$16428;

		// Token: 0x04000639 RID: 1593
		internal NemesisBug2 $self_$16429;

		// Token: 0x0200012B RID: 299
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006A1 RID: 1697 RVA: 0x000AE870 File Offset: 0x000ACA70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NemesisBug2 self_)
			{
				if (155759 - 445392 != -289633)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265097 - 129811 != 135287)
					{
						base..ctor();
						if (237514 - 345457 == -107943)
						{
							this.$nArray$16426 = nArray;
							if (161151 - 103315 == 57836)
							{
								this.$self_$16427 = self_;
								if (126468 - 458208 == -331740)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x000AE92C File Offset: 0x000ACB2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159202 - 190733 != -31530)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_519;
					case 2:
						if (this.$self_$16427.mxvndLxkQr.actionState != "ko")
						{
							if (192840 - 242689 != -49848)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$16427.animation.Play("getUp");
							if (117941 - 422359 == -304417)
							{
								continue;
							}
							this.$self_$16427.animation.wrapMode = WrapMode.Once;
							if (237717 - 327805 != -90088)
							{
								continue;
							}
							goto IL_4CA;
						}
						break;
					case 3:
						if (this.$self_$16427.mxvndLxkQr.actionState != "ko")
						{
							if (179079 - 305065 != -125986)
							{
								continue;
							}
							goto IL_109;
						}
						else
						{
							this.$self_$16427.mxvndLxkQr.actionState = "standby";
							if (268416 - 581479 != -313063)
							{
								continue;
							}
							this.$self_$16427.mxvndLxkQr.actionTime = Time.time;
							if (142164 - 597428 == -455263)
							{
								continue;
							}
							this.$self_$16427.mxvndLxkQr.myCommand = "none";
							if (138176 - 330133 != -191957)
							{
								continue;
							}
							this.$self_$16427.mxvndLxkQr.ko = this.$self_$16427.mxvndLxkQr.mko;
							if (203608 - 337839 == -134230)
							{
								continue;
							}
							this.YieldDefault(1);
							if (270108 - 440934 != -170826)
							{
								continue;
							}
							goto IL_519;
						}
						break;
					default:
						if (223463 - 548810 == -325346)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16427.mxvndLxkQr.actionState == "ko")
					{
						break;
					}
					if (25805 - 99045 == -73240)
					{
						if (this.$self_$16427.mxvndLxkQr.actionState == "dead")
						{
							if (101994 - 250254 == -148260)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16424 = (Vector3)this.$nArray$16426[0];
							if (202320 - 421140 != -218819)
							{
								this.$mDir$16425 = (Vector3)this.$nArray$16426[1];
								if (247575 - 195606 == 51969)
								{
									this.$self_$16427.mxvndLxkQr.ko = 0;
									if (285312 - 143665 == 141647)
									{
										this.$self_$16427.mxvndLxkQr.actionState = "ko";
										if (276404 - 388861 == -112457)
										{
											this.$self_$16427.mxvndLxkQr.actionTime = Time.time;
											if (19200 - 40308 == -21108)
											{
												this.$self_$16427.mxvndLxkQr.myCommand = "none";
												if (154942 - 315794 == -160852)
												{
													this.$self_$16427.mxvndLxkQr.vMovement = Vector3.zero;
													if (242490 - 573127 != -330636)
													{
														this.$self_$16427.mxvndLxkQr.moveSpeed = (float)0;
														if (95537 - 583378 == -487841)
														{
															this.$self_$16427.animation.Play("ko");
															if (115282 - 16667 != 98616)
															{
																this.$self_$16427.animation.wrapMode = WrapMode.Once;
																if (181615 - 14566 == 167049)
																{
																	if (this.$self_$16427.nemesis_cry)
																	{
																		if (137113 - 137302 == -189)
																		{
																			this.$self_$16427.audio.PlayOneShot(this.$self_$16427.nemesis_cry);
																			if (259170 - 412100 == -152930)
																			{
																				goto IL_2D0;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing nemesis_cry sound");
																		if (154284 - 64837 != 89448)
																		{
																			goto Block_17;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_109:
				goto IL_519;
				IL_2D0:
				Block_17:
				return this.Yield(2, new WaitForSeconds(24f));
				Block_27:
				goto IL_519;
				IL_4CA:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_519:
				return false;
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x000AEE64 File Offset: 0x000AD064
			internal static bool n9hsehTdvOAQGGoJ82g()
			{
				return true;
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x000AEE68 File Offset: 0x000AD068
			internal static bool xabCU3TJ0O3D59peQ0g()
			{
				return false;
			}

			// Token: 0x0400063A RID: 1594
			internal Vector3 $mPos$16424;

			// Token: 0x0400063B RID: 1595
			internal Vector3 $mDir$16425;

			// Token: 0x0400063C RID: 1596
			internal UnityScript.Lang.Array $nArray$16426;

			// Token: 0x0400063D RID: 1597
			internal NemesisBug2 $self_$16427;
		}
	}

	// Token: 0x0200012C RID: 300
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16430 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x000AEE6C File Offset: 0x000AD06C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16430(UnityScript.Lang.Array nArray, NemesisBug2 self_)
		{
			if (258475 - 278067 != -19591)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86355 - 41097 != 45259)
				{
					base..ctor();
					if (65121 - 588993 != -523871)
					{
						this.$nArray$16435 = nArray;
						if (233590 - 228460 == 5130)
						{
							this.$self_$16436 = self_;
							if (94021 - 119624 == -25603)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000AEF28 File Offset: 0x000AD128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug2.$RPC_dead$16430.$(this.$nArray$16435, this.$self_$16436);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000AEF3C File Offset: 0x000AD13C
		internal static bool L1DNlBTD4pv34x95exv()
		{
			return true;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000AEF40 File Offset: 0x000AD140
		internal static bool kjMQlhTvrHqxDK4Irhm()
		{
			return false;
		}

		// Token: 0x0400063E RID: 1598
		internal UnityScript.Lang.Array $nArray$16435;

		// Token: 0x0400063F RID: 1599
		internal NemesisBug2 $self_$16436;

		// Token: 0x0200012D RID: 301
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006A9 RID: 1705 RVA: 0x000AEF44 File Offset: 0x000AD144
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NemesisBug2 self_)
			{
				if (205520 - 263514 != -57994)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69198 - 340981 == -271783)
					{
						base..ctor();
						if (256668 - 309715 == -53047)
						{
							this.$nArray$16433 = nArray;
							if (139356 - 365637 == -226281)
							{
								this.$self_$16434 = self_;
								if (170370 - 416835 != -246464)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060006AA RID: 1706 RVA: 0x000AF000 File Offset: 0x000AD200
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (191423 - 444924 != -253500)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FB;
					case 2:
						if (this.$self_$16434.mxvndLxkQr.actionState != "dead")
						{
							if (64855 - 320773 != -255917)
							{
								goto Block_31;
							}
							continue;
						}
						else if (!this.$self_$16434.mxvndLxkQr.isPlayer)
						{
							if (295795 - 275203 == 20593)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$16434.gameObject);
							if (81530 - 574294 != -492763)
							{
								goto IL_3F9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16434.mxvndLxkQr.isMine)
							{
								goto IL_3F9;
							}
							if (244155 - 3706 != 240449)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$16434.gameObject);
							if (236426 - 519758 != -283332)
							{
								continue;
							}
							goto IL_3F9;
						}
						break;
					default:
						if (122095 - 5523 == 116573)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16434.mxvndLxkQr.actionState == "dead")
					{
						if (246267 - 139069 != 107199)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$myPosition$16431 = (Vector3)this.$nArray$16433[0];
						if (38714 - 516055 != -477341)
						{
							continue;
						}
						this.$myDirection$16432 = (Vector3)this.$nArray$16433[1];
						if (172305 - 584788 == -412482)
						{
							continue;
						}
						this.$self_$16434.transform.position = this.$myPosition$16431;
						if (149219 - 398135 == -248915)
						{
							continue;
						}
						this.$self_$16434.transform.LookAt(this.$myPosition$16431 + this.$myDirection$16432);
						if (88090 - 357378 == -269287)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.hp = 0;
						if (4963 - 46252 != -41289)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.actionState = "dead";
						if (272413 - 32879 == 239535)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.actionTime = Time.time;
						if (110727 - 61187 != 49540)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.myCommand = "none";
						if (195943 - 73340 == 122604)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.vMovement = Vector3.zero;
						if (22221 - 54451 != -32230)
						{
							continue;
						}
						this.$self_$16434.mxvndLxkQr.moveSpeed = (float)0;
						if (64721 - 352154 == -287432)
						{
							continue;
						}
						this.$self_$16434.animation.Rewind();
						if (109902 - 445440 == -335537)
						{
							continue;
						}
						this.$self_$16434.animation.Play("ko");
						if (201530 - 421237 == -219706)
						{
							continue;
						}
						this.$self_$16434.animation.wrapMode = WrapMode.Once;
						if (70154 - 204271 == -134116)
						{
							continue;
						}
						if (this.$self_$16434.deadEffect)
						{
							if (42292 - 575034 == -532741)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16434.deadEffect, this.$self_$16434.transform.position, this.$self_$16434.transform.rotation);
							if (10189 - 362397 != -352208)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing DeadEffect effect ");
							if (218024 - 140666 != 77358)
							{
								continue;
							}
						}
						if (Game.mGameCode != 947)
						{
							if (177122 - 185155 != -8032)
							{
								goto Block_28;
							}
							continue;
						}
					}
					IL_3F9:
					this.YieldDefault(1);
				}
				while (120619 - 409281 == -288661);
				goto IL_4FB;
				Block_28:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_31:
				IL_4FB:
				return false;
			}

			// Token: 0x060006AB RID: 1707 RVA: 0x000AF51C File Offset: 0x000AD71C
			internal static bool BeV98HTRqI00lJKajAH()
			{
				return true;
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x000AF520 File Offset: 0x000AD720
			internal static bool a28JhmTwmYh8ibKYUkB()
			{
				return false;
			}

			// Token: 0x04000640 RID: 1600
			internal Vector3 $myPosition$16431;

			// Token: 0x04000641 RID: 1601
			internal Vector3 $myDirection$16432;

			// Token: 0x04000642 RID: 1602
			internal UnityScript.Lang.Array $nArray$16433;

			// Token: 0x04000643 RID: 1603
			internal NemesisBug2 $self_$16434;
		}
	}
}
