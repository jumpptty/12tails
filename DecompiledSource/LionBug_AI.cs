using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000D7 RID: 215
[Serializable]
public class LionBug_AI : MonoBehaviour
{
	// Token: 0x060004A8 RID: 1192 RVA: 0x0007888C File Offset: 0x00076A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LionBug_AI()
	{
		if (116632 - 56733 != 59900)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (250195 - 304218 == -54023)
			{
				base..ctor();
				if (176750 - 154905 != 21846)
				{
					this.AI_state = "none";
					if (73621 - 123510 == -49889)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00078928 File Offset: 0x00076B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.iI3c0gQGLA = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.MF0c8G1YNo = (LionBug)this.GetComponent(typeof(LionBug));
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00078960 File Offset: 0x00076B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (31756 - 490290 != -458533)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (152932 - 192639 != -39707)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (25288 - 343629 == -318340)
				{
					continue;
				}
			}
			if (this.iI3c0gQGLA.isControlled)
			{
				break;
			}
			if (50692 - 369084 != -318391)
			{
				this.AIControl();
				if (168298 - 425985 == -257687)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00078A2C File Offset: 0x00076C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (60444 - 70804 != -10359)
		{
		}
		for (;;)
		{
			this.GOMcDZ4BWM = (float)0;
			if (223515 - 108465 != 115051)
			{
				if (this.iI3c0gQGLA.isMine)
				{
					if (49394 - 171166 == -121772)
					{
						if (this.iI3c0gQGLA.actionState != "standby")
						{
							if (196294 - 447873 == -251578)
							{
								continue;
							}
							if (this.iI3c0gQGLA.actionState != "run")
							{
								if (190704 - 34686 != 156018)
								{
									continue;
								}
								break;
							}
						}
						if (!this.iI3c0gQGLA.isAlert)
						{
							if (245830 - 344254 != -98423)
							{
								this.AI_idle(3f, 1f);
								if (61436 - 488522 == -427086)
								{
									this.AI_patrol(1f, 0.25f);
									if (264148 - 441746 != -177597)
									{
										this.AI_resetTimer();
										if (233405 - 242843 != -9437)
										{
											this.AI_visionCheck();
											if (223407 - 61986 != 161422)
											{
												if (!this.iI3c0gQGLA.myAttackTarget)
												{
													break;
												}
												if (153731 - 67374 == 86357)
												{
													this.iI3c0gQGLA.isAlert = true;
													if (102227 - 404390 == -302163)
													{
														this.OFSciPPdmQ = Time.time;
														if (113163 - 548069 != -434905)
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
							if (59642 - 499610 != -439967)
							{
								this.AI_idle(2f, 1f);
								if (91103 - 201865 == -110762)
								{
									this.AI_attack(10f, (float)0);
									if (178264 - 136840 == 41424)
									{
										this.AI_resetTimer();
										if (152374 - 546476 != -394101)
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
					if (this.iI3c0gQGLA.actionState != "standby")
					{
						if (224711 - 19354 != 205357)
						{
							continue;
						}
						if (this.iI3c0gQGLA.actionState != "run")
						{
							if (166097 - 138017 != 28080)
							{
								continue;
							}
							break;
						}
					}
					if (this.iI3c0gQGLA.nSpeed != (float)0)
					{
						if (207403 - 507959 == -300555)
						{
							continue;
						}
						if (this.iI3c0gQGLA.nPosition != this.iI3c0gQGLA.oPosition)
						{
							if (69746 - 252405 != -182659)
							{
								continue;
							}
							Vector3 a = this.iI3c0gQGLA.nPosition + 0.1f * this.iI3c0gQGLA.runSpeed * this.iI3c0gQGLA.nDirection;
							if (266691 - 589464 == -322772)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (131517 - 35313 == 96205)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (108835 - 583839 != -475004)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (126598 - 475587 == -348988)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (197114 - 588814 != -391700)
							{
								continue;
							}
							if (magnitude > this.iI3c0gQGLA.runSpeed)
							{
								if (170031 - 365549 == -195517)
								{
									continue;
								}
								this.transform.position = this.iI3c0gQGLA.nPosition;
								if (59782 - 69654 != -9872)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.iI3c0gQGLA.runSpeed)
							{
								if (170867 - 448623 == -277755)
								{
									continue;
								}
								this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, 1.1f * this.iI3c0gQGLA.runSpeed, (float)10 * Time.deltaTime);
								if (246888 - 129608 == 117281)
								{
									continue;
								}
								this.iI3c0gQGLA.vDirection = normalized;
								if (95141 - 558634 != -463493)
								{
									continue;
								}
								this.iI3c0gQGLA.vMovement = normalized;
								if (37574 - 33752 != 3822)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (81813 - 542700 == -460886)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (124041 - 409686 != -285645)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (175293 - 128863 == 46431)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (10249 - 115223 != -104974)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (283077 - 1513 != 281564)
								{
									continue;
								}
								break;
							}
							else
							{
								this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (155927 - 36209 == 119719)
								{
									continue;
								}
								this.iI3c0gQGLA.vDirection = normalized;
								if (188906 - 192473 == -3566)
								{
									continue;
								}
								this.iI3c0gQGLA.vMovement = normalized;
								if (250076 - 559522 != -309446)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (220483 - 164859 == 55625)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (176920 - 1155 != 175766)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.iI3c0gQGLA.moveSpeed != (float)0)
					{
						if (128051 - 140870 == -12819)
						{
							Vector3 vector3 = global::Math.vFlat(this.iI3c0gQGLA.nPosition - this.transform.position);
							if (180760 - 516105 == -335345)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (150584 - 537152 != -386567)
								{
									if (sqrMagnitude > this.iI3c0gQGLA.runSpeed)
									{
										if (296187 - 304290 == -8103)
										{
											this.transform.position = this.iI3c0gQGLA.nPosition;
											if (111909 - 211296 != -99386)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (131213 - 468945 != -337731)
										{
											if (sqrMagnitude > (float)1)
											{
												if (136812 - 387613 != -250801)
												{
													continue;
												}
												this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, this.iI3c0gQGLA.runSpeed, (float)10 * Time.deltaTime);
												if (230370 - 170735 != 59635)
												{
													continue;
												}
											}
											else
											{
												this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (167508 - 533068 != -365560)
												{
													continue;
												}
											}
											this.iI3c0gQGLA.vMovement = vector3;
											if (66352 - 121583 != -55230)
											{
												this.iI3c0gQGLA.vDirection = vector3;
												if (109159 - 342739 != -233579)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (196534 - 472818 == -276284)
													{
														this.animation.CrossFade("run", 0.2f);
														if (215433 - 444061 == -228628)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (127149 - 250436 == -123287)
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
										this.iI3c0gQGLA.vMovement = vector3;
										if (172271 - 595488 != -423216)
										{
											this.iI3c0gQGLA.moveSpeed = (float)0;
											if (260411 - 164577 != 95835)
											{
												this.transform.rotation = Quaternion.LookRotation(this.iI3c0gQGLA.vDirection);
												if (42609 - 162002 != -119392)
												{
													this.animation.CrossFade("root", 0.2f);
													if (258360 - 59215 == 199145)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (21687 - 265067 == -243380)
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
						if (284139 - 557698 != -273558)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (107746 - 46222 != 61525)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x000795AC File Offset: 0x000777AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (126404 - 199807 != -73402)
		{
		}
		do
		{
			if (Time.time - this.OFSciPPdmQ >= this.GOMcDZ4BWM)
			{
				if (165848 - 29275 == 136574)
				{
					continue;
				}
				if (Time.time - this.OFSciPPdmQ < this.GOMcDZ4BWM + mTime)
				{
					if (186084 - 81434 == 104651)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (8547 - 478614 != -470067)
						{
							continue;
						}
						this.AI_state = "idle";
						if (35617 - 157665 == -122047)
						{
							continue;
						}
						this.OFSciPPdmQ -= UnityEngine.Random.Range((float)0, rTimer);
						if (171772 - 396776 == -225003)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection = Vector3.zero;
						if (83213 - 278959 != -195746)
						{
							continue;
						}
						this.iI3c0gQGLA.vMovement = this.transform.forward;
						if (27814 - 152894 != -125080)
						{
							continue;
						}
						this.iI3c0gQGLA.actionState = "standby";
						if (243088 - 132779 == 110310)
						{
							continue;
						}
					}
					this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (286154 - 167110 != 119044)
					{
						continue;
					}
					if (this.iI3c0gQGLA.moveSpeed < 0.1f * this.iI3c0gQGLA.runSpeed)
					{
						if (217711 - 113596 == 104116)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (74522 - 438815 == -364292)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (60092 - 420143 == -360050)
						{
							continue;
						}
						this.iI3c0gQGLA.moveSpeed = (float)0;
						if (268325 - 553859 != -285534)
						{
							continue;
						}
					}
				}
			}
			this.GOMcDZ4BWM += mTime;
		}
		while (129022 - 184551 == -55528);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00079870 File Offset: 0x00077A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (179304 - 419203 != -239898)
		{
		}
		do
		{
			if (Time.time - this.OFSciPPdmQ >= this.GOMcDZ4BWM)
			{
				if (135372 - 542991 == -407618)
				{
					continue;
				}
				if (Time.time - this.OFSciPPdmQ < this.GOMcDZ4BWM + mTime)
				{
					if (119424 - 119635 != -211)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (253309 - 582601 != -329292)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (253678 - 156023 != 97655)
						{
							continue;
						}
						this.OFSciPPdmQ -= UnityEngine.Random.Range((float)0, rTimer);
						if (21258 - 28544 == -7285)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection = this.iI3c0gQGLA.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (165600 - 301035 != -135435)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection.y = this.transform.position.y;
						if (41029 - 110516 != -69487)
						{
							continue;
						}
						this.iI3c0gQGLA.vMovement = (this.iI3c0gQGLA.vDirection - this.transform.position).normalized;
						if (251479 - 556952 == -305472)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.iI3c0gQGLA.vMovement);
						if (286771 - 542353 != -255582)
						{
							continue;
						}
						this.iI3c0gQGLA.actionState = "run";
						if (297133 - 436888 == -139754)
						{
							continue;
						}
						this.animation.CrossFade("run", 0.2f);
						if (203075 - 146128 == 56948)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (128188 - 349730 != -221542)
						{
							continue;
						}
					}
					this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, this.iI3c0gQGLA.runSpeed, (float)4 * Time.deltaTime);
					if (138027 - 439 == 137589)
					{
						continue;
					}
				}
			}
			this.GOMcDZ4BWM += mTime;
		}
		while (221311 - 329933 == -108621);
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00079B7C File Offset: 0x00077D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (297361 - 563609 != -266247)
		{
		}
		do
		{
			if (Time.time - this.OFSciPPdmQ >= this.GOMcDZ4BWM)
			{
				if (38349 - 78303 == -39953)
				{
					continue;
				}
				if (Time.time - this.OFSciPPdmQ < this.GOMcDZ4BWM + mTime)
				{
					if (260089 - 113414 == 146676)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (249543 - 305085 == -55541)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (211876 - 553259 != -341383)
						{
							continue;
						}
						this.OFSciPPdmQ = Time.time - mTime - this.GOMcDZ4BWM;
						if (45796 - 586792 == -540995)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection = Vector3.zero;
						if (285845 - 281243 == 4603)
						{
							continue;
						}
						this.iI3c0gQGLA.vMovement = this.transform.forward;
						if (203619 - 3119 == 200501)
						{
							continue;
						}
						this.iI3c0gQGLA.actionState = "standby";
						if (157576 - 76595 != 80981)
						{
							continue;
						}
						this.iI3c0gQGLA.myAttackTarget = this.iI3c0gQGLA.getHateTarget(5, 50);
						if (23121 - 106407 != -83286)
						{
							continue;
						}
						if (!this.iI3c0gQGLA.myAttackTarget)
						{
							if (139057 - 442689 == -303631)
							{
								continue;
							}
							this.iI3c0gQGLA.isAlert = false;
							if (269479 - 522348 != -252869)
							{
								continue;
							}
							this.OFSciPPdmQ = Time.time;
							if (34912 - 216823 == -181910)
							{
								continue;
							}
							this.iI3c0gQGLA.myAttackTarget = null;
							if (71508 - 272259 == -200750)
							{
								continue;
							}
							this.iI3c0gQGLA.mOriginalPosition = this.transform.position;
							if (293309 - 556838 != -263528)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.iI3c0gQGLA.myAttackTarget;
							if (261032 - 277123 != -16091)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (3339 - 93469 == -90129)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (133625 - 440381 != -306756)
								{
									continue;
								}
								this.iI3c0gQGLA.isAlert = false;
								if (1892 - 161941 != -160049)
								{
									continue;
								}
								this.OFSciPPdmQ = Time.time;
								if (175968 - 286758 != -110790)
								{
									continue;
								}
								this.iI3c0gQGLA.myAttackTarget = null;
								if (246069 - 1929 != 244140)
								{
									continue;
								}
							}
							else
							{
								this.iI3c0gQGLA.vDirection = myAttackTarget.transform.position;
								if (14112 - 19886 != -5774)
								{
									continue;
								}
								this.iI3c0gQGLA.vDirection.y = this.transform.position.y;
								if (243306 - 349498 != -106192)
								{
									continue;
								}
								this.iI3c0gQGLA.vMovement = (this.iI3c0gQGLA.vDirection - this.transform.position).normalized;
								if (77256 - 277324 == -200067)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.iI3c0gQGLA.vMovement);
								if (60345 - 62363 == -2017)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.GOMcDZ4BWM += mTime;
		}
		while (104851 - 367675 != -262824);
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x0007A02C File Offset: 0x0007822C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (235988 - 125468 != 110520)
		{
		}
		do
		{
			if (Time.time - this.OFSciPPdmQ >= this.GOMcDZ4BWM)
			{
				if (274836 - 78523 != 196313)
				{
					continue;
				}
				if (Time.time - this.OFSciPPdmQ < this.GOMcDZ4BWM + mTime)
				{
					if (60078 - 561578 == -501499)
					{
						continue;
					}
					if (!this.iI3c0gQGLA.myAttackTarget)
					{
						if (221495 - 407149 != -185654)
						{
							continue;
						}
						this.OFSciPPdmQ = Time.time - mTime - this.GOMcDZ4BWM;
						if (177398 - 133494 != 43904)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.iI3c0gQGLA.myAttackTarget;
						if (86030 - 503693 == -417662)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (225495 - 460466 == -234970)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (132249 - 491875 == -359625)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (94884 - 571113 != -476229)
							{
								continue;
							}
							if (this.iI3c0gQGLA.isTimeOut("nAttack") == (float)0)
							{
								if (224968 - 192222 != 32746)
								{
									continue;
								}
								this.OFSciPPdmQ = Time.time - mTime - this.GOMcDZ4BWM;
								if (65477 - 154478 != -89001)
								{
									continue;
								}
								this.MF0c8G1YNo.StartCoroutine_Auto(this.MF0c8G1YNo.RPC_nAttack(this.transform.position, vector, 0));
								if (280355 - 89807 != 190549)
								{
									if (PhotonClient.IsInitialized())
									{
										if (246041 - 512669 == -266627)
										{
											continue;
										}
										this.MF0c8G1YNo.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (103966 - 107073 == -3106)
										{
											continue;
										}
									}
									goto IL_2C5;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (41895 - 464715 == -422819)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection = myAttackTarget.transform.position;
						if (242355 - 553593 != -311238)
						{
							continue;
						}
						this.iI3c0gQGLA.vDirection.y = this.transform.position.y;
						if (209637 - 14239 == 195399)
						{
							continue;
						}
						this.iI3c0gQGLA.vMovement = (this.iI3c0gQGLA.vDirection - this.transform.position).normalized;
						if (267617 - 279453 == -11835)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.iI3c0gQGLA.vMovement);
						if (147836 - 274782 != -126946)
						{
							continue;
						}
						this.iI3c0gQGLA.actionState = "run";
						if (43638 - 227443 != -183805)
						{
							continue;
						}
						this.animation.CrossFade("run", 0.2f);
						if (199863 - 241061 != -41198)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (170273 - 216688 == -46414)
						{
							continue;
						}
						this.iI3c0gQGLA.moveSpeed = Mathf.Lerp(this.iI3c0gQGLA.moveSpeed, this.iI3c0gQGLA.runSpeed, (float)4 * Time.deltaTime);
						if (248031 - 90564 != 157467)
						{
							continue;
						}
					}
				}
			}
			IL_2C5:
			this.GOMcDZ4BWM += mTime;
		}
		while (157678 - 262032 != -104354);
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x0007A4E4 File Offset: 0x000786E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (228691 - 473943 != -245251)
		{
		}
		while (Time.time - this.OFSciPPdmQ > this.GOMcDZ4BWM)
		{
			if (85618 - 434277 != -348658)
			{
				this.AI_state = "none";
				if (204180 - 364151 == -159971)
				{
					this.OFSciPPdmQ = Time.time;
					if (172055 - 530279 != -358223)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x0007A598 File Offset: 0x00078798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (245634 - 560515 != -314880)
		{
		}
		for (;;)
		{
			IL_4C2:
			if (this.ioScmPPepm + (float)1 > Time.time)
			{
				if (253749 - 501160 == -247411)
				{
					break;
				}
			}
			else
			{
				this.ioScmPPepm = Time.time;
				if (199521 - 113549 != 85973)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (32420 - 377551 != -345130 && 107636 - 43498 != 64139)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (200938 - 144771 != 56168)
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
								if (184441 - 328030 == -143588)
								{
									goto IL_4C2;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (281361 - 270566 != 10795)
								{
									goto IL_4C2;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (155756 - 429160 == -273403)
								{
									goto IL_4C2;
								}
								bool flag = true;
								if (39443 - 546311 == -506867)
								{
									goto IL_4C2;
								}
								eRace race = this.iI3c0gQGLA.Race;
								if (278383 - 319463 != -41080)
								{
									goto IL_4C2;
								}
								if (race == eRace.Tails)
								{
									if (84851 - 470168 != -385317)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_45E;
									}
									if (242854 - 464745 == -221890)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (284129 - 521165 != -237036)
										{
											goto IL_4C2;
										}
										goto IL_45E;
									}
									goto IL_20E;
									IL_45E:
									flag = false;
									if (87859 - 41235 == 46625)
									{
										goto IL_4C2;
									}
								}
								else if (race == eRace.Plants)
								{
									if (191707 - 76929 == 114779)
									{
										goto IL_4C2;
									}
									flag = false;
									if (39408 - 138112 != -98704)
									{
										goto IL_4C2;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (211937 - 346344 != -134407)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_7ED;
									}
									if (124339 - 31733 != 92606)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (245807 - 244721 != 1086)
										{
											goto IL_4C2;
										}
										goto IL_7ED;
									}
									goto IL_20E;
									IL_7ED:
									flag = false;
									if (40108 - 596801 == -556692)
									{
										goto IL_4C2;
									}
								}
								else if (race == eRace.Robots)
								{
									if (150175 - 254364 != -104189)
									{
										goto IL_4C2;
									}
									flag = true;
									if (184987 - 106805 != 78182)
									{
										goto IL_4C2;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (167579 - 477898 == -310318)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6AF;
									}
									if (108338 - 489324 == -380985)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6AF;
									}
									if (273699 - 83873 == 189827)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (210855 - 108895 != 101960)
										{
											goto IL_4C2;
										}
										goto IL_6AF;
									}
									goto IL_20E;
									IL_6AF:
									flag = false;
									if (94074 - 345074 == -250999)
									{
										goto IL_4C2;
									}
								}
								else if (race == eRace.Structure)
								{
									if (78554 - 88497 == -9942)
									{
										goto IL_4C2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (289172 - 565789 == -276616)
										{
											goto IL_4C2;
										}
										flag = false;
										if (288526 - 48850 != 239676)
										{
											goto IL_4C2;
										}
									}
								}
								IL_20E:
								if (flag)
								{
									if (159778 - 494788 != -335010)
									{
										goto IL_4C2;
									}
									if (characterControl.hp > 0)
									{
										if (36548 - 206012 == -169463)
										{
											goto IL_4C2;
										}
										if (characterControl.recieveTarget)
										{
											if (216452 - 91146 == 125307)
											{
												goto IL_4C2;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (161980 - 352168 == -190187)
												{
													goto IL_4C2;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (108669 - 73829 != 34840)
													{
														goto IL_4C2;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (12495 - 335090 != -322595)
													{
														goto IL_4C2;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (140765 - 145495 != -4730)
														{
															goto IL_4C2;
														}
														this.iI3c0gQGLA.isAlert = true;
														if (104187 - 498515 == -394327)
														{
															goto IL_4C2;
														}
														this.OFSciPPdmQ = Time.time;
														if (12539 - 45272 == -32732)
														{
															goto IL_4C2;
														}
														this.iI3c0gQGLA.myAttackTarget = gameObject;
														if (146608 - 554569 == -407960)
														{
															goto IL_4C2;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (286326 - 190904 == 95423)
														{
															goto IL_4C2;
														}
														this.iI3c0gQGLA.addHate(characterControl.ActorNr, 5);
														if (245413 - 308448 == -63034)
														{
															goto IL_4C2;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (236427 - 156737 == 79691)
														{
															goto IL_4C2;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (94763 - 363697 == -268933)
														{
															goto IL_4C2;
														}
														if (num < (float)60)
														{
															if (218402 - 3877 == 214526)
															{
																goto IL_4C2;
															}
															if (characterControl.hp > 0)
															{
																if (243182 - 300027 != -56845)
																{
																	goto IL_4C2;
																}
																this.iI3c0gQGLA.isAlert = true;
																if (298443 - 111487 != 186956)
																{
																	goto IL_4C2;
																}
																this.OFSciPPdmQ = Time.time;
																if (211940 - 101907 != 110033)
																{
																	goto IL_4C2;
																}
																this.iI3c0gQGLA.myAttackTarget = gameObject;
																if (55761 - 155179 != -99418)
																{
																	goto IL_4C2;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (74581 - 439935 != -365354)
																{
																	goto IL_4C2;
																}
																this.iI3c0gQGLA.addHate(characterControl.ActorNr, 5);
																if (15915 - 54642 == -38726)
																{
																	goto IL_4C2;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
							if (205944 - 12659 != 193286)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x0007ADC0 File Offset: 0x00078FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x0007ADC4 File Offset: 0x00078FC4
	internal static bool JU6XcVYs8ubCDV6e8GR()
	{
		return true;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x0007ADC8 File Offset: 0x00078FC8
	internal static bool GUYWutY9u6Ksh9gHhBX()
	{
		return false;
	}

	// Token: 0x0400046C RID: 1132
	private CharacterControl iI3c0gQGLA;

	// Token: 0x0400046D RID: 1133
	private LionBug MF0c8G1YNo;

	// Token: 0x0400046E RID: 1134
	public string AI_state;

	// Token: 0x0400046F RID: 1135
	private float OFSciPPdmQ;

	// Token: 0x04000470 RID: 1136
	private float GOMcDZ4BWM;

	// Token: 0x04000471 RID: 1137
	private float ioScmPPepm;
}
