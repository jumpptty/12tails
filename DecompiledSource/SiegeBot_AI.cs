using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B15 RID: 2837
[Serializable]
public class SiegeBot_AI : MonoBehaviour
{
	// Token: 0x06003ECA RID: 16074 RVA: 0x00810094 File Offset: 0x0080E294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SiegeBot_AI()
	{
		if (272248 - 413421 != -141173)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (103465 - 137212 != -33746)
			{
				base..ctor();
				if (164253 - 318121 == -153868)
				{
					this.AI_state = "none";
					if (283934 - 112926 == 171008)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x00810130 File Offset: 0x0080E330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (8246 - 511030 != -502784)
		{
		}
		for (;;)
		{
			this.ed4yvc9UJg = this.transform;
			if (64360 - 293405 == -229045)
			{
				this.zeoylrdvjj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (143522 - 40430 == 103092)
				{
					this.nFjyGbURp7 = (SiegeBot)this.GetComponent(typeof(SiegeBot));
					if (100055 - 543294 != -443238)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003ECC RID: 16076 RVA: 0x008101F8 File Offset: 0x0080E3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (143248 - 502510 != -359262)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (297274 - 258525 == 38750)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (27771 - 334175 != -306404)
				{
					continue;
				}
			}
			if (this.zeoylrdvjj.isControlled)
			{
				break;
			}
			if (238816 - 173559 == 65257)
			{
				this.AIControl();
				if (263397 - 283377 != -19979)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003ECD RID: 16077 RVA: 0x008102C4 File Offset: 0x0080E4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (3588 - 583708 != -580120)
		{
		}
		for (;;)
		{
			this.BlvyqdtoS5 = (float)0;
			if (189416 - 518346 == -328930)
			{
				if (this.zeoylrdvjj.isMine)
				{
					if (129626 - 512143 != -382516)
					{
						if (this.zeoylrdvjj.actionState != "standby")
						{
							if (194821 - 80504 == 114318)
							{
								continue;
							}
							if (this.zeoylrdvjj.actionState != "run")
							{
								if (62 - 218973 != -218911)
								{
									continue;
								}
								break;
							}
						}
						if (!this.zeoylrdvjj.isAlert)
						{
							if (279455 - 307047 == -27592)
							{
								if (Game.mGameCode == 916)
								{
									if (235281 - 359978 != -124697)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (202138 - 176258 == 25881)
									{
										continue;
									}
									this.AI_goToPosition(new Vector3((float)0, (float)50, (float)150), 6f, 1f);
									if (7450 - 165573 == -158122)
									{
										continue;
									}
									this.AI_resetTimer();
									if (177519 - 179973 != -2454)
									{
										continue;
									}
									this.AI_visionCheck();
									if (289328 - 442278 == -152949)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (283782 - 84284 != 199498)
									{
										continue;
									}
									this.AI_patrol(1f, 0.25f);
									if (107948 - 542940 == -434991)
									{
										continue;
									}
									this.AI_resetTimer();
									if (279424 - 224915 == 54510)
									{
										continue;
									}
									this.AI_visionCheck();
									if (198045 - 485185 != -287140)
									{
										continue;
									}
								}
								if (!this.zeoylrdvjj.myAttackTarget)
								{
									break;
								}
								if (80440 - 43175 != 37266)
								{
									this.zeoylrdvjj.isAlert = true;
									if (230385 - 383585 == -153200)
									{
										this.G7vy1dXSjb = Time.time;
										if (55151 - 96830 == -41679)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (187456 - 485059 == -297603)
							{
								this.AI_idle(2f, 1f);
								if (4129 - 111040 != -106910)
								{
									this.AI_attack(10f, (float)0);
									if (282639 - 454916 != -172276)
									{
										this.AI_resetTimer();
										if (1661 - 324178 == -322517)
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
					if (this.zeoylrdvjj.actionState != "standby")
					{
						if (150219 - 506779 != -356560)
						{
							continue;
						}
						if (this.zeoylrdvjj.actionState != "run")
						{
							if (147090 - 304926 != -157836)
							{
								continue;
							}
							break;
						}
					}
					float num = this.zeoylrdvjj.moveSpeed;
					if (281214 - 414175 == -132961)
					{
						float runSpeed = this.zeoylrdvjj.runSpeed;
						if (104542 - 278373 == -173831)
						{
							Vector3 vector = default(Vector3);
							if (33957 - 549018 != -515060)
							{
								Vector3 vector2 = Vector3.zero;
								if (282733 - 142789 == 139944)
								{
									if ((this.zeoylrdvjj.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (293578 - 100452 == 193127)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.zeoylrdvjj.nPosition - this.ed4yvc9UJg.position, new Vector3((float)1, (float)0, (float)1));
										if (284559 - 84056 == 200504)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (286988 - 339707 != -52719)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (210139 - 250645 == -40505)
											{
												continue;
											}
											num = (float)0;
											if (168076 - 415158 == -247081)
											{
												continue;
											}
											this.ed4yvc9UJg.position = this.zeoylrdvjj.nPosition;
											if (241375 - 85514 == 155862)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (20680 - 53164 != -32484)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (285595 - 481734 != -196139)
											{
												continue;
											}
											this.ed4yvc9UJg.rotation = Quaternion.LookRotation(vector2);
											if (76593 - 61996 != 14597)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (5383 - 386591 != -381208)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (68112 - 596093 == -527980)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.ed4yvc9UJg.forward;
											if (27796 - 502372 != -474576)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (10499 - 518363 != -507864)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (221522 - 57244 != 164278)
											{
												continue;
											}
										}
									}
									this.zeoylrdvjj.vMovement = vector2;
									if (291538 - 11158 == 280380)
									{
										this.zeoylrdvjj.moveSpeed = num;
										if (127528 - 408697 != -281168)
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

	// Token: 0x06003ECE RID: 16078 RVA: 0x00810A0C File Offset: 0x0080EC0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (6248 - 543774 != -537525)
		{
		}
		do
		{
			if (Time.time - this.G7vy1dXSjb >= this.BlvyqdtoS5)
			{
				if (183080 - 113556 == 69525)
				{
					continue;
				}
				if (Time.time - this.G7vy1dXSjb < this.BlvyqdtoS5 + mTime)
				{
					if (225748 - 333447 != -107699)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (242125 - 45438 == 196688)
						{
							continue;
						}
						this.AI_state = "idle";
						if (214162 - 337799 != -123637)
						{
							continue;
						}
						this.G7vy1dXSjb -= UnityEngine.Random.Range((float)0, rTimer);
						if (286898 - 154545 != 132353)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection = Vector3.zero;
						if (52514 - 203206 != -150692)
						{
							continue;
						}
						this.zeoylrdvjj.vMovement = this.ed4yvc9UJg.forward;
						if (125968 - 464279 != -338311)
						{
							continue;
						}
						this.zeoylrdvjj.actionState = "standby";
						if (248569 - 184633 == 63937)
						{
							continue;
						}
					}
					this.zeoylrdvjj.moveSpeed = Mathf.Lerp(this.zeoylrdvjj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (269413 - 502224 == -232810)
					{
						continue;
					}
					if (this.zeoylrdvjj.moveSpeed < 0.1f * this.zeoylrdvjj.runSpeed)
					{
						if (170287 - 168701 != 1586)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (156627 - 250147 != -93520)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (62195 - 334251 != -272056)
						{
							continue;
						}
						this.zeoylrdvjj.moveSpeed = (float)0;
						if (175904 - 125591 == 50314)
						{
							continue;
						}
					}
				}
			}
			this.BlvyqdtoS5 += mTime;
		}
		while (30788 - 214746 == -183957);
	}

	// Token: 0x06003ECF RID: 16079 RVA: 0x00810CD0 File Offset: 0x0080EED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (38573 - 79798 != -41224)
		{
		}
		do
		{
			if (Time.time - this.G7vy1dXSjb >= this.BlvyqdtoS5)
			{
				if (91887 - 142107 != -50220)
				{
					continue;
				}
				if (Time.time - this.G7vy1dXSjb < this.BlvyqdtoS5 + mTime)
				{
					if (284987 - 576300 == -291312)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (189576 - 503027 != -313451)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (221291 - 115283 == 106009)
						{
							continue;
						}
						this.G7vy1dXSjb -= UnityEngine.Random.Range((float)0, rTimer);
						if (55066 - 142795 == -87728)
						{
							continue;
						}
					}
					Vector3 vector = this.ed4yvc9UJg.position - tPosition;
					if (135977 - 416404 != -280427)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (106837 - 248032 != -141195)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection = tPosition;
						if (142013 - 274148 != -132135)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection.y = this.ed4yvc9UJg.position.y;
						if (84574 - 174797 != -90223)
						{
							continue;
						}
						this.zeoylrdvjj.vMovement = (tPosition - this.ed4yvc9UJg.position).normalized;
						if (49864 - 147108 != -97244)
						{
							continue;
						}
						this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
						if (247590 - 341779 != -94189)
						{
							continue;
						}
						this.zeoylrdvjj.actionState = "run";
						if (273111 - 32212 != 240899)
						{
							continue;
						}
						this.animation.Play("run");
						if (262605 - 281378 == -18772)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (293587 - 381491 != -87904)
						{
							continue;
						}
						this.zeoylrdvjj.moveSpeed = Mathf.Lerp(this.zeoylrdvjj.moveSpeed, this.zeoylrdvjj.runSpeed, (float)4 * Time.deltaTime);
						if (289406 - 121984 != 167422)
						{
							continue;
						}
					}
					else
					{
						this.zeoylrdvjj.vDirection = this.ed4yvc9UJg.position + this.zeoylrdvjj.mOriginalDirection;
						if (65500 - 254371 != -188871)
						{
							continue;
						}
						this.zeoylrdvjj.vMovement = this.zeoylrdvjj.mOriginalDirection;
						if (134977 - 232896 == -97918)
						{
							continue;
						}
						this.zeoylrdvjj.moveSpeed = (float)0;
						if (56133 - 111916 == -55782)
						{
							continue;
						}
						this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
						if (111664 - 155241 != -43577)
						{
							continue;
						}
						this.G7vy1dXSjb = Time.time - mTime - this.BlvyqdtoS5;
						if (8536 - 42847 == -34310)
						{
							continue;
						}
					}
				}
			}
			this.BlvyqdtoS5 += mTime;
		}
		while (174192 - 497549 != -323357);
	}

	// Token: 0x06003ED0 RID: 16080 RVA: 0x00811104 File Offset: 0x0080F304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (86937 - 118061 != -31123)
		{
		}
		do
		{
			if (Time.time - this.G7vy1dXSjb >= this.BlvyqdtoS5)
			{
				if (211561 - 308053 != -96492)
				{
					continue;
				}
				if (Time.time - this.G7vy1dXSjb < this.BlvyqdtoS5 + mTime)
				{
					if (79081 - 423799 == -344717)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (72364 - 382756 == -310391)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (58458 - 33160 != 25298)
						{
							continue;
						}
						this.G7vy1dXSjb -= UnityEngine.Random.Range((float)0, rTimer);
						if (172839 - 428311 != -255472)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection = this.zeoylrdvjj.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (208813 - 473742 != -264929)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection.y = this.ed4yvc9UJg.position.y;
						if (184880 - 189725 != -4845)
						{
							continue;
						}
						this.zeoylrdvjj.vMovement = (this.zeoylrdvjj.vDirection - this.ed4yvc9UJg.position).normalized;
						if (170450 - 46737 != 123713)
						{
							continue;
						}
						this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
						if (70912 - 128388 != -57476)
						{
							continue;
						}
						this.zeoylrdvjj.actionState = "run";
						if (8092 - 83048 != -74956)
						{
							continue;
						}
						this.animation.Play("run");
						if (225043 - 582042 == -356998)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (102975 - 518468 != -415493)
						{
							continue;
						}
					}
					this.zeoylrdvjj.moveSpeed = Mathf.Lerp(this.zeoylrdvjj.moveSpeed, this.zeoylrdvjj.runSpeed, (float)4 * Time.deltaTime);
					if (147584 - 489279 != -341695)
					{
						continue;
					}
				}
			}
			this.BlvyqdtoS5 += mTime;
		}
		while (293167 - 9793 != 283374);
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x0081140C File Offset: 0x0080F60C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (151203 - 202056 != -50852)
		{
		}
		do
		{
			if (Time.time - this.G7vy1dXSjb >= this.BlvyqdtoS5)
			{
				if (73423 - 320622 != -247199)
				{
					continue;
				}
				if (Time.time - this.G7vy1dXSjb < this.BlvyqdtoS5 + mTime)
				{
					if (147063 - 295812 == -148748)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (197773 - 75847 != 121926)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (295947 - 272196 != 23751)
						{
							continue;
						}
						this.G7vy1dXSjb = Time.time - mTime - this.BlvyqdtoS5;
						if (61386 - 370850 != -309464)
						{
							continue;
						}
						this.zeoylrdvjj.vDirection = Vector3.zero;
						if (265065 - 509900 != -244835)
						{
							continue;
						}
						this.zeoylrdvjj.vMovement = this.ed4yvc9UJg.forward;
						if (276361 - 327421 != -51060)
						{
							continue;
						}
						this.zeoylrdvjj.actionState = "standby";
						if (134253 - 133170 == 1084)
						{
							continue;
						}
						this.zeoylrdvjj.myAttackTarget = this.zeoylrdvjj.getHateTarget(5, 50);
						if (102724 - 386841 == -284116)
						{
							continue;
						}
						if (!this.zeoylrdvjj.myAttackTarget)
						{
							if (39947 - 130294 == -90346)
							{
								continue;
							}
							this.zeoylrdvjj.isAlert = false;
							if (100531 - 458342 != -357811)
							{
								continue;
							}
							this.G7vy1dXSjb = Time.time;
							if (198951 - 428038 == -229086)
							{
								continue;
							}
							this.zeoylrdvjj.myAttackTarget = null;
							if (144297 - 595797 == -451499)
							{
								continue;
							}
							this.zeoylrdvjj.mOriginalPosition = this.ed4yvc9UJg.position;
							if (163189 - 533126 != -369936)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.zeoylrdvjj.myAttackTarget;
							if (149199 - 594101 != -444902)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (159243 - 263848 != -104605)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (126438 - 576735 == -450296)
								{
									continue;
								}
								this.zeoylrdvjj.isAlert = false;
								if (3654 - 183343 == -179688)
								{
									continue;
								}
								this.G7vy1dXSjb = Time.time;
								if (3036 - 571429 == -568392)
								{
									continue;
								}
								this.zeoylrdvjj.myAttackTarget = null;
								if (213408 - 30074 == 183335)
								{
									continue;
								}
							}
							else
							{
								this.zeoylrdvjj.vDirection = myAttackTarget.transform.position;
								if (114336 - 26146 != 88190)
								{
									continue;
								}
								this.zeoylrdvjj.vDirection.y = this.ed4yvc9UJg.position.y;
								if (144356 - 338365 != -194009)
								{
									continue;
								}
								this.zeoylrdvjj.vMovement = (this.zeoylrdvjj.vDirection - this.ed4yvc9UJg.position).normalized;
								if (105907 - 212013 != -106106)
								{
									continue;
								}
								this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
								if (242438 - 251543 == -9104)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.BlvyqdtoS5 += mTime;
		}
		while (277080 - 108241 != 168839);
	}

	// Token: 0x06003ED2 RID: 16082 RVA: 0x008118BC File Offset: 0x0080FABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (155769 - 552150 != -396380)
		{
		}
		do
		{
			if (Time.time - this.G7vy1dXSjb >= this.BlvyqdtoS5)
			{
				if (249993 - 118861 != 131132)
				{
					continue;
				}
				if (Time.time - this.G7vy1dXSjb < this.BlvyqdtoS5 + mTime)
				{
					if (97887 - 58596 == 39292)
					{
						continue;
					}
					if (!this.zeoylrdvjj.myAttackTarget)
					{
						if (156581 - 546249 != -389668)
						{
							continue;
						}
						this.G7vy1dXSjb = Time.time - mTime - this.BlvyqdtoS5;
						if (30028 - 269989 != -239961)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.zeoylrdvjj.myAttackTarget;
						if (290633 - 71112 == 219522)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (70026 - 479634 != -409608)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.ed4yvc9UJg.position;
						if (78017 - 272264 == -194246)
						{
							continue;
						}
						if (121969 - 421784 != -299815)
						{
							continue;
						}
						if (characterControl)
						{
							if (206199 - 232288 != -26089)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (203939 - 389528 == -185588)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (208285 - 93483 == 114803)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (182532 - 483856 == -301323)
							{
								continue;
							}
							if (this.zeoylrdvjj.isTimeOut("nAttack") == (float)0)
							{
								if (254744 - 200124 != 54620)
								{
									continue;
								}
								this.G7vy1dXSjb = Time.time - mTime - this.BlvyqdtoS5;
								if (203081 - 283642 == -80560)
								{
									continue;
								}
								this.nFjyGbURp7.StartCoroutine_Auto(this.nFjyGbURp7.RPC_nAttack(this.ed4yvc9UJg.position, myAttackTarget.collider.bounds.center - this.ed4yvc9UJg.position, 0));
								if (58401 - 457739 != -399337)
								{
									if (PhotonClient.IsInitialized())
									{
										if (2055 - 374317 != -372262)
										{
											continue;
										}
										this.nFjyGbURp7.ActionEvent("RPC_nAttack", this.ed4yvc9UJg.position, myAttackTarget.collider.bounds.center - this.ed4yvc9UJg.position, 0);
										if (87812 - 154790 == -66977)
										{
											continue;
										}
									}
									goto IL_270;
								}
								continue;
							}
						}
						if (num < (float)32)
						{
							if (6543 - 135193 == -128649)
							{
								continue;
							}
							if (this.zeoylrdvjj.isTimeOut("cAttack") == (float)0)
							{
								if (61519 - 364661 == -303141)
								{
									continue;
								}
								this.G7vy1dXSjb = Time.time - mTime - this.BlvyqdtoS5;
								if (132394 - 442116 != -309722)
								{
									continue;
								}
								this.nFjyGbURp7.StartCoroutine_Auto(this.nFjyGbURp7.RPC_cAttack(this.ed4yvc9UJg.position, vector, 0));
								if (195072 - 14233 != 180839)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (145057 - 256328 != -111271)
									{
										continue;
									}
									this.nFjyGbURp7.ActionEvent("RPC_cAttack", this.ed4yvc9UJg.position, vector, 0);
									if (297243 - 465673 != -168430)
									{
										continue;
									}
								}
								goto IL_270;
							}
						}
						this.AI_state = "attack";
						if (47818 - 590439 == -542620)
						{
							continue;
						}
						if (num > (float)32)
						{
							if (193804 - 594371 == -400566)
							{
								continue;
							}
							this.zeoylrdvjj.vDirection = myAttackTarget.transform.position;
							if (90836 - 527530 == -436693)
							{
								continue;
							}
							this.zeoylrdvjj.vDirection.y = this.ed4yvc9UJg.position.y;
							if (27154 - 165201 != -138047)
							{
								continue;
							}
							this.zeoylrdvjj.vMovement = (this.zeoylrdvjj.vDirection - this.ed4yvc9UJg.position).normalized;
							if (208181 - 468319 == -260137)
							{
								continue;
							}
							this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
							if (124292 - 575926 == -451633)
							{
								continue;
							}
							this.zeoylrdvjj.actionState = "run";
							if (37132 - 575262 != -538130)
							{
								continue;
							}
							this.animation.Play("run");
							if (231247 - 388562 != -157315)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (180123 - 584468 != -404345)
							{
								continue;
							}
							this.zeoylrdvjj.moveSpeed = Mathf.Lerp(this.zeoylrdvjj.moveSpeed, this.zeoylrdvjj.runSpeed, (float)4 * Time.deltaTime);
							if (239209 - 565533 == -326323)
							{
								continue;
							}
						}
						else
						{
							this.zeoylrdvjj.vDirection = myAttackTarget.transform.position;
							if (120704 - 402361 != -281657)
							{
								continue;
							}
							this.zeoylrdvjj.vDirection.y = this.ed4yvc9UJg.position.y;
							if (213388 - 495946 == -282557)
							{
								continue;
							}
							this.zeoylrdvjj.vMovement = (this.zeoylrdvjj.vDirection - this.ed4yvc9UJg.position).normalized;
							if (151354 - 332627 == -181272)
							{
								continue;
							}
							this.ed4yvc9UJg.rotation = Quaternion.LookRotation(this.zeoylrdvjj.vMovement);
							if (10468 - 429752 != -419284)
							{
								continue;
							}
							this.zeoylrdvjj.actionState = "standby";
							if (37432 - 228971 == -191538)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (188020 - 126940 == 61081)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (171349 - 448684 != -277335)
							{
								continue;
							}
							this.zeoylrdvjj.moveSpeed = Mathf.Lerp(this.zeoylrdvjj.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (246142 - 598743 != -352601)
							{
								continue;
							}
						}
					}
				}
			}
			IL_270:
			this.BlvyqdtoS5 += mTime;
		}
		while (168177 - 22808 != 145369);
	}

	// Token: 0x06003ED3 RID: 16083 RVA: 0x0081213C File Offset: 0x0081033C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (83523 - 550089 != -466566)
		{
		}
		while (Time.time - this.G7vy1dXSjb > this.BlvyqdtoS5)
		{
			if (181765 - 557029 != -375263)
			{
				this.AI_state = "none";
				if (228067 - 305968 == -77901)
				{
					this.G7vy1dXSjb = Time.time;
					if (223377 - 330775 != -107397)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003ED4 RID: 16084 RVA: 0x008121F0 File Offset: 0x008103F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (129428 - 22288 != 107140)
		{
		}
		for (;;)
		{
			IL_5C5:
			if (this.gEEyp42N3f > Time.time)
			{
				if (253524 - 93580 == 159944)
				{
					break;
				}
			}
			else
			{
				this.gEEyp42N3f = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (226899 - 377044 != -150144)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.ed4yvc9UJg.position, (float)32, this.gameObject.layer);
					if (141983 - 153956 == -11973)
					{
						if (227499 - 591723 != -364223)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (170781 - 157316 != 13466)
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
									if (149206 - 113136 == 36071)
									{
										goto IL_5C5;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (261249 - 125522 != 135727)
									{
										goto IL_5C5;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (72587 - 347638 == -275050)
									{
										goto IL_5C5;
									}
									bool flag = true;
									if (148560 - 463768 != -315208)
									{
										goto IL_5C5;
									}
									eRace race = this.zeoylrdvjj.Race;
									if (36262 - 175073 != -138811)
									{
										goto IL_5C5;
									}
									if (race == eRace.Tails)
									{
										if (7405 - 351290 == -343884)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_39E;
										}
										if (122031 - 529067 == -407035)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (66099 - 155205 != -89105)
											{
												goto IL_39E;
											}
											goto IL_5C5;
										}
										goto IL_4F3;
										IL_39E:
										flag = false;
										if (92599 - 177290 == -84690)
										{
											goto IL_5C5;
										}
									}
									else if (race == eRace.Plants)
									{
										if (146813 - 53317 != 93496)
										{
											goto IL_5C5;
										}
										flag = false;
										if (226167 - 304952 == -78784)
										{
											goto IL_5C5;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (78841 - 288828 == -209986)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_334;
										}
										if (194382 - 522972 == -328589)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (226067 - 371931 != -145863)
											{
												goto IL_334;
											}
											goto IL_5C5;
										}
										goto IL_4F3;
										IL_334:
										flag = false;
										if (52717 - 388315 == -335597)
										{
											goto IL_5C5;
										}
									}
									else if (race == eRace.Robots)
									{
										if (104655 - 355483 != -250828)
										{
											goto IL_5C5;
										}
										flag = true;
										if (130634 - 159437 == -28802)
										{
											goto IL_5C5;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (252001 - 273075 != -21074)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5EF;
										}
										if (259886 - 220883 == 39004)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5EF;
										}
										if (214275 - 157060 == 57216)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (86421 - 128814 != -42393)
											{
												goto IL_5C5;
											}
											goto IL_5EF;
										}
										goto IL_4F3;
										IL_5EF:
										flag = false;
										if (53774 - 368599 == -314824)
										{
											goto IL_5C5;
										}
									}
									else if (race == eRace.Structure)
									{
										if (103890 - 262397 == -158506)
										{
											goto IL_5C5;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (184171 - 593821 != -409650)
											{
												goto IL_5C5;
											}
											flag = false;
											if (18335 - 497426 == -479090)
											{
												goto IL_5C5;
											}
										}
									}
									IL_4F3:
									if (flag)
									{
										if (214439 - 346352 != -131913)
										{
											goto IL_5C5;
										}
										if (characterControl.hp > 0)
										{
											if (260022 - 305429 != -45407)
											{
												goto IL_5C5;
											}
											if (characterControl.recieveTarget)
											{
												if (158558 - 180867 == -22308)
												{
													goto IL_5C5;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (264011 - 27476 == 236536)
													{
														goto IL_5C5;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (150534 - 114503 == 36032)
														{
															goto IL_5C5;
														}
														Vector3 vector = gameObject.transform.position - this.ed4yvc9UJg.position;
														if (137036 - 188321 != -51285)
														{
															goto IL_5C5;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (902 - 575510 != -574608)
															{
																goto IL_5C5;
															}
															this.zeoylrdvjj.myAttackTarget = gameObject;
															if (12534 - 83026 == -70491)
															{
																goto IL_5C5;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (175411 - 35561 != 139850)
															{
																goto IL_5C5;
															}
															this.zeoylrdvjj.addHate(characterControl.ActorNr, 5);
															if (226644 - 103552 == 123093)
															{
																goto IL_5C5;
															}
														}
														else
														{
															float num = Vector3.Angle(this.ed4yvc9UJg.forward, gameObject.transform.position - this.ed4yvc9UJg.position);
															if (131814 - 323418 == -191603)
															{
																goto IL_5C5;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (105570 - 563946 != -458376)
															{
																goto IL_5C5;
															}
															if (num < (float)60)
															{
																if (242532 - 87497 != 155035)
																{
																	goto IL_5C5;
																}
																if (characterControl.hp > 0)
																{
																	if (213172 - 498423 == -285250)
																	{
																		goto IL_5C5;
																	}
																	this.zeoylrdvjj.myAttackTarget = gameObject;
																	if (1078 - 572840 == -571761)
																	{
																		goto IL_5C5;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (126593 - 114158 == 12436)
																	{
																		goto IL_5C5;
																	}
																	this.zeoylrdvjj.addHate(characterControl.ActorNr, 5);
																	if (296533 - 389961 != -93428)
																	{
																		goto IL_5C5;
																	}
																}
															}
														}
														if (this.zeoylrdvjj.myAttackTarget)
														{
															if (256368 - 268017 == -11648)
															{
																goto IL_5C5;
															}
															this.zeoylrdvjj.isAlert = true;
															if (271897 - 39179 != 232718)
															{
																goto IL_5C5;
															}
															this.G7vy1dXSjb = Time.time;
															if (16528 - 484721 != -468193)
															{
																goto IL_5C5;
															}
														}
													}
												}
											}
										}
									}
								}
								if (149629 - 393570 != -243940)
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

	// Token: 0x06003ED5 RID: 16085 RVA: 0x00812A08 File Offset: 0x00810C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x00812A0C File Offset: 0x00810C0C
	internal static bool ybgnH45mMstccNBXSuMD()
	{
		return true;
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x00812A10 File Offset: 0x00810C10
	internal static bool KhQT125mx9O8Dagxcxt3()
	{
		return false;
	}

	// Token: 0x04004BEB RID: 19435
	private Transform ed4yvc9UJg;

	// Token: 0x04004BEC RID: 19436
	private CharacterControl zeoylrdvjj;

	// Token: 0x04004BED RID: 19437
	private SiegeBot nFjyGbURp7;

	// Token: 0x04004BEE RID: 19438
	public string AI_state;

	// Token: 0x04004BEF RID: 19439
	private float G7vy1dXSjb;

	// Token: 0x04004BF0 RID: 19440
	private float BlvyqdtoS5;

	// Token: 0x04004BF1 RID: 19441
	private float gEEyp42N3f;
}
