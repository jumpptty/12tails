using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D85 RID: 3461
[Serializable]
public class RabbitCult_AI : MonoBehaviour
{
	// Token: 0x06004DEF RID: 19951 RVA: 0x009960B4 File Offset: 0x009942B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RabbitCult_AI()
	{
		if (78097 - 318984 != -240887)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (8261 - 228992 != -220730)
			{
				base..ctor();
				if (91890 - 108909 != -17018)
				{
					this.AI_state = "none";
					if (215799 - 431937 == -216138)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x00996150 File Offset: 0x00994350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.WJ9cnQeouCL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.jJMcneOrBFs = (RabbitCult)this.GetComponent(typeof(RabbitCult));
	}

	// Token: 0x06004DF1 RID: 19953 RVA: 0x00996188 File Offset: 0x00994388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (263228 - 346328 != -83099)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (58463 - 96320 != -37857)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (161458 - 384638 != -223180)
				{
					continue;
				}
			}
			if (this.WJ9cnQeouCL.isControlled)
			{
				break;
			}
			if (239059 - 289207 != -50147)
			{
				this.AIControl();
				if (15977 - 143754 != -127776)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x00996254 File Offset: 0x00994454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (122331 - 502249 != -379917)
		{
		}
		for (;;)
		{
			this.gw6cnJF8gjJ = (float)0;
			if (156686 - 568661 != -411974)
			{
				if (this.WJ9cnQeouCL.isMine)
				{
					if (298087 - 520772 != -222684)
					{
						if (this.WJ9cnQeouCL.actionState != "standby")
						{
							if (54477 - 79300 == -24822)
							{
								continue;
							}
							if (this.WJ9cnQeouCL.actionState != "run")
							{
								if (36312 - 505128 != -468815)
								{
									break;
								}
								continue;
							}
						}
						if (!this.WJ9cnQeouCL.isAlert)
						{
							if (245412 - 98592 != 146821)
							{
								this.AI_idle(6f, 1f);
								if (91337 - 462877 == -371540)
								{
									this.AI_patrol(2f, 1f);
									if (246157 - 52158 != 194000)
									{
										this.AI_resetTimer();
										if (11710 - 424422 != -412711)
										{
											this.AI_visionCheck();
											if (248396 - 101102 == 147294)
											{
												if (!this.WJ9cnQeouCL.myAttackTarget)
												{
													break;
												}
												if (18367 - 236935 != -218567)
												{
													this.WJ9cnQeouCL.isAlert = true;
													if (207491 - 515841 != -308349)
													{
														this.KE8cnIKnxjY = Time.time;
														if (99974 - 374626 != -274651)
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
							if (209027 - 359705 == -150678)
							{
								this.AI_patrol(2f, 1f);
								if (158759 - 452096 == -293337)
								{
									this.AI_attack(10f, (float)0);
									if (245650 - 364733 == -119083)
									{
										this.AI_resetTimer();
										if (9621 - 76578 != -66956)
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
					if (this.WJ9cnQeouCL.actionState != "standby")
					{
						if (288186 - 195185 == 93002)
						{
							continue;
						}
						if (this.WJ9cnQeouCL.actionState != "run")
						{
							if (130724 - 454304 != -323579)
							{
								break;
							}
							continue;
						}
					}
					float num = this.WJ9cnQeouCL.moveSpeed;
					if (149075 - 281996 == -132921)
					{
						float runSpeed = this.WJ9cnQeouCL.runSpeed;
						if (76252 - 338483 != -262230)
						{
							Vector3 vector = default(Vector3);
							if (102841 - 364247 != -261405)
							{
								Vector3 vector2 = Vector3.zero;
								if (218606 - 590642 != -372035)
								{
									if ((this.WJ9cnQeouCL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (266180 - 8178 == 258003)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.WJ9cnQeouCL.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (279306 - 103606 != 175700)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (52297 - 284964 != -232667)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (266066 - 474776 != -208710)
											{
												continue;
											}
											num = (float)0;
											if (105015 - 533300 == -428284)
											{
												continue;
											}
											this.transform.position = this.WJ9cnQeouCL.nPosition;
											if (142920 - 465891 != -322971)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (30985 - 472375 == -441389)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (172808 - 33618 == 139191)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (201067 - 332469 != -131402)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (182723 - 408955 == -226231)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (96501 - 406727 != -310226)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (10773 - 342739 != -331966)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (59364 - 429975 == -370610)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (9830 - 285116 != -275286)
											{
												continue;
											}
										}
									}
									this.WJ9cnQeouCL.vMovement = vector2;
									if (239254 - 522748 != -283493)
									{
										this.WJ9cnQeouCL.moveSpeed = num;
										if (203383 - 112227 == 91156)
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

	// Token: 0x06004DF3 RID: 19955 RVA: 0x009968CC File Offset: 0x00994ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (163460 - 473651 != -310190)
		{
		}
		do
		{
			if (Time.time - this.KE8cnIKnxjY >= this.gw6cnJF8gjJ)
			{
				if (22407 - 289454 != -267047)
				{
					continue;
				}
				if (Time.time - this.KE8cnIKnxjY < this.gw6cnJF8gjJ + mTime)
				{
					if (115979 - 317136 == -201156)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (98021 - 564061 != -466040)
						{
							continue;
						}
						this.AI_state = "idle";
						if (141189 - 7964 == 133226)
						{
							continue;
						}
						this.KE8cnIKnxjY -= UnityEngine.Random.Range((float)0, rTimer);
						if (138958 - 505290 != -366332)
						{
							continue;
						}
						this.WJ9cnQeouCL.vDirection = Vector3.zero;
						if (62819 - 516292 != -453473)
						{
							continue;
						}
						this.WJ9cnQeouCL.vMovement = this.transform.forward;
						if (192912 - 170783 != 22129)
						{
							continue;
						}
						this.WJ9cnQeouCL.actionState = "standby";
						if (218994 - 557585 != -338591)
						{
							continue;
						}
					}
					this.WJ9cnQeouCL.moveSpeed = Mathf.Lerp(this.WJ9cnQeouCL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (16696 - 424786 == -408089)
					{
						continue;
					}
					if (this.WJ9cnQeouCL.moveSpeed < 0.1f * this.WJ9cnQeouCL.runSpeed)
					{
						if (273396 - 67668 == 205729)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (125606 - 526013 == -400406)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (208117 - 380560 == -172442)
						{
							continue;
						}
						this.WJ9cnQeouCL.moveSpeed = (float)0;
						if (188486 - 490246 == -301759)
						{
							continue;
						}
					}
				}
			}
			this.gw6cnJF8gjJ += mTime;
		}
		while (216570 - 387949 != -171379);
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x00996B90 File Offset: 0x00994D90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (251224 - 190598 != 60626)
		{
		}
		do
		{
			if (Time.time - this.KE8cnIKnxjY >= this.gw6cnJF8gjJ)
			{
				if (224857 - 257036 != -32179)
				{
					continue;
				}
				if (Time.time - this.KE8cnIKnxjY < this.gw6cnJF8gjJ + mTime)
				{
					if (146088 - 460437 != -314349)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (137517 - 159868 != -22351)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (151640 - 145024 == 6617)
						{
							continue;
						}
						this.KE8cnIKnxjY -= UnityEngine.Random.Range((float)0, rTimer);
						if (228451 - 264741 != -36290)
						{
							continue;
						}
						this.WJ9cnQeouCL.vDirection = this.WJ9cnQeouCL.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (100953 - 12277 == 88677)
						{
							continue;
						}
						this.WJ9cnQeouCL.vDirection.y = this.transform.position.y;
						if (233061 - 442002 != -208941)
						{
							continue;
						}
						this.WJ9cnQeouCL.vMovement = (this.WJ9cnQeouCL.vDirection - this.transform.position).normalized;
						if (127555 - 381824 == -254268)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.WJ9cnQeouCL.vMovement);
						if (83811 - 556114 != -472303)
						{
							continue;
						}
						this.WJ9cnQeouCL.actionState = "run";
						if (284229 - 344106 == -59876)
						{
							continue;
						}
						this.animation.Play("run");
						if (297209 - 207607 == 89603)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (146553 - 270512 == -123958)
						{
							continue;
						}
					}
					this.WJ9cnQeouCL.moveSpeed = Mathf.Lerp(this.WJ9cnQeouCL.moveSpeed, this.WJ9cnQeouCL.runSpeed, (float)4 * Time.deltaTime);
					if (242125 - 473583 != -231458)
					{
						continue;
					}
				}
			}
			this.gw6cnJF8gjJ += mTime;
		}
		while (235708 - 560872 != -325164);
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x00996E98 File Offset: 0x00995098
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (253936 - 304042 != -50105)
		{
		}
		do
		{
			if (Time.time - this.KE8cnIKnxjY >= this.gw6cnJF8gjJ)
			{
				if (169812 - 456213 == -286400)
				{
					continue;
				}
				if (Time.time - this.KE8cnIKnxjY < this.gw6cnJF8gjJ + mTime)
				{
					if (198881 - 284661 != -85780)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (159259 - 368118 != -208859)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (292923 - 169208 == 123716)
						{
							continue;
						}
						this.KE8cnIKnxjY = Time.time - mTime - this.gw6cnJF8gjJ;
						if (41847 - 250966 == -209118)
						{
							continue;
						}
						this.WJ9cnQeouCL.vDirection = Vector3.zero;
						if (130887 - 526125 != -395238)
						{
							continue;
						}
						this.WJ9cnQeouCL.vMovement = this.transform.forward;
						if (173314 - 289262 == -115947)
						{
							continue;
						}
						this.WJ9cnQeouCL.actionState = "standby";
						if (63041 - 334036 == -270994)
						{
							continue;
						}
						this.WJ9cnQeouCL.myAttackTarget = this.WJ9cnQeouCL.getHateTarget(5, 50);
						if (241683 - 392681 != -150998)
						{
							continue;
						}
						if (!this.WJ9cnQeouCL.myAttackTarget)
						{
							if (223820 - 349850 == -126029)
							{
								continue;
							}
							this.WJ9cnQeouCL.isAlert = false;
							if (215032 - 590049 == -375016)
							{
								continue;
							}
							this.KE8cnIKnxjY = Time.time;
							if (238125 - 318895 == -80769)
							{
								continue;
							}
							this.WJ9cnQeouCL.myAttackTarget = null;
							if (134013 - 79712 == 54302)
							{
								continue;
							}
							this.WJ9cnQeouCL.mOriginalPosition = this.transform.position;
							if (16835 - 381864 != -365029)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.WJ9cnQeouCL.myAttackTarget;
							if (200357 - 177096 != 23261)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (289508 - 362823 != -73315)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (85043 - 524919 != -439876)
								{
									continue;
								}
								this.WJ9cnQeouCL.isAlert = false;
								if (132232 - 395446 == -263213)
								{
									continue;
								}
								this.KE8cnIKnxjY = Time.time;
								if (55080 - 551212 != -496132)
								{
									continue;
								}
								this.WJ9cnQeouCL.myAttackTarget = null;
								if (46140 - 31678 != 14462)
								{
									continue;
								}
							}
							else
							{
								this.WJ9cnQeouCL.vDirection = myAttackTarget.transform.position;
								if (126878 - 429740 != -302862)
								{
									continue;
								}
								this.WJ9cnQeouCL.vDirection.y = this.transform.position.y;
								if (86599 - 6049 != 80550)
								{
									continue;
								}
								this.WJ9cnQeouCL.vMovement = (this.WJ9cnQeouCL.vDirection - this.transform.position).normalized;
								if (32521 - 291856 == -259334)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.WJ9cnQeouCL.vMovement);
								if (282045 - 547231 != -265186)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.gw6cnJF8gjJ += mTime;
		}
		while (250421 - 176915 != 73506);
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x00997348 File Offset: 0x00995548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (166349 - 43477 != 122873)
		{
		}
		do
		{
			if (Time.time - this.KE8cnIKnxjY >= this.gw6cnJF8gjJ)
			{
				if (184671 - 332046 == -147374)
				{
					continue;
				}
				if (Time.time - this.KE8cnIKnxjY < this.gw6cnJF8gjJ + mTime)
				{
					if (134349 - 222697 != -88348)
					{
						continue;
					}
					if (!this.WJ9cnQeouCL.myAttackTarget)
					{
						if (75202 - 64709 != 10493)
						{
							continue;
						}
						this.KE8cnIKnxjY = Time.time - mTime - this.gw6cnJF8gjJ;
						if (225074 - 527022 != -301947)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.WJ9cnQeouCL.myAttackTarget;
						if (45873 - 236086 == -190212)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (26222 - 57123 == -30900)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (296890 - 545319 != -248429)
						{
							continue;
						}
						int tID = 0;
						if (203393 - 351063 == -147669)
						{
							continue;
						}
						if (characterControl)
						{
							if (288729 - 511716 == -222986)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (60302 - 475597 == -415294)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (10802 - 340677 != -329875)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (118155 - 494003 == -375847)
							{
								continue;
							}
							if (this.WJ9cnQeouCL.isTimeOut("nAttack") == (float)0)
							{
								if (276063 - 47117 != 228946)
								{
									continue;
								}
								this.KE8cnIKnxjY = Time.time - mTime - this.gw6cnJF8gjJ;
								if (129312 - 42787 != 86525)
								{
									continue;
								}
								this.jJMcneOrBFs.StartCoroutine_Auto(this.jJMcneOrBFs.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (158291 - 107445 != 50846)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (73087 - 82151 == -9063)
									{
										continue;
									}
									this.jJMcneOrBFs.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
									if (277255 - 81097 != 196158)
									{
										continue;
									}
								}
								goto IL_49C;
							}
						}
						if (num > (float)3)
						{
							if (8787 - 188784 == -179996)
							{
								continue;
							}
							if (this.WJ9cnQeouCL.isTimeOut("maimShot") == (float)0)
							{
								if (108927 - 391315 != -282388)
								{
									continue;
								}
								this.KE8cnIKnxjY = Time.time - mTime - this.gw6cnJF8gjJ;
								if (216596 - 282895 != -66299)
								{
									continue;
								}
								this.jJMcneOrBFs.StartCoroutine_Auto(this.jJMcneOrBFs.RPC_maimShot(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (15277 - 54923 != -39645)
								{
									if (PhotonClient.IsInitialized())
									{
										if (260543 - 359524 != -98981)
										{
											continue;
										}
										this.jJMcneOrBFs.ActionEvent("RPC_maimShot", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (73735 - 160341 != -86606)
										{
											continue;
										}
									}
									goto IL_49C;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (298684 - 371426 != -72742)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (20485 - 548511 != -528026)
							{
								continue;
							}
							this.WJ9cnQeouCL.vDirection = this.transform.position - global::Math.vFlat(myAttackTarget.transform.position - this.transform.position).normalized;
							if (239346 - 10015 != 229331)
							{
								continue;
							}
							this.WJ9cnQeouCL.vMovement = (this.WJ9cnQeouCL.vDirection - this.transform.position).normalized;
							if (109324 - 225833 != -116509)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.WJ9cnQeouCL.vMovement);
							if (74420 - 114577 == -40156)
							{
								continue;
							}
							this.WJ9cnQeouCL.actionState = "run";
							if (14178 - 132354 != -118176)
							{
								continue;
							}
							this.animation.Play("run");
							if (234157 - 3622 == 230536)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (34493 - 207782 != -173289)
							{
								continue;
							}
							this.WJ9cnQeouCL.moveSpeed = Mathf.Lerp(this.WJ9cnQeouCL.moveSpeed, this.WJ9cnQeouCL.runSpeed, (float)4 * Time.deltaTime);
							if (91075 - 98228 == -7152)
							{
								continue;
							}
						}
						else if (num > (float)24)
						{
							if (126932 - 367731 == -240798)
							{
								continue;
							}
							this.WJ9cnQeouCL.vDirection = myAttackTarget.transform.position;
							if (78471 - 396511 != -318040)
							{
								continue;
							}
							this.WJ9cnQeouCL.vDirection.y = this.transform.position.y;
							if (126997 - 367945 == -240947)
							{
								continue;
							}
							this.WJ9cnQeouCL.vMovement = (this.WJ9cnQeouCL.vDirection - this.transform.position).normalized;
							if (53700 - 432554 == -378853)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.WJ9cnQeouCL.vMovement);
							if (140179 - 457195 != -317016)
							{
								continue;
							}
							this.WJ9cnQeouCL.actionState = "run";
							if (169250 - 46566 == 122685)
							{
								continue;
							}
							this.animation.Play("run");
							if (6987 - 599640 == -592652)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (92272 - 582748 == -490475)
							{
								continue;
							}
							this.WJ9cnQeouCL.moveSpeed = Mathf.Lerp(this.WJ9cnQeouCL.moveSpeed, this.WJ9cnQeouCL.runSpeed, (float)4 * Time.deltaTime);
							if (261369 - 283532 != -22163)
							{
								continue;
							}
						}
						else
						{
							this.WJ9cnQeouCL.vDirection = myAttackTarget.transform.position;
							if (86815 - 495318 != -408503)
							{
								continue;
							}
							this.WJ9cnQeouCL.vDirection.y = this.transform.position.y;
							if (253893 - 139274 == 114620)
							{
								continue;
							}
							this.WJ9cnQeouCL.vMovement = (this.WJ9cnQeouCL.vDirection - this.transform.position).normalized;
							if (76553 - 392629 == -316075)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.WJ9cnQeouCL.vMovement);
							if (188740 - 287578 != -98838)
							{
								continue;
							}
							this.WJ9cnQeouCL.actionState = "standby";
							if (135056 - 387800 != -252744)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (146277 - 568267 == -421989)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (23987 - 596183 != -572196)
							{
								continue;
							}
							this.WJ9cnQeouCL.moveSpeed = (float)0;
							if (159926 - 217225 != -57299)
							{
								continue;
							}
						}
					}
				}
			}
			IL_49C:
			this.gw6cnJF8gjJ += mTime;
		}
		while (206495 - 589223 == -382727);
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x00997DBC File Offset: 0x00995FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (11065 - 447185 != -436120)
		{
		}
		while (Time.time - this.KE8cnIKnxjY > this.gw6cnJF8gjJ)
		{
			if (168836 - 42499 == 126337)
			{
				this.AI_state = "none";
				if (130889 - 244088 == -113199)
				{
					this.KE8cnIKnxjY = Time.time;
					if (115060 - 314331 != -199270)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x00997E70 File Offset: 0x00996070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (296082 - 553880 != -257798)
		{
		}
		for (;;)
		{
			IL_2D5:
			if (this.DSScn6XY5R1 + (float)1 > Time.time)
			{
				if (237437 - 276456 != -39018)
				{
					break;
				}
			}
			else
			{
				this.DSScn6XY5R1 = Time.time;
				if (285512 - 488810 != -203297)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (60749 - 506943 != -446193 && 242400 - 176762 != 65639)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (291153 - 596907 == -305754)
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
								if (224418 - 515828 != -291410)
								{
									goto IL_2D5;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (276076 - 196847 == 79230)
								{
									goto IL_2D5;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (169291 - 499466 == -330174)
								{
									goto IL_2D5;
								}
								bool flag = true;
								if (116823 - 152411 == -35587)
								{
									goto IL_2D5;
								}
								eRace race = this.WJ9cnQeouCL.Race;
								if (297000 - 66386 == 230615)
								{
									goto IL_2D5;
								}
								if (race == eRace.Tails)
								{
									if (226633 - 438030 == -211396)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_678;
									}
									if (252745 - 113384 == 139362)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (279648 - 188155 != 91493)
										{
											goto IL_2D5;
										}
										goto IL_678;
									}
									goto IL_7E9;
									IL_678:
									flag = false;
									if (258847 - 80061 == 178787)
									{
										goto IL_2D5;
									}
								}
								else if (race == eRace.Plants)
								{
									if (125677 - 390693 == -265015)
									{
										goto IL_2D5;
									}
									flag = false;
									if (109822 - 459274 != -349452)
									{
										goto IL_2D5;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (281676 - 48600 != 233076)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_15F;
									}
									if (113601 - 281592 == -167990)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (223122 - 212582 != 10540)
										{
											goto IL_2D5;
										}
										goto IL_15F;
									}
									goto IL_7E9;
									IL_15F:
									flag = false;
									if (132770 - 528144 == -395373)
									{
										goto IL_2D5;
									}
								}
								else if (race == eRace.Robots)
								{
									if (252824 - 468657 == -215832)
									{
										goto IL_2D5;
									}
									flag = true;
									if (200530 - 332971 != -132441)
									{
										goto IL_2D5;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (10347 - 202750 != -192403)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_1A;
									}
									if (155554 - 110942 == 44613)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_1A;
									}
									if (113328 - 35741 == 77588)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (40190 - 548563 != -508373)
										{
											goto IL_2D5;
										}
										goto IL_1A;
									}
									goto IL_7E9;
									IL_1A:
									flag = false;
									if (125791 - 54779 == 71013)
									{
										goto IL_2D5;
									}
								}
								else if (race == eRace.Structure)
								{
									if (151224 - 205500 != -54276)
									{
										goto IL_2D5;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (13580 - 491441 != -477861)
										{
											goto IL_2D5;
										}
										flag = false;
										if (18486 - 419090 != -400604)
										{
											goto IL_2D5;
										}
									}
								}
								IL_7E9:
								if (flag)
								{
									if (147099 - 167329 == -20229)
									{
										goto IL_2D5;
									}
									if (characterControl.hp > 0)
									{
										if (19735 - 221024 != -201289)
										{
											goto IL_2D5;
										}
										if (characterControl.recieveTarget)
										{
											if (54104 - 311579 == -257474)
											{
												goto IL_2D5;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (23760 - 233230 != -209470)
												{
													goto IL_2D5;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (167917 - 412240 == -244322)
													{
														goto IL_2D5;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (250671 - 27223 != 223448)
													{
														goto IL_2D5;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (45791 - 479041 != -433250)
														{
															goto IL_2D5;
														}
														this.WJ9cnQeouCL.isAlert = true;
														if (236836 - 278838 == -42001)
														{
															goto IL_2D5;
														}
														this.KE8cnIKnxjY = Time.time;
														if (59372 - 124684 != -65312)
														{
															goto IL_2D5;
														}
														this.WJ9cnQeouCL.myAttackTarget = gameObject;
														if (149708 - 66082 != 83626)
														{
															goto IL_2D5;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (214963 - 474769 != -259806)
														{
															goto IL_2D5;
														}
														this.WJ9cnQeouCL.addHate(characterControl.ActorNr, 5);
														if (90972 - 318249 == -227276)
														{
															goto IL_2D5;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (214239 - 568344 != -354105)
														{
															goto IL_2D5;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (55524 - 45253 == 10272)
														{
															goto IL_2D5;
														}
														if (num < (float)60)
														{
															if (107341 - 283299 == -175957)
															{
																goto IL_2D5;
															}
															if (characterControl.hp > 0)
															{
																if (152024 - 46786 == 105239)
																{
																	goto IL_2D5;
																}
																this.WJ9cnQeouCL.isAlert = true;
																if (221986 - 554866 != -332880)
																{
																	goto IL_2D5;
																}
																this.KE8cnIKnxjY = Time.time;
																if (13246 - 511519 == -498272)
																{
																	goto IL_2D5;
																}
																this.WJ9cnQeouCL.myAttackTarget = gameObject;
																if (258616 - 431638 != -173022)
																{
																	goto IL_2D5;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (40603 - 305256 != -264653)
																{
																	goto IL_2D5;
																}
																this.WJ9cnQeouCL.addHate(characterControl.ActorNr, 5);
																if (171730 - 370610 == -198879)
																{
																	goto IL_2D5;
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
							if (98839 - 373692 == -274853)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x00998698 File Offset: 0x00996898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004DFA RID: 19962 RVA: 0x0099869C File Offset: 0x0099689C
	internal static bool HaneOL5bdGSu7uvpr36B()
	{
		return true;
	}

	// Token: 0x06004DFB RID: 19963 RVA: 0x009986A0 File Offset: 0x009968A0
	internal static bool AAmNW45bJ5ak2cE4Rfwf()
	{
		return false;
	}

	// Token: 0x0400580B RID: 22539
	private CharacterControl WJ9cnQeouCL;

	// Token: 0x0400580C RID: 22540
	private RabbitCult jJMcneOrBFs;

	// Token: 0x0400580D RID: 22541
	public string AI_state;

	// Token: 0x0400580E RID: 22542
	private float KE8cnIKnxjY;

	// Token: 0x0400580F RID: 22543
	private float gw6cnJF8gjJ;

	// Token: 0x04005810 RID: 22544
	private float DSScn6XY5R1;
}
