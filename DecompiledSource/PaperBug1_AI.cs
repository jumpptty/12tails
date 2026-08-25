using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000163 RID: 355
[Serializable]
public class PaperBug1_AI : MonoBehaviour
{
	// Token: 0x060007EE RID: 2030 RVA: 0x000CE0EC File Offset: 0x000CC2EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug1_AI()
	{
		if (230194 - 592491 != -362297)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (208102 - 5912 != 202191)
			{
				base..ctor();
				if (100400 - 152745 == -52345)
				{
					this.AI_state = "none";
					if (201555 - 365271 != -163715)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x000CE188 File Offset: 0x000CC388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.vienz0hIdR = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Q9hQ5GaRnG = (PaperBug1)this.GetComponent(typeof(PaperBug1));
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x000CE1C0 File Offset: 0x000CC3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (209898 - 425276 != -215377)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (132497 - 99792 != 32705)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (61537 - 465780 == -404242)
				{
					continue;
				}
			}
			if (this.vienz0hIdR.isControlled)
			{
				break;
			}
			if (103904 - 274753 != -170848)
			{
				this.AIControl();
				if (203597 - 393744 != -190146)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x000CE28C File Offset: 0x000CC48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (61344 - 191374 != -130030)
		{
		}
		for (;;)
		{
			this.zsFQnCUTqH = (float)0;
			if (27397 - 537272 != -509874)
			{
				if (this.vienz0hIdR.isMine)
				{
					if (150314 - 370334 == -220020)
					{
						if (this.vienz0hIdR.actionState != "standby")
						{
							if (29326 - 443216 != -413890)
							{
								continue;
							}
							if (this.vienz0hIdR.actionState != "run")
							{
								if (106278 - 265136 != -158857)
								{
									break;
								}
								continue;
							}
						}
						if (!this.vienz0hIdR.isAlert)
						{
							if (243516 - 42644 != 200873)
							{
								this.AI_idle(3f, 1f);
								if (161069 - 78726 == 82343)
								{
									this.AI_patrol(2f, 0.25f);
									if (4585 - 62305 == -57720)
									{
										this.AI_resetTimer();
										if (35668 - 189622 == -153954)
										{
											this.AI_visionCheck();
											if (20094 - 263252 == -243158)
											{
												if (!this.vienz0hIdR.myAttackTarget)
												{
													break;
												}
												if (25905 - 96410 != -70504)
												{
													this.vienz0hIdR.isAlert = true;
													if (288010 - 140474 == 147536)
													{
														this.vOqQckUhK6 = Time.time;
														if (270832 - 124324 != 146509)
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
							if (6995 - 929 != 6067)
							{
								this.AI_patrol(3f, 1f);
								if (138288 - 419617 != -281328)
								{
									this.AI_attack(4f, (float)0);
									if (252289 - 403441 == -151152)
									{
										this.AI_resetTimer();
										if (125582 - 563098 != -437515)
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
					if (this.vienz0hIdR.actionState != "standby")
					{
						if (27688 - 117667 == -89978)
						{
							continue;
						}
						if (this.vienz0hIdR.actionState != "run")
						{
							if (281420 - 530989 != -249569)
							{
								continue;
							}
							break;
						}
					}
					if (this.vienz0hIdR.nSpeed != (float)0)
					{
						if (103313 - 308442 == -205128)
						{
							continue;
						}
						if (this.vienz0hIdR.nPosition != this.vienz0hIdR.oPosition)
						{
							if (262215 - 486607 == -224391)
							{
								continue;
							}
							Vector3 a = this.vienz0hIdR.nPosition + 0.1f * this.vienz0hIdR.runSpeed * this.vienz0hIdR.nDirection;
							if (273692 - 135340 != 138352)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (278901 - 253536 == 25366)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (41992 - 131903 != -89911)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (33881 - 347794 == -313912)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (110954 - 37429 != 73525)
							{
								continue;
							}
							if (magnitude > this.vienz0hIdR.runSpeed)
							{
								if (48279 - 11270 != 37009)
								{
									continue;
								}
								this.transform.position = this.vienz0hIdR.nPosition;
								if (124 - 443752 != -443628)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.vienz0hIdR.runSpeed)
							{
								if (46108 - 598252 != -552144)
								{
									continue;
								}
								this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, 1.1f * this.vienz0hIdR.runSpeed, (float)10 * Time.deltaTime);
								if (217164 - 213194 != 3970)
								{
									continue;
								}
								this.vienz0hIdR.vDirection = normalized;
								if (41397 - 59787 != -18390)
								{
									continue;
								}
								this.vienz0hIdR.vMovement = normalized;
								if (15405 - 422936 != -407531)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (9279 - 76243 != -66964)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (286407 - 401175 == -114767)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (115002 - 378571 != -263569)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (26189 - 232528 == -206338)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (230421 - 62731 != 167690)
								{
									continue;
								}
								break;
							}
							else
							{
								this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (78733 - 311111 != -232378)
								{
									continue;
								}
								this.vienz0hIdR.vDirection = normalized;
								if (252671 - 546194 != -293523)
								{
									continue;
								}
								this.vienz0hIdR.vMovement = normalized;
								if (85682 - 283700 != -198018)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (50481 - 334200 != -283719)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (277814 - 206575 != 71239)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.vienz0hIdR.moveSpeed != (float)0)
					{
						if (292990 - 361012 != -68021)
						{
							Vector3 vector3 = global::Math.vFlat(this.vienz0hIdR.nPosition - this.transform.position);
							if (236527 - 53817 == 182710)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (265336 - 364144 == -98808)
								{
									if (sqrMagnitude > this.vienz0hIdR.runSpeed)
									{
										if (85092 - 580644 != -495551)
										{
											this.transform.position = this.vienz0hIdR.nPosition;
											if (115965 - 478917 == -362952)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (21287 - 505341 == -484054)
										{
											if (sqrMagnitude > (float)1)
											{
												if (126745 - 105887 != 20858)
												{
													continue;
												}
												this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, this.vienz0hIdR.runSpeed, (float)10 * Time.deltaTime);
												if (184494 - 483886 == -299391)
												{
													continue;
												}
											}
											else
											{
												this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (228859 - 85792 != 143067)
												{
													continue;
												}
											}
											this.vienz0hIdR.vMovement = vector3;
											if (177393 - 31612 != 145782)
											{
												this.vienz0hIdR.vDirection = vector3;
												if (269576 - 265144 == 4432)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (150755 - 94590 == 56165)
													{
														this.animation.CrossFade("run", 0.2f);
														if (234965 - 227676 != 7290)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (136658 - 439786 == -303128)
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
										this.vienz0hIdR.vMovement = vector3;
										if (64654 - 397648 == -332994)
										{
											this.vienz0hIdR.moveSpeed = (float)0;
											if (82220 - 112245 != -30024)
											{
												this.transform.rotation = Quaternion.LookRotation(this.vienz0hIdR.vDirection);
												if (287880 - 585353 == -297473)
												{
													this.animation.CrossFade("root", 0.2f);
													if (277135 - 214515 == 62620)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (94814 - 197030 == -102216)
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
						if (163251 - 374216 != -210964)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (158878 - 286240 != -127361)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x000CEE0C File Offset: 0x000CD00C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (160191 - 65076 != 95115)
		{
		}
		do
		{
			if (Time.time - this.vOqQckUhK6 >= this.zsFQnCUTqH)
			{
				if (46812 - 142104 == -95291)
				{
					continue;
				}
				if (Time.time - this.vOqQckUhK6 < this.zsFQnCUTqH + mTime)
				{
					if (178947 - 103779 == 75169)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (253587 - 524937 == -271349)
						{
							continue;
						}
						this.AI_state = "idle";
						if (144680 - 327607 != -182927)
						{
							continue;
						}
						this.vOqQckUhK6 -= UnityEngine.Random.Range((float)0, rTimer);
						if (138118 - 379060 != -240942)
						{
							continue;
						}
						this.vienz0hIdR.vDirection = Vector3.zero;
						if (255460 - 186783 == 68678)
						{
							continue;
						}
						this.vienz0hIdR.vMovement = this.transform.forward;
						if (47354 - 3751 == 43604)
						{
							continue;
						}
						this.vienz0hIdR.actionState = "standby";
						if (49220 - 166333 != -117113)
						{
							continue;
						}
					}
					this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (175509 - 442636 != -267127)
					{
						continue;
					}
					if (this.vienz0hIdR.moveSpeed < 0.1f * this.vienz0hIdR.runSpeed)
					{
						if (72034 - 332391 == -260356)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (151914 - 294673 != -142759)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (273492 - 286473 == -12980)
						{
							continue;
						}
						this.vienz0hIdR.moveSpeed = (float)0;
						if (39824 - 457017 != -417193)
						{
							continue;
						}
					}
				}
			}
			this.zsFQnCUTqH += mTime;
		}
		while (7441 - 584917 == -577475);
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x000CF0D0 File Offset: 0x000CD2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (160679 - 248458 != -87779)
		{
		}
		do
		{
			if (Time.time - this.vOqQckUhK6 >= this.zsFQnCUTqH)
			{
				if (240703 - 405797 == -165093)
				{
					continue;
				}
				if (Time.time - this.vOqQckUhK6 < this.zsFQnCUTqH + mTime)
				{
					if (11438 - 578529 != -567091)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (234634 - 501764 == -267129)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (4525 - 32655 != -28130)
						{
							continue;
						}
						this.vOqQckUhK6 -= UnityEngine.Random.Range((float)0, rTimer);
						if (294054 - 66874 == 227181)
						{
							continue;
						}
						this.vienz0hIdR.vDirection = this.vienz0hIdR.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (136683 - 540049 == -403365)
						{
							continue;
						}
						this.vienz0hIdR.vDirection.y = this.transform.position.y;
						if (264621 - 305679 != -41058)
						{
							continue;
						}
						this.vienz0hIdR.vMovement = (this.vienz0hIdR.vDirection - this.transform.position).normalized;
						if (18726 - 348329 == -329602)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.vienz0hIdR.vMovement);
						if (113336 - 432545 == -319208)
						{
							continue;
						}
						this.vienz0hIdR.actionState = "run";
						if (183390 - 177434 != 5956)
						{
							continue;
						}
						this.animation.Play("run");
						if (77400 - 108755 != -31355)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (17847 - 110090 != -92243)
						{
							continue;
						}
					}
					this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, this.vienz0hIdR.runSpeed, (float)4 * Time.deltaTime);
					if (89768 - 349214 == -259445)
					{
						continue;
					}
				}
			}
			this.zsFQnCUTqH += mTime;
		}
		while (72046 - 379488 == -307441);
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x000CF3D8 File Offset: 0x000CD5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (32352 - 561564 != -529211)
		{
		}
		do
		{
			if (Time.time - this.vOqQckUhK6 >= this.zsFQnCUTqH)
			{
				if (159859 - 172846 != -12987)
				{
					continue;
				}
				if (Time.time - this.vOqQckUhK6 < this.zsFQnCUTqH + mTime)
				{
					if (205978 - 244933 == -38954)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (284004 - 282202 != 1802)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (134953 - 183366 == -48412)
						{
							continue;
						}
						this.vOqQckUhK6 = Time.time - mTime - this.zsFQnCUTqH;
						if (67165 - 5351 == 61815)
						{
							continue;
						}
						this.vienz0hIdR.vDirection = Vector3.zero;
						if (156045 - 134038 != 22007)
						{
							continue;
						}
						this.vienz0hIdR.vMovement = this.transform.forward;
						if (15660 - 481406 == -465745)
						{
							continue;
						}
						this.vienz0hIdR.actionState = "standby";
						if (10140 - 555724 == -545583)
						{
							continue;
						}
						this.vienz0hIdR.myAttackTarget = this.vienz0hIdR.getHateTarget(15, 40);
						if (82647 - 278577 == -195929)
						{
							continue;
						}
						if (!this.vienz0hIdR.myAttackTarget)
						{
							if (56396 - 156153 == -99756)
							{
								continue;
							}
							this.vienz0hIdR.isAlert = false;
							if (105307 - 247631 != -142324)
							{
								continue;
							}
							this.vOqQckUhK6 = Time.time;
							if (191044 - 66192 == 124853)
							{
								continue;
							}
							this.vienz0hIdR.myAttackTarget = null;
							if (156905 - 50088 == 106818)
							{
								continue;
							}
							this.vienz0hIdR.mOriginalPosition = this.transform.position;
							if (75389 - 525390 != -450001)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.vienz0hIdR.myAttackTarget;
							if (260291 - 132285 == 128007)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (74245 - 32135 != 42110)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (161736 - 254602 != -92866)
								{
									continue;
								}
								this.vienz0hIdR.isAlert = false;
								if (9769 - 368039 != -358270)
								{
									continue;
								}
								this.vOqQckUhK6 = Time.time;
								if (173678 - 104921 != 68757)
								{
									continue;
								}
								this.vienz0hIdR.myAttackTarget = null;
								if (249929 - 534760 != -284831)
								{
									continue;
								}
							}
							else
							{
								this.vienz0hIdR.vDirection = myAttackTarget.transform.position;
								if (198660 - 180939 != 17721)
								{
									continue;
								}
								this.vienz0hIdR.vDirection.y = this.transform.position.y;
								if (117159 - 589688 != -472529)
								{
									continue;
								}
								this.vienz0hIdR.vMovement = (this.vienz0hIdR.vDirection - this.transform.position).normalized;
								if (210761 - 73412 == 137350)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.vienz0hIdR.vMovement);
								if (266789 - 365039 == -98249)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.zsFQnCUTqH += mTime;
		}
		while (195016 - 9026 == 185991);
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x000CF888 File Offset: 0x000CDA88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (53319 - 463557 != -410238)
		{
		}
		do
		{
			if (Time.time - this.vOqQckUhK6 >= this.zsFQnCUTqH)
			{
				if (76489 - 346671 == -270181)
				{
					continue;
				}
				if (Time.time - this.vOqQckUhK6 < this.zsFQnCUTqH + mTime)
				{
					if (202386 - 468024 == -265637)
					{
						continue;
					}
					if (!this.vienz0hIdR.myAttackTarget)
					{
						if (176296 - 388125 == -211828)
						{
							continue;
						}
						this.vOqQckUhK6 = Time.time - mTime - this.zsFQnCUTqH;
						if (90056 - 208674 != -118618)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.vienz0hIdR.myAttackTarget;
						if (157093 - 5417 == 151677)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (59524 - 507045 == -447520)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (85117 - 81433 != 3684)
						{
							continue;
						}
						int tID = 0;
						if (60742 - 250783 == -190040)
						{
							continue;
						}
						if (characterControl)
						{
							if (161136 - 37538 != 123598)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (192681 - 102026 == 90656)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (160854 - 268236 == -107381)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (237703 - 213901 == 23803)
							{
								continue;
							}
							if (this.vienz0hIdR.isTimeOut("nAttack") == (float)0)
							{
								if (63381 - 159609 != -96228)
								{
									continue;
								}
								this.vOqQckUhK6 = Time.time - mTime - this.zsFQnCUTqH;
								if (271887 - 264619 == 7269)
								{
									continue;
								}
								this.Q9hQ5GaRnG.StartCoroutine_Auto(this.Q9hQ5GaRnG.RPC_nAttack(this.transform.position, vector, tID));
								if (30813 - 543363 != -512550)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (182180 - 513424 != -331244)
									{
										continue;
									}
									this.Q9hQ5GaRnG.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (169817 - 385231 != -215414)
									{
										continue;
									}
								}
								goto IL_81;
							}
						}
						if (num < (float)32)
						{
							if (195230 - 295980 == -100749)
							{
								continue;
							}
							if (this.vienz0hIdR.isTimeOut("nAttack") == (float)0)
							{
								if (296325 - 370213 == -73887)
								{
									continue;
								}
								this.vOqQckUhK6 = Time.time - mTime - this.zsFQnCUTqH;
								if (93823 - 159473 != -65650)
								{
									continue;
								}
								this.Q9hQ5GaRnG.StartCoroutine_Auto(this.Q9hQ5GaRnG.RPC_bookThrow(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (85632 - 357780 != -272147)
								{
									if (PhotonClient.IsInitialized())
									{
										if (91045 - 340680 != -249635)
										{
											continue;
										}
										this.Q9hQ5GaRnG.ActionEvent("RPC_bookThrow", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (9194 - 457411 == -448216)
										{
											continue;
										}
									}
									goto IL_81;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (278404 - 112182 != 166222)
						{
							continue;
						}
						this.vienz0hIdR.vDirection = myAttackTarget.transform.position;
						if (23555 - 251439 != -227884)
						{
							continue;
						}
						this.vienz0hIdR.vDirection.y = this.transform.position.y;
						if (47729 - 566849 != -519120)
						{
							continue;
						}
						this.vienz0hIdR.vMovement = (this.vienz0hIdR.vDirection - this.transform.position).normalized;
						if (156157 - 285626 != -129469)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.vienz0hIdR.vMovement);
						if (253467 - 199626 == 53842)
						{
							continue;
						}
						this.vienz0hIdR.actionState = "standby";
						if (117523 - 551421 != -433898)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (296502 - 492345 != -195843)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (70740 - 524165 == -453424)
						{
							continue;
						}
						this.vienz0hIdR.moveSpeed = Mathf.Lerp(this.vienz0hIdR.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (100870 - 303274 != -202404)
						{
							continue;
						}
					}
				}
			}
			IL_81:
			this.zsFQnCUTqH += mTime;
		}
		while (137644 - 432408 == -294763);
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x000CFF30 File Offset: 0x000CE130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (123473 - 253800 != -130326)
		{
		}
		for (;;)
		{
			IL_3F4:
			if (this.wGnQQCvDJA + (float)1 > Time.time)
			{
				if (68758 - 438291 != -369532)
				{
					break;
				}
			}
			else
			{
				this.wGnQQCvDJA = Time.time;
				if (134260 - 106454 == 27806)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (156510 - 289003 == -132493)
					{
						if (50914 - 518128 != -467213)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (215685 - 1002 == 214683)
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
									if (142471 - 394105 == -251633)
									{
										goto IL_3F4;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (73273 - 519453 != -446180)
									{
										goto IL_3F4;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (64124 - 149418 == -85293)
									{
										goto IL_3F4;
									}
									bool flag = true;
									if (139806 - 308119 != -168313)
									{
										goto IL_3F4;
									}
									eRace race = this.vienz0hIdR.Race;
									if (100847 - 175991 != -75144)
									{
										goto IL_3F4;
									}
									if (race == eRace.Tails)
									{
										if (62360 - 51824 == 10537)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_103;
										}
										if (205678 - 105084 != 100594)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (21321 - 387966 != -366645)
											{
												goto IL_3F4;
											}
											goto IL_103;
										}
										goto IL_67E;
										IL_103:
										flag = false;
										if (223391 - 80368 == 143024)
										{
											goto IL_3F4;
										}
									}
									else if (race == eRace.Plants)
									{
										if (96253 - 546810 != -450557)
										{
											goto IL_3F4;
										}
										flag = false;
										if (35562 - 213360 != -177798)
										{
											goto IL_3F4;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (47079 - 569205 != -522126)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_C1;
										}
										if (242667 - 309300 != -66633)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (206779 - 531330 != -324551)
											{
												goto IL_3F4;
											}
											goto IL_C1;
										}
										goto IL_67E;
										IL_C1:
										flag = false;
										if (179753 - 423758 != -244005)
										{
											goto IL_3F4;
										}
									}
									else if (race == eRace.Robots)
									{
										if (212931 - 113812 != 99119)
										{
											goto IL_3F4;
										}
										flag = true;
										if (233525 - 560828 != -327303)
										{
											goto IL_3F4;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (263538 - 48963 != 214575)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_145;
										}
										if (208397 - 166218 != 42179)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_145;
										}
										if (62803 - 105150 == -42346)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (267039 - 251729 != 15311)
											{
												goto IL_145;
											}
											goto IL_3F4;
										}
										goto IL_67E;
										IL_145:
										flag = false;
										if (2676 - 71549 != -68873)
										{
											goto IL_3F4;
										}
									}
									else if (race == eRace.Structure)
									{
										if (75121 - 18172 == 56950)
										{
											goto IL_3F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (225593 - 194120 == 31474)
											{
												goto IL_3F4;
											}
											flag = false;
											if (67829 - 575168 == -507338)
											{
												goto IL_3F4;
											}
										}
									}
									IL_67E:
									if (flag)
									{
										if (152892 - 430210 == -277317)
										{
											goto IL_3F4;
										}
										if (characterControl.hp > 0)
										{
											if (115381 - 222081 == -106699)
											{
												goto IL_3F4;
											}
											if (characterControl.recieveTarget)
											{
												if (166750 - 167743 != -993)
												{
													goto IL_3F4;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (10997 - 517218 == -506220)
													{
														goto IL_3F4;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (230361 - 507932 == -277570)
														{
															goto IL_3F4;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (296797 - 381417 == -84619)
														{
															goto IL_3F4;
														}
														if (vector.sqrMagnitude < (float)900)
														{
															if (58196 - 562228 != -504032)
															{
																goto IL_3F4;
															}
															this.vienz0hIdR.isAlert = true;
															if (65465 - 178588 != -113123)
															{
																goto IL_3F4;
															}
															this.vOqQckUhK6 = Time.time;
															if (156778 - 211109 != -54331)
															{
																goto IL_3F4;
															}
															this.vienz0hIdR.myAttackTarget = gameObject;
															if (261134 - 74206 != 186928)
															{
																goto IL_3F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (18197 - 294867 != -276670)
															{
																goto IL_3F4;
															}
															this.vienz0hIdR.addHate(characterControl.ActorNr, 5);
															if (21250 - 92994 == -71743)
															{
																goto IL_3F4;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (205452 - 404017 == -198564)
															{
																goto IL_3F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (230548 - 540576 != -310028)
															{
																goto IL_3F4;
															}
															if (num < (float)60)
															{
																if (263977 - 585989 == -322011)
																{
																	goto IL_3F4;
																}
																if (characterControl.hp > 0)
																{
																	if (12009 - 598649 == -586639)
																	{
																		goto IL_3F4;
																	}
																	this.vienz0hIdR.isAlert = true;
																	if (40807 - 494033 == -453225)
																	{
																		goto IL_3F4;
																	}
																	this.vOqQckUhK6 = Time.time;
																	if (177591 - 75026 == 102566)
																	{
																		goto IL_3F4;
																	}
																	this.vienz0hIdR.myAttackTarget = gameObject;
																	if (1645 - 479483 != -477838)
																	{
																		goto IL_3F4;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (167639 - 418068 != -250429)
																	{
																		goto IL_3F4;
																	}
																	this.vienz0hIdR.addHate(characterControl.ActorNr, 5);
																	if (222176 - 207745 != 14431)
																	{
																		goto IL_3F4;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								if (6403 - 3137 == 3266)
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

	// Token: 0x060007F7 RID: 2039 RVA: 0x000D0758 File Offset: 0x000CE958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (67967 - 507938 != -439971)
		{
		}
		while (Time.time - this.vOqQckUhK6 > this.zsFQnCUTqH)
		{
			if (247743 - 53234 == 194509)
			{
				this.AI_state = "none";
				if (38480 - 415462 != -376981)
				{
					this.vOqQckUhK6 = Time.time;
					if (279139 - 299238 != -20098)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x000D080C File Offset: 0x000CEA0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x000D0810 File Offset: 0x000CEA10
	internal static bool FrM7LqXLMaUMn411XTF()
	{
		return true;
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x000D0814 File Offset: 0x000CEA14
	internal static bool w0VBKWXOYZ5MJVMucuE()
	{
		return false;
	}

	// Token: 0x04000735 RID: 1845
	private CharacterControl vienz0hIdR;

	// Token: 0x04000736 RID: 1846
	private PaperBug1 Q9hQ5GaRnG;

	// Token: 0x04000737 RID: 1847
	public string AI_state;

	// Token: 0x04000738 RID: 1848
	private float vOqQckUhK6;

	// Token: 0x04000739 RID: 1849
	private float zsFQnCUTqH;

	// Token: 0x0400073A RID: 1850
	private float wGnQQCvDJA;
}
