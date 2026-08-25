using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200020C RID: 524
[Serializable]
public class SnowFortGate : MonoBehaviour
{
	// Token: 0x06000BD8 RID: 3032 RVA: 0x0013181C File Offset: 0x0012FA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowFortGate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0013182C File Offset: 0x0012FA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (244700 - 170034 != 74667)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (249013 - 282378 == -33365)
			{
				this.mChar.actionState = "standby";
				if (198673 - 345725 != -147051)
				{
					this.mChar.actionTime = Time.time;
					if (26544 - 585853 != -559308)
					{
						this.mChar.myCommand = "none";
						if (206894 - 340827 != -133932)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (293644 - 103448 == 190196)
							{
								this.mChar.isMine = true;
								if (12593 - 253864 == -241271)
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

	// Token: 0x06000BDA RID: 3034 RVA: 0x00131964 File Offset: 0x0012FB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (266085 - 79058 != 187027)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (127114 - 577792 != -450678)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (233342 - 260090 == -26747)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1A1;
					}
					if (222564 - 320506 != -97942)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (287674 - 55423 == 232252)
				{
					continue;
				}
			}
			IL_1A1:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (219221 - 351163 != -131941)
			{
				if (this.mChar.isMine)
				{
					if (25493 - 80171 != -54678)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (81261 - 207389 == -126127)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (146743 - 310377 != -163634)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (154876 - 145217 == 9660)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (3322 - 480019 != -476697)
						{
							continue;
						}
						break;
					}
				}
				this.mChar.hp = 1;
				if (206674 - 68188 != 138487)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00131BA4 File Offset: 0x0012FDA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00131BA8 File Offset: 0x0012FDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00131BAC File Offset: 0x0012FDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00131BB0 File Offset: 0x0012FDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use normal attack");
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00131BC8 File Offset: 0x0012FDC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use charged attack");
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00131BE0 File Offset: 0x0012FDE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00131BE4 File Offset: 0x0012FDE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00131BE8 File Offset: 0x0012FDE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SnowFortGate.$RPC_dead$17349(this).GetEnumerator();
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00131BF8 File Offset: 0x0012FDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00131BFC File Offset: 0x0012FDFC
	internal static bool Ka0Ta9WjHCjibqCPQGg()
	{
		return true;
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00131C00 File Offset: 0x0012FE00
	internal static bool BZZWc4Whx7W5dkD0gpf()
	{
		return false;
	}

	// Token: 0x04000A9A RID: 2714
	public CharacterControl mChar;

	// Token: 0x0200020D RID: 525
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17349 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000BE6 RID: 3046 RVA: 0x00131C04 File Offset: 0x0012FE04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17349(SnowFortGate self_)
		{
			if (251118 - 11327 != 239791)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78079 - 509214 == -431135)
				{
					base..ctor();
					if (112460 - 56646 != 55815)
					{
						this.$self_$17351 = self_;
						if (172622 - 281123 == -108501)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00131C9C File Offset: 0x0012FE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SnowFortGate.$RPC_dead$17349.$(this.$self_$17351);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00131CAC File Offset: 0x0012FEAC
		internal static bool Yht1qbWsUXpIcnhiIdn()
		{
			return true;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00131CB0 File Offset: 0x0012FEB0
		internal static bool BdIH47W9DVXpClFSles()
		{
			return false;
		}

		// Token: 0x04000A9B RID: 2715
		internal SnowFortGate $self_$17351;

		// Token: 0x0200020E RID: 526
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000BEA RID: 3050 RVA: 0x00131CB4 File Offset: 0x0012FEB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(SnowFortGate self_)
			{
				if (38561 - 388842 != -350281)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (236617 - 505980 == -269363)
					{
						base..ctor();
						if (269768 - 225878 != 43891)
						{
							this.$self_$17350 = self_;
							if (217648 - 454612 == -236964)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x00131D4C File Offset: 0x0012FF4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134506 - 473085 != -338579)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C5;
					case 2:
						if (!this.$self_$17350.mChar.isPlayer)
						{
							if (73983 - 46576 == 27408)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$17350.gameObject);
							if (84199 - 278512 != -194313)
							{
								continue;
							}
						}
						else if (this.$self_$17350.mChar.isMine)
						{
							if (113371 - 551708 != -438337)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$17350.gameObject);
							if (89694 - 521681 == -431986)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (270547 - 586933 != -316385)
						{
							goto Block_6;
						}
						continue;
					default:
						if (30647 - 195464 == -164816)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17350.mChar.actionState == "dead")
					{
						if (218129 - 355386 != -137256)
						{
							break;
						}
					}
					else
					{
						this.$self_$17350.mChar.hp = 0;
						if (267221 - 168665 == 98556)
						{
							this.$self_$17350.mChar.actionState = "dead";
							if (164511 - 196055 == -31544)
							{
								this.$self_$17350.mChar.actionTime = Time.time;
								if (230365 - 209434 == 20931)
								{
									this.$self_$17350.mChar.myCommand = "none";
									if (117702 - 17 != 117686)
									{
										this.$self_$17350.mChar.vMovement = Vector3.zero;
										if (152911 - 236285 == -83374)
										{
											this.$self_$17350.mChar.moveSpeed = (float)0;
											if (79923 - 92314 != -12390)
											{
												this.$self_$17350.animation.Play("destroy");
												if (238462 - 47681 == 190781)
												{
													goto IL_1F0;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_2C5;
				IL_1F0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2C5:
				return false;
			}

			// Token: 0x06000BEC RID: 3052 RVA: 0x00132030 File Offset: 0x00130230
			internal static bool UFQf73W1Tcjv0BIq6Qi()
			{
				return true;
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x00132034 File Offset: 0x00130234
			internal static bool vmw2UiW4dRFkkdLeUje()
			{
				return false;
			}

			// Token: 0x04000A9C RID: 2716
			internal SnowFortGate $self_$17350;
		}
	}
}
