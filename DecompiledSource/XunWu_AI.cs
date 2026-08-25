using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E5B RID: 3675
[Serializable]
public class XunWu_AI : MonoBehaviour
{
	// Token: 0x06005326 RID: 21286 RVA: 0x00A215BC File Offset: 0x00A1F7BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XunWu_AI()
	{
		if (289444 - 29025 != 260419)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (40251 - 87902 != -47650)
			{
				base..ctor();
				if (196584 - 178478 != 18107)
				{
					this.AI_state = "none";
					if (129618 - 478133 != -348514)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005327 RID: 21287 RVA: 0x00A21658 File Offset: 0x00A1F858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aPOcIT9S1nd = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Ep5cIYOFrbJ = (XunWu)this.GetComponent(typeof(XunWu));
	}

	// Token: 0x06005328 RID: 21288 RVA: 0x00A21690 File Offset: 0x00A1F890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (55526 - 44243 != 11284)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (260586 - 595531 != -334945)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (50979 - 61167 != -10188)
				{
					continue;
				}
			}
			if (this.aPOcIT9S1nd.isControlled)
			{
				break;
			}
			if (268588 - 475030 != -206441)
			{
				this.AIControl();
				if (195893 - 492815 != -296921)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005329 RID: 21289 RVA: 0x00A2175C File Offset: 0x00A1F95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (84445 - 437051 != -352605)
		{
		}
		for (;;)
		{
			this.AQOcIb3pVkm = (float)0;
			if (226893 - 568303 != -341409)
			{
				if (this.aPOcIT9S1nd.isMine)
				{
					if (189918 - 333019 == -143101)
					{
						if (this.aPOcIT9S1nd.actionState != "standby")
						{
							if (107995 - 294702 != -186707)
							{
								continue;
							}
							if (this.aPOcIT9S1nd.actionState != "run")
							{
								if (208758 - 490717 != -281958)
								{
									break;
								}
								continue;
							}
						}
						if (!this.aPOcIT9S1nd.isAlert)
						{
							if (164518 - 72132 != 92387)
							{
								this.AI_idle(3f, 1f);
								if (32902 - 328222 != -295319)
								{
									this.AI_patrol(1f, 0.5f);
									if (274947 - 250052 == 24895)
									{
										this.AI_resetTimer();
										if (89934 - 222342 == -132408)
										{
											this.AI_visionCheck();
											if (55024 - 337885 == -282861)
											{
												if (!this.aPOcIT9S1nd.myAttackTarget)
												{
													break;
												}
												if (233825 - 174958 != 58868)
												{
													this.aPOcIT9S1nd.isAlert = true;
													if (76696 - 435161 == -358465)
													{
														this.vEWcI3WkbH8 = Time.time;
														if (45420 - 570243 == -524823)
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
							if (293560 - 483463 != -189902)
							{
								this.AI_patrol(1f, 0.25f);
								if (124347 - 357544 != -233196)
								{
									this.AI_attack(10f, (float)0);
									if (167467 - 10143 != 157325)
									{
										this.AI_resetTimer();
										if (164904 - 140695 == 24209)
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
					if (this.aPOcIT9S1nd.actionState != "standby")
					{
						if (266692 - 490641 != -223949)
						{
							continue;
						}
						if (this.aPOcIT9S1nd.actionState != "run")
						{
							if (254160 - 386433 != -132273)
							{
								continue;
							}
							break;
						}
					}
					float num = this.aPOcIT9S1nd.moveSpeed;
					if (254570 - 39370 == 215200)
					{
						float runSpeed = this.aPOcIT9S1nd.runSpeed;
						if (64395 - 119601 == -55206)
						{
							Vector3 vector = default(Vector3);
							if (44428 - 321646 != -277217)
							{
								Vector3 vector2 = Vector3.zero;
								if (154493 - 552476 == -397983)
								{
									if ((this.aPOcIT9S1nd.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (34884 - 120141 != -85257)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aPOcIT9S1nd.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (171411 - 400281 == -228869)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (202542 - 50540 != 152002)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (295058 - 542940 != -247882)
											{
												continue;
											}
											num = (float)0;
											if (275369 - 192467 == 82903)
											{
												continue;
											}
											this.transform.position = this.aPOcIT9S1nd.nPosition;
											if (225433 - 565614 != -340181)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (132401 - 160747 == -28345)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (214782 - 63505 == 151278)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (271934 - 74880 != 197054)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (112083 - 521122 != -409039)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (279675 - 356839 == -77163)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (57050 - 525614 != -468564)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (80176 - 7644 == 72533)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (77597 - 188749 != -111152)
											{
												continue;
											}
										}
									}
									this.aPOcIT9S1nd.vMovement = vector2;
									if (34000 - 535616 != -501615)
									{
										this.aPOcIT9S1nd.moveSpeed = num;
										if (242352 - 472752 == -230400)
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

	// Token: 0x0600532A RID: 21290 RVA: 0x00A21DD4 File Offset: 0x00A1FFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (93480 - 341110 != -247629)
		{
		}
		do
		{
			if (Time.time - this.vEWcI3WkbH8 >= this.AQOcIb3pVkm)
			{
				if (298226 - 358430 == -60203)
				{
					continue;
				}
				if (Time.time - this.vEWcI3WkbH8 < this.AQOcIb3pVkm + mTime)
				{
					if (276044 - 566750 == -290705)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (71308 - 377763 == -306454)
						{
							continue;
						}
						this.AI_state = "idle";
						if (251952 - 90902 != 161050)
						{
							continue;
						}
						this.vEWcI3WkbH8 -= UnityEngine.Random.Range((float)0, rTimer);
						if (253286 - 563236 != -309950)
						{
							continue;
						}
						this.aPOcIT9S1nd.vDirection = Vector3.zero;
						if (85727 - 325438 != -239711)
						{
							continue;
						}
						this.aPOcIT9S1nd.vMovement = this.transform.forward;
						if (66698 - 178671 != -111973)
						{
							continue;
						}
						this.aPOcIT9S1nd.actionState = "standby";
						if (217359 - 494061 == -276701)
						{
							continue;
						}
					}
					this.aPOcIT9S1nd.moveSpeed = Mathf.Lerp(this.aPOcIT9S1nd.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (181832 - 572592 == -390759)
					{
						continue;
					}
					if (this.aPOcIT9S1nd.moveSpeed < 0.1f * this.aPOcIT9S1nd.runSpeed)
					{
						if (82245 - 345004 == -262758)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (131478 - 152506 == -21027)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (195657 - 208434 == -12776)
						{
							continue;
						}
						this.aPOcIT9S1nd.moveSpeed = (float)0;
						if (101875 - 221712 != -119837)
						{
							continue;
						}
					}
				}
			}
			this.AQOcIb3pVkm += mTime;
		}
		while (294344 - 498962 == -204617);
	}

	// Token: 0x0600532B RID: 21291 RVA: 0x00A22098 File Offset: 0x00A20298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (232179 - 218755 != 13425)
		{
		}
		for (;;)
		{
			this.aPOcIT9S1nd.vDirection = followObject.transform.position;
			if (99578 - 340931 == -241353)
			{
				this.aPOcIT9S1nd.vDirection.y = this.transform.position.y;
				if (44945 - 434830 != -389884)
				{
					this.aPOcIT9S1nd.vMovement = (this.aPOcIT9S1nd.vDirection - this.transform.position).normalized;
					if (66582 - 477785 == -411203)
					{
						this.transform.rotation = Quaternion.LookRotation(this.aPOcIT9S1nd.vMovement);
						if (218757 - 26195 != 192563)
						{
							this.aPOcIT9S1nd.actionState = "run";
							if (216695 - 226457 != -9761)
							{
								this.animation.Play("run");
								if (252747 - 78665 != 174083)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (280472 - 200562 == 79910)
									{
										this.aPOcIT9S1nd.moveSpeed = Mathf.Lerp(this.aPOcIT9S1nd.moveSpeed, this.aPOcIT9S1nd.runSpeed, (float)4 * Time.deltaTime);
										if (205546 - 564548 == -359002)
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

	// Token: 0x0600532C RID: 21292 RVA: 0x00A22280 File Offset: 0x00A20480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (64089 - 566002 != -501912)
		{
		}
		do
		{
			if (Time.time - this.vEWcI3WkbH8 >= this.AQOcIb3pVkm)
			{
				if (216383 - 25611 != 190772)
				{
					continue;
				}
				if (Time.time - this.vEWcI3WkbH8 < this.AQOcIb3pVkm + mTime)
				{
					if (76133 - 497333 == -421199)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (155177 - 282244 != -127067)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (154513 - 221149 == -66635)
						{
							continue;
						}
						this.vEWcI3WkbH8 -= UnityEngine.Random.Range((float)0, rTimer);
						if (102179 - 65354 == 36826)
						{
							continue;
						}
						this.aPOcIT9S1nd.vDirection = this.aPOcIT9S1nd.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (281514 - 106559 != 174955)
						{
							continue;
						}
						this.aPOcIT9S1nd.vDirection.y = this.transform.position.y;
						if (39979 - 67846 == -27866)
						{
							continue;
						}
						this.aPOcIT9S1nd.vMovement = (this.aPOcIT9S1nd.vDirection - this.transform.position).normalized;
						if (59737 - 594304 != -534567)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aPOcIT9S1nd.vMovement);
						if (74237 - 454959 == -380721)
						{
							continue;
						}
						this.aPOcIT9S1nd.actionState = "run";
						if (113523 - 350566 != -237043)
						{
							continue;
						}
						this.animation.Play("run");
						if (98836 - 471874 != -373038)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (185320 - 263784 != -78464)
						{
							continue;
						}
					}
					this.aPOcIT9S1nd.moveSpeed = Mathf.Lerp(this.aPOcIT9S1nd.moveSpeed, this.aPOcIT9S1nd.runSpeed, (float)4 * Time.deltaTime);
					if (163144 - 24952 == 138193)
					{
						continue;
					}
				}
			}
			this.AQOcIb3pVkm += mTime;
		}
		while (115542 - 194739 == -79196);
	}

	// Token: 0x0600532D RID: 21293 RVA: 0x00A22588 File Offset: 0x00A20788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (2972 - 204091 != -201119)
		{
		}
		do
		{
			if (Time.time - this.vEWcI3WkbH8 >= this.AQOcIb3pVkm)
			{
				if (97244 - 62349 == 34896)
				{
					continue;
				}
				if (Time.time - this.vEWcI3WkbH8 < this.AQOcIb3pVkm + mTime)
				{
					if (245220 - 207579 != 37641)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (105653 - 302630 != -196977)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (36438 - 17627 == 18812)
						{
							continue;
						}
						this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
						if (38677 - 599321 == -560643)
						{
							continue;
						}
						this.aPOcIT9S1nd.vDirection = Vector3.zero;
						if (79048 - 251178 != -172130)
						{
							continue;
						}
						this.aPOcIT9S1nd.vMovement = this.transform.forward;
						if (133860 - 345056 == -211195)
						{
							continue;
						}
						this.aPOcIT9S1nd.actionState = "standby";
						if (46206 - 309901 != -263695)
						{
							continue;
						}
						this.aPOcIT9S1nd.myAttackTarget = this.aPOcIT9S1nd.getHateTarget(5, 50);
						if (190438 - 549310 != -358872)
						{
							continue;
						}
						if (!this.aPOcIT9S1nd.myAttackTarget)
						{
							if (35374 - 420903 != -385529)
							{
								continue;
							}
							this.aPOcIT9S1nd.isAlert = false;
							if (34603 - 296613 != -262010)
							{
								continue;
							}
							this.vEWcI3WkbH8 = Time.time;
							if (193813 - 301513 == -107699)
							{
								continue;
							}
							this.aPOcIT9S1nd.myAttackTarget = null;
							if (49988 - 355550 != -305562)
							{
								continue;
							}
							this.aPOcIT9S1nd.mOriginalPosition = this.transform.position;
							if (276336 - 301079 != -24742)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.aPOcIT9S1nd.myAttackTarget;
							if (245615 - 186674 != 58941)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (288639 - 364309 == -75669)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (160831 - 28287 != 132544)
								{
									continue;
								}
								this.aPOcIT9S1nd.isAlert = false;
								if (156644 - 593808 == -437163)
								{
									continue;
								}
								this.vEWcI3WkbH8 = Time.time;
								if (239566 - 46746 == 192821)
								{
									continue;
								}
								this.aPOcIT9S1nd.myAttackTarget = null;
								if (8264 - 440142 == -431877)
								{
									continue;
								}
							}
							else
							{
								this.aPOcIT9S1nd.vDirection = myAttackTarget.transform.position;
								if (184593 - 578353 == -393759)
								{
									continue;
								}
								this.aPOcIT9S1nd.vDirection.y = this.transform.position.y;
								if (287598 - 153229 == 134370)
								{
									continue;
								}
								this.aPOcIT9S1nd.vMovement = (this.aPOcIT9S1nd.vDirection - this.transform.position).normalized;
								if (233574 - 234865 != -1291)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aPOcIT9S1nd.vMovement);
								if (182110 - 498752 == -316641)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.AQOcIb3pVkm += mTime;
		}
		while (94271 - 595488 == -501216);
	}

	// Token: 0x0600532E RID: 21294 RVA: 0x00A22A38 File Offset: 0x00A20C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (246253 - 141857 != 104396)
		{
		}
		do
		{
			if (Time.time - this.vEWcI3WkbH8 >= this.AQOcIb3pVkm)
			{
				if (260545 - 61512 == 199034)
				{
					continue;
				}
				if (Time.time - this.vEWcI3WkbH8 < this.AQOcIb3pVkm + mTime)
				{
					if (274017 - 338610 == -64592)
					{
						continue;
					}
					if (!this.aPOcIT9S1nd.myAttackTarget)
					{
						if (168336 - 467468 == -299131)
						{
							continue;
						}
						this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
						if (168448 - 103252 != 65196)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.aPOcIT9S1nd.myAttackTarget;
						if (126419 - 47298 == 79122)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (94102 - 145914 == -51811)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (186044 - 389457 == -203412)
						{
							continue;
						}
						int tID = 0;
						if (196326 - 129379 != 66947)
						{
							continue;
						}
						if (characterControl)
						{
							if (89398 - 400675 != -311277)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (55802 - 94433 == -38630)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (22270 - 478201 == -455930)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (170052 - 326485 != -156433)
							{
								continue;
							}
							if ((float)this.aPOcIT9S1nd.hp < 0.5f * (float)this.aPOcIT9S1nd.mhp)
							{
								if (73406 - 179786 == -106379)
								{
									continue;
								}
								if (this.aPOcIT9S1nd.isTimeOut("flashFire") == (float)0)
								{
									if (183172 - 441644 != -258472)
									{
										continue;
									}
									this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
									if (220963 - 197609 == 23355)
									{
										continue;
									}
									this.Ep5cIYOFrbJ.StartCoroutine_Auto(this.Ep5cIYOFrbJ.RPC_flashFire(this.transform.position, vector, tID));
									if (74259 - 569645 != -495386)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (70966 - 570441 == -499474)
										{
											continue;
										}
										this.Ep5cIYOFrbJ.ActionEvent("RPC_flashFire", this.transform.position, vector, tID);
										if (40341 - 246259 == -205917)
										{
											continue;
										}
									}
									goto IL_569;
								}
							}
						}
						if (num < (float)5)
						{
							if (149896 - 139414 != 10482)
							{
								continue;
							}
							if (this.aPOcIT9S1nd.isTimeOut("flameSmite") == (float)0)
							{
								if (215258 - 306302 != -91044)
								{
									continue;
								}
								this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
								if (91224 - 286111 == -194886)
								{
									continue;
								}
								this.Ep5cIYOFrbJ.StartCoroutine_Auto(this.Ep5cIYOFrbJ.RPC_flameSmite(this.transform.position, vector, tID));
								if (57716 - 444241 != -386524)
								{
									if (PhotonClient.IsInitialized())
									{
										if (24964 - 90603 == -65638)
										{
											continue;
										}
										this.Ep5cIYOFrbJ.ActionEvent("RPC_flameSmite", this.transform.position, vector, tID);
										if (154578 - 589723 != -435145)
										{
											continue;
										}
									}
									goto IL_569;
								}
								continue;
							}
						}
						if (num > (float)6)
						{
							if (130190 - 411085 != -280895)
							{
								continue;
							}
							if (this.aPOcIT9S1nd.isTimeOut("fireBall") == (float)0)
							{
								if (74496 - 343962 != -269466)
								{
									continue;
								}
								this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
								if (33913 - 403190 == -369276)
								{
									continue;
								}
								this.Ep5cIYOFrbJ.StartCoroutine_Auto(this.Ep5cIYOFrbJ.RPC_fireBall(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (291606 - 240050 != 51557)
								{
									if (PhotonClient.IsInitialized())
									{
										if (89549 - 15698 != 73851)
										{
											continue;
										}
										this.Ep5cIYOFrbJ.ActionEvent("RPC_fireBall", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (4678 - 69481 == -64802)
										{
											continue;
										}
									}
									goto IL_569;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (127738 - 373134 != -245396)
							{
								continue;
							}
							if (this.aPOcIT9S1nd.isTimeOut("nAttack") == (float)0)
							{
								if (272474 - 308426 != -35952)
								{
									continue;
								}
								this.vEWcI3WkbH8 = Time.time - mTime - this.AQOcIb3pVkm;
								if (155284 - 288313 != -133029)
								{
									continue;
								}
								this.Ep5cIYOFrbJ.StartCoroutine_Auto(this.Ep5cIYOFrbJ.RPC_nAttack(this.transform.position, vector, 0));
								if (296199 - 252716 != 43484)
								{
									if (PhotonClient.IsInitialized())
									{
										if (288532 - 13457 == 275076)
										{
											continue;
										}
										this.Ep5cIYOFrbJ.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (29191 - 206463 != -177272)
										{
											continue;
										}
									}
									goto IL_569;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (280415 - 414688 != -134273)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (159209 - 87339 == 71871)
							{
								continue;
							}
							this.aPOcIT9S1nd.vDirection = myAttackTarget.transform.position;
							if (196830 - 597933 != -401103)
							{
								continue;
							}
							this.aPOcIT9S1nd.vDirection.y = this.transform.position.y;
							if (56330 - 89023 != -32693)
							{
								continue;
							}
							this.aPOcIT9S1nd.vMovement = (this.aPOcIT9S1nd.vDirection - this.transform.position).normalized;
							if (199950 - 52447 == 147504)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.aPOcIT9S1nd.vMovement);
							if (235183 - 367770 != -132587)
							{
								continue;
							}
							this.aPOcIT9S1nd.actionState = "run";
							if (173164 - 520507 != -347343)
							{
								continue;
							}
							this.animation.Play("run");
							if (182213 - 99972 == 82242)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (246540 - 377506 == -130965)
							{
								continue;
							}
							this.aPOcIT9S1nd.moveSpeed = Mathf.Lerp(this.aPOcIT9S1nd.moveSpeed, this.aPOcIT9S1nd.runSpeed, (float)4 * Time.deltaTime);
							if (66872 - 539477 != -472605)
							{
								continue;
							}
						}
						else
						{
							this.aPOcIT9S1nd.vDirection = myAttackTarget.transform.position;
							if (179967 - 84071 != 95896)
							{
								continue;
							}
							this.aPOcIT9S1nd.vDirection.y = this.transform.position.y;
							if (32596 - 55799 != -23203)
							{
								continue;
							}
							this.aPOcIT9S1nd.vMovement = (this.aPOcIT9S1nd.vDirection - this.transform.position).normalized;
							if (228093 - 218388 != 9705)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.aPOcIT9S1nd.vMovement);
							if (150355 - 218421 == -68065)
							{
								continue;
							}
							this.aPOcIT9S1nd.actionState = "standby";
							if (78130 - 410018 == -331887)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (117847 - 282753 == -164905)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (85005 - 403814 == -318808)
							{
								continue;
							}
							this.aPOcIT9S1nd.moveSpeed = Mathf.Lerp(this.aPOcIT9S1nd.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (136563 - 264477 != -127914)
							{
								continue;
							}
						}
					}
				}
			}
			IL_569:
			this.AQOcIb3pVkm += mTime;
		}
		while (5971 - 130064 != -124093);
	}

	// Token: 0x0600532F RID: 21295 RVA: 0x00A23534 File Offset: 0x00A21734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (112969 - 584123 != -471154)
		{
		}
		while (Time.time - this.vEWcI3WkbH8 > this.AQOcIb3pVkm)
		{
			if (226951 - 348234 != -121282)
			{
				this.AI_state = "none";
				if (30288 - 327971 == -297683)
				{
					this.vEWcI3WkbH8 = Time.time;
					if (10545 - 497943 == -487398)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005330 RID: 21296 RVA: 0x00A235E8 File Offset: 0x00A217E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (277569 - 505846 != -228277)
		{
		}
		for (;;)
		{
			IL_78E:
			if (this.KAQcIddFyqh > Time.time)
			{
				if (253464 - 551632 != -298167)
				{
					break;
				}
			}
			else
			{
				this.KAQcIddFyqh = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (211376 - 141639 == 69737)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (144225 - 113534 != 30692 && 121807 - 319892 != -198084)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (14591 - 529294 != -514702)
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
								if (252628 - 167515 != 85113)
								{
									goto IL_78E;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (116118 - 97910 == 18209)
								{
									goto IL_78E;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (160091 - 223039 != -62948)
								{
									goto IL_78E;
								}
								bool flag = true;
								if (40493 - 187304 == -146810)
								{
									goto IL_78E;
								}
								eRace race = this.aPOcIT9S1nd.Race;
								if (259162 - 337255 == -78092)
								{
									goto IL_78E;
								}
								if (race == eRace.Tails)
								{
									if (178768 - 267211 != -88443)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_22B;
									}
									if (164934 - 265047 != -100113)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (173637 - 552288 != -378650)
										{
											goto IL_22B;
										}
										goto IL_78E;
									}
									goto IL_8D;
									IL_22B:
									flag = false;
									if (203773 - 236851 == -33077)
									{
										goto IL_78E;
									}
								}
								else if (race == eRace.Plants)
								{
									if (235450 - 295136 != -59686)
									{
										goto IL_78E;
									}
									flag = false;
									if (132235 - 562198 == -429962)
									{
										goto IL_78E;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (207546 - 286700 != -79154)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_43C;
									}
									if (30528 - 270739 == -240210)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (34103 - 260697 != -226594)
										{
											goto IL_78E;
										}
										goto IL_43C;
									}
									goto IL_8D;
									IL_43C:
									flag = false;
									if (102084 - 309971 == -207886)
									{
										goto IL_78E;
									}
								}
								else if (race == eRace.Robots)
								{
									if (293223 - 169415 == 123809)
									{
										goto IL_78E;
									}
									flag = true;
									if (15553 - 174045 != -158492)
									{
										goto IL_78E;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (269689 - 467996 == -198306)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_51A;
									}
									if (142111 - 327006 != -184895)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_51A;
									}
									if (194874 - 584629 == -389754)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (124824 - 350889 != -226064)
										{
											goto IL_51A;
										}
										goto IL_78E;
									}
									goto IL_8D;
									IL_51A:
									flag = false;
									if (215483 - 597825 != -382342)
									{
										goto IL_78E;
									}
								}
								else if (race == eRace.Structure)
								{
									if (260120 - 230341 != 29779)
									{
										goto IL_78E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (115721 - 296311 == -180589)
										{
											goto IL_78E;
										}
										flag = false;
										if (32544 - 317824 == -285279)
										{
											goto IL_78E;
										}
									}
								}
								IL_8D:
								if (flag)
								{
									if (119446 - 195641 != -76195)
									{
										goto IL_78E;
									}
									if (characterControl.hp > 0)
									{
										if (96276 - 211926 == -115649)
										{
											goto IL_78E;
										}
										if (characterControl.recieveTarget)
										{
											if (207008 - 516827 != -309819)
											{
												goto IL_78E;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (294048 - 241837 != 52211)
												{
													goto IL_78E;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (241155 - 245346 != -4191)
													{
														goto IL_78E;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (131215 - 552871 == -421655)
													{
														goto IL_78E;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (39095 - 328909 != -289814)
														{
															goto IL_78E;
														}
														this.aPOcIT9S1nd.myAttackTarget = gameObject;
														if (61878 - 563352 == -501473)
														{
															goto IL_78E;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (120090 - 148272 != -28182)
														{
															goto IL_78E;
														}
														this.aPOcIT9S1nd.addHate(characterControl.ActorNr, 5);
														if (149899 - 475848 == -325948)
														{
															goto IL_78E;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (12461 - 86987 != -74526)
														{
															goto IL_78E;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (53603 - 131183 != -77580)
														{
															goto IL_78E;
														}
														if (num < (float)60)
														{
															if (11517 - 473987 != -462470)
															{
																goto IL_78E;
															}
															if (characterControl.hp > 0)
															{
																if (241313 - 236649 == 4665)
																{
																	goto IL_78E;
																}
																this.aPOcIT9S1nd.myAttackTarget = gameObject;
																if (140359 - 536467 == -396107)
																{
																	goto IL_78E;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (140523 - 111578 == 28946)
																{
																	goto IL_78E;
																}
																this.aPOcIT9S1nd.addHate(characterControl.ActorNr, 5);
																if (48308 - 41742 != 6566)
																{
																	goto IL_78E;
																}
															}
														}
													}
													if (this.aPOcIT9S1nd.myAttackTarget)
													{
														if (91429 - 411412 != -319983)
														{
															goto IL_78E;
														}
														this.aPOcIT9S1nd.isAlert = true;
														if (143745 - 67613 != 76132)
														{
															goto IL_78E;
														}
														this.vEWcI3WkbH8 = Time.time;
														if (42110 - 51879 != -9769)
														{
															goto IL_78E;
														}
													}
												}
											}
										}
									}
								}
							}
							if (253736 - 306038 == -52302)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005331 RID: 21297 RVA: 0x00A23E00 File Offset: 0x00A22000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005332 RID: 21298 RVA: 0x00A23E04 File Offset: 0x00A22004
	internal static bool Fc59jX5hgRdJ4KMwIlvP()
	{
		return true;
	}

	// Token: 0x06005333 RID: 21299 RVA: 0x00A23E08 File Offset: 0x00A22008
	internal static bool VkgVjH5hfC8YvLmE2ICM()
	{
		return false;
	}

	// Token: 0x04005C77 RID: 23671
	private CharacterControl aPOcIT9S1nd;

	// Token: 0x04005C78 RID: 23672
	private XunWu Ep5cIYOFrbJ;

	// Token: 0x04005C79 RID: 23673
	public string AI_state;

	// Token: 0x04005C7A RID: 23674
	private float vEWcI3WkbH8;

	// Token: 0x04005C7B RID: 23675
	private float AQOcIb3pVkm;

	// Token: 0x04005C7C RID: 23676
	private float KAQcIddFyqh;
}
