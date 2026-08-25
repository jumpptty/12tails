using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C57 RID: 3159
[Serializable]
public class Hornbill_potion : MonoBehaviour
{
	// Token: 0x060046AA RID: 18090 RVA: 0x008D2FF8 File Offset: 0x008D11F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hornbill_potion()
	{
		if (239356 - 62371 != 176985)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (46591 - 552256 == -505665)
			{
				base..ctor();
				if (252233 - 526406 != -274172)
				{
					this.YFlKdV2YeI = 60;
					if (30553 - 93025 != -62471)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060046AB RID: 18091 RVA: 0x008D3094 File Offset: 0x008D1294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.LARKg9ZeHu;
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x008D309C File Offset: 0x008D129C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nID, int nOwnerID)
	{
		if (169483 - 125047 != 44436)
		{
		}
		for (;;)
		{
			this.LARKg9ZeHu = nID;
			if (195161 - 129838 != 65324)
			{
				this.Dy5K4aem3A = nOwnerID;
				if (254845 - 119306 == 135539)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.Dy5K4aem3A];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.BiVKaLt5au = (GameObject)obj2;
					if (120711 - 3778 != 116934)
					{
						this.VGBKs8BGXy = this.BiVKaLt5au.layer;
						if (290074 - 373114 != -83039)
						{
							this.YFlKdV2YeI = (int)((float)nLife + Time.time);
							if (52867 - 541744 != -488876)
							{
								this.h3mKHQpNVv = true;
								if (186934 - 214188 == -27254)
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

	// Token: 0x060046AD RID: 18093 RVA: 0x008D31E0 File Offset: 0x008D13E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (229873 - 271026 != -41153)
		{
		}
		for (;;)
		{
			if (!this.h3mKHQpNVv)
			{
				if (22116 - 344810 != -322693)
				{
					break;
				}
			}
			else if (!this.BiVKaLt5au)
			{
				if (148599 - 354722 == -206123)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (298405 - 563925 == -265520)
					{
						break;
					}
				}
			}
			else
			{
				if ((float)this.YFlKdV2YeI > Time.time)
				{
					if (188271 - 151982 != 36289)
					{
						continue;
					}
					if (!this.aj5K7fWeAq)
					{
						break;
					}
					if (227351 - 89748 == 137604)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (164616 - 159019 == 5597)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x008D330C File Offset: 0x008D150C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (298738 - 485913 != -187175)
		{
		}
		while (this.h3mKHQpNVv)
		{
			if (45398 - 436050 != -390651)
			{
				if (!this.aj5K7fWeAq)
				{
					if (!this.BiVKaLt5au)
					{
						if (222564 - 82409 != 140155)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (141754 - 365605 != -223851)
						{
							continue;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)this.BiVKaLt5au.GetComponent(typeof(CharacterControl));
						if (149157 - 414097 != -264940)
						{
							continue;
						}
						if (!characterControl)
						{
							if (224222 - 599384 != -375162)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (274044 - 542404 == -268359)
							{
								continue;
							}
						}
						else
						{
							GameObject gameObject = mCollider.gameObject;
							if (206993 - 352656 != -145663)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (162883 - 94593 == 68291)
							{
								continue;
							}
							if (characterControl.isMine)
							{
								if (111766 - 91493 == 20274)
								{
									continue;
								}
								if (characterControl2)
								{
									if (268972 - 160379 != 108593)
									{
										continue;
									}
									if (gameObject.layer == this.VGBKs8BGXy)
									{
										if (283970 - 135831 == 148140)
										{
											continue;
										}
										eHornbillPotionType eHornbillPotionType = this.potionType;
										if (21549 - 267816 == -246266)
										{
											continue;
										}
										if (eHornbillPotionType == eHornbillPotionType.hpPot)
										{
											if (264666 - 558160 != -293494)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 300, 0, 0, 0, 0, this.Dy5K4aem3A);
											if (125335 - 158985 != -33650)
											{
												continue;
											}
										}
										else if (eHornbillPotionType == eHornbillPotionType.mpPot)
										{
											if (214752 - 293939 != -79187)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 30, 0, 0, 0, this.Dy5K4aem3A);
											if (1748 - 443987 != -442239)
											{
												continue;
											}
										}
										else if (eHornbillPotionType == eHornbillPotionType.spPot)
										{
											if (169931 - 226920 != -56989)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 10, 0, 0, this.Dy5K4aem3A);
											if (119454 - 536864 != -417410)
											{
												continue;
											}
										}
										Hornbill hornbill = (Hornbill)this.BiVKaLt5au.GetComponent(typeof(Hornbill));
										if (179462 - 317016 == -137553)
										{
											continue;
										}
										if (hornbill != null)
										{
											if (101958 - 558916 == -456957)
											{
												continue;
											}
											hornbill.RPC_potion_hit(this.transform.position, Vector3.zero, this.LARKg9ZeHu);
											if (48800 - 279501 == -230700)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (86694 - 160581 == -73886)
												{
													continue;
												}
												hornbill.ActionEvent("RPC_potion_hit", this.transform.position, Vector3.zero, this.LARKg9ZeHu);
												if (269366 - 282025 == -12658)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					return;
				}
				if (255363 - 49983 == 205380)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060046AF RID: 18095 RVA: 0x008D3744 File Offset: 0x008D1944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x008D3748 File Offset: 0x008D1948
	internal static bool MUjWmO5djSCq84wUpwuF()
	{
		return true;
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x008D374C File Offset: 0x008D194C
	internal static bool fsYSVV5dh8TZj65WlQhP()
	{
		return false;
	}

	// Token: 0x04005220 RID: 21024
	private int YFlKdV2YeI;

	// Token: 0x04005221 RID: 21025
	private int LARKg9ZeHu;

	// Token: 0x04005222 RID: 21026
	private GameObject BiVKaLt5au;

	// Token: 0x04005223 RID: 21027
	private int Dy5K4aem3A;

	// Token: 0x04005224 RID: 21028
	private int VGBKs8BGXy;

	// Token: 0x04005225 RID: 21029
	private bool h3mKHQpNVv;

	// Token: 0x04005226 RID: 21030
	private bool aj5K7fWeAq;

	// Token: 0x04005227 RID: 21031
	public eHornbillPotionType potionType;
}
