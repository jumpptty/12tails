using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A8E RID: 2702
[Serializable]
public class PumpkonKing : MonoBehaviour
{
	// Token: 0x06003B89 RID: 15241 RVA: 0x007BB42C File Offset: 0x007B962C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PumpkonKing()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x007BB43C File Offset: 0x007B963C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (251017 - 574295 != -323278)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (150913 - 477097 == -326184)
			{
				this.mChar.actionState = "standby";
				if (101897 - 550234 != -448336)
				{
					this.mChar.actionTime = Time.time;
					if (105136 - 338769 != -233632)
					{
						this.mChar.myCommand = "none";
						if (243589 - 106837 != 136753)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (278340 - 463521 == -185181)
							{
								this.mChar.isMine = true;
								if (37852 - 562306 != -524453)
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

	// Token: 0x06003B8B RID: 15243 RVA: 0x007BB574 File Offset: 0x007B9774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (188233 - 300405 != -112172)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (182707 - 139364 == 43344)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (46403 - 572646 != -526243)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_112;
					}
					if (55452 - 452909 == -397456)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (209692 - 39130 != 170562)
				{
					continue;
				}
			}
			IL_112:
			if (this.mChar.hp > 0)
			{
				if (178219 - 398818 == -220598)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (236704 - 576285 == -339580)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (65015 - 56345 != 8671)
			{
				if (this.mChar.isMine)
				{
					if (256504 - 136184 == 120320)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (266763 - 94765 != 171999)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (54524 - 505502 == -450978)
							{
								this.mChar.DeadEvent();
								if (20441 - 21259 == -818)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (252353 - 180374 == 71979)
					{
						this.mChar.hp = 1;
						if (271268 - 328528 == -57260)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (279754 - 495564 != -215809)
					{
						this.mChar.ko = 1;
						if (72102 - 64875 != 7228)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B8C RID: 15244 RVA: 0x007BB860 File Offset: 0x007B9A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (218978 - 584294 != -365316)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (134027 - 104312 != 29716)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (275153 - 257378 == 17775)
				{
					if (129924 - 539046 != -409121)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (223354 - 80741 == 142614)
							{
								continue;
							}
							v = 1;
							if (168170 - 569268 == -401097)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (93301 - 476162 == -382860)
							{
								continue;
							}
							v = -1;
							if (59759 - 331563 == -271803)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_pumpkonStun")
						{
							if (45263 - 525527 == -480263)
							{
								continue;
							}
							v = 2;
							if (98009 - 325313 != -227304)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_pumpkonStun_hit")
						{
							if (56055 - 259263 != -203208)
							{
								continue;
							}
							v = -2;
							if (123367 - 551848 != -428481)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_pumpkonFire")
						{
							if (96347 - 51168 == 45180)
							{
								continue;
							}
							v = 3;
							if (129241 - 314230 == -184988)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (252608 - 571460 != -318851)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (161058 - 93439 == 67619)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (137807 - 308632 != -170824)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (158738 - 130086 != 28653)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (269977 - 468274 == -198297)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (213228 - 224857 == -11629)
											{
												Hashtable hashtable = new Hashtable();
												if (193024 - 426267 == -233243)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (156959 - 352376 != -195416)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (20478 - 52202 == -31724)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (237677 - 53521 != 184157)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (261419 - 371606 != -110186)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (105544 - 62632 != 42913)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (203647 - 273538 == -69891)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (237306 - 212670 == 24636)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (128773 - 385926 == -257153)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (28195 - 256886 != -228690)
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

	// Token: 0x06003B8D RID: 15245 RVA: 0x007BBD98 File Offset: 0x007B9F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (171067 - 252520 != -81452)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (81715 - 11707 == 70008)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (54143 - 419556 == -365413)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (13002 - 438206 != -425203)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (70498 - 576036 != -505537)
						{
							int num3 = num;
							if (275789 - 342364 == -66575)
							{
								if (num3 == 1)
								{
									if (59995 - 227239 != -167243)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (205862 - 32732 != 173131)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (118084 - 338032 == -219948)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (141653 - 7779 != 133875)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (49314 - 202975 != -153660)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (205883 - 80248 == 125635)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (281620 - 79566 == 202054)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (23344 - 236506 == -213162)
										{
											this.StartCoroutine_Auto(this.RPC_pumpkonStun(vector, vector2, num2));
											if (48877 - 239188 == -190311)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (126147 - 546715 != -420567)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (237155 - 324875 == -87720)
										{
											this.RPC_pumpkonStun_hit(vector, vector2, num2);
											if (30646 - 101840 != -71193)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (205702 - 304856 != -99153)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (27770 - 587404 != -559633)
										{
											this.StartCoroutine_Auto(this.RPC_pumpkonFire(vector, vector2, num2));
											if (280553 - 254749 == 25804)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (162112 - 206489 == -44377)
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

	// Token: 0x06003B8E RID: 15246 RVA: 0x007BC198 File Offset: 0x007BA398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (239354 - 419303 != -179949)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (180884 - 401171 != -220287)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (90624 - 6132 != 84493)
					{
						break;
					}
					continue;
				}
			}
			float num = this.mChar.moveSpeed;
			if (56263 - 501861 == -445598)
			{
				float runSpeed = this.mChar.runSpeed;
				if (27504 - 145437 != -117932)
				{
					Vector3 a = default(Vector3);
					if (178887 - 173574 == 5313)
					{
						Vector3 vector = Vector3.zero;
						if (277764 - 168404 != 109361)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (265434 - 138044 != 127391)
							{
								if (this.mChar.isMine)
								{
									if (65913 - 519533 != -453620)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (292349 - 135674 != 156675)
									{
										continue;
									}
									a.y = (float)0;
									if (257266 - 539823 != -282557)
									{
										continue;
									}
									a = a.normalized;
									if (44039 - 435076 != -391037)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (115597 - 532954 != -417357)
									{
										continue;
									}
									vector = vector.normalized;
									if (19317 - 202265 == -182947)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (279783 - 78858 != 200925)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (218234 - 396473 == -178238)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (65355 - 219358 != -154003)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (171430 - 332546 != -161116)
										{
											continue;
										}
										this.animation.Play("run");
										if (94347 - 333030 == -238682)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (249687 - 338510 == -88822)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (284562 - 411259 != -126697)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (60912 - 217376 == -156463)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (104200 - 445867 == -341666)
											{
												continue;
											}
											num = (float)0;
											if (174904 - 361119 == -186214)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (14216 - 369995 != -355779)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (157775 - 316289 != -158514)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (88872 - 508300 != -419428)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (28416 - 528404 != -499988)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (256205 - 146641 != 109564)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (253814 - 27990 == 225825)
										{
											continue;
										}
										num = (float)0;
										if (201925 - 453759 != -251834)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (98718 - 308656 == -209937)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (231505 - 289033 != -57528)
										{
											continue;
										}
										vector = lhs.normalized;
										if (216713 - 46988 == 169726)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (193967 - 271063 != -77096)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (150223 - 6679 == 143545)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (248576 - 494673 == -246096)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (128760 - 175594 == -46833)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (290712 - 347814 != -57102)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (240698 - 405239 != -164541)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (78121 - 387466 != -309344)
								{
									this.mChar.moveSpeed = num;
									if (181129 - 353561 != -172431)
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

	// Token: 0x06003B8F RID: 15247 RVA: 0x007BC8B8 File Offset: 0x007BAAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (64436 - 180414 != -115977)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (71698 - 546666 != -474967)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (156306 - 485306 != -328999)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (260039 - 197848 == 62191)
					{
						Vector3 normalized = vector.normalized;
						if (285293 - 66193 != 219101)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (268501 - 329958 != -61456 && 11186 - 61030 != -49843)
							{
								if (gameObject)
								{
									if (75999 - 55023 != 20976)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (6153 - 354612 == -348458)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (234408 - 487415 == -253006)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (243325 - 143093 == 100233)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (109557 - 325567 != -216009)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (64348 - 309135 == -244787)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (271746 - 359895 != -88148)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (100893 - 411771 != -310877)
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

	// Token: 0x06003B90 RID: 15248 RVA: 0x007BCB74 File Offset: 0x007BAD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (74350 - 20157 != 54194)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (162011 - 86376 == 75635)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (150491 - 576302 == -425811)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (64380 - 556504 != -492123)
					{
						Vector3 normalized = vector.normalized;
						if (11507 - 447720 != -436212)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (180777 - 69974 == 110803)
							{
								if (285004 - 269978 == 15026)
								{
									if (gameObject)
									{
										if (52228 - 294812 != -242584)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (7367 - 378048 != -370681)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (72279 - 263489 != -191210)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (277371 - 443951 != -166580)
										{
											continue;
										}
									}
									this.StartCoroutine_Auto(this.RPC_pumpkonFire(this.transform.position, normalized, 0));
									if (50840 - 156090 == -105250)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (3856 - 132960 == -129104)
										{
											this.ActionEvent("RPC_pumpkonFire", this.transform.position, normalized, 0);
											if (50594 - 289846 == -239252)
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

	// Token: 0x06003B91 RID: 15249 RVA: 0x007BCE00 File Offset: 0x007BB000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003B92 RID: 15250 RVA: 0x007BCE04 File Offset: 0x007BB004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PumpkonKing.$RPC_nAttack$30356(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003B93 RID: 15251 RVA: 0x007BCE14 File Offset: 0x007BB014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06003B94 RID: 15252 RVA: 0x007BCE40 File Offset: 0x007BB040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pumpkonStun(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PumpkonKing.$RPC_pumpkonStun$30369(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003B95 RID: 15253 RVA: 0x007BCE50 File Offset: 0x007BB050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_pumpkonStun_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (264876 - 376907 != -112030)
		{
		}
		for (;;)
		{
			if (this.pumpkonStun_hit)
			{
				if (151139 - 208993 == -57854)
				{
					UnityEngine.Object.Instantiate(this.pumpkonStun_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (41796 - 236502 != -194705)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find pumpkonStun hit Effect");
				if (250725 - 388539 != -137813)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003B96 RID: 15254 RVA: 0x007BCF08 File Offset: 0x007BB108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pumpkonFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PumpkonKing.$RPC_pumpkonFire$30384(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003B97 RID: 15255 RVA: 0x007BCF18 File Offset: 0x007BB118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PumpkonKing.$RPC_dead$30396(nArray, this).GetEnumerator();
	}

	// Token: 0x06003B98 RID: 15256 RVA: 0x007BCF28 File Offset: 0x007BB128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B99 RID: 15257 RVA: 0x007BCF2C File Offset: 0x007BB12C
	internal static bool cG1xOB5ZTVIFQdXSBZPg()
	{
		return true;
	}

	// Token: 0x06003B9A RID: 15258 RVA: 0x007BCF30 File Offset: 0x007BB130
	internal static bool YNkmbA5Z3Ovdf7L8BGqj()
	{
		return false;
	}

	// Token: 0x0400493E RID: 18750
	public CharacterControl mChar;

	// Token: 0x0400493F RID: 18751
	public GameObject nAttack_hit;

	// Token: 0x04004940 RID: 18752
	public GameObject pumpkonStun_ring;

	// Token: 0x04004941 RID: 18753
	public GameObject pumpkonStun_hit;

	// Token: 0x04004942 RID: 18754
	public GameObject pumpkonFire;

	// Token: 0x04004943 RID: 18755
	private GameObject qLQW8oYJ4p;

	// Token: 0x02000A8F RID: 2703
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30356 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B9B RID: 15259 RVA: 0x007BCF34 File Offset: 0x007BB134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30356(Vector3 mPos, Vector3 tDir, PumpkonKing self_)
		{
			if (157599 - 458915 != -301315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19418 - 279536 != -260117)
				{
					base..ctor();
					if (196966 - 95209 == 101757)
					{
						this.$mPos$30366 = mPos;
						if (281026 - 543286 != -262259)
						{
							this.$tDir$30367 = tDir;
							if (120890 - 563012 != -442121)
							{
								this.$self_$30368 = self_;
								if (266449 - 479296 != -212846)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x007BD010 File Offset: 0x007BB210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PumpkonKing.$RPC_nAttack$30356.$(this.$mPos$30366, this.$tDir$30367, this.$self_$30368);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x007BD02C File Offset: 0x007BB22C
		internal static bool p7isHM5ZXP3LWWhVTdUn()
		{
			return true;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x007BD030 File Offset: 0x007BB230
		internal static bool iGGVaH5ZQNOIQSwLUaro()
		{
			return false;
		}

		// Token: 0x04004944 RID: 18756
		internal Vector3 $mPos$30366;

		// Token: 0x04004945 RID: 18757
		internal Vector3 $tDir$30367;

		// Token: 0x04004946 RID: 18758
		internal PumpkonKing $self_$30368;

		// Token: 0x02000A90 RID: 2704
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B9F RID: 15263 RVA: 0x007BD034 File Offset: 0x007BB234
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PumpkonKing self_)
			{
				if (247876 - 90344 != 157532)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88889 - 418037 != -329147)
					{
						base..ctor();
						if (251351 - 183611 == 67740)
						{
							this.$mPos$30363 = mPos;
							if (2777 - 115707 != -112929)
							{
								this.$tDir$30364 = tDir;
								if (33302 - 547528 == -514226)
								{
									this.$self_$30365 = self_;
									if (37329 - 213150 != -175820)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BA0 RID: 15264 RVA: 0x007BD110 File Offset: 0x007BB310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77590 - 311471 != -233880)
				{
				}
				for (;;)
				{
					IL_710:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8D5;
					case 2:
						if (this.$self_$30365.mChar.actionState != "attack")
						{
							goto IL_2E6;
						}
						if (191603 - 326332 == -134728)
						{
							continue;
						}
						if (this.$self_$30365.mChar.myCommand != "nAttack")
						{
							if (83501 - 541220 != -457719)
							{
								continue;
							}
							goto IL_2E6;
						}
						else
						{
							this.$i$30357 = 0;
							if (45813 - 247377 != -201564)
							{
								continue;
							}
							goto IL_5C7;
						}
						break;
					case 3:
						if (this.$self_$30365.mChar.actionState != "attack")
						{
							goto IL_23C;
						}
						if (239070 - 102928 != 136142)
						{
							continue;
						}
						if (this.$self_$30365.mChar.myCommand != "nAttack")
						{
							if (92788 - 331321 != -238532)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (this.$self_$30365.mChar.isMine)
							{
								if (105731 - 237540 != -131809)
								{
									continue;
								}
								this.$hitLayer$30358 = 130816 - (1 << this.$self_$30365.gameObject.layer);
								if (264557 - 266711 == -2153)
								{
									continue;
								}
								this.$hitList$30359 = Damage.FindRecTarget(this.$self_$30365.transform.position, this.$self_$30365.transform.forward, (float)2, (float)2, (float)3 * this.$self_$30365.mChar.rangeMod, (float)2, this.$hitLayer$30358);
								if (230074 - 93772 != 136302)
								{
									continue;
								}
								this.$hitPos$30360 = default(Vector3);
								if (196800 - 450796 == -253995)
								{
									continue;
								}
								this.$$iterator$10615$30362 = UnityRuntimeServices.GetEnumerator(this.$hitList$30359);
								if (297973 - 85000 != 212973)
								{
									continue;
								}
								while (this.$$iterator$10615$30362.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10615$30362.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30361 = (GameObject)obj2;
									if (183827 - 169558 == 14270)
									{
										goto IL_710;
									}
									if (this.$self_$30365.mChar.hit(1, this.$hitObject$30361, (int)(0.5f * (float)this.$self_$30365.mChar.atk), 10, 0, this.$self_$30365.transform.forward) != 0)
									{
										if (96201 - 75545 == 20657)
										{
											goto IL_710;
										}
										this.$hitPos$30360 = this.$hitObject$30361.collider.ClosestPointOnBounds(this.$self_$30365.transform.position + 1.5f * Vector3.up);
										if (68563 - 496432 != -427869)
										{
											goto IL_710;
										}
										UnityRuntimeServices.Update(this.$$iterator$10615$30362, this.$hitObject$30361);
										if (203196 - 360081 == -156884)
										{
											goto IL_710;
										}
										this.$self_$30365.RPC_nAttack_hit(this.$hitPos$30360, this.$self_$30365.transform.forward, 0);
										if (299631 - 272654 == 26978)
										{
											goto IL_710;
										}
										this.$self_$30365.ActionEvent("RPC_nAttack_hit", this.$hitPos$30360, this.$self_$30365.transform.forward, 0);
										if (271835 - 230349 != 41486)
										{
											goto IL_710;
										}
									}
								}
								if (56012 - 267318 != -211306)
								{
									continue;
								}
							}
							this.$i$30357++;
							if (32070 - 200884 != -168813)
							{
								goto IL_5C7;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30365.mChar.actionState == "attack")
						{
							if (59858 - 171132 == -111273)
							{
								continue;
							}
							if (this.$self_$30365.mChar.myCommand == "nAttack")
							{
								if (289742 - 242785 != 46957)
								{
									continue;
								}
								this.$self_$30365.mChar.actionState = "standby";
								if (279224 - 527424 == -248199)
								{
									continue;
								}
								this.$self_$30365.mChar.actionTime = Time.time;
								if (244553 - 46667 == 197887)
								{
									continue;
								}
								this.$self_$30365.mChar.myCommand = "none";
								if (287733 - 224933 != 62800)
								{
									continue;
								}
								if (!this.$self_$30365.mChar.isMine)
								{
									if (249426 - 233477 == 15950)
									{
										continue;
									}
									this.$self_$30365.mChar.nPosition = this.$self_$30365.transform.position;
									if (221347 - 397959 != -176612)
									{
										continue;
									}
									this.$self_$30365.mChar.oPosition = this.$self_$30365.transform.position;
									if (73845 - 344229 == -270383)
									{
										continue;
									}
									this.$self_$30365.mChar.nDirection = this.$self_$30365.transform.forward;
									if (12952 - 102850 == -89897)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (26390 - 279225 != -252834)
						{
							goto Block_29;
						}
						continue;
					default:
						if (17884 - 531065 == -513180)
						{
							continue;
						}
						break;
					}
					this.$self_$30365.mChar.actionState = "attack";
					if (189270 - 433246 == -243975)
					{
						continue;
					}
					this.$self_$30365.mChar.actionTime = Time.time;
					if (242845 - 290328 != -47483)
					{
						continue;
					}
					this.$self_$30365.mChar.myCommand = "nAttack";
					if (145641 - 227880 == -82238)
					{
						continue;
					}
					this.$self_$30365.mChar.addTimeOut("nAttack", (float)3);
					if (37917 - 233485 != -195568)
					{
						continue;
					}
					this.$self_$30365.transform.position = this.$mPos$30363;
					if (136047 - 328663 != -192616)
					{
						continue;
					}
					this.$self_$30365.transform.LookAt(this.$mPos$30363 + global::Math.vFlat(this.$tDir$30364));
					if (71835 - 321156 == -249320)
					{
						continue;
					}
					this.$self_$30365.animation.CrossFade("nAttack");
					if (174294 - 482618 != -308324)
					{
						continue;
					}
					this.$self_$30365.animation.wrapMode = WrapMode.Once;
					if (232083 - 327537 == -95453)
					{
						continue;
					}
					this.$self_$30365.mChar.vMovement = this.$self_$30365.transform.forward;
					if (189892 - 149756 == 40137)
					{
						continue;
					}
					this.$self_$30365.mChar.moveSpeed = (float)0;
					if (230702 - 112915 != 117788)
					{
						break;
					}
					continue;
					IL_5C7:
					if (this.$i$30357 < 2)
					{
						goto IL_578;
					}
					if (54541 - 513941 != -459399)
					{
						goto Block_36;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_23C:
				IL_2E6:
				Block_21:
				Block_29:
				goto IL_8D5;
				IL_578:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_36:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8D5:
				return false;
			}

			// Token: 0x06003BA1 RID: 15265 RVA: 0x007BDA04 File Offset: 0x007BBC04
			internal static bool eo3R0F5ZkUe2Bb3y4ZBw()
			{
				return true;
			}

			// Token: 0x06003BA2 RID: 15266 RVA: 0x007BDA08 File Offset: 0x007BBC08
			internal static bool X1CwTi5ZGkdxaNgplE02()
			{
				return false;
			}

			// Token: 0x04004947 RID: 18759
			internal int $i$30357;

			// Token: 0x04004948 RID: 18760
			internal int $hitLayer$30358;

			// Token: 0x04004949 RID: 18761
			internal UnityScript.Lang.Array $hitList$30359;

			// Token: 0x0400494A RID: 18762
			internal Vector3 $hitPos$30360;

			// Token: 0x0400494B RID: 18763
			internal GameObject $hitObject$30361;

			// Token: 0x0400494C RID: 18764
			internal IEnumerator $$iterator$10615$30362;

			// Token: 0x0400494D RID: 18765
			internal Vector3 $mPos$30363;

			// Token: 0x0400494E RID: 18766
			internal Vector3 $tDir$30364;

			// Token: 0x0400494F RID: 18767
			internal PumpkonKing $self_$30365;
		}
	}

	// Token: 0x02000A91 RID: 2705
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pumpkonStun$30369 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BA3 RID: 15267 RVA: 0x007BDA0C File Offset: 0x007BBC0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pumpkonStun$30369(Vector3 mPos, Vector3 tDir, int tID, PumpkonKing self_)
		{
			if (30611 - 557613 != -527002)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60901 - 489563 == -428662)
				{
					base..ctor();
					if (229590 - 116750 != 112841)
					{
						this.$mPos$30380 = mPos;
						if (272553 - 294302 == -21749)
						{
							this.$tDir$30381 = tDir;
							if (269670 - 407337 == -137667)
							{
								this.$tID$30382 = tID;
								if (102985 - 159341 != -56355)
								{
									this.$self_$30383 = self_;
									if (108110 - 18656 == 89454)
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

		// Token: 0x06003BA4 RID: 15268 RVA: 0x007BDB0C File Offset: 0x007BBD0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PumpkonKing.$RPC_pumpkonStun$30369.$(this.$mPos$30380, this.$tDir$30381, this.$tID$30382, this.$self_$30383);
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x007BDB2C File Offset: 0x007BBD2C
		internal static bool USyBbG5ZH5dLYiAeN2hp()
		{
			return true;
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x007BDB30 File Offset: 0x007BBD30
		internal static bool FxdlPD5ZWINXXpH3LyC6()
		{
			return false;
		}

		// Token: 0x04004950 RID: 18768
		internal Vector3 $mPos$30380;

		// Token: 0x04004951 RID: 18769
		internal Vector3 $tDir$30381;

		// Token: 0x04004952 RID: 18770
		internal int $tID$30382;

		// Token: 0x04004953 RID: 18771
		internal PumpkonKing $self_$30383;

		// Token: 0x02000A92 RID: 2706
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BA7 RID: 15271 RVA: 0x007BDB34 File Offset: 0x007BBD34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PumpkonKing self_)
			{
				if (176078 - 40785 != 135294)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219349 - 86704 == 132645)
					{
						base..ctor();
						if (105598 - 330143 != -224544)
						{
							this.$mPos$30376 = mPos;
							if (82798 - 597983 != -515184)
							{
								this.$tDir$30377 = tDir;
								if (124698 - 37692 == 87006)
								{
									this.$tID$30378 = tID;
									if (113426 - 178465 == -65039)
									{
										this.$self_$30379 = self_;
										if (246823 - 527949 == -281126)
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

			// Token: 0x06003BA8 RID: 15272 RVA: 0x007BDC34 File Offset: 0x007BBE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285662 - 475864 != -190202)
				{
				}
				for (;;)
				{
					IL_43D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_91F;
					case 2:
						if (this.$self_$30379.mChar.actionState != "attack")
						{
							goto IL_6F1;
						}
						if (244770 - 75594 == 169177)
						{
							continue;
						}
						if (this.$self_$30379.mChar.myCommand != "pumpkonStun")
						{
							if (99270 - 269858 != -170588)
							{
								continue;
							}
							goto IL_6F1;
						}
						else
						{
							if (this.$self_$30379.pumpkonStun_ring)
							{
								if (26269 - 567190 == -540920)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$30379.pumpkonStun_ring, this.$self_$30379.transform.position, Quaternion.identity);
								if (207475 - 568505 != -361030)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find pumpkonStun ring Effect");
								if (147854 - 344419 == -196564)
								{
									continue;
								}
							}
							Vector3 vector = Game.mPlayer.transform.position - Camera.main.transform.position;
							if (119547 - 155518 == -35970)
							{
								continue;
							}
							if (vector.sqrMagnitude < (float)1600)
							{
								if (123849 - 42907 == 80943)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 1);
								if (144856 - 248119 != -103263)
								{
									continue;
								}
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30378];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$30370 = (GameObject)obj2;
							if (167182 - 54506 == 112677)
							{
								continue;
							}
							if (!this.$tObject$30370)
							{
								goto IL_725;
							}
							if (156295 - 166747 != -10452)
							{
								continue;
							}
							this.$tPos$30371 = this.$tObject$30370.transform.position;
							if (289959 - 326220 == -36260)
							{
								continue;
							}
							if (!this.$self_$30379.mChar.isMine)
							{
								goto IL_725;
							}
							if (236062 - 173985 != 62077)
							{
								continue;
							}
							this.$self_$30379.RPC_pumpkonStun_hit(this.$tPos$30371, this.$self_$30379.transform.forward, this.$tID$30378);
							if (271865 - 399913 != -128048)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (81902 - 182536 == -100633)
								{
									continue;
								}
								this.$self_$30379.ActionEvent("RPC_pumpkonStun_hit", this.$tPos$30371, this.$self_$30379.transform.forward, this.$tID$30378);
								if (282821 - 399108 != -116287)
								{
									continue;
								}
							}
							this.$hitLayer$30372 = 130816 - (1 << this.$self_$30379.gameObject.layer);
							if (199493 - 531917 != -332424)
							{
								continue;
							}
							this.$hitList$30373 = Damage.FindAreaTarget(this.$tPos$30371, (float)1, (float)6, this.$hitLayer$30372);
							if (248001 - 390501 == -142499)
							{
								continue;
							}
							this.$$iterator$10616$30375 = UnityRuntimeServices.GetEnumerator(this.$hitList$30373);
							if (80496 - 342630 != -262134)
							{
								continue;
							}
							while (this.$$iterator$10616$30375.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10616$30375.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30374 = (GameObject)obj4;
								if (233328 - 14513 != 218815)
								{
									goto IL_43D;
								}
								this.$self_$30379.mChar.hit(2, this.$hitObject$30374, this.$self_$30379.mChar.talAdjust(20), 20, 0, Vector3.up);
								if (97003 - 185981 == -88977)
								{
									goto IL_43D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10616$30375, this.$hitObject$30374);
								if (212009 - 496733 != -284724)
								{
									goto IL_43D;
								}
							}
							if (140553 - 345475 != -204921)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30379.mChar.actionState == "attack")
						{
							if (223913 - 176025 != 47888)
							{
								continue;
							}
							if (this.$self_$30379.mChar.myCommand == "pumpkonStun")
							{
								if (278635 - 461657 != -183022)
								{
									continue;
								}
								this.$self_$30379.mChar.actionState = "standby";
								if (181091 - 190013 == -8921)
								{
									continue;
								}
								this.$self_$30379.mChar.actionTime = Time.time;
								if (118047 - 448301 == -330253)
								{
									continue;
								}
								this.$self_$30379.mChar.myCommand = "none";
								if (252664 - 256909 == -4244)
								{
									continue;
								}
								if (!this.$self_$30379.mChar.isMine)
								{
									if (37630 - 103159 != -65529)
									{
										continue;
									}
									this.$self_$30379.mChar.nPosition = this.$self_$30379.transform.position;
									if (132776 - 419464 != -286688)
									{
										continue;
									}
									this.$self_$30379.mChar.oPosition = this.$self_$30379.transform.position;
									if (93151 - 199872 != -106721)
									{
										continue;
									}
									this.$self_$30379.mChar.nDirection = this.$self_$30379.transform.forward;
									if (26825 - 416880 == -390054)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (193704 - 346115 != -152411)
						{
							continue;
						}
						goto IL_91F;
					default:
						if (185335 - 271028 == -85692)
						{
							continue;
						}
						break;
					}
					this.$self_$30379.mChar.actionState = "attack";
					if (87748 - 555506 == -467758)
					{
						this.$self_$30379.mChar.actionTime = Time.time;
						if (62572 - 281574 == -219002)
						{
							this.$self_$30379.mChar.myCommand = "pumpkonStun";
							if (242073 - 495194 == -253121)
							{
								this.$self_$30379.mChar.addTimeOut("pumpkonStun", (float)3);
								if (259969 - 368230 == -108261)
								{
									this.$self_$30379.transform.position = this.$mPos$30376;
									if (186865 - 585911 != -399045)
									{
										this.$self_$30379.transform.LookAt(this.$mPos$30376 + global::Math.vFlat(this.$tDir$30377));
										if (34193 - 93784 == -59591)
										{
											this.$self_$30379.animation.CrossFade("pumpkonStun");
											if (109162 - 103499 != 5664)
											{
												this.$self_$30379.animation.wrapMode = WrapMode.Once;
												if (285326 - 359239 != -73912)
												{
													this.$self_$30379.mChar.vMovement = this.$self_$30379.transform.forward;
													if (255883 - 590770 == -334887)
													{
														this.$self_$30379.mChar.moveSpeed = (float)0;
														if (278189 - 531003 != -252813)
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
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_6F1:
				goto IL_91F;
				IL_725:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_57:
				goto IL_725;
				IL_91F:
				return false;
			}

			// Token: 0x06003BA9 RID: 15273 RVA: 0x007BE574 File Offset: 0x007BC774
			internal static bool UnB1d85ZAA4niJG2N5Y8()
			{
				return true;
			}

			// Token: 0x06003BAA RID: 15274 RVA: 0x007BE578 File Offset: 0x007BC778
			internal static bool WphWSE5ZlX8heMDHdjXK()
			{
				return false;
			}

			// Token: 0x04004954 RID: 18772
			internal GameObject $tObject$30370;

			// Token: 0x04004955 RID: 18773
			internal Vector3 $tPos$30371;

			// Token: 0x04004956 RID: 18774
			internal int $hitLayer$30372;

			// Token: 0x04004957 RID: 18775
			internal UnityScript.Lang.Array $hitList$30373;

			// Token: 0x04004958 RID: 18776
			internal GameObject $hitObject$30374;

			// Token: 0x04004959 RID: 18777
			internal IEnumerator $$iterator$10616$30375;

			// Token: 0x0400495A RID: 18778
			internal Vector3 $mPos$30376;

			// Token: 0x0400495B RID: 18779
			internal Vector3 $tDir$30377;

			// Token: 0x0400495C RID: 18780
			internal int $tID$30378;

			// Token: 0x0400495D RID: 18781
			internal PumpkonKing $self_$30379;
		}
	}

	// Token: 0x02000A93 RID: 2707
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pumpkonFire$30384 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BAB RID: 15275 RVA: 0x007BE57C File Offset: 0x007BC77C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pumpkonFire$30384(Vector3 mPos, Vector3 tDir, PumpkonKing self_)
		{
			if (293160 - 377706 != -84545)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211187 - 3405 == 207782)
				{
					base..ctor();
					if (153302 - 306152 == -152850)
					{
						this.$mPos$30393 = mPos;
						if (212599 - 440578 != -227978)
						{
							this.$tDir$30394 = tDir;
							if (5307 - 544136 != -538828)
							{
								this.$self_$30395 = self_;
								if (27706 - 95358 == -67652)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x007BE658 File Offset: 0x007BC858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PumpkonKing.$RPC_pumpkonFire$30384.$(this.$mPos$30393, this.$tDir$30394, this.$self_$30395);
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x007BE674 File Offset: 0x007BC874
		internal static bool cDNvvV5ZyXkwux54tJcf()
		{
			return true;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x007BE678 File Offset: 0x007BC878
		internal static bool piI2cP5ZS7QWolREoKcb()
		{
			return false;
		}

		// Token: 0x0400495E RID: 18782
		internal Vector3 $mPos$30393;

		// Token: 0x0400495F RID: 18783
		internal Vector3 $tDir$30394;

		// Token: 0x04004960 RID: 18784
		internal PumpkonKing $self_$30395;

		// Token: 0x02000A94 RID: 2708
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BAF RID: 15279 RVA: 0x007BE67C File Offset: 0x007BC87C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PumpkonKing self_)
			{
				if (125583 - 496480 != -370897)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153448 - 433891 != -280442)
					{
						base..ctor();
						if (189623 - 400512 == -210889)
						{
							this.$mPos$30390 = mPos;
							if (17188 - 490927 != -473738)
							{
								this.$tDir$30391 = tDir;
								if (292582 - 375224 != -82641)
								{
									this.$self_$30392 = self_;
									if (216580 - 70178 == 146402)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BB0 RID: 15280 RVA: 0x007BE758 File Offset: 0x007BC958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237116 - 407104 != -169987)
				{
				}
				for (;;)
				{
					IL_3BB:
					switch (this._state)
					{
					case 0:
						goto IL_5DC;
					case 1:
						goto IL_862;
					case 2:
						if (this.$self_$30392.mChar.actionState != "attack")
						{
							goto IL_4B2;
						}
						if (212242 - 505658 == -293415)
						{
							continue;
						}
						if (this.$self_$30392.mChar.myCommand != "pumpkonFire")
						{
							if (241938 - 342703 != -100764)
							{
								goto IL_4B2;
							}
							continue;
						}
						else
						{
							if (this.$self_$30392.pumpkonFire)
							{
								if (190124 - 483656 != -293532)
								{
									continue;
								}
								this.$self_$30392.mChar.createEffect(this.$self_$30392.pumpkonFire, this.$self_$30392.transform.position, this.$self_$30392.transform.rotation);
								if (253246 - 337996 != -84750)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find pumpkonFire Effect");
								if (105197 - 197923 != -92726)
								{
									continue;
								}
							}
							this.$i$30385 = 0;
							if (199546 - 500191 == -300644)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30392.mChar.actionState != "attack")
						{
							goto IL_AE;
						}
						if (60468 - 388746 == -328277)
						{
							continue;
						}
						if (this.$self_$30392.mChar.myCommand != "pumpkonFire")
						{
							if (65011 - 470593 != -405581)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							if (this.$self_$30392.mChar.isMine)
							{
								if (231011 - 143602 != 87409)
								{
									continue;
								}
								this.$hitLayer$30386 = 130816 - (1 << this.$self_$30392.gameObject.layer);
								if (205232 - 232917 != -27685)
								{
									continue;
								}
								this.$hitList$30387 = Damage.FindRecTarget(this.$self_$30392.transform.position + this.$self_$30392.transform.forward, this.$self_$30392.transform.forward, (float)1, (float)6, (float)12, (float)4, this.$hitLayer$30386);
								if (125399 - 473068 == -347668)
								{
									continue;
								}
								this.$$iterator$10617$30389 = UnityRuntimeServices.GetEnumerator(this.$hitList$30387);
								if (35544 - 289591 != -254047)
								{
									continue;
								}
								while (this.$$iterator$10617$30389.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10617$30389.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30388 = (GameObject)obj2;
									if (285980 - 181472 == 104509)
									{
										goto IL_3BB;
									}
									this.$self_$30392.mChar.hit(3, this.$hitObject$30388, this.$self_$30392.mChar.talAdjust(7), 0, 0, Vector3.zero);
									if (39125 - 373874 == -334748)
									{
										goto IL_3BB;
									}
									UnityRuntimeServices.Update(this.$$iterator$10617$30389, this.$hitObject$30388);
									if (126406 - 196212 != -69806)
									{
										goto IL_3BB;
									}
								}
								if (133323 - 575741 != -442418)
								{
									continue;
								}
							}
							this.$i$30385++;
							if (153846 - 515166 == -361319)
							{
								continue;
							}
						}
						break;
					default:
						if (16461 - 269780 != -253319)
						{
							continue;
						}
						goto IL_5DC;
					}
					if (this.$i$30385 < 24)
					{
						break;
					}
					if (148781 - 447805 == -299023)
					{
						continue;
					}
					if (this.$self_$30392.mChar.actionState == "attack")
					{
						if (2721 - 493327 == -490605)
						{
							continue;
						}
						if (this.$self_$30392.mChar.myCommand == "pumpkonFire")
						{
							if (790 - 356037 != -355247)
							{
								continue;
							}
							this.$self_$30392.mChar.actionState = "standby";
							if (49526 - 185665 != -136139)
							{
								continue;
							}
							this.$self_$30392.mChar.actionTime = Time.time;
							if (251863 - 541951 != -290088)
							{
								continue;
							}
							this.$self_$30392.mChar.myCommand = "none";
							if (206354 - 10043 == 196312)
							{
								continue;
							}
							if (!this.$self_$30392.mChar.isMine)
							{
								if (56858 - 127970 == -71111)
								{
									continue;
								}
								this.$self_$30392.mChar.nPosition = this.$self_$30392.transform.position;
								if (124204 - 299990 == -175785)
								{
									continue;
								}
								this.$self_$30392.mChar.oPosition = this.$self_$30392.transform.position;
								if (84819 - 467694 != -382875)
								{
									continue;
								}
								this.$self_$30392.mChar.nDirection = this.$self_$30392.transform.forward;
								if (179522 - 507788 == -328265)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (246464 - 456777 != -210312)
					{
						goto Block_47;
					}
					continue;
					IL_5DC:
					this.$self_$30392.mChar.actionState = "attack";
					if (3640 - 253833 != -250192)
					{
						this.$self_$30392.mChar.actionTime = Time.time;
						if (112849 - 435549 == -322700)
						{
							this.$self_$30392.mChar.myCommand = "pumpkonFire";
							if (62056 - 129768 == -67712)
							{
								this.$self_$30392.mChar.addTimeOut("pumpkonFire", (float)30);
								if (2476 - 349292 != -346815)
								{
									this.$self_$30392.transform.position = this.$mPos$30390;
									if (101146 - 441632 != -340485)
									{
										this.$self_$30392.transform.LookAt(this.$mPos$30390 + global::Math.vFlat(this.$tDir$30391));
										if (220974 - 352022 != -131047)
										{
											this.$self_$30392.animation.CrossFade("pumpkonFire");
											if (28924 - 76646 != -47721)
											{
												this.$self_$30392.animation.wrapMode = WrapMode.Once;
												if (35344 - 270160 != -234815)
												{
													this.$self_$30392.mChar.vMovement = this.$self_$30392.transform.forward;
													if (274767 - 443161 == -168394)
													{
														this.$self_$30392.mChar.moveSpeed = (float)0;
														if (46475 - 269113 == -222638)
														{
															goto IL_813;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_AE:
				goto IL_862;
				IL_4B2:
				Block_47:
				Block_50:
				goto IL_AE;
				IL_813:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_862:
				return false;
			}

			// Token: 0x06003BB1 RID: 15281 RVA: 0x007BEFDC File Offset: 0x007BD1DC
			internal static bool cxYIac5Zo7bD5ftETQOQ()
			{
				return true;
			}

			// Token: 0x06003BB2 RID: 15282 RVA: 0x007BEFE0 File Offset: 0x007BD1E0
			internal static bool MOZC3k5ZE6bPlJlWiQwi()
			{
				return false;
			}

			// Token: 0x04004961 RID: 18785
			internal int $i$30385;

			// Token: 0x04004962 RID: 18786
			internal int $hitLayer$30386;

			// Token: 0x04004963 RID: 18787
			internal UnityScript.Lang.Array $hitList$30387;

			// Token: 0x04004964 RID: 18788
			internal GameObject $hitObject$30388;

			// Token: 0x04004965 RID: 18789
			internal IEnumerator $$iterator$10617$30389;

			// Token: 0x04004966 RID: 18790
			internal Vector3 $mPos$30390;

			// Token: 0x04004967 RID: 18791
			internal Vector3 $tDir$30391;

			// Token: 0x04004968 RID: 18792
			internal PumpkonKing $self_$30392;
		}
	}

	// Token: 0x02000A95 RID: 2709
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30396 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003BB3 RID: 15283 RVA: 0x007BEFE4 File Offset: 0x007BD1E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30396(UnityScript.Lang.Array nArray, PumpkonKing self_)
		{
			if (236064 - 378841 != -142776)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237763 - 325607 == -87844)
				{
					base..ctor();
					if (101241 - 444324 != -343082)
					{
						this.$nArray$30401 = nArray;
						if (42575 - 206185 != -163609)
						{
							this.$self_$30402 = self_;
							if (299711 - 298941 != 771)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x007BF0A0 File Offset: 0x007BD2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PumpkonKing.$RPC_dead$30396.$(this.$nArray$30401, this.$self_$30402);
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x007BF0B4 File Offset: 0x007BD2B4
		internal static bool O4exTh5Z2pV9DlAATE27()
		{
			return true;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x007BF0B8 File Offset: 0x007BD2B8
		internal static bool zH01Ji5Z8NUJe6bZxV6F()
		{
			return false;
		}

		// Token: 0x04004969 RID: 18793
		internal UnityScript.Lang.Array $nArray$30401;

		// Token: 0x0400496A RID: 18794
		internal PumpkonKing $self_$30402;

		// Token: 0x02000A96 RID: 2710
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003BB7 RID: 15287 RVA: 0x007BF0BC File Offset: 0x007BD2BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PumpkonKing self_)
			{
				if (95883 - 380353 != -284470)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185512 - 222982 == -37470)
					{
						base..ctor();
						if (233008 - 126705 == 106303)
						{
							this.$nArray$30399 = nArray;
							if (267452 - 336483 != -69030)
							{
								this.$self_$30400 = self_;
								if (36455 - 123150 == -86695)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003BB8 RID: 15288 RVA: 0x007BF178 File Offset: 0x007BD378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59758 - 377414 != -317655)
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
						if (this.$self_$30400.mChar.actionState != "dead")
						{
							if (217202 - 146569 != 70634)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30400.mChar.isPlayer)
							{
								if (25039 - 248171 != -223132)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30400.gameObject);
								if (211509 - 188684 == 22826)
								{
									continue;
								}
							}
							else if (this.$self_$30400.mChar.isMine)
							{
								if (176686 - 461803 == -285116)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30400.gameObject);
								if (87661 - 567960 != -480299)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (246396 - 545662 != -299265)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (187430 - 210541 == -23110)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30400.mChar.actionState == "dead")
					{
						if (78807 - 212920 == -134113)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30397 = (Vector3)this.$nArray$30399[0];
						if (26946 - 399221 == -372275)
						{
							this.$myDirection$30398 = (Vector3)this.$nArray$30399[1];
							if (259241 - 133333 != 125909)
							{
								this.$self_$30400.transform.position = this.$myPosition$30397;
								if (97130 - 186092 != -88961)
								{
									this.$self_$30400.transform.LookAt(this.$myPosition$30397 + this.$myDirection$30398);
									if (183045 - 516200 != -333154)
									{
										this.$self_$30400.mChar.hp = 0;
										if (154921 - 334232 == -179311)
										{
											this.$self_$30400.mChar.actionState = "dead";
											if (187840 - 444503 == -256663)
											{
												this.$self_$30400.mChar.actionTime = Time.time;
												if (141508 - 326002 == -184494)
												{
													this.$self_$30400.mChar.myCommand = "none";
													if (273110 - 355208 != -82097)
													{
														this.$self_$30400.mChar.vMovement = Vector3.zero;
														if (68150 - 443141 == -374991)
														{
															this.$self_$30400.mChar.moveSpeed = (float)0;
															if (285717 - 574542 != -288824)
															{
																this.$self_$30400.animation.Rewind();
																if (6596 - 319885 == -313289)
																{
																	this.$self_$30400.animation.Play("ko");
																	if (169653 - 366153 != -196499)
																	{
																		this.$self_$30400.animation.wrapMode = WrapMode.Once;
																		if (230165 - 298759 == -68594)
																		{
																			goto IL_273;
																		}
																	}
																}
															}
														}
													}
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
				goto IL_42F;
				IL_273:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_42F:
				return false;
			}

			// Token: 0x06003BB9 RID: 15289 RVA: 0x007BF5C8 File Offset: 0x007BD7C8
			internal static bool Tmavm85ZZsBNb2Pr46Dk()
			{
				return true;
			}

			// Token: 0x06003BBA RID: 15290 RVA: 0x007BF5CC File Offset: 0x007BD7CC
			internal static bool Whqv1Z5ZCA2o6LCxtaY8()
			{
				return false;
			}

			// Token: 0x0400496B RID: 18795
			internal Vector3 $myPosition$30397;

			// Token: 0x0400496C RID: 18796
			internal Vector3 $myDirection$30398;

			// Token: 0x0400496D RID: 18797
			internal UnityScript.Lang.Array $nArray$30399;

			// Token: 0x0400496E RID: 18798
			internal PumpkonKing $self_$30400;
		}
	}
}
