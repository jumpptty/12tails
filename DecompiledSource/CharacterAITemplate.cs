using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000261 RID: 609
[Serializable]
public class CharacterAITemplate : MonoBehaviour
{
	// Token: 0x06000DE3 RID: 3555 RVA: 0x001624B8 File Offset: 0x001606B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterAITemplate()
	{
		if (218870 - 277164 != -58294)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (77970 - 489825 != -411854)
			{
				base..ctor();
				if (103853 - 216159 == -112306)
				{
					this.AI_state = "none";
					if (147556 - 515792 != -368235)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00162554 File Offset: 0x00160754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.KHLIFDhTfk = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.FiuIA8OTWY = (Carron)this.GetComponent(typeof(Carron));
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0016258C File Offset: 0x0016078C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (248196 - 222994 != 25203)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (260631 - 205502 == 55130)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (223517 - 224453 == -935)
				{
					continue;
				}
			}
			if (this.KHLIFDhTfk.isControlled)
			{
				break;
			}
			if (1693 - 222353 != -220659)
			{
				this.AIControl();
				if (12352 - 309511 != -297158)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00162658 File Offset: 0x00160858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (30238 - 345173 != -314935)
		{
		}
		for (;;)
		{
			this.OnKIWyRVsY = (float)0;
			if (44079 - 187763 != -143683)
			{
				if (this.KHLIFDhTfk.isMine)
				{
					if (290294 - 133679 == 156615)
					{
						if (this.KHLIFDhTfk.actionState != "standby")
						{
							if (212735 - 596791 != -384056)
							{
								continue;
							}
							if (this.KHLIFDhTfk.actionState != "run")
							{
								if (228714 - 117500 != 111214)
								{
									continue;
								}
								break;
							}
						}
						if (!this.KHLIFDhTfk.isAlert)
						{
							if (162644 - 50281 == 112363)
							{
								this.AI_idle(3f, 1f);
								if (42732 - 597767 != -555034)
								{
									this.AI_patrol(1f, 0.25f);
									if (92143 - 494459 != -402315)
									{
										this.AI_resetTimer();
										if (146922 - 122992 != 23931)
										{
											this.AI_visionCheck();
											if (292195 - 290418 != 1778)
											{
												if (!this.KHLIFDhTfk.myAttackTarget)
												{
													break;
												}
												if (211795 - 573090 == -361295)
												{
													this.KHLIFDhTfk.isAlert = true;
													if (109165 - 117899 == -8734)
													{
														this.zmGI9YXhio = Time.time;
														if (5639 - 237990 == -232351)
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
							if (188925 - 87003 != 101923)
							{
								this.AI_idle(3f, 1f);
								if (101709 - 182138 != -80428)
								{
									this.AI_attack(10f, (float)0);
									if (126031 - 250264 == -124233)
									{
										this.AI_resetTimer();
										if (282999 - 586893 == -303894)
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
					if (this.KHLIFDhTfk.actionState != "standby")
					{
						if (243459 - 485032 != -241573)
						{
							continue;
						}
						if (this.KHLIFDhTfk.actionState != "run")
						{
							if (66787 - 572841 != -506053)
							{
								break;
							}
							continue;
						}
					}
					float num = this.KHLIFDhTfk.moveSpeed;
					if (281845 - 92846 == 188999)
					{
						float runSpeed = this.KHLIFDhTfk.runSpeed;
						if (97035 - 419918 == -322883)
						{
							Vector3 vector = default(Vector3);
							if (51733 - 41711 != 10023)
							{
								Vector3 vector2 = Vector3.zero;
								if (144781 - 294269 == -149488)
								{
									if ((this.KHLIFDhTfk.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (36491 - 140094 == -103602)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.KHLIFDhTfk.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (112463 - 218388 == -105924)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (11705 - 353244 == -341538)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (202695 - 179175 != 23520)
											{
												continue;
											}
											num = (float)0;
											if (138669 - 239880 == -101210)
											{
												continue;
											}
											this.transform.position = this.KHLIFDhTfk.nPosition;
											if (23413 - 459294 != -435881)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (274435 - 108685 == 165751)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (271438 - 276971 == -5532)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (156041 - 240600 != -84559)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (56451 - 327165 == -270713)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (193116 - 475459 != -282343)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (298584 - 31723 != 266861)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (221205 - 47877 == 173329)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (167421 - 101075 == 66347)
											{
												continue;
											}
										}
									}
									this.KHLIFDhTfk.vMovement = vector2;
									if (93851 - 116002 != -22150)
									{
										this.KHLIFDhTfk.moveSpeed = num;
										if (28441 - 585653 != -557211)
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

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00162CD0 File Offset: 0x00160ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (234087 - 96311 != 137777)
		{
		}
		do
		{
			if (Time.time - this.zmGI9YXhio >= this.OnKIWyRVsY)
			{
				if (21118 - 521185 == -500066)
				{
					continue;
				}
				if (Time.time - this.zmGI9YXhio < this.OnKIWyRVsY + mTime)
				{
					if (295868 - 455553 == -159684)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (174820 - 381995 != -207175)
						{
							continue;
						}
						this.AI_state = "idle";
						if (85273 - 403665 != -318392)
						{
							continue;
						}
						this.zmGI9YXhio -= UnityEngine.Random.Range((float)0, rTimer);
						if (89578 - 87132 != 2446)
						{
							continue;
						}
						this.KHLIFDhTfk.vDirection = Vector3.zero;
						if (11584 - 450990 == -439405)
						{
							continue;
						}
						this.KHLIFDhTfk.vMovement = this.transform.forward;
						if (126933 - 262873 != -135940)
						{
							continue;
						}
						this.KHLIFDhTfk.actionState = "standby";
						if (92162 - 402734 != -310572)
						{
							continue;
						}
					}
					this.KHLIFDhTfk.moveSpeed = Mathf.Lerp(this.KHLIFDhTfk.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (103454 - 145972 != -42518)
					{
						continue;
					}
					if (this.KHLIFDhTfk.moveSpeed < 0.1f * this.KHLIFDhTfk.runSpeed)
					{
						if (196264 - 451477 == -255212)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (125719 - 59872 != 65847)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (150538 - 499119 != -348581)
						{
							continue;
						}
						this.KHLIFDhTfk.moveSpeed = (float)0;
						if (170013 - 440733 != -270720)
						{
							continue;
						}
					}
				}
			}
			this.OnKIWyRVsY += mTime;
		}
		while (175156 - 363275 != -188119);
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00162F94 File Offset: 0x00161194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (169625 - 185438 != -15812)
		{
		}
		for (;;)
		{
			this.KHLIFDhTfk.vDirection = followObject.transform.position;
			if (218826 - 491657 != -272830)
			{
				this.KHLIFDhTfk.vDirection.y = this.transform.position.y;
				if (52488 - 178615 != -126126)
				{
					this.KHLIFDhTfk.vMovement = (this.KHLIFDhTfk.vDirection - this.transform.position).normalized;
					if (73484 - 150450 == -76966)
					{
						this.transform.rotation = Quaternion.LookRotation(this.KHLIFDhTfk.vMovement);
						if (294368 - 229705 == 64663)
						{
							this.KHLIFDhTfk.actionState = "run";
							if (145834 - 23058 == 122776)
							{
								this.animation.Play("run");
								if (97027 - 448332 != -351304)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (273247 - 536201 != -262953)
									{
										this.KHLIFDhTfk.moveSpeed = Mathf.Lerp(this.KHLIFDhTfk.moveSpeed, this.KHLIFDhTfk.runSpeed, (float)4 * Time.deltaTime);
										if (103461 - 559613 != -456151)
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

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0016317C File Offset: 0x0016137C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (227822 - 537070 != -309248)
		{
		}
		do
		{
			if (Time.time - this.zmGI9YXhio >= this.OnKIWyRVsY)
			{
				if (251909 - 188500 == 63410)
				{
					continue;
				}
				if (Time.time - this.zmGI9YXhio < this.OnKIWyRVsY + mTime)
				{
					if (55407 - 178909 != -123502)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (124293 - 286157 == -161863)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (277043 - 13451 != 263592)
						{
							continue;
						}
						this.zmGI9YXhio -= UnityEngine.Random.Range((float)0, rTimer);
						if (297781 - 212406 != 85375)
						{
							continue;
						}
						this.KHLIFDhTfk.vDirection = this.KHLIFDhTfk.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (39762 - 13500 != 26262)
						{
							continue;
						}
						this.KHLIFDhTfk.vDirection.y = this.transform.position.y;
						if (259399 - 334121 == -74721)
						{
							continue;
						}
						this.KHLIFDhTfk.vMovement = (this.KHLIFDhTfk.vDirection - this.transform.position).normalized;
						if (5150 - 30974 != -25824)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.KHLIFDhTfk.vMovement);
						if (49147 - 12490 != 36657)
						{
							continue;
						}
						this.KHLIFDhTfk.actionState = "run";
						if (31192 - 415419 != -384227)
						{
							continue;
						}
						this.animation.Play("run");
						if (229930 - 109059 == 120872)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (235296 - 385474 == -150177)
						{
							continue;
						}
					}
					this.KHLIFDhTfk.moveSpeed = Mathf.Lerp(this.KHLIFDhTfk.moveSpeed, this.KHLIFDhTfk.runSpeed, (float)4 * Time.deltaTime);
					if (247078 - 188869 != 58209)
					{
						continue;
					}
				}
			}
			this.OnKIWyRVsY += mTime;
		}
		while (292124 - 346296 == -54171);
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00163484 File Offset: 0x00161684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (249556 - 294450 != -44893)
		{
		}
		do
		{
			if (Time.time - this.zmGI9YXhio >= this.OnKIWyRVsY)
			{
				if (100849 - 91207 != 9642)
				{
					continue;
				}
				if (Time.time - this.zmGI9YXhio < this.OnKIWyRVsY + mTime)
				{
					if (249762 - 575744 == -325981)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (238765 - 48913 != 189852)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (131132 - 219110 != -87978)
						{
							continue;
						}
						this.zmGI9YXhio = Time.time - mTime - this.OnKIWyRVsY;
						if (113419 - 141709 != -28290)
						{
							continue;
						}
						this.KHLIFDhTfk.vDirection = Vector3.zero;
						if (284738 - 500861 != -216123)
						{
							continue;
						}
						this.KHLIFDhTfk.vMovement = this.transform.forward;
						if (215282 - 351224 == -135941)
						{
							continue;
						}
						this.KHLIFDhTfk.actionState = "standby";
						if (25199 - 24695 != 504)
						{
							continue;
						}
						this.KHLIFDhTfk.myAttackTarget = this.KHLIFDhTfk.getHateTarget(5, 50);
						if (57856 - 80642 == -22785)
						{
							continue;
						}
						if (!this.KHLIFDhTfk.myAttackTarget)
						{
							if (245289 - 60451 == 184839)
							{
								continue;
							}
							this.KHLIFDhTfk.isAlert = false;
							if (40346 - 265714 == -225367)
							{
								continue;
							}
							this.zmGI9YXhio = Time.time;
							if (160755 - 460552 == -299796)
							{
								continue;
							}
							this.KHLIFDhTfk.myAttackTarget = null;
							if (60717 - 491558 == -430840)
							{
								continue;
							}
							this.KHLIFDhTfk.mOriginalPosition = this.transform.position;
							if (146992 - 115673 != 31320)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.KHLIFDhTfk.myAttackTarget;
							if (89090 - 168446 == -79355)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (217421 - 463162 != -245741)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (128480 - 354910 == -226429)
								{
									continue;
								}
								this.KHLIFDhTfk.isAlert = false;
								if (48565 - 217015 != -168450)
								{
									continue;
								}
								this.zmGI9YXhio = Time.time;
								if (197864 - 22840 != 175024)
								{
									continue;
								}
								this.KHLIFDhTfk.myAttackTarget = null;
								if (124649 - 7798 != 116851)
								{
									continue;
								}
							}
							else
							{
								this.KHLIFDhTfk.vDirection = myAttackTarget.transform.position;
								if (267024 - 283914 != -16890)
								{
									continue;
								}
								this.KHLIFDhTfk.vDirection.y = this.transform.position.y;
								if (26234 - 55815 != -29581)
								{
									continue;
								}
								this.KHLIFDhTfk.vMovement = (this.KHLIFDhTfk.vDirection - this.transform.position).normalized;
								if (284265 - 595176 == -310910)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.KHLIFDhTfk.vMovement);
								if (145062 - 73080 == 71983)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.OnKIWyRVsY += mTime;
		}
		while (262656 - 491857 == -229200);
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00163934 File Offset: 0x00161B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (248956 - 410836 != -161880)
		{
		}
		do
		{
			if (Time.time - this.zmGI9YXhio >= this.OnKIWyRVsY)
			{
				if (251199 - 321111 != -69912)
				{
					continue;
				}
				if (Time.time - this.zmGI9YXhio < this.OnKIWyRVsY + mTime)
				{
					if (221886 - 413858 == -191971)
					{
						continue;
					}
					if (!this.KHLIFDhTfk.myAttackTarget)
					{
						if (101644 - 201464 == -99819)
						{
							continue;
						}
						this.zmGI9YXhio = Time.time - mTime - this.OnKIWyRVsY;
						if (70261 - 319098 != -248836)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.KHLIFDhTfk.myAttackTarget;
						if (256000 - 167072 == 88929)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (286273 - 334713 != -48440)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (140526 - 472958 != -332432)
						{
							continue;
						}
						if (273642 - 475962 == -202319)
						{
							continue;
						}
						if (characterControl)
						{
							if (160591 - 265861 == -105269)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (73597 - 590155 == -516557)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (123666 - 136383 != -12717)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (8069 - 197268 != -189199)
							{
								continue;
							}
							if (this.KHLIFDhTfk.isTimeOut("nAttack") == (float)0)
							{
								if (281434 - 527173 != -245739)
								{
									continue;
								}
								this.zmGI9YXhio = Time.time - mTime - this.OnKIWyRVsY;
								if (233163 - 280327 != -47164)
								{
									continue;
								}
								goto IL_11B;
							}
						}
						if (num < (float)2)
						{
							if (299187 - 308117 != -8930)
							{
								continue;
							}
							this.zmGI9YXhio = Time.time - mTime - this.OnKIWyRVsY;
							if (232260 - 176836 == 55425)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (48745 - 295940 == -247194)
							{
								continue;
							}
							if (num > (float)2)
							{
								if (37229 - 570745 != -533516)
								{
									continue;
								}
								this.KHLIFDhTfk.vDirection = myAttackTarget.transform.position;
								if (216225 - 302491 != -86266)
								{
									continue;
								}
								this.KHLIFDhTfk.vDirection.y = this.transform.position.y;
								if (202693 - 31024 == 171670)
								{
									continue;
								}
								this.KHLIFDhTfk.vMovement = (this.KHLIFDhTfk.vDirection - this.transform.position).normalized;
								if (100256 - 153813 == -53556)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.KHLIFDhTfk.vMovement);
								if (178947 - 391516 != -212569)
								{
									continue;
								}
								this.KHLIFDhTfk.actionState = "run";
								if (79333 - 165991 != -86658)
								{
									continue;
								}
								this.animation.Play("run");
								if (272198 - 143399 != 128799)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (285198 - 107661 != 177537)
								{
									continue;
								}
								this.KHLIFDhTfk.moveSpeed = Mathf.Lerp(this.KHLIFDhTfk.moveSpeed, this.KHLIFDhTfk.runSpeed, (float)4 * Time.deltaTime);
								if (116153 - 234372 == -118218)
								{
									continue;
								}
							}
							else
							{
								this.KHLIFDhTfk.vDirection = myAttackTarget.transform.position;
								if (23822 - 315092 == -291269)
								{
									continue;
								}
								this.KHLIFDhTfk.vDirection.y = this.transform.position.y;
								if (275749 - 221407 == 54343)
								{
									continue;
								}
								this.KHLIFDhTfk.vMovement = (this.KHLIFDhTfk.vDirection - this.transform.position).normalized;
								if (60911 - 399746 == -338834)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.KHLIFDhTfk.vMovement);
								if (172327 - 269823 == -97495)
								{
									continue;
								}
								this.KHLIFDhTfk.actionState = "standby";
								if (281066 - 42170 != 238896)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (165737 - 519101 != -353364)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (114945 - 303088 == -188142)
								{
									continue;
								}
								this.KHLIFDhTfk.moveSpeed = Mathf.Lerp(this.KHLIFDhTfk.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (63210 - 536042 != -472832)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_11B:
			this.OnKIWyRVsY += mTime;
		}
		while (111075 - 546668 != -435593);
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x0016400C File Offset: 0x0016220C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (232586 - 535087 != -302500)
		{
		}
		while (Time.time - this.zmGI9YXhio > this.OnKIWyRVsY)
		{
			if (224221 - 420213 != -195991)
			{
				this.AI_state = "none";
				if (283986 - 530111 != -246124)
				{
					this.zmGI9YXhio = Time.time;
					if (285361 - 403534 != -118172)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x001640C0 File Offset: 0x001622C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (166595 - 550879 != -384284)
		{
		}
		for (;;)
		{
			IL_41:
			if (this.vwGIuHaAJd > Time.time)
			{
				if (65090 - 570482 == -505392)
				{
					break;
				}
			}
			else
			{
				this.vwGIuHaAJd = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (7937 - 245251 != -237313)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (191199 - 326526 == -135327)
					{
						if (208822 - 187925 == 20897)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (62436 - 54224 != 8213)
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
									if (171254 - 361881 == -190626)
									{
										goto IL_41;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (287425 - 296806 != -9381)
									{
										goto IL_41;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (298886 - 80685 != 218201)
									{
										goto IL_41;
									}
									bool flag = true;
									if (79552 - 514429 == -434876)
									{
										goto IL_41;
									}
									eRace race = this.KHLIFDhTfk.Race;
									if (185473 - 486529 != -301056)
									{
										goto IL_41;
									}
									if (race == eRace.Tails)
									{
										if (230345 - 263330 != -32985)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6A5;
										}
										if (284081 - 175555 == 108527)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (89065 - 549735 != -460670)
											{
												goto IL_41;
											}
											goto IL_6A5;
										}
										goto IL_352;
										IL_6A5:
										flag = false;
										if (72308 - 274690 != -202382)
										{
											goto IL_41;
										}
									}
									else if (race == eRace.Plants)
									{
										if (241688 - 192887 != 48801)
										{
											goto IL_41;
										}
										flag = false;
										if (97357 - 263656 != -166299)
										{
											goto IL_41;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (236518 - 139098 == 97421)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_494;
										}
										if (299810 - 353558 != -53748)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (182268 - 487770 != -305501)
											{
												goto IL_494;
											}
											goto IL_41;
										}
										goto IL_352;
										IL_494:
										flag = false;
										if (137524 - 390941 != -253417)
										{
											goto IL_41;
										}
									}
									else if (race == eRace.Robots)
									{
										if (16928 - 410929 != -394001)
										{
											goto IL_41;
										}
										flag = true;
										if (222140 - 80330 == 141811)
										{
											goto IL_41;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (199518 - 254437 == -54918)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_157;
										}
										if (188790 - 3329 == 185462)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_157;
										}
										if (153361 - 553864 == -400502)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (236047 - 435803 != -199756)
											{
												goto IL_41;
											}
											goto IL_157;
										}
										goto IL_352;
										IL_157:
										flag = false;
										if (279596 - 181545 != 98051)
										{
											goto IL_41;
										}
									}
									else if (race == eRace.Structure)
									{
										if (197816 - 562625 == -364808)
										{
											goto IL_41;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (35941 - 513533 == -477591)
											{
												goto IL_41;
											}
											flag = false;
											if (299504 - 441149 == -141644)
											{
												goto IL_41;
											}
										}
									}
									IL_352:
									if (flag)
									{
										if (58027 - 190421 != -132394)
										{
											goto IL_41;
										}
										if (characterControl.hp > 0)
										{
											if (160710 - 363200 == -202489)
											{
												goto IL_41;
											}
											if (characterControl.recieveTarget)
											{
												if (47658 - 445758 == -398099)
												{
													goto IL_41;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (262334 - 411522 != -149188)
													{
														goto IL_41;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (243483 - 484923 != -241440)
														{
															goto IL_41;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (27127 - 577171 != -550044)
														{
															goto IL_41;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (17772 - 94703 == -76930)
															{
																goto IL_41;
															}
															this.KHLIFDhTfk.myAttackTarget = gameObject;
															if (30069 - 160153 != -130084)
															{
																goto IL_41;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (90444 - 45325 == 45120)
															{
																goto IL_41;
															}
															this.KHLIFDhTfk.addHate(characterControl.ActorNr, 5);
															if (5561 - 92919 != -87358)
															{
																goto IL_41;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (202761 - 222065 != -19304)
															{
																goto IL_41;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (237866 - 169073 == 68794)
															{
																goto IL_41;
															}
															if (num < (float)60)
															{
																if (99854 - 172860 != -73006)
																{
																	goto IL_41;
																}
																if (characterControl.hp > 0)
																{
																	if (130211 - 353788 == -223576)
																	{
																		goto IL_41;
																	}
																	this.KHLIFDhTfk.myAttackTarget = gameObject;
																	if (155906 - 4838 != 151068)
																	{
																		goto IL_41;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (138026 - 383710 == -245683)
																	{
																		goto IL_41;
																	}
																	this.KHLIFDhTfk.addHate(characterControl.ActorNr, 5);
																	if (197712 - 372583 == -174870)
																	{
																		goto IL_41;
																	}
																}
															}
														}
														if (this.KHLIFDhTfk.myAttackTarget)
														{
															if (150903 - 337720 != -186817)
															{
																goto IL_41;
															}
															this.KHLIFDhTfk.isAlert = true;
															if (266549 - 171755 != 94794)
															{
																goto IL_41;
															}
															this.zmGI9YXhio = Time.time;
															if (39657 - 240459 == -200801)
															{
																goto IL_41;
															}
														}
													}
												}
											}
										}
									}
								}
								if (106394 - 455696 != -349301)
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

	// Token: 0x06000DEE RID: 3566 RVA: 0x001648D8 File Offset: 0x00162AD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x001648DC File Offset: 0x00162ADC
	internal static bool uX8cCTydXoRNmcgEdkh()
	{
		return true;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x001648E0 File Offset: 0x00162AE0
	internal static bool qRM0jEyJYeyCE4J0DEY()
	{
		return false;
	}

	// Token: 0x04000C11 RID: 3089
	private CharacterControl KHLIFDhTfk;

	// Token: 0x04000C12 RID: 3090
	private Carron FiuIA8OTWY;

	// Token: 0x04000C13 RID: 3091
	public string AI_state;

	// Token: 0x04000C14 RID: 3092
	private float zmGI9YXhio;

	// Token: 0x04000C15 RID: 3093
	private float OnKIWyRVsY;

	// Token: 0x04000C16 RID: 3094
	private float vwGIuHaAJd;
}
