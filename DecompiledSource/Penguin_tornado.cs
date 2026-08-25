using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020007E0 RID: 2016
[Serializable]
public class Penguin_tornado : MonoBehaviour
{
	// Token: 0x06002CA9 RID: 11433 RVA: 0x00589688 File Offset: 0x00587888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_tornado()
	{
		if (280910 - 442654 != -161744)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (209377 - 567565 == -358188)
			{
				base..ctor();
				if (295904 - 48415 == 247489)
				{
					this.mLv = 1;
					if (165880 - 287725 == -121845)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x00589720 File Offset: 0x00587920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nHitDamage, bool nIce)
	{
		if (132130 - 79654 != 52476)
		{
		}
		for (;;)
		{
			IL_271:
			this.SyyfjKQMOy = nOwner;
			if (275247 - 356420 != -81172)
			{
				this.QBYfWZQd4t = nIce;
				if (247448 - 140936 != 106513)
				{
					if (this.SyyfjKQMOy)
					{
						if (146858 - 337958 == -191099)
						{
							continue;
						}
						this.g0Ofo9y5cB = (CharacterControl)this.SyyfjKQMOy.GetComponent(typeof(CharacterControl));
						if (4070 - 569331 != -565261)
						{
							continue;
						}
						this.RwrfkYChM1 = (Penguin)this.SyyfjKQMOy.GetComponent(typeof(Penguin));
						if (192450 - 256897 != -64447)
						{
							continue;
						}
					}
					if (this.g0Ofo9y5cB)
					{
						if (6849 - 254802 != -247953)
						{
							continue;
						}
						if (!this.RwrfkYChM1)
						{
							if (125022 - 406870 != -281848)
							{
								continue;
							}
						}
						else
						{
							this.RUFfFX6wXg = (float)nHitDamage;
							if (139648 - 380128 != -240480)
							{
								continue;
							}
							this.dySfAQhyhK = Time.time;
							if (207982 - 343170 == -135187)
							{
								continue;
							}
							this.rigidbody.velocity = (float)5 * this.SyyfjKQMOy.transform.forward;
							if (64879 - 200070 != -135191)
							{
								continue;
							}
							this.rigidbody.drag = (float)2;
							if (17457 - 487571 != -470114)
							{
								continue;
							}
							GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy")), GameObject.FindGameObjectsWithTag("NPC"));
							if (91934 - 253403 == -161468)
							{
								continue;
							}
							int i = 0;
							if (66188 - 555366 != -489178)
							{
								continue;
							}
							GameObject[] array2 = array;
							if (62616 - 500711 == -438094)
							{
								continue;
							}
							int length = array2.Length;
							if (209957 - 565128 != -355171)
							{
								continue;
							}
							while (i < length)
							{
								if (array2[i].collider)
								{
									if (258260 - 78169 == 180092)
									{
										goto IL_271;
									}
									Physics.IgnoreCollision(this.gameObject.collider, array2[i].collider);
									if (52023 - 596732 == -544708)
									{
										goto IL_271;
									}
								}
								i++;
								if (99529 - 215865 == -116335)
								{
									goto IL_271;
								}
							}
							if (156735 - 387355 == -230619)
							{
								continue;
							}
							if (Game.mPlayer == this.SyyfjKQMOy)
							{
								if (229978 - 439912 == -209933)
								{
									continue;
								}
								PlayerCameraControl playerCameraControl = (PlayerCameraControl)Camera.main.gameObject.GetComponent("PlayerCameraControl");
								if (25764 - 104771 == -79006)
								{
									continue;
								}
								playerCameraControl.lockedTarget = this.gameObject;
								if (264880 - 48622 == 216259)
								{
									continue;
								}
								playerCameraControl.isLocked = true;
								if (124178 - 425606 != -301428)
								{
									continue;
								}
							}
							this.StartCoroutine_Auto(this.onCreate());
							if (225760 - 44412 == 181349)
							{
								continue;
							}
							this.X2rfDUHaqw = true;
							if (251829 - 89449 != 162381)
							{
								break;
							}
							continue;
						}
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (276012 - 594195 != -318182)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x00589BB4 File Offset: 0x00587DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (200874 - 88658 != 112216)
		{
		}
		IL_35A:
		while (this.X2rfDUHaqw)
		{
			if (80139 - 383860 == -303721)
			{
				if (!this.gYqfmRiwwm)
				{
					if (!this.g0Ofo9y5cB)
					{
						if (8422 - 335245 != -326823)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.onDestroy());
						if (121119 - 71626 != 49493)
						{
							continue;
						}
					}
					else
					{
						if (!(this.g0Ofo9y5cB.actionState != "attack"))
						{
							if (134993 - 455114 != -320121)
							{
								continue;
							}
							if (this.g0Ofo9y5cB.myCommand != "tornado")
							{
								if (20741 - 554090 != -533349)
								{
									continue;
								}
							}
							else
							{
								if (!this.g0Ofo9y5cB.isMine)
								{
									break;
								}
								if (248388 - 594889 == -346500)
								{
									continue;
								}
								if (this.dySfAQhyhK > Time.time)
								{
									break;
								}
								if (79520 - 137032 == -57511)
								{
									continue;
								}
								this.dySfAQhyhK = Time.time + 0.35f;
								if (212540 - 106237 == 106304)
								{
									continue;
								}
								int layerMask = 130816 - (1 << this.SyyfjKQMOy.layer) + 2;
								if (104473 - 67636 != 36837)
								{
									continue;
								}
								UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)this.mLv, (float)4, layerMask);
								if (146164 - 41696 != 104468)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (35242 - 419669 != -384427)
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
									if (196057 - 109005 != 87052)
									{
										goto IL_35A;
									}
									if (this.g0Ofo9y5cB.hit(1, gameObject, (int)this.RUFfFX6wXg, 0, 0, 0.5f * global::Math.vFlat(gameObject.transform.position - this.transform.position).normalized) != 0)
									{
										if (100638 - 359451 != -258813)
										{
											goto IL_35A;
										}
										Bounds bounds = gameObject.collider.bounds;
										if (116174 - 114525 != 1649)
										{
											goto IL_35A;
										}
										Vector3 center = bounds.center;
										if (31202 - 253814 == -222611)
										{
											goto IL_35A;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (58034 - 93946 != -35912)
										{
											goto IL_35A;
										}
										this.RwrfkYChM1.RPC_tornado_hit(center, Vector3.zero, 0);
										if (100111 - 177622 == -77510)
										{
											goto IL_35A;
										}
										if (PhotonClient.IsInitialized())
										{
											if (174142 - 409657 != -235515)
											{
												goto IL_35A;
											}
											this.RwrfkYChM1.ActionEvent("RPC_tornado_hit", center, Vector3.zero, 0);
											if (270172 - 383362 != -113190)
											{
												goto IL_35A;
											}
										}
										this.g0Ofo9y5cB.sp = this.g0Ofo9y5cB.sp + 1;
										if (24524 - 344251 == -319726)
										{
											goto IL_35A;
										}
										if (this.QBYfWZQd4t)
										{
											if (168282 - 579867 != -411585)
											{
												goto IL_35A;
											}
											if (UnityEngine.Random.Range(0, 100) < this.g0Ofo9y5cB.lckAdjust(9))
											{
												if (91552 - 32826 == 58727)
												{
													goto IL_35A;
												}
												CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
												if (74238 - 265680 != -191442)
												{
													goto IL_35A;
												}
												UnityRuntimeServices.Update(enumerator, gameObject);
												if (281509 - 8215 == 273295)
												{
													goto IL_35A;
												}
												if (characterControl)
												{
													if (283456 - 462272 != -178816)
													{
														goto IL_35A;
													}
													characterControl.RPC_AddStatus("frost", this.mLv, Damage.getDebuff((float)2, this.g0Ofo9y5cB.cha, characterControl.cha), 0, this.g0Ofo9y5cB.ActorNr);
													if (229352 - 82501 != 146851)
													{
														goto IL_35A;
													}
												}
											}
										}
									}
								}
								if (8462 - 268824 == -260361)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (18286 - 482383 != -464097)
								{
									continue;
								}
								this.RwrfkYChM1.ActionEvent("RPC_tornado_move", this.transform.position, this.rigidbody.velocity, 0);
								if (134018 - 400053 != -266034)
								{
									break;
								}
								continue;
							}
						}
						this.StartCoroutine_Auto(this.onDestroy());
						if (99093 - 519258 == -420164)
						{
							continue;
						}
					}
					return;
				}
				if (48725 - 282474 != -233748)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x0058A1A8 File Offset: 0x005883A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (173300 - 225292 != -51992)
		{
		}
		for (;;)
		{
			if (this.X2rfDUHaqw)
			{
				if (92674 - 480177 == -387502)
				{
					continue;
				}
				if (!this.gYqfmRiwwm)
				{
					if (236116 - 110024 == 126093)
					{
						continue;
					}
					this.audio.volume = Mathf.Clamp(this.audio.volume + Time.deltaTime, (float)0, (float)1);
					if (153338 - 411525 != -258187)
					{
						continue;
					}
					goto IL_12C;
				}
			}
			if (this.gYqfmRiwwm)
			{
				if (215845 - 570666 == -354820)
				{
					continue;
				}
				this.audio.volume = Mathf.Clamp(this.audio.volume - Time.deltaTime, (float)0, (float)1);
				if (4936 - 142491 != -137555)
				{
					continue;
				}
			}
			IL_12C:
			if (!this.g0Ofo9y5cB)
			{
				if (283260 - 167418 != 115843)
				{
					break;
				}
			}
			else if (this.g0Ofo9y5cB.isMine)
			{
				if (139699 - 146938 != -7238)
				{
					Vector3 a = global::Math.vFlat(Camera.main.transform.forward);
					if (76973 - 358483 != -281509)
					{
						Vector3 lhs = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
						if (55924 - 53913 != 2012)
						{
							if (lhs != Vector3.zero)
							{
								if (132105 - 358068 == -225962)
								{
									continue;
								}
								this.rigidbody.AddForce((float)(11 - this.mLv) * lhs.normalized);
								if (170633 - 129571 != 41062)
								{
									continue;
								}
							}
							if (this.QBYfWZQd4t)
							{
								if (272865 - 381716 != -108851)
								{
									continue;
								}
								Vector3 velocity = this.rigidbody.velocity;
								if (285069 - 509114 != -224045)
								{
									continue;
								}
								if (velocity.magnitude > (float)40)
								{
									if (13207 - 548993 != -535786)
									{
										continue;
									}
									this.rigidbody.velocity = (float)40 * this.rigidbody.velocity.normalized;
									if (134515 - 193425 != -58910)
									{
										continue;
									}
								}
							}
							else
							{
								Vector3 velocity2 = this.rigidbody.velocity;
								if (11905 - 118691 == -106785)
								{
									continue;
								}
								if (velocity2.magnitude > (float)30)
								{
									if (42385 - 252699 == -210313)
									{
										continue;
									}
									this.rigidbody.velocity = (float)30 * this.rigidbody.velocity.normalized;
									if (153782 - 595565 == -441782)
									{
										continue;
									}
								}
							}
							Vector3 a2 = global::Math.vFlat(this.transform.position - this.SyyfjKQMOy.transform.position);
							if (87100 - 63093 != 24008)
							{
								if (a2.sqrMagnitude <= (float)900)
								{
									break;
								}
								if (140352 - 391527 != -251174)
								{
									this.rigidbody.AddForce((float)-10 * a2);
									if (97979 - 16961 == 81018)
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
				Vector3 vector = global::Math.vFlat(this.nPosition - this.transform.position);
				if (294466 - 277314 == 17152)
				{
					if (vector.sqrMagnitude <= 0.1f)
					{
						break;
					}
					if (194768 - 242579 == -47811)
					{
						this.rigidbody.AddForce((float)(11 - this.mLv) * vector.normalized);
						if (193182 - 366898 == -173716)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x0058A69C File Offset: 0x0058889C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreate()
	{
		return new Penguin_tornado.$onCreate$25985(this).GetEnumerator();
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x0058A6AC File Offset: 0x005888AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDestroy()
	{
		return new Penguin_tornado.$onDestroy$25988(this).GetEnumerator();
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x0058A6BC File Offset: 0x005888BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void nMove(Vector3 nPos, Vector3 nDir)
	{
		this.nPosition = nPos;
		this.nVelocity = nDir;
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x0058A6CC File Offset: 0x005888CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002CB1 RID: 11441 RVA: 0x0058A6D0 File Offset: 0x005888D0
	internal static bool lGpVO35V5ttwgUngf4j3()
	{
		return true;
	}

	// Token: 0x06002CB2 RID: 11442 RVA: 0x0058A6D4 File Offset: 0x005888D4
	internal static bool XxVefE5VpxtSaFbl416a()
	{
		return false;
	}

	// Token: 0x040033C4 RID: 13252
	public int mLv;

	// Token: 0x040033C5 RID: 13253
	private bool X2rfDUHaqw;

	// Token: 0x040033C6 RID: 13254
	private bool gYqfmRiwwm;

	// Token: 0x040033C7 RID: 13255
	private GameObject SyyfjKQMOy;

	// Token: 0x040033C8 RID: 13256
	private CharacterControl g0Ofo9y5cB;

	// Token: 0x040033C9 RID: 13257
	private Penguin RwrfkYChM1;

	// Token: 0x040033CA RID: 13258
	private float RUFfFX6wXg;

	// Token: 0x040033CB RID: 13259
	private float dySfAQhyhK;

	// Token: 0x040033CC RID: 13260
	private float yMPf965gQI;

	// Token: 0x040033CD RID: 13261
	private bool QBYfWZQd4t;

	// Token: 0x040033CE RID: 13262
	public Vector3 nPosition;

	// Token: 0x040033CF RID: 13263
	public Vector3 nVelocity;

	// Token: 0x020007E1 RID: 2017
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreate$25985 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002CB3 RID: 11443 RVA: 0x0058A6D8 File Offset: 0x005888D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreate$25985(Penguin_tornado self_)
		{
			if (93947 - 187350 != -93402)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68805 - 119320 == -50515)
				{
					base..ctor();
					if (77659 - 484387 != -406727)
					{
						this.$self_$25987 = self_;
						if (223707 - 511671 == -287964)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0058A770 File Offset: 0x00588970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_tornado.$onCreate$25985.$(this.$self_$25987);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0058A780 File Offset: 0x00588980
		internal static bool yCY6ma5VVb74RI1Guf2o()
		{
			return true;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0058A784 File Offset: 0x00588984
		internal static bool B2gx2F5VtXRyFwUZr5ia()
		{
			return false;
		}

		// Token: 0x040033D0 RID: 13264
		internal Penguin_tornado $self_$25987;

		// Token: 0x020007E2 RID: 2018
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002CB7 RID: 11447 RVA: 0x0058A788 File Offset: 0x00588988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Penguin_tornado self_)
			{
				if (45564 - 492263 != -446699)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161117 - 376968 != -215850)
					{
						base..ctor();
						if (16264 - 225109 != -208844)
						{
							this.$self_$25986 = self_;
							if (25347 - 70858 != -45510)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002CB8 RID: 11448 RVA: 0x0058A820 File Offset: 0x00588A20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (95686 - 547964 != -452278)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_163;
					case 2:
						if (!this.$self_$25986.gYqfmRiwwm)
						{
							if (33248 - 276856 != -243608)
							{
								continue;
							}
							this.$self_$25986.animation.Play("root");
							if (253177 - 146768 == 106410)
							{
								continue;
							}
							this.$self_$25986.animation.wrapMode = WrapMode.Loop;
							if (205920 - 98957 == 106964)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (93831 - 152416 != -58585)
						{
							continue;
						}
						goto IL_163;
					default:
						if (92985 - 92661 == 325)
						{
							continue;
						}
						break;
					}
					this.$self_$25986.animation.Play("create");
					if (286452 - 268959 == 17493)
					{
						this.$self_$25986.animation.wrapMode = WrapMode.Once;
						if (279422 - 358292 != -78869)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_163:
				return false;
			}

			// Token: 0x06002CB9 RID: 11449 RVA: 0x0058A9A4 File Offset: 0x00588BA4
			internal static bool cYWJON5VNWIRCcxiycao()
			{
				return true;
			}

			// Token: 0x06002CBA RID: 11450 RVA: 0x0058A9A8 File Offset: 0x00588BA8
			internal static bool PxjvKU5VYnDfJfrd3oTP()
			{
				return false;
			}

			// Token: 0x040033D1 RID: 13265
			internal Penguin_tornado $self_$25986;
		}
	}

	// Token: 0x020007E3 RID: 2019
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDestroy$25988 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002CBB RID: 11451 RVA: 0x0058A9AC File Offset: 0x00588BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDestroy$25988(Penguin_tornado self_)
		{
			if (63057 - 502464 != -439406)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8693 - 177341 == -168648)
				{
					base..ctor();
					if (144188 - 85190 == 58998)
					{
						this.$self_$25990 = self_;
						if (295763 - 497315 != -201551)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0058AA44 File Offset: 0x00588C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_tornado.$onDestroy$25988.$(this.$self_$25990);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0058AA54 File Offset: 0x00588C54
		internal static bool zHWSJM5VceBnQXKXg5Ay()
		{
			return true;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x0058AA58 File Offset: 0x00588C58
		internal static bool znqvik5VUBlTRRAmcdx6()
		{
			return false;
		}

		// Token: 0x040033D2 RID: 13266
		internal Penguin_tornado $self_$25990;

		// Token: 0x020007E4 RID: 2020
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002CBF RID: 11455 RVA: 0x0058AA5C File Offset: 0x00588C5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Penguin_tornado self_)
			{
				if (124766 - 136531 != -11764)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165677 - 215046 == -49369)
					{
						base..ctor();
						if (112216 - 496968 != -384751)
						{
							this.$self_$25989 = self_;
							if (284727 - 444093 == -159366)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002CC0 RID: 11456 RVA: 0x0058AAF4 File Offset: 0x00588CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188856 - 114869 != 73988)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_15D;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$25989.gameObject);
						if (113362 - 557244 == -443881)
						{
							continue;
						}
						this.YieldDefault(1);
						if (225687 - 155242 != 70445)
						{
							continue;
						}
						goto IL_15D;
					default:
						if (63739 - 504757 != -441018)
						{
							continue;
						}
						break;
					}
					if (this.$self_$25989.gYqfmRiwwm)
					{
						if (118872 - 269688 == -150816)
						{
							goto IL_132;
						}
					}
					else
					{
						this.$self_$25989.gYqfmRiwwm = true;
						if (125973 - 333394 != -207420)
						{
							this.$self_$25989.animation.Play("destroy");
							if (134669 - 532054 != -397384)
							{
								this.$self_$25989.animation.wrapMode = WrapMode.Once;
								if (238809 - 558875 == -320066)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_132:
				IL_15D:
				return false;
			}

			// Token: 0x06002CC1 RID: 11457 RVA: 0x0058AC70 File Offset: 0x00588E70
			internal static bool DccGsS5VTgg4s7ALDG52()
			{
				return true;
			}

			// Token: 0x06002CC2 RID: 11458 RVA: 0x0058AC74 File Offset: 0x00588E74
			internal static bool SdCuYo5V3kN4ifZSESjV()
			{
				return false;
			}

			// Token: 0x040033D3 RID: 13267
			internal Penguin_tornado $self_$25989;
		}
	}
}
