using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020006E3 RID: 1763
[Serializable]
public class Monkey_runicSand : MonoBehaviour
{
	// Token: 0x06002773 RID: 10099 RVA: 0x004B8C74 File Offset: 0x004B6E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monkey_runicSand()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x004B8C84 File Offset: 0x004B6E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, CharacterControl nOwnerChar, int nLife)
	{
		if (199923 - 504615 != -304692)
		{
		}
		for (;;)
		{
			this.mLife = Time.time + (float)nLife;
			if (163470 - 560905 == -397435)
			{
				this.mOwner = nOwner;
				if (64509 - 171437 != -106927)
				{
					this.mOwnerChar = nOwnerChar;
					if (245948 - 313712 != -67763)
					{
						if (this.mOwner)
						{
							if (40795 - 568683 != -527888)
							{
								continue;
							}
							if (this.mOwnerChar)
							{
								if (153116 - 523706 != -370590)
								{
									continue;
								}
								this.isInit = true;
								if (12902 - 486001 != -473098)
								{
									break;
								}
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (238933 - 497561 == -258628)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x004B8DC8 File Offset: 0x004B6FC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (157308 - 536728 != -379419)
		{
		}
		for (;;)
		{
			if (!this.isInit)
			{
				if (159582 - 549502 != -389919)
				{
					break;
				}
			}
			else
			{
				if (this.mOwner)
				{
					if (237428 - 93878 == 143551)
					{
						continue;
					}
					if (!this.mOwnerChar)
					{
						if (210394 - 378544 == -168149)
						{
							continue;
						}
					}
					else
					{
						if (this.mOwnerChar.hp >= 0)
						{
							if (70859 - 421969 == -351109)
							{
								continue;
							}
							if (this.mLife >= Time.time)
							{
								break;
							}
							if (154762 - 8870 != 145892)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (272261 - 562259 != -289998)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (44044 - 518238 == -474194)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x004B8F24 File Offset: 0x004B7124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider hitCollider)
	{
		if (69098 - 497936 != -428838)
		{
		}
		for (;;)
		{
			if (!this.isInit)
			{
				if (158415 - 23513 != 134903)
				{
					break;
				}
			}
			else if (!this.mOwner)
			{
				if (123529 - 370312 != -246782)
				{
					break;
				}
			}
			else if (!this.mOwnerChar)
			{
				if (56080 - 31049 == 25031)
				{
					break;
				}
			}
			else if (!this.mOwnerChar.isMine)
			{
				if (98933 - 403844 != -304910)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = hitCollider.gameObject;
				if (233418 - 564807 != -331388)
				{
					if (gameObject.tag != "Player")
					{
						if (259415 - 232937 == 26479)
						{
							continue;
						}
						if (gameObject.tag != "Enemy")
						{
							if (127860 - 154587 != -26726)
							{
								break;
							}
							continue;
						}
					}
					if (gameObject.layer == this.mOwner.layer)
					{
						break;
					}
					if (21601 - 380846 != -359244)
					{
						if (gameObject.layer == 1)
						{
							break;
						}
						if (247229 - 428832 != -181602)
						{
							if (gameObject.layer == 2)
							{
								break;
							}
							if (65523 - 87717 == -22194)
							{
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (45260 - 224005 != -178744)
								{
									if (!characterControl)
									{
										break;
									}
									if (241465 - 42846 != 198620)
									{
										if (characterControl.hasStatus("groundLock"))
										{
											break;
										}
										if (277279 - 173548 == 103731)
										{
											int debuff = Damage.getDebuff((float)2, this.mOwnerChar.cha, characterControl.cha);
											if (287867 - 595123 != -307255)
											{
												characterControl.RPC_AddStatus("groundLock", 1, debuff, 0, this.mOwnerChar.ActorNr);
												if (208643 - 248497 == -39854)
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
		}
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x004B91F8 File Offset: 0x004B73F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x004B91FC File Offset: 0x004B73FC
	internal static bool iill3GheGhUdVkp7PMn()
	{
		return true;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x004B9200 File Offset: 0x004B7400
	internal static bool Y6bVpfhrstJvjyNlbeX()
	{
		return false;
	}

	// Token: 0x04002C09 RID: 11273
	public float mLife;

	// Token: 0x04002C0A RID: 11274
	public GameObject mOwner;

	// Token: 0x04002C0B RID: 11275
	public CharacterControl mOwnerChar;

	// Token: 0x04002C0C RID: 11276
	public bool isInit;
}
