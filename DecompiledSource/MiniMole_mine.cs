using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000CF8 RID: 3320
[Serializable]
public class MiniMole_mine : MonoBehaviour
{
	// Token: 0x06004A92 RID: 19090 RVA: 0x0093D3BC File Offset: 0x0093B5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniMole_mine()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x0093D3CC File Offset: 0x0093B5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.Iw0c5aZT9gj;
	}

	// Token: 0x06004A94 RID: 19092 RVA: 0x0093D3D4 File Offset: 0x0093B5D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nID, int nOwnerID)
	{
		if (213652 - 289736 != -76084)
		{
		}
		for (;;)
		{
			IL_7F:
			this.Iw0c5aZT9gj = nID;
			if (108848 - 230488 == -121640)
			{
				this.uj5c54Yx6Xf = nOwnerID;
				if (83031 - 21716 == 61315)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.uj5c54Yx6Xf];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.wr2c5ZWFrUo = (GameObject)obj2;
					if (67211 - 407320 == -340109)
					{
						this.Jpkc5sK1WDQ = this.wr2c5ZWFrUo.layer;
						if (86541 - 384859 == -298318)
						{
							this.G7lc5Cmong3 = (CharacterControl)this.wr2c5ZWFrUo.GetComponent(typeof(CharacterControl));
							if (181750 - 58157 != 123594)
							{
								this.oCpc5gcefgg = (int)((float)60 + Time.time);
								if (261042 - 587624 != -326581)
								{
									if (Game.mPlayer)
									{
										if (30509 - 469297 == -438787)
										{
											continue;
										}
										if (Game.mPlayer.layer != this.wr2c5ZWFrUo.layer)
										{
											if (109866 - 1726 != 108140)
											{
												continue;
											}
											Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
											if (294242 - 379965 == -85722)
											{
												continue;
											}
											int i = 0;
											if (63354 - 298177 == -234822)
											{
												continue;
											}
											Component[] array = componentsInChildren;
											if (59205 - 313234 == -254028)
											{
												continue;
											}
											int length = array.Length;
											if (102890 - 168787 == -65896)
											{
												continue;
											}
											while (i < length)
											{
												((Renderer)array[i]).enabled = false;
												if (188671 - 341785 != -153114)
												{
													goto IL_7F;
												}
												i++;
												if (229627 - 367589 != -137962)
												{
													goto IL_7F;
												}
											}
											if (243167 - 361853 != -118686)
											{
												continue;
											}
										}
									}
									this.KZIc5HO6YpO = true;
									if (201172 - 232467 == -31295)
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

	// Token: 0x06004A95 RID: 19093 RVA: 0x0093D6A8 File Offset: 0x0093B8A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (256883 - 437434 != -180550)
		{
		}
		for (;;)
		{
			if (!this.KZIc5HO6YpO)
			{
				if (62791 - 166092 != -103300)
				{
					break;
				}
			}
			else
			{
				if ((float)this.oCpc5gcefgg <= Time.time)
				{
					if (278517 - 299997 != -21480)
					{
						continue;
					}
					if (!this.IMgc57utJPR)
					{
						if (144930 - 484146 != -339216)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (11609 - 52575 != -40965)
						{
							break;
						}
						continue;
					}
				}
				if (!this.wr2c5ZWFrUo)
				{
					if (5037 - 182336 != -177298)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (180844 - 594162 != -413317)
						{
							break;
						}
					}
				}
				else if (!this.G7lc5Cmong3)
				{
					if (94015 - 211832 == -117817)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (195987 - 131400 == 64587)
						{
							break;
						}
					}
				}
				else
				{
					if (this.G7lc5Cmong3.hp > 0)
					{
						break;
					}
					if (14347 - 211457 != -197109)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (218263 - 163789 == 54474)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004A96 RID: 19094 RVA: 0x0093D87C File Offset: 0x0093BA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnTriggerEnter(Collider mCollider)
	{
		return new MiniMole_mine.$OnTriggerEnter$32808(mCollider, this).GetEnumerator();
	}

	// Token: 0x06004A97 RID: 19095 RVA: 0x0093D88C File Offset: 0x0093BA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x0093D890 File Offset: 0x0093BA90
	internal static bool MTLR1h5qNjOqD1TEQeJm()
	{
		return true;
	}

	// Token: 0x06004A99 RID: 19097 RVA: 0x0093D894 File Offset: 0x0093BA94
	internal static bool kNTmNw5qYBCVhmS1JRNZ()
	{
		return false;
	}

	// Token: 0x04005545 RID: 21829
	private int oCpc5gcefgg;

	// Token: 0x04005546 RID: 21830
	private int Iw0c5aZT9gj;

	// Token: 0x04005547 RID: 21831
	private int uj5c54Yx6Xf;

	// Token: 0x04005548 RID: 21832
	private int Jpkc5sK1WDQ;

	// Token: 0x04005549 RID: 21833
	private bool KZIc5HO6YpO;

	// Token: 0x0400554A RID: 21834
	private bool IMgc57utJPR;

	// Token: 0x0400554B RID: 21835
	private GameObject wr2c5ZWFrUo;

	// Token: 0x0400554C RID: 21836
	private CharacterControl G7lc5Cmong3;

	// Token: 0x0400554D RID: 21837
	public mMiniMineType mType;

	// Token: 0x02000CF9 RID: 3321
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnTriggerEnter$32808 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A9A RID: 19098 RVA: 0x0093D898 File Offset: 0x0093BA98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnTriggerEnter$32808(Collider mCollider, MiniMole_mine self_)
		{
			if (145783 - 311652 != -165868)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57971 - 287089 != -229117)
				{
					base..ctor();
					if (229720 - 124455 != 105266)
					{
						this.$mCollider$32813 = mCollider;
						if (236192 - 125109 == 111083)
						{
							this.$self_$32814 = self_;
							if (59216 - 368476 == -309260)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x0093D954 File Offset: 0x0093BB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniMole_mine.$OnTriggerEnter$32808.$(this.$mCollider$32813, this.$self_$32814);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x0093D968 File Offset: 0x0093BB68
		internal static bool Un8o715qcST136nd5L0F()
		{
			return true;
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x0093D96C File Offset: 0x0093BB6C
		internal static bool tJBJsm5qUvvZs1QTjXsA()
		{
			return false;
		}

		// Token: 0x0400554E RID: 21838
		internal Collider $mCollider$32813;

		// Token: 0x0400554F RID: 21839
		internal MiniMole_mine $self_$32814;

		// Token: 0x02000CFA RID: 3322
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A9E RID: 19102 RVA: 0x0093D970 File Offset: 0x0093BB70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Collider mCollider, MiniMole_mine self_)
			{
				if (267570 - 2067 != 265504)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (192972 - 516169 == -323197)
					{
						base..ctor();
						if (211394 - 181823 == 29571)
						{
							this.$mCollider$32811 = mCollider;
							if (92411 - 534806 != -442394)
							{
								this.$self_$32812 = self_;
								if (271745 - 275065 != -3319)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A9F RID: 19103 RVA: 0x0093DA2C File Offset: 0x0093BC2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (168448 - 159948 != 8501)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BA;
					case 2:
						this.$mMiniMoleScript$32810 = (MiniMole)this.$self_$32812.wr2c5ZWFrUo.GetComponent(typeof(MiniMole));
						if (23900 - 582347 != -558447)
						{
							continue;
						}
						if (!this.$mMiniMoleScript$32810)
						{
							goto IL_195;
						}
						if (148630 - 158376 != -9746)
						{
							continue;
						}
						if (this.$self_$32812.mType == mMiniMineType.mine)
						{
							if (295098 - 81263 == 213836)
							{
								continue;
							}
							this.$mMiniMoleScript$32810.RPC_mine_hit(this.$self_$32812.transform.position, Vector3.zero, this.$self_$32812.Iw0c5aZT9gj);
							if (292592 - 326848 != -34256)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (63147 - 383293 != -320146)
								{
									continue;
								}
								this.$mMiniMoleScript$32810.ActionEvent("RPC_mine_hit", this.$self_$32812.transform.position, Vector3.zero, this.$self_$32812.Iw0c5aZT9gj);
								if (68837 - 59363 != 9474)
								{
									continue;
								}
							}
							goto IL_195;
						}
						else
						{
							this.$mMiniMoleScript$32810.RPC_stunMine_hit(this.$self_$32812.transform.position, Vector3.zero, this.$self_$32812.Iw0c5aZT9gj);
							if (165221 - 214194 != -48973)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_195;
							}
							if (161236 - 561014 != -399778)
							{
								continue;
							}
							this.$mMiniMoleScript$32810.ActionEvent("RPC_stunMine_hit", this.$self_$32812.transform.position, Vector3.zero, this.$self_$32812.Iw0c5aZT9gj);
							if (180603 - 388428 != -207825)
							{
								continue;
							}
							goto IL_195;
						}
						break;
					default:
						if (113115 - 73704 != 39411)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$32812.KZIc5HO6YpO)
					{
						break;
					}
					if (49555 - 299658 != -250103)
					{
						continue;
					}
					if (this.$self_$32812.IMgc57utJPR)
					{
						if (195044 - 468006 != -272962)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$self_$32812.wr2c5ZWFrUo)
						{
							if (155250 - 381179 == -225928)
							{
								continue;
							}
							if (!this.$self_$32812.G7lc5Cmong3)
							{
								if (190339 - 566829 == -376489)
								{
									continue;
								}
							}
							else if (!this.$self_$32812.G7lc5Cmong3.isMine)
							{
								if (104576 - 108133 != -3556)
								{
									break;
								}
								continue;
							}
							else
							{
								this.$mCollideObject$32809 = this.$mCollider$32811.gameObject;
								if (242087 - 295889 == -53801)
								{
									continue;
								}
								if (!(this.$mCollideObject$32809.tag == "Player"))
								{
									if (128342 - 15477 == 112866)
									{
										continue;
									}
									if (!(this.$mCollideObject$32809.tag == "Enemy"))
									{
										goto IL_195;
									}
									if (246036 - 358203 != -112167)
									{
										continue;
									}
								}
								if (this.$mCollideObject$32809.layer == this.$self_$32812.Jpkc5sK1WDQ)
								{
									goto IL_195;
								}
								if (138716 - 138171 == 546)
								{
									continue;
								}
								if (this.$mCollideObject$32809.layer <= 2)
								{
									if (227786 - 181787 != 46000)
									{
										break;
									}
									continue;
								}
								else
								{
									this.$self_$32812.IMgc57utJPR = true;
									if (181562 - 219227 != -37665)
									{
										continue;
									}
									goto IL_465;
								}
							}
						}
						UnityEngine.Object.Destroy(this.$self_$32812.gameObject);
						if (180312 - 206839 != -26526)
						{
							break;
						}
						continue;
					}
					IL_195:
					this.YieldDefault(1);
				}
				while (276117 - 363907 != -87790);
				goto IL_4BA;
				IL_465:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4BA:
				return false;
			}

			// Token: 0x06004AA0 RID: 19104 RVA: 0x0093DF08 File Offset: 0x0093C108
			internal static bool Fh3wcI5qTL0HGk4bg9kW()
			{
				return true;
			}

			// Token: 0x06004AA1 RID: 19105 RVA: 0x0093DF0C File Offset: 0x0093C10C
			internal static bool MaaqgF5q31k6VFrvgafB()
			{
				return false;
			}

			// Token: 0x04005550 RID: 21840
			internal GameObject $mCollideObject$32809;

			// Token: 0x04005551 RID: 21841
			internal MiniMole $mMiniMoleScript$32810;

			// Token: 0x04005552 RID: 21842
			internal Collider $mCollider$32811;

			// Token: 0x04005553 RID: 21843
			internal MiniMole_mine $self_$32812;
		}
	}
}
