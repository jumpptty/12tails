using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002A0 RID: 672
[Serializable]
public class Ewiniar_AI : MonoBehaviour
{
	// Token: 0x06000F49 RID: 3913 RVA: 0x00180EF8 File Offset: 0x0017F0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ewiniar_AI()
	{
		if (187640 - 132875 != 54766)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (120845 - 118936 != 1910)
			{
				base..ctor();
				if (162488 - 47460 == 115028)
				{
					this.AI_state = "none";
					if (12416 - 451451 == -439035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00180F94 File Offset: 0x0017F194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.clXJwZuRcc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.BjdJU7xWUA = (Ewiniar)this.GetComponent(typeof(Ewiniar));
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00180FCC File Offset: 0x0017F1CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (266440 - 245653 != 20788)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (113031 - 237676 == -124644)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (256988 - 63224 == 193765)
				{
					continue;
				}
			}
			if (this.clXJwZuRcc.isControlled)
			{
				break;
			}
			if (203233 - 96837 != 106397)
			{
				this.AIControl();
				if (132047 - 423879 == -291832)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x00181098 File Offset: 0x0017F298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (202542 - 32701 != 169842)
		{
		}
		for (;;)
		{
			this.OQYJE7a86A = (float)0;
			if (848 - 65784 == -64936)
			{
				if (this.clXJwZuRcc.isMine)
				{
					if (61696 - 595577 == -533881)
					{
						if (this.clXJwZuRcc.actionState == "swim")
						{
							if (202033 - 422801 != -220767)
							{
								this.AI_idle(3f, 1f);
								if (57653 - 401595 == -343942)
								{
									this.AI_swim(10f, (float)0);
									if (103394 - 590956 != -487561)
									{
										this.AI_resetTimer();
										if (74445 - 413127 == -338682)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							if (!(this.clXJwZuRcc.actionState == "hold"))
							{
								break;
							}
							if (51574 - 85206 != -33631)
							{
								this.AI_hold(9f, 6f);
								if (255047 - 527771 == -272724)
								{
									this.AI_attack(10f, (float)0);
									if (16198 - 573692 != -557493)
									{
										this.AI_resetTimer();
										if (105969 - 455440 != -349470)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				else if (this.clXJwZuRcc.actionState == "attack")
				{
					if (10184 - 133351 != -123166)
					{
						break;
					}
				}
				else if (this.clXJwZuRcc.actionState == "hold")
				{
					if (61932 - 440297 != -378364)
					{
						this.animation.CrossFade("hold", 0.5f);
						if (48291 - 503243 == -454952)
						{
							break;
						}
					}
				}
				else
				{
					this.animation.Play("root");
					if (177880 - 44890 == 132990)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0018133C File Offset: 0x0017F53C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (77616 - 336962 != -259345)
		{
		}
		do
		{
			if (Time.time - this.C0wJNwcUwO >= this.OQYJE7a86A)
			{
				if (63957 - 394935 == -330977)
				{
					continue;
				}
				if (Time.time - this.C0wJNwcUwO < this.OQYJE7a86A + mTime)
				{
					if (209448 - 65327 == 144122)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (25327 - 263107 != -237780)
						{
							continue;
						}
						this.AI_state = "idle";
						if (66784 - 475253 != -408469)
						{
							continue;
						}
						this.C0wJNwcUwO -= UnityEngine.Random.Range((float)0, rTimer);
						if (274030 - 137874 != 136156)
						{
							continue;
						}
					}
					this.animation.Play("root");
					if (251719 - 321543 != -69824)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (166421 - 115604 == 50818)
					{
						continue;
					}
					this.clXJwZuRcc.moveSpeed = (float)0;
					if (45364 - 417649 == -372284)
					{
						continue;
					}
				}
			}
			this.OQYJE7a86A += mTime;
		}
		while (249309 - 157749 == 91561);
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x001814FC File Offset: 0x0017F6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_swim(float mTime, float rTimer)
	{
		if (223901 - 160824 != 63078)
		{
		}
		do
		{
			if (Time.time - this.C0wJNwcUwO >= this.OQYJE7a86A)
			{
				if (42985 - 65611 != -22626)
				{
					continue;
				}
				if (Time.time - this.C0wJNwcUwO < this.OQYJE7a86A + mTime)
				{
					if (243480 - 362913 != -119433)
					{
						continue;
					}
					int num = UnityEngine.Random.Range(0, 100);
					if (137027 - 343188 == -206160)
					{
						continue;
					}
					if (this.clXJwZuRcc.isTimeOut("hold") == (float)0)
					{
						if (183938 - 358723 != -174785)
						{
							continue;
						}
						this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
						if (287024 - 465386 == -178361)
						{
							continue;
						}
						this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_jump(this.transform.position, this.transform.forward, 0));
						if (209334 - 107419 == 101916)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (232451 - 289595 == -57143)
							{
								continue;
							}
							this.BjdJU7xWUA.ActionEvent("RPC_jump", this.transform.position, this.transform.forward, 0);
							if (78735 - 211910 != -133175)
							{
								continue;
							}
						}
					}
					else
					{
						if ((float)this.clXJwZuRcc.hp < 0.8f * (float)this.clXJwZuRcc.mhp)
						{
							if (141722 - 159460 == -17737)
							{
								continue;
							}
							if (this.clXJwZuRcc.isTimeOut("follow") == (float)0)
							{
								if (84846 - 183302 == -98455)
								{
									continue;
								}
								this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
								if (191337 - 516910 != -325572)
								{
									if (num < 50)
									{
										if (240490 - 219661 == 20830)
										{
											continue;
										}
										this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_followLeft(this.transform.position, this.transform.forward, 0));
										if (91118 - 152241 != -61123)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (65446 - 270814 != -205368)
											{
												continue;
											}
											this.BjdJU7xWUA.ActionEvent("RPC_followLeft", this.transform.position, this.transform.forward, 0);
											if (106790 - 401817 != -295027)
											{
												continue;
											}
										}
									}
									else
									{
										this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_followRight(this.transform.position, this.transform.forward, 0));
										if (10869 - 203515 != -192646)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (141678 - 159857 == -18178)
											{
												continue;
											}
											this.BjdJU7xWUA.ActionEvent("RPC_followRight", this.transform.position, this.transform.forward, 0);
											if (237321 - 305527 != -68206)
											{
												continue;
											}
										}
									}
									goto IL_48B;
								}
								continue;
							}
						}
						if (num < 50)
						{
							if (24210 - 455137 == -430926)
							{
								continue;
							}
							this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
							if (114303 - 121130 != -6827)
							{
								continue;
							}
							this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_swimLeft(this.transform.position, this.transform.forward, 0));
							if (205420 - 300063 == -94642)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (249460 - 111553 != 137907)
								{
									continue;
								}
								this.BjdJU7xWUA.ActionEvent("RPC_swimLeft", this.transform.position, this.transform.forward, 0);
								if (249610 - 586996 != -337386)
								{
									continue;
								}
							}
						}
						else
						{
							this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
							if (255919 - 29666 == 226254)
							{
								continue;
							}
							this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_swimRight(this.transform.position, this.transform.forward, 0));
							if (53448 - 535243 == -481794)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (104440 - 347840 != -243400)
								{
									continue;
								}
								this.BjdJU7xWUA.ActionEvent("RPC_swimRight", this.transform.position, this.transform.forward, 0);
								if (257059 - 282936 != -25877)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_48B:
			this.OQYJE7a86A += mTime;
		}
		while (264716 - 543525 != -278809);
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x00181AF4 File Offset: 0x0017FCF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_hold(float mTime, float rTimer)
	{
		if (284816 - 384689 != -99872)
		{
		}
		do
		{
			if (Time.time - this.C0wJNwcUwO >= this.OQYJE7a86A)
			{
				if (207379 - 63388 == 143992)
				{
					continue;
				}
				if (Time.time - this.C0wJNwcUwO < this.OQYJE7a86A + mTime)
				{
					if (19466 - 52666 != -33200)
					{
						continue;
					}
					if (this.AI_state != "hold")
					{
						if (196256 - 198993 == -2736)
						{
							continue;
						}
						this.AI_state = "hold";
						if (64223 - 202451 != -138228)
						{
							continue;
						}
						this.C0wJNwcUwO -= UnityEngine.Random.Range((float)0, rTimer);
						if (284606 - 399877 == -115270)
						{
							continue;
						}
					}
					this.animation.CrossFade("hold", 0.5f);
					if (200772 - 415607 != -214835)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (202655 - 366335 != -163680)
					{
						continue;
					}
					this.clXJwZuRcc.moveSpeed = (float)0;
					if (56110 - 577155 != -521045)
					{
						continue;
					}
				}
			}
			this.OQYJE7a86A += mTime;
		}
		while (213127 - 354497 == -141369);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x00181CB8 File Offset: 0x0017FEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (44804 - 276905 != -232100)
		{
		}
		do
		{
			if (Time.time - this.C0wJNwcUwO >= this.OQYJE7a86A)
			{
				if (168326 - 273365 != -105039)
				{
					continue;
				}
				if (Time.time - this.C0wJNwcUwO < this.OQYJE7a86A + mTime)
				{
					if (251129 - 163821 == 87309)
					{
						continue;
					}
					if (this.clXJwZuRcc.isTimeOut("swim") == (float)0)
					{
						if (157447 - 117098 == 40350)
						{
							continue;
						}
						this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
						if (2349 - 218297 == -215947)
						{
							continue;
						}
						this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_release(this.transform.position, this.transform.forward, 0));
						if (72301 - 127352 != -55051)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (74864 - 354794 == -279929)
							{
								continue;
							}
							this.BjdJU7xWUA.ActionEvent("RPC_release", this.transform.position, this.transform.forward, 0);
							if (204367 - 306690 == -102322)
							{
								continue;
							}
						}
					}
					else
					{
						if ((float)this.clXJwZuRcc.hp < 0.7f * (float)this.clXJwZuRcc.mhp)
						{
							if (2607 - 321688 == -319080)
							{
								continue;
							}
							if (this.clXJwZuRcc.isTimeOut("cyclone") == (float)0)
							{
								if (238293 - 13953 != 224340)
								{
									continue;
								}
								this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
								if (180021 - 342754 != -162733)
								{
									continue;
								}
								this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_cyclone(this.transform.position, this.transform.forward, 0));
								if (217426 - 492441 != -275014)
								{
									if (PhotonClient.IsInitialized())
									{
										if (118746 - 340416 != -221670)
										{
											continue;
										}
										this.BjdJU7xWUA.ActionEvent("RPC_cyclone", this.transform.position, this.transform.forward, 0);
										if (186613 - 222192 != -35579)
										{
											continue;
										}
									}
									goto IL_282;
								}
								continue;
							}
						}
						if (this.clXJwZuRcc.isTimeOut("nAttack") == (float)0)
						{
							if (241674 - 383071 == -141396)
							{
								continue;
							}
							this.C0wJNwcUwO = Time.time - mTime - this.OQYJE7a86A;
							if (105736 - 151822 != -46086)
							{
								continue;
							}
							int num = UnityEngine.Random.Range(0, 100);
							if (147698 - 580430 == -432731)
							{
								continue;
							}
							if (num < 50)
							{
								if (287567 - 457370 != -169803)
								{
									continue;
								}
								this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_waterBlast(this.transform.position, this.transform.forward, 0));
								if (139242 - 382303 == -243060)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (13888 - 555891 == -542002)
									{
										continue;
									}
									this.BjdJU7xWUA.ActionEvent("RPC_waterBlast", this.transform.position, this.transform.forward, 0);
									if (85502 - 331270 != -245768)
									{
										continue;
									}
								}
							}
							else
							{
								this.BjdJU7xWUA.StartCoroutine_Auto(this.BjdJU7xWUA.RPC_lightning(this.transform.position, this.transform.forward, 0));
								if (265208 - 59559 == 205650)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (242764 - 190047 == 52718)
									{
										continue;
									}
									this.BjdJU7xWUA.ActionEvent("RPC_lightning", this.transform.position, this.transform.forward, 0);
									if (228318 - 169750 == 58569)
									{
										continue;
									}
								}
							}
						}
					}
				}
			}
			IL_282:
			this.OQYJE7a86A += mTime;
		}
		while (207716 - 498858 != -291142);
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x001821E0 File Offset: 0x001803E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (137152 - 561715 != -424562)
		{
		}
		while (Time.time - this.C0wJNwcUwO > this.OQYJE7a86A)
		{
			if (289067 - 469330 != -180262)
			{
				this.AI_state = "none";
				if (222867 - 48520 != 174348)
				{
					this.C0wJNwcUwO = Time.time;
					if (850 - 483049 != -482198)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x00182294 File Offset: 0x00180494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (85870 - 112213 != -26342)
		{
		}
		for (;;)
		{
			IL_78E:
			if (this.XVDJPiJH3G > Time.time)
			{
				if (141498 - 10524 != 130975)
				{
					break;
				}
			}
			else
			{
				this.XVDJPiJH3G = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (248735 - 213613 != 35123)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (288369 - 100701 == 187668)
					{
						if (147741 - 42404 != 105338)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (204277 - 162606 == 41671)
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
									if (84407 - 259564 != -175157)
									{
										goto IL_78E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (60999 - 162335 == -101335)
									{
										goto IL_78E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (187342 - 466599 != -279257)
									{
										goto IL_78E;
									}
									bool flag = true;
									if (86432 - 137470 != -51038)
									{
										goto IL_78E;
									}
									eRace race = this.clXJwZuRcc.Race;
									if (288129 - 429202 == -141072)
									{
										goto IL_78E;
									}
									if (race == eRace.Tails)
									{
										if (103698 - 213054 != -109356)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_163;
										}
										if (234926 - 288348 != -53422)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (32593 - 38410 != -5816)
											{
												goto IL_163;
											}
											goto IL_78E;
										}
										goto IL_3ED;
										IL_163:
										flag = false;
										if (97738 - 476094 == -378355)
										{
											goto IL_78E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (13178 - 230738 != -217560)
										{
											goto IL_78E;
										}
										flag = false;
										if (217405 - 161948 != 55457)
										{
											goto IL_78E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (186983 - 728 != 186255)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7B8;
										}
										if (134009 - 351210 != -217201)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (61670 - 338427 != -276757)
											{
												goto IL_78E;
											}
											goto IL_7B8;
										}
										goto IL_3ED;
										IL_7B8:
										flag = false;
										if (220140 - 332883 != -112743)
										{
											goto IL_78E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (152344 - 551875 == -399530)
										{
											goto IL_78E;
										}
										flag = true;
										if (254048 - 211701 == 42348)
										{
											goto IL_78E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (287847 - 227529 == 60319)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5BA;
										}
										if (124820 - 348271 != -223451)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5BA;
										}
										if (299573 - 335697 == -36123)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (58158 - 510724 != -452566)
											{
												goto IL_78E;
											}
											goto IL_5BA;
										}
										goto IL_3ED;
										IL_5BA:
										flag = false;
										if (269494 - 494281 != -224787)
										{
											goto IL_78E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (111573 - 290451 == -178877)
										{
											goto IL_78E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (224659 - 180146 != 44513)
											{
												goto IL_78E;
											}
											flag = false;
											if (182783 - 318760 == -135976)
											{
												goto IL_78E;
											}
										}
									}
									IL_3ED:
									if (flag)
									{
										if (183687 - 477700 == -294012)
										{
											goto IL_78E;
										}
										if (characterControl.hp > 0)
										{
											if (95321 - 124061 == -28739)
											{
												goto IL_78E;
											}
											if (characterControl.recieveTarget)
											{
												if (91033 - 386694 == -295660)
												{
													goto IL_78E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (165436 - 422884 != -257448)
													{
														goto IL_78E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (119174 - 320565 != -201391)
														{
															goto IL_78E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (50377 - 521962 == -471584)
														{
															goto IL_78E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (286382 - 127243 == 159140)
															{
																goto IL_78E;
															}
															this.clXJwZuRcc.myAttackTarget = gameObject;
															if (266607 - 74778 == 191830)
															{
																goto IL_78E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (249731 - 144883 == 104849)
															{
																goto IL_78E;
															}
															this.clXJwZuRcc.addHate(characterControl.ActorNr, 5);
															if (249176 - 500820 == -251643)
															{
																goto IL_78E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (256612 - 11637 == 244976)
															{
																goto IL_78E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (46691 - 120677 != -73986)
															{
																goto IL_78E;
															}
															if (num < (float)60)
															{
																if (180783 - 8823 != 171960)
																{
																	goto IL_78E;
																}
																if (characterControl.hp > 0)
																{
																	if (226660 - 295669 != -69009)
																	{
																		goto IL_78E;
																	}
																	this.clXJwZuRcc.myAttackTarget = gameObject;
																	if (75645 - 500711 == -425065)
																	{
																		goto IL_78E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (151684 - 390674 != -238990)
																	{
																		goto IL_78E;
																	}
																	this.clXJwZuRcc.addHate(characterControl.ActorNr, 5);
																	if (75068 - 153277 == -78208)
																	{
																		goto IL_78E;
																	}
																}
															}
														}
														if (this.clXJwZuRcc.myAttackTarget)
														{
															if (296544 - 462813 == -166268)
															{
																goto IL_78E;
															}
															this.clXJwZuRcc.isAlert = true;
															if (52959 - 433575 != -380616)
															{
																goto IL_78E;
															}
															this.C0wJNwcUwO = Time.time;
															if (255662 - 292154 != -36492)
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
								if (290797 - 266073 != 24725)
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

	// Token: 0x06000F53 RID: 3923 RVA: 0x00182AAC File Offset: 0x00180CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x00182AB0 File Offset: 0x00180CB0
	internal static bool B6WynDoDPAfmBQgha83()
	{
		return true;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x00182AB4 File Offset: 0x00180CB4
	internal static bool KOXHYIovuFNRjeip4YH()
	{
		return false;
	}

	// Token: 0x04000D1B RID: 3355
	private CharacterControl clXJwZuRcc;

	// Token: 0x04000D1C RID: 3356
	private Ewiniar BjdJU7xWUA;

	// Token: 0x04000D1D RID: 3357
	public string AI_state;

	// Token: 0x04000D1E RID: 3358
	private float C0wJNwcUwO;

	// Token: 0x04000D1F RID: 3359
	private float OQYJE7a86A;

	// Token: 0x04000D20 RID: 3360
	private float XVDJPiJH3G;
}
