using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E3D RID: 3645
[Serializable]
public class Menalisa_AI : MonoBehaviour
{
	// Token: 0x06005271 RID: 21105 RVA: 0x00A0F248 File Offset: 0x00A0D448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Menalisa_AI()
	{
		if (146442 - 226050 != -79608)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (210069 - 284542 == -74473)
			{
				base..ctor();
				if (273172 - 171339 == 101833)
				{
					this.AI_state = "none";
					if (64617 - 12158 != 52460)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005272 RID: 21106 RVA: 0x00A0F2E4 File Offset: 0x00A0D4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ahscey2Xbje = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.lAEceVp3PVv = (Menalisa)this.GetComponent(typeof(Menalisa));
	}

	// Token: 0x06005273 RID: 21107 RVA: 0x00A0F31C File Offset: 0x00A0D51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (23460 - 397554 != -374093)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (81035 - 280913 != -199878)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (212129 - 459087 == -246957)
				{
					continue;
				}
			}
			if (this.ahscey2Xbje.isControlled)
			{
				break;
			}
			if (255633 - 179018 != 76616)
			{
				this.AIControl();
				if (67478 - 459353 == -391875)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005274 RID: 21108 RVA: 0x00A0F3E8 File Offset: 0x00A0D5E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (179488 - 134507 != 44981)
		{
		}
		for (;;)
		{
			this.FWLceK9hMHl = (float)0;
			if (210668 - 234907 == -24239)
			{
				if (this.ahscey2Xbje.isMine)
				{
					if (166804 - 47929 != 118876)
					{
						if (this.ahscey2Xbje.actionState != "standby")
						{
							if (95846 - 240988 != -145142)
							{
								continue;
							}
							if (this.ahscey2Xbje.actionState != "run")
							{
								if (190816 - 441354 != -250538)
								{
									continue;
								}
								break;
							}
						}
						if (!this.ahscey2Xbje.isAlert)
						{
							if (20159 - 40384 != -20224)
							{
								this.AI_idle(2f, 1f);
								if (166386 - 9248 == 157138)
								{
									this.AI_patrol(3f, 2f);
									if (132000 - 78313 == 53687)
									{
										this.AI_resetTimer();
										if (240932 - 380489 == -139557)
										{
											this.AI_visionCheck();
											if (56350 - 133398 == -77048)
											{
												if (!this.ahscey2Xbje.myAttackTarget)
												{
													break;
												}
												if (95291 - 483509 != -388217)
												{
													this.ahscey2Xbje.isAlert = true;
													if (221304 - 245454 == -24150)
													{
														this.MfVcehV8gCj = Time.time;
														if (246033 - 401359 == -155326)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (246006 - 352687 != -106680)
							{
								this.AI_patrol(3f, 2f);
								if (15390 - 437984 == -422594)
								{
									this.AI_attack(7f, (float)0);
									if (208483 - 404365 == -195882)
									{
										this.AI_resetTimer();
										if (264616 - 258166 == 6450)
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
					if (this.ahscey2Xbje.actionState != "standby")
					{
						if (285826 - 225516 != 60310)
						{
							continue;
						}
						if (this.ahscey2Xbje.actionState != "run")
						{
							if (68945 - 574715 != -505769)
							{
								break;
							}
							continue;
						}
					}
					float num = this.ahscey2Xbje.moveSpeed;
					if (284378 - 233068 != 51311)
					{
						float runSpeed = this.ahscey2Xbje.runSpeed;
						if (267362 - 180301 != 87062)
						{
							Vector3 vector = default(Vector3);
							if (222656 - 251613 == -28957)
							{
								Vector3 vector2 = Vector3.zero;
								if (285587 - 180251 != 105337)
								{
									if ((this.ahscey2Xbje.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (246552 - 444202 != -197650)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ahscey2Xbje.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (140002 - 315334 != -175332)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (216988 - 264779 == -47790)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (292650 - 33799 != 258851)
											{
												continue;
											}
											num = (float)0;
											if (226871 - 553574 != -326703)
											{
												continue;
											}
											this.transform.position = this.ahscey2Xbje.nPosition;
											if (191584 - 386073 != -194489)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (292669 - 431416 != -138747)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (88050 - 165874 != -77824)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (127438 - 113609 == 13830)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (141662 - 559905 == -418242)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (114627 - 29797 == 84831)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (244824 - 130443 != 114381)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (93832 - 499705 != -405873)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (27526 - 469911 != -442385)
											{
												continue;
											}
										}
									}
									this.ahscey2Xbje.vMovement = vector2;
									if (6776 - 589221 == -582445)
									{
										this.ahscey2Xbje.moveSpeed = num;
										if (42151 - 234674 == -192523)
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

	// Token: 0x06005275 RID: 21109 RVA: 0x00A0FA60 File Offset: 0x00A0DC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (78780 - 538597 != -459817)
		{
		}
		do
		{
			if (Time.time - this.MfVcehV8gCj >= this.FWLceK9hMHl)
			{
				if (172254 - 72902 == 99353)
				{
					continue;
				}
				if (Time.time - this.MfVcehV8gCj < this.FWLceK9hMHl + mTime)
				{
					if (101155 - 95585 != 5570)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (125942 - 416477 != -290535)
						{
							continue;
						}
						this.AI_state = "idle";
						if (208887 - 67529 != 141358)
						{
							continue;
						}
						this.MfVcehV8gCj -= UnityEngine.Random.Range((float)0, rTimer);
						if (150362 - 118567 == 31796)
						{
							continue;
						}
						this.ahscey2Xbje.vDirection = Vector3.zero;
						if (166619 - 273266 != -106647)
						{
							continue;
						}
						this.ahscey2Xbje.vMovement = this.transform.forward;
						if (224544 - 162803 != 61741)
						{
							continue;
						}
						this.ahscey2Xbje.actionState = "standby";
						if (194742 - 591627 != -396885)
						{
							continue;
						}
					}
					this.ahscey2Xbje.moveSpeed = Mathf.Lerp(this.ahscey2Xbje.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (153619 - 197692 == -44072)
					{
						continue;
					}
					if (this.ahscey2Xbje.moveSpeed < 0.1f * this.ahscey2Xbje.runSpeed)
					{
						if (282826 - 466529 != -183703)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (60389 - 1139 == 59251)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (284847 - 307411 != -22564)
						{
							continue;
						}
						this.ahscey2Xbje.moveSpeed = (float)0;
						if (54791 - 194476 == -139684)
						{
							continue;
						}
					}
				}
			}
			this.FWLceK9hMHl += mTime;
		}
		while (250335 - 564753 != -314418);
	}

	// Token: 0x06005276 RID: 21110 RVA: 0x00A0FD24 File Offset: 0x00A0DF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (108447 - 27441 != 81007)
		{
		}
		do
		{
			if (Time.time - this.MfVcehV8gCj >= this.FWLceK9hMHl)
			{
				if (273298 - 529644 == -256345)
				{
					continue;
				}
				if (Time.time - this.MfVcehV8gCj < this.FWLceK9hMHl + mTime)
				{
					if (262125 - 303117 == -40991)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (27019 - 435159 != -408140)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (69189 - 207283 != -138094)
						{
							continue;
						}
						this.MfVcehV8gCj -= UnityEngine.Random.Range((float)0, rTimer);
						if (217421 - 501184 != -283763)
						{
							continue;
						}
						this.ahscey2Xbje.vDirection = this.ahscey2Xbje.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (199419 - 188751 == 10669)
						{
							continue;
						}
						this.ahscey2Xbje.vDirection.y = this.transform.position.y;
						if (30271 - 554856 == -524584)
						{
							continue;
						}
						this.ahscey2Xbje.vMovement = (this.ahscey2Xbje.vDirection - this.transform.position).normalized;
						if (82300 - 583536 != -501236)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ahscey2Xbje.vMovement);
						if (126805 - 593752 != -466947)
						{
							continue;
						}
						this.ahscey2Xbje.actionState = "run";
						if (105112 - 365737 != -260625)
						{
							continue;
						}
						if ((float)this.ahscey2Xbje.hp < 0.4f * (float)this.ahscey2Xbje.mhp)
						{
							if (187777 - 247443 != -59666)
							{
								continue;
							}
							this.animation.Play("sprint");
							if (83604 - 4746 != 78858)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (221006 - 160476 != 60530)
							{
								continue;
							}
							this.ahscey2Xbje.runSpeed = (float)7;
							if (206833 - 413972 == -207138)
							{
								continue;
							}
						}
						else if ((float)this.ahscey2Xbje.hp < 0.7f * (float)this.ahscey2Xbje.mhp)
						{
							if (127070 - 90287 == 36784)
							{
								continue;
							}
							this.animation.Play("run");
							if (84942 - 196686 != -111744)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (216061 - 108382 == 107680)
							{
								continue;
							}
							this.ahscey2Xbje.runSpeed = (float)5;
							if (181273 - 509006 == -327732)
							{
								continue;
							}
						}
						else
						{
							this.animation.Play("walk");
							if (14798 - 545298 == -530499)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (238108 - 451401 == -213292)
							{
								continue;
							}
							this.ahscey2Xbje.runSpeed = (float)3;
							if (269928 - 202064 == 67865)
							{
								continue;
							}
						}
					}
					this.ahscey2Xbje.moveSpeed = Mathf.Lerp(this.ahscey2Xbje.moveSpeed, this.ahscey2Xbje.runSpeed, (float)4 * Time.deltaTime);
					if (40228 - 269029 == -228800)
					{
						continue;
					}
				}
			}
			this.FWLceK9hMHl += mTime;
		}
		while (231763 - 282445 != -50682);
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x00A101C8 File Offset: 0x00A0E3C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (131137 - 203550 != -72412)
		{
		}
		do
		{
			if (Time.time - this.MfVcehV8gCj >= this.FWLceK9hMHl)
			{
				if (252856 - 309351 == -56494)
				{
					continue;
				}
				if (Time.time - this.MfVcehV8gCj < this.FWLceK9hMHl + mTime)
				{
					if (156716 - 281405 == -124688)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (7891 - 210455 == -202563)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (217428 - 226110 != -8682)
						{
							continue;
						}
						this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
						if (6666 - 570122 == -563455)
						{
							continue;
						}
						this.ahscey2Xbje.vDirection = Vector3.zero;
						if (97811 - 505606 == -407794)
						{
							continue;
						}
						this.ahscey2Xbje.vMovement = this.transform.forward;
						if (275253 - 4706 == 270548)
						{
							continue;
						}
						this.ahscey2Xbje.actionState = "standby";
						if (129089 - 349645 == -220555)
						{
							continue;
						}
						this.ahscey2Xbje.myAttackTarget = this.ahscey2Xbje.getRandomHateTarget(50);
						if (150319 - 410428 != -260109)
						{
							continue;
						}
						if (!this.ahscey2Xbje.myAttackTarget)
						{
							if (44660 - 318895 == -274234)
							{
								continue;
							}
							this.ahscey2Xbje.isAlert = false;
							if (58069 - 579446 != -521377)
							{
								continue;
							}
							this.MfVcehV8gCj = Time.time;
							if (292063 - 379853 == -87789)
							{
								continue;
							}
							this.ahscey2Xbje.myAttackTarget = null;
							if (107008 - 267555 != -160547)
							{
								continue;
							}
							this.ahscey2Xbje.mOriginalPosition = this.transform.position;
							if (191936 - 286796 != -94859)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.ahscey2Xbje.myAttackTarget;
							if (282036 - 61089 == 220948)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (182073 - 131066 != 51007)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (213336 - 507347 != -294011)
								{
									continue;
								}
								this.ahscey2Xbje.isAlert = false;
								if (211698 - 229853 != -18155)
								{
									continue;
								}
								this.MfVcehV8gCj = Time.time;
								if (25650 - 338866 == -313215)
								{
									continue;
								}
								this.ahscey2Xbje.myAttackTarget = null;
								if (253967 - 503194 == -249226)
								{
									continue;
								}
							}
							else
							{
								this.ahscey2Xbje.vDirection = myAttackTarget.transform.position;
								if (226943 - 392985 != -166042)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection.y = this.transform.position.y;
								if (111507 - 513476 != -401969)
								{
									continue;
								}
								this.ahscey2Xbje.vMovement = (this.ahscey2Xbje.vDirection - this.transform.position).normalized;
								if (262757 - 317172 == -54414)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ahscey2Xbje.vMovement);
								if (214471 - 347882 != -133411)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.FWLceK9hMHl += mTime;
		}
		while (118299 - 570514 != -452215);
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x00A10678 File Offset: 0x00A0E878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (68378 - 436885 != -368507)
		{
		}
		do
		{
			if (Time.time - this.MfVcehV8gCj >= this.FWLceK9hMHl)
			{
				if (18471 - 581970 == -563498)
				{
					continue;
				}
				if (Time.time - this.MfVcehV8gCj < this.FWLceK9hMHl + mTime)
				{
					if (182461 - 336222 == -153760)
					{
						continue;
					}
					if (!this.ahscey2Xbje.myAttackTarget)
					{
						if (115272 - 233474 == -118201)
						{
							continue;
						}
						this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
						if (295533 - 269621 != 25913)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.ahscey2Xbje.myAttackTarget;
						if (264837 - 367807 != -102970)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (120662 - 267335 != -146673)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (125295 - 425928 != -300633)
						{
							continue;
						}
						int tID = 0;
						if (218369 - 327722 == -109352)
						{
							continue;
						}
						if (characterControl)
						{
							if (11041 - 34781 != -23740)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (56811 - 208596 == -151784)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (13479 - 558215 != -544736)
						{
							continue;
						}
						if (this.ahscey2Xbje.isTimeOut("badRomance") == (float)0)
						{
							if (251471 - 510733 != -259262)
							{
								continue;
							}
							if ((float)this.ahscey2Xbje.hp < 0.4f * (float)this.ahscey2Xbje.mhp)
							{
								if (88903 - 103043 == -14139)
								{
									continue;
								}
								this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
								if (154041 - 80488 != 73553)
								{
									continue;
								}
								this.lAEceVp3PVv.StartCoroutine_Auto(this.lAEceVp3PVv.RPC_badRomance(this.transform.position, vector, tID));
								if (166626 - 362652 != -196026)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (260691 - 491804 == -231112)
									{
										continue;
									}
									this.lAEceVp3PVv.ActionEvent("RPC_badRomance", this.transform.position, vector, tID);
									if (154494 - 589166 != -434672)
									{
										continue;
									}
								}
								goto IL_4DA;
							}
						}
						if (this.ahscey2Xbje.isTimeOut("gorgonEye") == (float)0)
						{
							if (48679 - 10905 != 37774)
							{
								continue;
							}
							if (num < (float)20)
							{
								if (93813 - 97520 != -3707)
								{
									continue;
								}
								if ((float)this.ahscey2Xbje.hp < 0.8f * (float)this.ahscey2Xbje.mhp)
								{
									if (143011 - 164032 == -21020)
									{
										continue;
									}
									this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
									if (116137 - 192825 != -76688)
									{
										continue;
									}
									this.lAEceVp3PVv.StartCoroutine_Auto(this.lAEceVp3PVv.RPC_gorgonEye(this.transform.position, vector, tID));
									if (276140 - 219637 != 56503)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (75620 - 426516 == -350895)
										{
											continue;
										}
										this.lAEceVp3PVv.ActionEvent("RPC_gorgonEye", this.transform.position, vector, tID);
										if (53457 - 189686 == -136228)
										{
											continue;
										}
									}
									goto IL_4DA;
								}
							}
						}
						if (this.ahscey2Xbje.isTimeOut("netherBane") == (float)0)
						{
							if (56927 - 555413 == -498485)
							{
								continue;
							}
							this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
							if (68251 - 347536 != -279285)
							{
								continue;
							}
							this.lAEceVp3PVv.StartCoroutine_Auto(this.lAEceVp3PVv.RPC_netherBane(this.transform.position, vector, tID));
							if (209764 - 242361 != -32597)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (290157 - 433443 != -143286)
								{
									continue;
								}
								this.lAEceVp3PVv.ActionEvent("RPC_netherBane", this.transform.position, vector, tID);
								if (118293 - 216295 != -98002)
								{
									continue;
								}
							}
						}
						else if (this.ahscey2Xbje.isTimeOut("nAttack") == (float)0)
						{
							if (189512 - 173339 != 16173)
							{
								continue;
							}
							this.MfVcehV8gCj = Time.time - mTime - this.FWLceK9hMHl;
							if (226622 - 516563 == -289940)
							{
								continue;
							}
							this.lAEceVp3PVv.StartCoroutine_Auto(this.lAEceVp3PVv.RPC_nAttack(this.transform.position, vector, tID));
							if (36713 - 482404 == -445690)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (189701 - 74925 == 114777)
								{
									continue;
								}
								this.lAEceVp3PVv.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
								if (143694 - 519032 == -375337)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (84433 - 453528 == -369094)
							{
								continue;
							}
							if (num > (float)20)
							{
								if (73397 - 44413 != 28984)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection = myAttackTarget.transform.position;
								if (7180 - 129033 != -121853)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection.y = this.transform.position.y;
								if (176708 - 351550 != -174842)
								{
									continue;
								}
								this.ahscey2Xbje.vMovement = (this.ahscey2Xbje.vDirection - this.transform.position).normalized;
								if (209059 - 266480 != -57421)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ahscey2Xbje.vMovement);
								if (207885 - 104339 == 103547)
								{
									continue;
								}
								this.ahscey2Xbje.actionState = "run";
								if (158854 - 66699 != 92155)
								{
									continue;
								}
								this.animation.Play("run");
								if (221286 - 169508 == 51779)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (41625 - 138813 != -97188)
								{
									continue;
								}
								this.ahscey2Xbje.moveSpeed = Mathf.Lerp(this.ahscey2Xbje.moveSpeed, this.ahscey2Xbje.runSpeed, (float)4 * Time.deltaTime);
								if (141446 - 268823 != -127377)
								{
									continue;
								}
							}
							else if (num < (float)6)
							{
								if (185309 - 289285 != -103976)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection = myAttackTarget.transform.position;
								if (76130 - 499662 != -423532)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection.y = this.transform.position.y;
								if (67694 - 453537 != -385843)
								{
									continue;
								}
								this.ahscey2Xbje.vMovement = (this.transform.position - this.ahscey2Xbje.vDirection).normalized;
								if (198691 - 412717 != -214026)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ahscey2Xbje.vMovement);
								if (153906 - 179510 == -25603)
								{
									continue;
								}
								this.ahscey2Xbje.actionState = "run";
								if (20742 - 132684 == -111941)
								{
									continue;
								}
								this.animation.Play("run");
								if (119771 - 553279 != -433508)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (244402 - 43990 == 200413)
								{
									continue;
								}
								this.ahscey2Xbje.moveSpeed = Mathf.Lerp(this.ahscey2Xbje.moveSpeed, (float)5, (float)4 * Time.deltaTime);
								if (227776 - 242468 == -14691)
								{
									continue;
								}
							}
							else
							{
								this.ahscey2Xbje.vDirection = myAttackTarget.transform.position;
								if (29507 - 109551 == -80043)
								{
									continue;
								}
								this.ahscey2Xbje.vDirection.y = this.transform.position.y;
								if (231685 - 406144 != -174459)
								{
									continue;
								}
								this.ahscey2Xbje.vMovement = (this.ahscey2Xbje.vDirection - this.transform.position).normalized;
								if (208787 - 501400 == -292612)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ahscey2Xbje.vMovement);
								if (119485 - 313686 == -194200)
								{
									continue;
								}
								this.ahscey2Xbje.actionState = "standby";
								if (135753 - 431681 == -295927)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (181036 - 204484 != -23448)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (275117 - 340812 != -65695)
								{
									continue;
								}
								this.ahscey2Xbje.moveSpeed = Mathf.Lerp(this.ahscey2Xbje.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (291320 - 116101 == 175220)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_4DA:
			this.FWLceK9hMHl += mTime;
		}
		while (298622 - 435883 != -137261);
	}

	// Token: 0x06005279 RID: 21113 RVA: 0x00A112D4 File Offset: 0x00A0F4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (143802 - 467291 != -323489)
		{
		}
		while (Time.time - this.MfVcehV8gCj > this.FWLceK9hMHl)
		{
			if (297967 - 125680 == 172287)
			{
				this.AI_state = "none";
				if (93926 - 413358 == -319432)
				{
					this.MfVcehV8gCj = Time.time;
					if (278441 - 320158 != -41716)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600527A RID: 21114 RVA: 0x00A11388 File Offset: 0x00A0F588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (16433 - 588354 != -571921)
		{
		}
		for (;;)
		{
			IL_2CC:
			if (this.S6sceziMsBT > Time.time)
			{
				if (62737 - 47870 != 14868)
				{
					break;
				}
			}
			else
			{
				this.S6sceziMsBT = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (34225 - 233655 == -199430)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (195653 - 71906 != 123748)
					{
						if (285567 - 592430 == -306863)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (182381 - 41334 == 141047)
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
									if (239659 - 210011 != 29648)
									{
										goto IL_2CC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (74279 - 528791 == -454511)
									{
										goto IL_2CC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (53168 - 15670 == 37499)
									{
										goto IL_2CC;
									}
									bool flag = true;
									if (121435 - 441822 == -320386)
									{
										goto IL_2CC;
									}
									eRace race = this.ahscey2Xbje.Race;
									if (85098 - 110180 != -25082)
									{
										goto IL_2CC;
									}
									if (race == eRace.Tails)
									{
										if (237611 - 270352 != -32741)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_110;
										}
										if (6015 - 502426 == -496410)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (159894 - 366585 != -206690)
											{
												goto IL_110;
											}
											goto IL_2CC;
										}
										goto IL_4CD;
										IL_110:
										flag = false;
										if (130135 - 257341 != -127206)
										{
											goto IL_2CC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (20111 - 62573 != -42462)
										{
											goto IL_2CC;
										}
										flag = false;
										if (259436 - 317615 == -58178)
										{
											goto IL_2CC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (105027 - 346381 == -241353)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_43A;
										}
										if (41631 - 314223 == -272591)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (243441 - 522166 != -278724)
											{
												goto IL_43A;
											}
											goto IL_2CC;
										}
										goto IL_4CD;
										IL_43A:
										flag = false;
										if (171804 - 432498 != -260694)
										{
											goto IL_2CC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (189943 - 549240 == -359296)
										{
											goto IL_2CC;
										}
										flag = true;
										if (198573 - 391282 == -192708)
										{
											goto IL_2CC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (214226 - 314203 != -99977)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_77D;
										}
										if (23161 - 488973 != -465812)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_77D;
										}
										if (278614 - 529689 == -251074)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (98112 - 443401 != -345288)
											{
												goto IL_77D;
											}
											goto IL_2CC;
										}
										goto IL_4CD;
										IL_77D:
										flag = false;
										if (54302 - 426342 == -372039)
										{
											goto IL_2CC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (38505 - 442940 == -404434)
										{
											goto IL_2CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (209027 - 186496 == 22532)
											{
												goto IL_2CC;
											}
											flag = false;
											if (153636 - 466132 == -312495)
											{
												goto IL_2CC;
											}
										}
									}
									IL_4CD:
									if (flag)
									{
										if (45118 - 278114 == -232995)
										{
											goto IL_2CC;
										}
										if (characterControl.hp > 0)
										{
											if (46969 - 33422 != 13547)
											{
												goto IL_2CC;
											}
											if (characterControl.recieveTarget)
											{
												if (100083 - 507119 == -407035)
												{
													goto IL_2CC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (280746 - 314123 != -33377)
													{
														goto IL_2CC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (238225 - 422434 != -184209)
														{
															goto IL_2CC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (31171 - 360487 == -329315)
														{
															goto IL_2CC;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (206714 - 240017 != -33303)
															{
																goto IL_2CC;
															}
															this.ahscey2Xbje.myAttackTarget = gameObject;
															if (156025 - 74476 != 81549)
															{
																goto IL_2CC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (221570 - 59506 == 162065)
															{
																goto IL_2CC;
															}
															this.ahscey2Xbje.addHate(characterControl.ActorNr, 5);
															if (244005 - 588381 == -344375)
															{
																goto IL_2CC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (156002 - 550819 != -394817)
															{
																goto IL_2CC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (283851 - 330586 == -46734)
															{
																goto IL_2CC;
															}
															if (num < (float)60)
															{
																if (130702 - 220563 == -89860)
																{
																	goto IL_2CC;
																}
																if (characterControl.hp > 0)
																{
																	if (72381 - 37713 != 34668)
																	{
																		goto IL_2CC;
																	}
																	this.ahscey2Xbje.myAttackTarget = gameObject;
																	if (260281 - 590828 != -330547)
																	{
																		goto IL_2CC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (75827 - 160735 == -84907)
																	{
																		goto IL_2CC;
																	}
																	this.ahscey2Xbje.addHate(characterControl.ActorNr, 5);
																	if (102138 - 415436 == -313297)
																	{
																		goto IL_2CC;
																	}
																}
															}
														}
														if (this.ahscey2Xbje.myAttackTarget)
														{
															if (183363 - 320914 == -137550)
															{
																goto IL_2CC;
															}
															this.ahscey2Xbje.isAlert = true;
															if (282176 - 409329 == -127152)
															{
																goto IL_2CC;
															}
															this.MfVcehV8gCj = Time.time;
															if (11531 - 401438 == -389906)
															{
																goto IL_2CC;
															}
														}
													}
												}
											}
										}
									}
								}
								if (218960 - 27310 != 191651)
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

	// Token: 0x0600527B RID: 21115 RVA: 0x00A11BA0 File Offset: 0x00A0FDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600527C RID: 21116 RVA: 0x00A11BA4 File Offset: 0x00A0FDA4
	internal static bool p1RhCb5jnKAyZpYi2erk()
	{
		return true;
	}

	// Token: 0x0600527D RID: 21117 RVA: 0x00A11BA8 File Offset: 0x00A0FDA8
	internal static bool dfb0VK5j69lBlWbH6sB6()
	{
		return false;
	}

	// Token: 0x04005BE7 RID: 23527
	private CharacterControl ahscey2Xbje;

	// Token: 0x04005BE8 RID: 23528
	private Menalisa lAEceVp3PVv;

	// Token: 0x04005BE9 RID: 23529
	public string AI_state;

	// Token: 0x04005BEA RID: 23530
	private float MfVcehV8gCj;

	// Token: 0x04005BEB RID: 23531
	private float FWLceK9hMHl;

	// Token: 0x04005BEC RID: 23532
	private float S6sceziMsBT;
}
