using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DB1 RID: 3505
[Serializable]
public class Skunk_AI : MonoBehaviour
{
	// Token: 0x06004F15 RID: 20245 RVA: 0x009B4898 File Offset: 0x009B2A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Skunk_AI()
	{
		if (225027 - 392635 != -167608)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (134004 - 305820 != -171815)
			{
				base..ctor();
				if (234045 - 282090 != -48044)
				{
					this.AI_state = "none";
					if (101311 - 190548 != -89236)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004F16 RID: 20246 RVA: 0x009B4934 File Offset: 0x009B2B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LTCcnSSbZMP = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.igZcnB3MhGR = (Skunk)this.GetComponent(typeof(Skunk));
	}

	// Token: 0x06004F17 RID: 20247 RVA: 0x009B496C File Offset: 0x009B2B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (85844 - 227686 != -141842)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (164746 - 456890 != -292144)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (237855 - 556022 != -318167)
				{
					continue;
				}
			}
			if (this.LTCcnSSbZMP.isControlled)
			{
				break;
			}
			if (123687 - 225381 == -101694)
			{
				this.AIControl();
				if (273067 - 521416 != -248348)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004F18 RID: 20248 RVA: 0x009B4A38 File Offset: 0x009B2C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (231336 - 373622 != -142286)
		{
		}
		for (;;)
		{
			this.dGUcn84USXl = (float)0;
			if (227290 - 161758 != 65533)
			{
				if (this.LTCcnSSbZMP.isMine)
				{
					if (194400 - 468344 == -273944)
					{
						if (this.LTCcnSSbZMP.actionState != "standby")
						{
							if (185616 - 79193 != 106423)
							{
								continue;
							}
							if (this.LTCcnSSbZMP.actionState != "run")
							{
								if (180115 - 82678 != 97438)
								{
									break;
								}
								continue;
							}
						}
						if (!this.LTCcnSSbZMP.isAlert)
						{
							if (21533 - 68546 != -47012)
							{
								if (!this.LTCcnSSbZMP.isSummon)
								{
									goto IL_40A;
								}
								if (200241 - 432960 == -232718)
								{
									continue;
								}
								if (!(this.LTCcnSSbZMP.mSummoner != null))
								{
									goto IL_40A;
								}
								if (126942 - 143492 == -16549)
								{
									continue;
								}
								Vector3 vector = this.LTCcnSSbZMP.mSummoner.transform.position - this.transform.position;
								if (52812 - 509970 == -457157)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (39706 - 311851 == -272144)
									{
										continue;
									}
									this.AI_follow(this.LTCcnSSbZMP.mSummoner);
									if (250525 - 535421 != -284896)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (1419 - 348750 == -347330)
									{
										continue;
									}
									this.AI_resetTimer();
									if (55287 - 370386 != -315099)
									{
										continue;
									}
									this.AI_visionCheck();
									if (269384 - 385810 == -116425)
									{
										continue;
									}
								}
								IL_22C:
								if (!this.LTCcnSSbZMP.myAttackTarget)
								{
									break;
								}
								if (246476 - 152837 == 93640)
								{
									continue;
								}
								this.LTCcnSSbZMP.isAlert = true;
								if (254447 - 351701 != -97254)
								{
									continue;
								}
								this.qoxcn0DM4ZI = Time.time;
								if (267666 - 139319 != 128348)
								{
									break;
								}
								continue;
								IL_40A:
								this.AI_idle(3f, 1f);
								if (119969 - 291644 != -171674)
								{
									this.AI_patrol(1f, 0.25f);
									if (31909 - 305366 != -273456)
									{
										this.AI_resetTimer();
										if (75870 - 328144 == -252274)
										{
											this.AI_visionCheck();
											if (76585 - 563769 != -487183)
											{
												goto IL_22C;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (108545 - 594548 == -486003)
							{
								this.AI_idle(3f, 1f);
								if (98881 - 19235 != 79647)
								{
									this.AI_attack(10f, (float)0);
									if (75829 - 68661 == 7168)
									{
										this.AI_resetTimer();
										if (204077 - 168013 == 36064)
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
					if (this.LTCcnSSbZMP.actionState != "standby")
					{
						if (288253 - 264655 == 23599)
						{
							continue;
						}
						if (this.LTCcnSSbZMP.actionState != "run")
						{
							if (87172 - 266211 != -179038)
							{
								break;
							}
							continue;
						}
					}
					float num = this.LTCcnSSbZMP.moveSpeed;
					if (24119 - 164648 != -140528)
					{
						float runSpeed = this.LTCcnSSbZMP.runSpeed;
						if (137682 - 467514 == -329832)
						{
							Vector3 vector2 = default(Vector3);
							if (113668 - 592541 != -478872)
							{
								Vector3 vector3 = Vector3.zero;
								if (43831 - 447528 == -403697)
								{
									if ((this.LTCcnSSbZMP.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (55722 - 120122 != -64400)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.LTCcnSSbZMP.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (113224 - 97145 == 16080)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (60067 - 379299 == -319231)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (152361 - 446775 == -294413)
											{
												continue;
											}
											num = (float)0;
											if (197683 - 124096 != 73587)
											{
												continue;
											}
											this.transform.position = this.LTCcnSSbZMP.nPosition;
											if (72589 - 37691 == 34899)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (59472 - 312214 != -252742)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (52533 - 528295 == -475761)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (75336 - 482418 != -407082)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (219344 - 427981 == -208636)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (79417 - 366034 != -286617)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (191134 - 467064 != -275930)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (100435 - 92967 == 7469)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152399 - 269033 != -116634)
											{
												continue;
											}
										}
									}
									this.LTCcnSSbZMP.vMovement = vector3;
									if (78406 - 378317 != -299910)
									{
										this.LTCcnSSbZMP.moveSpeed = num;
										if (102615 - 198121 == -95506)
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

	// Token: 0x06004F19 RID: 20249 RVA: 0x009B5214 File Offset: 0x009B3414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (194713 - 266014 != -71300)
		{
		}
		do
		{
			if (Time.time - this.qoxcn0DM4ZI >= this.dGUcn84USXl)
			{
				if (287218 - 254663 != 32555)
				{
					continue;
				}
				if (Time.time - this.qoxcn0DM4ZI < this.dGUcn84USXl + mTime)
				{
					if (32566 - 192130 != -159564)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (216318 - 563254 == -346935)
						{
							continue;
						}
						this.AI_state = "idle";
						if (259344 - 524354 == -265009)
						{
							continue;
						}
						this.qoxcn0DM4ZI -= UnityEngine.Random.Range((float)0, rTimer);
						if (248790 - 291378 != -42588)
						{
							continue;
						}
						this.LTCcnSSbZMP.vDirection = Vector3.zero;
						if (98763 - 545316 == -446552)
						{
							continue;
						}
						this.LTCcnSSbZMP.vMovement = this.transform.forward;
						if (192116 - 482450 == -290333)
						{
							continue;
						}
						this.LTCcnSSbZMP.actionState = "standby";
						if (216871 - 356824 == -139952)
						{
							continue;
						}
					}
					this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (207836 - 326486 != -118650)
					{
						continue;
					}
					if (this.LTCcnSSbZMP.moveSpeed < 0.1f * this.LTCcnSSbZMP.runSpeed)
					{
						if (79652 - 75516 != 4136)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (217958 - 133243 != 84715)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (34783 - 173372 != -138589)
						{
							continue;
						}
						this.LTCcnSSbZMP.moveSpeed = (float)0;
						if (279413 - 317692 != -38279)
						{
							continue;
						}
					}
				}
			}
			this.dGUcn84USXl += mTime;
		}
		while (202982 - 124079 == 78904);
	}

	// Token: 0x06004F1A RID: 20250 RVA: 0x009B54D8 File Offset: 0x009B36D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (151700 - 19056 != 132644)
		{
		}
		for (;;)
		{
			this.LTCcnSSbZMP.vDirection = followObject.transform.position;
			if (60648 - 94022 != -33373)
			{
				this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
				if (183016 - 394575 != -211558)
				{
					this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
					if (98797 - 403612 != -304814)
					{
						this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
						if (126205 - 173834 == -47629)
						{
							this.LTCcnSSbZMP.actionState = "run";
							if (109089 - 431491 != -322401)
							{
								this.animation.Play("run");
								if (152678 - 241011 == -88333)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (19056 - 515562 != -496505)
									{
										this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, this.LTCcnSSbZMP.runSpeed, (float)4 * Time.deltaTime);
										if (9212 - 2645 != 6568)
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

	// Token: 0x06004F1B RID: 20251 RVA: 0x009B56C0 File Offset: 0x009B38C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (181384 - 439531 != -258147)
		{
		}
		do
		{
			if (Time.time - this.qoxcn0DM4ZI >= this.dGUcn84USXl)
			{
				if (270237 - 140887 != 129350)
				{
					continue;
				}
				if (Time.time - this.qoxcn0DM4ZI < this.dGUcn84USXl + mTime)
				{
					if (170394 - 387579 != -217185)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (197545 - 3808 == 193738)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (285839 - 470326 == -184486)
						{
							continue;
						}
						this.qoxcn0DM4ZI -= UnityEngine.Random.Range((float)0, rTimer);
						if (205483 - 22418 == 183066)
						{
							continue;
						}
						this.LTCcnSSbZMP.vDirection = this.LTCcnSSbZMP.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (176035 - 587417 != -411382)
						{
							continue;
						}
						this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
						if (160909 - 386080 == -225170)
						{
							continue;
						}
						this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
						if (115682 - 342262 == -226579)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
						if (164282 - 202652 != -38370)
						{
							continue;
						}
						this.LTCcnSSbZMP.actionState = "run";
						if (107146 - 203577 != -96431)
						{
							continue;
						}
						this.animation.Play("run");
						if (232755 - 558093 != -325338)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (196060 - 340513 == -144452)
						{
							continue;
						}
					}
					this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, this.LTCcnSSbZMP.runSpeed, (float)4 * Time.deltaTime);
					if (99369 - 305955 != -206586)
					{
						continue;
					}
				}
			}
			this.dGUcn84USXl += mTime;
		}
		while (228348 - 474951 == -246602);
	}

	// Token: 0x06004F1C RID: 20252 RVA: 0x009B59C8 File Offset: 0x009B3BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (1064 - 520935 != -519871)
		{
		}
		do
		{
			if (Time.time - this.qoxcn0DM4ZI >= this.dGUcn84USXl)
			{
				if (268633 - 391612 != -122979)
				{
					continue;
				}
				if (Time.time - this.qoxcn0DM4ZI < this.dGUcn84USXl + mTime)
				{
					if (58553 - 23767 == 34787)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (253964 - 190181 == 63784)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (95081 - 121583 == -26501)
						{
							continue;
						}
						this.qoxcn0DM4ZI = Time.time - mTime - this.dGUcn84USXl;
						if (20196 - 205731 == -185534)
						{
							continue;
						}
						this.LTCcnSSbZMP.vDirection = Vector3.zero;
						if (84241 - 427264 == -343022)
						{
							continue;
						}
						this.LTCcnSSbZMP.vMovement = this.transform.forward;
						if (156366 - 499964 != -343598)
						{
							continue;
						}
						this.LTCcnSSbZMP.actionState = "standby";
						if (282750 - 3410 == 279341)
						{
							continue;
						}
						this.LTCcnSSbZMP.myAttackTarget = this.LTCcnSSbZMP.getHateTarget(5, 50);
						if (188624 - 255332 == -66707)
						{
							continue;
						}
						if (!this.LTCcnSSbZMP.myAttackTarget)
						{
							if (237091 - 468365 != -231274)
							{
								continue;
							}
							this.LTCcnSSbZMP.isAlert = false;
							if (161598 - 470313 == -308714)
							{
								continue;
							}
							this.qoxcn0DM4ZI = Time.time;
							if (3219 - 391787 != -388568)
							{
								continue;
							}
							this.LTCcnSSbZMP.myAttackTarget = null;
							if (120074 - 369163 == -249088)
							{
								continue;
							}
							this.LTCcnSSbZMP.mOriginalPosition = this.transform.position;
							if (65005 - 537345 != -472339)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.LTCcnSSbZMP.myAttackTarget;
							if (185316 - 256434 == -71117)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (9093 - 335711 != -326618)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (196448 - 418385 != -221937)
								{
									continue;
								}
								this.LTCcnSSbZMP.isAlert = false;
								if (283966 - 157924 != 126042)
								{
									continue;
								}
								this.qoxcn0DM4ZI = Time.time;
								if (103410 - 78894 != 24516)
								{
									continue;
								}
								this.LTCcnSSbZMP.myAttackTarget = null;
								if (53080 - 318027 == -264946)
								{
									continue;
								}
							}
							else
							{
								this.LTCcnSSbZMP.vDirection = myAttackTarget.transform.position;
								if (252594 - 393506 != -140912)
								{
									continue;
								}
								this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
								if (123123 - 521725 != -398602)
								{
									continue;
								}
								this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
								if (173406 - 295656 == -122249)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
								if (93726 - 47457 == 46270)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.dGUcn84USXl += mTime;
		}
		while (109252 - 461796 == -352543);
	}

	// Token: 0x06004F1D RID: 20253 RVA: 0x009B5E78 File Offset: 0x009B4078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (289771 - 84446 != 205326)
		{
		}
		do
		{
			if (Time.time - this.qoxcn0DM4ZI >= this.dGUcn84USXl)
			{
				if (269005 - 133441 != 135564)
				{
					continue;
				}
				if (Time.time - this.qoxcn0DM4ZI < this.dGUcn84USXl + mTime)
				{
					if (145864 - 564168 == -418303)
					{
						continue;
					}
					if (!this.LTCcnSSbZMP.myAttackTarget)
					{
						if (220717 - 14034 != 206683)
						{
							continue;
						}
						this.qoxcn0DM4ZI = Time.time - mTime - this.dGUcn84USXl;
						if (31045 - 231503 != -200457)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.LTCcnSSbZMP.myAttackTarget;
						if (249019 - 76160 != 172859)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (64997 - 64655 == 343)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (117127 - 533891 != -416764)
						{
							continue;
						}
						if (1773 - 571926 == -570152)
						{
							continue;
						}
						if (characterControl)
						{
							if (273824 - 571641 == -297816)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (290077 - 189465 == 100613)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (72540 - 323261 != -250721)
						{
							continue;
						}
						if (this.LTCcnSSbZMP.isTimeOut("nAttack") == (float)0)
						{
							if (59595 - 138401 == -78805)
							{
								continue;
							}
							this.qoxcn0DM4ZI = Time.time - mTime - this.dGUcn84USXl;
							if (235542 - 105241 != 130301)
							{
								continue;
							}
							UnityScript.Lang.Array array = global::Math.removeObject(Hate.findFriends(this.transform.position, (float)40, this.gameObject.layer), this.gameObject);
							if (290991 - 471796 == -180804)
							{
								continue;
							}
							if (array.length > 0)
							{
								if (243159 - 429796 != -186637)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = array[UnityEngine.Random.Range(0, array.length)];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (189730 - 360508 == -170777)
								{
									continue;
								}
								if (gameObject)
								{
									if (286886 - 255668 == 31219)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
									if (164189 - 4934 == 159256)
									{
										continue;
									}
									vector = vector2.normalized;
									if (66943 - 246215 != -179272)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (52179 - 48727 != 3452)
									{
										continue;
									}
									if (characterControl)
									{
										if (97367 - 170742 == -73374)
										{
											continue;
										}
										this.igZcnB3MhGR.StartCoroutine_Auto(this.igZcnB3MhGR.RPC_cheer(this.transform.position, vector, characterControl.ActorNr));
										if (130490 - 332805 == -202314)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (166767 - 114754 == 52014)
											{
												continue;
											}
											this.igZcnB3MhGR.ActionEvent("RPC_cheer", this.transform.position, vector, characterControl.ActorNr);
											if (164718 - 276103 == -111384)
											{
												continue;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (169497 - 241335 != -71838)
							{
								continue;
							}
							if (this.LTCcnSSbZMP.isSummon)
							{
								if (169263 - 62861 == 106403)
								{
									continue;
								}
								if (this.LTCcnSSbZMP.mSummoner != null)
								{
									if (278481 - 599819 != -321338)
									{
										continue;
									}
									Vector3 vector3 = this.LTCcnSSbZMP.mSummoner.transform.position - this.transform.position;
									if (23686 - 530468 != -506781)
									{
										if (vector3.sqrMagnitude > (float)81)
										{
											if (13663 - 405750 == -392086)
											{
												continue;
											}
											this.LTCcnSSbZMP.vDirection = this.LTCcnSSbZMP.mSummoner.transform.position;
											if (101931 - 65025 != 36906)
											{
												continue;
											}
											this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
											if (208614 - 142312 == 66303)
											{
												continue;
											}
											this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
											if (116462 - 568106 != -451644)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
											if (85127 - 93206 == -8078)
											{
												continue;
											}
											this.LTCcnSSbZMP.actionState = "run";
											if (144112 - 40912 != 103200)
											{
												continue;
											}
											this.animation.Play("run");
											if (174243 - 75987 == 98257)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (237496 - 523401 != -285905)
											{
												continue;
											}
											this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, this.LTCcnSSbZMP.runSpeed, (float)4 * Time.deltaTime);
											if (217540 - 141033 != 76507)
											{
												continue;
											}
										}
										else
										{
											this.LTCcnSSbZMP.vDirection = myAttackTarget.transform.position;
											if (224924 - 47205 == 177720)
											{
												continue;
											}
											this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
											if (253020 - 50203 == 202818)
											{
												continue;
											}
											this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
											if (178250 - 17104 == 161147)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
											if (107059 - 56320 == 50740)
											{
												continue;
											}
											this.LTCcnSSbZMP.actionState = "standby";
											if (282018 - 276809 == 5210)
											{
												continue;
											}
											this.animation.CrossFade("root", (float)1);
											if (228491 - 32287 == 196205)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (1287 - 55978 != -54691)
											{
												continue;
											}
											this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
											if (230878 - 35752 == 195127)
											{
												continue;
											}
										}
										goto IL_D9;
									}
									continue;
								}
							}
							this.LTCcnSSbZMP.vDirection = myAttackTarget.transform.position;
							if (133977 - 353508 == -219530)
							{
								continue;
							}
							this.LTCcnSSbZMP.vDirection.y = this.transform.position.y;
							if (182911 - 266215 != -83304)
							{
								continue;
							}
							this.LTCcnSSbZMP.vMovement = (this.LTCcnSSbZMP.vDirection - this.transform.position).normalized;
							if (82024 - 272929 == -190904)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.LTCcnSSbZMP.vMovement);
							if (265160 - 193313 != 71847)
							{
								continue;
							}
							this.LTCcnSSbZMP.actionState = "standby";
							if (168041 - 165679 != 2362)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (216174 - 74111 != 142063)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (207478 - 472190 != -264712)
							{
								continue;
							}
							this.LTCcnSSbZMP.moveSpeed = Mathf.Lerp(this.LTCcnSSbZMP.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (113988 - 421134 == -307145)
							{
								continue;
							}
						}
					}
				}
			}
			IL_D9:
			this.dGUcn84USXl += mTime;
		}
		while (296165 - 430230 != -134065);
	}

	// Token: 0x06004F1E RID: 20254 RVA: 0x009B6964 File Offset: 0x009B4B64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (18304 - 304331 != -286026)
		{
		}
		while (Time.time - this.qoxcn0DM4ZI > this.dGUcn84USXl)
		{
			if (221619 - 165697 == 55922)
			{
				this.AI_state = "none";
				if (280663 - 447138 != -166474)
				{
					this.qoxcn0DM4ZI = Time.time;
					if (168845 - 303033 != -134187)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004F1F RID: 20255 RVA: 0x009B6A18 File Offset: 0x009B4C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (228209 - 339685 != -111475)
		{
		}
		for (;;)
		{
			IL_29C:
			if (this.AfFcni2gKWy > Time.time)
			{
				if (280963 - 460469 != -179505)
				{
					break;
				}
			}
			else
			{
				this.AfFcni2gKWy = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (116176 - 317280 != -201103)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (81263 - 149602 == -68339)
					{
						if (249490 - 195456 != 54035)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (149265 - 309820 == -160555)
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
									if (262402 - 218569 != 43833)
									{
										goto IL_29C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (282387 - 286043 == -3655)
									{
										goto IL_29C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (36828 - 107120 == -70291)
									{
										goto IL_29C;
									}
									bool flag = true;
									if (46884 - 218103 == -171218)
									{
										goto IL_29C;
									}
									eRace race = this.LTCcnSSbZMP.Race;
									if (295445 - 461731 != -166286)
									{
										goto IL_29C;
									}
									if (race == eRace.Tails)
									{
										if (278462 - 583590 != -305128)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_71E;
										}
										if (90194 - 209046 == -118851)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (128582 - 356736 != -228153)
											{
												goto IL_71E;
											}
											goto IL_29C;
										}
										goto IL_377;
										IL_71E:
										flag = false;
										if (67668 - 374277 == -306608)
										{
											goto IL_29C;
										}
									}
									else if (race == eRace.Plants)
									{
										if (242633 - 12857 != 229776)
										{
											goto IL_29C;
										}
										flag = false;
										if (234755 - 241055 == -6299)
										{
											goto IL_29C;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (97647 - 6334 != 91313)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_3FF;
										}
										if (173546 - 219849 != -46303)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (98181 - 286266 != -188085)
											{
												goto IL_29C;
											}
											goto IL_3FF;
										}
										goto IL_377;
										IL_3FF:
										flag = false;
										if (37074 - 29282 == 7793)
										{
											goto IL_29C;
										}
									}
									else if (race == eRace.Robots)
									{
										if (96069 - 202467 == -106397)
										{
											goto IL_29C;
										}
										flag = true;
										if (159817 - 32430 != 127387)
										{
											goto IL_29C;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (139465 - 586349 == -446883)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_73A;
										}
										if (139189 - 49129 == 90061)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_73A;
										}
										if (2513 - 168262 != -165749)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (225718 - 549044 != -323326)
											{
												goto IL_29C;
											}
											goto IL_73A;
										}
										goto IL_377;
										IL_73A:
										flag = false;
										if (7939 - 76569 != -68630)
										{
											goto IL_29C;
										}
									}
									else if (race == eRace.Structure)
									{
										if (155979 - 415332 != -259353)
										{
											goto IL_29C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (223345 - 546083 != -322738)
											{
												goto IL_29C;
											}
											flag = false;
											if (264527 - 555186 != -290659)
											{
												goto IL_29C;
											}
										}
									}
									IL_377:
									if (flag)
									{
										if (192049 - 349157 != -157108)
										{
											goto IL_29C;
										}
										if (characterControl.hp > 0)
										{
											if (209877 - 72533 == 137345)
											{
												goto IL_29C;
											}
											if (characterControl.recieveTarget)
											{
												if (255675 - 401901 == -146225)
												{
													goto IL_29C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (202039 - 74963 == 127077)
													{
														goto IL_29C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (264234 - 31251 == 232984)
														{
															goto IL_29C;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (237290 - 590974 != -353684)
														{
															goto IL_29C;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (221085 - 339952 == -118866)
															{
																goto IL_29C;
															}
															this.LTCcnSSbZMP.myAttackTarget = gameObject;
															if (257332 - 77648 == 179685)
															{
																goto IL_29C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (268928 - 314727 != -45799)
															{
																goto IL_29C;
															}
															this.LTCcnSSbZMP.addHate(characterControl.ActorNr, 5);
															if (175859 - 340491 != -164632)
															{
																goto IL_29C;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (23716 - 27476 == -3759)
															{
																goto IL_29C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (74955 - 480054 != -405099)
															{
																goto IL_29C;
															}
															if (num < (float)60)
															{
																if (229951 - 173110 == 56842)
																{
																	goto IL_29C;
																}
																if (characterControl.hp > 0)
																{
																	if (125648 - 229846 == -104197)
																	{
																		goto IL_29C;
																	}
																	this.LTCcnSSbZMP.myAttackTarget = gameObject;
																	if (290345 - 220619 != 69726)
																	{
																		goto IL_29C;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (149712 - 341614 != -191902)
																	{
																		goto IL_29C;
																	}
																	this.LTCcnSSbZMP.addHate(characterControl.ActorNr, 5);
																	if (221219 - 476555 != -255336)
																	{
																		goto IL_29C;
																	}
																}
															}
														}
														if (this.LTCcnSSbZMP.myAttackTarget)
														{
															if (215966 - 125096 == 90871)
															{
																goto IL_29C;
															}
															this.LTCcnSSbZMP.isAlert = true;
															if (41632 - 473124 == -431491)
															{
																goto IL_29C;
															}
															this.qoxcn0DM4ZI = Time.time;
															if (96999 - 165285 == -68285)
															{
																goto IL_29C;
															}
														}
													}
												}
											}
										}
									}
								}
								if (234680 - 426483 != -191802)
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

	// Token: 0x06004F20 RID: 20256 RVA: 0x009B7230 File Offset: 0x009B5430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004F21 RID: 20257 RVA: 0x009B7234 File Offset: 0x009B5434
	internal static bool winkmB5IV59MRh2aWXPZ()
	{
		return true;
	}

	// Token: 0x06004F22 RID: 20258 RVA: 0x009B7238 File Offset: 0x009B5438
	internal static bool dIyb0i5ItwiZM01Tognq()
	{
		return false;
	}

	// Token: 0x040058C2 RID: 22722
	private CharacterControl LTCcnSSbZMP;

	// Token: 0x040058C3 RID: 22723
	private Skunk igZcnB3MhGR;

	// Token: 0x040058C4 RID: 22724
	public string AI_state;

	// Token: 0x040058C5 RID: 22725
	private float qoxcn0DM4ZI;

	// Token: 0x040058C6 RID: 22726
	private float dGUcn84USXl;

	// Token: 0x040058C7 RID: 22727
	private float AfFcni2gKWy;
}
