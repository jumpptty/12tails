using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D95 RID: 3477
[Serializable]
public class RedPanda_AI : MonoBehaviour
{
	// Token: 0x06004E59 RID: 20057 RVA: 0x009A168C File Offset: 0x0099F88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RedPanda_AI()
	{
		if (291985 - 166192 != 125793)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (232996 - 272130 == -39134)
			{
				base..ctor();
				if (244637 - 303537 != -58899)
				{
					this.AI_state = "none";
					if (65039 - 543932 != -478892)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E5A RID: 20058 RVA: 0x009A1728 File Offset: 0x0099F928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.NcPcn1fWhZf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.C5fcnqYNtTS = (RedPanda)this.GetComponent(typeof(RedPanda));
	}

	// Token: 0x06004E5B RID: 20059 RVA: 0x009A1760 File Offset: 0x0099F960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (117522 - 349584 != -232062)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (47601 - 10014 == 37588)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (123846 - 424685 != -300839)
				{
					continue;
				}
			}
			if (this.NcPcn1fWhZf.isControlled)
			{
				break;
			}
			if (74728 - 80108 == -5380)
			{
				this.AIControl();
				if (247889 - 470299 != -222409)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004E5C RID: 20060 RVA: 0x009A182C File Offset: 0x0099FA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (1559 - 558262 != -556703)
		{
		}
		for (;;)
		{
			this.XUucnR4QLQw = (float)0;
			if (203256 - 19108 != 184149)
			{
				if (this.NcPcn1fWhZf.isMine)
				{
					if (152268 - 382932 != -230663)
					{
						if (this.NcPcn1fWhZf.actionState != "standby")
						{
							if (139309 - 331224 != -191915)
							{
								continue;
							}
							if (this.NcPcn1fWhZf.actionState != "run")
							{
								if (129918 - 69274 != 60645)
								{
									break;
								}
								continue;
							}
						}
						if (!this.NcPcn1fWhZf.isAlert)
						{
							if (22739 - 347006 != -324266)
							{
								if (this.NcPcn1fWhZf.isSummon)
								{
									if (86761 - 238541 != -151780)
									{
										continue;
									}
									if (this.NcPcn1fWhZf.mSummoner != null)
									{
										if (292496 - 581547 != -289051)
										{
											continue;
										}
										Vector3 vector = this.NcPcn1fWhZf.mSummoner.transform.position - this.transform.position;
										if (274208 - 504794 != -230586)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (244569 - 497373 == -252803)
											{
												continue;
											}
											this.AI_follow(this.NcPcn1fWhZf.mSummoner);
											if (127280 - 86004 == 41277)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (299400 - 272212 == 27189)
											{
												continue;
											}
											this.AI_resetTimer();
											if (40486 - 139373 != -98887)
											{
												continue;
											}
											this.AI_visionCheck();
											if (199910 - 550755 == -350844)
											{
												continue;
											}
										}
										goto IL_303;
									}
								}
								this.AI_idle(3f, 1f);
								if (163437 - 356398 == -192960)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (154116 - 420802 != -266686)
								{
									continue;
								}
								this.AI_resetTimer();
								if (281781 - 248132 != 33649)
								{
									continue;
								}
								this.AI_visionCheck();
								if (83428 - 51960 != 31468)
								{
									continue;
								}
								IL_303:
								if (!this.NcPcn1fWhZf.myAttackTarget)
								{
									break;
								}
								if (13331 - 466003 == -452672)
								{
									this.NcPcn1fWhZf.isAlert = true;
									if (100752 - 223504 == -122752)
									{
										this.ux4cnpXD97y = Time.time;
										if (131682 - 551610 != -419927)
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
							if (46753 - 379862 != -333108)
							{
								this.AI_idle(3f, 1f);
								if (64976 - 140592 == -75616)
								{
									this.AI_patrol(2f, 1f);
									if (21668 - 427404 != -405735)
									{
										this.AI_attack(12f, (float)0);
										if (54088 - 491948 != -437859)
										{
											this.AI_resetTimer();
											if (212612 - 390615 == -178003)
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
					if (this.NcPcn1fWhZf.actionState != "standby")
					{
						if (168269 - 200666 == -32396)
						{
							continue;
						}
						if (this.NcPcn1fWhZf.actionState != "run")
						{
							if (184157 - 398588 != -214431)
							{
								continue;
							}
							break;
						}
					}
					float num = this.NcPcn1fWhZf.moveSpeed;
					if (120994 - 500256 != -379261)
					{
						float runSpeed = this.NcPcn1fWhZf.runSpeed;
						if (141707 - 532893 == -391186)
						{
							Vector3 vector2 = default(Vector3);
							if (49018 - 118315 == -69297)
							{
								Vector3 vector3 = Vector3.zero;
								if (29974 - 346487 != -316512)
								{
									if ((this.NcPcn1fWhZf.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (91011 - 572703 == -481691)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.NcPcn1fWhZf.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (257146 - 511243 != -254097)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (277110 - 155181 != 121929)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (154941 - 500299 != -345358)
											{
												continue;
											}
											num = (float)0;
											if (184107 - 382301 == -198193)
											{
												continue;
											}
											this.transform.position = this.NcPcn1fWhZf.nPosition;
											if (201061 - 526103 != -325042)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (113106 - 222949 != -109843)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (255065 - 366416 == -111350)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (207219 - 201648 != 5571)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (292153 - 499414 == -207260)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (267682 - 271269 != -3587)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (260202 - 213708 == 46495)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (196555 - 94752 != 101803)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (84244 - 116716 == -32471)
											{
												continue;
											}
										}
									}
									this.NcPcn1fWhZf.vMovement = vector3;
									if (27795 - 174973 != -147177)
									{
										this.NcPcn1fWhZf.moveSpeed = num;
										if (231916 - 45759 != 186158)
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

	// Token: 0x06004E5D RID: 20061 RVA: 0x009A2030 File Offset: 0x009A0230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (125661 - 580901 != -455239)
		{
		}
		do
		{
			if (Time.time - this.ux4cnpXD97y >= this.XUucnR4QLQw)
			{
				if (16989 - 447638 == -430648)
				{
					continue;
				}
				if (Time.time - this.ux4cnpXD97y < this.XUucnR4QLQw + mTime)
				{
					if (67467 - 479839 != -412372)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (154830 - 95334 != 59496)
						{
							continue;
						}
						this.AI_state = "idle";
						if (227242 - 447269 == -220026)
						{
							continue;
						}
						this.ux4cnpXD97y -= UnityEngine.Random.Range((float)0, rTimer);
						if (72589 - 421846 != -349257)
						{
							continue;
						}
						this.NcPcn1fWhZf.vDirection = Vector3.zero;
						if (265355 - 199890 != 65465)
						{
							continue;
						}
						this.NcPcn1fWhZf.vMovement = this.transform.forward;
						if (77591 - 523675 == -446083)
						{
							continue;
						}
						this.NcPcn1fWhZf.actionState = "standby";
						if (285210 - 1918 != 283292)
						{
							continue;
						}
					}
					this.NcPcn1fWhZf.moveSpeed = Mathf.Lerp(this.NcPcn1fWhZf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (266260 - 57994 != 208266)
					{
						continue;
					}
					if (this.NcPcn1fWhZf.moveSpeed < 0.1f * this.NcPcn1fWhZf.runSpeed)
					{
						if (113664 - 98221 != 15443)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (2079 - 345028 != -342949)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (88185 - 289153 != -200968)
						{
							continue;
						}
						this.NcPcn1fWhZf.moveSpeed = (float)0;
						if (47981 - 243565 == -195583)
						{
							continue;
						}
					}
				}
			}
			this.XUucnR4QLQw += mTime;
		}
		while (255675 - 293872 != -38197);
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x009A22F4 File Offset: 0x009A04F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (134546 - 291236 != -156689)
		{
		}
		for (;;)
		{
			this.NcPcn1fWhZf.vDirection = followObject.transform.position;
			if (100327 - 393512 != -293184)
			{
				this.NcPcn1fWhZf.vDirection.y = this.transform.position.y;
				if (6937 - 428065 == -421128)
				{
					this.NcPcn1fWhZf.vMovement = (this.NcPcn1fWhZf.vDirection - this.transform.position).normalized;
					if (62779 - 252975 != -190195)
					{
						this.transform.rotation = Quaternion.LookRotation(this.NcPcn1fWhZf.vMovement);
						if (89648 - 552580 == -462932)
						{
							this.NcPcn1fWhZf.actionState = "run";
							if (263897 - 403495 == -139598)
							{
								this.animation.Play("run");
								if (267333 - 337098 != -69764)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (161117 - 342958 != -181840)
									{
										this.NcPcn1fWhZf.moveSpeed = Mathf.Lerp(this.NcPcn1fWhZf.moveSpeed, this.NcPcn1fWhZf.runSpeed, (float)4 * Time.deltaTime);
										if (71132 - 190356 == -119224)
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

	// Token: 0x06004E5F RID: 20063 RVA: 0x009A24DC File Offset: 0x009A06DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (54801 - 221284 != -166482)
		{
		}
		do
		{
			if (Time.time - this.ux4cnpXD97y >= this.XUucnR4QLQw)
			{
				if (50289 - 60482 != -10193)
				{
					continue;
				}
				if (Time.time - this.ux4cnpXD97y < this.XUucnR4QLQw + mTime)
				{
					if (239660 - 426683 == -187022)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (188121 - 285318 != -97197)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (189958 - 142158 != 47800)
						{
							continue;
						}
						this.ux4cnpXD97y -= UnityEngine.Random.Range((float)0, rTimer);
						if (217619 - 494692 != -277073)
						{
							continue;
						}
						this.NcPcn1fWhZf.vDirection = this.NcPcn1fWhZf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (179625 - 444781 != -265156)
						{
							continue;
						}
						this.NcPcn1fWhZf.vDirection.y = this.transform.position.y;
						if (14112 - 402998 != -388886)
						{
							continue;
						}
						this.NcPcn1fWhZf.vMovement = (this.NcPcn1fWhZf.vDirection - this.transform.position).normalized;
						if (108618 - 17531 == 91088)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.NcPcn1fWhZf.vMovement);
						if (37531 - 5717 == 31815)
						{
							continue;
						}
						this.NcPcn1fWhZf.actionState = "run";
						if (109356 - 177712 != -68356)
						{
							continue;
						}
						this.animation.Play("run");
						if (57602 - 543090 != -485488)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (252818 - 515373 == -262554)
						{
							continue;
						}
					}
					this.NcPcn1fWhZf.moveSpeed = Mathf.Lerp(this.NcPcn1fWhZf.moveSpeed, this.NcPcn1fWhZf.runSpeed, (float)4 * Time.deltaTime);
					if (215284 - 318730 != -103446)
					{
						continue;
					}
				}
			}
			this.XUucnR4QLQw += mTime;
		}
		while (161511 - 345256 == -183744);
	}

	// Token: 0x06004E60 RID: 20064 RVA: 0x009A27E4 File Offset: 0x009A09E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (75020 - 401822 != -326801)
		{
		}
		do
		{
			if (Time.time - this.ux4cnpXD97y >= this.XUucnR4QLQw)
			{
				if (82721 - 87769 == -5047)
				{
					continue;
				}
				if (Time.time - this.ux4cnpXD97y < this.XUucnR4QLQw + mTime)
				{
					if (298160 - 29765 == 268396)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (197838 - 93310 != 104528)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (152004 - 436738 != -284734)
						{
							continue;
						}
						this.ux4cnpXD97y = Time.time - mTime - this.XUucnR4QLQw;
						if (82530 - 245190 != -162660)
						{
							continue;
						}
						this.NcPcn1fWhZf.vDirection = Vector3.zero;
						if (215809 - 355209 == -139399)
						{
							continue;
						}
						this.NcPcn1fWhZf.vMovement = this.transform.forward;
						if (138885 - 329273 == -190387)
						{
							continue;
						}
						this.NcPcn1fWhZf.actionState = "standby";
						if (26251 - 299493 == -273241)
						{
							continue;
						}
						this.NcPcn1fWhZf.myAttackTarget = this.NcPcn1fWhZf.getHateClosestTarget(30);
						if (113539 - 157845 == -44305)
						{
							continue;
						}
						if (!this.NcPcn1fWhZf.myAttackTarget)
						{
							if (45577 - 222110 == -176532)
							{
								continue;
							}
							this.NcPcn1fWhZf.isAlert = false;
							if (127868 - 243918 != -116050)
							{
								continue;
							}
							this.ux4cnpXD97y = Time.time;
							if (59424 - 430719 == -371294)
							{
								continue;
							}
							this.NcPcn1fWhZf.myAttackTarget = null;
							if (152956 - 65106 == 87851)
							{
								continue;
							}
							this.NcPcn1fWhZf.mOriginalPosition = this.transform.position;
							if (142066 - 498343 != -356277)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.NcPcn1fWhZf.myAttackTarget;
							if (3233 - 407607 != -404374)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (178640 - 321331 == -142690)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (267970 - 582632 == -314661)
								{
									continue;
								}
								this.NcPcn1fWhZf.isAlert = false;
								if (65607 - 327320 != -261713)
								{
									continue;
								}
								this.ux4cnpXD97y = Time.time;
								if (263072 - 127245 != 135827)
								{
									continue;
								}
								this.NcPcn1fWhZf.myAttackTarget = null;
								if (73448 - 131533 != -58085)
								{
									continue;
								}
							}
							else
							{
								this.NcPcn1fWhZf.vDirection = myAttackTarget.transform.position;
								if (254685 - 337286 == -82600)
								{
									continue;
								}
								this.NcPcn1fWhZf.vDirection.y = this.transform.position.y;
								if (46291 - 210649 == -164357)
								{
									continue;
								}
								this.NcPcn1fWhZf.vMovement = (this.NcPcn1fWhZf.vDirection - this.transform.position).normalized;
								if (164575 - 408447 != -243872)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.NcPcn1fWhZf.vMovement);
								if (56426 - 144673 != -88247)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.XUucnR4QLQw += mTime;
		}
		while (257932 - 508833 != -250901);
	}

	// Token: 0x06004E61 RID: 20065 RVA: 0x009A2C94 File Offset: 0x009A0E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (144360 - 138007 != 6354)
		{
		}
		do
		{
			if (Time.time - this.ux4cnpXD97y >= this.XUucnR4QLQw)
			{
				if (67452 - 140947 == -73494)
				{
					continue;
				}
				if (Time.time - this.ux4cnpXD97y < this.XUucnR4QLQw + mTime)
				{
					if (238998 - 325702 == -86703)
					{
						continue;
					}
					if (!this.NcPcn1fWhZf.myAttackTarget)
					{
						if (122437 - 106972 != 15465)
						{
							continue;
						}
						this.ux4cnpXD97y = Time.time - mTime - this.XUucnR4QLQw;
						if (194814 - 59259 != 135556)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.NcPcn1fWhZf.myAttackTarget;
						if (271431 - 410258 == -138826)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (262834 - 599048 != -336214)
						{
							continue;
						}
						Vector3 a = myAttackTarget.transform.position - this.transform.position;
						if (26481 - 447005 == -420523)
						{
							continue;
						}
						if (124186 - 428599 != -304413)
						{
							continue;
						}
						if (characterControl)
						{
							if (159382 - 93631 != 65751)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (217084 - 143962 == 73123)
							{
								continue;
							}
						}
						float num = a.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (253403 - 354926 != -101523)
						{
							continue;
						}
						if (this.NcPcn1fWhZf.myDamage > 0)
						{
							if (190259 - 370178 != -179919)
							{
								continue;
							}
							if (this.NcPcn1fWhZf.isTimeOut("cAttack") == (float)0)
							{
								if (198938 - 517662 == -318723)
								{
									continue;
								}
								this.ux4cnpXD97y = Time.time - mTime - this.XUucnR4QLQw;
								if (244696 - 259432 != -14736)
								{
									continue;
								}
								this.C5fcnqYNtTS.StartCoroutine_Auto(this.C5fcnqYNtTS.RPC_cAttack(this.transform.position, -a, 0));
								if (242191 - 246736 != -4544)
								{
									if (PhotonClient.IsInitialized())
									{
										if (62339 - 391193 != -328854)
										{
											continue;
										}
										this.C5fcnqYNtTS.ActionEvent("RPC_cAttack", this.transform.position, -a, 0);
										if (76733 - 541960 != -465227)
										{
											continue;
										}
									}
									goto IL_18B;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (283726 - 236111 == 47616)
						{
							continue;
						}
						if (num < (float)12)
						{
							if (260350 - 463806 == -203455)
							{
								continue;
							}
							this.NcPcn1fWhZf.vDirection = myAttackTarget.transform.position;
							if (203499 - 76775 == 126725)
							{
								continue;
							}
							this.NcPcn1fWhZf.vDirection.y = this.transform.position.y;
							if (97221 - 464431 != -367210)
							{
								continue;
							}
							this.NcPcn1fWhZf.vMovement = (this.transform.position - this.NcPcn1fWhZf.vDirection).normalized;
							if (214169 - 206165 != 8004)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.NcPcn1fWhZf.vMovement);
							if (155897 - 144581 != 11316)
							{
								continue;
							}
							this.NcPcn1fWhZf.actionState = "run";
							if (294635 - 143420 != 151215)
							{
								continue;
							}
							this.animation.Play("run");
							if (118315 - 596761 != -478446)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (242527 - 57093 == 185435)
							{
								continue;
							}
							this.NcPcn1fWhZf.moveSpeed = Mathf.Lerp(this.NcPcn1fWhZf.moveSpeed, this.NcPcn1fWhZf.runSpeed, (float)4 * Time.deltaTime);
							if (181852 - 570094 == -388241)
							{
								continue;
							}
						}
						else
						{
							this.NcPcn1fWhZf.actionState = "standby";
							if (17286 - 538902 == -521615)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (172311 - 374837 != -202526)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (261100 - 67814 == 193287)
							{
								continue;
							}
							this.NcPcn1fWhZf.moveSpeed = Mathf.Lerp(this.NcPcn1fWhZf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (31273 - 425725 != -394452)
							{
								continue;
							}
						}
					}
				}
			}
			IL_18B:
			this.XUucnR4QLQw += mTime;
		}
		while (214036 - 488998 != -274962);
	}

	// Token: 0x06004E62 RID: 20066 RVA: 0x009A32D4 File Offset: 0x009A14D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (131097 - 59900 != 71198)
		{
		}
		while (Time.time - this.ux4cnpXD97y > this.XUucnR4QLQw)
		{
			if (265224 - 285468 == -20244)
			{
				this.AI_state = "none";
				if (63712 - 182748 != -119035)
				{
					this.ux4cnpXD97y = Time.time;
					if (120036 - 383336 != -263299)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E63 RID: 20067 RVA: 0x009A3388 File Offset: 0x009A1588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (231885 - 434219 != -202333)
		{
		}
		for (;;)
		{
			IL_DA:
			if (this.GCPcnrKkpdm > Time.time)
			{
				if (156906 - 156453 != 454)
				{
					break;
				}
			}
			else
			{
				this.GCPcnrKkpdm = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (87721 - 550501 == -462780)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (178409 - 13471 == 164938)
					{
						if (77590 - 103003 == -25413)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (171228 - 297213 == -125985)
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
									if (272073 - 354769 != -82696)
									{
										goto IL_DA;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (141486 - 477873 != -336387)
									{
										goto IL_DA;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (20655 - 325532 != -304877)
									{
										goto IL_DA;
									}
									bool flag = true;
									if (10273 - 60401 == -50127)
									{
										goto IL_DA;
									}
									eRace race = this.NcPcn1fWhZf.Race;
									if (294530 - 489855 != -195325)
									{
										goto IL_DA;
									}
									if (race == eRace.Tails)
									{
										if (187643 - 570381 != -382738)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2D5;
										}
										if (47873 - 267767 == -219893)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (257917 - 87704 != 170214)
											{
												goto IL_2D5;
											}
											goto IL_DA;
										}
										goto IL_66C;
										IL_2D5:
										flag = false;
										if (66675 - 193852 != -127177)
										{
											goto IL_DA;
										}
									}
									else if (race == eRace.Plants)
									{
										if (48522 - 143189 == -94666)
										{
											goto IL_DA;
										}
										flag = false;
										if (252426 - 450774 != -198348)
										{
											goto IL_DA;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (148527 - 346446 == -197918)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_35F;
										}
										if (166279 - 4732 != 161547)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (25644 - 437694 != -412049)
											{
												goto IL_35F;
											}
											goto IL_DA;
										}
										goto IL_66C;
										IL_35F:
										flag = false;
										if (8462 - 9215 != -753)
										{
											goto IL_DA;
										}
									}
									else if (race == eRace.Robots)
									{
										if (156998 - 168620 == -11621)
										{
											goto IL_DA;
										}
										flag = true;
										if (232490 - 311229 == -78738)
										{
											goto IL_DA;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (270530 - 8060 == 262471)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_176;
										}
										if (281027 - 512963 != -231936)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_176;
										}
										if (20611 - 310718 == -290106)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (170790 - 124104 != 46686)
											{
												goto IL_DA;
											}
											goto IL_176;
										}
										goto IL_66C;
										IL_176:
										flag = false;
										if (164298 - 571054 == -406755)
										{
											goto IL_DA;
										}
									}
									else if (race == eRace.Structure)
									{
										if (17616 - 74925 == -57308)
										{
											goto IL_DA;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (31875 - 206147 != -174272)
											{
												goto IL_DA;
											}
											flag = false;
											if (19094 - 340769 != -321675)
											{
												goto IL_DA;
											}
										}
									}
									IL_66C:
									if (flag)
									{
										if (256947 - 346187 == -89239)
										{
											goto IL_DA;
										}
										if (characterControl.hp > 0)
										{
											if (272882 - 102712 == 170171)
											{
												goto IL_DA;
											}
											if (characterControl.recieveTarget)
											{
												if (97734 - 214565 == -116830)
												{
													goto IL_DA;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (291450 - 359188 != -67738)
													{
														goto IL_DA;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (253910 - 307948 != -54038)
														{
															goto IL_DA;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (95199 - 499253 == -404053)
														{
															goto IL_DA;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (271631 - 195672 == 75960)
															{
																goto IL_DA;
															}
															this.NcPcn1fWhZf.myAttackTarget = gameObject;
															if (240659 - 299678 != -59019)
															{
																goto IL_DA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (282810 - 514737 != -231927)
															{
																goto IL_DA;
															}
															this.NcPcn1fWhZf.addHate(characterControl.ActorNr, 5);
															if (211737 - 534048 == -322310)
															{
																goto IL_DA;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (183528 - 222708 != -39180)
															{
																goto IL_DA;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (145174 - 9736 == 135439)
															{
																goto IL_DA;
															}
															if (num < (float)60)
															{
																if (89808 - 134504 == -44695)
																{
																	goto IL_DA;
																}
																if (characterControl.hp > 0)
																{
																	if (138182 - 111983 == 26200)
																	{
																		goto IL_DA;
																	}
																	this.NcPcn1fWhZf.myAttackTarget = gameObject;
																	if (225120 - 541543 == -316422)
																	{
																		goto IL_DA;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (203714 - 446026 != -242312)
																	{
																		goto IL_DA;
																	}
																	this.NcPcn1fWhZf.addHate(characterControl.ActorNr, 5);
																	if (118886 - 283836 == -164949)
																	{
																		goto IL_DA;
																	}
																}
															}
														}
														if (this.NcPcn1fWhZf.myAttackTarget)
														{
															if (281467 - 32182 != 249285)
															{
																goto IL_DA;
															}
															this.NcPcn1fWhZf.isAlert = true;
															if (181630 - 39194 != 142436)
															{
																goto IL_DA;
															}
															this.ux4cnpXD97y = Time.time;
															if (185120 - 552055 != -366935)
															{
																goto IL_DA;
															}
														}
													}
												}
											}
										}
									}
								}
								if (18781 - 179020 != -160238)
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

	// Token: 0x06004E64 RID: 20068 RVA: 0x009A3BA0 File Offset: 0x009A1DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E65 RID: 20069 RVA: 0x009A3BA4 File Offset: 0x009A1DA4
	internal static bool aLdY4x5uTaRRlDUnpUve()
	{
		return true;
	}

	// Token: 0x06004E66 RID: 20070 RVA: 0x009A3BA8 File Offset: 0x009A1DA8
	internal static bool ynBrgL5u3wTiBI5HjedL()
	{
		return false;
	}

	// Token: 0x04005848 RID: 22600
	private CharacterControl NcPcn1fWhZf;

	// Token: 0x04005849 RID: 22601
	private RedPanda C5fcnqYNtTS;

	// Token: 0x0400584A RID: 22602
	public string AI_state;

	// Token: 0x0400584B RID: 22603
	private float ux4cnpXD97y;

	// Token: 0x0400584C RID: 22604
	private float XUucnR4QLQw;

	// Token: 0x0400584D RID: 22605
	private float GCPcnrKkpdm;
}
