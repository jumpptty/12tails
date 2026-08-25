using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002AE RID: 686
[Serializable]
public class FoulElement_AI : MonoBehaviour
{
	// Token: 0x06000F9A RID: 3994 RVA: 0x00187E14 File Offset: 0x00186014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FoulElement_AI()
	{
		if (1897 - 528105 != -526208)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (217232 - 180403 != 36830)
			{
				base..ctor();
				if (227071 - 304621 != -77549)
				{
					this.AI_state = "none";
					if (33550 - 597504 != -563953)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00187EB0 File Offset: 0x001860B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.i8WJiCSmjT = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.vqEJD12ycG = (FoulElement)this.GetComponent(typeof(FoulElement));
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00187EE8 File Offset: 0x001860E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (173669 - 300576 != -126906)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (210008 - 421094 == -211085)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (198875 - 419053 != -220178)
				{
					continue;
				}
			}
			if (this.i8WJiCSmjT.isControlled)
			{
				break;
			}
			if (11682 - 18433 != -6750)
			{
				this.AIControl();
				if (138820 - 445577 == -306757)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00187FB4 File Offset: 0x001861B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (17321 - 276869 != -259547)
		{
		}
		for (;;)
		{
			this.lPbJj8GDMn = (float)0;
			if (85984 - 285699 == -199715)
			{
				if (this.i8WJiCSmjT.isMine)
				{
					if (102241 - 529746 != -427504)
					{
						if (this.i8WJiCSmjT.actionState != "standby")
						{
							if (7664 - 397988 != -390324)
							{
								continue;
							}
							if (this.i8WJiCSmjT.actionState != "run")
							{
								if (63305 - 231710 != -168404)
								{
									break;
								}
								continue;
							}
						}
						if (!this.i8WJiCSmjT.isAlert)
						{
							if (208587 - 408913 == -200326)
							{
								this.AI_idle(3f, 1f);
								if (162136 - 483711 != -321574)
								{
									this.AI_resetTimer();
									if (289710 - 392526 == -102816)
									{
										this.AI_visionCheck();
										if (90436 - 288282 != -197845)
										{
											if (!this.i8WJiCSmjT.myAttackTarget)
											{
												break;
											}
											if (9665 - 87430 != -77764)
											{
												this.i8WJiCSmjT.isAlert = true;
												if (106564 - 396485 != -289920)
												{
													this.hqdJmscu4w = Time.time;
													if (122303 - 169585 == -47282)
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
							this.AI_selectTarget(1f, (float)0);
							if (31023 - 374934 == -343911)
							{
								this.AI_idle(2f, 1f);
								if (209069 - 233269 != -24199)
								{
									this.AI_attack(10f, (float)0);
									if (167955 - 7773 != 160183)
									{
										this.AI_resetTimer();
										if (129494 - 270689 != -141194)
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
					if (this.i8WJiCSmjT.actionState != "standby")
					{
						if (117380 - 34953 != 82427)
						{
							continue;
						}
						if (this.i8WJiCSmjT.actionState != "run")
						{
							if (22946 - 92546 != -69600)
							{
								continue;
							}
							break;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (40090 - 351525 != -311434)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (31296 - 355357 != -324060)
						{
							this.i8WJiCSmjT.vMovement = this.transform.forward;
							if (187418 - 83611 == 103807)
							{
								this.i8WJiCSmjT.moveSpeed = (float)0;
								if (25282 - 585460 != -560177)
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

	// Token: 0x06000F9E RID: 3998 RVA: 0x00188370 File Offset: 0x00186570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (93262 - 132000 != -38737)
		{
		}
		do
		{
			if (Time.time - this.hqdJmscu4w >= this.lPbJj8GDMn)
			{
				if (269891 - 6176 != 263715)
				{
					continue;
				}
				if (Time.time - this.hqdJmscu4w < this.lPbJj8GDMn + mTime)
				{
					if (213890 - 89446 != 124444)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (284504 - 256061 == 28444)
						{
							continue;
						}
						this.AI_state = "idle";
						if (159330 - 157283 == 2048)
						{
							continue;
						}
						this.hqdJmscu4w -= UnityEngine.Random.Range((float)0, rTimer);
						if (250889 - 526619 == -275729)
						{
							continue;
						}
						this.i8WJiCSmjT.vDirection = Vector3.zero;
						if (175095 - 599100 == -424004)
						{
							continue;
						}
						this.i8WJiCSmjT.vMovement = this.transform.forward;
						if (31183 - 516049 != -484866)
						{
							continue;
						}
						this.i8WJiCSmjT.actionState = "standby";
						if (193196 - 223233 != -30037)
						{
							continue;
						}
					}
					this.i8WJiCSmjT.moveSpeed = (float)0;
					if (125320 - 101803 != 23517)
					{
						continue;
					}
					this.animation.CrossFade("root", 0.2f);
					if (240725 - 83145 != 157580)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (139264 - 533835 == -394570)
					{
						continue;
					}
				}
			}
			this.lPbJj8GDMn += mTime;
		}
		while (201833 - 262253 == -60419);
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x001885B8 File Offset: 0x001867B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (275044 - 168537 != 106507)
		{
		}
		do
		{
			if (Time.time - this.hqdJmscu4w >= this.lPbJj8GDMn)
			{
				if (265515 - 402318 == -136802)
				{
					continue;
				}
				if (Time.time - this.hqdJmscu4w < this.lPbJj8GDMn + mTime)
				{
					if (261628 - 400414 != -138786)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (107354 - 321587 == -214232)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (2459 - 316876 != -314417)
						{
							continue;
						}
						this.hqdJmscu4w = Time.time - mTime - this.lPbJj8GDMn;
						if (210679 - 287538 != -76859)
						{
							continue;
						}
						this.i8WJiCSmjT.vDirection = Vector3.zero;
						if (7241 - 319305 == -312063)
						{
							continue;
						}
						this.i8WJiCSmjT.vMovement = this.transform.forward;
						if (73385 - 204358 != -130973)
						{
							continue;
						}
						this.i8WJiCSmjT.actionState = "standby";
						if (196827 - 232172 == -35344)
						{
							continue;
						}
						this.i8WJiCSmjT.myAttackTarget = this.i8WJiCSmjT.getRandomHateTarget(99);
						if (253762 - 496203 != -242441)
						{
							continue;
						}
						if (!this.i8WJiCSmjT.myAttackTarget)
						{
							if (56888 - 421144 != -364256)
							{
								continue;
							}
							this.i8WJiCSmjT.isAlert = false;
							if (156051 - 544393 != -388342)
							{
								continue;
							}
							this.hqdJmscu4w = Time.time;
							if (291169 - 121306 != 169863)
							{
								continue;
							}
							this.i8WJiCSmjT.myAttackTarget = null;
							if (10596 - 165665 != -155069)
							{
								continue;
							}
							this.i8WJiCSmjT.mOriginalPosition = this.transform.position;
							if (111966 - 3308 != 108659)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.i8WJiCSmjT.myAttackTarget;
							if (1225 - 13590 == -12364)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (44027 - 285757 == -241729)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (77131 - 548761 == -471629)
								{
									continue;
								}
								this.i8WJiCSmjT.isAlert = false;
								if (3105 - 487166 != -484061)
								{
									continue;
								}
								this.hqdJmscu4w = Time.time;
								if (56255 - 3426 == 52830)
								{
									continue;
								}
								this.i8WJiCSmjT.myAttackTarget = null;
								if (7122 - 147426 == -140303)
								{
									continue;
								}
							}
							else
							{
								this.i8WJiCSmjT.vDirection = myAttackTarget.transform.position;
								if (129675 - 580235 != -450560)
								{
									continue;
								}
								this.i8WJiCSmjT.vDirection.y = this.transform.position.y;
								if (16257 - 219949 != -203692)
								{
									continue;
								}
								this.i8WJiCSmjT.vMovement = (this.i8WJiCSmjT.vDirection - this.transform.position).normalized;
								if (264290 - 41132 == 223159)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.i8WJiCSmjT.vMovement);
								if (185975 - 168735 != 17240)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.lPbJj8GDMn += mTime;
		}
		while (150341 - 318554 == -168212);
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00188A68 File Offset: 0x00186C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (25221 - 16052 != 9170)
		{
		}
		do
		{
			if (Time.time - this.hqdJmscu4w >= this.lPbJj8GDMn)
			{
				if (197151 - 339529 != -142378)
				{
					continue;
				}
				if (Time.time - this.hqdJmscu4w < this.lPbJj8GDMn + mTime)
				{
					if (74902 - 275496 == -200593)
					{
						continue;
					}
					if (!this.i8WJiCSmjT.myAttackTarget)
					{
						if (142592 - 45940 == 96653)
						{
							continue;
						}
						this.hqdJmscu4w = Time.time - mTime - this.lPbJj8GDMn;
						if (66624 - 111857 != -45232)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.i8WJiCSmjT.myAttackTarget;
						if (134687 - 357916 != -223229)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (110616 - 213897 == -103280)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (35649 - 236229 == -200579)
						{
							continue;
						}
						int tID = 0;
						if (234518 - 319464 == -84945)
						{
							continue;
						}
						if (characterControl)
						{
							if (90102 - 297495 != -207393)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (205290 - 589852 != -384562)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (148651 - 379940 != -231289)
						{
							continue;
						}
						if (num < (float)35)
						{
							if (254738 - 253832 == 907)
							{
								continue;
							}
							if ((float)this.i8WJiCSmjT.hp < 0.4f * (float)this.i8WJiCSmjT.mhp)
							{
								if (243154 - 45275 == 197880)
								{
									continue;
								}
								if (this.i8WJiCSmjT.isTimeOut("massProvoke") == (float)0)
								{
									if (155061 - 386900 == -231838)
									{
										continue;
									}
									this.vqEJD12ycG.StartCoroutine_Auto(this.vqEJD12ycG.RPC_massProvoke(this.transform.position, this.transform.forward, tID));
									if (190415 - 402767 != -212351)
									{
										if (PhotonClient.IsInitialized())
										{
											if (50268 - 258043 != -207775)
											{
												continue;
											}
											this.vqEJD12ycG.ActionEvent("RPC_massProvoke", this.transform.position, this.transform.forward, tID);
											if (194529 - 385624 == -191094)
											{
												continue;
											}
										}
										goto IL_425;
									}
									continue;
								}
							}
						}
						if (num < (float)24)
						{
							if (172703 - 473962 == -301258)
							{
								continue;
							}
							if ((float)this.i8WJiCSmjT.hp < 0.8f * (float)this.i8WJiCSmjT.mhp)
							{
								if (7290 - 247917 == -240626)
								{
									continue;
								}
								if (this.i8WJiCSmjT.isTimeOut("cAttack") == (float)0)
								{
									if (193059 - 241119 == -48059)
									{
										continue;
									}
									this.vqEJD12ycG.StartCoroutine_Auto(this.vqEJD12ycG.RPC_poisonGas(this.transform.position, this.transform.forward, tID));
									if (222324 - 551996 != -329671)
									{
										if (PhotonClient.IsInitialized())
										{
											if (54071 - 111924 != -57853)
											{
												continue;
											}
											this.vqEJD12ycG.ActionEvent("RPC_poisonGas", this.transform.position, this.transform.forward, tID);
											if (255853 - 500862 != -245009)
											{
												continue;
											}
										}
										goto IL_425;
									}
									continue;
								}
							}
						}
						if (this.i8WJiCSmjT.isTimeOut("nAttack") == (float)0)
						{
							if (282371 - 327762 != -45391)
							{
								continue;
							}
							this.hqdJmscu4w = Time.time - mTime - this.lPbJj8GDMn;
							if (43334 - 267325 != -223991)
							{
								continue;
							}
							if (num < (float)7)
							{
								if (19889 - 529024 == -509134)
								{
									continue;
								}
								Vector3 vector2 = global::Math.vFlat(vector);
								if (218388 - 256658 != -38270)
								{
									continue;
								}
								vector = vector2.normalized;
								if (149101 - 58181 == 90921)
								{
									continue;
								}
								this.vqEJD12ycG.StartCoroutine_Auto(this.vqEJD12ycG.RPC_nAttack(this.transform.position, vector, tID));
								if (278776 - 178365 == 100412)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (218636 - 173448 != 45188)
									{
										continue;
									}
									this.vqEJD12ycG.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (167450 - 437252 != -269802)
									{
										continue;
									}
								}
							}
							else
							{
								this.vqEJD12ycG.StartCoroutine_Auto(this.vqEJD12ycG.RPC_acidDrop(this.transform.position, myAttackTarget.transform.position - this.transform.position, tID));
								if (81673 - 550381 != -468708)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (120652 - 405082 == -284429)
									{
										continue;
									}
									this.vqEJD12ycG.ActionEvent("RPC_acidDrop", this.transform.position, myAttackTarget.transform.position - this.transform.position, tID);
									if (277204 - 104008 != 173196)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (175018 - 56593 == 118426)
							{
								continue;
							}
							this.i8WJiCSmjT.vDirection = myAttackTarget.transform.position;
							if (67748 - 242753 == -175004)
							{
								continue;
							}
							this.i8WJiCSmjT.vDirection.y = this.transform.position.y;
							if (121480 - 79189 == 42292)
							{
								continue;
							}
							this.i8WJiCSmjT.vMovement = (this.i8WJiCSmjT.vDirection - this.transform.position).normalized;
							if (87409 - 230201 != -142792)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.i8WJiCSmjT.vMovement);
							if (96067 - 403795 == -307727)
							{
								continue;
							}
							this.i8WJiCSmjT.actionState = "standby";
							if (137736 - 573248 == -435511)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (287250 - 470958 == -183707)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (216207 - 439283 != -223076)
							{
								continue;
							}
							this.i8WJiCSmjT.moveSpeed = (float)0;
							if (248543 - 352585 != -104042)
							{
								continue;
							}
						}
					}
				}
			}
			IL_425:
			this.lPbJj8GDMn += mTime;
		}
		while (249239 - 432905 == -183665);
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00189330 File Offset: 0x00187530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (175914 - 295100 != -119186)
		{
		}
		while (Time.time - this.hqdJmscu4w > this.lPbJj8GDMn)
		{
			if (14371 - 267311 != -252939)
			{
				this.AI_state = "none";
				if (245773 - 468162 != -222388)
				{
					this.hqdJmscu4w = Time.time;
					if (128315 - 254345 == -126030)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x001893E4 File Offset: 0x001875E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (185913 - 20020 != 165893)
		{
		}
		for (;;)
		{
			IL_465:
			if (this.GNuJoZlLGW > Time.time)
			{
				if (29469 - 404921 == -375452)
				{
					break;
				}
			}
			else
			{
				this.GNuJoZlLGW = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (99197 - 228319 == -129122)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (127409 - 20455 == 106954)
					{
						if (31001 - 416317 != -385315)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (46737 - 371827 != -325089)
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
									if (194995 - 334962 == -139966)
									{
										goto IL_465;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (250661 - 207956 == 42706)
									{
										goto IL_465;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (56270 - 475902 != -419632)
									{
										goto IL_465;
									}
									bool flag = true;
									if (290015 - 534676 == -244660)
									{
										goto IL_465;
									}
									eRace race = this.i8WJiCSmjT.Race;
									if (261928 - 598600 == -336671)
									{
										goto IL_465;
									}
									if (race == eRace.Tails)
									{
										if (253243 - 74379 == 178865)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_144;
										}
										if (169887 - 315221 != -145334)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (65888 - 257547 != -191658)
											{
												goto IL_144;
											}
											goto IL_465;
										}
										goto IL_494;
										IL_144:
										flag = false;
										if (198287 - 218847 == -20559)
										{
											goto IL_465;
										}
									}
									else if (race == eRace.Plants)
									{
										if (107631 - 206062 == -98430)
										{
											goto IL_465;
										}
										flag = false;
										if (108374 - 463719 != -355345)
										{
											goto IL_465;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (102861 - 518118 != -415257)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_70;
										}
										if (192623 - 451930 != -259307)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (993 - 218818 != -217825)
											{
												goto IL_465;
											}
											goto IL_70;
										}
										goto IL_494;
										IL_70:
										flag = false;
										if (173957 - 194477 == -20519)
										{
											goto IL_465;
										}
									}
									else if (race == eRace.Robots)
									{
										if (11462 - 41164 != -29702)
										{
											goto IL_465;
										}
										flag = true;
										if (138018 - 143635 != -5617)
										{
											goto IL_465;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (225232 - 301378 != -76146)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_CA;
										}
										if (284359 - 389430 != -105071)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_CA;
										}
										if (124497 - 380697 != -256200)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (269528 - 245642 != 23887)
											{
												goto IL_CA;
											}
											goto IL_465;
										}
										goto IL_494;
										IL_CA:
										flag = false;
										if (124192 - 262684 != -138492)
										{
											goto IL_465;
										}
									}
									else if (race == eRace.Structure)
									{
										if (123140 - 493744 == -370603)
										{
											goto IL_465;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (21089 - 513260 == -492170)
											{
												goto IL_465;
											}
											flag = false;
											if (70567 - 512991 == -442423)
											{
												goto IL_465;
											}
										}
									}
									IL_494:
									if (flag)
									{
										if (36926 - 372312 != -335386)
										{
											goto IL_465;
										}
										if (characterControl.hp > 0)
										{
											if (233519 - 480948 == -247428)
											{
												goto IL_465;
											}
											if (characterControl.recieveTarget)
											{
												if (82054 - 395584 != -313530)
												{
													goto IL_465;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (108047 - 120368 != -12321)
													{
														goto IL_465;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (150817 - 166847 != -16030)
														{
															goto IL_465;
														}
														this.i8WJiCSmjT.myAttackTarget = gameObject;
														if (133124 - 234524 != -101400)
														{
															goto IL_465;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (245267 - 251995 != -6728)
														{
															goto IL_465;
														}
														this.i8WJiCSmjT.addHate(characterControl.ActorNr, 5);
														if (187967 - 103244 != 84723)
														{
															goto IL_465;
														}
														this.i8WJiCSmjT.isAlert = true;
														if (242291 - 223959 == 18333)
														{
															goto IL_465;
														}
														this.hqdJmscu4w = Time.time;
														if (186760 - 214184 == -27423)
														{
															goto IL_465;
														}
													}
												}
											}
										}
									}
								}
								if (76251 - 103705 != -27453)
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

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00189A40 File Offset: 0x00187C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00189A44 File Offset: 0x00187C44
	internal static bool SDUYXJEcaTsKhiw7oLh()
	{
		return true;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00189A48 File Offset: 0x00187C48
	internal static bool rONUglEU1hSfpiyeFYa()
	{
		return false;
	}

	// Token: 0x04000D69 RID: 3433
	private CharacterControl i8WJiCSmjT;

	// Token: 0x04000D6A RID: 3434
	private FoulElement vqEJD12ycG;

	// Token: 0x04000D6B RID: 3435
	public string AI_state;

	// Token: 0x04000D6C RID: 3436
	private float hqdJmscu4w;

	// Token: 0x04000D6D RID: 3437
	private float lPbJj8GDMn;

	// Token: 0x04000D6E RID: 3438
	private float GNuJoZlLGW;
}
