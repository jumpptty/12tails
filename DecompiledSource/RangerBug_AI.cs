using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200019A RID: 410
[Serializable]
public class RangerBug_AI : MonoBehaviour
{
	// Token: 0x06000929 RID: 2345 RVA: 0x000ED534 File Offset: 0x000EB734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangerBug_AI()
	{
		if (183295 - 232332 != -49037)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (68154 - 552257 == -484103)
			{
				base..ctor();
				if (215540 - 471659 == -256119)
				{
					this.AI_state = "none";
					if (217772 - 233346 != -15573)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x000ED5D0 File Offset: 0x000EB7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.lxkQY7Egmi = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.f8cQ3H31Mc = (RangerBug)this.GetComponent(typeof(RangerBug));
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x000ED608 File Offset: 0x000EB808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (241243 - 486697 != -245453)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (79740 - 251487 != -171747)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (281991 - 545199 != -263208)
				{
					continue;
				}
			}
			if (this.lxkQY7Egmi.isControlled)
			{
				break;
			}
			if (211166 - 199305 == 11861)
			{
				this.AIControl();
				if (280954 - 474916 != -193961)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x000ED6D4 File Offset: 0x000EB8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (259865 - 559084 != -299219)
		{
		}
		for (;;)
		{
			this.DNgQdbZ76J = (float)0;
			if (52922 - 571915 != -518992)
			{
				if (this.lxkQY7Egmi.isMine)
				{
					if (86336 - 79957 != 6380)
					{
						if (this.lxkQY7Egmi.actionState != "standby")
						{
							if (84577 - 229769 != -145192)
							{
								continue;
							}
							if (this.lxkQY7Egmi.actionState != "run")
							{
								if (51637 - 11683 != 39954)
								{
									continue;
								}
								break;
							}
						}
						if (!this.lxkQY7Egmi.isAlert)
						{
							if (94271 - 595371 != -501099)
							{
								this.AI_idle(3f, 1f);
								if (31808 - 459486 != -427677)
								{
									this.AI_patrol(1f, 0.25f);
									if (267946 - 513663 != -245716)
									{
										this.AI_resetTimer();
										if (274224 - 75890 != 198335)
										{
											this.AI_visionCheck();
											if (75725 - 381963 == -306238)
											{
												if (!this.lxkQY7Egmi.myAttackTarget)
												{
													break;
												}
												if (259986 - 245343 == 14643)
												{
													this.lxkQY7Egmi.isAlert = true;
													if (267931 - 560269 != -292337)
													{
														this.wobQb7IAWn = Time.time;
														if (232832 - 129077 == 103755)
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
							if (132521 - 485739 == -353218)
							{
								this.AI_patrol(2f, 1f);
								if (294615 - 87517 != 207099)
								{
									this.AI_attack(10f, (float)0);
									if (270249 - 79328 != 190922)
									{
										this.AI_resetTimer();
										if (242974 - 487248 == -244274)
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
					if (this.lxkQY7Egmi.actionState != "standby")
					{
						if (290524 - 326012 == -35487)
						{
							continue;
						}
						if (this.lxkQY7Egmi.actionState != "run")
						{
							if (97503 - 550490 != -452986)
							{
								break;
							}
							continue;
						}
					}
					float num = this.lxkQY7Egmi.moveSpeed;
					if (142190 - 327973 == -185783)
					{
						float runSpeed = this.lxkQY7Egmi.runSpeed;
						if (77983 - 347351 != -269367)
						{
							Vector3 vector = default(Vector3);
							if (121911 - 277377 != -155465)
							{
								Vector3 vector2 = Vector3.zero;
								if (242156 - 358711 != -116554)
								{
									if ((this.lxkQY7Egmi.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (140536 - 392106 == -251569)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.lxkQY7Egmi.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (205649 - 440901 == -235251)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (208913 - 589316 == -380402)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (185867 - 4912 != 180955)
											{
												continue;
											}
											num = (float)0;
											if (54571 - 249128 == -194556)
											{
												continue;
											}
											this.transform.position = this.lxkQY7Egmi.nPosition;
											if (115039 - 465748 != -350709)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (6442 - 117181 != -110739)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (99589 - 399333 == -299743)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (61338 - 441594 == -380255)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (297557 - 272755 == 24803)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264970 - 178507 != 86463)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (284372 - 478941 == -194568)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (59605 - 340704 != -281099)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (268575 - 149079 != 119496)
											{
												continue;
											}
										}
									}
									this.lxkQY7Egmi.vMovement = vector2;
									if (185719 - 7961 != 177759)
									{
										this.lxkQY7Egmi.moveSpeed = num;
										if (237372 - 331681 == -94309)
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

	// Token: 0x0600092D RID: 2349 RVA: 0x000EDD4C File Offset: 0x000EBF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (221595 - 464443 != -242848)
		{
		}
		do
		{
			if (Time.time - this.wobQb7IAWn >= this.DNgQdbZ76J)
			{
				if (296995 - 307558 != -10563)
				{
					continue;
				}
				if (Time.time - this.wobQb7IAWn < this.DNgQdbZ76J + mTime)
				{
					if (569 - 301013 == -300443)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (253841 - 137679 != 116162)
						{
							continue;
						}
						this.AI_state = "idle";
						if (6428 - 134815 != -128387)
						{
							continue;
						}
						this.wobQb7IAWn -= UnityEngine.Random.Range((float)0, rTimer);
						if (156996 - 232539 != -75543)
						{
							continue;
						}
						this.lxkQY7Egmi.vDirection = Vector3.zero;
						if (221429 - 586329 == -364899)
						{
							continue;
						}
						this.lxkQY7Egmi.vMovement = this.transform.forward;
						if (130489 - 268212 == -137722)
						{
							continue;
						}
						this.lxkQY7Egmi.actionState = "standby";
						if (105347 - 584596 != -479249)
						{
							continue;
						}
					}
					this.lxkQY7Egmi.moveSpeed = Mathf.Lerp(this.lxkQY7Egmi.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (112900 - 49840 != 63060)
					{
						continue;
					}
					if (this.lxkQY7Egmi.moveSpeed < 0.1f * this.lxkQY7Egmi.runSpeed)
					{
						if (161990 - 205457 != -43467)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (53290 - 291471 == -238180)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (178220 - 297108 == -118887)
						{
							continue;
						}
						this.lxkQY7Egmi.moveSpeed = (float)0;
						if (214989 - 319314 != -104325)
						{
							continue;
						}
					}
				}
			}
			this.DNgQdbZ76J += mTime;
		}
		while (140484 - 252532 != -112048);
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x000EE010 File Offset: 0x000EC210
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (281807 - 438310 != -156502)
		{
		}
		do
		{
			if (Time.time - this.wobQb7IAWn >= this.DNgQdbZ76J)
			{
				if (153454 - 445878 != -292424)
				{
					continue;
				}
				if (Time.time - this.wobQb7IAWn < this.DNgQdbZ76J + mTime)
				{
					if (175517 - 308319 == -132801)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (172440 - 123979 != 48461)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (180313 - 136925 != 43388)
						{
							continue;
						}
						this.wobQb7IAWn -= UnityEngine.Random.Range((float)0, rTimer);
						if (40894 - 177936 == -137041)
						{
							continue;
						}
						this.lxkQY7Egmi.vDirection = this.lxkQY7Egmi.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (165724 - 304722 == -138997)
						{
							continue;
						}
						this.lxkQY7Egmi.vDirection.y = this.transform.position.y;
						if (264889 - 132004 != 132885)
						{
							continue;
						}
						this.lxkQY7Egmi.vMovement = (this.lxkQY7Egmi.vDirection - this.transform.position).normalized;
						if (258658 - 264284 != -5626)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.lxkQY7Egmi.vMovement);
						if (274357 - 566767 != -292410)
						{
							continue;
						}
						this.lxkQY7Egmi.actionState = "run";
						if (118525 - 299802 != -181277)
						{
							continue;
						}
						this.animation.Play("run");
						if (203193 - 545629 == -342435)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (261807 - 188384 != 73423)
						{
							continue;
						}
					}
					this.lxkQY7Egmi.moveSpeed = Mathf.Lerp(this.lxkQY7Egmi.moveSpeed, this.lxkQY7Egmi.runSpeed, (float)4 * Time.deltaTime);
					if (22301 - 326912 != -304611)
					{
						continue;
					}
				}
			}
			this.DNgQdbZ76J += mTime;
		}
		while (71426 - 41879 != 29547);
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x000EE318 File Offset: 0x000EC518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (46655 - 86306 != -39651)
		{
		}
		do
		{
			if (Time.time - this.wobQb7IAWn >= this.DNgQdbZ76J)
			{
				if (98537 - 31092 != 67445)
				{
					continue;
				}
				if (Time.time - this.wobQb7IAWn < this.DNgQdbZ76J + mTime)
				{
					if (235289 - 118913 != 116376)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (63255 - 457702 == -394446)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (279924 - 22093 == 257832)
						{
							continue;
						}
						this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
						if (76867 - 214452 != -137585)
						{
							continue;
						}
						this.lxkQY7Egmi.vDirection = Vector3.zero;
						if (76692 - 453058 == -376365)
						{
							continue;
						}
						this.lxkQY7Egmi.vMovement = this.transform.forward;
						if (281236 - 83874 == 197363)
						{
							continue;
						}
						this.lxkQY7Egmi.actionState = "standby";
						if (63652 - 115152 != -51500)
						{
							continue;
						}
						this.lxkQY7Egmi.myAttackTarget = this.lxkQY7Egmi.getHateTarget(5, 50);
						if (150306 - 145695 == 4612)
						{
							continue;
						}
						if (!this.lxkQY7Egmi.myAttackTarget)
						{
							if (24736 - 329440 == -304703)
							{
								continue;
							}
							this.lxkQY7Egmi.isAlert = false;
							if (116497 - 394311 != -277814)
							{
								continue;
							}
							this.wobQb7IAWn = Time.time;
							if (89794 - 236199 == -146404)
							{
								continue;
							}
							this.lxkQY7Egmi.myAttackTarget = null;
							if (163385 - 133526 == 29860)
							{
								continue;
							}
							this.lxkQY7Egmi.mOriginalPosition = this.transform.position;
							if (178975 - 267631 != -88655)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.lxkQY7Egmi.myAttackTarget;
							if (290893 - 410338 != -119445)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (60311 - 71805 == -11493)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (182459 - 42256 == 140204)
								{
									continue;
								}
								this.lxkQY7Egmi.isAlert = false;
								if (24661 - 59203 == -34541)
								{
									continue;
								}
								this.wobQb7IAWn = Time.time;
								if (164965 - 457549 == -292583)
								{
									continue;
								}
								this.lxkQY7Egmi.myAttackTarget = null;
								if (162104 - 111769 != 50335)
								{
									continue;
								}
							}
							else
							{
								this.lxkQY7Egmi.vDirection = myAttackTarget.transform.position;
								if (188495 - 320944 == -132448)
								{
									continue;
								}
								this.lxkQY7Egmi.vDirection.y = this.transform.position.y;
								if (58924 - 224666 == -165741)
								{
									continue;
								}
								this.lxkQY7Egmi.vMovement = (this.lxkQY7Egmi.vDirection - this.transform.position).normalized;
								if (124313 - 57090 != 67223)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.lxkQY7Egmi.vMovement);
								if (261060 - 38735 != 222325)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.DNgQdbZ76J += mTime;
		}
		while (163328 - 282944 != -119616);
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x000EE7C8 File Offset: 0x000EC9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (132721 - 268164 != -135442)
		{
		}
		do
		{
			IL_6AF:
			if (Time.time - this.wobQb7IAWn >= this.DNgQdbZ76J)
			{
				if (258351 - 390292 == -131940)
				{
					continue;
				}
				if (Time.time - this.wobQb7IAWn < this.DNgQdbZ76J + mTime)
				{
					if (25846 - 235952 != -210106)
					{
						continue;
					}
					if (!this.lxkQY7Egmi.myAttackTarget)
					{
						if (93012 - 97292 != -4280)
						{
							continue;
						}
						this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
						if (273940 - 190723 != 83218)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.lxkQY7Egmi.myAttackTarget;
						if (26735 - 541184 == -514448)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (44266 - 430511 != -386245)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (197634 - 443100 == -245465)
						{
							continue;
						}
						int tID = 0;
						if (215168 - 115399 == 99770)
						{
							continue;
						}
						if (characterControl)
						{
							if (208336 - 534440 != -326104)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (57755 - 445748 == -387992)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (71258 - 173962 == -102703)
						{
							continue;
						}
						if (this.f8cQ3H31Mc.rangerBugType == eRangerBugType.red)
						{
							if (192081 - 550143 != -358062)
							{
								continue;
							}
							if (num < (float)3)
							{
								if (249350 - 114200 == 135151)
								{
									continue;
								}
								if (this.lxkQY7Egmi.isTimeOut("nAttack") == (float)0)
								{
									if (129412 - 316860 == -187447)
									{
										continue;
									}
									this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
									if (121276 - 293899 == -172622)
									{
										continue;
									}
									this.f8cQ3H31Mc.StartCoroutine_Auto(this.f8cQ3H31Mc.RPC_nAttack_red(this.transform.position, vector, tID));
									if (296697 - 267065 != 29633)
									{
										if (PhotonClient.IsInitialized())
										{
											if (247709 - 213643 == 34067)
											{
												continue;
											}
											this.f8cQ3H31Mc.ActionEvent("RPC_nAttack_red", this.transform.position, vector, tID);
											if (129126 - 439760 != -310634)
											{
												continue;
											}
										}
										goto IL_DAD;
									}
									continue;
								}
							}
						}
						if (this.f8cQ3H31Mc.rangerBugType == eRangerBugType.yellow)
						{
							if (65825 - 505750 != -439925)
							{
								continue;
							}
							if (num < (float)2)
							{
								if (201487 - 481596 == -280108)
								{
									continue;
								}
								if (this.lxkQY7Egmi.isTimeOut("nAttack") == (float)0)
								{
									if (14899 - 512516 == -497616)
									{
										continue;
									}
									this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
									if (129248 - 498523 != -369275)
									{
										continue;
									}
									this.f8cQ3H31Mc.StartCoroutine_Auto(this.f8cQ3H31Mc.RPC_nAttack_yellow(this.transform.position, vector, tID));
									if (204737 - 352201 != -147463)
									{
										if (PhotonClient.IsInitialized())
										{
											if (63228 - 130755 != -67527)
											{
												continue;
											}
											this.f8cQ3H31Mc.ActionEvent("RPC_nAttack_yellow", this.transform.position, vector, tID);
											if (172019 - 6103 != 165916)
											{
												continue;
											}
										}
										goto IL_DAD;
									}
									continue;
								}
							}
						}
						if (this.f8cQ3H31Mc.rangerBugType == eRangerBugType.pink)
						{
							if (81042 - 316549 == -235506)
							{
								continue;
							}
							if (this.lxkQY7Egmi.isTimeOut("nAttack") == (float)0)
							{
								if (223242 - 437323 == -214080)
								{
									continue;
								}
								this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
								if (22500 - 406476 == -383975)
								{
									continue;
								}
								int num2 = 99999;
								if (114279 - 543994 != -429715)
								{
									continue;
								}
								UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)50, this.gameObject.layer);
								if (299043 - 439996 == -140952)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (218922 - 143781 != 75141)
								{
									continue;
								}
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
									if (140134 - 182864 == -42729)
									{
										goto IL_6AF;
									}
									CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (158255 - 203943 != -45688)
									{
										goto IL_6AF;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (12053 - 504602 == -492548)
									{
										goto IL_6AF;
									}
									if (characterControl2.hp > 0)
									{
										if (245525 - 342527 != -97002)
										{
											goto IL_6AF;
										}
										if (characterControl2.hp < num2)
										{
											if (121622 - 394162 == -272539)
											{
												goto IL_6AF;
											}
											num2 = characterControl2.hp;
											if (105220 - 283996 == -178775)
											{
												goto IL_6AF;
											}
											tID = characterControl2.ActorNr;
											if (175175 - 305789 != -130614)
											{
												goto IL_6AF;
											}
											Vector3 vector2 = gameObject.transform.position - this.transform.position;
											if (238098 - 306939 != -68841)
											{
												goto IL_6AF;
											}
											vector = vector2.normalized;
											if (74495 - 372727 != -298232)
											{
												goto IL_6AF;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (38650 - 344920 != -306270)
											{
												goto IL_6AF;
											}
										}
									}
								}
								if (213673 - 181357 == 32317)
								{
									continue;
								}
								this.f8cQ3H31Mc.StartCoroutine_Auto(this.f8cQ3H31Mc.RPC_nAttack_pink(this.transform.position, vector, tID));
								if (287694 - 557821 != -270127)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (182062 - 340950 != -158888)
									{
										continue;
									}
									this.f8cQ3H31Mc.ActionEvent("RPC_nAttack_pink", this.transform.position, vector, tID);
									if (212540 - 487386 == -274845)
									{
										continue;
									}
								}
								goto IL_DAD;
							}
						}
						if (this.f8cQ3H31Mc.rangerBugType == eRangerBugType.blue)
						{
							if (244550 - 347054 != -102504)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (4812 - 382938 != -378126)
								{
									continue;
								}
								if (this.lxkQY7Egmi.isTimeOut("nAttack") == (float)0)
								{
									if (266742 - 140705 != 126037)
									{
										continue;
									}
									this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
									if (206831 - 385507 != -178676)
									{
										continue;
									}
									this.f8cQ3H31Mc.StartCoroutine_Auto(this.f8cQ3H31Mc.RPC_nAttack_blue(this.transform.position, vector, tID));
									if (11707 - 152336 != -140629)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (4233 - 542598 == -538364)
										{
											continue;
										}
										this.f8cQ3H31Mc.ActionEvent("RPC_nAttack_blue", this.transform.position, vector, tID);
										if (213189 - 191432 == 21758)
										{
											continue;
										}
									}
									goto IL_DAD;
								}
							}
						}
						if (this.f8cQ3H31Mc.rangerBugType == eRangerBugType.black)
						{
							if (208579 - 213931 != -5352)
							{
								continue;
							}
							if (num < (float)2)
							{
								if (36507 - 170512 == -134004)
								{
									continue;
								}
								if (this.lxkQY7Egmi.isTimeOut("nAttack") == (float)0)
								{
									if (225432 - 543036 == -317603)
									{
										continue;
									}
									this.wobQb7IAWn = Time.time - mTime - this.DNgQdbZ76J;
									if (297828 - 478155 != -180327)
									{
										continue;
									}
									this.f8cQ3H31Mc.StartCoroutine_Auto(this.f8cQ3H31Mc.RPC_nAttack_black(this.transform.position, vector, tID));
									if (98154 - 302002 != -203848)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (8337 - 165258 == -156920)
										{
											continue;
										}
										this.f8cQ3H31Mc.ActionEvent("RPC_nAttack_black", this.transform.position, vector, tID);
										if (185993 - 271470 == -85476)
										{
											continue;
										}
									}
									goto IL_DAD;
								}
							}
						}
						this.AI_state = "attack";
						if (249498 - 595257 == -345758)
						{
							continue;
						}
						if (num > (float)1)
						{
							if (253805 - 114765 == 139041)
							{
								continue;
							}
							if (this.f8cQ3H31Mc.rangerBugType != eRangerBugType.red)
							{
								if (91628 - 120865 == -29236)
								{
									continue;
								}
								if (this.f8cQ3H31Mc.rangerBugType != eRangerBugType.yellow)
								{
									if (21922 - 509229 != -487307)
									{
										continue;
									}
									if (this.f8cQ3H31Mc.rangerBugType != eRangerBugType.black)
									{
										goto IL_B7B;
									}
									if (235967 - 268040 == -32072)
									{
										continue;
									}
								}
							}
							this.lxkQY7Egmi.vDirection = myAttackTarget.transform.position;
							if (277621 - 590613 != -312992)
							{
								continue;
							}
							this.lxkQY7Egmi.vDirection.y = this.transform.position.y;
							if (204310 - 281687 == -77376)
							{
								continue;
							}
							this.lxkQY7Egmi.vMovement = (this.lxkQY7Egmi.vDirection - this.transform.position).normalized;
							if (114044 - 30177 == 83868)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.lxkQY7Egmi.vMovement);
							if (162347 - 227819 == -65471)
							{
								continue;
							}
							this.lxkQY7Egmi.actionState = "run";
							if (89939 - 329448 == -239508)
							{
								continue;
							}
							this.animation.Play("run");
							if (201542 - 65496 == 136047)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (249285 - 380497 == -131211)
							{
								continue;
							}
							this.lxkQY7Egmi.moveSpeed = Mathf.Lerp(this.lxkQY7Egmi.moveSpeed, this.lxkQY7Egmi.runSpeed, (float)4 * Time.deltaTime);
							if (198127 - 424686 != -226558)
							{
								goto IL_DAD;
							}
							continue;
						}
						IL_B7B:
						if (num < (float)6)
						{
							if (188981 - 312864 != -123883)
							{
								continue;
							}
							if (this.f8cQ3H31Mc.rangerBugType != eRangerBugType.pink)
							{
								if (120281 - 512853 != -392572)
								{
									continue;
								}
								if (this.f8cQ3H31Mc.rangerBugType != eRangerBugType.blue)
								{
									goto IL_D23;
								}
								if (236173 - 414621 != -178448)
								{
									continue;
								}
							}
							this.lxkQY7Egmi.vDirection = myAttackTarget.transform.position;
							if (156069 - 26303 != 129766)
							{
								continue;
							}
							this.lxkQY7Egmi.vDirection.y = this.transform.position.y;
							if (61370 - 521385 != -460015)
							{
								continue;
							}
							this.lxkQY7Egmi.vMovement = (this.transform.position - this.lxkQY7Egmi.vDirection).normalized;
							if (270651 - 93731 == 176921)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.lxkQY7Egmi.vMovement);
							if (140658 - 133452 == 7207)
							{
								continue;
							}
							this.lxkQY7Egmi.actionState = "run";
							if (137840 - 122016 != 15824)
							{
								continue;
							}
							this.animation.Play("run");
							if (206303 - 132313 != 73990)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (85345 - 385685 == -300339)
							{
								continue;
							}
							this.lxkQY7Egmi.moveSpeed = Mathf.Lerp(this.lxkQY7Egmi.moveSpeed, this.lxkQY7Egmi.runSpeed, (float)4 * Time.deltaTime);
							if (290364 - 74237 != 216128)
							{
								goto IL_DAD;
							}
							continue;
						}
						IL_D23:
						this.lxkQY7Egmi.vDirection = myAttackTarget.transform.position;
						if (27192 - 509643 != -482451)
						{
							continue;
						}
						this.lxkQY7Egmi.vDirection.y = this.transform.position.y;
						if (40493 - 354016 != -313523)
						{
							continue;
						}
						this.lxkQY7Egmi.vMovement = (this.lxkQY7Egmi.vDirection - this.transform.position).normalized;
						if (277361 - 446328 != -168967)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.lxkQY7Egmi.vMovement);
						if (168061 - 51899 == 116163)
						{
							continue;
						}
						this.lxkQY7Egmi.actionState = "standby";
						if (100395 - 353398 != -253003)
						{
							continue;
						}
						this.animation.CrossFade("root", (float)1);
						if (152335 - 326617 != -174282)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (181554 - 551623 == -370068)
						{
							continue;
						}
						this.lxkQY7Egmi.moveSpeed = Mathf.Lerp(this.lxkQY7Egmi.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (35796 - 561564 != -525768)
						{
							continue;
						}
					}
				}
			}
			IL_DAD:
			this.DNgQdbZ76J += mTime;
		}
		while (220486 - 594510 != -374024);
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x000EF914 File Offset: 0x000EDB14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (283946 - 365705 != -81759)
		{
		}
		while (Time.time - this.wobQb7IAWn > this.DNgQdbZ76J)
		{
			if (20413 - 312460 == -292047)
			{
				this.AI_state = "none";
				if (48467 - 233260 != -184792)
				{
					this.wobQb7IAWn = Time.time;
					if (278757 - 65206 != 213552)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x000EF9C8 File Offset: 0x000EDBC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (119866 - 478660 != -358793)
		{
		}
		for (;;)
		{
			IL_45E:
			if (this.y9GQgP5O0q > Time.time)
			{
				if (98333 - 294614 != -196280)
				{
					break;
				}
			}
			else
			{
				this.y9GQgP5O0q = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (191342 - 438174 != -246831)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (98802 - 480991 != -382188)
					{
						if (223451 - 351142 == -127691)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (16007 - 520015 == -504008)
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
									if (152781 - 470366 != -317585)
									{
										goto IL_45E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (126672 - 43383 != 83289)
									{
										goto IL_45E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (130197 - 458605 == -328407)
									{
										goto IL_45E;
									}
									bool flag = true;
									if (197941 - 53798 != 144143)
									{
										goto IL_45E;
									}
									eRace race = this.lxkQY7Egmi.Race;
									if (294188 - 47415 != 246773)
									{
										goto IL_45E;
									}
									if (race == eRace.Tails)
									{
										if (175646 - 142066 != 33580)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7DE;
										}
										if (135186 - 568323 != -433137)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (205540 - 7859 != 197682)
											{
												goto IL_7DE;
											}
											goto IL_45E;
										}
										goto IL_78;
										IL_7DE:
										flag = false;
										if (49260 - 404409 == -355148)
										{
											goto IL_45E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (268811 - 318389 == -49577)
										{
											goto IL_45E;
										}
										flag = false;
										if (211126 - 164817 == 46310)
										{
											goto IL_45E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (270321 - 59486 == 210836)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1BB;
										}
										if (32710 - 358324 != -325614)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (146516 - 95978 != 50538)
											{
												goto IL_45E;
											}
											goto IL_1BB;
										}
										goto IL_78;
										IL_1BB:
										flag = false;
										if (172409 - 510839 != -338430)
										{
											goto IL_45E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (201989 - 460379 == -258389)
										{
											goto IL_45E;
										}
										flag = true;
										if (275214 - 404113 != -128899)
										{
											goto IL_45E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (107644 - 290102 == -182457)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_223;
										}
										if (242908 - 179808 != 63100)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_223;
										}
										if (109827 - 490618 == -380790)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (65896 - 386796 != -320899)
											{
												goto IL_223;
											}
											goto IL_45E;
										}
										goto IL_78;
										IL_223:
										flag = false;
										if (15171 - 555437 != -540266)
										{
											goto IL_45E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (294873 - 239343 == 55531)
										{
											goto IL_45E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (248215 - 95654 == 152562)
											{
												goto IL_45E;
											}
											flag = false;
											if (25847 - 449354 != -423507)
											{
												goto IL_45E;
											}
										}
									}
									IL_78:
									if (flag)
									{
										if (253806 - 436864 == -183057)
										{
											goto IL_45E;
										}
										if (characterControl.hp > 0)
										{
											if (228878 - 442482 != -213604)
											{
												goto IL_45E;
											}
											if (characterControl.recieveTarget)
											{
												if (155167 - 144173 == 10995)
												{
													goto IL_45E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (179120 - 213640 != -34520)
													{
														goto IL_45E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (267776 - 413639 == -145862)
														{
															goto IL_45E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (122092 - 322647 != -200555)
														{
															goto IL_45E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (9566 - 64230 != -54664)
															{
																goto IL_45E;
															}
															this.lxkQY7Egmi.myAttackTarget = gameObject;
															if (216856 - 596260 != -379404)
															{
																goto IL_45E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (105431 - 318507 != -213076)
															{
																goto IL_45E;
															}
															this.lxkQY7Egmi.addHate(characterControl.ActorNr, 5);
															if (36086 - 583104 == -547017)
															{
																goto IL_45E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (266864 - 387329 == -120464)
															{
																goto IL_45E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (24036 - 145138 == -121101)
															{
																goto IL_45E;
															}
															if (num < (float)60)
															{
																if (207291 - 417378 != -210087)
																{
																	goto IL_45E;
																}
																if (characterControl.hp > 0)
																{
																	if (247761 - 298878 != -51117)
																	{
																		goto IL_45E;
																	}
																	this.lxkQY7Egmi.myAttackTarget = gameObject;
																	if (196821 - 51844 == 144978)
																	{
																		goto IL_45E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (43204 - 77693 == -34488)
																	{
																		goto IL_45E;
																	}
																	this.lxkQY7Egmi.addHate(characterControl.ActorNr, 5);
																	if (219336 - 253290 != -33954)
																	{
																		goto IL_45E;
																	}
																}
															}
														}
														if (this.lxkQY7Egmi.myAttackTarget)
														{
															if (89867 - 381779 == -291911)
															{
																goto IL_45E;
															}
															this.lxkQY7Egmi.isAlert = true;
															if (156649 - 427971 == -271321)
															{
																goto IL_45E;
															}
															this.wobQb7IAWn = Time.time;
															if (156218 - 238859 == -82640)
															{
																goto IL_45E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (246323 - 87100 != 159224)
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

	// Token: 0x06000933 RID: 2355 RVA: 0x000F01E0 File Offset: 0x000EE3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x000F01E4 File Offset: 0x000EE3E4
	internal static bool VHHMgekkrShWyERFJXc()
	{
		return true;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x000F01E8 File Offset: 0x000EE3E8
	internal static bool yT7dUpkGrINu9q0JPPh()
	{
		return false;
	}

	// Token: 0x0400084B RID: 2123
	private CharacterControl lxkQY7Egmi;

	// Token: 0x0400084C RID: 2124
	private RangerBug f8cQ3H31Mc;

	// Token: 0x0400084D RID: 2125
	public string AI_state;

	// Token: 0x0400084E RID: 2126
	private float wobQb7IAWn;

	// Token: 0x0400084F RID: 2127
	private float DNgQdbZ76J;

	// Token: 0x04000850 RID: 2128
	private float y9GQgP5O0q;
}
