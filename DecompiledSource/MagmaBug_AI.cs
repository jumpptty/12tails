using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000EB RID: 235
[Serializable]
public class MagmaBug_AI : MonoBehaviour
{
	// Token: 0x06000524 RID: 1316 RVA: 0x00085614 File Offset: 0x00083814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MagmaBug_AI()
	{
		if (136466 - 22418 != 114048)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (267694 - 25783 == 241911)
			{
				base..ctor();
				if (251346 - 161922 == 89424)
				{
					this.AI_state = "none";
					if (241901 - 456799 != -214897)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x000856B0 File Offset: 0x000838B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.xHUc9SVkf6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.uHwcWowb21 = (MagmaBug)this.GetComponent(typeof(MagmaBug));
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x000856E8 File Offset: 0x000838E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (124720 - 119155 != 5565)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (205999 - 395393 == -189393)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (105602 - 448201 == -342598)
				{
					continue;
				}
			}
			if (this.xHUc9SVkf6.isControlled)
			{
				break;
			}
			if (128817 - 521711 == -392894)
			{
				this.AIControl();
				if (35973 - 53584 == -17611)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x000857B4 File Offset: 0x000839B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (280287 - 116505 != 163782)
		{
		}
		for (;;)
		{
			this.lGOcyrhHV2 = (float)0;
			if (189224 - 78003 == 111221)
			{
				if (this.xHUc9SVkf6.isMine)
				{
					if (11155 - 260709 == -249554)
					{
						if (this.xHUc9SVkf6.actionState != "standby")
						{
							if (95478 - 296583 == -201104)
							{
								continue;
							}
							if (this.xHUc9SVkf6.actionState != "run")
							{
								if (257400 - 167839 != 89561)
								{
									continue;
								}
								break;
							}
						}
						if (!this.xHUc9SVkf6.isAlert)
						{
							if (54781 - 463476 != -408694)
							{
								this.AI_idle(3f, 1f);
								if (47123 - 599193 != -552069)
								{
									this.AI_patrol(1f, 0.25f);
									if (37948 - 437098 == -399150)
									{
										this.AI_resetTimer();
										if (212020 - 364120 != -152099)
										{
											this.AI_visionCheck();
											if (165584 - 218582 == -52998)
											{
												if (!this.xHUc9SVkf6.myAttackTarget)
												{
													break;
												}
												if (222374 - 197259 != 25116)
												{
													this.xHUc9SVkf6.isAlert = true;
													if (119071 - 479634 != -360562)
													{
														this.WRBcu530d5 = Time.time;
														if (288984 - 187365 == 101619)
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
							this.AI_idle(1f, (float)0);
							if (141463 - 159213 == -17750)
							{
								this.AI_selectTarget(1f, (float)0);
								if (221295 - 291748 == -70453)
								{
									this.AI_idle(2f, 1f);
									if (53192 - 86166 != -32973)
									{
										this.AI_attack(4f, 1f);
										if (271699 - 552533 == -280834)
										{
											this.AI_resetTimer();
											if (66415 - 44202 == 22213)
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
					if (this.xHUc9SVkf6.actionState != "standby")
					{
						if (197752 - 575826 == -378073)
						{
							continue;
						}
						if (this.xHUc9SVkf6.actionState != "run")
						{
							if (41648 - 278243 != -236594)
							{
								break;
							}
							continue;
						}
					}
					if (this.xHUc9SVkf6.nSpeed != (float)0)
					{
						if (246157 - 380880 != -134723)
						{
							continue;
						}
						if (this.xHUc9SVkf6.nPosition != this.xHUc9SVkf6.oPosition)
						{
							if (281328 - 178522 == 102807)
							{
								continue;
							}
							Vector3 a = this.xHUc9SVkf6.nPosition + 0.1f * this.xHUc9SVkf6.runSpeed * this.xHUc9SVkf6.nDirection;
							if (88338 - 119559 != -31221)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (272824 - 407874 == -135049)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (39425 - 417964 != -378539)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (76939 - 162398 == -85458)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (220006 - 462799 == -242792)
							{
								continue;
							}
							if (magnitude > this.xHUc9SVkf6.runSpeed)
							{
								if (99920 - 17385 != 82535)
								{
									continue;
								}
								this.transform.position = this.xHUc9SVkf6.nPosition;
								if (106934 - 39918 != 67017)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.xHUc9SVkf6.runSpeed)
							{
								if (49594 - 270684 == -221089)
								{
									continue;
								}
								this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, 1.1f * this.xHUc9SVkf6.runSpeed, (float)10 * Time.deltaTime);
								if (210927 - 55936 == 154992)
								{
									continue;
								}
								this.xHUc9SVkf6.vDirection = normalized;
								if (116776 - 147143 != -30367)
								{
									continue;
								}
								this.xHUc9SVkf6.vMovement = normalized;
								if (192524 - 578240 != -385716)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (131960 - 356784 != -224824)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (255485 - 271051 != -15566)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (152853 - 160309 == -7455)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (212672 - 181698 == 30975)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (16379 - 225389 != -209009)
								{
									break;
								}
								continue;
							}
							else
							{
								this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (85719 - 350557 == -264837)
								{
									continue;
								}
								this.xHUc9SVkf6.vDirection = normalized;
								if (212149 - 495350 != -283201)
								{
									continue;
								}
								this.xHUc9SVkf6.vMovement = normalized;
								if (150302 - 263028 != -112726)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (64764 - 390584 == -325819)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (44865 - 116078 != -71212)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.xHUc9SVkf6.moveSpeed != (float)0)
					{
						if (282963 - 373048 == -90085)
						{
							Vector3 vector3 = global::Math.vFlat(this.xHUc9SVkf6.nPosition - this.transform.position);
							if (242691 - 331453 == -88762)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (162652 - 307663 != -145010)
								{
									if (sqrMagnitude > this.xHUc9SVkf6.runSpeed)
									{
										if (172472 - 165226 != 7247)
										{
											this.transform.position = this.xHUc9SVkf6.nPosition;
											if (190544 - 214360 == -23816)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (175993 - 593209 == -417216)
										{
											if (sqrMagnitude > (float)1)
											{
												if (159699 - 255279 == -95579)
												{
													continue;
												}
												this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, this.xHUc9SVkf6.runSpeed, (float)10 * Time.deltaTime);
												if (10911 - 427687 == -416775)
												{
													continue;
												}
											}
											else
											{
												this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (35114 - 245485 != -210371)
												{
													continue;
												}
											}
											this.xHUc9SVkf6.vMovement = vector3;
											if (249994 - 295857 != -45862)
											{
												this.xHUc9SVkf6.vDirection = vector3;
												if (251569 - 382129 == -130560)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (240733 - 289560 != -48826)
													{
														this.animation.CrossFade("run", 0.2f);
														if (79109 - 541520 == -462411)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (332 - 186285 == -185953)
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
										this.xHUc9SVkf6.vMovement = vector3;
										if (184153 - 510440 == -326287)
										{
											this.xHUc9SVkf6.moveSpeed = (float)0;
											if (295981 - 165867 != 130115)
											{
												this.transform.rotation = Quaternion.LookRotation(this.xHUc9SVkf6.vDirection);
												if (41375 - 186142 == -144767)
												{
													this.animation.CrossFade("root", 0.2f);
													if (276272 - 444866 != -168593)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (152046 - 257905 == -105859)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (179056 - 525533 == -346477)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (64020 - 569031 == -505011)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00086360 File Offset: 0x00084560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (263164 - 522281 != -259117)
		{
		}
		do
		{
			if (Time.time - this.WRBcu530d5 >= this.lGOcyrhHV2)
			{
				if (58004 - 214645 == -156640)
				{
					continue;
				}
				if (Time.time - this.WRBcu530d5 < this.lGOcyrhHV2 + mTime)
				{
					if (165292 - 162512 == 2781)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (127640 - 312227 != -184587)
						{
							continue;
						}
						this.AI_state = "idle";
						if (15790 - 138987 == -123196)
						{
							continue;
						}
						this.WRBcu530d5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (171231 - 195878 == -24646)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection = Vector3.zero;
						if (241198 - 409243 == -168044)
						{
							continue;
						}
						this.xHUc9SVkf6.vMovement = this.transform.forward;
						if (118446 - 144261 == -25814)
						{
							continue;
						}
						this.xHUc9SVkf6.actionState = "standby";
						if (165728 - 299968 == -134239)
						{
							continue;
						}
					}
					this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (183663 - 184496 == -832)
					{
						continue;
					}
					if (this.xHUc9SVkf6.moveSpeed < 0.1f * this.xHUc9SVkf6.runSpeed)
					{
						if (53181 - 297646 != -244465)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (293654 - 514484 != -220830)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (252844 - 304795 == -51950)
						{
							continue;
						}
						this.xHUc9SVkf6.moveSpeed = (float)0;
						if (275253 - 95334 == 179920)
						{
							continue;
						}
					}
				}
			}
			this.lGOcyrhHV2 += mTime;
		}
		while (143159 - 302572 != -159413);
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00086624 File Offset: 0x00084824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (90453 - 43996 != 46457)
		{
		}
		do
		{
			if (Time.time - this.WRBcu530d5 >= this.lGOcyrhHV2)
			{
				if (41906 - 37641 == 4266)
				{
					continue;
				}
				if (Time.time - this.WRBcu530d5 < this.lGOcyrhHV2 + mTime)
				{
					if (77116 - 276679 == -199562)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (207616 - 304802 == -97185)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (41223 - 454009 != -412786)
						{
							continue;
						}
						this.WRBcu530d5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (88768 - 7069 == 81700)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection = this.xHUc9SVkf6.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (22841 - 386621 == -363779)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection.y = this.transform.position.y;
						if (239894 - 112637 != 127257)
						{
							continue;
						}
						this.xHUc9SVkf6.vMovement = (this.xHUc9SVkf6.vDirection - this.transform.position).normalized;
						if (108078 - 142587 == -34508)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xHUc9SVkf6.vMovement);
						if (4557 - 335385 == -330827)
						{
							continue;
						}
						this.xHUc9SVkf6.actionState = "run";
						if (139935 - 258772 == -118836)
						{
							continue;
						}
						this.animation.Play("run");
						if (23735 - 98289 == -74553)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (297239 - 528200 == -230960)
						{
							continue;
						}
					}
					this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, this.xHUc9SVkf6.runSpeed, (float)4 * Time.deltaTime);
					if (30863 - 483766 != -452903)
					{
						continue;
					}
				}
			}
			this.lGOcyrhHV2 += mTime;
		}
		while (254731 - 270122 != -15391);
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0008692C File Offset: 0x00084B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (33500 - 380758 != -347258)
		{
		}
		do
		{
			if (Time.time - this.WRBcu530d5 >= this.lGOcyrhHV2)
			{
				if (89452 - 529246 == -439793)
				{
					continue;
				}
				if (Time.time - this.WRBcu530d5 < this.lGOcyrhHV2 + mTime)
				{
					if (48190 - 479245 != -431055)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (201286 - 284959 == -83672)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (102981 - 531836 == -428854)
						{
							continue;
						}
						this.WRBcu530d5 = Time.time - mTime - this.lGOcyrhHV2;
						if (239780 - 371597 == -131816)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection = Vector3.zero;
						if (30452 - 119466 == -89013)
						{
							continue;
						}
						this.xHUc9SVkf6.vMovement = this.transform.forward;
						if (235771 - 119900 != 115871)
						{
							continue;
						}
						this.xHUc9SVkf6.actionState = "standby";
						if (112464 - 73172 != 39292)
						{
							continue;
						}
						this.xHUc9SVkf6.myAttackTarget = this.xHUc9SVkf6.getHateTarget(5, 50);
						if (152780 - 73450 == 79331)
						{
							continue;
						}
						if (!this.xHUc9SVkf6.myAttackTarget)
						{
							if (146403 - 9075 != 137328)
							{
								continue;
							}
							this.xHUc9SVkf6.isAlert = false;
							if (153044 - 331341 != -178297)
							{
								continue;
							}
							this.WRBcu530d5 = Time.time;
							if (20817 - 214681 == -193863)
							{
								continue;
							}
							this.xHUc9SVkf6.myAttackTarget = null;
							if (29909 - 49102 == -19192)
							{
								continue;
							}
							this.xHUc9SVkf6.mOriginalPosition = this.transform.position;
							if (48405 - 73993 != -25588)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.xHUc9SVkf6.myAttackTarget;
							if (290017 - 404729 != -114712)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (93406 - 228689 == -135282)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (172076 - 276356 != -104280)
								{
									continue;
								}
								this.xHUc9SVkf6.isAlert = false;
								if (212193 - 345526 != -133333)
								{
									continue;
								}
								this.WRBcu530d5 = Time.time;
								if (223566 - 356489 != -132923)
								{
									continue;
								}
								this.xHUc9SVkf6.myAttackTarget = null;
								if (173650 - 68012 == 105639)
								{
									continue;
								}
							}
							else
							{
								this.xHUc9SVkf6.vDirection = myAttackTarget.transform.position;
								if (228843 - 80929 == 147915)
								{
									continue;
								}
								this.xHUc9SVkf6.vDirection.y = this.transform.position.y;
								if (205400 - 191393 == 14008)
								{
									continue;
								}
								this.xHUc9SVkf6.vMovement = (this.xHUc9SVkf6.vDirection - this.transform.position).normalized;
								if (174409 - 20497 == 153913)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.xHUc9SVkf6.vMovement);
								if (10626 - 143037 == -132410)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.lGOcyrhHV2 += mTime;
		}
		while (292349 - 286668 != 5681);
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00086DDC File Offset: 0x00084FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (173144 - 386105 != -212960)
		{
		}
		do
		{
			if (Time.time - this.WRBcu530d5 >= this.lGOcyrhHV2)
			{
				if (38586 - 182244 == -143657)
				{
					continue;
				}
				if (Time.time - this.WRBcu530d5 < this.lGOcyrhHV2 + mTime)
				{
					if (205505 - 535416 == -329910)
					{
						continue;
					}
					if (!this.xHUc9SVkf6.myAttackTarget)
					{
						if (45822 - 231667 != -185845)
						{
							continue;
						}
						this.WRBcu530d5 = Time.time - mTime - this.lGOcyrhHV2;
						if (202046 - 214135 != -12088)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.xHUc9SVkf6.myAttackTarget;
						if (280676 - 29692 != 250984)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (217011 - 156728 != 60283)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (298256 - 116164 == 182093)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (118146 - 307505 != -189359)
							{
								continue;
							}
							if (this.xHUc9SVkf6.isTimeOut("nAttack") == (float)0)
							{
								if (285897 - 68625 == 217273)
								{
									continue;
								}
								this.WRBcu530d5 = Time.time - mTime - this.lGOcyrhHV2;
								if (230667 - 332720 == -102052)
								{
									continue;
								}
								this.uHwcWowb21.StartCoroutine_Auto(this.uHwcWowb21.RPC_nAttack(this.transform.position, vector, 0));
								if (204719 - 511760 != -307041)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (42227 - 17047 != 25180)
									{
										continue;
									}
									this.uHwcWowb21.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (202133 - 479913 == -277779)
									{
										continue;
									}
								}
								goto IL_32A;
							}
						}
						if (this.lGOcyrhHV2 + mTime - (Time.time - this.WRBcu530d5) <= (float)1)
						{
							if (11392 - 158949 != -147557)
							{
								continue;
							}
							if (this.xHUc9SVkf6.isTimeOut("magmaLock") == (float)0)
							{
								if (289903 - 136242 != 153661)
								{
									continue;
								}
								this.WRBcu530d5 = Time.time - mTime - this.lGOcyrhHV2;
								if (286605 - 41456 != 245149)
								{
									continue;
								}
								int tID = 0;
								if (264385 - 364238 == -99852)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
								if (283418 - 483418 == -199999)
								{
									continue;
								}
								if (characterControl)
								{
									if (78382 - 295545 == -217162)
									{
										continue;
									}
									tID = characterControl.ActorNr;
									if (30180 - 181212 != -151032)
									{
										continue;
									}
								}
								this.uHwcWowb21.StartCoroutine_Auto(this.uHwcWowb21.RPC_magmaLock(this.transform.position, vector, tID));
								if (216895 - 392982 != -176087)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (136904 - 242096 == -105191)
									{
										continue;
									}
									this.uHwcWowb21.ActionEvent("RPC_magmaLock", this.transform.position, vector, tID);
									if (237436 - 91896 != 145540)
									{
										continue;
									}
								}
								goto IL_32A;
							}
						}
						this.AI_state = "attack";
						if (84712 - 236321 == -151608)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection = myAttackTarget.transform.position;
						if (215459 - 414602 != -199143)
						{
							continue;
						}
						this.xHUc9SVkf6.vDirection.y = this.transform.position.y;
						if (81350 - 104710 == -23359)
						{
							continue;
						}
						this.xHUc9SVkf6.vMovement = (this.xHUc9SVkf6.vDirection - this.transform.position).normalized;
						if (249367 - 469480 != -220113)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xHUc9SVkf6.vMovement);
						if (35650 - 345505 != -309855)
						{
							continue;
						}
						this.xHUc9SVkf6.actionState = "run";
						if (54667 - 261456 == -206788)
						{
							continue;
						}
						this.animation.Play("run");
						if (12766 - 56248 != -43482)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (96075 - 292053 == -195977)
						{
							continue;
						}
						this.xHUc9SVkf6.moveSpeed = Mathf.Lerp(this.xHUc9SVkf6.moveSpeed, this.xHUc9SVkf6.runSpeed, (float)4 * Time.deltaTime);
						if (236706 - 283395 != -46689)
						{
							continue;
						}
					}
				}
			}
			IL_32A:
			this.lGOcyrhHV2 += mTime;
		}
		while (228092 - 528382 != -300290);
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0008745C File Offset: 0x0008565C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (209471 - 165253 != 44219)
		{
		}
		while (Time.time - this.WRBcu530d5 > this.lGOcyrhHV2)
		{
			if (249453 - 358540 != -109086)
			{
				this.AI_state = "none";
				if (269305 - 450968 == -181663)
				{
					this.WRBcu530d5 = Time.time;
					if (106355 - 474788 == -368433)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00087510 File Offset: 0x00085710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (298177 - 503964 != -205786)
		{
		}
		for (;;)
		{
			IL_52A:
			if (this.IpAcVypS4p > Time.time)
			{
				if (251715 - 392714 == -140999)
				{
					break;
				}
			}
			else
			{
				this.IpAcVypS4p = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (266780 - 198502 != 68279)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (120339 - 443096 == -322757)
					{
						if (266381 - 4441 != 261941)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (204195 - 478220 == -274025)
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
									if (129590 - 133433 != -3843)
									{
										goto IL_52A;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (216213 - 290713 != -74500)
									{
										goto IL_52A;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (27844 - 402608 == -374763)
									{
										goto IL_52A;
									}
									bool flag = true;
									if (273272 - 548931 != -275659)
									{
										goto IL_52A;
									}
									eRace race = this.xHUc9SVkf6.Race;
									if (240942 - 411635 == -170692)
									{
										goto IL_52A;
									}
									if (race == eRace.Tails)
									{
										if (239310 - 497155 != -257845)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3A9;
										}
										if (181265 - 543283 == -362017)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (62286 - 520454 != -458168)
											{
												goto IL_52A;
											}
											goto IL_3A9;
										}
										goto IL_6B;
										IL_3A9:
										flag = false;
										if (29279 - 59529 == -30249)
										{
											goto IL_52A;
										}
									}
									else if (race == eRace.Plants)
									{
										if (296532 - 10755 != 285777)
										{
											goto IL_52A;
										}
										flag = false;
										if (37128 - 416939 == -379810)
										{
											goto IL_52A;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (264561 - 322009 == -57447)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_6B7;
										}
										if (68932 - 469933 == -401000)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (149832 - 489909 != -340076)
											{
												goto IL_6B7;
											}
											goto IL_52A;
										}
										goto IL_6B;
										IL_6B7:
										flag = false;
										if (273505 - 180532 == 92974)
										{
											goto IL_52A;
										}
									}
									else if (race == eRace.Robots)
									{
										if (92292 - 317940 != -225648)
										{
											goto IL_52A;
										}
										flag = true;
										if (157812 - 461931 != -304119)
										{
											goto IL_52A;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (50681 - 585182 == -534500)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_369;
										}
										if (186994 - 187323 != -329)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_369;
										}
										if (53201 - 133788 != -80587)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (180877 - 317064 != -136186)
											{
												goto IL_369;
											}
											goto IL_52A;
										}
										goto IL_6B;
										IL_369:
										flag = false;
										if (30898 - 177076 == -146177)
										{
											goto IL_52A;
										}
									}
									else if (race == eRace.Structure)
									{
										if (257826 - 95857 != 161969)
										{
											goto IL_52A;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (220501 - 281282 == -60780)
											{
												goto IL_52A;
											}
											flag = false;
											if (80987 - 421520 == -340532)
											{
												goto IL_52A;
											}
										}
									}
									IL_6B:
									if (flag)
									{
										if (289526 - 253192 != 36334)
										{
											goto IL_52A;
										}
										if (characterControl.hp > 0)
										{
											if (251450 - 221521 == 29930)
											{
												goto IL_52A;
											}
											if (characterControl.recieveTarget)
											{
												if (154542 - 459872 == -305329)
												{
													goto IL_52A;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (274627 - 251849 != 22778)
													{
														goto IL_52A;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (88205 - 249378 == -161172)
														{
															goto IL_52A;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (25842 - 284954 != -259112)
														{
															goto IL_52A;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (175770 - 544567 == -368796)
															{
																goto IL_52A;
															}
															this.xHUc9SVkf6.myAttackTarget = gameObject;
															if (272628 - 339128 == -66499)
															{
																goto IL_52A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (84552 - 309642 != -225090)
															{
																goto IL_52A;
															}
															this.xHUc9SVkf6.addHate(characterControl.ActorNr, 5);
															if (217686 - 467126 != -249440)
															{
																goto IL_52A;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (281287 - 214652 != 66635)
															{
																goto IL_52A;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (4839 - 425167 != -420328)
															{
																goto IL_52A;
															}
															if (num < (float)60)
															{
																if (200831 - 386858 == -186026)
																{
																	goto IL_52A;
																}
																if (characterControl.hp > 0)
																{
																	if (69141 - 344722 == -275580)
																	{
																		goto IL_52A;
																	}
																	this.xHUc9SVkf6.myAttackTarget = gameObject;
																	if (131933 - 176076 == -44142)
																	{
																		goto IL_52A;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (297481 - 89883 == 207599)
																	{
																		goto IL_52A;
																	}
																	this.xHUc9SVkf6.addHate(characterControl.ActorNr, 5);
																	if (11290 - 139200 == -127909)
																	{
																		goto IL_52A;
																	}
																}
															}
														}
														if (this.xHUc9SVkf6.myAttackTarget)
														{
															if (102191 - 175401 != -73210)
															{
																goto IL_52A;
															}
															this.xHUc9SVkf6.isAlert = true;
															if (80750 - 418172 == -337421)
															{
																goto IL_52A;
															}
															this.WRBcu530d5 = Time.time;
															if (226784 - 462894 == -236109)
															{
																goto IL_52A;
															}
														}
													}
												}
											}
										}
									}
								}
								if (288372 - 58764 != 229609)
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

	// Token: 0x0600052E RID: 1326 RVA: 0x00087D28 File Offset: 0x00085F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x00087D2C File Offset: 0x00085F2C
	internal static bool owVaZicnELjxNOTmUTa()
	{
		return true;
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00087D30 File Offset: 0x00085F30
	internal static bool keXLHKc6aNpmeA8aCpO()
	{
		return false;
	}

	// Token: 0x040004C6 RID: 1222
	private CharacterControl xHUc9SVkf6;

	// Token: 0x040004C7 RID: 1223
	private MagmaBug uHwcWowb21;

	// Token: 0x040004C8 RID: 1224
	public string AI_state;

	// Token: 0x040004C9 RID: 1225
	private float WRBcu530d5;

	// Token: 0x040004CA RID: 1226
	private float lGOcyrhHV2;

	// Token: 0x040004CB RID: 1227
	private float IpAcVypS4p;
}
