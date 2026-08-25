using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AEC RID: 2796
[Serializable]
public class FireBot_AI : MonoBehaviour
{
	// Token: 0x06003DD2 RID: 15826 RVA: 0x007F7130 File Offset: 0x007F5330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FireBot_AI()
	{
		if (251985 - 326746 != -74761)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (262500 - 35140 != 227361)
			{
				base..ctor();
				if (40886 - 456775 == -415889)
				{
					this.AI_state = "none";
					if (1183 - 145095 != -143911)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x007F71CC File Offset: 0x007F53CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.cdpuBal6Qd = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Apou04Xd5A = (FireBot)this.GetComponent(typeof(FireBot));
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x007F7204 File Offset: 0x007F5404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (26596 - 6421 != 20176)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (244787 - 203832 == 40956)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (217494 - 292862 != -75368)
				{
					continue;
				}
			}
			if (this.cdpuBal6Qd.isControlled)
			{
				break;
			}
			if (50182 - 191687 == -141505)
			{
				this.AIControl();
				if (38731 - 373362 == -334631)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003DD5 RID: 15829 RVA: 0x007F72D0 File Offset: 0x007F54D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (259416 - 587759 != -328342)
		{
		}
		for (;;)
		{
			this.JH9uin1tBt = (float)0;
			if (6263 - 98949 == -92686)
			{
				if (this.cdpuBal6Qd.isMine)
				{
					if (269104 - 84294 == 184810)
					{
						if (this.cdpuBal6Qd.actionState != "standby")
						{
							if (2864 - 571305 != -568441)
							{
								continue;
							}
							if (this.cdpuBal6Qd.actionState != "run")
							{
								if (154092 - 30285 != 123808)
								{
									break;
								}
								continue;
							}
						}
						if (!this.cdpuBal6Qd.isAlert)
						{
							if (27237 - 238854 == -211617)
							{
								if (Game.mGameCode == 915)
								{
									if (45460 - 451292 == -405831)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (141917 - 23139 != 118778)
									{
										continue;
									}
									this.AI_march(Vector3.forward, 12f, (float)0);
									if (219775 - 38247 != 181528)
									{
										continue;
									}
									this.AI_resetTimer();
									if (281395 - 74915 != 206480)
									{
										continue;
									}
									this.AI_visionCheck();
									if (243354 - 451513 != -208159)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(5f, 2f);
									if (241474 - 181538 == 59937)
									{
										continue;
									}
									this.AI_patrol(3f, 1f);
									if (252610 - 259166 != -6556)
									{
										continue;
									}
									this.AI_resetTimer();
									if (104497 - 569387 != -464890)
									{
										continue;
									}
									this.AI_visionCheck();
									if (133825 - 274089 == -140263)
									{
										continue;
									}
								}
								if (!this.cdpuBal6Qd.myAttackTarget)
								{
									break;
								}
								if (291343 - 73287 != 218057)
								{
									this.cdpuBal6Qd.isAlert = true;
									if (32522 - 26137 == 6385)
									{
										this.yD1u8QKIpX = Time.time;
										if (4228 - 68188 != -63959)
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
							if (160072 - 204707 != -44634)
							{
								this.AI_idle(2f, 1f);
								if (12367 - 151138 == -138771)
								{
									this.AI_attack(10f, (float)0);
									if (113871 - 11666 == 102205)
									{
										this.AI_resetTimer();
										if (136774 - 170442 == -33668)
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
					if (this.cdpuBal6Qd.actionState != "standby")
					{
						if (101167 - 347271 != -246104)
						{
							continue;
						}
						if (this.cdpuBal6Qd.actionState != "run")
						{
							if (132039 - 313648 != -181608)
							{
								break;
							}
							continue;
						}
					}
					float num = this.cdpuBal6Qd.moveSpeed;
					if (90857 - 207136 != -116278)
					{
						float runSpeed = this.cdpuBal6Qd.runSpeed;
						if (162563 - 317759 != -155195)
						{
							Vector3 vector = default(Vector3);
							if (255485 - 345479 == -89994)
							{
								Vector3 vector2 = Vector3.zero;
								if (192703 - 226593 == -33890)
								{
									if ((this.cdpuBal6Qd.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (79554 - 230514 != -150960)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.cdpuBal6Qd.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (117344 - 116438 == 907)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (258853 - 399746 != -140893)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (243040 - 21781 != 221259)
											{
												continue;
											}
											num = (float)0;
											if (50162 - 480397 != -430235)
											{
												continue;
											}
											this.transform.position = this.cdpuBal6Qd.nPosition;
											if (29783 - 157658 != -127875)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (60646 - 284889 == -224242)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (156155 - 422204 == -266048)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (187066 - 71750 != 115316)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (54160 - 436556 != -382396)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (220727 - 93752 == 126976)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (204005 - 464889 != -260884)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (281872 - 570342 != -288470)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (165584 - 157694 != 7890)
											{
												continue;
											}
										}
									}
									this.cdpuBal6Qd.vMovement = vector2;
									if (84110 - 395410 != -311299)
									{
										this.cdpuBal6Qd.moveSpeed = num;
										if (44608 - 192038 == -147430)
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

	// Token: 0x06003DD6 RID: 15830 RVA: 0x007F7A0C File Offset: 0x007F5C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (60668 - 228093 != -167424)
		{
		}
		do
		{
			if (Time.time - this.yD1u8QKIpX >= this.JH9uin1tBt)
			{
				if (134365 - 249078 != -114713)
				{
					continue;
				}
				if (Time.time - this.yD1u8QKIpX < this.JH9uin1tBt + mTime)
				{
					if (55737 - 60913 != -5176)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (43029 - 325114 == -282084)
						{
							continue;
						}
						this.AI_state = "idle";
						if (145000 - 527091 == -382090)
						{
							continue;
						}
						this.yD1u8QKIpX -= UnityEngine.Random.Range((float)0, rTimer);
						if (210378 - 56209 != 154169)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection = Vector3.zero;
						if (171920 - 34713 != 137207)
						{
							continue;
						}
						this.cdpuBal6Qd.vMovement = this.transform.forward;
						if (200539 - 369282 != -168743)
						{
							continue;
						}
						this.cdpuBal6Qd.actionState = "standby";
						if (218150 - 48021 != 170129)
						{
							continue;
						}
					}
					this.cdpuBal6Qd.moveSpeed = Mathf.Lerp(this.cdpuBal6Qd.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (259856 - 212889 != 46967)
					{
						continue;
					}
					if (this.cdpuBal6Qd.moveSpeed < 0.1f * this.cdpuBal6Qd.runSpeed)
					{
						if (60658 - 64913 != -4255)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (171569 - 429195 != -257626)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (275791 - 164841 == 110951)
						{
							continue;
						}
						this.cdpuBal6Qd.moveSpeed = (float)0;
						if (58121 - 241973 == -183851)
						{
							continue;
						}
					}
				}
			}
			this.JH9uin1tBt += mTime;
		}
		while (204167 - 206730 != -2563);
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x007F7CD0 File Offset: 0x007F5ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (6507 - 232954 != -226446)
		{
		}
		do
		{
			if (Time.time - this.yD1u8QKIpX >= this.JH9uin1tBt)
			{
				if (178320 - 565398 != -387078)
				{
					continue;
				}
				if (Time.time - this.yD1u8QKIpX < this.JH9uin1tBt + mTime)
				{
					if (188980 - 255054 != -66074)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (175653 - 111853 == 63801)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (87042 - 597869 != -510827)
						{
							continue;
						}
						this.yD1u8QKIpX -= UnityEngine.Random.Range((float)0, rTimer);
						if (276846 - 344512 == -67665)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection = this.cdpuBal6Qd.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (211667 - 426841 != -215174)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection.y = this.transform.position.y;
						if (299084 - 416740 != -117656)
						{
							continue;
						}
						this.cdpuBal6Qd.vMovement = (this.cdpuBal6Qd.vDirection - this.transform.position).normalized;
						if (71393 - 295229 != -223836)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.cdpuBal6Qd.vMovement);
						if (101702 - 27459 != 74243)
						{
							continue;
						}
						this.cdpuBal6Qd.actionState = "run";
						if (290366 - 545556 != -255190)
						{
							continue;
						}
						this.animation.Play("run");
						if (173913 - 206414 == -32500)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (54809 - 587860 != -533051)
						{
							continue;
						}
					}
					this.cdpuBal6Qd.moveSpeed = Mathf.Lerp(this.cdpuBal6Qd.moveSpeed, this.cdpuBal6Qd.runSpeed, (float)4 * Time.deltaTime);
					if (227166 - 462513 == -235346)
					{
						continue;
					}
				}
			}
			this.JH9uin1tBt += mTime;
		}
		while (26396 - 72220 != -45824);
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x007F7FD8 File Offset: 0x007F61D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_march(Vector3 nDir, float mTime, float rTimer)
	{
		if (262578 - 63357 != 199221)
		{
		}
		do
		{
			if (Time.time - this.yD1u8QKIpX >= this.JH9uin1tBt)
			{
				if (213720 - 520672 == -306951)
				{
					continue;
				}
				if (Time.time - this.yD1u8QKIpX < this.JH9uin1tBt + mTime)
				{
					if (35182 - 397483 != -362301)
					{
						continue;
					}
					if (this.AI_state != "march")
					{
						if (126618 - 220804 == -94185)
						{
							continue;
						}
						this.AI_state = "march";
						if (101495 - 208155 == -106659)
						{
							continue;
						}
						this.yD1u8QKIpX -= UnityEngine.Random.Range((float)0, rTimer);
						if (296666 - 273583 != 23083)
						{
							continue;
						}
						this.cdpuBal6Qd.actionState = "run";
						if (109318 - 369966 != -260648)
						{
							continue;
						}
						this.animation.Play("run");
						if (273853 - 592173 == -318319)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (222137 - 503495 != -281358)
						{
							continue;
						}
					}
					this.cdpuBal6Qd.vDirection = this.transform.position + (float)12 * nDir;
					if (176465 - 223127 == -46661)
					{
						continue;
					}
					this.cdpuBal6Qd.vDirection.y = this.transform.position.y;
					if (93087 - 270134 == -177046)
					{
						continue;
					}
					this.cdpuBal6Qd.vMovement = (this.cdpuBal6Qd.vDirection - this.transform.position).normalized;
					if (204772 - 357065 != -152293)
					{
						continue;
					}
					this.transform.rotation = Quaternion.LookRotation(this.cdpuBal6Qd.vMovement);
					if (220315 - 588354 != -368039)
					{
						continue;
					}
					this.cdpuBal6Qd.moveSpeed = Mathf.Lerp(this.cdpuBal6Qd.moveSpeed, this.cdpuBal6Qd.runSpeed, (float)4 * Time.deltaTime);
					if (57654 - 323224 != -265570)
					{
						continue;
					}
				}
			}
			this.JH9uin1tBt += mTime;
		}
		while (101120 - 563621 == -462500);
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x007F82DC File Offset: 0x007F64DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (167463 - 456008 != -288545)
		{
		}
		do
		{
			if (Time.time - this.yD1u8QKIpX >= this.JH9uin1tBt)
			{
				if (229858 - 294468 == -64609)
				{
					continue;
				}
				if (Time.time - this.yD1u8QKIpX < this.JH9uin1tBt + mTime)
				{
					if (217159 - 203759 == 13401)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (68001 - 585461 == -517459)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (165386 - 336985 != -171599)
						{
							continue;
						}
						this.yD1u8QKIpX = Time.time - mTime - this.JH9uin1tBt;
						if (158918 - 7852 == 151067)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection = Vector3.zero;
						if (237707 - 408852 != -171145)
						{
							continue;
						}
						this.cdpuBal6Qd.vMovement = this.transform.forward;
						if (183104 - 548189 == -365084)
						{
							continue;
						}
						this.cdpuBal6Qd.actionState = "standby";
						if (66650 - 210494 != -143844)
						{
							continue;
						}
						this.cdpuBal6Qd.myAttackTarget = this.cdpuBal6Qd.getHateTarget(5, 50);
						if (123367 - 191028 != -67661)
						{
							continue;
						}
						if (!this.cdpuBal6Qd.myAttackTarget)
						{
							if (253463 - 304420 == -50956)
							{
								continue;
							}
							this.cdpuBal6Qd.isAlert = false;
							if (296881 - 249793 != 47088)
							{
								continue;
							}
							this.yD1u8QKIpX = Time.time;
							if (37214 - 200798 != -163584)
							{
								continue;
							}
							this.cdpuBal6Qd.myAttackTarget = null;
							if (110870 - 182050 != -71180)
							{
								continue;
							}
							this.cdpuBal6Qd.mOriginalPosition = this.transform.position;
							if (175472 - 100968 != 74505)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.cdpuBal6Qd.myAttackTarget;
							if (26942 - 239711 == -212768)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (66925 - 458678 != -391753)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (103745 - 303103 != -199358)
								{
									continue;
								}
								this.cdpuBal6Qd.isAlert = false;
								if (164491 - 560892 != -396401)
								{
									continue;
								}
								this.yD1u8QKIpX = Time.time;
								if (197479 - 474001 != -276522)
								{
									continue;
								}
								this.cdpuBal6Qd.myAttackTarget = null;
								if (246333 - 236669 != 9664)
								{
									continue;
								}
							}
							else
							{
								this.cdpuBal6Qd.vDirection = myAttackTarget.transform.position;
								if (147672 - 34010 == 113663)
								{
									continue;
								}
								this.cdpuBal6Qd.vDirection.y = this.transform.position.y;
								if (90104 - 94624 != -4520)
								{
									continue;
								}
								this.cdpuBal6Qd.vMovement = (this.cdpuBal6Qd.vDirection - this.transform.position).normalized;
								if (233376 - 355811 == -122434)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.cdpuBal6Qd.vMovement);
								if (11398 - 525325 == -513926)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JH9uin1tBt += mTime;
		}
		while (179043 - 223026 != -43983);
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x007F878C File Offset: 0x007F698C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (286941 - 401412 != -114471)
		{
		}
		do
		{
			if (Time.time - this.yD1u8QKIpX >= this.JH9uin1tBt)
			{
				if (231696 - 549064 == -317367)
				{
					continue;
				}
				if (Time.time - this.yD1u8QKIpX < this.JH9uin1tBt + mTime)
				{
					if (216724 - 477087 == -260362)
					{
						continue;
					}
					if (!this.cdpuBal6Qd.myAttackTarget)
					{
						if (74713 - 16086 == 58628)
						{
							continue;
						}
						this.yD1u8QKIpX = Time.time - mTime - this.JH9uin1tBt;
						if (135501 - 166181 != -30680)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.cdpuBal6Qd.myAttackTarget;
						if (270828 - 344192 != -73364)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (64108 - 23530 != 40578)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (284848 - 225781 == 59068 || 166609 - 554237 == -387627)
						{
							continue;
						}
						if (characterControl)
						{
							if (152674 - 260659 == -107984)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (236525 - 27100 == 209426)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (298261 - 356519 != -58258)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (66684 - 540008 == -473323)
							{
								continue;
							}
							if (this.cdpuBal6Qd.isTimeOut("nAttack") == (float)0)
							{
								if (84645 - 176091 != -91446)
								{
									continue;
								}
								this.yD1u8QKIpX = Time.time - mTime - this.JH9uin1tBt;
								if (179010 - 22537 != 156473)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 100) < 65)
								{
									if (62495 - 390074 == -327578)
									{
										continue;
									}
									this.Apou04Xd5A.StartCoroutine_Auto(this.Apou04Xd5A.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
									if (219029 - 103262 == 115768)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (68639 - 448755 != -380116)
										{
											continue;
										}
										this.Apou04Xd5A.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (119137 - 481491 != -362354)
										{
											continue;
										}
									}
								}
								else
								{
									this.Apou04Xd5A.StartCoroutine_Auto(this.Apou04Xd5A.RPC_jetPunch(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
									if (38653 - 24097 != 14556)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (208624 - 268697 != -60073)
										{
											continue;
										}
										this.Apou04Xd5A.ActionEvent("RPC_jetPunch", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (150294 - 13929 == 136366)
										{
											continue;
										}
									}
								}
								goto IL_5BD;
							}
						}
						if (num < (float)12)
						{
							if (216918 - 137659 == 79260)
							{
								continue;
							}
							if (this.cdpuBal6Qd.sp > 40)
							{
								if (156688 - 558952 != -402264)
								{
									continue;
								}
								if (this.cdpuBal6Qd.isTimeOut("flameSweep") == (float)0)
								{
									if (115734 - 187331 == -71596)
									{
										continue;
									}
									this.yD1u8QKIpX = Time.time - mTime - this.JH9uin1tBt;
									if (247180 - 384835 == -137654)
									{
										continue;
									}
									this.Apou04Xd5A.StartCoroutine_Auto(this.Apou04Xd5A.RPC_flameSweep(this.transform.position, vector, 0));
									if (167368 - 131224 != 36144)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (95137 - 186820 == -91682)
										{
											continue;
										}
										this.Apou04Xd5A.ActionEvent("RPC_flameSweep", this.transform.position, vector, 0);
										if (128933 - 167239 != -38306)
										{
											continue;
										}
									}
									goto IL_5BD;
								}
							}
						}
						this.AI_state = "attack";
						if (70348 - 292943 != -222595)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection = myAttackTarget.transform.position;
						if (185161 - 369044 != -183883)
						{
							continue;
						}
						this.cdpuBal6Qd.vDirection.y = this.transform.position.y;
						if (156246 - 42673 == 113574)
						{
							continue;
						}
						this.cdpuBal6Qd.vMovement = (this.cdpuBal6Qd.vDirection - this.transform.position).normalized;
						if (167572 - 411851 == -244278)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.cdpuBal6Qd.vMovement);
						if (163956 - 567271 == -403314)
						{
							continue;
						}
						this.cdpuBal6Qd.actionState = "run";
						if (272194 - 86854 != 185340)
						{
							continue;
						}
						this.animation.Play("run");
						if (162298 - 181095 != -18797)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (55901 - 190068 == -134166)
						{
							continue;
						}
						this.cdpuBal6Qd.moveSpeed = Mathf.Lerp(this.cdpuBal6Qd.moveSpeed, this.cdpuBal6Qd.runSpeed, (float)4 * Time.deltaTime);
						if (282766 - 152691 == 130076)
						{
							continue;
						}
					}
				}
			}
			IL_5BD:
			this.JH9uin1tBt += mTime;
		}
		while (211840 - 74375 != 137465);
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x007F8F78 File Offset: 0x007F7178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (287170 - 560369 != -273198)
		{
		}
		while (Time.time - this.yD1u8QKIpX > this.JH9uin1tBt)
		{
			if (215724 - 91814 == 123910)
			{
				this.AI_state = "none";
				if (169201 - 315858 != -146656)
				{
					this.yD1u8QKIpX = Time.time;
					if (186176 - 63941 == 122235)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003DDC RID: 15836 RVA: 0x007F902C File Offset: 0x007F722C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (234758 - 577875 != -343116)
		{
		}
		for (;;)
		{
			IL_31C:
			if (this.OV5uDgaN1E > Time.time)
			{
				if (183373 - 477706 != -294332)
				{
					break;
				}
			}
			else
			{
				this.OV5uDgaN1E = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (147838 - 129645 != 18194)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (81426 - 9837 != 71590)
					{
						if (41735 - 431582 == -389847)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (51443 - 531437 != -479993)
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
									if (201813 - 397005 == -195191)
									{
										goto IL_31C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (275345 - 564618 != -289273)
									{
										goto IL_31C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (177727 - 478164 == -300436)
									{
										goto IL_31C;
									}
									bool flag = true;
									if (202410 - 271240 == -68829)
									{
										goto IL_31C;
									}
									eRace race = this.cdpuBal6Qd.Race;
									if (223606 - 515076 != -291470)
									{
										goto IL_31C;
									}
									if (race == eRace.Tails)
									{
										if (251100 - 47153 == 203948)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1B0;
										}
										if (74184 - 467105 != -392921)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (154398 - 493549 != -339150)
											{
												goto IL_1B0;
											}
											goto IL_31C;
										}
										goto IL_434;
										IL_1B0:
										flag = false;
										if (94902 - 498460 == -403557)
										{
											goto IL_31C;
										}
									}
									else if (race == eRace.Plants)
									{
										if (65120 - 434105 != -368985)
										{
											goto IL_31C;
										}
										flag = false;
										if (9137 - 448507 == -439369)
										{
											goto IL_31C;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (160128 - 560961 != -400833)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_470;
										}
										if (162815 - 92386 != 70429)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (22410 - 537174 != -514763)
											{
												goto IL_470;
											}
											goto IL_31C;
										}
										goto IL_434;
										IL_470:
										flag = false;
										if (112213 - 415938 != -303725)
										{
											goto IL_31C;
										}
									}
									else if (race == eRace.Robots)
									{
										if (155281 - 491348 != -336067)
										{
											goto IL_31C;
										}
										flag = true;
										if (19325 - 358076 != -338751)
										{
											goto IL_31C;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (41662 - 518340 == -476677)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_372;
										}
										if (243164 - 317051 == -73886)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_372;
										}
										if (241143 - 6584 == 234560)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (236935 - 120941 != 115994)
											{
												goto IL_31C;
											}
											goto IL_372;
										}
										goto IL_434;
										IL_372:
										flag = false;
										if (284764 - 159226 == 125539)
										{
											goto IL_31C;
										}
									}
									else if (race == eRace.Structure)
									{
										if (81795 - 170900 != -89105)
										{
											goto IL_31C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (24807 - 124301 == -99493)
											{
												goto IL_31C;
											}
											flag = false;
											if (222387 - 565310 == -342922)
											{
												goto IL_31C;
											}
										}
									}
									IL_434:
									if (flag)
									{
										if (45204 - 417467 != -372263)
										{
											goto IL_31C;
										}
										if (characterControl.hp > 0)
										{
											if (283652 - 158902 != 124750)
											{
												goto IL_31C;
											}
											if (characterControl.recieveTarget)
											{
												if (250800 - 157635 == 93166)
												{
													goto IL_31C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (36531 - 546276 == -509744)
													{
														goto IL_31C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (198147 - 497075 != -298928)
														{
															goto IL_31C;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (182409 - 367951 != -185542)
														{
															goto IL_31C;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (241474 - 251913 != -10439)
															{
																goto IL_31C;
															}
															this.cdpuBal6Qd.myAttackTarget = gameObject;
															if (277319 - 197224 == 80096)
															{
																goto IL_31C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (144572 - 441680 != -297108)
															{
																goto IL_31C;
															}
															this.cdpuBal6Qd.addHate(characterControl.ActorNr, 5);
															if (122950 - 525954 != -403004)
															{
																goto IL_31C;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (210757 - 332164 != -121407)
															{
																goto IL_31C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (209897 - 459924 == -250026)
															{
																goto IL_31C;
															}
															if (num < (float)60)
															{
																if (244135 - 313860 != -69725)
																{
																	goto IL_31C;
																}
																if (characterControl.hp > 0)
																{
																	if (183632 - 557066 != -373434)
																	{
																		goto IL_31C;
																	}
																	this.cdpuBal6Qd.myAttackTarget = gameObject;
																	if (198288 - 404649 == -206360)
																	{
																		goto IL_31C;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (169864 - 367125 == -197260)
																	{
																		goto IL_31C;
																	}
																	this.cdpuBal6Qd.addHate(characterControl.ActorNr, 5);
																	if (156951 - 334107 == -177155)
																	{
																		goto IL_31C;
																	}
																}
															}
														}
														if (this.cdpuBal6Qd.myAttackTarget)
														{
															if (50324 - 515249 == -464924)
															{
																goto IL_31C;
															}
															this.cdpuBal6Qd.isAlert = true;
															if (148106 - 510090 == -361983)
															{
																goto IL_31C;
															}
															this.yD1u8QKIpX = Time.time;
															if (125809 - 16852 != 108957)
															{
																goto IL_31C;
															}
														}
													}
												}
											}
										}
									}
								}
								if (70467 - 323476 == -253009)
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

	// Token: 0x06003DDD RID: 15837 RVA: 0x007F9844 File Offset: 0x007F7A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003DDE RID: 15838 RVA: 0x007F9848 File Offset: 0x007F7A48
	internal static bool nt7gfl5OXWQh34JNleFj()
	{
		return true;
	}

	// Token: 0x06003DDF RID: 15839 RVA: 0x007F984C File Offset: 0x007F7A4C
	internal static bool GJmIon5OQk0EfLGOFU3w()
	{
		return false;
	}

	// Token: 0x04004B1A RID: 19226
	private CharacterControl cdpuBal6Qd;

	// Token: 0x04004B1B RID: 19227
	private FireBot Apou04Xd5A;

	// Token: 0x04004B1C RID: 19228
	public string AI_state;

	// Token: 0x04004B1D RID: 19229
	private float yD1u8QKIpX;

	// Token: 0x04004B1E RID: 19230
	private float JH9uin1tBt;

	// Token: 0x04004B1F RID: 19231
	private float OV5uDgaN1E;
}
