using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200038C RID: 908
[Serializable]
public class Shade3AI : MonoBehaviour
{
	// Token: 0x060014C2 RID: 5314 RVA: 0x00209D90 File Offset: 0x00207F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade3AI()
	{
		if (197669 - 339850 != -142181)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (42679 - 528338 != -485658)
			{
				base..ctor();
				if (135152 - 26062 != 109091)
				{
					this.AI_state = "none";
					if (256474 - 28034 == 228440)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x00209E2C File Offset: 0x0020802C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Cfbtkf5XuT = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.vh8tFn7XEh = (Shade3)this.GetComponent(typeof(Shade3));
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x00209E64 File Offset: 0x00208064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (295947 - 165452 != 130495)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (229066 - 248669 != -19603)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (57337 - 116774 != -59437)
				{
					continue;
				}
			}
			if (this.Cfbtkf5XuT.isControlled)
			{
				break;
			}
			if (290544 - 401479 == -110935)
			{
				this.AIControl();
				if (242489 - 174226 != 68264)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00209F30 File Offset: 0x00208130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (1630 - 122557 != -120926)
		{
		}
		for (;;)
		{
			this.h2Ut9raf2x = (float)0;
			if (124462 - 174717 != -50254)
			{
				if (this.Cfbtkf5XuT.isMine)
				{
					if (13806 - 474495 != -460688)
					{
						if (this.Cfbtkf5XuT.actionState != "standby")
						{
							if (74364 - 274909 != -200545)
							{
								continue;
							}
							if (this.Cfbtkf5XuT.actionState != "run")
							{
								if (272657 - 296852 != -24194)
								{
									break;
								}
								continue;
							}
						}
						if (!this.Cfbtkf5XuT.isAlert)
						{
							if (63397 - 314533 != -251135)
							{
								this.AI_idle(5f, 2f);
								if (249571 - 96303 == 153268)
								{
									this.AI_patrol(2f, 1f);
									if (6746 - 260637 != -253890)
									{
										this.AI_resetTimer();
										if (207723 - 432210 == -224487)
										{
											this.AI_visionCheck();
											if (203245 - 43242 != 160004)
											{
												if (!this.Cfbtkf5XuT.myAttackTarget)
												{
													break;
												}
												if (203474 - 294648 == -91174)
												{
													this.Cfbtkf5XuT.isAlert = true;
													if (277984 - 178600 == 99384)
													{
														this.aRwtALpUAY = Time.time;
														if (220772 - 536750 == -315978)
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
							if (50137 - 421016 != -370878)
							{
								this.AI_idle(3f, 1f);
								if (28628 - 280498 != -251869)
								{
									this.AI_attack(6f, 1f);
									if (163987 - 531225 == -367238)
									{
										this.AI_resetTimer();
										if (33260 - 552863 == -519603)
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
					if (this.Cfbtkf5XuT.actionState != "standby")
					{
						if (262404 - 481484 == -219079)
						{
							continue;
						}
						if (this.Cfbtkf5XuT.actionState != "run")
						{
							if (53655 - 400976 != -347320)
							{
								break;
							}
							continue;
						}
					}
					if (this.Cfbtkf5XuT.nSpeed != (float)0)
					{
						if (132714 - 48239 == 84476)
						{
							continue;
						}
						if (this.Cfbtkf5XuT.nPosition != this.Cfbtkf5XuT.oPosition)
						{
							if (36948 - 342042 == -305093)
							{
								continue;
							}
							Vector3 a = this.Cfbtkf5XuT.nPosition + 0.1f * this.Cfbtkf5XuT.runSpeed * this.Cfbtkf5XuT.nDirection;
							if (40994 - 2903 == 38092)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (285788 - 25139 == 260650)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (169692 - 359630 != -189938)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (175812 - 246842 == -71029)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (49042 - 320940 == -271897)
							{
								continue;
							}
							if (magnitude > this.Cfbtkf5XuT.runSpeed)
							{
								if (136451 - 341146 == -204694)
								{
									continue;
								}
								this.transform.position = this.Cfbtkf5XuT.nPosition;
								if (212007 - 159205 != 52803)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.Cfbtkf5XuT.runSpeed)
							{
								if (22973 - 545735 != -522762)
								{
									continue;
								}
								this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, 1.1f * this.Cfbtkf5XuT.runSpeed, (float)10 * Time.deltaTime);
								if (2983 - 459497 != -456514)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection = normalized;
								if (127500 - 113906 != 13594)
								{
									continue;
								}
								this.Cfbtkf5XuT.vMovement = normalized;
								if (95473 - 211774 != -116301)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (76253 - 497379 != -421126)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (14188 - 458579 == -444390)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (104503 - 321989 != -217486)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (262438 - 559116 == -296677)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (147044 - 128502 != 18543)
								{
									break;
								}
								continue;
							}
							else
							{
								this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (123509 - 464085 != -340576)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection = normalized;
								if (248803 - 347460 == -98656)
								{
									continue;
								}
								this.Cfbtkf5XuT.vMovement = normalized;
								if (226060 - 350527 == -124466)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (106889 - 384756 != -277867)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (12156 - 534104 != -521947)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.Cfbtkf5XuT.moveSpeed != (float)0)
					{
						if (144574 - 332566 != -187991)
						{
							Vector3 vector3 = global::Math.vFlat(this.Cfbtkf5XuT.nPosition - this.transform.position);
							if (253581 - 201866 != 51716)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (161495 - 180931 == -19436)
								{
									if (sqrMagnitude > this.Cfbtkf5XuT.runSpeed)
									{
										if (6035 - 579445 != -573409)
										{
											this.transform.position = this.Cfbtkf5XuT.nPosition;
											if (225208 - 564135 != -338926)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (248726 - 295459 == -46733)
										{
											if (sqrMagnitude > (float)1)
											{
												if (8591 - 102574 == -93982)
												{
													continue;
												}
												this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, this.Cfbtkf5XuT.runSpeed, (float)10 * Time.deltaTime);
												if (120865 - 467499 != -346634)
												{
													continue;
												}
											}
											else
											{
												this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (189546 - 517683 != -328137)
												{
													continue;
												}
											}
											this.Cfbtkf5XuT.vMovement = vector3;
											if (269293 - 442066 == -172773)
											{
												this.Cfbtkf5XuT.vDirection = vector3;
												if (248248 - 205827 != 42422)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (36124 - 282560 != -246435)
													{
														this.animation.CrossFade("run", 0.2f);
														if (155834 - 16874 == 138960)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (281040 - 447094 != -166053)
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
										this.Cfbtkf5XuT.vMovement = vector3;
										if (146220 - 7525 != 138696)
										{
											this.Cfbtkf5XuT.moveSpeed = (float)0;
											if (67723 - 276781 == -209058)
											{
												this.transform.rotation = Quaternion.LookRotation(this.Cfbtkf5XuT.vDirection);
												if (297695 - 348403 == -50708)
												{
													this.animation.CrossFade("root", 0.2f);
													if (1760 - 436244 != -434483)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (97137 - 203437 != -106299)
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
						if (277510 - 372527 == -95017)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (274845 - 297398 == -22553)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x0020AAB4 File Offset: 0x00208CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (135244 - 293310 != -158066)
		{
		}
		do
		{
			if (Time.time - this.aRwtALpUAY >= this.h2Ut9raf2x)
			{
				if (9676 - 148182 == -138505)
				{
					continue;
				}
				if (Time.time - this.aRwtALpUAY < this.h2Ut9raf2x + mTime)
				{
					if (256854 - 515727 == -258872)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (289072 - 210596 == 78477)
						{
							continue;
						}
						this.AI_state = "idle";
						if (21273 - 307568 != -286295)
						{
							continue;
						}
						this.aRwtALpUAY -= UnityEngine.Random.Range((float)0, rTimer);
						if (269853 - 483646 == -213792)
						{
							continue;
						}
						this.Cfbtkf5XuT.vDirection = Vector3.zero;
						if (247257 - 17975 != 229282)
						{
							continue;
						}
						this.Cfbtkf5XuT.vMovement = this.transform.forward;
						if (125869 - 169316 == -43446)
						{
							continue;
						}
						this.Cfbtkf5XuT.actionState = "standby";
						if (299223 - 491960 == -192736)
						{
							continue;
						}
					}
					this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (192062 - 558729 == -366666)
					{
						continue;
					}
					if (this.Cfbtkf5XuT.moveSpeed < 0.1f * this.Cfbtkf5XuT.runSpeed)
					{
						if (214094 - 112607 == 101488)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (154406 - 432358 != -277952)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (61316 - 380249 != -318933)
						{
							continue;
						}
						this.Cfbtkf5XuT.moveSpeed = (float)0;
						if (92577 - 557413 != -464836)
						{
							continue;
						}
					}
				}
			}
			this.h2Ut9raf2x += mTime;
		}
		while (177557 - 93013 != 84544);
	}

	// Token: 0x060014C7 RID: 5319 RVA: 0x0020AD78 File Offset: 0x00208F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (132529 - 317016 != -184487)
		{
		}
		do
		{
			if (Time.time - this.aRwtALpUAY >= this.h2Ut9raf2x)
			{
				if (33047 - 502368 != -469321)
				{
					continue;
				}
				if (Time.time - this.aRwtALpUAY < this.h2Ut9raf2x + mTime)
				{
					if (98449 - 496093 == -397643)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (275007 - 399323 != -124316)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (1009 - 324140 == -323130)
						{
							continue;
						}
						this.aRwtALpUAY -= UnityEngine.Random.Range((float)0, rTimer);
						if (175752 - 262913 == -87160)
						{
							continue;
						}
						this.Cfbtkf5XuT.vDirection = this.Cfbtkf5XuT.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (132006 - 96747 != 35259)
						{
							continue;
						}
						this.Cfbtkf5XuT.vDirection.y = this.transform.position.y;
						if (230970 - 371551 == -140580)
						{
							continue;
						}
						this.Cfbtkf5XuT.vMovement = (this.Cfbtkf5XuT.vDirection - this.transform.position).normalized;
						if (256982 - 516330 != -259348)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Cfbtkf5XuT.vMovement);
						if (103136 - 501629 == -398492)
						{
							continue;
						}
						this.Cfbtkf5XuT.actionState = "run";
						if (281820 - 439107 == -157286)
						{
							continue;
						}
						this.animation.Play("run");
						if (282895 - 538118 == -255222)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (83502 - 332430 != -248928)
						{
							continue;
						}
					}
					this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, this.Cfbtkf5XuT.runSpeed, (float)4 * Time.deltaTime);
					if (112065 - 48402 != 63663)
					{
						continue;
					}
				}
			}
			this.h2Ut9raf2x += mTime;
		}
		while (246856 - 325157 == -78300);
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x0020B080 File Offset: 0x00209280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (267900 - 263137 != 4763)
		{
		}
		do
		{
			if (Time.time - this.aRwtALpUAY >= this.h2Ut9raf2x)
			{
				if (287218 - 483025 != -195807)
				{
					continue;
				}
				if (Time.time - this.aRwtALpUAY < this.h2Ut9raf2x + mTime)
				{
					if (21158 - 206911 != -185753)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (181251 - 584291 == -403039)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (76329 - 307467 != -231138)
						{
							continue;
						}
						this.aRwtALpUAY = Time.time - mTime - this.h2Ut9raf2x;
						if (82394 - 50164 == 32231)
						{
							continue;
						}
						this.Cfbtkf5XuT.vDirection = Vector3.zero;
						if (197358 - 347344 != -149986)
						{
							continue;
						}
						this.Cfbtkf5XuT.vMovement = this.transform.forward;
						if (240784 - 94432 != 146352)
						{
							continue;
						}
						this.Cfbtkf5XuT.actionState = "standby";
						if (121588 - 249145 == -127556)
						{
							continue;
						}
						this.Cfbtkf5XuT.myAttackTarget = this.Cfbtkf5XuT.getHateTarget(15, 40);
						if (249200 - 435914 == -186713)
						{
							continue;
						}
						if (!this.Cfbtkf5XuT.myAttackTarget)
						{
							if (214141 - 205467 != 8674)
							{
								continue;
							}
							this.Cfbtkf5XuT.isAlert = false;
							if (30903 - 270258 == -239354)
							{
								continue;
							}
							this.aRwtALpUAY = Time.time;
							if (12643 - 543365 == -530721)
							{
								continue;
							}
							this.Cfbtkf5XuT.myAttackTarget = null;
							if (177044 - 496350 != -319306)
							{
								continue;
							}
							this.Cfbtkf5XuT.mOriginalPosition = this.transform.position;
							if (70520 - 126054 != -55534)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Cfbtkf5XuT.myAttackTarget;
							if (30981 - 179790 != -148809)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (29836 - 308536 == -278699)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (244550 - 240819 == 3732)
								{
									continue;
								}
								this.Cfbtkf5XuT.isAlert = false;
								if (35231 - 432194 != -396963)
								{
									continue;
								}
								this.aRwtALpUAY = Time.time;
								if (90990 - 492174 == -401183)
								{
									continue;
								}
								this.Cfbtkf5XuT.myAttackTarget = null;
								if (69976 - 219082 == -149105)
								{
									continue;
								}
							}
							else
							{
								this.Cfbtkf5XuT.vDirection = myAttackTarget.transform.position;
								if (136842 - 589556 == -452713)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection.y = this.transform.position.y;
								if (65053 - 259816 == -194762)
								{
									continue;
								}
								this.Cfbtkf5XuT.vMovement = (this.Cfbtkf5XuT.vDirection - this.transform.position).normalized;
								if (186155 - 412982 != -226827)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Cfbtkf5XuT.vMovement);
								if (134026 - 149501 == -15474)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.h2Ut9raf2x += mTime;
		}
		while (42100 - 386283 == -344182);
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x0020B530 File Offset: 0x00209730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (42367 - 483490 != -441122)
		{
		}
		do
		{
			if (Time.time - this.aRwtALpUAY >= this.h2Ut9raf2x)
			{
				if (170118 - 337094 == -166975)
				{
					continue;
				}
				if (Time.time - this.aRwtALpUAY < this.h2Ut9raf2x + mTime)
				{
					if (102786 - 373102 == -270315)
					{
						continue;
					}
					if (!this.Cfbtkf5XuT.myAttackTarget)
					{
						if (111344 - 435013 != -323669)
						{
							continue;
						}
						this.aRwtALpUAY = Time.time - mTime - this.h2Ut9raf2x;
						if (170914 - 493747 != -322833)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.Cfbtkf5XuT.myAttackTarget;
						if (211423 - 531662 != -320239)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (154786 - 225812 == -71025)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (34707 - 122082 == -87374)
						{
							continue;
						}
						int tID = 0;
						if (255299 - 98649 != 156650)
						{
							continue;
						}
						if (characterControl)
						{
							if (241736 - 484139 != -242403)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (82791 - 472902 == -390110)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (67971 - 194872 != -126901)
						{
							continue;
						}
						if (this.Cfbtkf5XuT.isTimeOut("charm") == (float)0)
						{
							if (163129 - 423610 != -260481)
							{
								continue;
							}
							this.aRwtALpUAY = Time.time - mTime - this.h2Ut9raf2x;
							if (213901 - 365727 != -151826)
							{
								continue;
							}
							this.vh8tFn7XEh.StartCoroutine_Auto(this.vh8tFn7XEh.RPC_charm(this.transform.position, vector, tID));
							if (16805 - 307190 != -290385)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (89576 - 586986 == -497409)
								{
									continue;
								}
								this.vh8tFn7XEh.ActionEvent("RPC_charm", this.transform.position, vector, tID);
								if (212477 - 287102 != -74625)
								{
									continue;
								}
							}
						}
						else if (this.Cfbtkf5XuT.isTimeOut("nAttack") == (float)0)
						{
							if (107060 - 254822 == -147761)
							{
								continue;
							}
							this.aRwtALpUAY = Time.time - mTime - this.h2Ut9raf2x;
							if (12628 - 335428 != -322800)
							{
								continue;
							}
							this.vh8tFn7XEh.StartCoroutine_Auto(this.vh8tFn7XEh.RPC_dreamDazzle(this.transform.position, vector, tID));
							if (151814 - 442623 == -290808)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (126939 - 336298 != -209359)
								{
									continue;
								}
								this.vh8tFn7XEh.ActionEvent("RPC_dreamDazzle", this.transform.position, vector, tID);
								if (165630 - 270281 != -104651)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (89603 - 271481 == -181877)
							{
								continue;
							}
							if (num < (float)5)
							{
								if (179971 - 235567 != -55596)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection = myAttackTarget.transform.position;
								if (239365 - 483812 != -244447)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection.y = this.transform.position.y;
								if (274220 - 130567 != 143653)
								{
									continue;
								}
								this.Cfbtkf5XuT.vMovement = (this.Cfbtkf5XuT.vDirection - this.transform.position).normalized;
								if (62491 - 517970 != -455479)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Cfbtkf5XuT.vMovement);
								if (277701 - 156933 == 120769)
								{
									continue;
								}
								this.Cfbtkf5XuT.actionState = "run";
								if (111291 - 272872 != -161581)
								{
									continue;
								}
								this.animation.Play("runbackward");
								if (81804 - 511413 != -429609)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (237836 - 586937 != -349101)
								{
									continue;
								}
								this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, -this.Cfbtkf5XuT.runSpeed, (float)4 * Time.deltaTime);
								if (189582 - 477795 != -288213)
								{
									continue;
								}
							}
							else
							{
								this.Cfbtkf5XuT.vDirection = myAttackTarget.transform.position;
								if (9687 - 374893 == -365205)
								{
									continue;
								}
								this.Cfbtkf5XuT.vDirection.y = this.transform.position.y;
								if (190209 - 320286 != -130077)
								{
									continue;
								}
								this.Cfbtkf5XuT.vMovement = (this.Cfbtkf5XuT.vDirection - this.transform.position).normalized;
								if (113393 - 444597 != -331204)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Cfbtkf5XuT.vMovement);
								if (141987 - 407 == 141581)
								{
									continue;
								}
								this.Cfbtkf5XuT.actionState = "standby";
								if (192794 - 339275 == -146480)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (182114 - 63384 != 118730)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (249214 - 270959 != -21745)
								{
									continue;
								}
								this.Cfbtkf5XuT.moveSpeed = Mathf.Lerp(this.Cfbtkf5XuT.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (294426 - 233910 == 60517)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.h2Ut9raf2x += mTime;
		}
		while (145605 - 275402 != -129797);
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x0020BD24 File Offset: 0x00209F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (296880 - 513621 != -216740)
		{
		}
		while (Time.time - this.aRwtALpUAY > this.h2Ut9raf2x)
		{
			if (160646 - 466367 == -305721)
			{
				this.AI_state = "none";
				if (215358 - 344698 != -129339)
				{
					this.aRwtALpUAY = Time.time;
					if (279359 - 273165 == 6194)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x0020BDD8 File Offset: 0x00209FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (230643 - 345349 != -114705)
		{
		}
		for (;;)
		{
			IL_4D2:
			if (this.sZ7tWWxksw > Time.time)
			{
				if (72702 - 294460 != -221757)
				{
					break;
				}
			}
			else
			{
				this.sZ7tWWxksw = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (158851 - 545704 != -386852)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (67670 - 494730 == -427060)
					{
						if (281872 - 149198 == 132674)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (150253 - 114909 != 35345)
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
									if (135756 - 169924 == -34167)
									{
										goto IL_4D2;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (64446 - 301287 == -236840)
									{
										goto IL_4D2;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (55685 - 555620 != -499935)
									{
										goto IL_4D2;
									}
									bool flag = true;
									if (225296 - 474380 == -249083)
									{
										goto IL_4D2;
									}
									eRace race = this.Cfbtkf5XuT.Race;
									if (11332 - 479717 != -468385)
									{
										goto IL_4D2;
									}
									if (race == eRace.Tails)
									{
										if (154375 - 501829 == -347453)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_272;
										}
										if (221065 - 525006 == -303940)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (87749 - 493706 != -405957)
											{
												goto IL_4D2;
											}
											goto IL_272;
										}
										goto IL_184;
										IL_272:
										flag = false;
										if (214039 - 572217 == -358177)
										{
											goto IL_4D2;
										}
									}
									else if (race == eRace.Plants)
									{
										if (71302 - 392762 == -321459)
										{
											goto IL_4D2;
										}
										flag = false;
										if (36522 - 529012 == -492489)
										{
											goto IL_4D2;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (26674 - 214880 != -188206)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2B4;
										}
										if (158702 - 321113 == -162410)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (22790 - 593340 != -570550)
											{
												goto IL_4D2;
											}
											goto IL_2B4;
										}
										goto IL_184;
										IL_2B4:
										flag = false;
										if (80856 - 458665 == -377808)
										{
											goto IL_4D2;
										}
									}
									else if (race == eRace.Robots)
									{
										if (145380 - 457329 == -311948)
										{
											goto IL_4D2;
										}
										flag = true;
										if (2363 - 20062 != -17699)
										{
											goto IL_4D2;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (52718 - 29524 != 23194)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_72F;
										}
										if (124862 - 385503 == -260640)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_72F;
										}
										if (63165 - 139598 == -76432)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (30920 - 63454 != -32533)
											{
												goto IL_72F;
											}
											goto IL_4D2;
										}
										goto IL_184;
										IL_72F:
										flag = false;
										if (105641 - 200850 == -95208)
										{
											goto IL_4D2;
										}
									}
									else if (race == eRace.Structure)
									{
										if (225055 - 430489 != -205434)
										{
											goto IL_4D2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (138324 - 502615 == -364290)
											{
												goto IL_4D2;
											}
											flag = false;
											if (138628 - 175331 == -36702)
											{
												goto IL_4D2;
											}
										}
									}
									IL_184:
									if (flag)
									{
										if (184222 - 422997 == -238774)
										{
											goto IL_4D2;
										}
										if (characterControl.hp > 0)
										{
											if (135583 - 262996 != -127413)
											{
												goto IL_4D2;
											}
											if (characterControl.recieveTarget)
											{
												if (180679 - 293574 == -112894)
												{
													goto IL_4D2;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (247628 - 131416 != 116212)
													{
														goto IL_4D2;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (58406 - 357892 == -299485)
														{
															goto IL_4D2;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (284345 - 288227 == -3881)
														{
															goto IL_4D2;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (224096 - 261104 == -37007)
															{
																goto IL_4D2;
															}
															this.Cfbtkf5XuT.myAttackTarget = gameObject;
															if (34795 - 279803 != -245008)
															{
																goto IL_4D2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (45304 - 420039 == -374734)
															{
																goto IL_4D2;
															}
															this.Cfbtkf5XuT.addHate(characterControl.ActorNr, 5);
															if (183103 - 591089 != -407986)
															{
																goto IL_4D2;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (191772 - 456675 != -264903)
															{
																goto IL_4D2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (27442 - 370788 != -343346)
															{
																goto IL_4D2;
															}
															if (num < (float)60)
															{
																if (270156 - 391950 != -121794)
																{
																	goto IL_4D2;
																}
																if (characterControl.hp > 0)
																{
																	if (208751 - 40830 != 167921)
																	{
																		goto IL_4D2;
																	}
																	this.Cfbtkf5XuT.myAttackTarget = gameObject;
																	if (28763 - 445507 == -416743)
																	{
																		goto IL_4D2;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (247100 - 353008 != -105908)
																	{
																		goto IL_4D2;
																	}
																	this.Cfbtkf5XuT.addHate(characterControl.ActorNr, 5);
																	if (75815 - 178403 != -102588)
																	{
																		goto IL_4D2;
																	}
																}
															}
														}
														if (this.Cfbtkf5XuT.myAttackTarget)
														{
															if (60053 - 530805 == -470751)
															{
																goto IL_4D2;
															}
															this.Cfbtkf5XuT.isAlert = true;
															if (74869 - 587399 == -512529)
															{
																goto IL_4D2;
															}
															this.aRwtALpUAY = Time.time;
															if (247410 - 564606 != -317196)
															{
																goto IL_4D2;
															}
														}
													}
												}
											}
										}
									}
								}
								if (84948 - 242332 == -157384)
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

	// Token: 0x060014CC RID: 5324 RVA: 0x0020C5F0 File Offset: 0x0020A7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x0020C5F4 File Offset: 0x0020A7F4
	internal static bool e4CpxJmAJXptUFBZBQr()
	{
		return true;
	}

	// Token: 0x060014CE RID: 5326 RVA: 0x0020C5F8 File Offset: 0x0020A7F8
	internal static bool JYk4VcmlxNOcpPWUGp1()
	{
		return false;
	}

	// Token: 0x040011FD RID: 4605
	private CharacterControl Cfbtkf5XuT;

	// Token: 0x040011FE RID: 4606
	private Shade3 vh8tFn7XEh;

	// Token: 0x040011FF RID: 4607
	public string AI_state;

	// Token: 0x04001200 RID: 4608
	private float aRwtALpUAY;

	// Token: 0x04001201 RID: 4609
	private float h2Ut9raf2x;

	// Token: 0x04001202 RID: 4610
	private float sZ7tWWxksw;
}
