using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AF9 RID: 2809
[Serializable]
public class MissileBot_AI : MonoBehaviour
{
	// Token: 0x06003E26 RID: 15910 RVA: 0x007FF3FC File Offset: 0x007FD5FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MissileBot_AI()
	{
		if (44031 - 96307 != -52275)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (80787 - 580856 == -500069)
			{
				base..ctor();
				if (240708 - 26809 != 213900)
				{
					this.AI_state = "none";
					if (198097 - 207564 != -9466)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x007FF498 File Offset: 0x007FD698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (258205 - 505000 != -246795)
		{
		}
		for (;;)
		{
			this.jHdu90K3Ao = this.transform;
			if (215270 - 463207 != -247936)
			{
				this.mwvuWm9sK4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (234927 - 553789 == -318862)
				{
					this.aX7uuZmtv5 = (MissileBot)this.GetComponent(typeof(MissileBot));
					if (207583 - 442652 != -235068)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x007FF560 File Offset: 0x007FD760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (90148 - 193090 != -102942)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (177028 - 418908 != -241880)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (272459 - 595167 != -322708)
				{
					continue;
				}
			}
			if (this.mwvuWm9sK4.isControlled)
			{
				break;
			}
			if (279609 - 590039 == -310430)
			{
				this.AIControl();
				if (126073 - 171271 == -45198)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x007FF62C File Offset: 0x007FD82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (183174 - 22978 != 160196)
		{
		}
		for (;;)
		{
			this.mahuV89CN6 = (float)0;
			if (156209 - 229218 == -73009)
			{
				if (this.mwvuWm9sK4.isMine)
				{
					if (123181 - 336271 != -213089)
					{
						if (this.mwvuWm9sK4.actionState != "standby")
						{
							if (127598 - 560148 != -432550)
							{
								continue;
							}
							if (this.mwvuWm9sK4.actionState != "run")
							{
								if (242126 - 413007 != -170881)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode == 923)
						{
							if (174823 - 416439 == -241616)
							{
								this.AI_escape(6f, 3f);
								if (247096 - 118892 == 128204)
								{
									if (!this.mwvuWm9sK4.isAlert)
									{
										if (272345 - 533112 != -260767)
										{
											continue;
										}
										this.AI_visionCheck();
										if (93124 - 341882 == -248757)
										{
											continue;
										}
										if (this.mwvuWm9sK4.myAttackTarget)
										{
											if (73381 - 476056 != -402675)
											{
												continue;
											}
											this.mwvuWm9sK4.isAlert = true;
											if (230135 - 36324 != 193811)
											{
												continue;
											}
										}
									}
									else
									{
										this.AI_selectTarget(1f, (float)0);
										if (295084 - 116962 == 178123)
										{
											continue;
										}
										this.AI_attack(4f, 2f);
										if (268547 - 259635 != 8912)
										{
											continue;
										}
									}
									this.AI_resetTimer();
									if (212228 - 56458 != 155771)
									{
										break;
									}
								}
							}
						}
						else if (!this.mwvuWm9sK4.isAlert)
						{
							if (13234 - 258404 != -245169)
							{
								this.AI_idle(4f, 2f);
								if (260960 - 330940 == -69980)
								{
									this.AI_patrol(1f, 0.25f);
									if (221071 - 72294 == 148777)
									{
										this.AI_resetTimer();
										if (85324 - 508932 != -423607)
										{
											this.AI_visionCheck();
											if (58886 - 836 != 58051)
											{
												if (!this.mwvuWm9sK4.myAttackTarget)
												{
													break;
												}
												if (263322 - 107280 == 156042)
												{
													this.mwvuWm9sK4.isAlert = true;
													if (238970 - 422866 == -183896)
													{
														this.wnWuykr6WH = Time.time;
														if (197172 - 141963 == 55209)
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
							if (178100 - 127345 == 50755)
							{
								this.AI_idle(2f, 1f);
								if (2590 - 153066 == -150476)
								{
									this.AI_attack(12f, (float)0);
									if (169359 - 142856 == 26503)
									{
										this.AI_resetTimer();
										if (228763 - 289416 != -60652)
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
					if (this.mwvuWm9sK4.actionState != "standby")
					{
						if (217673 - 474283 != -256610)
						{
							continue;
						}
						if (this.mwvuWm9sK4.actionState != "run")
						{
							if (130500 - 104533 != 25968)
							{
								break;
							}
							continue;
						}
					}
					float num = this.mwvuWm9sK4.moveSpeed;
					if (199164 - 84558 != 114607)
					{
						float runSpeed = this.mwvuWm9sK4.runSpeed;
						if (224038 - 429853 == -205815)
						{
							Vector3 vector = default(Vector3);
							if (146838 - 421763 != -274924)
							{
								Vector3 vector2 = Vector3.zero;
								if (162264 - 366203 != -203938)
								{
									if ((this.mwvuWm9sK4.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (263151 - 494463 != -231312)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mwvuWm9sK4.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (297059 - 254398 != 42661)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (110505 - 183533 == -73027)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (168038 - 416213 == -248174)
											{
												continue;
											}
											num = (float)0;
											if (104822 - 571672 != -466850)
											{
												continue;
											}
											this.transform.position = this.mwvuWm9sK4.nPosition;
											if (95842 - 371322 != -275480)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (223682 - 391262 == -167579)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (6299 - 436447 == -430147)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (32365 - 73325 != -40960)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (149000 - 355195 == -206194)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288992 - 385559 != -96567)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (103578 - 274826 == -171247)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (12178 - 177835 != -165657)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264142 - 470268 == -206125)
											{
												continue;
											}
										}
									}
									this.mwvuWm9sK4.vMovement = vector2;
									if (250918 - 3334 == 247584)
									{
										this.mwvuWm9sK4.moveSpeed = num;
										if (48062 - 36631 == 11431)
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

	// Token: 0x06003E2A RID: 15914 RVA: 0x007FFE10 File Offset: 0x007FE010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (18632 - 211430 != -192798)
		{
		}
		do
		{
			if (Time.time - this.wnWuykr6WH >= this.mahuV89CN6)
			{
				if (277646 - 496409 != -218763)
				{
					continue;
				}
				if (Time.time - this.wnWuykr6WH < this.mahuV89CN6 + mTime)
				{
					if (97822 - 510192 == -412369)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (129411 - 565689 == -436277)
						{
							continue;
						}
						this.AI_state = "idle";
						if (43488 - 134209 == -90720)
						{
							continue;
						}
						this.wnWuykr6WH -= UnityEngine.Random.Range((float)0, rTimer);
						if (123588 - 405237 == -281648)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection = Vector3.zero;
						if (101513 - 330186 != -228673)
						{
							continue;
						}
						this.mwvuWm9sK4.vMovement = this.transform.forward;
						if (124323 - 459352 == -335028)
						{
							continue;
						}
						this.mwvuWm9sK4.actionState = "standby";
						if (35593 - 455507 == -419913)
						{
							continue;
						}
					}
					this.mwvuWm9sK4.moveSpeed = Mathf.Lerp(this.mwvuWm9sK4.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (299224 - 62415 != 236809)
					{
						continue;
					}
					if (this.mwvuWm9sK4.moveSpeed < 0.1f * this.mwvuWm9sK4.runSpeed)
					{
						if (284051 - 433910 == -149858)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (61035 - 506573 != -445538)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (168403 - 37669 == 130735)
						{
							continue;
						}
						this.mwvuWm9sK4.moveSpeed = (float)0;
						if (192801 - 321710 != -128909)
						{
							continue;
						}
					}
				}
			}
			this.mahuV89CN6 += mTime;
		}
		while (218422 - 112248 == 106175);
	}

	// Token: 0x06003E2B RID: 15915 RVA: 0x008000D4 File Offset: 0x007FE2D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (16789 - 316357 != -299568)
		{
		}
		do
		{
			if (Time.time - this.wnWuykr6WH >= this.mahuV89CN6)
			{
				if (89092 - 516229 == -427136)
				{
					continue;
				}
				if (Time.time - this.wnWuykr6WH < this.mahuV89CN6 + mTime)
				{
					if (104067 - 78313 != 25754)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (201369 - 368720 != -167351)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (211312 - 416630 != -205318)
						{
							continue;
						}
						this.wnWuykr6WH -= UnityEngine.Random.Range((float)0, rTimer);
						if (51859 - 18986 != 32873)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection = this.mwvuWm9sK4.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (25309 - 147564 != -122255)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection.y = this.transform.position.y;
						if (60316 - 528051 != -467735)
						{
							continue;
						}
						this.mwvuWm9sK4.vMovement = (this.mwvuWm9sK4.vDirection - this.transform.position).normalized;
						if (221306 - 181326 == 39981)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.mwvuWm9sK4.vMovement);
						if (19620 - 238734 != -219114)
						{
							continue;
						}
						this.mwvuWm9sK4.actionState = "run";
						if (48071 - 472236 != -424165)
						{
							continue;
						}
						this.animation.Play("run");
						if (78246 - 151479 == -73232)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (87983 - 83456 == 4528)
						{
							continue;
						}
					}
					this.mwvuWm9sK4.moveSpeed = Mathf.Lerp(this.mwvuWm9sK4.moveSpeed, this.mwvuWm9sK4.runSpeed, (float)4 * Time.deltaTime);
					if (294566 - 38490 == 256077)
					{
						continue;
					}
				}
			}
			this.mahuV89CN6 += mTime;
		}
		while (158801 - 346892 != -188091);
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x008003DC File Offset: 0x007FE5DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_escape(float mTime, float rTimer)
	{
		if (112700 - 516118 != -403417)
		{
		}
		for (;;)
		{
			IL_565:
			if (Game.mGameCode != 923)
			{
				if (60808 - 32727 != 28082)
				{
					break;
				}
			}
			else
			{
				if (Time.time - this.wnWuykr6WH >= this.mahuV89CN6)
				{
					if (28610 - 123990 == -95379)
					{
						continue;
					}
					if (Time.time - this.wnWuykr6WH < this.mahuV89CN6 + mTime)
					{
						if (215937 - 563505 != -347568)
						{
							continue;
						}
						if (this.LGfuhTU7VN == 0)
						{
							if (115932 - 587603 != -471671)
							{
								continue;
							}
							int num = 999;
							if (89385 - 152268 == -62882)
							{
								continue;
							}
							int i = 1;
							if (247371 - 402734 == -155362)
							{
								continue;
							}
							while (i <= 4)
							{
								GameObject gameObject = GameObject.Find("SpawnPoint" + i);
								if (61565 - 221574 == -160008)
								{
									goto IL_565;
								}
								if (gameObject)
								{
									if (171250 - 561652 == -390401)
									{
										goto IL_565;
									}
									Vector3 vector = gameObject.transform.position - this.transform.position;
									if (120915 - 540770 != -419855)
									{
										goto IL_565;
									}
									if (vector.magnitude < (float)num)
									{
										if (59611 - 93076 == -33464)
										{
											goto IL_565;
										}
										Vector3 vector2 = gameObject.transform.position - this.transform.position;
										if (250571 - 48842 == 201730)
										{
											goto IL_565;
										}
										num = (int)vector2.magnitude;
										if (93008 - 27352 != 65656)
										{
											goto IL_565;
										}
										this.LGfuhTU7VN = i;
										if (2552 - 443506 != -440954)
										{
											goto IL_565;
										}
									}
								}
								i++;
								if (186902 - 562634 != -375732)
								{
									goto IL_565;
								}
							}
							if (256796 - 394460 != -137664)
							{
								continue;
							}
						}
						else
						{
							if (!this.NIsuzMM6fd)
							{
								if (100630 - 374842 == -274211)
								{
									continue;
								}
								if (this.a7GuKccT7d < 9)
								{
									if (132867 - 518802 == -385934)
									{
										continue;
									}
									this.a7GuKccT7d++;
									if (114474 - 62539 == 51936)
									{
										continue;
									}
									GameObject gameObject2 = GameObject.Find("WayPoint" + (10 * this.LGfuhTU7VN + this.a7GuKccT7d));
									if (118742 - 297839 == -179096)
									{
										continue;
									}
									if (gameObject2)
									{
										if (120115 - 370328 == -250212)
										{
											continue;
										}
										this.NIsuzMM6fd = gameObject2;
										if (27221 - 332090 == -304868)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find WayPoint" + (10 * this.LGfuhTU7VN + this.a7GuKccT7d));
										if (43084 - 541914 == -498829)
										{
											continue;
										}
									}
								}
							}
							if (this.NIsuzMM6fd)
							{
								if (273306 - 493989 != -220683)
								{
									continue;
								}
								Vector3 vector3 = global::Math.vFlat(this.NIsuzMM6fd.transform.position - this.jHdu90K3Ao.position);
								if (290867 - 504492 != -213625)
								{
									continue;
								}
								float sqrMagnitude = vector3.sqrMagnitude;
								if (33387 - 178616 == -145228)
								{
									continue;
								}
								if (sqrMagnitude < (float)4)
								{
									if (216218 - 171413 != 44805)
									{
										continue;
									}
									this.NIsuzMM6fd = null;
									if (687 - 423927 != -423240)
									{
										continue;
									}
								}
								else
								{
									this.AI_state = "escape";
									if (1274 - 420656 != -419382)
									{
										continue;
									}
									this.mwvuWm9sK4.vMovement = vector3.normalized;
									if (113796 - 496130 == -382333)
									{
										continue;
									}
									this.jHdu90K3Ao.rotation = Quaternion.LookRotation(this.mwvuWm9sK4.vMovement);
									if (139262 - 481522 != -342260)
									{
										continue;
									}
									this.mwvuWm9sK4.actionState = "run";
									if (18719 - 475081 == -456361)
									{
										continue;
									}
									this.animation.Play("run");
									if (145194 - 449064 != -303870)
									{
										continue;
									}
									this.animation.wrapMode = WrapMode.Loop;
									if (19393 - 212324 != -192931)
									{
										continue;
									}
									this.mwvuWm9sK4.moveSpeed = Mathf.Lerp(this.mwvuWm9sK4.moveSpeed, this.mwvuWm9sK4.runSpeed, (float)4 * Time.deltaTime);
									if (106826 - 111989 == -5162)
									{
										continue;
									}
								}
							}
						}
					}
				}
				this.mahuV89CN6 += mTime;
				if (290631 - 543116 == -252485)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x00800A08 File Offset: 0x007FEC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (220758 - 306393 != -85635)
		{
		}
		do
		{
			if (Time.time - this.wnWuykr6WH >= this.mahuV89CN6)
			{
				if (266930 - 199241 != 67689)
				{
					continue;
				}
				if (Time.time - this.wnWuykr6WH < this.mahuV89CN6 + mTime)
				{
					if (248386 - 37416 == 210971)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (120209 - 45964 == 74246)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (166582 - 170398 != -3816)
						{
							continue;
						}
						this.wnWuykr6WH = Time.time - mTime - this.mahuV89CN6;
						if (116709 - 508288 != -391579)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection = Vector3.zero;
						if (149070 - 377360 == -228289)
						{
							continue;
						}
						this.mwvuWm9sK4.vMovement = this.transform.forward;
						if (18371 - 503782 != -485411)
						{
							continue;
						}
						this.mwvuWm9sK4.actionState = "standby";
						if (227201 - 390434 == -163232)
						{
							continue;
						}
						this.mwvuWm9sK4.myAttackTarget = this.mwvuWm9sK4.getHateTarget(5, 50);
						if (83484 - 301314 != -217830)
						{
							continue;
						}
						if (!this.mwvuWm9sK4.myAttackTarget)
						{
							if (187262 - 124614 != 62648)
							{
								continue;
							}
							this.mwvuWm9sK4.isAlert = false;
							if (78504 - 444049 != -365545)
							{
								continue;
							}
							this.wnWuykr6WH = Time.time;
							if (250402 - 290478 != -40076)
							{
								continue;
							}
							this.mwvuWm9sK4.myAttackTarget = null;
							if (160099 - 123994 == 36106)
							{
								continue;
							}
							this.mwvuWm9sK4.mOriginalPosition = this.transform.position;
							if (63882 - 187056 != -123174)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.mwvuWm9sK4.myAttackTarget;
							if (233002 - 552202 == -319199)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (178671 - 596948 != -418277)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (212748 - 352162 != -139414)
								{
									continue;
								}
								this.mwvuWm9sK4.isAlert = false;
								if (219336 - 194133 != 25203)
								{
									continue;
								}
								this.wnWuykr6WH = Time.time;
								if (266816 - 36100 != 230716)
								{
									continue;
								}
								this.mwvuWm9sK4.myAttackTarget = null;
								if (160659 - 42204 != 118455)
								{
									continue;
								}
							}
							else
							{
								this.mwvuWm9sK4.vDirection = myAttackTarget.transform.position;
								if (129972 - 82504 == 47469)
								{
									continue;
								}
								this.mwvuWm9sK4.vDirection.y = this.transform.position.y;
								if (174585 - 442327 == -267741)
								{
									continue;
								}
								this.mwvuWm9sK4.vMovement = (this.mwvuWm9sK4.vDirection - this.transform.position).normalized;
								if (199744 - 552431 == -352686)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.mwvuWm9sK4.vMovement);
								if (180217 - 388118 != -207901)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.mahuV89CN6 += mTime;
		}
		while (110532 - 333813 != -223281);
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x00800EB8 File Offset: 0x007FF0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (140104 - 368283 != -228179)
		{
		}
		do
		{
			if (Time.time - this.wnWuykr6WH >= this.mahuV89CN6)
			{
				if (112957 - 235460 != -122503)
				{
					continue;
				}
				if (Time.time - this.wnWuykr6WH < this.mahuV89CN6 + mTime)
				{
					if (227660 - 444960 != -217300)
					{
						continue;
					}
					if (!this.mwvuWm9sK4.myAttackTarget)
					{
						if (209035 - 209689 == -653)
						{
							continue;
						}
						this.wnWuykr6WH = Time.time - mTime - this.mahuV89CN6;
						if (106333 - 555766 != -449432)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.mwvuWm9sK4.myAttackTarget;
						if (259191 - 226579 == 32613)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (130178 - 509125 != -378947)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (127204 - 403179 != -275975)
						{
							continue;
						}
						int tID = 0;
						if (258201 - 494580 != -236379)
						{
							continue;
						}
						if (characterControl)
						{
							if (127556 - 54763 == 72794)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (239750 - 245416 != -5666)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (202638 - 492536 != -289898)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (23740 - 529166 == -505425)
							{
								continue;
							}
							if (this.aX7uuZmtv5.hasMissile)
							{
								if (260609 - 506286 == -245676)
								{
									continue;
								}
								this.wnWuykr6WH = Time.time - mTime - this.mahuV89CN6;
								if (131036 - 397395 == -266358)
								{
									continue;
								}
								this.aX7uuZmtv5.StartCoroutine_Auto(this.aX7uuZmtv5.RPC_missile(this.transform.position, vector, tID));
								if (185550 - 286005 != -100454)
								{
									if (PhotonClient.IsInitialized())
									{
										if (58089 - 70873 != -12784)
										{
											continue;
										}
										this.aX7uuZmtv5.ActionEvent("RPC_missile", this.transform.position, vector, tID);
										if (159412 - 129429 == 29984)
										{
											continue;
										}
									}
									goto IL_48D;
								}
								continue;
							}
						}
						if (num < (float)4)
						{
							if (82215 - 334194 != -251979)
							{
								continue;
							}
							if (!this.aX7uuZmtv5.hasMissile)
							{
								if (53480 - 100215 == -46734)
								{
									continue;
								}
								if ((float)this.mwvuWm9sK4.hp < 0.4f * (float)this.mwvuWm9sK4.mhp)
								{
									if (7639 - 143349 == -135709)
									{
										continue;
									}
									this.wnWuykr6WH = Time.time - mTime - this.mahuV89CN6;
									if (50826 - 27656 == 23171)
									{
										continue;
									}
									this.aX7uuZmtv5.StartCoroutine_Auto(this.aX7uuZmtv5.RPC_suicideBomb(this.transform.position, vector, tID));
									if (205570 - 296312 != -90741)
									{
										if (PhotonClient.IsInitialized())
										{
											if (33121 - 558232 == -525110)
											{
												continue;
											}
											this.aX7uuZmtv5.ActionEvent("RPC_suicideBomb", this.transform.position, vector, tID);
											if (270672 - 542544 != -271872)
											{
												continue;
											}
										}
										goto IL_48D;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (136260 - 210608 == -74347)
							{
								continue;
							}
							if (this.mwvuWm9sK4.isTimeOut("nAttack") == (float)0)
							{
								if (205739 - 561760 == -356020)
								{
									continue;
								}
								this.wnWuykr6WH = Time.time - mTime - this.mahuV89CN6;
								if (59340 - 56577 == 2764)
								{
									continue;
								}
								this.aX7uuZmtv5.StartCoroutine_Auto(this.aX7uuZmtv5.RPC_nAttack(this.transform.position, vector, tID));
								if (97111 - 285501 != -188390)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (293354 - 212556 == 80799)
									{
										continue;
									}
									this.aX7uuZmtv5.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (258711 - 314049 != -55338)
									{
										continue;
									}
								}
								goto IL_48D;
							}
						}
						this.AI_state = "attack";
						if (100987 - 397319 == -296331)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection = myAttackTarget.transform.position;
						if (180266 - 390763 != -210497)
						{
							continue;
						}
						this.mwvuWm9sK4.vDirection.y = this.transform.position.y;
						if (226622 - 461862 == -235239)
						{
							continue;
						}
						this.mwvuWm9sK4.vMovement = (this.mwvuWm9sK4.vDirection - this.transform.position).normalized;
						if (97987 - 317352 != -219365)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.mwvuWm9sK4.vMovement);
						if (217223 - 10075 == 207149)
						{
							continue;
						}
						this.mwvuWm9sK4.actionState = "run";
						if (266614 - 421596 != -154982)
						{
							continue;
						}
						this.animation.Play("run");
						if (90159 - 433692 != -343533)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (165779 - 441161 == -275381)
						{
							continue;
						}
						this.mwvuWm9sK4.moveSpeed = Mathf.Lerp(this.mwvuWm9sK4.moveSpeed, this.mwvuWm9sK4.runSpeed, (float)4 * Time.deltaTime);
						if (249719 - 525120 == -275400)
						{
							continue;
						}
					}
				}
			}
			IL_48D:
			this.mahuV89CN6 += mTime;
		}
		while (98151 - 165853 != -67702);
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x00801670 File Offset: 0x007FF870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (241805 - 592718 != -350912)
		{
		}
		while (Time.time - this.wnWuykr6WH > this.mahuV89CN6)
		{
			if (167351 - 581705 != -414353)
			{
				this.AI_state = "none";
				if (80778 - 434258 != -353479)
				{
					this.wnWuykr6WH = Time.time;
					if (147797 - 169371 == -21574)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x00801724 File Offset: 0x007FF924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (17876 - 158651 != -140774)
		{
		}
		for (;;)
		{
			IL_24F:
			if (this.yRXy5h4Xb3 > Time.time)
			{
				if (149145 - 284225 == -135080)
				{
					break;
				}
			}
			else
			{
				this.yRXy5h4Xb3 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (97628 - 16410 == 81218)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (131158 - 167935 != -36776 && 29958 - 97899 != -67940)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (208764 - 110499 != 98266)
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
								if (202920 - 128995 == 73926)
								{
									goto IL_24F;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (207275 - 210174 == -2898)
								{
									goto IL_24F;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (123803 - 510828 == -387024)
								{
									goto IL_24F;
								}
								bool flag = true;
								if (123573 - 97003 != 26570)
								{
									goto IL_24F;
								}
								eRace race = this.mwvuWm9sK4.Race;
								if (63217 - 463483 == -400265)
								{
									goto IL_24F;
								}
								if (race == eRace.Tails)
								{
									if (16221 - 394296 != -378075)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_233;
									}
									if (142980 - 477652 == -334671)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (48315 - 166481 != -118166)
										{
											goto IL_24F;
										}
										goto IL_233;
									}
									goto IL_437;
									IL_233:
									flag = false;
									if (267590 - 64482 != 203108)
									{
										goto IL_24F;
									}
								}
								else if (race == eRace.Plants)
								{
									if (96392 - 23220 == 73173)
									{
										goto IL_24F;
									}
									flag = false;
									if (39054 - 284842 == -245787)
									{
										goto IL_24F;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (17059 - 421433 == -404373)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_154;
									}
									if (289459 - 329540 != -40081)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (185721 - 233837 != -48115)
										{
											goto IL_154;
										}
										goto IL_24F;
									}
									goto IL_437;
									IL_154:
									flag = false;
									if (265907 - 389713 == -123805)
									{
										goto IL_24F;
									}
								}
								else if (race == eRace.Robots)
								{
									if (63850 - 352389 != -288539)
									{
										goto IL_24F;
									}
									flag = true;
									if (84326 - 342703 == -258376)
									{
										goto IL_24F;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (158283 - 249040 != -90757)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_67E;
									}
									if (255686 - 502886 == -247199)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_67E;
									}
									if (248782 - 271018 != -22236)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (104969 - 506082 != -401112)
										{
											goto IL_67E;
										}
										goto IL_24F;
									}
									goto IL_437;
									IL_67E:
									flag = false;
									if (221627 - 268393 != -46766)
									{
										goto IL_24F;
									}
								}
								else if (race == eRace.Structure)
								{
									if (205613 - 549598 != -343985)
									{
										goto IL_24F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (170156 - 351640 != -181484)
										{
											goto IL_24F;
										}
										flag = false;
										if (92688 - 167491 != -74803)
										{
											goto IL_24F;
										}
									}
								}
								IL_437:
								if (flag)
								{
									if (19919 - 374505 != -354586)
									{
										goto IL_24F;
									}
									if (characterControl.hp > 0)
									{
										if (256153 - 115656 == 140498)
										{
											goto IL_24F;
										}
										if (characterControl.recieveTarget)
										{
											if (154898 - 571795 != -416897)
											{
												goto IL_24F;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (192828 - 189548 == 3281)
												{
													goto IL_24F;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (162058 - 186938 == -24879)
													{
														goto IL_24F;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (294916 - 78967 != 215949)
													{
														goto IL_24F;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (290377 - 153530 == 136848)
														{
															goto IL_24F;
														}
														this.mwvuWm9sK4.myAttackTarget = gameObject;
														if (297898 - 164897 != 133001)
														{
															goto IL_24F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (256047 - 306067 == -50019)
														{
															goto IL_24F;
														}
														this.mwvuWm9sK4.addHate(characterControl.ActorNr, 5);
														if (213548 - 371817 == -158268)
														{
															goto IL_24F;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (241415 - 401962 != -160547)
														{
															goto IL_24F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (131473 - 412696 == -281222)
														{
															goto IL_24F;
														}
														if (num < (float)60)
														{
															if (124173 - 371153 == -246979)
															{
																goto IL_24F;
															}
															if (characterControl.hp > 0)
															{
																if (232563 - 73251 != 159312)
																{
																	goto IL_24F;
																}
																this.mwvuWm9sK4.myAttackTarget = gameObject;
																if (170599 - 581075 == -410475)
																{
																	goto IL_24F;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (88095 - 290061 != -201966)
																{
																	goto IL_24F;
																}
																this.mwvuWm9sK4.addHate(characterControl.ActorNr, 5);
																if (109795 - 265191 != -155396)
																{
																	goto IL_24F;
																}
															}
														}
													}
													if (this.mwvuWm9sK4.myAttackTarget)
													{
														if (141452 - 412123 == -270670)
														{
															goto IL_24F;
														}
														this.mwvuWm9sK4.isAlert = true;
														if (291951 - 90896 != 201055)
														{
															goto IL_24F;
														}
														this.wnWuykr6WH = Time.time;
														if (170844 - 241244 == -70399)
														{
															goto IL_24F;
														}
													}
												}
											}
										}
									}
								}
							}
							if (175590 - 168962 != 6629)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x00801F3C File Offset: 0x0080013C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x00801F40 File Offset: 0x00800140
	internal static bool SStGvk5OiwibmT4dIegn()
	{
		return true;
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x00801F44 File Offset: 0x00800144
	internal static bool lYbgMy5OK5NfA3irfRjY()
	{
		return false;
	}

	// Token: 0x04004B56 RID: 19286
	private Transform jHdu90K3Ao;

	// Token: 0x04004B57 RID: 19287
	private CharacterControl mwvuWm9sK4;

	// Token: 0x04004B58 RID: 19288
	private MissileBot aX7uuZmtv5;

	// Token: 0x04004B59 RID: 19289
	public string AI_state;

	// Token: 0x04004B5A RID: 19290
	private float wnWuykr6WH;

	// Token: 0x04004B5B RID: 19291
	private float mahuV89CN6;

	// Token: 0x04004B5C RID: 19292
	private int LGfuhTU7VN;

	// Token: 0x04004B5D RID: 19293
	private int a7GuKccT7d;

	// Token: 0x04004B5E RID: 19294
	private GameObject NIsuzMM6fd;

	// Token: 0x04004B5F RID: 19295
	private float yRXy5h4Xb3;
}
