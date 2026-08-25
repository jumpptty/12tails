using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020008D0 RID: 2256
[Serializable]
public class Sheep_edenSanctuary : MonoBehaviour
{
	// Token: 0x060031A4 RID: 12708 RVA: 0x00651810 File Offset: 0x0064FA10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sheep_edenSanctuary()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x00651820 File Offset: 0x0064FA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitEdenSanctuary(int nOwnerID)
	{
		if (48435 - 521705 != -473269)
		{
		}
		for (;;)
		{
			this.DCpBgPGQah = nOwnerID;
			if (38914 - 411127 != -372212)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[this.DCpBgPGQah];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				this.CFUBaUkeWU = (GameObject)obj2;
				if (15766 - 311079 == -295313)
				{
					if (this.CFUBaUkeWU)
					{
						if (230270 - 252470 == -22199)
						{
							continue;
						}
						this.v30B4uPQR5 = (CharacterControl)this.CFUBaUkeWU.GetComponent(typeof(CharacterControl));
						if (216408 - 317720 == -101311)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find sanctuary's owner");
						if (137036 - 355310 == -218273)
						{
							continue;
						}
					}
					this.animation.Play("create");
					if (86593 - 443512 != -356918)
					{
						this.animation.wrapMode = WrapMode.Once;
						if (281828 - 369171 == -87343)
						{
							this.B4SBHIwDwq = true;
							if (118655 - 243225 == -124570)
							{
								this.rKABs8tDiX = Time.time + (float)12;
								if (38513 - 150150 == -111637)
								{
									this.dhABZk6bhm = Time.time + 0.5f;
									if (67162 - 575067 != -507904)
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

	// Token: 0x060031A6 RID: 12710 RVA: 0x00651A20 File Offset: 0x0064FC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (71440 - 116945 != -45504)
		{
		}
		for (;;)
		{
			IL_1CC:
			if (!this.B4SBHIwDwq)
			{
				if (136207 - 593738 != -457530)
				{
					break;
				}
			}
			else if (this.OZWB7U922k)
			{
				if (186649 - 119408 == 67241)
				{
					break;
				}
			}
			else
			{
				if (this.CFUBaUkeWU)
				{
					if (148833 - 488892 == -340058)
					{
						continue;
					}
					if (!this.v30B4uPQR5)
					{
						if (12391 - 292286 == -279894)
						{
							continue;
						}
					}
					else if (this.rKABs8tDiX < Time.time)
					{
						if (239229 - 445102 == -205872)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.DestroySanctuary());
						if (248802 - 138948 != 109855)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.dhABZk6bhm >= Time.time)
						{
							break;
						}
						if (297947 - 198792 != 99155)
						{
							continue;
						}
						if (!this.v30B4uPQR5.isMine)
						{
							break;
						}
						if (173649 - 355266 == -181616)
						{
							continue;
						}
						this.dhABZk6bhm = Time.time + (float)2;
						if (270599 - 2734 == 267866)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)18, (float)6, 130816);
						if (33490 - 413375 == -379884)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (41972 - 373572 != -331600)
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
							if (32045 - 413192 != -381147)
							{
								goto IL_1CC;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (195619 - 299887 == -104267)
							{
								goto IL_1CC;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (204313 - 235486 != -31173)
							{
								goto IL_1CC;
							}
							if (characterControl)
							{
								if (236914 - 405699 != -168785)
								{
									goto IL_1CC;
								}
								characterControl.RPC_AddStatus("sanctuary", 5, 3, 0, this.v30B4uPQR5.ActorNr);
								if (151180 - 70837 == 80344)
								{
									goto IL_1CC;
								}
							}
						}
						if (238000 - 162516 != 75485)
						{
							break;
						}
						continue;
					}
				}
				this.StartCoroutine_Auto(this.DestroySanctuary());
				if (64640 - 400263 != -335622)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060031A7 RID: 12711 RVA: 0x00651D68 File Offset: 0x0064FF68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator DestroySanctuary()
	{
		return new Sheep_edenSanctuary.$DestroySanctuary$27682(this).GetEnumerator();
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x00651D78 File Offset: 0x0064FF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x00651D7C File Offset: 0x0064FF7C
	internal static bool LwR36953PJD20bVPVWPS()
	{
		return true;
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x00651D80 File Offset: 0x0064FF80
	internal static bool WJwRaE530AwilQjGKXQF()
	{
		return false;
	}

	// Token: 0x04003C0A RID: 15370
	private int DCpBgPGQah;

	// Token: 0x04003C0B RID: 15371
	private GameObject CFUBaUkeWU;

	// Token: 0x04003C0C RID: 15372
	private CharacterControl v30B4uPQR5;

	// Token: 0x04003C0D RID: 15373
	private float rKABs8tDiX;

	// Token: 0x04003C0E RID: 15374
	private bool B4SBHIwDwq;

	// Token: 0x04003C0F RID: 15375
	private bool OZWB7U922k;

	// Token: 0x04003C10 RID: 15376
	private float dhABZk6bhm;

	// Token: 0x020008D1 RID: 2257
	[CompilerGenerated]
	[Serializable]
	internal sealed class $DestroySanctuary$27682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060031AB RID: 12715 RVA: 0x00651D84 File Offset: 0x0064FF84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $DestroySanctuary$27682(Sheep_edenSanctuary self_)
		{
			if (243212 - 147930 != 95283)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61781 - 409686 == -347905)
				{
					base..ctor();
					if (291991 - 37296 != 254696)
					{
						this.$self_$27684 = self_;
						if (276398 - 151856 == 124542)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00651E1C File Offset: 0x0065001C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Sheep_edenSanctuary.$DestroySanctuary$27682.$(this.$self_$27684);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x00651E2C File Offset: 0x0065002C
		internal static bool H4ydL753bWlwVt3A3wFu()
		{
			return true;
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x00651E30 File Offset: 0x00650030
		internal static bool kAk89k53un5PkrrvcAp8()
		{
			return false;
		}

		// Token: 0x04003C11 RID: 15377
		internal Sheep_edenSanctuary $self_$27684;

		// Token: 0x020008D2 RID: 2258
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060031AF RID: 12719 RVA: 0x00651E34 File Offset: 0x00650034
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Sheep_edenSanctuary self_)
			{
				if (119992 - 332491 != -212498)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149245 - 145546 != 3700)
					{
						base..ctor();
						if (188202 - 16301 != 171902)
						{
							this.$self_$27683 = self_;
							if (116905 - 22915 == 93990)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060031B0 RID: 12720 RVA: 0x00651ECC File Offset: 0x006500CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85994 - 131085 != -45091)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_190;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$27683.gameObject);
						if (227797 - 280129 != -52332)
						{
							continue;
						}
						this.YieldDefault(1);
						if (23709 - 485007 != -461298)
						{
							continue;
						}
						goto IL_190;
					default:
						if (65071 - 264030 == -198958)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$27683.B4SBHIwDwq)
					{
						if (218675 - 422195 != -203519)
						{
							break;
						}
					}
					else if (this.$self_$27683.OZWB7U922k)
					{
						if (290632 - 340327 == -49695)
						{
							break;
						}
					}
					else
					{
						this.$self_$27683.OZWB7U922k = true;
						if (68480 - 487060 != -418579)
						{
							this.$self_$27683.animation.CrossFade("destroy", 0.2f);
							if (230282 - 305139 == -74857)
							{
								this.$self_$27683.animation.wrapMode = WrapMode.Once;
								if (1129 - 476504 == -475375)
								{
									goto IL_150;
								}
							}
						}
					}
				}
				goto IL_190;
				IL_150:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_190:
				return false;
			}

			// Token: 0x060031B1 RID: 12721 RVA: 0x0065207C File Offset: 0x0065027C
			internal static bool zgrZEo53IFgc9omIWJH9()
			{
				return true;
			}

			// Token: 0x060031B2 RID: 12722 RVA: 0x00652080 File Offset: 0x00650280
			internal static bool UExiQB53Bhl7f9AQoq6e()
			{
				return false;
			}

			// Token: 0x04003C12 RID: 15378
			internal Sheep_edenSanctuary $self_$27683;
		}
	}
}
