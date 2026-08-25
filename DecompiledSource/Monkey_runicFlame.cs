using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020006E2 RID: 1762
[Serializable]
public class Monkey_runicFlame : MonoBehaviour
{
	// Token: 0x0600276C RID: 10092 RVA: 0x004B878C File Offset: 0x004B698C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monkey_runicFlame()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x004B879C File Offset: 0x004B699C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, CharacterControl nOwnerChar, int nLife)
	{
		if (34825 - 145718 != -110893)
		{
		}
		for (;;)
		{
			this.mLife = Time.time + (float)nLife;
			if (34456 - 448763 != -414306)
			{
				this.mOwner = nOwner;
				if (103234 - 293935 == -190701)
				{
					this.mOwnerChar = nOwnerChar;
					if (101508 - 413794 != -312285)
					{
						if (this.mOwner)
						{
							if (156213 - 87038 != 69175)
							{
								continue;
							}
							if (this.mOwnerChar)
							{
								if (52674 - 457591 != -404917)
								{
									continue;
								}
								this.isInit = true;
								if (176695 - 105599 != 71096)
								{
									continue;
								}
								break;
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (243145 - 239449 != 3697)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x004B88E0 File Offset: 0x004B6AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (145860 - 561923 != -416063)
		{
		}
		for (;;)
		{
			if (!this.isInit)
			{
				if (69245 - 584853 == -515608)
				{
					break;
				}
			}
			else
			{
				if (this.mOwner)
				{
					if (193588 - 94166 == 99423)
					{
						continue;
					}
					if (!this.mOwnerChar)
					{
						if (30684 - 109406 != -78722)
						{
							continue;
						}
					}
					else
					{
						if (this.mOwnerChar.hp >= 0)
						{
							if (6399 - 370802 != -364403)
							{
								continue;
							}
							if (this.mLife >= Time.time)
							{
								break;
							}
							if (187605 - 50901 == 136705)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (172775 - 327438 != -154662)
						{
							break;
						}
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (185891 - 591588 != -405696)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x004B8A3C File Offset: 0x004B6C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider hitCollider)
	{
		if (257802 - 259535 != -1733)
		{
		}
		for (;;)
		{
			if (!this.isInit)
			{
				if (202215 - 365411 == -163196)
				{
					break;
				}
			}
			else if (!this.mOwner)
			{
				if (3160 - 512320 != -509159)
				{
					break;
				}
			}
			else if (!this.mOwnerChar)
			{
				if (146249 - 552592 != -406342)
				{
					break;
				}
			}
			else if (!this.mOwnerChar.isMine)
			{
				if (9975 - 39006 == -29031)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = hitCollider.gameObject;
				if (112837 - 265250 == -152413)
				{
					if (gameObject.tag != "Player")
					{
						if (107593 - 272410 == -164816)
						{
							continue;
						}
						if (gameObject.tag != "Enemy")
						{
							if (12637 - 492079 != -479441)
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
					if (257504 - 350116 != -92611)
					{
						if (gameObject.layer == 1)
						{
							break;
						}
						if (285406 - 478501 == -193095)
						{
							if (gameObject.layer == 2)
							{
								break;
							}
							if (39027 - 331825 != -292797)
							{
								this.mOwnerChar.hit(1, gameObject, this.mOwnerChar.talAdjust(24), 0, 0, Vector3.zero);
								if (130742 - 82635 != 48108)
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

	// Token: 0x06002770 RID: 10096 RVA: 0x004B8C68 File Offset: 0x004B6E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x004B8C6C File Offset: 0x004B6E6C
	internal static bool apY0qDhItggstkJvtDi()
	{
		return true;
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x004B8C70 File Offset: 0x004B6E70
	internal static bool N5jQVghB8prfKMBXFVZ()
	{
		return false;
	}

	// Token: 0x04002C05 RID: 11269
	public float mLife;

	// Token: 0x04002C06 RID: 11270
	public GameObject mOwner;

	// Token: 0x04002C07 RID: 11271
	public CharacterControl mOwnerChar;

	// Token: 0x04002C08 RID: 11272
	public bool isInit;
}
